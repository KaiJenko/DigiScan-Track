using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using DataTable = System.Data.DataTable;
using Excel = Microsoft.Office.Interop.Excel;

namespace DigiScan_Track
{
    public partial class AgedWIP : Form
    {

        SqlConnection conn = new SqlConnection();
        WIPTracker wip = new WIPTracker(null, null);

        public AgedWIP()
        {
            InitializeComponent();
            PullMaxCountSQL();
            GetAgedWIPSQL();

            wip.TransparentBackground(this, "excelbtn", "resetbtn", "tableaubtn");
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void PullMaxCountSQL()
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



        private void GetAgedWIPSQL()
        {
            DataTable dt = new DataTable();

            conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT [serialNumber], DATEDIFF(day, [DateEnteredStorage] , GETDATE()) AS aged FROM [AgedWIP] ORDER BY [aged] DESC";
            SqlDataReader dr = cmd.ExecuteReader();

            dt.Load(dr);

            conn.Close();

            Agedgridview.DataSource = dt;
            Create_defaultGridView_WIP();

            conn.Close();
        }



        private void AgedDaystrackbar_Scroll(object sender, EventArgs e)
        {
            counttrackbarlbl.Text = agedDaystrackbar.Value.ToString();
        }



        private void Create_defaultGridView_WIP()
        {
            Agedgridview.Columns[0].HeaderText = "Serial Number";
            Agedgridview.Columns[1].HeaderText = "Days Aged";

            wip.TurnColumnIntoPercent(Agedgridview, 60, 60);
        }



        private void FurtherDetailsSQL()
        {
            furtherDetailsgridview.Columns[0].HeaderText = "Serial No";
            furtherDetailsgridview.Columns[1].HeaderText = "Part No";
            furtherDetailsgridview.Columns[2].HeaderText = "Batch No";
            furtherDetailsgridview.Columns[3].HeaderText = "Department";
            furtherDetailsgridview.Columns[4].HeaderText = "Stored Date";
            furtherDetailsgridview.Columns[5].HeaderText = "Reason";
            furtherDetailsgridview.Columns[6].HeaderText = "User Responsible";

            wip.TurnColumnIntoPercent(furtherDetailsgridview, 14, 14, 14, 14, 14, 20, 14);
        }



        private void AgedSearchButton_Click(object sender, EventArgs e)
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
            cmd.CommandText = "SELECT [serialNumber], DATEDIFF(day, [DateEnteredStorage] , GETDATE()) AS aged FROM [AgedWIP] " + sqlquery + " ORDER BY [aged] DESC";
            SqlDataReader dr = cmd.ExecuteReader();

            dt.Load(dr);

            conn.Close();

            Agedgridview.DataSource = dt;
            Create_defaultGridView_WIP();

            conn.Close();
        }



        private void Rangerbtn_Click(object sender, EventArgs e)
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
                FurtherDetailsSQL();

                conn.Close();
            }
        }



        private void Resetbtn_Click(object sender, EventArgs e)
        {
            agedDaystrackbar.Value = 0;
            equalsrbtn.Checked = true;
            counttrackbarlbl.Text = "0";
            lowerRangenud.Value = 0;
            higherRangenud.Value = 0;
            GetAgedWIPSQL();
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



        private void Excelbtn_Click(object sender, EventArgs e)
        {

            if (UserLoginDetails.Instance.loggedIN == true)
            {
                if (UserLoginDetails.Instance.Permission != "Read")
                {
                    ExportToExcel(Agedgridview);
                }

                else
                {
                    MessageBox.Show("Please obtain higher permission level");
                }
            }

            else
            {
                MessageBox.Show("Please login");
            }

        }


        Workbook workbook;
        Worksheet worksheet;
        string filepath;

        private void ExportToExcel(DataGridView datagridview)
        {
            int i = 0;
            int j = 0;

            if (datagridview.Rows.Count > 0)
            {
                Excel.Application excel = new Excel.Application();
                workbook = excel.Workbooks.Add();
                worksheet = (Worksheet)workbook.Worksheets[1];

                worksheet.Cells[2, 1] = "Serial Num";
                worksheet.Cells[2, 2] = "Days Aged";

                for (int x = 0; x < datagridview.Rows.Count; x++)
                {
                    for (int y = 0; y < datagridview.Columns.Count; y++)
                    {
                        worksheet.Cells[x + 3, y + 1] = datagridview.Rows[x].Cells[y].Value.ToString();
                        i = y;
                    }
                    j = x;
                }
            }

            if (furtherDetailsgridview.Rows.Count > 0)
            {

                for (int y = 0; y < furtherDetailsgridview.Columns.Count; y++)
                {
                    worksheet.Cells[j + 5, y + 1] = furtherDetailsgridview.Columns[y].HeaderText;
                }

                for (int x = 0; x < furtherDetailsgridview.Rows.Count; x++)
                {
                    for (int y = 0; y < furtherDetailsgridview.Columns.Count; y++)
                    {
                        worksheet.Cells[x + 6 + j, y + i] = furtherDetailsgridview.Rows[x].Cells[y].Value.ToString();
                    }
                }
            }

            /*Excel.Range sortRange = worksheet.Range[worksheet.Cells[2, 2], worksheet.Cells[j + furtherDetailsgridview.Rows.Count + 3, 2]];
            sortRange.Sort(sortRange.Columns[1], XlSortOrder.xlDescending);*/

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    filepath = sfd.FileName;
                    if (File.Exists(filepath))
                    {

                        File.Delete(filepath);
                    }
                    worksheet.Columns.AutoFit();
                    workbook.SaveAs(filepath);
                    workbook.Close();
                }
            }

            string username = UserLoginDetails.Instance.Username;
            string action = "Exported Aged Parts";

            conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
            conn.Open();
            string sqlInsert = "INSERT INTO [History] (Username, Action, ActionTime)" +
                                " VALUES (@username, @action, GETDATE())";
            SqlCommand cmd = new SqlCommand(sqlInsert, conn);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@action", action);


            cmd.ExecuteNonQuery();
        }

        private void Agedgridview_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            object value = Agedgridview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            if (Agedgridview.Columns[e.ColumnIndex].Name == "aged")
            {
                if (value != null && value is int && (int)value > 60)
                {
                    e.CellStyle.ForeColor = Color.Red;
                }

                else if (value != null && value is int && (int)value > 30)
                {
                    e.CellStyle.ForeColor = Color.Yellow;
                }

                else if (value != null && value is int && (int)value > 0)
                {
                    e.CellStyle.ForeColor = Color.LightGreen;
                }
            }
        }
    }
}