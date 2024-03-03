namespace DigiScan_Track
{
    partial class HomePage
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
            Shortcutlbl = new Label();
            Departmentcmb = new ComboBox();
            Departmentlbl = new Label();
            HomepageImageflow = new FlowLayoutPanel();
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
            HomePageheader.Location = new Point(0, -4);
            HomePageheader.Name = "HomePageheader";
            HomePageheader.Size = new Size(1211, 75);
            HomePageheader.TabIndex = 0;
            // 
            // Userimgbox
            // 
            Userimgbox.Image = Properties.Resources.UserImage;
            Userimgbox.Location = new Point(1031, 16);
            Userimgbox.Name = "Userimgbox";
            Userimgbox.Size = new Size(58, 50);
            Userimgbox.SizeMode = PictureBoxSizeMode.StretchImage;
            Userimgbox.TabIndex = 6;
            Userimgbox.TabStop = false;
            // 
            // Usernamelbl
            // 
            Usernamelbl.BackColor = Color.Transparent;
            Usernamelbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Usernamelbl.ForeColor = Color.White;
            Usernamelbl.Location = new Point(1095, 26);
            Usernamelbl.Name = "Usernamelbl";
            Usernamelbl.Size = new Size(100, 26);
            Usernamelbl.TabIndex = 5;
            Usernamelbl.Text = "Username";
            // 
            // DisplayBoardbtn
            // 
            DisplayBoardbtn.Cursor = Cursors.Hand;
            DisplayBoardbtn.Location = new Point(892, 26);
            DisplayBoardbtn.Name = "DisplayBoardbtn";
            DisplayBoardbtn.Size = new Size(91, 26);
            DisplayBoardbtn.TabIndex = 2;
            DisplayBoardbtn.Text = "Display Board";
            DisplayBoardbtn.UseVisualStyleBackColor = true;
            DisplayBoardbtn.Click += DisplayBoardbtn_Click;
            // 
            // ManualInputbtn
            // 
            ManualInputbtn.Cursor = Cursors.Hand;
            ManualInputbtn.Location = new Point(774, 27);
            ManualInputbtn.Name = "ManualInputbtn";
            ManualInputbtn.Size = new Size(96, 26);
            ManualInputbtn.TabIndex = 2;
            ManualInputbtn.Text = "Manual Input";
            ManualInputbtn.UseVisualStyleBackColor = true;
            ManualInputbtn.Click += ManualInputbtn_Click;
            // 
            // EditPartsbtn
            // 
            EditPartsbtn.Cursor = Cursors.Hand;
            EditPartsbtn.Location = new Point(672, 27);
            EditPartsbtn.Name = "EditPartsbtn";
            EditPartsbtn.Size = new Size(82, 26);
            EditPartsbtn.TabIndex = 2;
            EditPartsbtn.Text = "Edit Parts";
            EditPartsbtn.UseVisualStyleBackColor = true;
            EditPartsbtn.Click += EditPartsbtn_Click;
            // 
            // AgedWIPbtn
            // 
            AgedWIPbtn.Cursor = Cursors.Hand;
            AgedWIPbtn.Location = new Point(563, 27);
            AgedWIPbtn.Name = "AgedWIPbtn";
            AgedWIPbtn.Size = new Size(82, 26);
            AgedWIPbtn.TabIndex = 4;
            AgedWIPbtn.Text = "Aged WIP";
            AgedWIPbtn.UseVisualStyleBackColor = true;
            AgedWIPbtn.Click += AgedWIPbtn_Click;
            // 
            // HomeAreabtn
            // 
            HomeAreabtn.Cursor = Cursors.Hand;
            HomeAreabtn.Location = new Point(343, 27);
            HomeAreabtn.Name = "HomeAreabtn";
            HomeAreabtn.Size = new Size(82, 26);
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
            Titlelbl.Location = new Point(45, 6);
            Titlelbl.Name = "Titlelbl";
            Titlelbl.Size = new Size(280, 70);
            Titlelbl.TabIndex = 2;
            Titlelbl.Text = "DigiScan and Track \r\nHome Area";
            Titlelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WIPTrackerbtn
            // 
            WIPTrackerbtn.Cursor = Cursors.Hand;
            WIPTrackerbtn.Location = new Point(454, 27);
            WIPTrackerbtn.Name = "WIPTrackerbtn";
            WIPTrackerbtn.Size = new Size(82, 26);
            WIPTrackerbtn.TabIndex = 1;
            WIPTrackerbtn.Text = "WIP Tracker";
            WIPTrackerbtn.UseVisualStyleBackColor = true;
            WIPTrackerbtn.Click += WIPTrackerbtn_Click;
            // 
            // HomePagefooter
            // 
            HomePagefooter.BackColor = Color.DimGray;
            HomePagefooter.Location = new Point(-1, 579);
            HomePagefooter.Name = "HomePagefooter";
            HomePagefooter.Size = new Size(1212, 34);
            HomePagefooter.TabIndex = 1;
            // 
            // Shortcutlbl
            // 
            Shortcutlbl.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Shortcutlbl.Location = new Point(12, 86);
            Shortcutlbl.Name = "Shortcutlbl";
            Shortcutlbl.Size = new Size(625, 41);
            Shortcutlbl.TabIndex = 2;
            Shortcutlbl.Text = "Select Shortcut to be taken to apropriate page";
            // 
            // Departmentcmb
            // 
            Departmentcmb.Cursor = Cursors.Hand;
            Departmentcmb.DropDownStyle = ComboBoxStyle.DropDownList;
            Departmentcmb.FlatStyle = FlatStyle.Popup;
            Departmentcmb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Departmentcmb.ForeColor = SystemColors.InfoText;
            Departmentcmb.FormattingEnabled = true;
            Departmentcmb.Location = new Point(1021, 89);
            Departmentcmb.Name = "Departmentcmb";
            Departmentcmb.Size = new Size(147, 29);
            Departmentcmb.TabIndex = 3;
            Departmentcmb.SelectedIndexChanged += Departmentcmb_SelectedIndexChanged;
            // 
            // Departmentlbl
            // 
            Departmentlbl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Departmentlbl.Location = new Point(776, 93);
            Departmentlbl.Name = "Departmentlbl";
            Departmentlbl.Size = new Size(249, 24);
            Departmentlbl.TabIndex = 4;
            Departmentlbl.Text = "Select Your Departmental Area:\r\n";
            // 
            // HomepageImageflow
            // 
            HomepageImageflow.Location = new Point(45, 130);
            HomepageImageflow.Name = "HomepageImageflow";
            HomepageImageflow.Size = new Size(1110, 411);
            HomepageImageflow.TabIndex = 5;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 611);
            Controls.Add(HomepageImageflow);
            Controls.Add(Departmentcmb);
            Controls.Add(Shortcutlbl);
            Controls.Add(HomePagefooter);
            Controls.Add(HomePageheader);
            Controls.Add(Departmentlbl);
            Name = "HomePage";
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
        private Label Shortcutlbl;
        private ComboBox Departmentcmb;
        private Label Departmentlbl;
        private FlowLayoutPanel HomepageImageflow;
    }
}