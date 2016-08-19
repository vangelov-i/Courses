namespace NorthwindDBExercise
{
    using System;
    using System.Configuration;
    using System.Data.SqlClient;
    using System.IO;
    using System.Text;

    public class NorthwindConnection
    {
        private SqlConnection northwindDbConnection;

        public void ConnectToDB()
        {
            ConnectionStringSettings dbConnectionString = ConfigurationManager.ConnectionStrings["SQLDB"];
            this.northwindDbConnection = new SqlConnection(dbConnectionString.ConnectionString);
            this.northwindDbConnection.Open();
        }

        public void DisconnectFromDb()
        {
            this.northwindDbConnection?.Close();
        }

        public int GetCategoriesCount()
        {
            SqlCommand cmdGetCategoriesCount = new SqlCommand(
                "SELECT COUNT(*) FROM Categories",
                this.northwindDbConnection);

            int result = (int)cmdGetCategoriesCount.ExecuteScalar();

            return result;
        }

        public string GetCategoriesNameAndDescription()
        {
            var cmdSelectNameAndDescription = new SqlCommand(
                "SELECT CategoryName, Description FROM Categories",
                this.northwindDbConnection);

            var result = new StringBuilder();

            var sqlReader = cmdSelectNameAndDescription.ExecuteReader();
            using (sqlReader)
            {
                while (sqlReader.Read())
                {
                    string categoryName = (string)sqlReader["CategoryName"];
                    string Description = (string)sqlReader["Description"];

                    result.AppendFormat(
                        "{0}: {1}{2}",
                        categoryName,
                        Description,
                        Environment.NewLine);
                }
            }

            return result.ToString();
        }

        public string GetProductsByCategories()
        {
            var cmdSelectCategoryAndProducts = new SqlCommand(
                "SELECT c.CategoryName, p.ProductName " +
                "FROM Categories c " +
                "JOIN Products p " +
                "ON p.CategoryID = c.CategoryID " +
                "ORDER BY c.CategoryName",
                this.northwindDbConnection);


            string result = FormatProductsByCategory(cmdSelectCategoryAndProducts);

            return result;
        }

        public int AddProduct(string productName, bool discontinued)
        {
            var cmdAddProduct = new SqlCommand(
                "INSERT INTO PRODUCTS (ProductName, Discontinued) " +
                "VALUES " +
                "(@productName, @discontinued)",
                this.northwindDbConnection);

            int discontinuedBit = discontinued ? 1 : 0;
            cmdAddProduct.Parameters.AddWithValue("@productName", productName);
            cmdAddProduct.Parameters.AddWithValue("@discontinued", discontinuedBit);

            cmdAddProduct.ExecuteNonQuery();

            var cmdSelectLastEntry = new SqlCommand(
                "SELECT @@Identity",
                this.northwindDbConnection);

            int entryIdentity = (int)(decimal)cmdSelectLastEntry.ExecuteScalar();

            return entryIdentity;
        }

        public void RetrieveImagesFromCategoriesTo()
        {
            var cmdRetrieveImages = new SqlCommand(
                "SELECT CategoryName, Picture " +
                "FROM Categories",
                this.northwindDbConnection);

            var sqlReader = cmdRetrieveImages.ExecuteReader();
            using (sqlReader)
            {
                while (sqlReader.Read())
                {
                    string categoryName = (string)sqlReader["CategoryName"];
                    categoryName = categoryName.Replace("/", string.Empty);
                    byte[] currentImage = (byte[])sqlReader["Picture"];

                    string imagePath = $"..//..//{categoryName}.jpg";

                    FileStream fileStream = File.OpenWrite(imagePath);
                    using (fileStream)
                    {
                        fileStream.Write(currentImage, 78, currentImage.Length - 78);
                    }
                }
            }
        }

        private static string FormatProductsByCategory(SqlCommand cmdSelectCategoryAndProducts)
        {
            var result = new StringBuilder();

            var sqlReader = cmdSelectCategoryAndProducts.ExecuteReader();
            using (sqlReader)
            {
                string prevCategory = string.Empty;
                while (sqlReader.Read())
                {
                    string categoryName = (string)sqlReader["CategoryName"];
                    string productName = (string)sqlReader["ProductName"];
                    if (categoryName != prevCategory)
                    {
                        if (prevCategory != string.Empty)
                        {
                            result.Remove(result.Length - 2, 2);
                            result.AppendLine();
                        }

                        prevCategory = categoryName;
                        result.AppendFormat("{0}: ", categoryName);
                    }

                    result.AppendFormat("{0}, ", productName);
                }
            }

            return result.ToString();
        }
    }
}