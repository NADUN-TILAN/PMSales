using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using PMSales.BusinessLayer;
using PMSalesDomainEntities;
using RJCodeAdvance.RJControls;
using System.Globalization;

namespace PMSales.PresentationLayer.UserForm
{
    public partial class customerForm2Product : Form
    {
        private readonly customerForm1Add previousForm;
        private bool isAlreadySaved;
        private Product? lastSavedProduct = null;

        // Dictionary to store product names and prices
        private Dictionary<string, decimal> productPriceMap = new Dictionary<string, decimal>();

        // Last saved product
        private readonly PMSalesDomainEntities.Customer _customer;

        // Constructor
        public customerForm2Product(customerForm1Add form, string fullName)
        {
            InitializeComponent();
            previousForm = form;
            _customer = form.GetCurrentCustomer();

            textBoxName.Texts = fullName;
            textBoxName.Enabled = false;
            rjTextBox3.Enabled = false;

            PopulateComboBoxes();
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
            ApplyHoverStyle(rjButton4);
        }

        //private void rjButton4_Click(object sender, EventArgs e)
        //{

        //}

        //btn 6
        private void rjButton6_MouseHover(object sender, EventArgs e) //eveent 1
        {
            ApplyHoverStyle(rjButton6);
        }

        private void rjButton6_MouseLeave(object sender, EventArgs e) //eveent 2
        {
            ApplyLeaveStyle(rjButton6);
        }

        private void rjButton6_Click(object sender, EventArgs e)
        {
            ApplyClickStyle(rjButton6);
        }

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

        private void rjButton7_Click(object sender, EventArgs e)
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

        // Back button
        private void rjButton5_Click(object sender, EventArgs e)
        {

            previousForm.Show();
            this.Hide();
        }

        // Populate ComboBox with product names and store prices
        private void PopulateComboBoxes()
        {
            try
            {
                var productBL = new ProductBLL();
                var productsWithPrices = productBL.FetchProductNames();

                if (productsWithPrices == null || productsWithPrices.Count == 0)
                {
                    MessageBox.Show("No products available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Clear existing items in ComboBox
                comboBox1.Items.Clear();
                rjComboBox1.Items.Clear();
                rjComboBox2.Items.Clear();
                rjComboBox3.Items.Clear();
                rjComboBox4.Items.Clear();
                rjComboBox5.Items.Clear();
                rjComboBox6.Items.Clear();
                rjComboBox7.Items.Clear();

                // Add empty row at the top
                comboBox1.Items.Add("Choose items");
                rjComboBox1.Items.Add("Choose items");
                rjComboBox2.Items.Add("Choose items");
                rjComboBox3.Items.Add("Choose items");
                rjComboBox4.Items.Add(" Choose items");
                rjComboBox5.Items.Add("Choose items");
                rjComboBox6.Items.Add("Choose items");
                rjComboBox7.Items.Add("Choose items");

                foreach (var (ProductName, Price) in productsWithPrices)
                {
                    if (!string.IsNullOrEmpty(ProductName) && !string.IsNullOrEmpty(Price) && decimal.TryParse(Price, out decimal priceValue))
                    {
                        // Add product name to ComboBox and store price in dictionary
                        comboBox1.Items.Add(ProductName);
                        rjComboBox1.Items.Add(ProductName);
                        rjComboBox2.Items.Add(ProductName);
                        rjComboBox3.Items.Add(ProductName);
                        rjComboBox4.Items.Add(ProductName);
                        rjComboBox5.Items.Add(ProductName);
                        rjComboBox6.Items.Add(ProductName);
                        rjComboBox7.Items.Add(ProductName);
                        productPriceMap[ProductName] = priceValue;
                    }
                }

                // Set default selected index for ComboBox
                comboBox1.OnSelectedIndexChanged += comboBox1_SelectedIndexChanged;
                rjComboBox1.OnSelectedIndexChanged += rjComboBox1_SelectedIndexChanged;
                rjComboBox2.OnSelectedIndexChanged += rjComboBox2_SelectedIndexChanged;
                rjComboBox3.OnSelectedIndexChanged += rjComboBox3_SelectedIndexChanged;
                rjComboBox4.OnSelectedIndexChanged += rjComboBox4_SelectedIndexChanged;
                rjComboBox5.OnSelectedIndexChanged += rjComboBox5_SelectedIndexChanged;
                rjComboBox6.OnSelectedIndexChanged += rjComboBox6_SelectedIndexChanged;
                rjComboBox7.OnSelectedIndexChanged += rjComboBox7_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTotalPrice()
        {
            decimal totalPrice = CalculateTotalPrice();
            rjTextBox3.Texts = totalPrice.ToString("F2", CultureInfo.InvariantCulture);
        }


        // When user selects a product, set Qty = 1 and show price
        private void comboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                string? selectedProduct = comboBox.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(selectedProduct) && productPriceMap.ContainsKey(selectedProduct))
                {
                    rjTextBox1.Texts = "1";
                }
                else
                {
                    rjTextBox1.Texts = string.Empty;
                }
            }

            // Update the total price
            UpdateTotalPrice();
        }

        // When user selects a product, set Qty = 1 and show price
        private void rjComboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                string? selectedProduct = comboBox.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(selectedProduct) && productPriceMap.ContainsKey(selectedProduct))
                {
                    rjTextBox2.Texts = "1";
                }
                else
                {
                    rjTextBox2.Texts = string.Empty;
                }
            }

