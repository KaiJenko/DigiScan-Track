using Microsoft.VisualBasic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DigiScan_Track
{
    public partial class DisplayBoard : Form
    {

        SqlConnection conn = new SqlConnection();

        public DisplayBoard()
        {
            InitializeComponent();
        }


        /*private void getSQLHomepage()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM WIPTracking";
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            dataGridView1.DataSource = dt;
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            string sqlQuery = "";
            foreach (RadioButton radioButton in radioButtonpnl.Controls)
            {
                if (radioButton.Checked)
                {
                    switch (radioButton.Tag)
                    {
                        case "2":
                            sqlQuery = "WHERE DATEDIFF(MINUTE, [WSTimeStampIN] , GETDATE()) < '2'";
                            break;
                        case "5":
                            sqlQuery = "WHERE DATEDIFF(MINUTE, [WSTimeStampIN] , GETDATE()) < '5'";
                            break;
                        case "10":
                            sqlQuery = "WHERE DATEDIFF(MINUTE, [WSTimeStampIN] , GETDATE()) < '10'";
                            break;
                        case "60":
                            sqlQuery = "WHERE DATEDIFF(MINUTE, [WSTimeStampIN] , GETDATE()) < '60'";
                            break;
                    }
                }

            }

            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM [WIPTracking] " + sqlQuery;
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            recentScannedGridView.DataSource = dt;

        }



        /*------------------------------------------------Repeated code in all Forms------------------------------------------------------------------*/
        //This function finds out which form page to close and which to open, and what size screen the user is working on so it can replicate this
        public static void HeaderButton(Form newForm, Form originalForm, FormWindowState windowState)
        {
            newForm.Show(); //in this case the newform would be the linked form of whichever button is clicked
            originalForm.Hide(); //Closes the previous tab so does not clog up users computer
            if (windowState == FormWindowState.Maximized) //If the user is working on a minimised screen then it stays minimised
            {
                newForm.WindowState = FormWindowState.Maximized;
            }
        }


    }
}