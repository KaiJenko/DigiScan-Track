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
        string sqlQuery = "";

        public DisplayBoard()
        {
            InitializeComponent();
            tenrbtn.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {

            foreach (RadioButton radioButton in radioButtonpnl.Controls)
            {
                if (radioButton.Checked)
                {
                    switch (radioButton.Tag)
                    {
                        case "2":
                            hideCustomInput();
                            sqlQuery = "WHERE DATEDIFF(MINUTE, [WSTimeStampIN] , GETDATE()) < '2'";
                            break;
                        case "5":
                            hideCustomInput();
                            sqlQuery = "WHERE DATEDIFF(MINUTE, [WSTimeStampIN] , GETDATE()) < '5'";
                            break;
                        case "10":
                            hideCustomInput();
                            sqlQuery = "WHERE DATEDIFF(MINUTE, [WSTimeStampIN] , GETDATE()) < '10'";
                            break;
                        case "custom":
                            customInputnud.Visible = true;
                            searchpbox.Visible = true;
                            break;
                        default:
                            break;
                    }
                }

            }
            executeAgedWIPSQL(sqlQuery);
        }


        private void searchpbox_Click(object sender, EventArgs e)
        {
            sqlQuery = "WHERE DATEDIFF(MINUTE, [WSTimeStampIN] , GETDATE()) < '" + customInputnud.Value + "'";
            executeAgedWIPSQL(sqlQuery);
        }


        private void executeAgedWIPSQL(string sqlQuery)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT [PartNumber], [SerialNumber], [BatchNumber], [Department], [Workstation], [WSTimestampIN] FROM [WIPTracking] " + sqlQuery;
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            recentScannedGridView.DataSource = dt;
            displayBoardSQL();
        }


        private void hideCustomInput()
        {
            customInputnud.Visible = false;
            searchpbox.Visible = false;
            customInputnud.Value = 0;
        }


        private void displayBoardSQL()
        {
            recentScannedGridView.Columns[0].HeaderText = "Part No";
            recentScannedGridView.Columns[1].HeaderText = "Serial No";
            recentScannedGridView.Columns[2].HeaderText = "Batch No";
            recentScannedGridView.Columns[3].HeaderText = "Department";
            recentScannedGridView.Columns[4].HeaderText = "Workstation";
            recentScannedGridView.Columns[5].HeaderText = "Time In";

            recentScannedGridView.Columns[0].Width = 150;
            recentScannedGridView.Columns[1].Width = 150;
            recentScannedGridView.Columns[2].Width = 150;
            recentScannedGridView.Columns[3].Width = 180;
            recentScannedGridView.Columns[4].Width = 180;
            recentScannedGridView.Columns[5].Width = 180;


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