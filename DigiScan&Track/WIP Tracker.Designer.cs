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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            Titlelbl = new Label();
            OuterBorderpnl = new Panel();
            InnerBorderpnl = new Panel();
            searchFieldpnl = new Panel();
            addFieldbtn = new Button();
            WIPgridView = new DataGridView();
            resetbtn = new Button();
            label1 = new Label();
            searchbtn = new Button();
            searchcmb = new ComboBox();
            searchtxt = new TextBox();
            OuterBorderpnl.SuspendLayout();
            InnerBorderpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WIPgridView).BeginInit();
            SuspendLayout();
            // 
            // Titlelbl
            // 
            Titlelbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Titlelbl.AutoSize = true;
            Titlelbl.BackColor = Color.Transparent;
            Titlelbl.Font = new Font("Taurus Mono Outline", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            Titlelbl.ForeColor = Color.White;
            Titlelbl.Location = new Point(140, 10);
            Titlelbl.Name = "Titlelbl";
            Titlelbl.Size = new Size(830, 47);
            Titlelbl.TabIndex = 13;
            Titlelbl.Text = "DigiScan && Track - WIP Tracker";
            Titlelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OuterBorderpnl
            // 
            OuterBorderpnl.Anchor = AnchorStyles.None;
            OuterBorderpnl.BackColor = Color.FromArgb(24, 30, 54);
            OuterBorderpnl.Controls.Add(InnerBorderpnl);
            OuterBorderpnl.Location = new Point(16, 69);
            OuterBorderpnl.Name = "OuterBorderpnl";
            OuterBorderpnl.Size = new Size(1020, 528);
            OuterBorderpnl.TabIndex = 14;
            // 
            // InnerBorderpnl
            // 
            InnerBorderpnl.Anchor = AnchorStyles.None;
            InnerBorderpnl.BackColor = Color.FromArgb(46, 51, 73);
            InnerBorderpnl.Controls.Add(searchFieldpnl);
            InnerBorderpnl.Controls.Add(addFieldbtn);
            InnerBorderpnl.Controls.Add(WIPgridView);
            InnerBorderpnl.Controls.Add(resetbtn);
            InnerBorderpnl.Controls.Add(label1);
            InnerBorderpnl.Controls.Add(searchbtn);
            InnerBorderpnl.Controls.Add(searchcmb);
            InnerBorderpnl.Controls.Add(searchtxt);
            InnerBorderpnl.Location = new Point(4, 3);
            InnerBorderpnl.Name = "InnerBorderpnl";
            InnerBorderpnl.Size = new Size(1013, 522);
            InnerBorderpnl.TabIndex = 11;
            // 
            // searchFieldpnl
            // 
            searchFieldpnl.Location = new Point(40, 50);
            searchFieldpnl.Name = "searchFieldpnl";
            searchFieldpnl.Size = new Size(679, 28);
            searchFieldpnl.TabIndex = 10;
            // 
            // addFieldbtn
            // 
            addFieldbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            addFieldbtn.Location = new Point(758, 23);
            addFieldbtn.Name = "addFieldbtn";
            addFieldbtn.Size = new Size(108, 43);
            addFieldbtn.TabIndex = 9;
            addFieldbtn.Text = "Add Another Search Field";
            addFieldbtn.UseVisualStyleBackColor = true;
            addFieldbtn.Click += addFieldbtn_Click;
            // 
            // WIPgridView
            // 
            WIPgridView.BackgroundColor = Color.FromArgb(45, 66, 91);
            WIPgridView.BorderStyle = BorderStyle.None;
            WIPgridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.White;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            WIPgridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            WIPgridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Window;
            dataGridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle14.SelectionForeColor = Color.White;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            WIPgridView.DefaultCellStyle = dataGridViewCellStyle14;
            WIPgridView.GridColor = Color.White;
            WIPgridView.Location = new Point(13, 84);
            WIPgridView.Name = "WIPgridView";
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            WIPgridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            WIPgridView.RowHeadersVisible = false;
            WIPgridView.RowHeadersWidth = 62;
            dataGridViewCellStyle16.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle16.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = Color.White;
            dataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = Color.White;
            WIPgridView.RowsDefaultCellStyle = dataGridViewCellStyle16;
            WIPgridView.RowTemplate.Height = 25;
            WIPgridView.Size = new Size(989, 425);
            WIPgridView.TabIndex = 6;
            // 
            // resetbtn
            // 
            resetbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            resetbtn.Location = new Point(895, 50);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(101, 28);
            resetbtn.TabIndex = 8;
            resetbtn.Text = "Reset Table";
            resetbtn.UseVisualStyleBackColor = true;
            resetbtn.Click += resetbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(27, 17);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 5;
            label1.Text = "Search by";
            // 
            // searchbtn
            // 
            searchbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            searchbtn.Location = new Point(911, 10);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(69, 28);
            searchbtn.TabIndex = 7;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_Click;
            // 
            // searchcmb
            // 
            searchcmb.BackColor = Color.FromArgb(46, 51, 73);
            searchcmb.FlatStyle = FlatStyle.Flat;
            searchcmb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchcmb.ForeColor = Color.White;
            searchcmb.FormattingEnabled = true;
            searchcmb.Items.AddRange(new object[] { "Part Number", "Serial Number", "Batch Number", "Department", "Workstation", "In Storage" });
            searchcmb.Location = new Point(120, 15);
            searchcmb.Name = "searchcmb";
            searchcmb.Size = new Size(149, 29);
            searchcmb.TabIndex = 3;
            searchcmb.Text = "Operations";
            // 
            // searchtxt
            // 
            searchtxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchtxt.Location = new Point(281, 15);
            searchtxt.Name = "searchtxt";
            searchtxt.Size = new Size(393, 29);
            searchtxt.TabIndex = 4;
            // 
            // WIPTracker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1052, 609);
            Controls.Add(OuterBorderpnl);
            Controls.Add(Titlelbl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WIPTracker";
            Text = "Form1";
            Load += Form1_Load;
            OuterBorderpnl.ResumeLayout(false);
            InnerBorderpnl.ResumeLayout(false);
            InnerBorderpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)WIPgridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Titlelbl;
        private Panel OuterBorderpnl;
        private Panel InnerBorderpnl;
        private Button addFieldbtn;
        private DataGridView WIPgridView;
        private Button resetbtn;
        private Label label1;
        private Button searchbtn;
        private ComboBox searchcmb;
        private TextBox searchtxt;
        private Panel searchFieldpnl;
    }
}