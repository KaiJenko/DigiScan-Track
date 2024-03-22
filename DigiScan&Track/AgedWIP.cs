using Microsoft.VisualBasic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
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
                int agedDaysCount = agedDays.Days;
                agedDaystrackbar.Maximum = agedDaysCount;
            }

            conn.Close();

        }

        private void getAgedWIPSQL()
        {
            conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT [DateEnteredStorage] FROM [AgedWIP]";
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                DateTime getDate = dr.GetDateTime(0);
                TimeSpan agedDays = DateTime.Today - getDate;
                int agedDaysCount = agedDays.Days;
                MessageBox.Show(agedDaysCount.ToString());
            }

            conn.Close();
        }

        private void getFurtherDetailsSQL()
        {

        }

        private void agedDaystrackbar_Scroll(object sender, EventArgs e)
        {
            counttrackbarlbl.Text = agedDaystrackbar.Value.ToString();
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