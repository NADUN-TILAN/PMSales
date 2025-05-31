using PMSalesBLL;
using PMSalesDomainEntities;
using RJCodeAdvance.RJControls;
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

            // Initialize labels for button tooltips
            labelAddButton = label6;
            labelDashButton = label7;
            labelAddPButton = label8;
            labelEmailButton = label9;
            labelSalesButton = label10;
            labelSearchButton = label11;
            labelHelpButton = label12;
        }

        // 1. Add this to the field declarations (with the other controls)
        private Label? labelAddButton;
        private Label? labelDashButton;
        private Label? labelAddPButton;
        private Label? labelEmailButton;
        private Label? labelSalesButton;
        private Label? labelSearchButton;
        private Label? labelHelpButton;

        #region btn 4 and 6 and 7 and 9
        //btn 4
        private void rjButton4_MouseHover(object sender, EventArgs e) //eveent 1
        {
            ApplyHoverStyle(rjButton4);
            labelAddButton!.Text = "Add New Sale";
            labelAddButton.Visible = true;
        }

        private void rjButton4_MouseLeave(object sender, EventArgs e) //eveent 2
        {
            ApplyLeaveStyle(rjButton4);
            labelAddButton!.Visible = false;
        }

        private void rjButton4_MouseClick(object sender, MouseEventArgs e) //eveent 3
        {
            ApplyClickStyle(rjButton4);
        }

        private void rjButton4_MouseDown(object sender, MouseEventArgs e) //eveent 4
        {
            ApplyPressedStyle(rjButton4);
        }

        private void rjButton4_MouseUp(object sender, MouseEventArgs e) //eveent 5
        {
            ApplyHoverStyle(rjButton4);
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {

        }

        //btn 6
        private void rjButton6_MouseHover(object sender, EventArgs e) //eveent 1
        {
            ApplyHoverStyle(rjButton6);
            labelDashButton!.Text = "Dashboard";
            labelDashButton.Visible = true;
        }

        private void rjButton6_MouseLeave(object sender, EventArgs e) //eveent 2
        {
            ApplyLeaveStyle(rjButton6);
            labelDashButton!.Visible = false;
        }

        //private void rjButton6_MouseClick(object sender, MouseEventArgs e) //eveent 3
        //{
        //    ApplyClickStyle(rjButton6);
        //}

        private void rjButton6_MouseDown(object sender, MouseEventArgs e) //eveent 4
        {
            ApplyPressedStyle(rjButton6);
        }

        private void rjButton6_MouseUp(object sender, MouseEventArgs e) //eveent 5
        {
            ApplyHoverStyle(rjButton6);
        }

        private void rjButton6_Click(object sender, EventArgs e)
        {
            ApplyLeaveStyle(rjButton6);
        }

        //btn 7
        private void rjButton7_MouseHover(object sender, EventArgs e) //eveent 1
        {
            ApplyHoverStyle(rjButton7);
            labelAddPButton!.Text = "Add New Item";
            labelAddPButton.Visible = true;
        }

        private void rjButton7_MouseLeave(object sender, EventArgs e) //eveent 2
        {
            ApplyLeaveStyle(rjButton7);
            labelAddPButton!.Visible = false;
        }

        private void rjButton7_Click(object sender, EventArgs e)
        {
            ApplyHoverStyle(rjButton7);
        }

        private void rjButton7_MouseDown(object sender, MouseEventArgs e) //eveent 4
        {
            ApplyPressedStyle(rjButton7);
        }

        private void rjButton7_MouseUp(object sender, MouseEventArgs e) //eveent 5
        {
            ApplyHoverStyle(rjButton7);
        }

        //btn 8
        private void rjButton8_MouseHover(object sender, EventArgs e) //eveent 1
        {
            ApplyHoverStyle(rjButton8);
            labelEmailButton!.Text = "Check Mails";
            labelEmailButton.Visible = true;
        }

        private void rjButton8_MouseLeave(object sender, EventArgs e) //eveent 2
        {
            ApplyLeaveStyle(rjButton8);
            labelEmailButton!.Visible = false;
        }

        private void rjButton8_MouseClick(object sender, MouseEventArgs e) //eveent 3
        {
            ApplyClickStyle(rjButton8);
        }

        private void rjButton8_MouseDown(object sender, MouseEventArgs e) //eveent 4
        {
            ApplyPressedStyle(rjButton8);
        }

        private void rjButton8_MouseUp(object sender, MouseEventArgs e) //eveent 5
        {
            ApplyHoverStyle(rjButton8);
        }

        //btn 9
        private void rjButton9_MouseHover(object sender, EventArgs e) //eveent 1
        {
            ApplyHoverStyle(rjButton9);
            labelSalesButton!.Text = "View Sales";
            labelSalesButton.Visible = true;
        }

        private void rjButton9_MouseLeave(object sender, EventArgs e) //eveent 2
        {
            ApplyLeaveStyle(rjButton9);
            labelSalesButton!.Visible = false;
        }

        private void rjButton9_Click(object sender, EventArgs e)
        {
            ApplyHoverStyle(rjButton9);
        }

        private void rjButton9_MouseDown(object sender, MouseEventArgs e) //eveent 4
        {
            ApplyPressedStyle(rjButton9);
        }

        private void rjButton9_MouseUp(object sender, MouseEventArgs e) //eveent 5
        {
            ApplyHoverStyle(rjButton9);
        }

        //btn 10
        private void rjButton10_MouseHover(object sender, EventArgs e) //eveent 1
        {
            ApplyHoverStyle(rjButton10);
            labelSearchButton!.Text = "Search & Edit";
            labelSearchButton.Visible = true;
        }

        private void rjButton10_MouseLeave(object sender, EventArgs e) //eveent 2
        {
            ApplyLeaveStyle(rjButton10);
            labelSearchButton!.Visible = false;
        }

        private void rjButton10_MouseClick(object sender, MouseEventArgs e) //eveent 3
        {
            ApplyClickStyle(rjButton10);
        }

        private void rjButton10_MouseDown(object sender, MouseEventArgs e) //eveent 4
        {
            ApplyPressedStyle(rjButton10);
        }

        private void rjButton10_MouseUp(object sender, MouseEventArgs e) //eveent 5
        {
            ApplyHoverStyle(rjButton10);
        }

        //btn 11
        private void rjButton11_MouseHover(object sender, EventArgs e) //eveent 1
        {
            ApplyHoverStyle(rjButton11);
            labelHelpButton!.Text = "Help";
            labelHelpButton.Visible = true;
        }

        private void rjButton11_MouseLeave(object sender, EventArgs e) //eveent 2
        {
            ApplyLeaveStyle(rjButton11);
            labelHelpButton!.Visible = false;
        }

        private void rjButton11_MouseClick(object sender, MouseEventArgs e) //eveent 3
        {
            ApplyClickStyle(rjButton11);
        }

        private void rjButton11_MouseDown(object sender, MouseEventArgs e) //eveent 4
        {
            ApplyPressedStyle(rjButton11);
        }

        private void rjButton11_MouseUp(object sender, MouseEventArgs e) //eveent 5
        {
            ApplyHoverStyle(rjButton11);
        }
        #endregion 

        #region btn design methods
        private void ApplyHoverStyle(RJButton button)
        {
            button.BackColor = Color.FromArgb(77, 182, 172); // Teal for hover effect
            button.BorderColor = Color.FromArgb(153, 233, 255); // Slightly darker teal for border
            button.BorderSize = 3;
            button.ForeColor = Color.White; // White text for contrast
            button.Font = new Font(button.Font.FontFamily, button.Font.Size, FontStyle.Bold); // Bold text
            button.Cursor = Cursors.Hand; // Hand cursor for better UX
        }

        private void ApplyLeaveStyle(RJButton button)
        {
            button.BackColor = Color.FromArgb(245, 245, 245); // Light Gray for neutral state
            button.BorderColor = Color.FromArgb(200, 200, 200); // Subtle Gray border
            button.BorderSize = 2;
            button.ForeColor = Color.Black; // Black text for readability
            button.Font = new Font(button.Font.FontFamily, button.Font.Size, FontStyle.Regular); // Regular text
        }

        private void ApplyClickStyle(RJButton button)
        {
            button.BackColor = Color.FromArgb(33, 150, 243); // Vibrant Blue for click effect
            button.BorderColor = Color.FromArgb(25, 118, 210); // Darker Blue for border
            button.BorderSize = 4;
            button.ForeColor = Color.White; // White text for contrast
        }

        private void ApplyPressedStyle(RJButton button)
        {
            button.BackColor = Color.FromArgb(30, 136, 229); // Slightly darker blue for pressed effect
            button.BorderColor = Color.FromArgb(21, 101, 192); // Even darker border
            button.BorderSize = 5;
            button.ForeColor = Color.White; // White text for contrast
        }
        #endregion

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
                WarrantyDueDate = DateTime.Now.AddMonths(6),
                WarrantyClaims = "0",
                ProductStatus = "",
                ProductWarrantyStatus = "",
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

        private void rjButton8_Click(object sender, EventArgs e)
        {

        }

        private void rjButton10_Click(object sender, EventArgs e)
        {

        }

        private void rjButton11_Click(object sender, EventArgs e)
        {

        }
    }
}
