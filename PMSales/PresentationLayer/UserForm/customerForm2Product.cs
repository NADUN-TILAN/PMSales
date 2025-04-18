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
        public customerForm2Product()
        {
            InitializeComponent();
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {            
            this.Hide();
            var customerForm1 = new customerForm1Add();
            customerForm1.Show();
        }
    }
}
