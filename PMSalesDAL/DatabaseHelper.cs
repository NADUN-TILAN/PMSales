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


        #region Get the total count of customers
        public int GetCustomerCount()
        {
            const string query = "SELECT COUNT(*) FROM Customers"; // Replace 'Customers' with your actual table name

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
    }
}
