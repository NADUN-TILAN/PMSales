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

        public decimal GetConfirmedProfit()
        {
            try
            {
                return customerDAL.GetAllConfirmedProfit();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving profit: {ex.Message}");
                return 0m;
            }
        }

        public decimal GetConfirmedCanceledProducts()
        {
            try
            {
                return customerDAL.GetConfirmedCanceledProductCount();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving canceled products: {ex.Message}");
                return 0m;
            }
        }

    }
}

