using System;
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

        private void rjButton4_Click(object sender, EventArgs e)
        {

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
        // Dashboard
        private void rjButton6_Click(object sender, EventArgs e)
        {
            var homeForm = new Dashboard();
            homeForm.Show();

            this.Close();
        }

        private void rjButton7_Click(object sender, EventArgs e)
        {

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
