using System.Diagnostics;


namespace DigiScan_Track
{
    public partial class SettingsPage : Form
    {
        public SettingsPage()
        {
            InitializeComponent();
        }


        //A process to send the email - ran into an error here where process.start() wasnt working displaying a file not found error
        //To get round this research was made into ProcessStartInfo which manually tells the process where to look and what to do 
        private void SendEmail(string recipientEmail, string subject)
        {
            try
            {
                string mailtoLink = $"mailto:{recipientEmail}?subject={Uri.EscapeDataString(subject)}";
                Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = $"/c start {mailtoLink}", //uses command line to input a url for the email provider and email address provided 
                    CreateNoWindow = true,
                    UseShellExecute = false
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //This is the email created specifically for this application
        private void Email_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SendEmail("digiscantrackQueries@gmail.com", "DigiScan&Track Application Query");
        }


        //When this link is clicked it takes the user to the tableau help website - allowing them to understand the basics of data visualisation
        private void TableauLinklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.tableau.com/en-gb/learn/get-started/viewer";
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = url, //Opens the browser and inputs the url
                UseShellExecute = true
            };

            Process.Start(startInfo);
        }


        //Displays a block of text on the application
        private void AppHelplbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            appHelppnl.Visible = true;
        }
    }
}
