namespace Wintellect.PowerCollections
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    using Wintellect.PowerCollections;

    class ShoppingCenterMain
    {
        static void Main()
        {
            var store = new ShoppingCenter();
            int commandsCount = int.Parse(Console.ReadLine());

            var regex = new Regex(@"(\w+) ([\w \d]+)*;*(.*);?([\w ]*)");

            for (int i = 0; i < commandsCount; i++)
            {
                string commandLine = Console.ReadLine();
                var commandParams = regex.Match(commandLine);

                string commandName = commandParams.Groups[1].Value;
                string productName = string.Empty;
                double productPrice = 0.0;
                string productProducer = string.Empty;

                switch (commandName)
                {
                    case "AddProduct":
                        productName = commandParams.Groups[2].Value;
                        string[] priceAndProducer = commandParams.Groups[3].Value.Split(';');
                        productPrice = double.Parse(priceAndProducer[0]);
                        productProducer = priceAndProducer[1];

                        store.AddProduct(productName, productPrice, productProducer);
                        Console.WriteLine("Product added");
                        break;
                    case "DeleteProducts":
                        int productsDeletedCount = 0;

                        if (commandParams.Groups[3].Value == string.Empty)
                        {
                            productProducer = commandParams.Groups[2].Value;
                            productsDeletedCount = store.DeleteProducts(productProducer);
                        }
                        else
                        {
                            productName = commandParams.Groups[2].Value;
                            productProducer = commandParams.Groups[3].Value;
                            productsDeletedCount = store.DeleteProducts(productName, productProducer);
                        }

                        Console.WriteLine(
                            productsDeletedCount == 0 ? 
                                "No products found" : 
                                productsDeletedCount + " products deleted");
                        break;
                    case "FindProductsByName":
                        productName = commandParams.Groups[2].Value;
                        var productsByName = store.FindProductsByName(productName);

                        if (! productsByName.Any())
                        {
                            Console.WriteLine("No products found");
                            break;
                        }

                        foreach (var product in productsByName)
                        {
                            Console.WriteLine(product);
                        }

                        break;
                    case "FindProductsByProducer":
                        productProducer = commandParams.Groups[2].Value;
                        var productsByProducer = store.FindProductsByProducer(productProducer);

                        if (!productsByProducer.Any())
                        {
                            Console.WriteLine("No products found");
                            break;
                        }

                        foreach (var product in productsByProducer)
                        {
                            Console.WriteLine(product);
                        }

                        break;
                    case "FindProductsByPriceRange":
                        var prices = commandLine.Substring(commandLine.LastIndexOf(' ')).Split(';');
                        double minPrice = double.Parse(prices[0]);
                        double maxPrice = double.Parse(prices[1]);

                        var productsInPriceRange = store.FindProducts(minPrice, maxPrice);

                        if (! productsInPriceRange.Any())
                        {
                            Console.WriteLine("No products found");
                            break;
                        }

                        foreach (var product in productsInPriceRange)
                        {
                            Console.WriteLine(product);
                        }

                        break;
                }
            }
        }
    }

    class ShoppingCenter
    {
        private Dictionary<string, OrderedBag<Product>> productsByProducer; 
        private Dictionary<string, OrderedBag<Product>> productsByName; 
        private Dictionary<string, OrderedBag<Product>> productsByNameAndProducer;
        private OrderedDictionary<double, Bag<Product>> productsOrderedByPrice;

        public ShoppingCenter()
        {
            this.productsByProducer = new Dictionary<string, OrderedBag<Product>>();
            this.productsByName = new Dictionary<string, OrderedBag<Product>>();
            this.productsByNameAndProducer = new Dictionary<string, OrderedBag<Product>>();
            this.productsOrderedByPrice = new OrderedDictionary<double, Bag<Product>>();
        }  

        public void AddProduct(string name, double price, string producer)
        {
            var product = new Product(name, price, producer);
            var nameAndProducer = name + " | " + producer;

            if (!this.productsByProducer.ContainsKey(producer))
            {
                this.productsByProducer[producer] = new OrderedBag<Product>();
            }

            this.productsByProducer[producer].Add(product);

            if (! this.productsByName.ContainsKey(name))
            {
                this.productsByName[name] = new OrderedBag<Product>();
            }

            this.productsByName[name].Add(product);

            if (! this.productsByNameAndProducer.ContainsKey(nameAndProducer))
            {
                this.productsByNameAndProducer[nameAndProducer] = new OrderedBag<Product>();
            }

            this.productsByNameAndProducer[nameAndProducer].Add(product);

            if (! this.productsOrderedByPrice.ContainsKey(price))
            {
                this.productsOrderedByPrice[price] = new Bag<Product>();
            }

            this.productsOrderedByPrice[price].Add(product);
        }

        public int DeleteProducts(string producer)
        {
            int productsDeletedCount = 0;

            if (!this.productsByProducer.ContainsKey(producer))
            {
                return productsDeletedCount;
            }

            var productsToDelete = this.productsByProducer[producer];
            foreach (var product in productsToDelete)
            {
                var nameToDelete = product.Name;
                var nameProducer = nameToDelete + " | " + producer;
                var price = product.Price;

                this.productsByName[nameToDelete].Remove(product);
                this.productsByNameAndProducer[nameProducer].Remove(product);
                this.productsOrderedByPrice[price].Remove(product);
            }

            productsDeletedCount = this.productsByProducer[producer].Count;
            this.productsByProducer.Remove(producer);

            return productsDeletedCount;
        }

        public int DeleteProducts(string name, string producer)
        {
            int productsDeletedCount = 0;
            var nameAndProducerKey = name + " | " + producer;
            if (! this.productsByNameAndProducer.ContainsKey(nameAndProducerKey))
            {
                return productsDeletedCount;
            }

            var productsToDelete = this.productsByNameAndProducer[nameAndProducerKey];
            foreach (var product in productsToDelete)
            {
                var price = product.Price;
                this.productsOrderedByPrice[price].Remove(product);
            }

            this.productsByName.Remove(name);
            this.productsByProducer.Remove(producer);
            productsDeletedCount = this.productsByNameAndProducer[nameAndProducerKey].Count;
            this.productsByNameAndProducer.Remove(nameAndProducerKey);

            return productsDeletedCount;
        }

        public IEnumerable<Product> FindProductsByName(string name)
        {
            if (! this.productsByName.ContainsKey(name))
            {
                return new Product[0];
            }

            return this.productsByName[name];
        }

        public IEnumerable<Product> FindProductsByProducer(string producer)
        {
            if (!this.productsByProducer.ContainsKey(producer))
            {
                return new Product[0];
            }

            return this.productsByProducer[producer];
        }

        public IEnumerable<Product> FindProducts(double minPrice, double maxPrice)
        {
            var orderedProducts = new OrderedBag<Product>();
            var productsInRange = this.productsOrderedByPrice.Range(minPrice, true, maxPrice, true);
        
            orderedProducts.AddMany(productsInRange.Values.SelectMany(p => p));

            return orderedProducts;
        }
    }

    class Product : IComparable<Product>
    {
        public Product(string name, double price, string producer)
        {
            this.Name = name;
            this.Price = price;
            this.Producer = producer;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Producer { get; set; }

        public int CompareTo(Product other)
        {
            if (this.Name != other.Name)
            {
                return this.Name.CompareTo(other.Name);
            }

            if (this.Producer != other.Producer)
            {
                return this.Producer.CompareTo(other.Producer);
            }

            return this.Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return string.Format("{{{0};{1};{2:0.00}}}", this.Name, this.Producer, this.Price);
        }
    }
}