using System.Data;
using System.Data.SqlClient;


namespace DigiScan_Track
{
    public partial class PartEditPage : UserControl
    {

        WIPTracker wip = new WIPTracker(null, null);

        public PartEditPage(string serialNumber, string workstation)
        {
            InitializeComponent();
            EditPartDetailsSQL(serialNumber, workstation);
            FurtherEditPartsSQL(serialNumber, workstation);
        }



        private void EditPartDetailsSQL(string serialNumber, string workstation)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";

            DataTable dt = new DataTable();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT [PartNumber], [SerialNumber], [BatchNumber], [Department], [Workstation], [WSTimestampIN], [WSTimestampOUT]," +
                              " [InStorage] FROM [WIPTracking] WHERE [SerialNumber] = '" + serialNumber + "' AND [Workstation] = '" + workstation + "'";
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            partTobeEditedGridView.DataSource = dt;
            PartsEditLayout();

        }



        private void FurtherEditPartsSQL(string serialNumber, string workstation)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";

            DataTable dt = new DataTable();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT [DateEnteredStorage], [ReasonForStorage], [UserWhoInputted] FROM [AgedWIP] WHERE [SerialNumber] = '" + serialNumber + "'";
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            furtherDetailsgridview.DataSource = dt;
            FurtherDetailsLayout();

            if (furtherDetailsgridview.Rows.Count == 0)
            {
                furtherDetailsgridview.Visible = false;
                furtherDetailspnl.Visible = false;
            }
        }



        private void InputEdit_Click(object sender, EventArgs e)
        {

            DataGridViewCell partToBeEdited = null;
            int repeat = 0;
            int count = 0;
            string sqlquery = "";

            foreach (Control control in userInputpnl.Controls)
            {
                if (control is RichTextBox richTextBox)
                {
                    if (!string.IsNullOrWhiteSpace(richTextBox.Text))
                    {
                        partToBeEdited = partTobeEditedGridView.Rows[0].Cells[1];

                        if (control is CheckBox)
                        {
                            CheckBox checkbox = control as CheckBox;
                            if (checkbox.Checked)
                            {
                                sqlquery += " [" + checkbox.Tag + "] = 1";
                            }

                            else if (checkbox.Checked = false)
                            {
                                sqlquery += " [" + checkbox.Tag + "] = 0";
                            }
                        }

                        else if (control is RichTextBox)
                        {
                            RichTextBox richtextbox = control as RichTextBox;
                            if (richtextbox.Text != "")
                            {
                                if (count == 0)
                                {
                                    sqlquery += " [" + richtextbox.Tag + "] = '" + richtextbox.Text + "'";
                                    count++;
                                }

                                else if (count > 0)
                                {
                                    sqlquery += " , [" + richtextbox.Tag + "] = '" + richtextbox.Text + "'";
                                    count++;
                                }

                            }

                        }
                    }

                    else
                    {
                        if (repeat == 0)
                        {
                            /*MessageBox.Show("Please input at least one different value");*/
                            repeat++;
                        }
                    }
                }
            }

            if (sqlquery != "")
            {
                string serialNum = partToBeEdited.Value.ToString();

                DataTable dt = new DataTable();
                SqlConnection conn = new SqlConnection();

                conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
                conn.Open();

                string sqlUpdate = "UPDATE [WIPTracking] SET " + sqlquery + " WHERE [SerialNumber] = '" + serialNum + "'";
                SqlCommand cmd = new SqlCommand(sqlUpdate, conn);
                cmd.ExecuteNonQuery();

                string username = UserLoginDetails.Instance.Username;
                string action = "Edited a part";

                string sqlInsert = "INSERT INTO [History] (Username, Action, ActionTime, [Part/Serial])" +
                                    " VALUES (@username, @action, GETDATE(), @partserial)";

                SqlCommand cmd2 = new SqlCommand(sqlInsert, conn);

                cmd2.Parameters.AddWithValue("@username", username);
                cmd2.Parameters.AddWithValue("@action", action);
                cmd2.Parameters.AddWithValue("@partserial", serialNum);

                cmd2.ExecuteNonQuery();

                conn.Close();
            }

        }
            
    

        private void PartsEditLayout()
        {
            partTobeEditedGridView.Columns[0].HeaderText = "Part No";
            partTobeEditedGridView.Columns[1].HeaderText = "Serial No";
            partTobeEditedGridView.Columns[2].HeaderText = "Batch No";
            partTobeEditedGridView.Columns[3].HeaderText = "Department";
            partTobeEditedGridView.Columns[4].HeaderText = "Workstation";
            partTobeEditedGridView.Columns[5].HeaderText = "Time In";
            partTobeEditedGridView.Columns[6].HeaderText = "Time Out";
            partTobeEditedGridView.Columns[7].HeaderText = "In Storage";

            wip.TurnColumnIntoPercent(partTobeEditedGridView, 12, 12, 12, 13, 14, 15, 15, 12);

        }



        private void FurtherDetailsLayout()
        {
            furtherDetailsgridview.Columns[0].HeaderText = "Storage Date";
            furtherDetailsgridview.Columns[1].HeaderText = "Reason";
            furtherDetailsgridview.Columns[2].HeaderText = "User";

            furtherDetailsgridview.Columns[0].Width = 150;
            furtherDetailsgridview.Columns[1].Width = 200;
            furtherDetailsgridview.Columns[2].Width = 150;

            wip.TurnColumnIntoPercent(furtherDetailsgridview, 33, 43, 33);
        }
    }
}
