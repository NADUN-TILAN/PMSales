using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using PMSales.BusinessLayer;
using PMSalesDomainEntities;
using RJCodeAdvance.RJControls;

namespace PMSales.PresentationLayer.UserForm
{
    public partial class customerForm2Product : Form
    {
        private readonly customerForm1Add previousForm;

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

        // Method to calculate the total price based on selected items
        private void UpdateTotalPrice()
        {
            decimal totalPrice = 0;

            // List of all combo boxes
            var comboBoxes = new[] { comboBox1, rjComboBox1, rjComboBox2, rjComboBox3, rjComboBox4, rjComboBox5, rjComboBox6, rjComboBox7 };

            foreach (var comboBox in comboBoxes)
            {
                if (comboBox.SelectedItem is string selectedProduct && productPriceMap.ContainsKey(selectedProduct))
                {
                    totalPrice += productPriceMap[selectedProduct];
                }
            }

            // Update the total price in rjTextBox3
            rjTextBox3.Texts = totalPrice.ToString("F2");
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            // Assign product names from combo boxes
            product.product1 = comboBox1.SelectedItem?.ToString();
            product.product2 = rjComboBox1.SelectedItem?.ToString();
            product.product3 = rjComboBox2.SelectedItem?.ToString();
            product.product4 = rjComboBox3.SelectedItem?.ToString();
            product.product5 = rjComboBox4.SelectedItem?.ToString();
            product.product6 = rjComboBox5.SelectedItem?.ToString();
            product.product7 = rjComboBox6.SelectedItem?.ToString();
            product.product8 = rjComboBox7.SelectedItem?.ToString();

            // Assign quantities using .Text instead of .Texts
            product.qty1 = int.TryParse(rjTextBox1.Text.Trim(), out int q1) ? q1 : 0;
            product.qty2 = int.TryParse(rjTextBox2.Text.Trim(), out int q2) ? q2 : 0;
            product.qty3 = int.TryParse(textBoxPhone1.Text.Trim(), out int q3) ? q3 : 0;
            product.qty4 = int.TryParse(textBoxPhone2.Text.Trim(), out int q4) ? q4 : 0;
            product.qty5 = int.TryParse(textBoxPhone3.Text.Trim(), out int q5) ? q5 : 0;
            product.qty6 = int.TryParse(textBoxEmail1.Text.Trim(), out int q6) ? q6 : 0;
            product.qty7 = int.TryParse(textBoxEmail2.Text.Trim(), out int q7) ? q7 : 0;
            product.qty8 = int.TryParse(textBoxAddress.Text.Trim(), out int q8) ? q8 : 0;

            // Parse total amount using .Text
            product.TotalAmount = decimal.TryParse(rjTextBox3.Text.Trim(), out decimal total) ? total : 0;

            // Optional: Show values for debugging
            MessageBox.Show(
                $"Qty1: {product.qty1}, Qty2: {product.qty2}, Qty3: {product.qty3}, Qty4: {product.qty4}\n" +
                $"Qty5: {product.qty5}, Qty6: {product.qty6}, Qty7: {product.qty7}, Qty8: {product.qty8}\n" +
                $"TotalAmount: {product.TotalAmount}",
                "Parsed Values", MessageBoxButtons.OK, MessageBoxIcon.Information
            );

            try
            {
                ProductBLL productBLL = new ProductBLL();
                bool success = productBLL.SaveFullProductEntry(product);

                if (success)
                {
                    MessageBox.Show("Product details saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    previousForm.Show();
                }
                else
                {
                    MessageBox.Show("Failed to save product details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






    }
}
