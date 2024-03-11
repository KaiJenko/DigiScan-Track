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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            HomePagefooter = new Panel();
            searchcmb = new ComboBox();
            searchtxt = new TextBox();
            label1 = new Label();
            WIPgridView = new DataGridView();
            searchbtn = new Button();
            resetbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)WIPgridView).BeginInit();
            SuspendLayout();
            // 
            // HomePagefooter
            // 
            HomePagefooter.BackColor = Color.DimGray;
            HomePagefooter.Location = new Point(0, 580);
            HomePagefooter.Name = "HomePagefooter";
            HomePagefooter.Size = new Size(1088, 34);
            HomePagefooter.TabIndex = 1;
            // 
            // searchcmb
            // 
            searchcmb.BackColor = SystemColors.Window;
            searchcmb.FlatStyle = FlatStyle.Popup;
            searchcmb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchcmb.FormattingEnabled = true;
            searchcmb.Items.AddRange(new object[] { "Part Number", "Serial Number", "Batch Number", "Department", "Workstation", "In Storage" });
            searchcmb.Location = new Point(102, 43);
            searchcmb.Name = "searchcmb";
            searchcmb.Size = new Size(149, 29);
            searchcmb.TabIndex = 3;
            // 
            // searchtxt
            // 
            searchtxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchtxt.Location = new Point(257, 43);
            searchtxt.Name = "searchtxt";
            searchtxt.Size = new Size(393, 29);
            searchtxt.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 5;
            label1.Text = "Search by";
            // 
            // WIPgridView
            // 
            WIPgridView.BackgroundColor = Color.FromArgb(45, 66, 91);
            WIPgridView.BorderStyle = BorderStyle.None;
            WIPgridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            WIPgridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            WIPgridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            WIPgridView.DefaultCellStyle = dataGridViewCellStyle2;
            WIPgridView.GridColor = Color.White;
            WIPgridView.Location = new Point(27, 89);
            WIPgridView.Name = "WIPgridView";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            WIPgridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            WIPgridView.RowHeadersVisible = false;
            WIPgridView.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            WIPgridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            WIPgridView.RowTemplate.Height = 25;
            WIPgridView.Size = new Size(1034, 472);
            WIPgridView.TabIndex = 6;
            // 
            // searchbtn
            // 
            searchbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            searchbtn.Location = new Point(885, 46);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(69, 28);
            searchbtn.TabIndex = 7;
            searchbtn.Text = "Enter";
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_Click;
            // 
            // resetbtn
            // 
            resetbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            resetbtn.Location = new Point(960, 46);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(101, 28);
            resetbtn.TabIndex = 8;
            resetbtn.Text = "Reset Table";
            resetbtn.UseVisualStyleBackColor = true;
            resetbtn.Click += resetbtn_Click;
            // 
            // WIPTracker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1084, 611);
            Controls.Add(resetbtn);
            Controls.Add(searchbtn);
            Controls.Add(WIPgridView);
            Controls.Add(label1);
            Controls.Add(searchtxt);
            Controls.Add(searchcmb);
            Controls.Add(HomePagefooter);
            Name = "WIPTracker";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)WIPgridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel HomePagefooter;
        private ComboBox searchcmb;
        private TextBox searchtxt;
        private Label label1;
        private DataGridView WIPgridView;
        private Button searchbtn;
        private Button resetbtn;
    }
}