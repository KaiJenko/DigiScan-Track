using System.Data;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace DigiScan_Track
{
    public partial class WIPTracker : Form
    {

        SqlConnection conn = new SqlConnection();
        int defaultOrCustom = 0;


        public WIPTracker(string sentDepartment, string sentWorkstation)
        {
            InitializeComponent();
            getSQLWIPTracker(sentDepartment, sentWorkstation);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void create_defaultGridView_WIP()
        {

            WIPgridView.Columns[0].HeaderText = "Part No";
            WIPgridView.Columns[1].HeaderText = "Serial No";
            WIPgridView.Columns[2].HeaderText = "Batch No";
            WIPgridView.Columns[3].HeaderText = "Department";
            WIPgridView.Columns[4].HeaderText = "Workstation";
            WIPgridView.Columns[5].HeaderText = "Time in";
            WIPgridView.Columns[6].HeaderText = "Time out";
            WIPgridView.Columns[7].HeaderText = "Storage";

            WIPgridView.Columns[0].Width = 150;
            WIPgridView.Columns[1].Width = 150;
            WIPgridView.Columns[2].Width = 150;
            WIPgridView.Columns[3].Width = 150;
            WIPgridView.Columns[4].Width = 150;
            WIPgridView.Columns[5].Width = 150;
            WIPgridView.Columns[6].Width = 150;
            WIPgridView.Columns[7].Width = 75;

            WIPgridView.ColumnHeadersDefaultCellStyle.Font = new Font(WIPgridView.Font.FontFamily, 12, FontStyle.Bold);
            WIPgridView.ColumnHeadersHeight = 50;

        }

        private void create_customGridView_WIP()
        {

            WIPgridView.Columns[0].HeaderText = "Part No";
            WIPgridView.Columns[1].HeaderText = "Serial No";
            WIPgridView.Columns[2].HeaderText = "Batch No";
            WIPgridView.Columns[3].HeaderText = "Time in";
            WIPgridView.Columns[4].HeaderText = "Time out";
            WIPgridView.Columns[5].HeaderText = "Storage";

            WIPgridView.Columns[0].Width = 150;
            WIPgridView.Columns[1].Width = 150;
            WIPgridView.Columns[2].Width = 150;
            WIPgridView.Columns[3].Width = 150;
            WIPgridView.Columns[4].Width = 150;
            WIPgridView.Columns[5].Width = 75;

            WIPgridView.ColumnHeadersDefaultCellStyle.Font = new Font(WIPgridView.Font.FontFamily, 12, FontStyle.Bold);
            WIPgridView.ColumnHeadersHeight = 50;

        }

        private void getSQLWIPTracker(string department, string workstation)
        {
            string cmdText = "";

            if (department == null && workstation == null)
            {
                departmentlbl.Text = "";
                workstationlbl.Text = "";
                cmdText = "SELECT TOP(1000)[PartNumber] ,[SerialNumber] ,[BatchNumber] ,[Department] ,[Workstation] " +
                          " ,[WSTimestampIN] ,[WSTimestampOUT] ,[InStorage] FROM [WIPTracking]";
                defaultOrCustom = 0;

            }

            else if (department != null || workstation != null)
            {
                departmentlbl.Text = "DP:  " + department;
                workstationlbl.Text = "WS:  " + workstation;
                cmdText = "SELECT TOP(1000)[PartNumber] ,[SerialNumber] ,[BatchNumber]" +
                          " ,[WSTimestampIN] ,[WSTimestampOUT] ,[InStorage] FROM [WIPTracking] WHERE [Department] = '" + department + "'" +
                          " AND [Workstation] = '" + workstation + "'";
                defaultOrCustom = 1;
            }

            DataTable dt = new DataTable();

            conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = cmdText;
            SqlDataReader dr = cmd.ExecuteReader();

            dt.Load(dr);

            conn.Close();

            WIPgridView.DataSource = dt;

            if (defaultOrCustom == 0)
            {
                create_defaultGridView_WIP();
            }

            else
            {
                create_customGridView_WIP();
            }

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string searchval = searchtxt.Text.Trim();
            string dropdownSelection = searchcmb.Text.Replace(" ", "");

            if (searchval != "" && dropdownSelection != "")
            {
                addFieldbtn_Click(sender, e);

                int index = 0;
                string sqlQuery = "";

                foreach (Label label in searchFieldpnl.Controls)
                {
                    string labelOutput = label.Text.ToString();
                    string[] parts = labelOutput.Split(new string[] { " - " }, StringSplitOptions.None);
                    string SearchField = parts[0];
                    string SearchValue = parts[1];

                    if (index == 0)
                    {
                        sqlQuery = "WHERE [" + SearchField + "] LIKE '%" + SearchValue + "%'"; // do i need '
                        index++;
                    }

                    else if (index != 0)
                    {
                        sqlQuery += " AND [" + SearchField + "] LIKE '%" + searchval + "%'";
                    }

                    if (defaultOrCustom == 1)
                    {
                        string departmentlblS = departmentlbl.Text.ToString();
                        string workstationlblS = workstationlbl.Text.ToString();
                        string[] departmentSplit = departmentlblS.Split(new string[] { ":  " }, StringSplitOptions.None);
                        string[] workstationSplit = workstationlblS.Split(new string[] { ":  " }, StringSplitOptions.None);
                        string department = departmentSplit[1];
                        string workstation = workstationSplit[1];

                        sqlQuery += " AND [Department] = '" + department + "' AND [Workstation] = '" + workstation + "'";
                    }
                }

                DataTable dt = new DataTable();
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
                con.Open();
                SqlCommand cmd = con.CreateCommand();

                if (defaultOrCustom == 0) {
                    cmd.CommandText = "SELECT TOP (1000) [PartNumber] ,[SerialNumber] ,[BatchNumber] ,[Department] ,[Workstation] " +
                                      ",[WSTimestampIN] ,[WSTimestampOUT] ,[InStorage] FROM [WIPTracking] " +
                                      sqlQuery;

                    cmd.Parameters.AddWithValue("@SQLSearchQuery", sqlQuery); //reduces SQL injection
                    SqlDataReader dr = cmd.ExecuteReader();

                    dt.Load(dr);

                    con.Close();

                    WIPgridView.DataSource = dt;
                    create_defaultGridView_WIP();
                }

                else
                {
                    cmd.CommandText = "SELECT TOP (1000) [PartNumber] ,[SerialNumber] ,[BatchNumber]" +
                                     ",[WSTimestampIN] ,[WSTimestampOUT] ,[InStorage] FROM [WIPTracking] " +
                                     sqlQuery;

                    cmd.Parameters.AddWithValue("@SQLSearchQuery", sqlQuery); //reduces SQL injection
                    SqlDataReader dr = cmd.ExecuteReader();

                    dt.Load(dr);

                    con.Close();

                    WIPgridView.DataSource = dt;
                    create_customGridView_WIP();
                }

            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            searchFieldpnl.Controls.Clear();
            getSQLWIPTracker(null, null);
            defaultOrCustom = 0;
        }

        private void addFieldbtn_Click(object sender, EventArgs e)
        {
            string searchField = searchcmb.Text.Replace(" ", "");
            string searchValue = searchtxt.Text.Trim();

            searchcmb.Text = null;
            searchtxt.Text = null;

            int index = searchFieldpnl.Controls.Count;

            if (index == 0)
            {
                Label field = new Label();
                field.Name = "label" + index;
                field.Text = searchField + " - " + searchValue;
                field.AutoSize = true;
                field.MaximumSize = new Size(150, 50);

                searchFieldpnl.Controls.Add(field);
            }

            else
            {
                if (index < 4)
                {
                    Label field = new Label();
                    field.Name = "label" + index;
                    field.Text = searchField + " - " + searchValue;
                    field.AutoSize = true;
                    Label oldLabel = (Label)searchFieldpnl.Controls["label" + (index - 1)];
                    field.Location = new Point(oldLabel.Right + 10, oldLabel.Top);
                    field.MaximumSize = new Size(150, 50);
                    searchFieldpnl.Controls.Add(field);
                }

                else
                {
                    MessageBox.Show("No More Search Fields Can Be Added!");
                }
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
