namespace DigiScan_Track
{
    partial class WIPTracker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HomePageheader = new Panel();
            Userimgbox = new PictureBox();
            Usernamelbl = new Label();
            DisplayBoardbtn = new Button();
            ManualInputbtn = new Button();
            EditPartsbtn = new Button();
            AgedWIPbtn = new Button();
            HomeAreabtn = new Button();
            Titlelbl = new Label();
            WIPTrackerbtn = new Button();
            HomePagefooter = new Panel();
            HomePageheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Userimgbox).BeginInit();
            SuspendLayout();
            // 
            // HomePageheader
            // 
            HomePageheader.BackColor = Color.Red;
            HomePageheader.Controls.Add(Userimgbox);
            HomePageheader.Controls.Add(Usernamelbl);
            HomePageheader.Controls.Add(DisplayBoardbtn);
            HomePageheader.Controls.Add(ManualInputbtn);
            HomePageheader.Controls.Add(EditPartsbtn);
            HomePageheader.Controls.Add(AgedWIPbtn);
            HomePageheader.Controls.Add(HomeAreabtn);
            HomePageheader.Controls.Add(Titlelbl);
            HomePageheader.Controls.Add(WIPTrackerbtn);
            HomePageheader.Location = new Point(0, -7);
            HomePageheader.Margin = new Padding(4, 5, 4, 5);
            HomePageheader.Name = "HomePageheader";
            HomePageheader.Size = new Size(1730, 125);
            HomePageheader.TabIndex = 0;
            // 
            // Userimgbox
            // 
            Userimgbox.Image = Properties.Resources.UserImage;
            Userimgbox.Location = new Point(1474, 27);
            Userimgbox.Margin = new Padding(4, 5, 4, 5);
            Userimgbox.Name = "Userimgbox";
            Userimgbox.Size = new Size(81, 83);
            Userimgbox.SizeMode = PictureBoxSizeMode.StretchImage;
            Userimgbox.TabIndex = 6;
            Userimgbox.TabStop = false;
            // 
            // Usernamelbl
            // 
            Usernamelbl.BackColor = Color.Transparent;
            Usernamelbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Usernamelbl.ForeColor = Color.White;
            Usernamelbl.Location = new Point(1564, 45);
            Usernamelbl.Margin = new Padding(4, 0, 4, 0);
            Usernamelbl.Name = "Usernamelbl";
            Usernamelbl.Size = new Size(143, 43);
            Usernamelbl.TabIndex = 5;
            Usernamelbl.Text = "Username";
            // 
            // DisplayBoardbtn
            // 
            DisplayBoardbtn.Location = new Point(1274, 43);
            DisplayBoardbtn.Margin = new Padding(4, 5, 4, 5);
            DisplayBoardbtn.Name = "DisplayBoardbtn";
            DisplayBoardbtn.Size = new Size(130, 43);
            DisplayBoardbtn.TabIndex = 2;
            DisplayBoardbtn.Text = "Display Board";
            DisplayBoardbtn.UseVisualStyleBackColor = true;
            DisplayBoardbtn.Click += DisplayBoardbtn_Click;
            // 
            // ManualInputbtn
            // 
            ManualInputbtn.Location = new Point(1106, 45);
            ManualInputbtn.Margin = new Padding(4, 5, 4, 5);
            ManualInputbtn.Name = "ManualInputbtn";
            ManualInputbtn.Size = new Size(137, 43);
            ManualInputbtn.TabIndex = 2;
            ManualInputbtn.Text = "Manual Input";
            ManualInputbtn.UseVisualStyleBackColor = true;
            ManualInputbtn.Click += ManualInputbtn_Click;
            // 
            // EditPartsbtn
            // 
            EditPartsbtn.Location = new Point(960, 45);
            EditPartsbtn.Margin = new Padding(4, 5, 4, 5);
            EditPartsbtn.Name = "EditPartsbtn";
            EditPartsbtn.Size = new Size(117, 43);
            EditPartsbtn.TabIndex = 2;
            EditPartsbtn.Text = "Edit Parts";
            EditPartsbtn.UseVisualStyleBackColor = true;
            EditPartsbtn.Click += EditPartsbtn_Click;

            // 
            // AgedWIPbtn
            // 
            AgedWIPbtn.Location = new Point(804, 45);
            AgedWIPbtn.Margin = new Padding(4, 5, 4, 5);
            AgedWIPbtn.Name = "AgedWIPbtn";
            AgedWIPbtn.Size = new Size(117, 43);
            AgedWIPbtn.TabIndex = 4;
            AgedWIPbtn.Text = "Aged WIP";
            AgedWIPbtn.UseVisualStyleBackColor = true;
            AgedWIPbtn.Click += AgedWIPbtn_Click;
            // 
            // HomeAreabtn
            // 
            HomeAreabtn.Location = new Point(490, 45);
            HomeAreabtn.Margin = new Padding(4, 5, 4, 5);
            HomeAreabtn.Name = "HomeAreabtn";
            HomeAreabtn.Size = new Size(117, 43);
            HomeAreabtn.TabIndex = 3;
            HomeAreabtn.Text = "Home Area";
            HomeAreabtn.UseVisualStyleBackColor = true;
            HomeAreabtn.Click += HomeAreabtn_Click;
            // 
            // Titlelbl
            // 
            Titlelbl.AutoSize = true;
            Titlelbl.BackColor = Color.Transparent;
            Titlelbl.Font = new Font("Yu Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Titlelbl.ForeColor = Color.White;
            Titlelbl.Location = new Point(64, 10);
            Titlelbl.Margin = new Padding(4, 0, 4, 0);
            Titlelbl.Name = "Titlelbl";
            Titlelbl.Size = new Size(359, 106);
            Titlelbl.TabIndex = 2;
            Titlelbl.Text = "Work In Progress\r\nTracker\r\n";
            Titlelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WIPTrackerbtn
            // 
            WIPTrackerbtn.Location = new Point(649, 45);
            WIPTrackerbtn.Margin = new Padding(4, 5, 4, 5);
            WIPTrackerbtn.Name = "WIPTrackerbtn";
            WIPTrackerbtn.Size = new Size(117, 43);
            WIPTrackerbtn.TabIndex = 1;
            WIPTrackerbtn.Text = "WIP Tracker";
            WIPTrackerbtn.UseVisualStyleBackColor = true;
            WIPTrackerbtn.Click += WIPTrackerbtn_Click;
            // 
            // HomePagefooter
            // 
            HomePagefooter.BackColor = Color.DimGray;
            HomePagefooter.Location = new Point(-1, 965);
            HomePagefooter.Margin = new Padding(4, 5, 4, 5);
            HomePagefooter.Name = "HomePagefooter";
            HomePagefooter.Size = new Size(1730, 57);
            HomePagefooter.TabIndex = 1;
            // 
            // WIPTracker
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1724, 1020);
            Controls.Add(HomePagefooter);
            Controls.Add(HomePageheader);
            Margin = new Padding(4, 5, 4, 5);
            Name = "WIPTracker";
            Text = "Form1";
            Load += Form1_Load;
            HomePageheader.ResumeLayout(false);
            HomePageheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Userimgbox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel HomePageheader;
        private Button WIPTrackerbtn;
        private Panel HomePagefooter;
        private Label Titlelbl;
        private Label Usernamelbl;
        private Button DisplayBoardbtn;
        private Button ManualInputbtn;
        private Button EditPartsbtn;
        private Button AgedWIPbtn;
        private Button HomeAreabtn;
        private PictureBox Userimgbox;
    }
}