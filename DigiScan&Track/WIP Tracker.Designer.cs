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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIPTracker));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Titlelbl = new Label();
            OuterBorderpnl = new Panel();
            InnerBorderpnl = new Panel();
            resetbtn = new Button();
            searchbtn = new Button();
            searchcmb = new ComboBox();
            workstationlbl = new Label();
            departmentlbl = new Label();
            searchFieldpnl = new Panel();
            WIPgridView = new DataGridView();
            label1 = new Label();
            searchtxt = new TextBox();
            addFieldbtn = new Button();
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
            InnerBorderpnl.Controls.Add(resetbtn);
            InnerBorderpnl.Controls.Add(searchbtn);
            InnerBorderpnl.Controls.Add(searchcmb);
            InnerBorderpnl.Controls.Add(workstationlbl);
            InnerBorderpnl.Controls.Add(departmentlbl);
            InnerBorderpnl.Controls.Add(searchFieldpnl);
            InnerBorderpnl.Controls.Add(WIPgridView);
            InnerBorderpnl.Controls.Add(label1);
            InnerBorderpnl.Controls.Add(searchtxt);
            InnerBorderpnl.Controls.Add(addFieldbtn);
            InnerBorderpnl.Location = new Point(4, 3);
            InnerBorderpnl.Name = "InnerBorderpnl";
            InnerBorderpnl.Size = new Size(1013, 522);
            InnerBorderpnl.TabIndex = 11;
            // 
            // resetbtn
            // 
            resetbtn.BackColor = Color.Transparent;
            resetbtn.BackgroundImage = (Image)resources.GetObject("resetbtn.BackgroundImage");
            resetbtn.BackgroundImageLayout = ImageLayout.Stretch;
            resetbtn.Cursor = Cursors.Hand;
            resetbtn.FlatAppearance.BorderSize = 0;
            resetbtn.FlatStyle = FlatStyle.Flat;
            resetbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            resetbtn.ForeColor = Color.White;
            resetbtn.Location = new Point(683, 46);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(104, 36);
            resetbtn.TabIndex = 32;
            resetbtn.Text = "Reset";
            resetbtn.UseVisualStyleBackColor = false;
            // 
            // searchbtn
            // 
            searchbtn.BackColor = Color.Transparent;
            searchbtn.BackgroundImage = (Image)resources.GetObject("searchbtn.BackgroundImage");
            searchbtn.BackgroundImageLayout = ImageLayout.Stretch;
            searchbtn.Cursor = Cursors.Hand;
            searchbtn.FlatAppearance.BorderSize = 0;
            searchbtn.FlatStyle = FlatStyle.Flat;
            searchbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchbtn.ForeColor = Color.White;
            searchbtn.Location = new Point(683, 10);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(104, 36);
            searchbtn.TabIndex = 31;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = false;
            // 
            // searchcmb
            // 
            searchcmb.BackColor = Color.FromArgb(46, 51, 73);
            searchcmb.Cursor = Cursors.Hand;
            searchcmb.DrawMode = DrawMode.OwnerDrawFixed;
            searchcmb.DropDownStyle = ComboBoxStyle.DropDownList;
            searchcmb.FlatStyle = FlatStyle.Popup;
            searchcmb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchcmb.ForeColor = Color.White;
            searchcmb.FormattingEnabled = true;
            searchcmb.Items.AddRange(new object[] { "Part Number", "Serial Number", "Batch Number", "Department", "Workstation", "In Storage" });
            searchcmb.Location = new Point(119, 15);
            searchcmb.Name = "searchcmb";
            searchcmb.Size = new Size(147, 30);
            searchcmb.TabIndex = 13;
            // 
            // workstationlbl
            // 
            workstationlbl.AutoSize = true;
            workstationlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            workstationlbl.ForeColor = Color.FromArgb(0, 126, 249);
            workstationlbl.Location = new Point(827, 26);
            workstationlbl.Name = "workstationlbl";
            workstationlbl.Size = new Size(39, 21);
            workstationlbl.TabIndex = 12;
            workstationlbl.Text = "WS:";
            // 
            // departmentlbl
            // 
            departmentlbl.AutoSize = true;
            departmentlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            departmentlbl.ForeColor = Color.FromArgb(0, 126, 249);
            departmentlbl.Location = new Point(829, 4);
            departmentlbl.Name = "departmentlbl";
            departmentlbl.Size = new Size(36, 21);
            departmentlbl.TabIndex = 11;
            departmentlbl.Text = "DP:";
            // 
            // searchFieldpnl
            // 
            searchFieldpnl.Location = new Point(36, 50);
            searchFieldpnl.Name = "searchFieldpnl";
            searchFieldpnl.Size = new Size(634, 28);
            searchFieldpnl.TabIndex = 10;
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
            WIPgridView.Location = new Point(14, 84);
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
            WIPgridView.Size = new Size(989, 425);
            WIPgridView.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(14, 18);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 5;
            label1.Text = "Search by";
            // 
            // searchtxt
            // 
            searchtxt.BackColor = Color.FromArgb(46, 51, 73);
            searchtxt.BorderStyle = BorderStyle.FixedSingle;
            searchtxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchtxt.ForeColor = Color.White;
            searchtxt.Location = new Point(281, 15);
            searchtxt.Name = "searchtxt";
            searchtxt.Size = new Size(393, 29);
            searchtxt.TabIndex = 4;
            // 
            // addFieldbtn
            // 
            addFieldbtn.BackColor = Color.Transparent;
            addFieldbtn.BackgroundImage = (Image)resources.GetObject("addFieldbtn.BackgroundImage");
            addFieldbtn.BackgroundImageLayout = ImageLayout.Stretch;
            addFieldbtn.Cursor = Cursors.Hand;
            addFieldbtn.FlatAppearance.BorderSize = 0;
            addFieldbtn.FlatStyle = FlatStyle.Flat;
            addFieldbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addFieldbtn.ForeColor = Color.White;
            addFieldbtn.Location = new Point(785, 46);
            addFieldbtn.Name = "addFieldbtn";
            addFieldbtn.Size = new Size(145, 36);
            addFieldbtn.TabIndex = 33;
            addFieldbtn.Text = "Add Search Field";
            addFieldbtn.UseVisualStyleBackColor = false;
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
        private TextBox searchtxt;
        private Panel searchFieldpnl;
        private Label workstationlbl;
        private Label departmentlbl;
        private ComboBox searchcmb;
        private Button submitbtn;
    }
}