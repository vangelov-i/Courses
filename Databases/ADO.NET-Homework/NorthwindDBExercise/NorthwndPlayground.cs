namespace NorthwindDBExercise
{
    using System;

    public class NorthwndPlayground
    {
        public static void Main()
        {
            var sqlNorthwindConnection = new NorthwindConnection();

            try
            {
                sqlNorthwindConnection.ConnectToDB();

                // TASK 1
                Console.WriteLine("{0}TASK 1", Environment.NewLine);

                Console.WriteLine("Categories count: {0}", sqlNorthwindConnection.GetCategoriesCount());

                // TASK 2
                Console.WriteLine("{0}TASK 2", Environment.NewLine);

                string categoriesWithDescription = sqlNorthwindConnection.GetCategoriesNameAndDescription();
                Console.WriteLine(categoriesWithDescription);

                // TASK 3
                Console.WriteLine("{0}TASK 3", Environment.NewLine);

                string productsByCategories = sqlNorthwindConnection.GetProductsByCategories();
                Console.WriteLine(productsByCategories);

                // TASK 4
                Console.WriteLine("{0}TASK 4", Environment.NewLine);

                Console.Write("Enter product's name to add: ");
                string productName = Console.ReadLine();

                Console.Write("Is product discontinued? (Y/N)");
                string discontinuedYorN = Console.ReadLine();
                while (
                    discontinuedYorN.ToUpper() != "Y" &&
                    discontinuedYorN.ToUpper() != "N")
                {
                    Console.WriteLine("Invalid answer.");
                    Console.Write("Is product discontinued? (Y/N)");
                    discontinuedYorN = Console.ReadLine();
                }

                bool discontinued = discontinuedYorN.ToUpper() == "Y";

                int productID = sqlNorthwindConnection.AddProduct(productName, discontinued);
                Console.WriteLine(
                    "Product {0} with ProductID:{1} added successfully.",
                    productName,
                    productID);

                // TASK 5
                Console.WriteLine("{0}TASK 4", Environment.NewLine);
                sqlNorthwindConnection.RetrieveImagesFromCategoriesTo();
            }
            finally
            {
                sqlNorthwindConnection.DisconnectFromDb();
            }
        }
    }
}