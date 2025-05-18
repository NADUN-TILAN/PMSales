using PMSalesBLL;
using PMSalesDomainEntities;
using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PMSales.PresentationLayer.UserForm
{
    public partial class customerForm3Confirm : Form
    {
        private readonly customerForm1Add previousForm;
        private readonly Product _product;
        private readonly Customer _customer;

        // Updated constructor to accept previousForm, product, and customerName
        public customerForm3Confirm(customerForm1Add previousForm, Product product, Customer customer)
        {
            this.previousForm = previousForm ?? throw new ArgumentNullException(nameof(previousForm));
            _product = product ?? throw new ArgumentNullException(nameof(product));
            _customer = customer ?? throw new ArgumentNullException(nameof(customer));
            InitializeComponent();
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Set customer info
            textBoxName.Texts = string.Join(" ",
                _customer.FirstName ?? "",
                _customer.SecondName ?? "",
                _customer.LastName ?? "").Trim();
            textBoxName.Enabled = false;
            textBoxPhone1.Texts = _customer.Phone1 ?? "";
            textBoxPhone1.Enabled = false;
            textBoxPhone2.Texts = _customer.Phone2 ?? "";
            textBoxPhone2.Enabled = false;
            textBoxPhone3.Texts = _customer.Phone3 ?? "";
            textBoxPhone3.Enabled = false;
            textBoxEmail1.Texts = _customer.Email1 ?? "";
            textBoxEmail1.Enabled = false;
            textBoxEmail2.Texts = _customer.Email2 ?? "";
            textBoxEmail2.Enabled = false;
            textBoxAddress.Texts = _customer.Address ?? "";
            textBoxAddress.Enabled = false;
            textBoxCity.Texts = _customer.City ?? "";
            textBoxCity.Enabled = false;

            // Set product names
            rjTextBox1.Texts = _product.product1;
            rjTextBox2.Texts = _product.product2;
            rjTextBox3.Texts = _product.product3;
            rjTextBox4.Texts = _product.product4;
            rjTextBox5.Texts = _product.product5;
            rjTextBox6.Texts = _product.product6;
            rjTextBox7.Texts = _product.product7;
            rjTextBox8.Texts = _product.product8;

            // Set product quantities
            rjTextBox13.Texts = _product.qty1?.ToString() ?? "";
            rjTextBox14.Texts = _product.qty2?.ToString() ?? "";
            rjTextBox15.Texts = _product.qty3?.ToString() ?? "";
            rjTextBox16.Texts = _product.qty4?.ToString() ?? "";
            rjTextBox9.Texts = _product.qty5?.ToString() ?? "";
            rjTextBox10.Texts = _product.qty6?.ToString() ?? "";
            rjTextBox11.Texts = _product.qty7?.ToString() ?? "";
            rjTextBox12.Texts = _product.qty8?.ToString() ?? "";

            // Set total amount
            rjTextBox17.Texts = "Rs. " + _product.TotalAmount.ToString("N2");

            // Set all product/qty textboxes to read-only
            rjTextBox1.Enabled = false;
            rjTextBox2.Enabled = false;
            rjTextBox3.Enabled = false;
            rjTextBox4.Enabled = false;
            rjTextBox5.Enabled = false;
            rjTextBox6.Enabled = false;
            rjTextBox7.Enabled = false;
            rjTextBox8.Enabled = false;
            rjTextBox13.Enabled = false;
            rjTextBox14.Enabled = false;
            rjTextBox15.Enabled = false;
            rjTextBox16.Enabled = false;
            rjTextBox9.Enabled = false;
            rjTextBox10.Enabled = false;
            rjTextBox11.Enabled = false;
            rjTextBox12.Enabled = false;

            // Set total amount textbox to read-only
            rjTextBox17.Enabled = false;

        }

        // Confirm Sales
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            var salesBL = new SalesBL();

            var sale = new Sales
            {
                // Customer Info
                FirstName = _customer.FirstName,
                SecondName = _customer.SecondName,
                LastName = _customer.LastName,
                Address = _customer.Address,
                City = _customer.City,
                ContactNo1 = _customer.Phone1,
                ContactNo2 = _customer.Phone2,
                ContactNo3 = _customer.Phone3,
                Email1 = _customer.Email1,
                Email2 = _customer.Email2,

                // Product/Item Info
                Item1 = _product.product1,
                Qty1 = _product.qty1?.ToString(),
                Item2 = _product.product2,
                Qty2 = _product.qty2?.ToString(),
                Item3 = _product.product3,
                Qty3 = _product.qty3?.ToString(),
                Item4 = _product.product4,
                Qty4 = _product.qty4?.ToString(),
                Item5 = _product.product5,
                Qty5 = _product.qty5?.ToString(),
                Item6 = _product.product6,
                Qty6 = _product.qty6?.ToString(),
                Item7 = _product.product7,
                Qty7 = _product.qty7?.ToString(),
                Item8 = _product.product8,
                Qty8 = _product.qty8?.ToString(),

                // Sale Info
                TotalPrice = _product.TotalAmount,
                // Set these as needed from our UI or business logic:
                WarrantyDueDate = null,
                WarrantyClaims = null,
                ProductStatus = null,
                ProductWarrantyStatus = null,
                ConfirmOrders = 1,
                ReturnedOrders = null
            };

            bool result = salesBL.SaveConfirmSale(sale);

            if (result)
            {
                MessageBox.Show(
                    "The sale has been saved successfully.",
                    "Sale Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "An error occurred while saving the sale. Please try again.",
                    "Save Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            this.Hide();
            var homeForm = new Dashboard();
            homeForm.Show();

        }



    }
}
