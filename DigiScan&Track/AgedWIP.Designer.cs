namespace DigiScan_Track
{
    partial class AgedWIP
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
            AgedGridView = new DataGridView();
            agedlbl = new Label();
            agedtxt = new TextBox();
            agedcmb = new ComboBox();
            excelbtn = new Button();
            tableaubtn = new Button();
            HomePageheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Userimgbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AgedGridView).BeginInit();
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
            DisplayBoardbtn.Click += DisplayBoardbtn_Click;
            // 
            // ManualInputbtn
            // 
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
            Titlelbl.Size = new Size(199, 70);
            Titlelbl.TabIndex = 2;
            Titlelbl.Text = "Aged Work In \r\nProgress";
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
            WIPTrackerbtn.Click += WIPTrackerbtn_Click;
            // 
            // HomePagefooter
            // 
            HomePagefooter.BackColor = Color.DimGray;
            HomePagefooter.Location = new Point(-1, 579);
            HomePagefooter.Name = "HomePagefooter";
            HomePagefooter.Size = new Size(1211, 34);
            HomePagefooter.TabIndex = 1;
            // 
            // AgedGridView
            // 
            AgedGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AgedGridView.Location = new Point(12, 173);
            AgedGridView.Name = "AgedGridView";
            AgedGridView.RowTemplate.Height = 25;
            AgedGridView.Size = new Size(1183, 391);
            AgedGridView.TabIndex = 2;
            // 
            // agedlbl
            // 
            agedlbl.AutoSize = true;
            agedlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            agedlbl.Location = new Point(24, 108);
            agedlbl.Name = "agedlbl";
            agedlbl.Size = new Size(166, 21);
            agedlbl.TabIndex = 8;
            agedlbl.Text = "Search Days as Aged";
            // 
            // agedtxt
            // 
            agedtxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            agedtxt.Location = new Point(361, 105);
            agedtxt.Name = "agedtxt";
            agedtxt.Size = new Size(175, 29);
            agedtxt.TabIndex = 7;
            // 
            // agedcmb
            // 
            agedcmb.BackColor = SystemColors.Window;
            agedcmb.FlatStyle = FlatStyle.Popup;
            agedcmb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            agedcmb.FormattingEnabled = true;
            agedcmb.Items.AddRange(new object[] { "=", "<", ">", "<=", ">=", "Range" });
            agedcmb.Location = new Point(196, 105);
            agedcmb.Name = "agedcmb";
            agedcmb.Size = new Size(149, 29);
            agedcmb.TabIndex = 6;
            // 
            // excelbtn
            // 
            excelbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            excelbtn.Location = new Point(1049, 77);
            excelbtn.Name = "excelbtn";
            excelbtn.Size = new Size(69, 42);
            excelbtn.TabIndex = 9;
            excelbtn.Text = "Excel Export";
            excelbtn.UseVisualStyleBackColor = true;
            // 
            // tableaubtn
            // 
            tableaubtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tableaubtn.Location = new Point(1049, 125);
            tableaubtn.Name = "tableaubtn";
            tableaubtn.Size = new Size(69, 42);
            tableaubtn.TabIndex = 10;
            tableaubtn.Text = "Tableau Metrics";
            tableaubtn.UseVisualStyleBackColor = true;
            // 
            // AgedWIP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 612);
            Controls.Add(tableaubtn);
            Controls.Add(excelbtn);
            Controls.Add(agedlbl);
            Controls.Add(agedtxt);
            Controls.Add(agedcmb);
            Controls.Add(AgedGridView);
            Controls.Add(HomePagefooter);
            Controls.Add(HomePageheader);
            Name = "AgedWIP";
            Text = "Form1";
            Load += Form1_Load;
            HomePageheader.ResumeLayout(false);
            HomePageheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Userimgbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)AgedGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private DataGridView AgedGridView;
        private Label agedlbl;
        private TextBox agedtxt;
        private ComboBox agedcmb;
        private Button excelbtn;
        private Button tableaubtn;
    }
}