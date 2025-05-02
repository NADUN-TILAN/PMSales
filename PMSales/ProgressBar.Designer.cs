using System;
using System.Drawing;
using System.Windows.Forms;
using ReaLTaiizor.Controls;

namespace PMSales
{
    partial class ProgressBar
    {
        private ReaLTaiizor.Controls.HopeProgressBar hopeProgressBar1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressBar));
            hopeProgressBar1 = new HopeProgressBar();
            label1 = new Label();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // hopeProgressBar1
            // 
            hopeProgressBar1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            hopeProgressBar1.BarColor = Color.FromArgb(230, 230, 230);
            hopeProgressBar1.BaseColor = Color.DodgerBlue;
            hopeProgressBar1.DangerColor = Color.FromArgb(245, 108, 108);
            hopeProgressBar1.Font = new Font("Segoe UI", 10F);
            hopeProgressBar1.ForeColor = Color.White;
            hopeProgressBar1.FullBallonColor = Color.FromArgb(103, 194, 58);
            hopeProgressBar1.FullBallonText = "Done!";
            hopeProgressBar1.FullBarColor = Color.FromArgb(46, 204, 113);
            hopeProgressBar1.IsError = false;
            hopeProgressBar1.Location = new Point(0, 230);
            hopeProgressBar1.Name = "hopeProgressBar1";
            hopeProgressBar1.ProgressBarStyle = HopeProgressBar.Style.ToolTip;
            hopeProgressBar1.Size = new Size(556, 32);
            hopeProgressBar1.TabIndex = 0;
            hopeProgressBar1.Text = "hopeProgressBar1";
            hopeProgressBar1.ValueNumber = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(38, 141);
            label1.Name = "label1";
            label1.Size = new Size(213, 16);
            label1.TabIndex = 1;
            label1.Text = "© 2025 Newsoft. All rights reserved.";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.NewSoft___Copy;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(125, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 214);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(146, -26);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 188);
            panel2.TabIndex = 3;
            // 
            // ProgressBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(556, 263);
            Controls.Add(hopeProgressBar1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Cursor = Cursors.WaitCursor;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProgressBar";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }
        private Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
