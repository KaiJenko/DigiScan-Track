namespace DigiScan_Track
{
    partial class DisplayBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayBoard));
            agedlbl = new Label();
            Titlelbl = new Label();
            BodyLayoutpnl = new Panel();
            noDatalbl = new Label();
            searchpbox = new PictureBox();
            customInputnud = new NumericUpDown();
            recentScannedGridView = new DataGridView();
            radioButtonpnl = new Panel();
            customrbtn = new RadioButton();
            tenrbtn = new RadioButton();
            fiverbtn = new RadioButton();
            tworbtn = new RadioButton();
            Borderpnl = new Panel();
            displayHelppbox = new PictureBox();
            DisplayHelp = new ToolTip(components);
            BodyLayoutpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchpbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customInputnud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recentScannedGridView).BeginInit();
            radioButtonpnl.SuspendLayout();
            Borderpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)displayHelppbox).BeginInit();
            SuspendLayout();
            // 
            // agedlbl
            // 
            agedlbl.AutoSize = true;
            agedlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            agedlbl.ForeColor = Color.White;
            agedlbl.Location = new Point(94, 52);
            agedlbl.Margin = new Padding(6, 0, 6, 0);
            agedlbl.Name = "agedlbl";
            agedlbl.Size = new Size(782, 45);
            agedlbl.TabIndex = 9;
            agedlbl.Text = "This Board Displays Everything Scanned in the last:";
            // 
            // Titlelbl
            // 
            Titlelbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Titlelbl.BackColor = Color.Transparent;
            Titlelbl.Font = new Font("Taurus Mono Outline", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            Titlelbl.ForeColor = Color.White;
            Titlelbl.Location = new Point(15, 21);
            Titlelbl.Margin = new Padding(6, 0, 6, 0);
            Titlelbl.Name = "Titlelbl";
            Titlelbl.Size = new Size(1803, 100);
            Titlelbl.TabIndex = 12;
            Titlelbl.Text = "DigiScan && Track - Display Board";
            Titlelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BodyLayoutpnl
            // 
            BodyLayoutpnl.BackColor = Color.FromArgb(46, 51, 73);
            BodyLayoutpnl.Controls.Add(noDatalbl);
            BodyLayoutpnl.Controls.Add(searchpbox);
            BodyLayoutpnl.Controls.Add(customInputnud);
            BodyLayoutpnl.Controls.Add(recentScannedGridView);
            BodyLayoutpnl.Controls.Add(radioButtonpnl);
            BodyLayoutpnl.Controls.Add(agedlbl);
            BodyLayoutpnl.Location = new Point(7, 6);
            BodyLayoutpnl.Margin = new Padding(6);
            BodyLayoutpnl.Name = "BodyLayoutpnl";
            BodyLayoutpnl.Size = new Size(1881, 1114);
            BodyLayoutpnl.TabIndex = 11;
            // 
            // noDatalbl
            // 
            noDatalbl.AutoSize = true;
            noDatalbl.BackColor = Color.FromArgb(113, 96, 232);
            noDatalbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            noDatalbl.ForeColor = Color.Coral;
            noDatalbl.Location = new Point(650, 512);
            noDatalbl.Margin = new Padding(6, 0, 6, 0);
            noDatalbl.Name = "noDatalbl";
            noDatalbl.Size = new Size(0, 51);
            noDatalbl.TabIndex = 23;
            // 
            // searchpbox
            // 
            searchpbox.BackgroundImage = Properties.Resources.MagnifyingGlass;
            searchpbox.BackgroundImageLayout = ImageLayout.Stretch;
            searchpbox.Cursor = Cursors.Hand;
            searchpbox.Location = new Point(1790, 47);
            searchpbox.Margin = new Padding(6);
            searchpbox.Name = "searchpbox";
            searchpbox.Size = new Size(46, 49);
            searchpbox.TabIndex = 22;
            searchpbox.TabStop = false;
            searchpbox.Visible = false;
            searchpbox.Click += Searchpbox_Click;
            // 
            // customInputnud
            // 
            customInputnud.BackColor = Color.FromArgb(46, 51, 73);
            customInputnud.BorderStyle = BorderStyle.FixedSingle;
            customInputnud.Cursor = Cursors.Hand;
            customInputnud.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customInputnud.ForeColor = Color.FromArgb(0, 126, 249);
            customInputnud.Location = new Point(1681, 47);
            customInputnud.Margin = new Padding(6);
            customInputnud.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            customInputnud.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            customInputnud.Name = "customInputnud";
            customInputnud.Size = new Size(98, 50);
            customInputnud.TabIndex = 4;
            customInputnud.Visible = false;
            // 
            // recentScannedGridView
            // 
            recentScannedGridView.AllowUserToAddRows = false;
            recentScannedGridView.AllowUserToDeleteRows = false;
            recentScannedGridView.AllowUserToResizeColumns = false;
            recentScannedGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(113, 96, 232);
            recentScannedGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            recentScannedGridView.BackgroundColor = Color.FromArgb(113, 96, 232);
            recentScannedGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            recentScannedGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            recentScannedGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Turquoise;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            recentScannedGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            recentScannedGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            recentScannedGridView.DefaultCellStyle = dataGridViewCellStyle3;
            recentScannedGridView.EnableHeadersVisualStyles = false;
            recentScannedGridView.GridColor = Color.Silver;
            recentScannedGridView.Location = new Point(30, 151);
            recentScannedGridView.Margin = new Padding(6);
            recentScannedGridView.MultiSelect = false;
            recentScannedGridView.Name = "recentScannedGridView";
            recentScannedGridView.ReadOnly = true;
            recentScannedGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            recentScannedGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            recentScannedGridView.RowHeadersVisible = false;
            recentScannedGridView.RowHeadersWidth = 62;
            recentScannedGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            recentScannedGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            recentScannedGridView.RowTemplate.Height = 50;
            recentScannedGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            recentScannedGridView.Size = new Size(1824, 875);
            recentScannedGridView.TabIndex = 13;
            // 
            // radioButtonpnl
            // 
            radioButtonpnl.Controls.Add(customrbtn);
            radioButtonpnl.Controls.Add(tenrbtn);
            radioButtonpnl.Controls.Add(fiverbtn);
            radioButtonpnl.Controls.Add(tworbtn);
            radioButtonpnl.Location = new Point(888, 16);
            radioButtonpnl.Margin = new Padding(6);
            radioButtonpnl.Name = "radioButtonpnl";
            radioButtonpnl.Size = new Size(745, 109);
            radioButtonpnl.TabIndex = 12;
            // 
            // customrbtn
            // 
            customrbtn.AutoSize = true;
            customrbtn.Cursor = Cursors.Hand;
            customrbtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            customrbtn.ForeColor = Color.FromArgb(0, 126, 249);
            customrbtn.Location = new Point(596, 34);
            customrbtn.Margin = new Padding(6);
            customrbtn.Name = "customrbtn";
            customrbtn.Size = new Size(155, 45);
            customrbtn.TabIndex = 3;
            customrbtn.Tag = "custom";
            customrbtn.Text = "Custom";
            customrbtn.UseVisualStyleBackColor = true;
            customrbtn.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // tenrbtn
            // 
            tenrbtn.AutoSize = true;
            tenrbtn.Cursor = Cursors.Hand;
            tenrbtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            tenrbtn.ForeColor = Color.FromArgb(0, 126, 249);
            tenrbtn.Location = new Point(399, 34);
            tenrbtn.Margin = new Padding(6);
            tenrbtn.Name = "tenrbtn";
            tenrbtn.Size = new Size(198, 45);
            tenrbtn.TabIndex = 2;
            tenrbtn.Tag = "10";
            tenrbtn.Text = "10 Minutes";
            tenrbtn.UseVisualStyleBackColor = true;
            tenrbtn.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // fiverbtn
            // 
            fiverbtn.AutoSize = true;
            fiverbtn.Cursor = Cursors.Hand;
            fiverbtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            fiverbtn.ForeColor = Color.FromArgb(0, 126, 249);
            fiverbtn.Location = new Point(214, 34);
            fiverbtn.Margin = new Padding(6);
            fiverbtn.Name = "fiverbtn";
            fiverbtn.Size = new Size(186, 45);
            fiverbtn.TabIndex = 1;
            fiverbtn.Tag = "5";
            fiverbtn.Text = "5 Minutes";
            fiverbtn.UseVisualStyleBackColor = true;
            fiverbtn.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // tworbtn
            // 
            tworbtn.AutoSize = true;
            tworbtn.Cursor = Cursors.Hand;
            tworbtn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            tworbtn.ForeColor = Color.FromArgb(0, 126, 249);
            tworbtn.Location = new Point(6, 34);
            tworbtn.Margin = new Padding(6);
            tworbtn.Name = "tworbtn";
            tworbtn.Size = new Size(194, 45);
            tworbtn.TabIndex = 0;
            tworbtn.Tag = "2";
            tworbtn.Text = "2 Minutes ";
            tworbtn.UseVisualStyleBackColor = true;
            tworbtn.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // Borderpnl
            // 
            Borderpnl.Anchor = AnchorStyles.None;
            Borderpnl.BackColor = Color.FromArgb(24, 30, 54);
            Borderpnl.Controls.Add(BodyLayoutpnl);
            Borderpnl.Location = new Point(30, 147);
            Borderpnl.Margin = new Padding(6);
            Borderpnl.Name = "Borderpnl";
            Borderpnl.Size = new Size(1894, 1126);
            Borderpnl.TabIndex = 14;
            // 
            // displayHelppbox
            // 
            displayHelppbox.BackColor = Color.FromArgb(46, 51, 73);
            displayHelppbox.Cursor = Cursors.Help;
            displayHelppbox.Image = (Image)resources.GetObject("displayHelppbox.Image");
            displayHelppbox.Location = new Point(1885, 21);
            displayHelppbox.Margin = new Padding(6);
            displayHelppbox.Name = "displayHelppbox";
            displayHelppbox.Size = new Size(46, 53);
            displayHelppbox.SizeMode = PictureBoxSizeMode.Zoom;
            displayHelppbox.TabIndex = 21;
            displayHelppbox.TabStop = false;
            DisplayHelp.SetToolTip(displayHelppbox, "Select a time period to view the most recently scanned\r\nparts within the goods in area. Used by operators in the goods \r\nin area to ensure all parts enter the site and get scanned.\r\n");
            // 
            // DisplayHelp
            // 
            DisplayHelp.ToolTipIcon = ToolTipIcon.Info;
            DisplayHelp.ToolTipTitle = "Display Board Help";
            // 
            // DisplayBoard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1954, 1299);
            Controls.Add(displayHelppbox);
            Controls.Add(Titlelbl);
            Controls.Add(Borderpnl);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "DisplayBoard";
            Text = "Form1";
            Load += Form1_Load;
            BodyLayoutpnl.ResumeLayout(false);
            BodyLayoutpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchpbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)customInputnud).EndInit();
            ((System.ComponentModel.ISupportInitialize)recentScannedGridView).EndInit();
            radioButtonpnl.ResumeLayout(false);
            radioButtonpnl.PerformLayout();
            Borderpnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)displayHelppbox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label agedlbl;
        private Label Titlelbl;
        private Panel BodyLayoutpnl;
        private Panel Borderpnl;
        private Panel radioButtonpnl;
        private RadioButton fiverbtn;
        private RadioButton tworbtn;
        private RadioButton customrbtn;
        private RadioButton tenrbtn;
        private DataGridView recentScannedGridView;
        private NumericUpDown customInputnud;
        private PictureBox searchpbox;
        private Label noDatalbl;
        private PictureBox displayHelppbox;
        private ToolTip DisplayHelp;
    }
}