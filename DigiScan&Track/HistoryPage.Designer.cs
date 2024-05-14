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
            components = new System.ComponentModel.Container();
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
            HistoryHelp = new ToolTip(components);
            historyHelppbox = new PictureBox();
            OuterBorderpnl.SuspendLayout();
            InnerBorderpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HistorygridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)historyHelppbox).BeginInit();
            SuspendLayout();
            // 
            // OuterBorderpnl
            // 
            OuterBorderpnl.Anchor = AnchorStyles.None;
            OuterBorderpnl.BackColor = Color.FromArgb(24, 30, 54);
            OuterBorderpnl.Controls.Add(InnerBorderpnl);
            OuterBorderpnl.Location = new Point(15, 113);
            OuterBorderpnl.Margin = new Padding(6);
            OuterBorderpnl.Name = "OuterBorderpnl";
            OuterBorderpnl.Size = new Size(1894, 1126);
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
            InnerBorderpnl.Location = new Point(7, 6);
            InnerBorderpnl.Margin = new Padding(6);
            InnerBorderpnl.Name = "InnerBorderpnl";
            InnerBorderpnl.Size = new Size(1881, 1114);
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
            resetbtn.Location = new Point(1562, 28);
            resetbtn.Margin = new Padding(6);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(193, 77);
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
            HistorygridView.Location = new Point(32, 128);
            HistorygridView.Margin = new Padding(6);
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
            HistorygridView.Size = new Size(1824, 951);
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
            searchbtn.Location = new Point(1371, 28);
            searchbtn.Margin = new Padding(6);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(193, 77);
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
            historycmb.Location = new Point(271, 34);
            historycmb.Margin = new Padding(6);
            historycmb.Name = "historycmb";
            historycmb.Size = new Size(299, 51);
            historycmb.TabIndex = 13;
            // 
            // searchBylbl
            // 
            searchBylbl.AutoSize = true;
            searchBylbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            searchBylbl.ForeColor = Color.Turquoise;
            searchBylbl.Location = new Point(52, 36);
            searchBylbl.Margin = new Padding(6, 0, 6, 0);
            searchBylbl.Name = "searchBylbl";
            searchBylbl.Size = new Size(194, 51);
            searchBylbl.TabIndex = 5;
            searchBylbl.Text = "Search by";
            // 
            // searchtxt
            // 
            searchtxt.BackColor = Color.FromArgb(46, 51, 73);
            searchtxt.BorderStyle = BorderStyle.FixedSingle;
            searchtxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchtxt.ForeColor = Color.White;
            searchtxt.Location = new Point(609, 34);
            searchtxt.Margin = new Padding(6);
            searchtxt.Name = "searchtxt";
            searchtxt.Size = new Size(728, 50);
            searchtxt.TabIndex = 4;
            searchtxt.KeyPress += searchtxt_KeyPress;
            // 
            // Titlelbl
            // 
            Titlelbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Titlelbl.BackColor = Color.Transparent;
            Titlelbl.Font = new Font("Taurus Mono Outline", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            Titlelbl.ForeColor = Color.White;
            Titlelbl.Location = new Point(45, 9);
            Titlelbl.Margin = new Padding(6, 0, 6, 0);
            Titlelbl.Name = "Titlelbl";
            Titlelbl.Size = new Size(1832, 100);
            Titlelbl.TabIndex = 15;
            Titlelbl.Text = "DigiScan && Track - Action History";
            Titlelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HistoryHelp
            // 
            HistoryHelp.ToolTipIcon = ToolTipIcon.Info;
            HistoryHelp.ToolTipTitle = "Action History Help";
            // 
            // historyHelppbox
            // 
            historyHelppbox.BackColor = Color.FromArgb(46, 51, 73);
            historyHelppbox.Cursor = Cursors.Help;
            historyHelppbox.Image = (Image)resources.GetObject("historyHelppbox.Image");
            historyHelppbox.Location = new Point(1863, 26);
            historyHelppbox.Margin = new Padding(6);
            historyHelppbox.Name = "historyHelppbox";
            historyHelppbox.Size = new Size(46, 53);
            historyHelppbox.SizeMode = PictureBoxSizeMode.Zoom;
            historyHelppbox.TabIndex = 21;
            historyHelppbox.TabStop = false;
            HistoryHelp.SetToolTip(historyHelppbox, resources.GetString("historyHelppbox.ToolTip"));
            // 
            // HistoryPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1926, 1227);
            Controls.Add(historyHelppbox);
            Controls.Add(OuterBorderpnl);
            Controls.Add(Titlelbl);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "HistoryPage";
            Text = "HistoryPage";
            OuterBorderpnl.ResumeLayout(false);
            InnerBorderpnl.ResumeLayout(false);
            InnerBorderpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HistorygridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)historyHelppbox).EndInit();
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
        private ToolTip HistoryHelp;
        private PictureBox historyHelppbox;
    }
}