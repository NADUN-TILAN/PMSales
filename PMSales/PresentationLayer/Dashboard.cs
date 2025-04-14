using PMSales.PresentationLayer.UserForm;
using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMSales.PresentationLayer
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            DisplayAssemblyVersion();
        }

        private void DisplayAssemblyVersion()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "Unknown Version";
            labelCustomerCounttx.Text = $"Vs.{version}";
        }

        #region btn 4 and 6
        //btn 4
        private void rjButton4_MouseHover(object sender, EventArgs e) //eveent 1
        {
            ApplyHoverStyle(rjButton4);
        }

        private void rjButton4_MouseLeave(object sender, EventArgs e) //eveent 2
        {
            ApplyLeaveStyle(rjButton4);
        }

        private void rjButton4_MouseClick(object sender, MouseEventArgs e) //eveent 3
        {
            ApplyClickStyle(rjButton4);
        }

        private void rjButton4_MouseDown(object sender, MouseEventArgs e) //eveent 4
        {
            ApplyPressedStyle(rjButton4);
        }

        private void rjButton4_MouseUp(object sender, MouseEventArgs e) //eveent 5
        {
            ApplyHoverStyle(rjButton4);
        }

        //btn 6
        private void rjButton6_MouseHover(object sender, EventArgs e) //eveent 1
        {
            ApplyHoverStyle(rjButton6);
        }

        private void rjButton6_MouseLeave(object sender, EventArgs e) //eveent 2
        {
            ApplyLeaveStyle(rjButton6);
        }

        private void rjButton6_MouseClick(object sender, MouseEventArgs e) //eveent 3
        {
            ApplyClickStyle(rjButton6);
        }

        private void rjButton6_MouseDown(object sender, MouseEventArgs e) //eveent 4
        {
            ApplyPressedStyle(rjButton6);
        }

        private void rjButton6_MouseUp(object sender, MouseEventArgs e) //eveent 5
        {
            ApplyHoverStyle(rjButton6);
        }

        //btn 7
        private void rjButton7_MouseHover(object sender, EventArgs e) //eveent 1
        {
            ApplyHoverStyle(rjButton7);
        }

        private void rjButton7_MouseLeave(object sender, EventArgs e) //eveent 2
        {
            ApplyLeaveStyle(rjButton7);
        }

        private void rjButton7_MouseClick(object sender, MouseEventArgs e) //eveent 3
        {
            ApplyClickStyle(rjButton7);
        }

        private void rjButton7_MouseDown(object sender, MouseEventArgs e) //eveent 4
        {
            ApplyPressedStyle(rjButton7);
        }

        private void rjButton7_MouseUp(object sender, MouseEventArgs e) //eveent 5
        {
            ApplyHoverStyle(rjButton7);
        }
        #endregion 

        #region btn design methods
        private void ApplyHoverStyle(RJButton button)
        {
            button.BackColor = Color.FromArgb(173, 216, 230); // LightBlue with transparency
            //button.BorderColor = Color.Red;
            button.BorderSize = 3;
            button.ForeColor = Color.White; // Change text color for better contrast
            button.Font = new Font(button.Font.FontFamily, button.Font.Size, FontStyle.Bold); // Bold text
            button.Cursor = Cursors.Hand; // Change cursor to hand for better UX
        }

        private void ApplyLeaveStyle(RJButton button)
        {
            button.BackColor = SystemColors.Control; // Reset to default
            button.BorderColor = Color.BlueViolet;
            button.BorderSize = 2;
            button.ForeColor = Color.Black; // Reset text color
            button.Font = new Font(button.Font.FontFamily, button.Font.Size, FontStyle.Regular); // Regular text
        }

        private void ApplyClickStyle(RJButton button)
        {
            button.BackColor = Color.FromArgb(100, 149, 237); // CornflowerBlue for click effect
            button.BorderColor = Color.DarkBlue;
            button.BorderSize = 4;
            button.ForeColor = Color.White;
        }

        private void ApplyPressedStyle(RJButton button)
        {
            button.BackColor = Color.FromArgb(70, 130, 180); // SteelBlue for pressed effect
            button.BorderColor = Color.DarkRed;
            button.BorderSize = 5;
            button.ForeColor = Color.White;
        }
        #endregion

        #region Features
        //Customers 
        private void rjButton4_Click(object sender, EventArgs e)
        {
            // Instantiate the customerForm1Add form
            var customerForm = new customerForm1Add();

            // Show the customerForm1Add form
            customerForm.Show();

            // Close the current Dashboard form
            this.Close();
        }

        #endregion

        

    }
}
