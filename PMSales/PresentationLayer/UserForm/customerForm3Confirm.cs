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
    public partial class customerForm3Confirm : Form
    {
        private readonly customerForm1Add previousForm;

        public customerForm3Confirm()
        {
            this.previousForm = previousForm ?? throw new ArgumentNullException(nameof(previousForm));
            InitializeComponent();

        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
        }

    }
}
