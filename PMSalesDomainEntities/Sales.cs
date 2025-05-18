using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSalesDomainEntities
{
    public class Sales
    {
        // Customer Info
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? ContactNo1 { get; set; }
        public string? ContactNo2 { get; set; }
        public string? ContactNo3 { get; set; }
        public string? Email1 { get; set; }
        public string? Email2 { get; set; }

        // Product/Item Info
        public string? Item1 { get; set; }
        public string? Qty1 { get; set; }
        public string? Item2 { get; set; }
        public string? Qty2 { get; set; }
        public string? Item3 { get; set; }
        public string? Qty3 { get; set; }
        public string? Item4 { get; set; }
        public string? Qty4 { get; set; }
        public string? Item5 { get; set; }
        public string? Qty5 { get; set; }
        public string? Item6 { get; set; }
        public string? Qty6 { get; set; }
        public string? Item7 { get; set; }
        public string? Qty7 { get; set; }
        public string? Item8 { get; set; }
        public string? Qty8 { get; set; }

        // Sale Info
        public decimal TotalPrice { get; set; }
        public DateTime? WarrantyDueDate { get; set; }
        public string? WarrantyClaims { get; set; }
        public int? ProductStatus { get; set; }
        public int? ProductWarrantyStatus { get; set; }
        public int? ConfirmOrders { get; set; }
        public int? ReturnedOrders { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
