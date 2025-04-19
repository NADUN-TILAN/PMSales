using PMSales.PresentationLayer.UserForm;
using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using PMSales.BusinessLayer;
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

        }

        private void DisplayAssemblyVersion()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "Unknown Version";
            labelCustomerCounttx.Text = $"Vs.{version}";
        }

        #region btn 4 and 6 and 7
        //btn 4
        private void rjButton4_MouseHover(object sender, EventArgs e) //eveent 1
        {
            ApplyHoverStyle(rjButton4);
        }

        private void rjButton4_MouseLeave(object sender, EventArgs e) //eveent 2
        {
            ApplyLeaveStyle(rjButton4);
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
        }

        private void rjButton6_MouseLeave(object sender, EventArgs e) //eveent 2
        {
            ApplyLeaveStyle(rjButton6);
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
        }

        private void rjButton7_MouseLeave(object sender, EventArgs e) //eveent 2
        {
            ApplyLeaveStyle(rjButton7);
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



    }
}
