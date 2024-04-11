using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace DigiScan_Track
{
    public partial class ManualInput : Form
    {

        SqlConnection conn = new SqlConnection();

        public ManualInput(string departmentName, string workstation)
        {
            InitializeComponent();
            InsertDepartment(departmentName, workstation);

            HomePageShortcuts homePageShortcuts = new HomePageShortcuts();

            departmentcmbox.DrawItem += homePageShortcuts.ComboBox_DrawItem;
            workstationcmbox.DrawItem += homePageShortcuts.ComboBox_DrawItem;
            partNumcmbox.DrawItem += homePageShortcuts.ComboBox_DrawItem;

            WIPTracker wip = new WIPTracker(null, null);
            wip.TransparentBackground(this, "submitbtn", "resetbtn");

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            permissionToAccess();
        }



        private void ManualSubmitbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string department = departmentcmbox.Text.ToString();
                string workstation = workstationcmbox.Text.ToString();
                string partNumber = partNumcmbox.Text.ToString();
                string serialNumber = serialNumtxt.Text.ToString();
                string batchNumber = batchNumtxt.Text.ToString();
                string manager = lineManagertxt.Text.ToString();
                string reason = reasontxt.Text.ToString();
                string timestamp = "";
                string notes = notestxt.Text.ToString();

                if (nocheckbox.Checked == true)
                {
                    timestamp = "GETDATE()";
                }

                else
                {
                    timestamp = timestamptxt.Value.ToString();
                }

                TextBox[] textboxes = { serialNumtxt, batchNumtxt, reasontxt };
                ComboBox[] comboBoxes = { partNumcmbox, departmentcmbox, workstationcmbox };
                Label[] textboxlabels = { serialNumlbl, batchNumlbl, reasonlbl };
                Label[] combolabels = { partNumberlbl, departmentlbl, workstationlbl };
                int index = 0;
                int index2 = 0;

                for (int x = 0; x < textboxes.Length; x++)
                {
                    if (string.IsNullOrEmpty(textboxes[x].Text))
                    {
                        if (index == 0)
                        {
                            MessageBox.Show("You have empty fields");
                            index++;
                        }
                        textboxlabels[x].ForeColor = Color.Red;
                    }

                    else
                    {
                        textboxlabels[x].ForeColor = Color.FromArgb(0, 126, 249);
                    }
                }

                for (int y = 0; y < comboBoxes.Length; y++)
                {
                    if (comboBoxes[y].SelectedIndex == -1)
                    {
                        combolabels[y].ForeColor = Color.Red;
                    }

                    else
                    {
                        combolabels[y].ForeColor = Color.FromArgb(0, 126, 249);
                    }
                }

                if (index == 0)
                {
                    if (partNumber != "Part Number" && serialNumber != null && batchNumber != null && department != "Department" && workstation != "Workstation")
                    {

                        conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
                        conn.Open();
                        string sqlSelect = "SELECT COUNT([SerialNumber]) FROM [WIPTracking] WHERE [SerialNumber] = '" + serialNumber + "'";

                        SqlCommand Selectcmd = new SqlCommand(sqlSelect, conn);
                        int rowCount = (int)Selectcmd.ExecuteScalar();
                        conn.Close();

                        if (workstation == "Goods Out")
                        {
                            if (rowCount == workstationcmbox.Items.Count - 1)
                            {
                                conn.Open();
                                string sqlUpdate0 = "UPDATE [WIPTracking] SET [Shipped] = 1 WHERE [SerialNumber] = '" + serialNumber + "'; " +
                                                    "UPDATE [WIPTracking] SET [WSTimestampOUT] = GETDATE() WHERE [SerialNumber] = '" + serialNumber + "' AND [WSTimestampOUT] IS NULL";
                                SqlCommand Updatecmd0 = new SqlCommand(sqlUpdate0, conn);
                                Updatecmd0.ExecuteNonQuery();
                                conn.Close();
                                MessageBox.Show("The part number: " + serialNumber + " has been shipped");
                            }

                            else if (rowCount != workstationcmbox.Items.Count - 1)
                            {
                                MessageBox.Show("This part has not finished its workstation cycle and cannot be shipped yet");
                            }

                            else
                            {
                                MessageBox.Show("Error - contact help email");
                            }
                        }

                        else
                        {
                            conn.Open();
                            string sqlUpdate = " DECLARE @SerialNumber VARCHAR(100) = '" + serialNumber + "';" +
                                               " IF EXISTS(SELECT 1 FROM[DigiTrackAndScan].[dbo].[WIPTracking] WHERE [SerialNumber] = @SerialNumber AND[WSTimestampOUT] IS NULL)" +
                                               " BEGIN " +
                                               "      UPDATE[DigiTrackAndScan].[dbo].[WIPTracking]" +
                                               "      SET[WSTimestampOUT] = GETDATE() " +
                                               "      WHERE SerialNumber = @SerialNumber AND[WSTimestampOUT] IS NULL;" +
                                               "END";


                            string sqlInsert = "INSERT INTO WIPTracking (Department, Workstation, PartNumber, SerialNumber, BatchNumber, LineManager, ManualReason, WSTimestampIN, Notes, InStorage, Shipped)" +
                                                " VALUES (@department, @workstation, @partnum, @serialnum, @batchnum, @manager, @reason, " + timestamp + ", @notes, 0, 0)";

                            SqlCommand Updatecmd = new SqlCommand(sqlUpdate, conn);
                            SqlCommand Insertcmd1 = new SqlCommand(sqlInsert, conn);


                            Insertcmd1.Parameters.AddWithValue("@department", department);
                            Insertcmd1.Parameters.AddWithValue("@workstation", workstation);
                            Insertcmd1.Parameters.AddWithValue("@partnum", partNumber);
                            Insertcmd1.Parameters.AddWithValue("@serialnum", serialNumber);
                            Insertcmd1.Parameters.AddWithValue("@batchnum", batchNumber);
                            Insertcmd1.Parameters.AddWithValue("@manager", manager);
                            Insertcmd1.Parameters.AddWithValue("@reason", reason);
                            Insertcmd1.Parameters.AddWithValue("@notes", notes);


                            Updatecmd.ExecuteNonQuery();
                            Insertcmd1.ExecuteNonQuery();

                            MessageBox.Show("Data inserted");

                            AddHistoryRow(serialNumber);

                            resetbtn.PerformClick();

                            conn.Close();

                        }
                    }
                }
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("This serial number is already in the database" + sqlex.Message);
                serialNumlbl.ForeColor = Color.Red;
                Console.WriteLine(sqlex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }




        private void AddHistoryRow(string serialNum)
        {
            string username = UserLoginDetails.Instance.Username;
            string action = "Created a new record";

            string sqlInsert = "INSERT INTO [History] (Username, Action, ActionTime, [Part/Serial])" +
                                " VALUES (@username, @action, GETDATE(), @partserial)";

            SqlCommand cmd = new SqlCommand(sqlInsert, conn);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@action", action);
            cmd.Parameters.AddWithValue("@partserial", serialNum);

            cmd.ExecuteNonQuery();
        }



        private void Resetbtn_Click(object sender, EventArgs e)
        {
            departmentcmbox.Text = "Department";
            partNumcmbox.Text = "Part Number";
            workstationcmbox.Text = "Workstation";
            serialNumtxt.Clear();
            batchNumtxt.Clear();
            lineManagertxt.Clear();
            reasontxt.Clear();
            nocheckbox.Checked = true;
            notestxt.Clear();

        }



        private void Nocheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (nocheckbox.Checked == true)
            {
                yescheckbox.Checked = false;
                timestamptxt.Enabled = false;
            }

            if (nocheckbox.Checked == false)
            {
                yescheckbox.Checked = true;
                timestamptxt.Enabled = true;
            }
        }



        private void Yescheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (yescheckbox.Checked == true)
            {
                nocheckbox.Checked = false;
                timestamptxt.Enabled = true;
            }

            if (yescheckbox.Checked == false)
            {
                nocheckbox.Checked = true;
                timestamptxt.Enabled = false;
            }
        }



        private void InsertDepartment(string department, string workstation)
        {
            if (department != null)
            {
                LoadDepartmentcmb();
                LoadWorkstationcmb(department);
                int departmentIndex = departmentcmbox.FindString(department);
                departmentcmbox.SelectedIndex = departmentIndex;
                int workstationIndex = workstationcmbox.FindString(workstation);
                workstationcmbox.SelectedIndex = workstationIndex;
                LoadPartNumbers(department);
            }

            else
            {
                LoadDepartmentcmb();
                LoadWorkstationcmb(departmentcmbox.SelectedItem.ToString());
            }

        }



        private void LoadPartNumbers(string chosenDepartment)
        {
            if (partNumcmbox.Items.Count == 0)
            {
                int countDepartments = departmentcmbox.Items.Count;
                string[] departmentList = new string[countDepartments];

                for (int x = 0; x < countDepartments; x++)
                {
                    string department = departmentcmbox.Items[x].ToString();
                    departmentList[x] = department;
                }

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();

                string[] partNumbers = new string[countDepartments];

                for (int x = 0; x < countDepartments; x++)
                {
                    string department = departmentcmbox.Items[x].ToString();

                    cmd.CommandText = "SELECT [PartNumber] FROM PartNumbers WHERE [Department] = @Department";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Department", department);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        List<string> str = new List<string>();
                        while (dr.Read())
                        {
                            str.Add(dr["PartNumber"].ToString());
                        }
                        partNumbers[x] = string.Join(",", str);
                    }
                }

                int index = Array.IndexOf(departmentList, chosenDepartment);

                string[] arraySplit = partNumbers[index].Split(new string[] { "," }, StringSplitOptions.None);

                for (int x = 0; x < arraySplit.Length; x++)
                {
                    partNumcmbox.Items.Add(arraySplit[x]);
                }
            }
        }



        private void LoadDepartmentcmb()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Distinct(Department) FROM Departments";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                departmentcmbox.Items.Add(dr["Department"].ToString());
            }
            conn.Close();

            departmentcmbox.SelectedIndex = 0;
        }



        private void LoadWorkstationcmb(string department)
        {
            if (workstationcmbox.Items.Count == 0)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT [Unit] FROM Departments WHERE [Department] = '" + department + "'";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    workstationcmbox.Items.Add(dr["Unit"].ToString());
                }
                conn.Close();

                workstationcmbox.Items.Add("Goods Out");
                workstationcmbox.SelectedIndex = 0;
            }
        }



        private void Departmentcmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (departmentcmbox.SelectedItem != null)
            {
                string selectedDepartment = departmentcmbox.SelectedItem.ToString();
                partNumcmbox.Items.Clear();
                workstationcmbox.Items.Clear();
                LoadWorkstationcmb(selectedDepartment);
                LoadPartNumbers(selectedDepartment);
                partNumcmbox.SelectedIndex = 0;
            }
        }



        private void permissionToAccess()
        {

            if (UserLoginDetails.Instance.loggedIN == false)
            {
                MessageBox.Show("Please login to gain access");
                BodyLayoutpnl.Enabled = false;
            }

            else if (UserLoginDetails.Instance.loggedIN == true)
            {
                if (UserLoginDetails.Instance.Permission == "Admin" || UserLoginDetails.Instance.Permission == "Read/Write")
                {
                    BodyLayoutpnl.Enabled = true;
                }

                else
                {
                    MessageBox.Show("You do not have the necessary permission level");
                }
            }

        }
    }
}