using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMSales.BusinessLayer;

namespace PMSales.PresentationLayer.UserForm
{
    public partial class customerForm2Product : Form
    {
        private readonly customerForm1Add previousForm;

        // Constructor that takes the previous form and concatenated name as parameters
        public customerForm2Product(customerForm1Add form, string fullName)
        {
            InitializeComponent();
            previousForm = form;

            // Set the concatenated name in textBoxName
            textBoxName.Texts = fullName;

            // Disable the textBoxName to make it read-only
            textBoxName.Enabled = false;

            // Alternatively, you can handle the KeyPress event to prevent input
            // textBoxName.KeyPress += (s, e) => e.Handled = true;

            PopulateComboBoxes();
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show(); // Show the previous form with filled data
        }

        private void PopulateComboBoxes()
        {
            try
            {
                var productBL = new ProductBLL();
                List<string> products = productBL.GetProductNames();

                if (products.Count == 0)
                {
                    MessageBox.Show("No products available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Populate all combo boxes
                comboBox1.Items.AddRange(products.ToArray());
                rjComboBox1.Items.AddRange(products.ToArray());
                rjComboBox2.Items.AddRange(products.ToArray());
                rjComboBox3.Items.AddRange(products.ToArray());
                rjComboBox4.Items.AddRange(products.ToArray());
                rjComboBox5.Items.AddRange(products.ToArray());
                rjComboBox6.Items.AddRange(products.ToArray());
                rjComboBox7.Items.AddRange(products.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
