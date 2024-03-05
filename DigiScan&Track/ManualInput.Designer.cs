namespace DigiScan_Track
{
    partial class ManualInput
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
            manualTablepnl = new TableLayoutPanel();
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
            dashpnl = new Panel();
            collapsepicbox = new PictureBox();
            manualTablepnl.SuspendLayout();
            HomePageheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Userimgbox).BeginInit();
            dashpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)collapsepicbox).BeginInit();
            SuspendLayout();
            // 
            // manualTablepnl
            // 
            manualTablepnl.ColumnCount = 2;
            manualTablepnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.344656F));
            manualTablepnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.65534F));
            manualTablepnl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            manualTablepnl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            manualTablepnl.Controls.Add(HomePageheader, 0, 0);
            manualTablepnl.Controls.Add(dashpnl, 0, 1);
            manualTablepnl.Dock = DockStyle.Fill;
            manualTablepnl.Location = new Point(0, 0);
            manualTablepnl.Name = "manualTablepnl";
            manualTablepnl.RowCount = 2;
            manualTablepnl.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5816994F));
            manualTablepnl.RowStyles.Add(new RowStyle(SizeType.Percent, 87.4183044F));
            manualTablepnl.Size = new Size(1207, 612);
            manualTablepnl.TabIndex = 1;
            // 
            // HomePageheader
            // 
            HomePageheader.BackColor = Color.Red;
            manualTablepnl.SetColumnSpan(HomePageheader, 2);
            HomePageheader.Controls.Add(Userimgbox);
            HomePageheader.Controls.Add(Usernamelbl);
            HomePageheader.Controls.Add(DisplayBoardbtn);
            HomePageheader.Controls.Add(ManualInputbtn);
            HomePageheader.Controls.Add(EditPartsbtn);
            HomePageheader.Controls.Add(AgedWIPbtn);
            HomePageheader.Controls.Add(HomeAreabtn);
            HomePageheader.Controls.Add(Titlelbl);
            HomePageheader.Controls.Add(WIPTrackerbtn);
            HomePageheader.Dock = DockStyle.Top;
            HomePageheader.Location = new Point(0, 0);
            HomePageheader.Margin = new Padding(0);
            HomePageheader.Name = "HomePageheader";
            HomePageheader.Size = new Size(1207, 75);
            HomePageheader.TabIndex = 1;
            // 
            // Userimgbox
            // 
            Userimgbox.Image = Properties.Resources.UserImage;
            Userimgbox.Location = new Point(1024, 16);
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
            Usernamelbl.Location = new Point(1095, 27);
            Usernamelbl.Name = "Usernamelbl";
            Usernamelbl.Size = new Size(100, 26);
            Usernamelbl.TabIndex = 5;
            Usernamelbl.Text = "Username";
            // 
            // DisplayBoardbtn
            // 
            DisplayBoardbtn.Location = new Point(892, 26);
            DisplayBoardbtn.Name = "DisplayBoardbtn";
            DisplayBoardbtn.Size = new Size(91, 26);
            DisplayBoardbtn.TabIndex = 2;
            DisplayBoardbtn.Text = "Display Board";
            DisplayBoardbtn.UseVisualStyleBackColor = true;
            // 
            // ManualInputbtn
            // 
            ManualInputbtn.Location = new Point(774, 27);
            ManualInputbtn.Name = "ManualInputbtn";
            ManualInputbtn.Size = new Size(96, 26);
            ManualInputbtn.TabIndex = 2;
            ManualInputbtn.Text = "Manual Input";
            ManualInputbtn.UseVisualStyleBackColor = true;
            // 
            // EditPartsbtn
            // 
            EditPartsbtn.Location = new Point(672, 27);
            EditPartsbtn.Name = "EditPartsbtn";
            EditPartsbtn.Size = new Size(82, 26);
            EditPartsbtn.TabIndex = 2;
            EditPartsbtn.Text = "Edit Parts";
            EditPartsbtn.UseVisualStyleBackColor = true;
            // 
            // AgedWIPbtn
            // 
            AgedWIPbtn.Location = new Point(563, 27);
            AgedWIPbtn.Name = "AgedWIPbtn";
            AgedWIPbtn.Size = new Size(82, 26);
            AgedWIPbtn.TabIndex = 4;
            AgedWIPbtn.Text = "Aged WIP";
            AgedWIPbtn.UseVisualStyleBackColor = true;
            // 
            // HomeAreabtn
            // 
            HomeAreabtn.Location = new Point(343, 27);
            HomeAreabtn.Name = "HomeAreabtn";
            HomeAreabtn.Size = new Size(82, 26);
            HomeAreabtn.TabIndex = 3;
            HomeAreabtn.Text = "Home Area";
            HomeAreabtn.UseVisualStyleBackColor = true;
            // 
            // Titlelbl
            // 
            Titlelbl.AutoSize = true;
            Titlelbl.BackColor = Color.Transparent;
            Titlelbl.Font = new Font("Yu Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Titlelbl.ForeColor = Color.White;
            Titlelbl.Location = new Point(36, 22);
            Titlelbl.Name = "Titlelbl";
            Titlelbl.Size = new Size(264, 35);
            Titlelbl.TabIndex = 2;
            Titlelbl.Text = "Manual Part Input \r\n";
            Titlelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WIPTrackerbtn
            // 
            WIPTrackerbtn.Location = new Point(454, 27);
            WIPTrackerbtn.Name = "WIPTrackerbtn";
            WIPTrackerbtn.Size = new Size(82, 26);
            WIPTrackerbtn.TabIndex = 1;
            WIPTrackerbtn.Text = "WIP Tracker";
            WIPTrackerbtn.UseVisualStyleBackColor = true;
            // 
            // dashpnl
            // 
            dashpnl.BackColor = Color.FromArgb(24, 30, 54);
            dashpnl.Controls.Add(collapsepicbox);
            dashpnl.Dock = DockStyle.Fill;
            dashpnl.Location = new Point(0, 77);
            dashpnl.Margin = new Padding(0);
            dashpnl.Name = "dashpnl";
            dashpnl.Size = new Size(149, 535);
            dashpnl.TabIndex = 2;
            // 
            // collapsepicbox
            // 
            collapsepicbox.Location = new Point(36, 17);
            collapsepicbox.Name = "collapsepicbox";
            collapsepicbox.Size = new Size(100, 50);
            collapsepicbox.TabIndex = 3;
            collapsepicbox.TabStop = false;
            // 
            // ManualInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1207, 612);
            Controls.Add(manualTablepnl);
            Name = "ManualInput";
            Text = "Form1";
            Load += Form1_Load;
            manualTablepnl.ResumeLayout(false);
            HomePageheader.ResumeLayout(false);
            HomePageheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Userimgbox).EndInit();
            dashpnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)collapsepicbox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel manualTablepnl;
        private Panel HomePageheader;
        private PictureBox Userimgbox;
        private Label Usernamelbl;
        private Button DisplayBoardbtn;
        private Button ManualInputbtn;
        private Button EditPartsbtn;
        private Button AgedWIPbtn;
        private Button HomeAreabtn;
        private Label Titlelbl;
        private Button WIPTrackerbtn;
        private Panel dashpnl;
        private PictureBox collapsepicbox;
    }
}