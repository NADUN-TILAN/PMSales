using PMSalesDomainEntities;
using PMSalesDAL.DatabaseHelper;

namespace PMSales.BusinessLayer
{
    public class CustomerBL
    {
        private readonly CustomerDAL customerDAL = new CustomerDAL();

        // Placeholder for saving customer Add Form 1 data
        public bool SaveCustomer(string customerName, string customerSName, string customerLName, string customerPhone1, string customerPhone2,
                                            string customerPhone3, string customerEmail1, string customerEmail2, string customerAddress, string customerCity)
        {
            //return customerDAL.InsertCustomer(customer);
        }
    }
}
