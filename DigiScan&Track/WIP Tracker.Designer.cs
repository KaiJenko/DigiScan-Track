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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIPTracker));
            Titlelbl = new Label();
            OuterBorderpnl = new Panel();
            InnerBorderpnl = new Panel();
            WIPgridView = new DataGridView();
            resetbtn = new Button();
            searchbtn = new Button();
            searchcmb = new ComboBox();
            workstationlbl = new Label();
            departmentlbl = new Label();
            searchFieldpnl = new Panel();
            searchBylbl = new Label();
            searchtxt = new TextBox();
            addFieldbtn = new Button();
            bottomLeftBorderbtn = new Button();
            WIPHelp = new ToolTip(components);
            wipHelppbox = new PictureBox();
            OuterBorderpnl.SuspendLayout();
            InnerBorderpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WIPgridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wipHelppbox).BeginInit();
            SuspendLayout();
            // 
            // Titlelbl
            // 
            Titlelbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Titlelbl.BackColor = Color.Transparent;
            Titlelbl.Font = new Font("Taurus Mono Outline", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            Titlelbl.ForeColor = Color.White;
            Titlelbl.Location = new Point(82, 10);
            Titlelbl.Name = "Titlelbl";
            Titlelbl.Size = new Size(888, 47);
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
            InnerBorderpnl.Controls.Add(WIPgridView);
            InnerBorderpnl.Controls.Add(resetbtn);
            InnerBorderpnl.Controls.Add(searchbtn);
            InnerBorderpnl.Controls.Add(searchcmb);
            InnerBorderpnl.Controls.Add(workstationlbl);
            InnerBorderpnl.Controls.Add(departmentlbl);
            InnerBorderpnl.Controls.Add(searchFieldpnl);
            InnerBorderpnl.Controls.Add(searchBylbl);
            InnerBorderpnl.Controls.Add(searchtxt);
            InnerBorderpnl.Controls.Add(addFieldbtn);
            InnerBorderpnl.Controls.Add(bottomLeftBorderbtn);
            InnerBorderpnl.Location = new Point(4, 3);
            InnerBorderpnl.Name = "InnerBorderpnl";
            InnerBorderpnl.Size = new Size(1013, 522);
            InnerBorderpnl.TabIndex = 11;
            // 
            // WIPgridView
            // 
            WIPgridView.AllowUserToAddRows = false;
            WIPgridView.AllowUserToDeleteRows = false;
            WIPgridView.AllowUserToResizeColumns = false;
            WIPgridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(113, 96, 232);
            WIPgridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            WIPgridView.BackgroundColor = Color.FromArgb(113, 96, 232);
            WIPgridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            WIPgridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            WIPgridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Turquoise;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            WIPgridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            WIPgridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            WIPgridView.DefaultCellStyle = dataGridViewCellStyle3;
            WIPgridView.EnableHeadersVisualStyles = false;
            WIPgridView.GridColor = Color.Silver;
            WIPgridView.Location = new Point(17, 96);
            WIPgridView.MultiSelect = false;
            WIPgridView.Name = "WIPgridView";
            WIPgridView.ReadOnly = true;
            WIPgridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            WIPgridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            WIPgridView.RowHeadersVisible = false;
            WIPgridView.RowHeadersWidth = 62;
            WIPgridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            WIPgridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            WIPgridView.RowTemplate.Height = 40;
            WIPgridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            WIPgridView.Size = new Size(982, 410);
            WIPgridView.TabIndex = 6;
            // 
            // resetbtn
            // 
            resetbtn.BackColor = Color.Transparent;
            resetbtn.BackgroundImage = (Image)resources.GetObject("resetbtn.BackgroundImage");
            resetbtn.BackgroundImageLayout = ImageLayout.Stretch;
            resetbtn.Cursor = Cursors.Hand;
            resetbtn.FlatAppearance.BorderSize = 0;
            resetbtn.FlatStyle = FlatStyle.Flat;
            resetbtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            resetbtn.ForeColor = Color.White;
            resetbtn.Location = new Point(747, 44);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(104, 36);
            resetbtn.TabIndex = 32;
            resetbtn.Text = "Reset";
            resetbtn.UseVisualStyleBackColor = false;
            resetbtn.Click += Resetbtn_Click;
            // 
            // searchbtn
            // 
            searchbtn.BackColor = Color.Transparent;
            searchbtn.BackgroundImage = (Image)resources.GetObject("searchbtn.BackgroundImage");
            searchbtn.BackgroundImageLayout = ImageLayout.Stretch;
            searchbtn.Cursor = Cursors.Hand;
            searchbtn.FlatAppearance.BorderSize = 0;
            searchbtn.FlatStyle = FlatStyle.Flat;
            searchbtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            searchbtn.ForeColor = Color.White;
            searchbtn.Location = new Point(747, 7);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(104, 36);
            searchbtn.TabIndex = 31;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = false;
            searchbtn.Click += Searchbtn_Click;
            // 
            // searchcmb
            // 
            searchcmb.BackColor = Color.FromArgb(46, 51, 73);
            searchcmb.Cursor = Cursors.Hand;
            searchcmb.DrawMode = DrawMode.OwnerDrawFixed;
            searchcmb.DropDownStyle = ComboBoxStyle.DropDownList;
            searchcmb.FlatStyle = FlatStyle.Flat;
            searchcmb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchcmb.ForeColor = Color.White;
            searchcmb.FormattingEnabled = true;
            searchcmb.Items.AddRange(new object[] { "Part Number", "Serial Number", "Batch Number", "Department", "Workstation", "In Storage" });
            searchcmb.Location = new Point(146, 10);
            searchcmb.Name = "searchcmb";
            searchcmb.Size = new Size(163, 30);
            searchcmb.TabIndex = 13;
            // 
            // workstationlbl
            // 
            workstationlbl.AutoSize = true;
            workstationlbl.BackColor = Color.Transparent;
            workstationlbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            workstationlbl.ForeColor = Color.FromArgb(0, 126, 249);
            workstationlbl.Location = new Point(872, 25);
            workstationlbl.Name = "workstationlbl";
            workstationlbl.Size = new Size(29, 15);
            workstationlbl.TabIndex = 12;
            workstationlbl.Text = "WS:";
            // 
            // departmentlbl
            // 
            departmentlbl.AutoSize = true;
            departmentlbl.BackColor = Color.Transparent;
            departmentlbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            departmentlbl.ForeColor = Color.FromArgb(0, 126, 249);
            departmentlbl.Location = new Point(875, 11);
            departmentlbl.Name = "departmentlbl";
            departmentlbl.Size = new Size(26, 15);
            departmentlbl.TabIndex = 11;
            departmentlbl.Text = "DP:";
            // 
            // searchFieldpnl
            // 
            searchFieldpnl.Location = new Point(30, 48);
            searchFieldpnl.Name = "searchFieldpnl";
            searchFieldpnl.Size = new Size(712, 32);
            searchFieldpnl.TabIndex = 10;
            // 
            // searchBylbl
            // 
            searchBylbl.AutoSize = true;
            searchBylbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            searchBylbl.ForeColor = Color.Turquoise;
            searchBylbl.Location = new Point(30, 12);
            searchBylbl.Name = "searchBylbl";
            searchBylbl.Size = new Size(98, 25);
            searchBylbl.TabIndex = 5;
            searchBylbl.Text = "Search by";
            // 
            // searchtxt
            // 
            searchtxt.BackColor = Color.FromArgb(46, 51, 73);
            searchtxt.BorderStyle = BorderStyle.FixedSingle;
            searchtxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchtxt.ForeColor = Color.White;
            searchtxt.Location = new Point(338, 11);
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
            addFieldbtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            addFieldbtn.ForeColor = Color.White;
            addFieldbtn.Location = new Point(850, 44);
            addFieldbtn.Name = "addFieldbtn";
            addFieldbtn.Size = new Size(145, 36);
            addFieldbtn.TabIndex = 33;
            addFieldbtn.Text = "Add Search Field";
            addFieldbtn.UseVisualStyleBackColor = false;
            addFieldbtn.Click += AddFieldbtn_Click;
            // 
            // bottomLeftBorderbtn
            // 
            bottomLeftBorderbtn.BackColor = Color.Transparent;
            bottomLeftBorderbtn.BackgroundImage = (Image)resources.GetObject("bottomLeftBorderbtn.BackgroundImage");
            bottomLeftBorderbtn.BackgroundImageLayout = ImageLayout.Stretch;
            bottomLeftBorderbtn.FlatAppearance.BorderSize = 0;
            bottomLeftBorderbtn.FlatStyle = FlatStyle.Flat;
            bottomLeftBorderbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bottomLeftBorderbtn.ForeColor = Color.White;
            bottomLeftBorderbtn.Location = new Point(849, 7);
            bottomLeftBorderbtn.Name = "bottomLeftBorderbtn";
            bottomLeftBorderbtn.Size = new Size(154, 36);
            bottomLeftBorderbtn.TabIndex = 34;
            bottomLeftBorderbtn.UseVisualStyleBackColor = false;
            // 
            // WIPHelp
            // 
            WIPHelp.ToolTipIcon = ToolTipIcon.Info;
            WIPHelp.ToolTipTitle = "Work in Progress Help";
            // 
            // wipHelppbox
            // 
            wipHelppbox.BackColor = Color.FromArgb(46, 51, 73);
            wipHelppbox.Cursor = Cursors.Help;
            wipHelppbox.Image = (Image)resources.GetObject("wipHelppbox.Image");
            wipHelppbox.Location = new Point(1015, 10);
            wipHelppbox.Name = "wipHelppbox";
            wipHelppbox.Size = new Size(25, 25);
            wipHelppbox.SizeMode = PictureBoxSizeMode.Zoom;
            wipHelppbox.TabIndex = 21;
            wipHelppbox.TabStop = false;
            WIPHelp.SetToolTip(wipHelppbox, resources.GetString("wipHelppbox.ToolTip"));
            // 
            // WIPTracker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1052, 609);
            Controls.Add(wipHelppbox);
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
            ((System.ComponentModel.ISupportInitialize)wipHelppbox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label Titlelbl;
        private Panel OuterBorderpnl;
        private Panel InnerBorderpnl;
        private Button addFieldbtn;
        private Button resetbtn;
        private Label searchBylbl;
        private Button searchbtn;
        private TextBox searchtxt;
        private Panel searchFieldpnl;
        private Label workstationlbl;
        private Label departmentlbl;
        private ComboBox searchcmb;
        private Button bottomLeftBorderbtn;
        private DataGridView WIPgridView;
        private ToolTip WIPHelp;
        private PictureBox wipHelppbox;
    }
}