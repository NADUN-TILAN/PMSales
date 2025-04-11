using PMSalesDomainEntities;
using PMSalesDAL.DatabaseHelper;

namespace PMSales.BusinessLayer
{
    public class CustomerBL
    {
        private readonly CustomerDAL customerDAL = new CustomerDAL();

        //public bool AddCustomer(Customer customer)
        //{
        //    return customerDAL.InsertCustomer(customer);
        //}
    }
}
