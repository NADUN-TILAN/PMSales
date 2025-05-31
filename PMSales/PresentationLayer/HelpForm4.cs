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
    public partial class HelpForm4 : Form
    {
        public HelpForm4()
        {
            InitializeComponent();
        }

        private void rjButton17_Click(object sender, EventArgs e)
        {
            var HelpForm3View = new HelpForm3();

            HelpForm3View.Show();

            this.Close();
        }
    }
}
