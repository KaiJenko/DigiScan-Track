using System.Data;
using System.Data.SqlClient;


namespace DigiScan_Track
{
    public partial class DisplayBoard : Form
    {

        string sqlQuery = "";

        public DisplayBoard()
        {
            InitializeComponent();
            tenrbtn.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton radioButton in radioButtonpnl.Controls)
            {
                if (radioButton.Checked)
                {
                    switch (radioButton.Tag)
                    {
                        case "2":
                            HideCustomInput();
                            sqlQuery = "WHERE DATEDIFF(MINUTE, [WSTimeStampIN] , GETDATE()) < '2'";
                            break;
                        case "5":
                            HideCustomInput();
                            sqlQuery = "WHERE DATEDIFF(MINUTE, [WSTimeStampIN] , GETDATE()) < '5'";
                            break;
                        case "10":
                            HideCustomInput();
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

            ExecuteAgedWIPSQL(sqlQuery);
        }



        private void Searchpbox_Click(object sender, EventArgs e)
        {
            sqlQuery = "WHERE DATEDIFF(MINUTE, [WSTimeStampIN] , GETDATE()) < '" + customInputnud.Value + "'";
            ExecuteAgedWIPSQL(sqlQuery);
        }



        private void ExecuteAgedWIPSQL(string sqlQuery)
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
            DisplayBoardSQL();
        }



        private void HideCustomInput()
        {
            customInputnud.Visible = false;
            searchpbox.Visible = false;
            customInputnud.Value = 0;
        }



        private void DisplayBoardSQL()
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
            recentScannedGridView.Columns[3].Width = 175;
            recentScannedGridView.Columns[4].Width = 175;
            recentScannedGridView.Columns[5].Width = 175;
        }
    }
}