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
    }
}

