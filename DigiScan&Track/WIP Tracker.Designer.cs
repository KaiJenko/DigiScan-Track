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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
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
            searchcmb = new ComboBox();
            searchtxt = new TextBox();
            label1 = new Label();
            WIPgridView = new DataGridView();
            searchbtn = new Button();
            resetbtn = new Button();
            HomePageheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Userimgbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WIPgridView).BeginInit();
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
            HomePagefooter.Location = new Point(0, 897);
            HomePagefooter.Margin = new Padding(4, 5, 4, 5);
            HomePagefooter.Name = "HomePagefooter";
            HomePagefooter.Size = new Size(1730, 57);
            HomePagefooter.TabIndex = 1;
            // 
            // searchcmb
            // 
            searchcmb.BackColor = SystemColors.Window;
            searchcmb.FlatStyle = FlatStyle.Popup;
            searchcmb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchcmb.FormattingEnabled = true;
            searchcmb.Items.AddRange(new object[] { "Part Number", "Serial Number", "Batch Number", "Department", "Workstation", "In Storage" });
            searchcmb.Location = new Point(161, 143);
            searchcmb.Margin = new Padding(4, 5, 4, 5);
            searchcmb.Name = "searchcmb";
            searchcmb.Size = new Size(211, 40);
            searchcmb.TabIndex = 3;
            // 
            // searchtxt
            // 
            searchtxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchtxt.Location = new Point(396, 144);
            searchtxt.Margin = new Padding(4, 5, 4, 5);
            searchtxt.Name = "searchtxt";
            searchtxt.Size = new Size(560, 39);
            searchtxt.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 146);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 32);
            label1.TabIndex = 5;
            label1.Text = "Search by";
            // 
            // WIPgridView
            // 
            WIPgridView.BackgroundColor = Color.FromArgb(45, 66, 91);
            WIPgridView.BorderStyle = BorderStyle.None;
            WIPgridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            WIPgridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            WIPgridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            WIPgridView.DefaultCellStyle = dataGridViewCellStyle6;
            WIPgridView.GridColor = Color.White;
            WIPgridView.Location = new Point(33, 215);
            WIPgridView.Margin = new Padding(4, 5, 4, 5);
            WIPgridView.Name = "WIPgridView";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            WIPgridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            WIPgridView.RowHeadersVisible = false;
            WIPgridView.RowHeadersWidth = 62;
            dataGridViewCellStyle8.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            WIPgridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            WIPgridView.RowTemplate.Height = 25;
            WIPgridView.Size = new Size(1654, 653);
            WIPgridView.TabIndex = 6;
            // 
            // searchbtn
            // 
            searchbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            searchbtn.Location = new Point(971, 142);
            searchbtn.Margin = new Padding(4, 5, 4, 5);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(99, 47);
            searchbtn.TabIndex = 7;
            searchbtn.Text = "Enter";
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_Click;
            // 
            // resetbtn
            // 
            resetbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            resetbtn.Location = new Point(1087, 142);
            resetbtn.Margin = new Padding(4, 5, 4, 5);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(144, 47);
            resetbtn.TabIndex = 8;
            resetbtn.Text = "Reset Table";
            resetbtn.UseVisualStyleBackColor = true;
            resetbtn.Click += resetbtn_Click;
            // 
            // WIPTracker
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1727, 943);
            Controls.Add(resetbtn);
            Controls.Add(searchbtn);
            Controls.Add(WIPgridView);
            Controls.Add(label1);
            Controls.Add(searchtxt);
            Controls.Add(searchcmb);
            Controls.Add(HomePagefooter);
            Controls.Add(HomePageheader);
            Margin = new Padding(4, 5, 4, 5);
            Name = "WIPTracker";
            Text = "Form1";
            Load += Form1_Load;
            HomePageheader.ResumeLayout(false);
            HomePageheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Userimgbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)WIPgridView).EndInit();
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
        private ComboBox searchcmb;
        private TextBox searchtxt;
        private Label label1;
        private DataGridView WIPgridView;
        private Button searchbtn;
        private Button resetbtn;
    }
}