using Microsoft.VisualBasic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;

namespace DigiScan_Track
{
    public partial class AgedWIP : Form
    {

        SqlConnection conn = new SqlConnection();

        public AgedWIP()
        {
            InitializeComponent();
            pullMaxCountSQL();
            getAgedWIPSQL();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pullMaxCountSQL()
        {
            conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT MIN([DateEnteredStorage]) FROM [AgedWIP]";
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                DateTime getDate = dr.GetDateTime(0);
                TimeSpan agedDays = DateTime.Today - getDate;
                int agedDaysCount = agedDays.Days + 1;
                agedDaystrackbar.Maximum = agedDaysCount;
                higherRangenud.Maximum = agedDaysCount;
            }

            conn.Close();

        }

        private void getAgedWIPSQL()
        {
            DataTable dt = new DataTable();

            conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT [serialNumber], DATEDIFF(day, [DateEnteredStorage] , GETDATE()) FROM [AgedWIP]";
            SqlDataReader dr = cmd.ExecuteReader();

            dt.Load(dr);

            conn.Close();

            Agedgridview.DataSource = dt;
            create_defaultGridView_WIP();

            conn.Close();
        }

        private void getFurtherDetailsSQL()
        {

        }

        private void agedDaystrackbar_Scroll(object sender, EventArgs e)
        {
            counttrackbarlbl.Text = agedDaystrackbar.Value.ToString();
        }

        private void create_defaultGridView_WIP()
        {
            Agedgridview.Columns[0].HeaderText = "Serial Number";
            Agedgridview.Columns[1].HeaderText = "Number of Days Aged";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string sqlquery = "";
            string searchValue = agedDaystrackbar.Value.ToString();
            foreach (RadioButton radiobutton in radioButtonpnl.Controls)
            {
                if (radiobutton.Checked)
                {
                    switch (radiobutton.Text)
                    {
                        case "=":
                            sqlquery = "WHERE DATEDIFF(day, [DateEnteredStorage] , GETDATE()) = '" + searchValue + "'";
                            break;
                        case "Range":
                            sqlquery = "WHERE DATEDIFF(day, [DateEnteredStorage] , GETDATE()) BETWEEN " + lowerRangenud.Value + " AND " + higherRangenud.Value;
                            break;
                        case "<":
                            sqlquery = "WHERE DATEDIFF(day, [DateEnteredStorage] , GETDATE()) < '" + searchValue + "'";
                            break;
                        case ">":
                            sqlquery = "WHERE DATEDIFF(day, [DateEnteredStorage] , GETDATE()) > '" + searchValue + "'";
                            break;
                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
            }

            DataTable dt = new DataTable();

            conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT [serialNumber], DATEDIFF(day, [DateEnteredStorage] , GETDATE()) FROM [AgedWIP] " + sqlquery;
            SqlDataReader dr = cmd.ExecuteReader();

            dt.Load(dr);

            conn.Close();

            Agedgridview.DataSource = dt;
            create_defaultGridView_WIP();

            conn.Close();

        }

        private void rangerbtn_Click(object sender, EventArgs e)
        {
            if (rangerbtn.Checked)
            {
                rangepnl.Visible = true;
                agedDaystrackbar.Visible = false;
                counttrackbarlbl.Visible = false;
            }

            else
            {
                rangepnl.Visible = false;
                agedDaystrackbar.Visible = true;
                counttrackbarlbl.Visible = true;
            }

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