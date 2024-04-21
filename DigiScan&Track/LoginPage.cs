using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace DigiScan_Track
{
    public partial class LoginPage : Form
    {

        SqlConnection conn = new SqlConnection();

        public LoginPage()
        {
            InitializeComponent();
        }


        //Validation for the user logging in - such as not including the . or not being case sensitive 
        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string username = ouUsernametxt.Text;
            string password = ouPasswordtxt.Text;

            if (username.Contains(" "))
            {
                MessageBox.Show("The username is your fullname with the space replaced by a full stop");
            }

            else
            {

                string[] splitUsername = username.Split('.');
                string firstname = splitUsername[0];
                string lastname = splitUsername[1];

                conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT [Username], [Password], [Permission] FROM [UserLogin] WHERE [Username] = '" + username + "' AND [Password] = '" + password + "'";
                SqlDataReader dr = cmd.ExecuteReader();

                //If it pulls back a row then it means the username and password was correct
                if (dr.HasRows)
                {
                    dr.Read();
                    string PermissionLevel = dr["Permission"].ToString();
                    MessageBox.Show("You have been logged in");
                    UserLoginDetails.Instance.Username = firstname + " " + lastname;
                    UserLoginDetails.Instance.loggedIN = true;
                    UserLoginDetails.Instance.Permission = PermissionLevel;
                    UpdateHomePageLoginStatus();

                    HomePage homePage = new HomePage();
                    homePage.HomePageShortcutsbtn.PerformClick();
                }

                else
                {
                    MessageBox.Show("Login values incorrect");
                }

                conn.Close();
            }
        }


        //As the homepage is always open it has to be directly invoked, especially when changing controls still active
        //Here it calls the setlogin function whihc logs in the user by essentially removing the login button and displaying their username
        public static void UpdateHomePageLoginStatus()
        {
            if (Application.OpenForms["HomePage"] is HomePage homePage)
            {
                homePage.Invoke((MethodInvoker)delegate
                {
                    homePage.SetLogin();
                    homePage.HomePageShortcutsbtn.PerformClick();
                });
            }
        }



        private void ClearFieldslbl_Click(object sender, EventArgs e)
        {
            ouUsernametxt.Clear();
            ouPasswordtxt.Clear();
            fullNametxt.Clear();
            employeeIDtxt.Clear();
            passwordtxt.Clear();
            retypePasswordtxt.Clear();
        }



        private void RegisterLinklbl_Click(object sender, EventArgs e)
        {
            oldUserpnl.Visible = false;
            newUserpnl.Visible = true;
            ouUsernametxt.Clear();
            ouPasswordtxt.Clear();
        }



        private void SignInLinklbl_Click(object sender, EventArgs e)
        {
            oldUserpnl.Visible = true;
            newUserpnl.Visible = false;
            fullNametxt.Clear();
            employeeIDtxt.Clear();
            passwordtxt.Clear();
            retypePasswordtxt.Clear();
        }


        //
        private void CreateLoginbtn_Click(object sender, EventArgs e)
        {
            string fullName = fullNametxt.Text;
            string employeeID = employeeIDtxt.Text;
            string password = passwordtxt.Text;
            string retypePassword = retypePasswordtxt.Text;

            string username = fullName.Replace(" ", ".");

            if (password == retypePassword)
            {
                if (MeetsLoginCriteria(password))
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
                        MessageBox.Show("Employee login created: \n Your Username is: " + username);
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
                    MessageBox.Show("You do not meet the Password Criteria");
                }
            }

            else
            {
                MessageBox.Show("Passwords do not match");
            }
        }


        //Some regex values for password validation - this ensures its longer than 6 characters, and contains 1 or more digits and capital letters
        private bool MeetsLoginCriteria(string password)
        {
            if (Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*[0-9]).{6,}$"))
            {
                return true;
            }

            else
            {
                return false;
            }
        }


        //This checks for the enter key - as the client wanted to be able to press enter to login and search tables
        private void ouPasswordtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            HomePage home = new HomePage();
            home.EnterButtonClicked(loginbtn, e);
        }



        private void retypePasswordtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            HomePage home = new HomePage();
            home.EnterButtonClicked(createLoginbtn, e);
        }
    }
}
