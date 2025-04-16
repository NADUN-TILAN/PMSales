using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using PMSalesDomainEntities;

namespace PMSalesDAL.DatabaseHelper
{
    public class CustomerDAL
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["PMSalesDB"].ConnectionString;

        public bool InsertCustomer(Customer customer)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PM_INSERT_CUSTOMER", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Map the correct properties to the stored procedure parameters
                    cmd.Parameters.AddWithValue("@FirstName", customer.FirstName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@SecondName", customer.SecondName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@LastName", customer.LastName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Phone1", customer.Phone1 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Phone2", customer.Phone2 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Phone3", customer.Phone3 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email1", customer.Email1 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email2", customer.Email2 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Address", customer.Address ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@City", customer.City ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@CreatedDate", customer.CreatedDate == default ? DateTime.Now : customer.CreatedDate);
                    cmd.Parameters.AddWithValue("@UpdatedDate", customer.UpdatedDate == default ? DateTime.Now : customer.UpdatedDate);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
