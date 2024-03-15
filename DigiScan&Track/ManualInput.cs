using System.Data.SqlClient;


namespace DigiScan_Track
{
    public partial class ManualInput : Form
    {

        SqlConnection conn = new SqlConnection();

        public ManualInput(string departmentName, string workstation)
        {
            InitializeComponent();
            /*getSQLHomepage();*/
            insertDepartment(departmentName, workstation);
        }


        /*private void getSQLHomepage()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;"
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM WIPTracking";
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            dataGridView1.DataSource = dt;
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string partNumber = partNumcmbox.Text.ToString();
                string serialNumber = serialNumtxt.Text.ToString();
                string batchNumber = batchNumtxt.Text.ToString();
                string manager = lineManagertxt.Text.ToString();
                string department = departmentcmbox.Text.ToString();
                string workstation = workstationcmbox.Text.ToString();
                string timestamp = timestamptxt.Value.ToString();
                string reason = reasontxt.Text.ToString();
                string notes = notestxt.Text.ToString();

                TextBox[] textboxes = { serialNumtxt, batchNumtxt, reasontxt };
                ComboBox[] comboBoxes = { partNumcmbox, departmentcmbox, workstationcmbox };
                Label[] textboxlabels = { serialNumlbl, batchNumlbl, reasonlbl };
                Label[] combolabels = { partNumberlbl, departmentlbl, workstationlbl };

                for (int x = 0; x < textboxes.Length; x++)
                {
                    if (string.IsNullOrEmpty(textboxes[x].Text))
                    {
                        textboxlabels[x].ForeColor = Color.Red; // Change text color of the corresponding label to red
                    }
                    else
                    {
                        textboxlabels[x].ForeColor = Color.FromArgb(0, 126, 249); // Reset text color to default if the textbox is not empty
                    }
                }

                for (int y = 0; y < comboBoxes.Length; y++)
                {
                    if (comboBoxes[y].SelectedIndex == -1)
                    {
                        combolabels[y].ForeColor = Color.Red; // Change text color of the corresponding label to red
                    }
                    else
                    {
                        combolabels[y].ForeColor = Color.FromArgb(0, 126, 249); // Reset text color to default if the textbox is not empty
                    }
                }

                if (partNumber != "Part Number" && serialNumber != null && batchNumber != null && department != "Department" && workstation != "Workstation" && timestamp != null)
                {


                    conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
                    conn.Open();
                    string sqlInsert = "INSERT INTO WIPTracking (PartNumber, SerialNumber, BatchNumber, Department, Workstation, WSTimestampIN)" +
                                      " VALUES (@part, @serial, @batch, @department, @workstation, @time)";
                    SqlCommand cmd = new SqlCommand(sqlInsert, conn);

                    cmd.Parameters.AddWithValue("@part", partNumber);
                    cmd.Parameters.AddWithValue("@serial", serialNumber);
                    cmd.Parameters.AddWithValue("@batch", batchNumber);
                    cmd.Parameters.AddWithValue("@department", department);
                    cmd.Parameters.AddWithValue("@workstation", workstation);
                    cmd.Parameters.AddWithValue("@time", timestamp);

                    cmd.ExecuteNonQuery();

                    SqlDataReader dr = cmd.ExecuteReader();

                    MessageBox.Show("Data inserted");
                }

                else
                {
                    MessageBox.Show("You have empty fields");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {

        }

        private void nocheckbox_CheckedChanged(object sender, EventArgs e)
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

        private void yescheckbox_CheckedChanged(object sender, EventArgs e)
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

        private void insertDepartment(string department, string workstation)
        {
            if (department != null)
            {
                int departmentIndex = departmentcmbox.FindString(department);
                departmentcmbox.SelectedIndex = departmentIndex;
                int workstationIndex = workstationcmbox.FindString(workstation);
                workstationcmbox.SelectedIndex = workstationIndex;

            }

            else
            {
                departmentcmbox.SelectedIndex = -1;
                workstationcmbox.SelectedIndex = -1;
            }

        }

        private void loadDetails(string chosenDepartment)
        {
            string[] departmentList = { "Nacelles", "Gears", "Military" };
            string[][] workstations = new string[3][];
            workstations[0] = new string[0] { };
            workstations[1] = new string[6] { "Bevelling", "Etching", "Precision", "Production", "Modelling", "Shim Grinding" };
            workstations[2] = new string[4] { "GLMRS", "Shipping", "HMO", "GPS" };

            string[][] partNumbers = new string[3][];
            partNumbers[0] = new string[0] { };
            partNumbers[1] = new string[4] { "COG78643", "FYG345", "AAG320", "BIO879" };
            partNumbers[2] = new string[6] { "TYM93787", "AQM45", "TYM8143", "AUM15", "PLM258", "PGM55" };


            int index = Array.IndexOf(departmentList, chosenDepartment);

            for (int i = 0; i < workstations[index].Length; i++)
            {
                workstationcmbox.Items.Add(workstations[index][i]);
            }

            for (int i = 0; i < partNumbers[index].Length; i++)
            {
                partNumcmbox.Items.Add(partNumbers[index][i]);
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

        private void departmentcmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDepartment = departmentcmbox.SelectedItem.ToString();
            partNumcmbox.Items.Clear();
            workstationcmbox.Items.Clear();
            loadDetails(selectedDepartment);
            workstationcmbox.SelectedIndex = 0;
        }
    }
}