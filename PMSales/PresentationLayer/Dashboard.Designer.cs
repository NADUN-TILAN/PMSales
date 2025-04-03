using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp; // Ensure you have added the FontAwesome.Sharp NuGet package

namespace PMSales.PresentationLayer
{
    public partial class Dashboard : Form
    {
        private System.ComponentModel.IContainer components = null;
        private Panel headerPanel;
        private Label titleLabel;
        private Panel sidebarPanel;
        private ToolTip toolTip;
        private Panel contentPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.panelItems = new System.Windows.Forms.Panel();
            this.homeButton = new FontAwesome.Sharp.IconButton();
            this.settingsButton = new FontAwesome.Sharp.IconButton();
            this.logoutButton = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.contentPanel = new System.Windows.Forms.Panel();
            this.headerPanel.SuspendLayout();
            this.sidebarPanel.SuspendLayout();
            this.panelItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(46, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1338, 60);
            this.headerPanel.TabIndex = 0;
            this.headerPanel.UseWaitCursor = true;
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1338, 60);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "📊 Dashboard";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.UseWaitCursor = true;
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.sidebarPanel.Controls.Add(this.panelItems);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(46, 669);
            this.sidebarPanel.TabIndex = 1;
            this.sidebarPanel.UseWaitCursor = true;
            // 
            // panelItems
            // 
            this.panelItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelItems.Controls.Add(this.homeButton);
            this.panelItems.Controls.Add(this.settingsButton);
            this.panelItems.Controls.Add(this.logoutButton);
            this.panelItems.Controls.Add(this.iconButton1);
            this.panelItems.Controls.Add(this.iconButton2);
            this.panelItems.Controls.Add(this.iconButton3);
            this.panelItems.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelItems.Location = new System.Drawing.Point(0, 0);
            this.panelItems.Name = "panelItems";
            this.panelItems.Size = new System.Drawing.Size(46, 669);
            this.panelItems.TabIndex = 3;
            this.panelItems.UseWaitCursor = true;
            // 
            // homeButton
            // 
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.homeButton.IconColor = System.Drawing.Color.White;
            this.homeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.homeButton.IconSize = 32;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(0, 250);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(46, 50);
            this.homeButton.TabIndex = 3;
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.homeButton, "Go to Home");
            this.homeButton.UseWaitCursor = true;
            // 
            // settingsButton
            // 
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.settingsButton.IconColor = System.Drawing.Color.White;
            this.settingsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.settingsButton.IconSize = 32;
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.Location = new System.Drawing.Point(0, 200);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(46, 50);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.Text = "  ";
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.settingsButton, "Open Settings");
            this.settingsButton.UseWaitCursor = true;
            // 
            // logoutButton
            // 
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.logoutButton.IconColor = System.Drawing.Color.White;
            this.logoutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logoutButton.IconSize = 32;
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.Location = new System.Drawing.Point(0, 150);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(46, 50);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = " ";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.logoutButton, "Log out of the application");
            this.logoutButton.UseWaitCursor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 100);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(46, 50);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.iconButton1, "Go to Home");
            this.iconButton1.UseWaitCursor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 32;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 50);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(46, 50);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.Text = "  ";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.iconButton2, "Open Settings");
            this.iconButton2.UseWaitCursor = true;
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 32;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(46, 50);
            this.iconButton3.TabIndex = 2;
            this.iconButton3.Text = " ";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.iconButton3, "Log out of the application");
            this.iconButton3.UseWaitCursor = true;
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.contentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(46, 60);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1338, 609);
            this.contentPanel.TabIndex = 2;
            this.contentPanel.UseWaitCursor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 669);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.sidebarPanel);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "Dashboard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.UseWaitCursor = true;
            this.headerPanel.ResumeLayout(false);
            this.sidebarPanel.ResumeLayout(false);
            this.panelItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            var button = sender as IconButton;
            if (button != null)
            {
                button.BackColor = Color.FromArgb(50, 50, 55);
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            var button = sender as IconButton;
            if (button != null)
            {
                button.BackColor = Color.FromArgb(45, 45, 48);
            }
        }

        private Panel panelItems;
        private IconButton homeButton;
        private IconButton settingsButton;
        private IconButton logoutButton;
        private IconButton iconButton1;
        private IconButton iconButton2;
        private IconButton iconButton3;
    }
}
