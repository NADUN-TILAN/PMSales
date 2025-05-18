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
                        cmd.Parameters.AddWithValue("@qty1", product.qty1 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@product2", product.product2 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@qty2", product.qty2 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@product3", product.product3 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@qty3", product.qty3 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@product4", product.product4 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@qty4", product.qty4 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@product5", product.product5 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@qty5", product.qty5 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@product6", product.product6 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@qty6", product.qty6 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@product7", product.product7 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@qty7", product.qty7 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@product8", product.product8 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@qty8", product.qty8 ?? (object)DBNull.Value);
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

        /// Insert a sale
        public bool InsertSale(Sales sale)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("PM_INSERT_CONFIRMED_SALES", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Customer info
                        cmd.Parameters.AddWithValue("@fname", sale.FirstName ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@sname", sale.SecondName ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@lname", sale.LastName ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@address", sale.Address ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@city", sale.City ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@phone1", sale.ContactNo1 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@phone2", sale.ContactNo2 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@phone3", sale.ContactNo3 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@email1", sale.Email1 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@email2", sale.Email2 ?? (object)DBNull.Value);

                        // Product/Item info
                        cmd.Parameters.AddWithValue("@item1", sale.Item1 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@qty1", sale.Qty1 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@item2", sale.Item2 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@qty2", sale.Qty2 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@item3", sale.Item3 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@qty3", sale.Qty3 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@item4", sale.Item4 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@qty4", sale.Qty4 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@item5", sale.Item5 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@qty5", sale.Qty5 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@item6", sale.Item6 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@qty6", sale.Qty6 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@item7", sale.Item7 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@qty7", sale.Qty7 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@item8", sale.Item8 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@qty8", sale.Qty8 ?? (object)DBNull.Value);

                        // Sale info
                        cmd.Parameters.AddWithValue("@totalprice", sale.TotalPrice);
                        cmd.Parameters.AddWithValue("@warrantyduedate", sale.WarrantyDueDate ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@warrantyclaims", sale.WarrantyClaims ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@prodstatus", sale.ProductStatus ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@prodwarrantystatus", sale.ProductWarrantyStatus ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@confirmorders", sale.ConfirmOrders ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@returnedorders", sale.ReturnedOrders ?? (object)DBNull.Value);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        // Get all sales reports
        public List<Sales> GetAllSalesReports()
        {
            var salesList = new List<Sales>();
            const string query = "GET_ALL_CONFIRMED_SALES_REPORTS";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var sale = new Sales
                            {
                                FirstName = reader["FirstName"]?.ToString(),
                                SecondName = reader["SecondName"]?.ToString(),
                                LastName = reader["LastName"]?.ToString(),
                                Address = reader["Address"]?.ToString(),
                                City = reader["City"]?.ToString(),
                                ContactNo1 = reader["Contact No 1"]?.ToString(),
                                ContactNo2 = reader["Contact No 2"]?.ToString(),
                                ContactNo3 = reader["Contact No 3"]?.ToString(),
                                Email1 = reader["Email 1"]?.ToString(),
                                Email2 = reader["Email 2"]?.ToString(),
                                Item1 = reader["Item 1"]?.ToString(),
                                Qty1 = reader["Qty 1"]?.ToString(),
                                Item2 = reader["Item 2"]?.ToString(),
                                Qty2 = reader["Qty 2"]?.ToString(),
                                Item3 = reader["Item 3"]?.ToString(),
                                Qty3 = reader["Qty 3"]?.ToString(),
                                Item4 = reader["Item 4"]?.ToString(),
                                Qty4 = reader["Qty 4"]?.ToString(),
                                Item5 = reader["Item 5"]?.ToString(),
                                Qty5 = reader["Qty 5"]?.ToString(),
                                Item6 = reader["Item 6"]?.ToString(),
                                Qty6 = reader["Qty 6"]?.ToString(),
                                Item7 = reader["Item 7"]?.ToString(),
                                Qty7 = reader["Qty 7"]?.ToString(),
                                Item8 = reader["Item 8"]?.ToString(),
                                Qty8 = reader["Qty 8"]?.ToString(),
                                TotalPrice = reader["Total Price"] != DBNull.Value ? Convert.ToDecimal(reader["Total Price"]) : 0,
                                WarrantyDueDate = reader["Warranty DueDate"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(reader["Warranty DueDate"]) : null,
                                WarrantyClaims = reader["Warranty Claims"]?.ToString(),
                                ProductStatus = reader["Product Status"] != DBNull.Value ? (int?)Convert.ToInt32(reader["Product Status"]) : null,
                                ProductWarrantyStatus = reader["Product Warranty Status"] != DBNull.Value ? (int?)Convert.ToInt32(reader["Product Warranty Status"]) : null,
                                ConfirmOrders = reader["Confirm Orders"] != DBNull.Value ? (int?)Convert.ToInt32(reader["Confirm Orders"]) : null,
                                ReturnedOrders = reader["Returned Orders"] != DBNull.Value ? (int?)Convert.ToInt32(reader["Returned Orders"]) : null,
                                CreatedDate = reader["Created Date"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(reader["Created Date"]) : null,
                                UpdatedDate = reader["Updated Date"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(reader["Updated Date"]) : null
                            };

                            salesList.Add(sale);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching sales: {ex.Message}");
            }

            return salesList;
        }






    }
}
