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

        // Constructor that takes the previous form as a parameter
        public customerForm2Product(customerForm1Add form)
        {
            InitializeComponent();
            previousForm = form;
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show(); // Show the previous form with filled data
        }
    }
}
