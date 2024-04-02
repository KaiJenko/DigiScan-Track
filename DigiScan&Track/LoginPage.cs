using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DigiScan_Track
{
    public partial class LoginPage : Form
    {

        SqlConnection conn = new SqlConnection();

        public LoginPage()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string username = ouUsernametxt.Text;
            string password = ouPasswordtxt.Text;

            conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT [Username], [Password], [Permission] FROM [UserLogin] WHERE [Username] = '" + username + "' AND [Password] = '" + password + "'";
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                string PermissionLevel = dr["Permission"].ToString();
                MessageBox.Show("You have been logged in");
                UserLoginDetails.Instance.Username = username;
                UserLoginDetails.Instance.loggedIN = true;
                UserLoginDetails.Instance.Permission = PermissionLevel;
                UpdateHomePageLoginStatus();

            }

            else
            {
                MessageBox.Show("Login values incorrect");
            }

            conn.Close();
        }

        public void UpdateHomePageLoginStatus()
        {
            if (Application.OpenForms["HomePage"] is HomePage homePage)
            {
                homePage.Invoke((MethodInvoker)delegate
                {
                    homePage.setLogin();
                    homePage.HomePageShortcutsbtn.PerformClick();
                });
            }
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

        private void createLoginbtn_Click(object sender, EventArgs e)
        {
            string fullName = fullNametxt.Text;
            string employeeID = employeeIDtxt.Text;
            string password = passwordtxt.Text;
            string retypePassword = retypePasswordtxt.Text;

            string username = fullName.Replace(" ", ".");

            if (password == retypePassword)
            {
                conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT [FullName], [EmployeeID] FROM [UserLogin] WHERE [FullName] = '" + fullName + "' AND [EmployeeID] = '" + employeeID + "'";
                SqlDataReader dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    dr.Close();
                    string sqlUpdate = " UPDATE [UserLogin] SET [Username] = '" + username + "', [Password] = '" + password + "', [Permission] = 'Read'" +
                                       " WHERE [FullName] = '" + fullName + "' AND [EmployeeID] = '" + employeeID + "'";
                    SqlCommand cmd2 = new SqlCommand(sqlUpdate, conn);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Employee login created");
                    newUserpnl.Visible = false;
                    oldUserpnl.Visible = true;
                }

                else
                {
                    MessageBox.Show("Employee not found");
                }

                conn.Close();
            }

            else
            {
                MessageBox.Show("Passwords do not match");
            }
        }


    }
}
