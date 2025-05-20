using PMSales.BusinessLayer;
using RJCodeAdvance.RJControls;
using System;
using System.Windows.Forms;

namespace PMSales.PresentationLayer.UserForm
{
    public partial class productFormAddNewItems : Form
    {
        public productFormAddNewItems()
        {
            InitializeComponent();
            buttonSave.Click += ButtonSave_Click;
            rjButton12.Click += (sender, e) =>
            {
                MessageBox.Show("Add button clicked!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
        }

        #region btn 4 and 6 and 7 and 9
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

        //btn 9
        private void rjButton9_MouseHover(object sender, EventArgs e) //eveent 1
        {
            ApplyHoverStyle(rjButton9);
        }

        private void rjButton9_MouseLeave(object sender, EventArgs e) //eveent 2
        {
            ApplyLeaveStyle(rjButton9);
        }

        private void rjButton9_Click(object sender, EventArgs e)
        {
            ApplyLeaveStyle(rjButton9);
        }

        private void rjButton9_MouseDown(object sender, MouseEventArgs e) //eveent 4
        {
            ApplyPressedStyle(rjButton9);
        }

        private void rjButton9_MouseUp(object sender, MouseEventArgs e) //eveent 5
        {
            ApplyHoverStyle(rjButton9);
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
        private void rjButton6_Click(object sender, EventArgs e)
        {
            var homeForm = new Dashboard();
            homeForm.Show();

            this.Close();
        }

        //private void rjButton4_Click(object sender, EventArgs e)
        //{
        //    var customerForm1 = new customerForm1Add();
        //    customerForm1.Show();

        //    this.Close();
        //}

        private void rjButton7_Click(object sender, EventArgs e)
        {
            var productForm = new productFormAddNewItems();
            productForm.Show();

            this.Close();
        }
        #endregion

        private void ButtonSave_Click(object? sender, EventArgs e)
        {
            if (!ValidateInputs(out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string productName = textBoxName.Texts;
            string category = textBoxSName.Texts;
            int stock = int.Parse(textBoxLName.Texts);
            decimal price = decimal.Parse(textBoxPhone1.Texts);
            string company = textBoxPhone2.Texts;
            string size = textBoxPhone3.Texts;
            string otherInfo = textBoxEmail1.Texts;

            var productBLL = new ProductBLL();
            bool isSaved = productBLL.SaveProduct(productName, category, stock, price, company, size, otherInfo);

            if (isSaved)
            {
                MessageBox.Show($"Product '{productName}' has been saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBoxes(); // Clear textboxes after successful save
            }
            else
            {
                MessageBox.Show("Failed to save the product. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool ValidateInputs(out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(textBoxName.Texts))
            {
                errorMessage = "Product Name is required.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxSName.Texts))
            {
                errorMessage = "Category is required.";
                return false;
            }

            if (!int.TryParse(textBoxLName.Texts, out _))
            {
                errorMessage = "Stock must be a valid integer.";
                return false;
            }

            if (!decimal.TryParse(textBoxPhone1.Texts, out _))
            {
                errorMessage = "Price must be a valid decimal number.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxPhone2.Texts))
            {
                errorMessage = "Company is required.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxPhone3.Texts))
            {
                errorMessage = "Size is required.";
                return false;
            }

            return true;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Set placeholder text for all fields
            textBoxName.PlaceholderText = "Enter product name...";
            textBoxSName.PlaceholderText = "Enter category...";
            textBoxLName.PlaceholderText = "Enter stock quantity...";
            textBoxPhone1.PlaceholderText = "Enter price...";
            textBoxPhone2.PlaceholderText = "Enter company name...";
            textBoxPhone3.PlaceholderText = "Enter size...";
            textBoxEmail1.PlaceholderText = "Enter additional information...";
        }

        // Clear all textboxes after saving
        private void ClearTextBoxes()
        {
            textBoxName.Texts = string.Empty;
            textBoxSName.Texts = string.Empty;
            textBoxLName.Texts = string.Empty;
            textBoxPhone1.Texts = string.Empty;
            textBoxPhone2.Texts = string.Empty;
            textBoxPhone3.Texts = string.Empty;
            textBoxEmail1.Texts = string.Empty;
        }

        
    }
}