            // Update the total price
            UpdateTotalPrice();
        }

        // When user selects a product, set Qty = 1 and show price
        private void rjComboBox2_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                string? selectedProduct = comboBox.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(selectedProduct) && productPriceMap.ContainsKey(selectedProduct))
                {
                    textBoxPhone1.Texts = "1";
                }
                else
                {
                    textBoxPhone1.Texts = string.Empty;
                }
            }

            // Update the total price
            UpdateTotalPrice();
        }

        // When user selects a product, set Qty = 1 and show price
        private void rjComboBox3_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                string? selectedProduct = comboBox.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(selectedProduct) && productPriceMap.ContainsKey(selectedProduct))
                {
                    textBoxPhone2.Texts = "1";
                }
                else
                {
                    textBoxPhone2.Texts = string.Empty;
                }
            }

            // Update the total price
            UpdateTotalPrice();
        }

        // When user selects a product, set Qty = 1 and show price
        private void rjComboBox4_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                string? selectedProduct = comboBox.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(selectedProduct) && productPriceMap.ContainsKey(selectedProduct))
                {
                    textBoxPhone3.Texts = "1";
                }
                else
                {
                    textBoxPhone3.Texts = string.Empty;
                }
            }

            // Update the total price
            UpdateTotalPrice();
        }

        // When user selects a product, set Qty = 1 and show price
        private void rjComboBox5_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                string? selectedProduct = comboBox.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(selectedProduct) && productPriceMap.ContainsKey(selectedProduct))
                {
                    textBoxEmail1.Texts = "1";
                }
                else
                {
                    textBoxEmail1.Texts = string.Empty;
                }
            }

            // Update the total price
            UpdateTotalPrice();
        }

        // When user selects a product, set Qty = 1 and show price
        private void rjComboBox6_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                string? selectedProduct = comboBox.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(selectedProduct) && productPriceMap.ContainsKey(selectedProduct))
                {
                    textBoxEmail2.Texts = "1";
                }
                else
                {
                    textBoxEmail2.Texts = string.Empty;
                }
            }

            // Update the total price
            UpdateTotalPrice();
        }

        // When user selects a product, set Qty = 1 and show price
        private void rjComboBox7_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                string? selectedProduct = comboBox.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(selectedProduct) && productPriceMap.ContainsKey(selectedProduct))
                {
                    textBoxAddress.Texts = "1";
                }
                else
                {
                    textBoxAddress.Texts = string.Empty;
                }
            }

            // Update the total price
            UpdateTotalPrice();
        }

        // Calculate total price based on selected products and quantities
        private decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;

            var productInputs = new (object comboBox, RJCodeAdvance.RJControls.RJTextBox qtyTextBox)[]
            {
                (comboBox1, rjTextBox1),
                (rjComboBox1, rjTextBox2),
                (rjComboBox2, textBoxPhone1),
                (rjComboBox3, textBoxPhone2),
                (rjComboBox4, textBoxPhone3),
                (rjComboBox5, textBoxEmail1),
                (rjComboBox6, textBoxEmail2),
                (rjComboBox7, textBoxAddress)
            };

            foreach (var (comboBoxObj, qtyTextBox) in productInputs)
            {
                string? selectedProduct = null;

                if (comboBoxObj is ComboBox cb)
                    selectedProduct = cb.SelectedItem as string;
                else if (comboBoxObj is RJCodeAdvance.RJControls.RJComboBox rjcb)
                    selectedProduct = rjcb.SelectedItem as string;

                if (!string.IsNullOrEmpty(selectedProduct) && productPriceMap.ContainsKey(selectedProduct))
                {
                    int qty = 1;
                    if (!int.TryParse(qtyTextBox.Texts?.Trim(), out qty) || qty < 1)
                        qty = 1;
                    totalPrice += productPriceMap[selectedProduct] * qty;
                }
            }

            return totalPrice;
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            // Prevent saving again if already saved
            if (isAlreadySaved)
            {
                MessageBox.Show(
                    "Product details have already been saved. Duplicate save is not allowed.",
                    "Already Saved",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Assign product names safely from ComboBoxes
            product.product1 = comboBox1.SelectedItem?.ToString() ?? string.Empty;
            product.product2 = rjComboBox1.SelectedItem?.ToString() ?? string.Empty;
            product.product3 = rjComboBox2.SelectedItem?.ToString() ?? string.Empty;
            product.product4 = rjComboBox3.SelectedItem?.ToString() ?? string.Empty;
            product.product5 = rjComboBox4.SelectedItem?.ToString() ?? string.Empty;
            product.product6 = rjComboBox5.SelectedItem?.ToString() ?? string.Empty;
            product.product7 = rjComboBox6.SelectedItem?.ToString() ?? string.Empty;
            product.product8 = rjComboBox7.SelectedItem?.ToString() ?? string.Empty;

            // Helper function for quantity logic
            int? GetQty(string productName, string qtyText)
            {
                // Treat "Choose items" and empty as not selected
                if (string.IsNullOrWhiteSpace(productName) || productName.Trim().Equals("Choose items", StringComparison.OrdinalIgnoreCase))
                    return null;
                if (int.TryParse(qtyText.Trim(), out int qty))
                    return qty < 2 ? 1 : qty;
                return 1; // If invalid, but product is selected, default to 1
            }

            // Assign quantities using the logic: if product is available and Qty < 2, set Qty = 1
            product.qty1 = GetQty(product.product1, rjTextBox1.Texts);
            product.qty2 = GetQty(product.product2, rjTextBox2.Texts);
            product.qty3 = GetQty(product.product3, textBoxPhone1.Texts);
            product.qty4 = GetQty(product.product4, textBoxPhone2.Texts);
            product.qty5 = GetQty(product.product5, textBoxPhone3.Texts);
            product.qty6 = GetQty(product.product6, textBoxEmail1.Texts);
            product.qty7 = GetQty(product.product7, textBoxEmail2.Texts);
            product.qty8 = GetQty(product.product8, textBoxAddress.Texts);

            // get total price
            decimal totalPrice = CalculateTotalPrice();
            product.TotalAmount = totalPrice;
            rjTextBox3.Texts = totalPrice.ToString("F2", CultureInfo.InvariantCulture);

            // Optional: Show parsed values           
            var productLines = new List<string>();
            for (int i = 1; i <= 8; i++)
            {
                var productName = (string?)typeof(Product).GetProperty($"product{i}")?.GetValue(product);
                var qty = (int?)typeof(Product).GetProperty($"qty{i}")?.GetValue(product);

                if (!string.IsNullOrWhiteSpace(productName) && !productName.Trim().Equals("Choose items", StringComparison.OrdinalIgnoreCase))
                {
                    productLines.Add($"Product {i}: {productName}   Qty: {qty ?? 1}");
                }
            }

            string message = string.Join(Environment.NewLine, productLines);
            message += Environment.NewLine + "-----------------------------";
            message += Environment.NewLine + $"Total Amount: {product.TotalAmount:C2}";

            var result = MessageBox.Show(
                message,
                "Confirm Product Details",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );


            if (result != DialogResult.Yes)
            {
                // User cancelled, do not proceed
                return;
            }

            try
            {
                ProductBLL productBLL = new ProductBLL();
                bool success = productBLL.SaveFullProductEntry(product);

                if (success)
                {
                    isAlreadySaved = true;
                    lastSavedProduct = product;

                    var saveResult = MessageBox.Show(
                        "Product details have been saved successfully.\n\nDo you want to continue?",
                        "Save Confirmation",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Information
                    );

                    if (saveResult != DialogResult.OK)
                    {
                        // User chose Cancel, so do not proceed further
                        return;
                    }

                    this.Hide();

                    // Pass the last saved product to the confirmation form
                    var customerFormConfirm = new customerForm3Confirm(previousForm, product, _customer);
                    customerFormConfirm.Show();
                }
                else
                {
                    MessageBox.Show("Failed to save product details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred while saving product details.\n\n{ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
    }
}
