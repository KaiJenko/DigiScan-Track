using System.Data.SqlClient;


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

        }



        private void Submitbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string partNumber = partNumcmbox.Text.ToString();
                string serialNumber = serialNumtxt.Text.ToString();
                string batchNumber = batchNumtxt.Text.ToString();
                string manager = lineManagertxt.Text.ToString();
                string department = departmentcmbox.Text.ToString();
                string workstation = workstationcmbox.Text.ToString();
                string timestamp = "";

                if (nocheckbox.Checked == true)
                {
                    timestamp = "GETDATE()";
                }

                else
                {
                    timestamp = timestamptxt.Value.ToString();
                }

                string reason = reasontxt.Text.ToString();
                string notes = notestxt.Text.ToString();

                TextBox[] textboxes = { serialNumtxt, batchNumtxt, reasontxt };
                ComboBox[] comboBoxes = { partNumcmbox, departmentcmbox, workstationcmbox };
                Label[] textboxlabels = { serialNumlbl, batchNumlbl, reasonlbl };
                Label[] combolabels = { partNumberlbl, departmentlbl, workstationlbl };
                int index = 0;

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
                        string sqlInsert = "INSERT INTO WIPTracking (PartNumber, SerialNumber, BatchNumber, Department, Workstation, WSTimestampIN)" +
                                            " VALUES (@part, @serial, @batch, @department, @workstation, + " + timestamp + ")";
                        SqlCommand cmd = new SqlCommand(sqlInsert, conn);

                        cmd.Parameters.AddWithValue("@part", partNumber);
                        cmd.Parameters.AddWithValue("@serial", serialNumber);
                        cmd.Parameters.AddWithValue("@batch", batchNumber);
                        cmd.Parameters.AddWithValue("@department", department);
                        cmd.Parameters.AddWithValue("@workstation", workstation);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data inserted");

                        conn.Close();
                    }
                }
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("This serial number is already in the database");
                serialNumlbl.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

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
    }
}