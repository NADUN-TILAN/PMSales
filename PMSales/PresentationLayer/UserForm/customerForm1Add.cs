﻿using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;
using PMSales.BusinessLayer;
using RJCodeAdvance.RJControls;

namespace PMSales.PresentationLayer.UserForm
{
    public partial class customerForm1Add : Form
    {
        private readonly CustomerBL customerBL; // Declare a CustomerBL instance
        private bool isAlreadySaved;

        public customerForm1Add()
        {
            InitializeComponent();
            customerBL = new CustomerBL(); // Initialize the CustomerBL instance

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
        // Dashboard
        private void rjButton6_Click(object sender, EventArgs e)
        {
            var homeForm = new Dashboard();
            homeForm.Show();

            this.Close();
        }

        private void rjButton7_Click(object sender, EventArgs e)
        {
            var productForm = new productFormAddNewItems();
            productForm.Show();

            this.Close();
        }
        #endregion

        // Event handler for Save button
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Prevent saving again if already saved
            if (isAlreadySaved)
            {
                this.Hide();
                //var customerForm2 = new customerForm2Product(this);
                var customerForm2 = new customerForm2Product(this, $"{textBoxName.Texts.Trim()} {textBoxSName.Texts.Trim()} {textBoxLName.Texts.Trim()}");
                customerForm2.Show();
                return;
            }

            try
            {
                // Step 1: Retrieve Input Data
                string customerName = textBoxName.Texts.Trim();
                string customerSName = textBoxSName.Texts.Trim();
                string customerLName = textBoxLName.Texts.Trim();
                string customerPhone1 = textBoxPhone1.Texts.Trim();
                string customerPhone2 = textBoxPhone2.Texts.Trim();
                string customerPhone3 = textBoxPhone3.Texts.Trim();
                string customerEmail1 = textBoxEmail1.Texts.Trim();
                string customerEmail2 = textBoxEmail2.Texts.Trim();
                string customerAddress = textBoxAddress.Texts.Trim();
                string customerCity = textBoxCity.Texts.Trim();

                // Step 2: Validate Input
                if (string.IsNullOrWhiteSpace(customerName))
                {
                    MessageBox.Show("Customer first name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(customerSName))
                {
                    MessageBox.Show("A valid second name address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(customerLName))
                {
                    MessageBox.Show("Customer last name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(customerPhone1))
                {
                    MessageBox.Show("Customer phone number 1 is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(customerPhone2))
                {
                    MessageBox.Show("Customer phone number 2 is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //if (string.IsNullOrWhiteSpace(customerPhone3))
                //{
                //    MessageBox.Show("Customer phone number 3 is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}

                if (string.IsNullOrWhiteSpace(customerEmail1))
                {
                    MessageBox.Show("Customer email 1 is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //if (string.IsNullOrWhiteSpace(customerEmail2))
                //{
                //    MessageBox.Show("Customer email 2 is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}

                if (string.IsNullOrWhiteSpace(customerAddress))
                {
                    MessageBox.Show("Customer address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(customerCity))
                {
                    MessageBox.Show("Customer city is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Step 3: Save Data
                bool isSaved = customerBL.SaveCustomer(customerName, customerSName, customerLName, customerPhone1, customerPhone2, customerPhone3, customerEmail1, customerEmail2, customerAddress, customerCity);

                if (isSaved)
                {
                    isAlreadySaved = true;

                    // Step 4: Provide Feedback
                    //MessageBox.Show("Customer data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);               
                    this.Hide();
                    //var customerForm2 = new customerForm2Product(this); // pass current form
                    var customerForm2 = new customerForm2Product(this, $"{customerName} {customerSName} {customerLName}"); // Pass concatenated name
                    customerForm2.Show();
                }
                else
                {
                    MessageBox.Show("Failed to save customer data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // In customerForm1Add.cs
        public PMSalesDomainEntities.Customer GetCurrentCustomer()
        {
            return new PMSalesDomainEntities.Customer
            {
                FirstName = textBoxName.Texts.Trim(),
                SecondName = textBoxSName.Texts.Trim(),
                LastName = textBoxLName.Texts.Trim(),
                Phone1 = textBoxPhone1.Texts.Trim(),
                Phone2 = textBoxPhone2.Texts.Trim(),
                Phone3 = textBoxPhone3.Texts.Trim(),
                Email1 = textBoxEmail1.Texts.Trim(),
                Email2 = textBoxEmail2.Texts.Trim(),
                Address = textBoxAddress.Texts.Trim(),
                City = textBoxCity.Texts.Trim()
            };
        }


        // Helper method to validate email format
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
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

        private void rjButton11_Click(object sender, EventArgs e)
        {

        }

        private void rjButton10_Click(object sender, EventArgs e)
        {

        }
    }
}
