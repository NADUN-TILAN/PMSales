﻿using PMSales.PresentationLayer;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace PMSales
{
    public partial class ProgressBar : Form
    {
        private System.Windows.Forms.Timer? progressTimer;

        public ProgressBar()
        {
            InitializeComponent();
            DisplayAssemblyVersion();
            Load += Form1_Load;
        }

        private void DisplayAssemblyVersion()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "Unknown Version";
            labelCustomerCounttx.Text = $"Vs{version}";
        }

        private void Form1_Load(object? sender, EventArgs e) // Updated nullability of 'sender'
        {
            // Initialize progress bar properties
            hopeProgressBar1.ValueNumber = 0;
            hopeProgressBar1.FullBallonText = "✔️";
            hopeProgressBar1.ProgressBarStyle = ReaLTaiizor.Controls.HopeProgressBar.Style.ToolTip;

            // Optional: Update color at runtime (already set in Designer)
            // hopeProgressBar1.BaseColor = Color.MediumSlateBlue;

            // Initialize and start progress timer
            progressTimer = new System.Windows.Forms.Timer();
            progressTimer.Interval = 50; // Smooth animation speed
            progressTimer.Tick += ProgressTimer_Tick; // Correct event
            progressTimer.Start();
        }

        private void ProgressTimer_Tick(object? sender, EventArgs e)
        {
            try
            {
                if (progressTimer != null && hopeProgressBar1.ValueNumber < 100)
                {
                    hopeProgressBar1.ValueNumber += 1;
                }
                else if (progressTimer != null)
                {
                    progressTimer.Stop();

                    // Redirect to Dashboard
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();

                    // Hide the ProgressBar form instead of closing it
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressTimer?.Stop();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                progressTimer?.Dispose();
            }
            base.Dispose(disposing);
        }        
    }
}
