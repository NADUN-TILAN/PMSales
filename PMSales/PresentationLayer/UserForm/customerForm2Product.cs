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

        // Constructor
        public customerForm2Product(customerForm1Add form, string fullName)
        {
            InitializeComponent();
            previousForm = form;

            textBoxName.Texts = fullName;
            textBoxName.Enabled = false;
            rjTextBox3.Enabled = false;

            PopulateComboBoxes();
        }

        // Back button
        private void rjButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
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
                this.Hide();
                var customerForm2 = new customerForm2Product(previousForm, textBoxName.Texts.Trim());
                customerForm2.Show();
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
            MessageBox.Show(
                $"Product1: {product.product1}, Qty1: {product.qty1}, " +
                $"Product2: {product.product2}, Qty2: {product.qty2}, " +
                $"Product3: {product.product3}, Qty3: {product.qty3}, " +
                $"Product4: {product.product4}, Qty4: {product.qty4}\n" +
                $"Product5: {product.product5}, Qty5: {product.qty5}, " +
                $"Product6: {product.product6}, Qty6: {product.qty6}, " +
                $"Product7: {product.product7}, Qty7: {product.qty7}, " +
                $"Product8: {product.product8}, Qty8: {product.qty8}\n" +
                $"TotalAmount: {product.TotalAmount}",
                "Parsed Values", MessageBoxButtons.OK, MessageBoxIcon.Information
            );

            try
            {
                ProductBLL productBLL = new ProductBLL();
                bool success = productBLL.SaveFullProductEntry(product);

                if (success)
                {
                    isAlreadySaved = true;
                    lastSavedProduct = product;
                    MessageBox.Show("Product details saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    // Show confirmation form
                    var customerFormConfirm = new customerForm3Confirm();
                    customerFormConfirm.Show();

                    if (previousForm != null && !previousForm.IsDisposed)
                    {
                        previousForm.Show();
                    }
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
