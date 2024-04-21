using System.Data;
using System.Data.SqlClient;


namespace DigiScan_Track
{
    public partial class HistoryPage : Form
    {

        SqlConnection conn = new SqlConnection();
        HomePageShortcuts home = new HomePageShortcuts();
        WIPTracker wip = new WIPTracker(null, null);

        public HistoryPage()
        {
            InitializeComponent();
            LoadHistorySQL();

            historycmb.SelectedIndex = 0;
            historycmb.DrawItem += home.ComboBox_DrawItem;
            wip.TransparentBackground(this, "searchbtn", "resetbtn");
        }


        //Pulls all data from the history table and populates the gridview
        private void LoadHistorySQL()
        {
            DataTable dt = new DataTable();

            conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM [History]";
            SqlDataReader dr = cmd.ExecuteReader();

            dt.Load(dr);

            conn.Close();

            HistorygridView.DataSource = dt;

            SQLGridViewLayout();
        }



        private void SQLGridViewLayout()
        {
            HistorygridView.Columns[0].HeaderText = "Username";
            HistorygridView.Columns[1].HeaderText = "Action";
            HistorygridView.Columns[2].HeaderText = "Date Performed";
            HistorygridView.Columns[3].HeaderText = "Part/Serial No";

            WIPTracker wip = new WIPTracker(null, null);
            wip.TurnColumnIntoPercent(HistorygridView, 25, 25, 25, 25);

        }


        //Search filter for reducing rows in the gridview
        private void HistorySearchbtn_Click(object sender, EventArgs e)
        {
            if (searchtxt.Text != "")
            {
                string chosenCol = historycmb.SelectedItem.ToString();
                string userSearchValue = searchtxt.Text;

                DataTable dt = new DataTable();

                conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM [History] WHERE [" + chosenCol + "] LIKE @searchvalue";

                cmd.Parameters.AddWithValue("@searchvalue", "%" + userSearchValue + "%"); //This is the line which doesnt require '' around the % unlike SQL

                SqlDataReader dr = cmd.ExecuteReader();

                dt.Load(dr);

                conn.Close();

                HistorygridView.DataSource = dt;
            }

            else
            {
                MessageBox.Show("Please input a search value");
            }
        }



        private void Resetbtn_Click(object sender, EventArgs e)
        {
            LoadHistorySQL();
            searchtxt.Text = string.Empty;
            historycmb.SelectedIndex = 0;
        }



        private void searchtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            HomePage home = new HomePage();
            home.EnterButtonClicked(searchbtn, e);
        }
    }
}
