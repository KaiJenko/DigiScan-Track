using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiScan_Track
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string fullName = ouUsernametxt.Text;
            string password = ouPasswordtxt.Text;

        }

        private void clearFieldslbl_Click(object sender, EventArgs e)
        {
            ouUsernametxt.Clear();
            ouPasswordtxt.Clear();
            fullNametxt.Clear();
            employeeIDtxt.Clear();
            passwordtxt.Clear();
            retypePasswordtxt.Clear();
        }

        private void registerLinklbl_Click(object sender, EventArgs e)
        {
            oldUserpnl.Visible = false;
            newUserpnl.Visible = true;
            ouUsernametxt.Clear();
            ouPasswordtxt.Clear();
        }

        private void signInLinklbl_Click(object sender, EventArgs e)
        {
            oldUserpnl.Visible = true;
            newUserpnl.Visible = false;
            fullNametxt.Clear();
            employeeIDtxt.Clear();
            passwordtxt.Clear();
            retypePasswordtxt.Clear();
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == textBox.Tag?.ToString())
            {
                textBox.Clear();
                textBox.ForeColor = Color.FromArgb(0, 126, 249);
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Tag.ToString();
                textBox.ForeColor = Color.RosyBrown;
            }
        }
    }
}
