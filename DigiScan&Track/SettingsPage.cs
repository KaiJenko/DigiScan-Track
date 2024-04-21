using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiScan_Track
{
    public partial class SettingsPage : Form
    {
        public SettingsPage()
        {
            InitializeComponent();
        }



        private void SendEmail(string recipientEmail, string subject)
        {
            try
            {
                string mailtoLink = $"mailto:{recipientEmail}?subject={Uri.EscapeDataString(subject)}";
                Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = $"/c start {mailtoLink}",
                    CreateNoWindow = true,
                    UseShellExecute = false
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Email_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SendEmail("digiscantrackQueries@gmail.com", "DigiScan&Track Application Query");
        }

        private void TableauLinklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.tableau.com/en-gb/learn/get-started/viewer";
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };

            Process.Start(startInfo);
        }

        private void AppHelplbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            appHelppnl.Visible = true;
        }
    }
}
