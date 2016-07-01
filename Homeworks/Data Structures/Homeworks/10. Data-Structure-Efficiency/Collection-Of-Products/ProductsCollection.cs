using System.Collections.Generic;
using System.Linq;

using Wintellect.PowerCollections;

public class ProductsCollection
{
    private Dictionary<int, Product> productsById;
    private OrderedDictionary<decimal, SortedSet<Product>> productsByPrice;
    private Dictionary<string, SortedSet<Product>> productsByTitle;
    private Dictionary<string, OrderedDictionary<decimal, SortedSet<Product>>> productsByTitleAndPrice;
    private Dictionary<string, OrderedDictionary<decimal, SortedSet<Product>>> productsBySuplierAndPrice;

    public ProductsCollection()
    {
        this.productsById = new Dictionary<int, Product>();
        this.productsByPrice = new OrderedDictionary<decimal, SortedSet<Product>>();
        this.productsByTitle = new Dictionary<string, SortedSet<Product>>();
        this.productsByTitleAndPrice = new Dictionary<string, OrderedDictionary<decimal, SortedSet<Product>>>();
        this.productsBySuplierAndPrice = new Dictionary<string, OrderedDictionary<decimal, SortedSet<Product>>>();
    }

    public int Count => this.productsById.Count;

    public void Add(int id, string title, string suplier, decimal price)
    {
        this.Remove(id);

        this.AddProduct(id, title, suplier, price);
    }

    public bool Remove(int id)
    {
        if (!this.productsById.ContainsKey(id))
        {
            return false;
        }

        var productToRemove = this.productsById[id];
        var title = productToRemove.Title;
        var suplier = productToRemove.Suplier;
        var price = productToRemove.Price;

        this.productsById.Remove(id);
        this.productsByPrice[price].Remove(productToRemove);
        this.productsByTitle[title].Remove(productToRemove);
        this.productsByTitleAndPrice[title][price].Remove(productToRemove);
        this.productsBySuplierAndPrice[suplier][price].Remove(productToRemove);

        return true;
    }

    public IEnumerable<Product> FindProductsByTitle(string title)
    {
        bool productsWithTitleExist = this.productsByTitle.ContainsKey(title);
        if (! productsWithTitleExist)
        {
            yield break;
        }

        foreach (var product in this.productsByTitle[title])
        {
            yield return product;
        }
    }

    public IEnumerable<Product> FindProductsByTitleAndPrice(string title, decimal price)
    {
        if (! this.productsByTitleAndPrice.ContainsKey(title) || ! this.productsByTitleAndPrice[title].ContainsKey(price))
        {
            yield break;
        }

        foreach (var product in this.productsByTitleAndPrice[title][price])
        {
            yield return product;
        }
    }

    public IEnumerable<Product> FindProductsByPriceRange(decimal minPrice, decimal maxPrice)
    {
        var filteredByPriceRange = this.productsByPrice.Range(minPrice, true, maxPrice, true).Values.SelectMany(p => p);

        // TODO: this is slow. Think of better way to extract the products ordered by ID
        OrderedSet<Product> result = new OrderedSet<Product>(filteredByPriceRange);

        return result;
    }

    public IEnumerable<Product> FindProductsTitleAndPriceRange(
        string title,
        decimal minPrice,
        decimal maxPrice)
    {
        bool productsWithTitleExist = this.productsByTitleAndPrice.ContainsKey(title);
        if (!productsWithTitleExist)
        {
            yield break;
        }

        var filteredByTittleAndPriceRange =
            this.productsByTitleAndPrice[title].Range(minPrice, true, maxPrice, true).Values.SelectMany(p => p);
        var result = new OrderedSet<Product>(filteredByTittleAndPriceRange);

        foreach (var product in result)
        {
            yield return product;
        }
    }

    public IEnumerable<Product> FindProductsBySupplierAndPrice(string supplier, decimal price)
    {
        if (! this.productsBySuplierAndPrice.ContainsKey(supplier) || 
            ! this.productsBySuplierAndPrice[supplier].ContainsKey(price))
        {
            yield break;
        }

        foreach (var product in this.productsBySuplierAndPrice[supplier][price])
        {
            yield return product;
        }
    }

    public IEnumerable<Product> FindeProductsBySupplierAndPriceRange(
        string supplier,
        decimal minPrice,
        decimal maxPrice)
    {
        if (! this.productsBySuplierAndPrice.ContainsKey(supplier))
        {
            yield break;
        }

        var filteredBySupplierAndPriceRange = this.productsBySuplierAndPrice[supplier].Range(minPrice, true, maxPrice, true).Values.SelectMany(p => p);

        // TODO: this is slow. Think of better way to extract the products ordered by ID
        OrderedSet<Product> result = new OrderedSet<Product>(filteredBySupplierAndPriceRange);

        foreach (var product in result)
        {
            yield return product;
        }
    }

    private void AddProduct(int id, string title, string suplier, decimal price)
    {
        var productToAdd = new Product(id, title, suplier, price);

        this.productsById[id] = productToAdd;

        bool titleExists = this.productsByTitle.ContainsKey(title);
        if (!titleExists)
        {
            this.productsByTitle[title] = new SortedSet<Product>();
            this.productsByTitleAndPrice[title] = new OrderedDictionary<decimal, SortedSet<Product>>();
        }

        this.productsByTitle[title].Add(productToAdd);

        bool suplierExists = this.productsBySuplierAndPrice.ContainsKey(suplier);
        if (!suplierExists)
        {
            this.productsBySuplierAndPrice[suplier] = new OrderedDictionary<decimal, SortedSet<Product>>();
        }

        bool priceExists = this.productsByPrice.ContainsKey(price);
        if (!priceExists)
        {
            this.productsByPrice[price] = new SortedSet<Product>();
        }

        this.productsByPrice[price].Add(productToAdd);

        if (! this.productsByTitleAndPrice[title].ContainsKey(price))
        {
            this.productsByTitleAndPrice[title][price] = new SortedSet<Product>();
        }

        this.productsByTitleAndPrice[title][price].Add(productToAdd);

        if (!this.productsBySuplierAndPrice[suplier].ContainsKey(price))
        {
            this.productsBySuplierAndPrice[suplier][price] = new SortedSet<Product>();
        }

        this.productsBySuplierAndPrice[suplier][price].Add(productToAdd);
    }
}