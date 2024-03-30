using Microsoft.VisualBasic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
using static System.ComponentModel.Design.ObjectSelectorEditor;

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

            WIPTracker wip = new WIPTracker(null, null);
            wip.transparentBackground(this, "excelbtn", "resetbtn", "tableaubtn");
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



        private void agedDaystrackbar_Scroll(object sender, EventArgs e)
        {
            counttrackbarlbl.Text = agedDaystrackbar.Value.ToString();
        }

        private void create_defaultGridView_WIP()
        {
            Agedgridview.Columns[0].HeaderText = "Serial Number";
            Agedgridview.Columns[1].HeaderText = "Days Aged";

            Agedgridview.Columns[0].Width = 124;
            Agedgridview.Columns[1].Width = 124;
        }

        private void furtherDetailsSQL()
        {
            furtherDetailsgridview.Columns[0].HeaderText = "Serial No";
            furtherDetailsgridview.Columns[1].HeaderText = "Part No";
            furtherDetailsgridview.Columns[2].HeaderText = "Batch No";
            furtherDetailsgridview.Columns[3].HeaderText = "Department";
            furtherDetailsgridview.Columns[4].HeaderText = "Stored Date";
            furtherDetailsgridview.Columns[5].HeaderText = "Reason";
            furtherDetailsgridview.Columns[6].HeaderText = "User Responsible";

            furtherDetailsgridview.Columns[0].Width = 95;
            furtherDetailsgridview.Columns[1].Width = 95;
            furtherDetailsgridview.Columns[2].Width = 95;
            furtherDetailsgridview.Columns[3].Width = 95;
            furtherDetailsgridview.Columns[4].Width = 95;
            furtherDetailsgridview.Columns[5].Width = 95;
            furtherDetailsgridview.Columns[6].Width = 95;
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

        private void Agedgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                moreInfolbl.Visible = false;
                string serialNumber = Agedgridview.Rows[e.RowIndex].Cells[0].Value.ToString();

                DataTable dt = new DataTable();
                conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT AgedWIP.[serialNumber], WIPTracking.[PartNumber], WIPTracking.[BatchNumber], WIPTracking.[Department], " +
                                  "AgedWIP.[DateEnteredStorage], AgedWIP.[ReasonForStorage], AgedWIP.[UserWhoInputted] FROM [DigiTrackAndScan].[dbo].[AgedWIP] " +
                                  "LEFT JOIN [DigiTrackAndScan].[dbo].WIPTracking ON AgedWIP.SerialNumber = WIPTracking.SerialNumber WHERE AgedWIP.SerialNumber = '" + serialNumber + "'";
                SqlDataReader dr = cmd.ExecuteReader();

                dt.Load(dr);

                conn.Close();

                furtherDetailsgridview.DataSource = dt;
                furtherDetailsSQL();

                conn.Close();
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            agedDaystrackbar.Value = 0;
            equalsrbtn.Checked = true;
            counttrackbarlbl.Text = "0";
            lowerRangenud.Value = 0;
            higherRangenud.Value = 0;
            getAgedWIPSQL();
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

        private void Agedgridview_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Agedgridview.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Coral;
            }
        }

        private void Agedgridview_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Agedgridview.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
            }
        }
    }
}