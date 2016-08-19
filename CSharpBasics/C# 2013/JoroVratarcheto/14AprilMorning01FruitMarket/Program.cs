using System;


//  MNOGO GROZNO RESHENIE, VYPREKI CHE DAVA 100/100 !!! 
//  DA SE POMISLI ZA NESHTO PO HITRO!
//  reshena za 50 min


namespace _14AprilMorning01FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine();
            double quantity1 = double.Parse(Console.ReadLine());
            string prod1 = Console.ReadLine();
            double quantity2 = double.Parse(Console.ReadLine());
            string prod2 = Console.ReadLine();
            double quantity3 = double.Parse(Console.ReadLine());
            string prod3 = Console.ReadLine();

            double income1 = 0d;
            double income2 = 0d;
            double income3 = 0d;

            double priceBanana = 1.80;
            double priceCucumber = 2.75;
            double priceTomato= 3.20;
            double priceOrange = 1.60;
            double priceApple = 0.86;
            double discount10All = 0.1;
            double discount5All = 0.05;
            double discount20Fruits = 0.20;
            double discount10Veg = 0.10;
            double discount30Ban = 0.30;

            if (dayOfWeek == "Friday")
            {
                switch (prod1)
                {
                    case "banana":
                        income1 = quantity1 * (priceBanana - priceBanana * discount10All);
                        break;
                    case "cucumber":
                        income1 = quantity1 * (priceCucumber - priceCucumber * discount10All);
                        break;
                    case "tomato":
                        income1 = quantity1 * (priceTomato - priceTomato * discount10All);
                        break;
                    case "orange":
                        income1 = quantity1 * (priceOrange - priceOrange * discount10All);
                        break;
                    case "apple":
                        income1 = quantity1 * (priceApple - priceApple * discount10All);
                        break;
                }
                switch (prod2)
                {
                    case "banana":
                        income2 = quantity2 * (priceBanana - priceBanana * discount10All);
                        break;
                    case "cucumber":
                        income2 = quantity2 * (priceCucumber - priceCucumber * discount10All);
                        break;
                    case "tomato":
                        income2 = quantity2 * (priceTomato - priceTomato * discount10All);
                        break;
                    case "orange":
                        income2 = quantity2 * (priceOrange - priceOrange * discount10All);
                        break;
                    case "apple":
                        income2 = quantity2 * (priceApple - priceApple * discount10All);
                        break;
                }
                switch (prod3)
                {
                    case "banana":
                        income3 = quantity3 * (priceBanana - priceBanana * discount10All);
                        break;
                    case "cucumber":
                        income3 = quantity3 * (priceCucumber - priceCucumber * discount10All);
                        break;
                    case "tomato":
                        income3 = quantity3 * (priceTomato - priceTomato * discount10All);
                        break;
                    case "orange":
                        income3 = quantity3 * (priceOrange - priceOrange * discount10All);
                        break;
                    case "apple":
                        income3 = quantity3 * (priceApple - priceApple * discount10All);
                        break;
                }
            }
            else if (dayOfWeek == "Sunday")
            {
                switch (prod1)
                {
                    case "banana":
                        income1 = quantity1 * (priceBanana - priceBanana * discount5All);
                        break;
                    case "cucumber":
                        income1 = quantity1 * (priceCucumber - priceCucumber * discount5All);
                        break;
                    case "tomato":
                        income1 = quantity1 * (priceTomato - priceTomato * discount5All);
                        break;
                    case "orange":
                        income1 = quantity1 * (priceOrange - priceOrange * discount5All);
                        break;
                    case "apple":
                        income1 = quantity1 * (priceApple - priceApple * discount5All);
                        break;
                }
                switch (prod2)
                {
                    case "banana":
                        income2 = quantity2 * (priceBanana - priceBanana * discount5All);
                        break;
                    case "cucumber":
                        income2 = quantity2 * (priceCucumber - priceCucumber * discount5All);
                        break;
                    case "tomato":
                        income2 = quantity2 * (priceTomato - priceTomato * discount5All);
                        break;
                    case "orange":
                        income2 = quantity2 * (priceOrange - priceOrange * discount5All);
                        break;
                    case "apple":
                        income2 = quantity2 * (priceApple - priceApple * discount5All);
                        break;
                }
                switch (prod3)
                {
                    case "banana":
                        income3 = quantity3 * (priceBanana - priceBanana * discount5All);
                        break;
                    case "cucumber":
                        income3 = quantity3 * (priceCucumber - priceCucumber * discount5All);
                        break;
                    case "tomato":
                        income3 = quantity3 * (priceTomato - priceTomato * discount5All);
                        break;
                    case "orange":
                        income3 = quantity3 * (priceOrange - priceOrange * discount5All);
                        break;
                    case "apple":
                        income3 = quantity3 * (priceApple - priceApple * discount5All);
                        break;
                }
            }
            else if (dayOfWeek == "Tuesday")
            {
                switch (prod1)
                {
                    case "banana":
                        income1 = quantity1 * (priceBanana - priceBanana * discount20Fruits);
                        break;
                    case "orange":
                        income1 = quantity1 * (priceOrange - priceOrange * discount20Fruits);
                        break;
                    case "apple":
                        income1 = quantity1 * (priceApple - priceApple * discount20Fruits);
                        break;
                    case "cucumber":
                        income1 = quantity1 *priceCucumber;
                        break;
                    case "tomato":
                        income1 = quantity1 * priceTomato;
                        break;
                }
                switch (prod2)
                {
                    case "banana":
                        income2 = quantity2 * (priceBanana - priceBanana * discount20Fruits);
                        break;
                    case "orange":
                        income2 = quantity2 * (priceOrange - priceOrange * discount20Fruits);
                        break;
                    case "apple":
                        income2 = quantity2 * (priceApple - priceApple * discount20Fruits);
                        break;
                    case "cucumber":
                        income2 = quantity2 *priceCucumber;
                        break;
                    case "tomato":
                        income2 = quantity2 * priceTomato;
                        break;
                }
                switch (prod3)
                {
                    case "banana":
                        income3 = quantity3 * (priceBanana - priceBanana * discount20Fruits);
                        break;
                    case "orange":
                        income3 = quantity3 * (priceOrange - priceOrange * discount20Fruits);
                        break;
                    case "apple":
                        income3 = quantity3 * (priceApple - priceApple * discount20Fruits);
                        break;
                    case "cucumber":
                        income3 = quantity3 *priceCucumber;
                        break;
                    case "tomato":
                        income3 = quantity3 * priceTomato;
                        break;
                }

            }
            else if (dayOfWeek == "Wednesday")
            {
                switch (prod1)
                {
                    case "banana":
                        income1 = quantity1 * priceBanana;
                        break;
                    case "orange":
                        income1 = quantity1 * priceOrange;
                        break;
                    case "apple":
                        income1 = quantity1 * priceApple;
                        break;
                    case "cucumber":
                        income1 = quantity1 * (priceCucumber - priceCucumber*discount10Veg);
                        break;
                    case "tomato":
                        income1 = quantity1 * (priceTomato - priceTomato * discount10Veg);
                        break;
                }
                switch (prod2)
                {
                    case "banana":
                        income2 = quantity2 * priceBanana;
                        break;
                    case "orange":
                        income2 = quantity2 * priceOrange;
                        break;
                    case "apple":
                        income2 = quantity2 * priceApple;
                        break;
                    case "cucumber":
                        income2 = quantity2 * (priceCucumber - priceCucumber*discount10Veg);
                        break;
                    case "tomato":
                        income2 = quantity2 * (priceTomato - priceTomato * discount10Veg);
                        break;
                }
                switch (prod3)
                {
                    case "banana":
                        income3 = quantity3 * priceBanana;
                        break;
                    case "orange":
                        income3 = quantity3 * priceOrange;
                        break;
                    case "apple":
                        income3 = quantity3 * priceApple;
                        break;
                    case "cucumber":
                        income3 = quantity3 * (priceCucumber - priceCucumber*discount10Veg);
                        break;
                    case "tomato":
                        income3 = quantity3 * (priceTomato - priceTomato * discount10Veg);
                        break;
                }
            }
            else if (dayOfWeek == "Thursday")
	        {
		        switch (prod1)
	            {
                    case "banana":
                        income1 = quantity1 * (priceBanana - priceBanana*discount30Ban);
                        break;
                    case "orange":
                        income1 = quantity1 * priceOrange;
                        break;
                    case "apple":
                        income1 = quantity1 * priceApple;
                        break;
                    case "cucumber":
                        income1 = quantity1 * priceCucumber;
                        break;
                    case "tomato":
                        income1 = quantity1 * priceTomato;
                        break;
	            }
                switch (prod2)
	            {
                    case "banana":
                        income2 = quantity2 * (priceBanana - priceBanana*discount30Ban);
                        break;
                    case "orange":
                        income2 = quantity2 * priceOrange;
                        break;
                    case "apple":
                        income2 = quantity2 * priceApple;
                        break;
                    case "cucumber":
                        income2 = quantity2 * priceCucumber;
                        break;
                    case "tomato":
                        income2 = quantity2 * priceTomato;
                        break;
	            }
                switch (prod3)
	            {
                    case "banana":
                        income3 = quantity3 * (priceBanana - priceBanana*discount30Ban);
                        break;
                    case "orange":
                        income3 = quantity3 * priceOrange;
                        break;
                    case "apple":
                        income3 = quantity3 * priceApple;
                        break;
                    case "cucumber":
                        income3 = quantity3 * priceCucumber;
                        break;
                    case "tomato":
                        income3 = quantity3 * priceTomato;
                        break;
	            }
	        }
            else
	        {
                switch (prod1)
	            {
                    case "banana":
                        income1 = quantity1 * priceBanana;
                        break;
                    case "orange":
                        income1 = quantity1 * priceOrange;
                        break;
                    case "apple":
                        income1 = quantity1 * priceApple;
                        break;
                    case "cucumber":
                        income1 = quantity1 * priceCucumber;
                        break;
                    case "tomato":
                        income1 = quantity1 * priceTomato;
                        break;
	            }

                switch (prod2)
	            {
                    case "banana":
                        income2 = quantity2 * priceBanana;
                        break;
                    case "orange":
                        income2 = quantity2 * priceOrange;
                        break;
                    case "apple":
                        income2 = quantity2 * priceApple;
                        break;
                    case "cucumber":
                        income2 = quantity2 * priceCucumber;
                        break;
                    case "tomato":
                        income2 = quantity2 * priceTomato;
                        break;
	            }
                switch (prod3)
	            {
                    case "banana":
                        income3 = quantity3 * priceBanana;
                        break;
                    case "orange":
                        income3 = quantity3 * priceOrange;
                        break;
                    case "apple":
                        income3 = quantity3 * priceApple;
                        break;
                    case "cucumber":
                        income3 = quantity3 * priceCucumber;
                        break;
                    case "tomato":
                        income3 = quantity3 * priceTomato;
                        break;
	            }
	        }
            double totalIncome = income1 + income2 + income3;
            Console.WriteLine("{0:F2}",totalIncome);
        }
    }
}
//19:20

// fruits:      banana orange apple
// vegetables:  cucumber, tomato