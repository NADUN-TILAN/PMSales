using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show(); // Show the previous form with filled data
        }
    }
}
