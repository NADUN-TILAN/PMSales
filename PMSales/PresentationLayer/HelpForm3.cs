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
    public partial class HelpForm3 : Form
    {
        public HelpForm3()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            var HelpForm4View = new HelpForm4();

            HelpForm4View.Show();

            this.Close();
        }

        private void rjButton17_Click(object sender, EventArgs e)
        {
            var HelpForm2View = new HelpForm2();

            HelpForm2View.Show();

            this.Close();
        }
    }
}
