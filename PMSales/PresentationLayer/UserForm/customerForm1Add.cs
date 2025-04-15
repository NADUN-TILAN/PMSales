using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;
using RJCodeAdvance.RJControls;

namespace PMSales.PresentationLayer.UserForm
{
    public partial class customerForm1Add : Form
    {
        public customerForm1Add()
        {
            InitializeComponent();
        }

        #region btn 6
        //btn 6
        private void rjButton6_Click(object sender, EventArgs e)
        {
            var homeForm = new Dashboard();
            homeForm.Show();

            this.Close();
        }
        #endregion 

        // Event handler for Save button
            // Save customer data logic goes here
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Step 1: Retrieve Input Data
                string customerName = textBoxName.Text.Trim();
                string customerSName = textBoxSName.Text.Trim();
                string customerLName = textBoxLName.Text.Trim();
                string customerPhone1 = textBoxPhone1.Text.Trim();
                string customerPhone2 = textBoxPhone2.Text.Trim();
                string customerPhone3 = textBoxPhone3.Text.Trim();
                string customerEmail1 = textBoxEmail1.Text.Trim();
                string customerEmail2 = textBoxEmail2.Text.Trim();
                string customerAddress = textBoxAddress.Text.Trim();
                string customerCity = textBoxCity.Text.Trim();

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

                if (string.IsNullOrWhiteSpace(customerPhone3))
                {
                    MessageBox.Show("Customer phone number 3 is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(customerEmail1))
                {
                    MessageBox.Show("Customer email 1 is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(customerEmail2))
                {
                    MessageBox.Show("Customer email 2 is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(customerAddress))
                {
                    MessageBox.Show("Customer address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(customerCity))
                {
                    MessageBox.Show("Customer cityr is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Step 3: Save Data (Example: Save to a database or file)
                // Assuming a method SaveCustomer exists in a data access layer
                bool isSaved = SaveCustomer(customerName, customerSName, customerLName, customerPhone1, customerPhone2, 
                                            customerPhone3, customerEmail1, customerEmail2, customerAddress, customerCity);

                if (isSaved)
                {
                    // Step 4: Provide Feedback
                    MessageBox.Show("Customer data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close the form after saving
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

        }
    }
