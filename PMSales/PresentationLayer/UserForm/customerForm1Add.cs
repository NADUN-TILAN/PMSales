using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;
using RJCodeAdvance.RJControls;

namespace PMSales.PresentationLayer.UserForm
{
    public partial class customerForm1Add : Form
    {
        public customerForm1Add()
        {
            InitializeComponent();
        }

        private void customerForm1Add_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton6_Click(object sender, EventArgs e)
        {
            var homeForm = new Dashboard();
            homeForm.Show();

            this.Close();
        }
    }
}
