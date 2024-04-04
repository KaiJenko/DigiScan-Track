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
            cmd.CommandText = "SELECT [serialNumber], DATEDIFF(day, [DateEnteredStorage] , GETDATE()) FROM [AgedWIP]";
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
            ExportToExcel(Agedgridview);

        }


        Workbook workbook;
        Worksheet worksheet;
        string filepath;

        private void ExportToExcel(DataGridView datagridview)
        {
            if (datagridview.Rows.Count > 0)
            {
                Excel.Application excel = new Excel.Application();
                workbook = excel.Workbooks.Add();
                worksheet = (Worksheet)workbook.Worksheets[1];

                for (int x = 0; x < datagridview.Rows.Count; x++)
                {
                    for (int y = 0; y < datagridview.Columns.Count; y++)
                    {
                        worksheet.Cells[x + 1, y + 1] = datagridview.Rows[x].Cells[y].Value.ToString();
                    }
                }

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
            }
        }
    }
}