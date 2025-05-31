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
using PMSalesBLL;
using PMSalesDomainEntities;
using RJCodeAdvance.RJControls;

namespace PMSales.PresentationLayer.UserForm
{
    public partial class salesFormReport : Form
    {
        private readonly SalesBL salesBL = new SalesBL();

        public salesFormReport()
        {
            InitializeComponent();
            DisplayCurrentDateTime();
            LoadSalesData();

            // Initialize labels for button tooltips
            labelAddButton = label6;
            labelDashButton = label7;
            labelAddPButton = label8;
            labelEmailButton = label9;
            labelSalesButton = label10;
            labelSearchButton = label11;
            labelHelpButton = label12;
        }

        private void DisplayCurrentDateTime()
        {
            var now = DateTime.Now;
            labelCustomerCounttx.Text = now.ToString("yyyy-MM-dd hh:mm:ss tt");
        }

        // 1. Add this to the field declarations (with the other controls)
        private Label? labelAddButton;
        private Label? labelDashButton;
        private Label? labelAddPButton;
        private Label? labelEmailButton;
        private Label? labelSalesButton;
        private Label? labelSearchButton;
        private Label? labelHelpButton;

        #region btn 4 and 6 and 7 and 9
        //btn 4
        private void rjButton4_MouseHover(object sender, EventArgs e) //eveent 1
        {
            ApplyHoverStyle(rjButton4);
            labelAddButton!.Text = "Add New Sale";
            labelAddButton.Visible = true;
        }

        private void rjButton4_MouseLeave(object sender, EventArgs e) //eveent 2
        {
            ApplyLeaveStyle(rjButton4);
            labelAddButton!.Visible = false;
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

        private void rjButton4_Click(object sender, EventArgs e)
        {

        }

        //btn 6
        private void rjButton6_MouseHover(object sender, EventArgs e) //eveent 1
        {
            ApplyHoverStyle(rjButton6);
            labelDashButton!.Text = "Dashboard";
            labelDashButton.Visible = true;
        }

        private void rjButton6_MouseLeave(object sender, EventArgs e) //eveent 2
        {
            ApplyLeaveStyle(rjButton6);
            labelDashButton!.Visible = false;
        }

        //private void rjButton6_MouseClick(object sender, MouseEventArgs e) //eveent 3
        //{
        //    ApplyClickStyle(rjButton6);
        //}

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
            labelAddPButton!.Text = "Add New Item";
            labelAddPButton.Visible = true;
        }

