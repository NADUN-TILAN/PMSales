using PMSalesDAL.DatabaseHelper;
using PMSalesDomainEntities;

namespace PMSalesBLL
{
    public class SalesBL
    {
        private readonly CustomerDAL customerDAL = new CustomerDAL();

        public bool SaveConfirmSale(Sales sale)
        {
            return customerDAL.InsertSale(sale);
        }

        public List<Sales> GetAllSales()
        {
            return customerDAL.GetAllSalesReports();
        }

        public int GetSalesCount()
        {
            try
            {
                return customerDAL.GetAllSalesCount();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving customer count: {ex.Message}");
                return 0; // Return 0 in case of an error
            }
        }

    }
}

