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

        private void Query_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String email = "DigiScanTrack@queries.com";
            string subjectLine = "DigiScan&Track Application Query";

            string mailToEmail = $"mailto:{email}?subject={subjectLine}";
            Process.Start(new ProcessStartInfo(mailToEmail));

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
