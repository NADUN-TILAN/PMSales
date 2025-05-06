using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using PMSalesDomainEntities;
using System.Data;

namespace PMSalesDAL.DatabaseHelper
{
    public class CustomerDAL
    {
        private readonly string connectionString;

        public CustomerDAL()
        {
            // Load configuration from appsettings.json
            var config = new ConfigurationBuilder()
                            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                            .Build();

            string? conn = config.GetConnectionString("PMSalesDB");

            if (string.IsNullOrEmpty(conn))
            {
                throw new Exception("Connection string 'PMSalesDB' not found in appsettings.json.");
            }

            connectionString = conn;
        }

        #region Insert customers
        public bool InsertCustomer(Customer customer)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("PM_INSERT_CUSTOMER", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add your parameters
                        cmd.Parameters.AddWithValue("@fname", customer.FirstName ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@sname", customer.SecondName ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@lname", customer.LastName ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@phone1", customer.Phone1 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@phone2", customer.Phone2 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@phone3", customer.Phone3 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@email1", customer.Email1 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@email2", customer.Email2 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@address", customer.Address ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@city", customer.City ?? (object)DBNull.Value);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        Console.WriteLine("Customer inserted successfully.");
                        return true;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine($"SQL Error: {sqlEx.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }

        }
        #endregion

        #region Insert products
        public bool InsertProduct(string productName, string category, int stock, decimal price, string company, string size, string otherInfo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("PM_INSERT_PRODUCT", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ProductName", productName);
                        cmd.Parameters.AddWithValue("@Category", category);
                        cmd.Parameters.AddWithValue("@Stock", stock);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Company", company);
                        cmd.Parameters.AddWithValue("@Size", size);
                        cmd.Parameters.AddWithValue("@OtherInfo", otherInfo ?? (object)DBNull.Value);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        Console.WriteLine("Product inserted successfully.");
                        return true;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine($"SQL Error: {sqlEx.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }
        #endregion

        #region Get the total count of customers
        public int GetCustomerCount()
        {
            const string query = "GET_NUMBER_OF_CUSTOMERS"; // Replace 'Customers' with your actual table name

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public int GetProductCount()
        {
            const string query = "GET_NUMBER_OF_PRODUCTS"; // Replace 'Products' with your actual table name

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }
        #endregion

        #region Get products
        public List<string> FetchProductNames()
        {
            List<string> productNames = new List<string>();
            const string query = "GET_AVAILABLE_ALL_PRODUCT_NAMES";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string productName = reader["ProductName"].ToString() ?? string.Empty;
                                Console.WriteLine($"Retrieved Product: {productName}");
                                productNames.Add(productName);
                            }
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine($"SQL Error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            if (productNames.Count == 0)
            {
                Console.WriteLine("No product names were retrieved from the database.");
            }

            return productNames;
        }
        #endregion

        #region Get products with prices
        public List<(string ProductName, string Price)> FetchProductNamesWithPrices()
        {
            var products = new List<(string ProductName, string Price)>();
            const string query = "SELECT_ALL_PRODUCT_NAMES_AND_PRICES";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string productName = reader["ProductName"].ToString() ?? string.Empty;
                                string price = reader["Price"].ToString() ?? string.Empty;
                                Console.WriteLine($"Retrieved Product: {productName}, Retrieved Price: {price}");
                                products.Add((productName, price));
                            }
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine($"SQL Error: {sqlEx.Message}");
                throw; // Rethrow the exception for higher-level handling
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw; // Rethrow the exception for higher-level handling
            }

            if (products.Count == 0)
            {
                Console.WriteLine("No products were retrieved from the database.");
            }

            return products;
        }
        #endregion

        public bool InsertFullProduct(Product product)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "PM_INSERT_FULL_PRODUCT_ENTRY";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@product1", product.product1 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@qty1", product.qty1);
                        cmd.Parameters.AddWithValue("@product2", product.product2 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@qty2", product.qty2);
                        cmd.Parameters.AddWithValue("@product3", product.product3 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@qty3", product.qty3);
                        cmd.Parameters.AddWithValue("@product4", product.product4 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@qty4", product.qty4);
                        cmd.Parameters.AddWithValue("@product5", product.product5 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@qty5", product.qty5);
                        cmd.Parameters.AddWithValue("@product6", product.product6 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@qty6", product.qty6);
                        cmd.Parameters.AddWithValue("@product7", product.product7 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@qty7", product.qty7);
                        cmd.Parameters.AddWithValue("@product8", product.product8 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@qty8", product.qty8);
                        cmd.Parameters.AddWithValue("@TotalAmount", product.TotalAmount);

                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        Console.WriteLine("Product inserted successfully.");
                        return rows > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine($"SQL Error: {sqlEx.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }




    }
}