        private void rjButton7_MouseLeave(object sender, EventArgs e) //eveent 2
        {
            ApplyLeaveStyle(rjButton7);
            labelAddPButton!.Visible = false;
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

        //btn 8
        private void rjButton8_MouseHover(object sender, EventArgs e) //eveent 1
        {
            ApplyHoverStyle(rjButton8);
            labelEmailButton!.Text = "Check Mails";
            labelEmailButton.Visible = true;
        }

        private void rjButton8_MouseLeave(object sender, EventArgs e) //eveent 2
        {
            ApplyLeaveStyle(rjButton8);
            labelEmailButton!.Visible = false;
        }

        private void rjButton8_MouseClick(object sender, MouseEventArgs e) //eveent 3
        {
            ApplyClickStyle(rjButton8);
        }

        private void rjButton8_MouseDown(object sender, MouseEventArgs e) //eveent 4
        {
            ApplyPressedStyle(rjButton8);
        }

        private void rjButton8_MouseUp(object sender, MouseEventArgs e) //eveent 5
        {
            ApplyHoverStyle(rjButton8);
        }

        //btn 9
        private void rjButton9_MouseHover(object sender, EventArgs e) //eveent 1
        {
            ApplyHoverStyle(rjButton9);
            labelSalesButton!.Text = "View Sales";
            labelSalesButton.Visible = true;
        }

        private void rjButton9_MouseLeave(object sender, EventArgs e) //eveent 2
        {
            ApplyLeaveStyle(rjButton9);
            labelSalesButton!.Visible = false;
        }

        private void rjButton9_Click(object sender, EventArgs e)
        {
            ApplyHoverStyle(rjButton9);
        }

        private void rjButton9_MouseDown(object sender, MouseEventArgs e) //eveent 4
        {
            ApplyPressedStyle(rjButton9);
        }

        private void rjButton9_MouseUp(object sender, MouseEventArgs e) //eveent 5
        {
            ApplyHoverStyle(rjButton9);
        }

        //btn 10
        private void rjButton10_MouseHover(object sender, EventArgs e) //eveent 1
        {
            ApplyHoverStyle(rjButton10);
            labelSearchButton!.Text = "Search & Edit";
            labelSearchButton.Visible = true;
        }

        private void rjButton10_MouseLeave(object sender, EventArgs e) //eveent 2
        {
            ApplyLeaveStyle(rjButton10);
            labelSearchButton!.Visible = false;
        }

        private void rjButton10_MouseClick(object sender, MouseEventArgs e) //eveent 3
        {
            ApplyClickStyle(rjButton10);
        }

        private void rjButton10_MouseDown(object sender, MouseEventArgs e) //eveent 4
        {
            ApplyPressedStyle(rjButton10);
        }

        private void rjButton10_MouseUp(object sender, MouseEventArgs e) //eveent 5
        {
            ApplyHoverStyle(rjButton10);
        }

        //btn 11
        private void rjButton11_MouseHover(object sender, EventArgs e) //eveent 1
        {
            ApplyHoverStyle(rjButton11);
            labelHelpButton!.Text = "Help";
            labelHelpButton.Visible = true;
        }

        private void rjButton11_MouseLeave(object sender, EventArgs e) //eveent 2
        {
            ApplyLeaveStyle(rjButton11);
            labelHelpButton!.Visible = false;
        }

        private void rjButton11_MouseClick(object sender, MouseEventArgs e) //eveent 3
        {
            ApplyClickStyle(rjButton11);
        }

        private void rjButton11_MouseDown(object sender, MouseEventArgs e) //eveent 4
        {
            ApplyPressedStyle(rjButton11);
        }

        private void rjButton11_MouseUp(object sender, MouseEventArgs e) //eveent 5
        {
            ApplyHoverStyle(rjButton11);
        }
        #endregion 

        #region btn design methods
        private void ApplyHoverStyle(RJButton button)
        {
            button.BackColor = Color.FromArgb(77, 182, 172); // Teal for hover effect
            button.BorderColor = Color.FromArgb(153, 233, 255); // Slightly darker teal for border
            button.BorderSize = 3;
            button.ForeColor = Color.White; // White text for contrast
            button.Font = new Font(button.Font.FontFamily, button.Font.Size, FontStyle.Bold); // Bold text
            button.Cursor = Cursors.Hand; // Hand cursor for better UX
        }

        private void ApplyLeaveStyle(RJButton button)
        {
            button.BackColor = Color.FromArgb(245, 245, 245); // Light Gray for neutral state
            button.BorderColor = Color.FromArgb(200, 200, 200); // Subtle Gray border
            button.BorderSize = 2;
            button.ForeColor = Color.Black; // Black text for readability
            button.Font = new Font(button.Font.FontFamily, button.Font.Size, FontStyle.Regular); // Regular text
        }

        private void ApplyClickStyle(RJButton button)
        {
            button.BackColor = Color.FromArgb(33, 150, 243); // Vibrant Blue for click effect
            button.BorderColor = Color.FromArgb(25, 118, 210); // Darker Blue for border
            button.BorderSize = 4;
            button.ForeColor = Color.White; // White text for contrast
        }

        private void ApplyPressedStyle(RJButton button)
        {
            button.BackColor = Color.FromArgb(30, 136, 229); // Slightly darker blue for pressed effect
            button.BorderColor = Color.FromArgb(21, 101, 192); // Even darker border
            button.BorderSize = 5;
            button.ForeColor = Color.White; // White text for contrast
        }
        #endregion

        #region Features
        private void salesReportGridviwer_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            if (grid == null)
                return;

            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            Rectangle headerBounds = new Rectangle(
                e.RowBounds.Left,
                e.RowBounds.Top,
                grid.RowHeadersWidth,
                e.RowBounds.Height);

            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            // Instantiate the Dashboard2View form
            var Dashboard2View = new Dashboard();

            // Show the Dashboard2View form
            Dashboard2View.Show();

            // Close the current Dashboard form
            this.Close();
        }

        private void rjButton6_Click(object sender, EventArgs e)
        {
            // Instantiate the customerForm1Add form
            var customerForm = new Dashboard();

            // Show the customerForm1Add form
            customerForm.Show();

            // Close the current Dashboard form
            this.Close();
        }

        private void rjButton7_Click(object sender, EventArgs e)
        {
            var productForm = new productFormAddNewItems();
            productForm.Show();

            this.Close();
        }


        #endregion

        private void LoadSalesData()
        {
            try
            {
                var salesList = salesBL.GetAllSales();
                if (salesList == null || salesList.Count == 0)
                {
                    MessageBox.Show("No sales data found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                salesReportGridviwer.DataSource = salesList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading sales data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
