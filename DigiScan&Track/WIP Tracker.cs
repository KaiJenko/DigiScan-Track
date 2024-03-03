using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace DigiScan_Track
{
    public partial class WIPTracker : Form
    {

        SqlConnection conn = new SqlConnection();

        public WIPTracker()
        {
            InitializeComponent();
            getSQLWIPTracker();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void create_gridView_WIP()
        {

            WIPgridView.Columns[0].HeaderText = "Part No";
            WIPgridView.Columns[1].HeaderText = "Serial No";
            WIPgridView.Columns[2].HeaderText = "Batch No";
            WIPgridView.Columns[3].HeaderText = "Department";
            WIPgridView.Columns[4].HeaderText = "Workstation";
            WIPgridView.Columns[5].HeaderText = "Storage";

            WIPgridView.Columns[0].Width = 180;
            WIPgridView.Columns[1].Width = 180;
            WIPgridView.Columns[2].Width = 180;
            WIPgridView.Columns[3].Width = 180;
            WIPgridView.Columns[4].Width = 180;
            WIPgridView.Columns[5].Width = 180;

            WIPgridView.ColumnHeadersDefaultCellStyle.Font = new Font(WIPgridView.Font.FontFamily, 12, FontStyle.Bold);
            WIPgridView.ColumnHeadersHeight = 50;

        }

        private void getSQLWIPTracker()
        {
            DataTable dt = new DataTable();  // To Hold Sql Value Returned

            SqlConnection con = new SqlConnection(); // Create a connection
            conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
            conn.Open();                                                                                                                                                                                                                                                          // Open db Connection
            SqlCommand cmd = con.CreateCommand();     // make an object to hold an sql command
            cmd.CommandText = "SELECT TOP (1000) [PartNumber] ,[SerialNumber] ,[BatchNumber] ,[Department] ,[Workstation] ,[WSTimestampIN] ,[WSTimestampOUT] ,[InStorage] FROM [DigiTrackAndScan].[dbo].[WIPTracking]";        // add SQL to CommandText option
            SqlDataReader dr = cmd.ExecuteReader();   // Create an SqlDataReader to load data to and load with <sqlcommandobject>. ExecuteReader()

            dt.Load(dr);

            con.Close();  // Close sql connection when complete to release memory etc.

            WIPgridView.DataSource = dt;   // return the sql value we bought back

            create_gridView_WIP();
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

        private void HomeAreabtn_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage(); //Create a new instance of the homepage to be called upon
            HeaderButton(homepage, this, this.WindowState); //open homepage, close this form, make the homepage windowstate match the current forms
        }

        private void WIPTrackerbtn_Click(object sender, EventArgs e)
        {
            WIPTracker wiptracker = new WIPTracker();
            HeaderButton(wiptracker, this, this.WindowState);
        }

        private void AgedWIPbtn_Click(object sender, EventArgs e)
        {
            AgedWIP agedwip = new AgedWIP();
            HeaderButton(agedwip, this, this.WindowState);
        }

        private void EditPartsbtn_Click(object sender, EventArgs e)
        {
            EditParts editparts = new EditParts();
            HeaderButton(editparts, this, this.WindowState);
        }

        private void ManualInputbtn_Click(object sender, EventArgs e)
        {
            ManualInput manualinput = new ManualInput();
            HeaderButton(manualinput, this, this.WindowState);
        }

        private void DisplayBoardbtn_Click(object sender, EventArgs e)
        {
            DisplayBoard displayboard = new DisplayBoard();
            HeaderButton(displayboard, this, this.WindowState);
        }


    }
}
