using PMSales.BusinessLayer;
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

        #region Features
        private void rjButton6_Click(object sender, EventArgs e)
        {
            var homeForm = new Dashboard();
            homeForm.Show();

            this.Close();
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            var customerForm1 = new customerForm1Add();
            customerForm1.Show();

            this.Close();
        }

        private void rjButton7_Click(object sender, EventArgs e)
        {
            var productForm = new productFormAddNewItems();
            productForm.Show();

            this.Close();
        }
        #endregion

        private void ButtonSave_Click(object sender, EventArgs e)
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



    }
}
