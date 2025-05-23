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
    public partial class Dashboard3 : Form
    {
        public Dashboard3()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            // Instantiate the Dashboard1View form
            var Dashboard2View = new Dashboard2();

            // Show the Dashboard1View form
            Dashboard2View.Show();

            // Close the current Dashboard form
            this.Close();
        }
    }
}
