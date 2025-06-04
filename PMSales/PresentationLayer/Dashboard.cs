using PMSales.BusinessLayer;
using PMSales.PresentationLayer.UserForm;
using PMSalesBLL;
using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMSales.PresentationLayer
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            DisplayAssemblyVersion();
            DisplayCustomerCount();
            PopulateComboBox1(); // Ensure this is called
            DisplayProductCount();
            GetConfirmSalesCount();
            DisplayConfirmSalesCount();
            DisplayConfirmedProfit();
            DisplayConfirmedCanceledProducts();

            // Initialize labels for button tooltips
            labelAddButton = label6;
            labelDashButton = label7;
            labelAddPButton = label8;
            labelEmailButton = label9;
            labelSalesButton = label10;
            labelSearchButton = label11;
            labelHelpButton = label12;

        }

        private void DisplayAssemblyVersion()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "Unknown Version";
            labelCustomerCounttx.Text = $"Vs{version}";
        }

        // 1. Add this to the field declarations (with the other controls)
        private Label? labelAddButton;
        private Label? labelDashButton;
        private Label? labelAddPButton;
        private Label? labelEmailButton;
        private Label? labelSalesButton;
        private Label? labelSearchButton;
        private Label? labelHelpButton;

        #region btn 4 and 6 and 7 and 8 and 9 and 10 and 11 
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

        private void rjButton7_MouseClick(object sender, MouseEventArgs e) //eveent 3
        {
            ApplyClickStyle(rjButton7);
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

        private void rjButton9_MouseClick(object sender, MouseEventArgs e) //eveent 3
        {
            ApplyClickStyle(rjButton9);
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

        #region Features
        //Customers 
        private void rjButton4_Click(object sender, EventArgs e)
        {
            // Instantiate the customerForm1Add form
            var customerForm = new customerForm1Add();

            // Show the customerForm1Add form
            customerForm.Show();

            // Close the current Dashboard form
            this.Close();
        }

        private void rjButton6_Click(object sender, EventArgs e)
        {
            // Instantiate the customerForm1Add form
            var customerForm = new Dashboard();

            // Show the customerForm1Add form
            customerForm.Show();

            // Close the current Dashboard form
            this.Close();
        }

        private void rjButton7_Click(object sender, EventArgs e)
        {
            var productForm = new productFormAddNewItems();
            productForm.Show();

            this.Close();
        }

        #endregion

        #region Dashboard Functions

        private void DisplayCustomerCount()
        {
            // Assuming GetCustomerCount() retrieves the number of customers
            int customerCount = GetCustomerCount();
            labelCustomerCount.Text = $"Customers: {customerCount}";
        }

        // method to retrieve customer count (replace with actual implementation)
        private int GetCustomerCount()
        {
            var customerBL = new PMSales.BusinessLayer.CustomerBL();
            return customerBL.GetCustomerCount();
        }

        private void DisplayProductCount()
        {
            // Assuming GetProductCount() retrieves the number of items
            int productCount = GetProductCount();
            labelProductCount.Text = $"Products: {productCount}";
        }

        // method to retrieve product count (replace with actual implementation)
        private int GetProductCount()
        {
            var customerBL = new PMSales.BusinessLayer.CustomerBL();
            return customerBL.GetProductCount();
        }

        // Displays the confirmed sales count on the label
        private void DisplayConfirmSalesCount()
        {
            int confirmSalesCount = GetConfirmSalesCount();
            label2.Text = $"Confirmed Sales: {confirmSalesCount}";
        }
        // Returns the confirmed sales count
        private int GetConfirmSalesCount()
        {
            var salesBL = new SalesBL();
            return salesBL.GetSalesCount();
        }

        // Displays the confirmed profit on the label
        private void DisplayConfirmedProfit()
        {
            var salesBL = new SalesBL();
            decimal confirmedProfit = salesBL.GetConfirmedProfit();
            label1.Text = $"Confirmed Profit: Rs. {confirmedProfit:N2}";
        }

        // Displays the confirmed canceled products on the label
        private void DisplayConfirmedCanceledProducts()
        {
            var salesBL = new SalesBL();
            var canceledProducts = salesBL.GetConfirmedCanceledProducts();
            label5.Text = "Canceled Products: " + string.Join(", ", canceledProducts);
        }

        // Items dropdown
        private void PopulateComboBox1()
        {
            try
            {
                var productBL = new PMSales.BusinessLayer.ProductBLL();
                List<string> products = productBL.GetProductNames(); // Declare 'products' here

                comboBox1.Items.Clear();

                if (products.Count == 0) // Check after 'products' is declared
                {
                    MessageBox.Show("No products available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    comboBox1.Items.AddRange(products.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


        private void rjButton1_Click(object sender, EventArgs e)
        {
            // Instantiate the Dashboard2View form
            var Dashboard2View = new Dashboard2();

            // Show the Dashboard2View form
            Dashboard2View.Show();

            // Close the current Dashboard form
            this.Close();
        }

        private void rjButton9_Click(object sender, EventArgs e)
        {
            // Instantiate the SalesReportView form
            var SalesReportView = new salesFormReport();

            // Show the SalesReportView form
            SalesReportView.Show();

            // Close the current Dashboard form
            this.Close();
        }

        private void rjButton8_Click(object sender, EventArgs e)
        {

        }

        private void rjButton10_Click(object sender, EventArgs e)
        {

        }

        private void rjButton11_Click(object sender, EventArgs e)
        {
            var HelpForm1View = new HelpForm();

            HelpForm1View.Show();

            this.Close();
        }
    }
}
