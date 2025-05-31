using PMSales.PresentationLayer.UserForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMSales.PresentationLayer
{
    public partial class HelpForm2 : Form
    {
        public HelpForm2()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            var HelpForm3View = new HelpForm3();

            HelpForm3View.Show();

            this.Close();
        }

        private void rjButton17_Click(object sender, EventArgs e)
        {
            var HelpForm1View = new HelpForm();

            HelpForm1View.Show();

            this.Close();
        }
    }
}
