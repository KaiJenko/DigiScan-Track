namespace DigiScan_Track
{
    partial class HistoryPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryPage));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            OuterBorderpnl = new Panel();
            InnerBorderpnl = new Panel();
            resetbtn = new Button();
            HistorygridView = new DataGridView();
            searchbtn = new Button();
            historycmb = new ComboBox();
            searchBylbl = new Label();
            searchtxt = new TextBox();
            Titlelbl = new Label();
            OuterBorderpnl.SuspendLayout();
            InnerBorderpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HistorygridView).BeginInit();
            SuspendLayout();
            // 
            // OuterBorderpnl
            // 
            OuterBorderpnl.Anchor = AnchorStyles.None;
            OuterBorderpnl.BackColor = Color.FromArgb(24, 30, 54);
            OuterBorderpnl.Controls.Add(InnerBorderpnl);
            OuterBorderpnl.Location = new Point(8, 53);
            OuterBorderpnl.Name = "OuterBorderpnl";
            OuterBorderpnl.Size = new Size(1020, 528);
            OuterBorderpnl.TabIndex = 16;
            // 
            // InnerBorderpnl
            // 
            InnerBorderpnl.Anchor = AnchorStyles.None;
            InnerBorderpnl.BackColor = Color.FromArgb(46, 51, 73);
            InnerBorderpnl.Controls.Add(resetbtn);
            InnerBorderpnl.Controls.Add(HistorygridView);
            InnerBorderpnl.Controls.Add(searchbtn);
            InnerBorderpnl.Controls.Add(historycmb);
            InnerBorderpnl.Controls.Add(searchBylbl);
            InnerBorderpnl.Controls.Add(searchtxt);
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
            resetbtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            resetbtn.ForeColor = Color.White;
            resetbtn.Location = new Point(841, 13);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(104, 36);
            resetbtn.TabIndex = 35;
            resetbtn.Text = "Reset";
            resetbtn.UseVisualStyleBackColor = false;
            resetbtn.Click += Resetbtn_Click;
            // 
            // HistorygridView
            // 
            HistorygridView.AllowUserToAddRows = false;
            HistorygridView.AllowUserToDeleteRows = false;
            HistorygridView.AllowUserToResizeColumns = false;
            HistorygridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(113, 96, 232);
            HistorygridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            HistorygridView.BackgroundColor = Color.FromArgb(113, 96, 232);
            HistorygridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            HistorygridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            HistorygridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Turquoise;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            HistorygridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            HistorygridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            HistorygridView.DefaultCellStyle = dataGridViewCellStyle3;
            HistorygridView.EnableHeadersVisualStyles = false;
            HistorygridView.GridColor = Color.Silver;
            HistorygridView.Location = new Point(17, 60);
            HistorygridView.MultiSelect = false;
            HistorygridView.Name = "HistorygridView";
            HistorygridView.ReadOnly = true;
            HistorygridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            HistorygridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            HistorygridView.RowHeadersVisible = false;
            HistorygridView.RowHeadersWidth = 62;
            HistorygridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            HistorygridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            HistorygridView.RowTemplate.Height = 45;
            HistorygridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            HistorygridView.Size = new Size(982, 446);
            HistorygridView.TabIndex = 6;
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
            searchbtn.Location = new Point(738, 13);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(104, 36);
            searchbtn.TabIndex = 31;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = false;
            searchbtn.Click += HistorySearchbtn_Click;
            // 
            // historycmb
            // 
            historycmb.BackColor = Color.FromArgb(46, 51, 73);
            historycmb.Cursor = Cursors.Hand;
            historycmb.DrawMode = DrawMode.OwnerDrawFixed;
            historycmb.DropDownStyle = ComboBoxStyle.DropDownList;
            historycmb.FlatStyle = FlatStyle.Flat;
            historycmb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            historycmb.ForeColor = Color.White;
            historycmb.FormattingEnabled = true;
            historycmb.Items.AddRange(new object[] { "Username", "Part/Serial" });
            historycmb.Location = new Point(146, 16);
            historycmb.Name = "historycmb";
            historycmb.Size = new Size(163, 30);
            historycmb.TabIndex = 13;
            // 
            // searchBylbl
            // 
            searchBylbl.AutoSize = true;
            searchBylbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            searchBylbl.ForeColor = Color.Turquoise;
            searchBylbl.Location = new Point(28, 17);
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
            searchtxt.Location = new Point(328, 16);
            searchtxt.Name = "searchtxt";
            searchtxt.Size = new Size(393, 29);
            searchtxt.TabIndex = 4;
            searchtxt.KeyPress += searchtxt_KeyPress;
            // 
            // Titlelbl
            // 
            Titlelbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Titlelbl.BackColor = Color.Transparent;
            Titlelbl.Font = new Font("Taurus Mono Outline", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            Titlelbl.ForeColor = Color.White;
            Titlelbl.Location = new Point(40, 4);
            Titlelbl.Name = "Titlelbl";
            Titlelbl.Size = new Size(971, 47);
            Titlelbl.TabIndex = 15;
            Titlelbl.Text = "DigiScan && Track - Action History";
            Titlelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HistoryPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1037, 575);
            Controls.Add(OuterBorderpnl);
            Controls.Add(Titlelbl);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "HistoryPage";
            Text = "HistoryPage";
            OuterBorderpnl.ResumeLayout(false);
            InnerBorderpnl.ResumeLayout(false);
            InnerBorderpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HistorygridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel OuterBorderpnl;
        private Panel InnerBorderpnl;
        private DataGridView HistorygridView;
        private Button searchbtn;
        private Label searchBylbl;
        private TextBox searchtxt;
        private Label Titlelbl;
        private ComboBox historycmb;
        private Button resetbtn;
    }
}