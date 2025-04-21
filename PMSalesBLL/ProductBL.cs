using PMSalesDomainEntities;
using PMSalesDAL.DatabaseHelper;

namespace PMSales.BusinessLayer

{
    public class ProductBLL
    {
        private readonly CustomerDAL customerDAL = new CustomerDAL();

        // Fetch product names
        public List<string> GetProductNames()
        {
            try
            {
                return customerDAL.FetchProductNames();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving product names: {ex.Message}");
                return new List<string>();
            }
        }

        // Fetch product names & prices
        public List<(string ProductName, string Price)> FetchProductNames()
        {
            try
            {
                // Directly return the result from FetchProductNamesWithPrices
                return customerDAL.FetchProductNamesWithPrices();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving product names and prices: {ex.Message}");
                return new List<(string ProductName, string Price)>();
            }
        }
    }
}
