using PMSalesDomainEntities;
using PMSalesDAL.DatabaseHelper;

namespace PMSales.BusinessLayer

{
    public class ProductBLL
    {
        private readonly CustomerDAL customerDAL = new CustomerDAL();

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
    }
}
