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

            
        }
    }
}
