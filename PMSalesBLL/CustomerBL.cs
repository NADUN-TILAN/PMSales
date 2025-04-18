using PMSalesDomainEntities;
using PMSalesDAL.DatabaseHelper;

namespace PMSales.BusinessLayer
{
    public class CustomerBL
    {
        private readonly CustomerDAL customerDAL = new CustomerDAL();

        // Save customer Add Form 1 data
        public bool SaveCustomer(string customerName, string customerSName, string customerLName, string customerPhone1, string customerPhone2,
                                            string customerPhone3, string customerEmail1, string customerEmail2, string customerAddress, string customerCity)
        {
            try
            {
                // Create a customer entity object
                var customer = new Customer
                {
                    FirstName = customerName,
                    SecondName = customerSName,
                    LastName = customerLName,
                    Phone1 = customerPhone1,
                    Phone2 = customerPhone2,
                    Phone3 = customerPhone3,
                    Email1 = customerEmail1,
                    Email2 = customerEmail2,
                    Address = customerAddress,
                    City = customerCity
                };

                // Call the DAL method to save the customer
                return customerDAL.InsertCustomer(customer);
            }
            catch (Exception ex)
            {
                // Log the exception (logging mechanism not shown here)
                Console.WriteLine($"Error saving customer: {ex.Message}");
                return false;
            }
        }

        #region Dashboard Count
        public int GetCustomerCount()
        {
            try
            {
                return customerDAL.GetCustomerCount();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving customer count: {ex.Message}");
                return 0; // Return 0 in case of an error
            }
        }
        #endregion
    }
}
