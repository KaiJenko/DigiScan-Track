using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DigiScan_Track
{
    public partial class PartEditPage : UserControl
    {

        WIPTracker wip = new WIPTracker(null, null);
        int trueCheckbox = 0;

        public PartEditPage(string serialNumber, string workstation)
        {
            InitializeComponent();
            EditPartDetailsSQL(serialNumber, workstation);

            string checkBox = partTobeEditedGridView.Rows[0].Cells[7].Value.ToString();

            if (checkBox == "True")
            {
                storagechbox.Checked = true;
                trueCheckbox = 1;

            }
            FurtherEditPartsSQL(serialNumber, workstation);

        }


        //SQL query to pull data pertaining to the serialnumber pulled from the parteditpage parameters
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


        //This only pulls data if the part is in storage, if it isnt then the gridview and all textboxes are hidden
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
                checkboxTicked();
            }
        }


        //Changes the current data in the SQL table for the users new data
        private void InputEdit_Click(object sender, EventArgs e)
        {
            DataGridViewCell partToBeEdited = null;
            int repeat = 0;
            int count = 0;
            string sqlquery = "";

            foreach (Control control in userInputpnl.Controls)
            {

                partToBeEdited = partTobeEditedGridView.Rows[0].Cells[1];

                if (control is RichTextBox richTextBox)
                {
                    if (!string.IsNullOrWhiteSpace(richTextBox.Text))
                    {
                        if (control is RichTextBox)
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

                else if (control is CheckBox)
                {
                    CheckBox checkbox = control as CheckBox;
                    if (checkbox.Checked)
                    {
                        sqlquery += " [" + checkbox.Tag + "] = 1";
                    }

                    else if (!checkbox.Checked)
                    {
                        sqlquery += " [" + checkbox.Tag + "] = 0";
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
                if (storagechbox.Checked && reasonTxtbox.Text != "")
                {
                    DateTime timestamp;
                    timestamp = timestamptxt.Value;
                    string SQLFormat = timestamp.ToString("yyyy-MM-dd HH:mm:ss");

                    string reason = reasonTxtbox.Text.ToString();


                    string slqInsert2 = "INSERT INTO [AgedWIP] ([SerialNumber], [DateEnteredStorage], [ReasonForStorage], [UserWhoInputted])" +
                                        " VALUES (@partserial, " + "'" + SQLFormat + "'" + ", @reason, @user)";
                    SqlCommand cmd2 = new SqlCommand(slqInsert2, conn);

                    cmd2.Parameters.AddWithValue("@partserial", serialNum);
                    cmd2.Parameters.AddWithValue("@reason", reason);
                    cmd2.Parameters.AddWithValue("@user", username);

                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Part has been inputted into storage");
                }



                SqlCommand cmd3 = new SqlCommand(sqlInsert, conn);

                cmd3.Parameters.AddWithValue("@username", username);
                cmd3.Parameters.AddWithValue("@action", action);
                cmd3.Parameters.AddWithValue("@partserial", serialNum);

                cmd3.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Updated");
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

        private void storagechbox_CheckedChanged(object sender, EventArgs e)
        {
            if (trueCheckbox == 0)
            {
                if (storagechbox.Checked)
                {
                    furtherDetailspnl.Visible = true;
                    usertextbox.Text = UserLoginDetails.Instance.Username;
                    checkboxTicked();
                }

                else
                {
                    furtherDetailspnl.Visible = false;
                }
            }

            if (trueCheckbox == 1)
            {

            }

        }

        private void checkboxTicked()
        {
            if (storagechbox.Checked)
            {
                timestamptxt.Visible = true;
                furtherDetailspnl.Visible = true;
            }

            else
            {
                timestamptxt.Visible = false;
                furtherDetailspnl.Visible = false;
            }

        }
    }
}
