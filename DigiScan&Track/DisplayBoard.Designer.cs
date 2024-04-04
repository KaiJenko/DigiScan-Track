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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
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
            BodyLayoutpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchpbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customInputnud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recentScannedGridView).BeginInit();
            radioButtonpnl.SuspendLayout();
            Borderpnl.SuspendLayout();
            SuspendLayout();
            // 
            // agedlbl
            // 
            agedlbl.AutoSize = true;
            agedlbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            agedlbl.ForeColor = Color.White;
            agedlbl.Location = new Point(6, 34);
            agedlbl.Margin = new Padding(4, 0, 4, 0);
            agedlbl.Name = "agedlbl";
            agedlbl.Size = new Size(686, 38);
            agedlbl.TabIndex = 9;
            agedlbl.Text = "This Board Displays Everything Scanned in the last:";
            // 
            // Titlelbl
            // 
            Titlelbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Titlelbl.BackColor = Color.Transparent;
            Titlelbl.Font = new Font("Taurus Mono Outline", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            Titlelbl.ForeColor = Color.White;
            Titlelbl.Location = new Point(86, 17);
            Titlelbl.Margin = new Padding(4, 0, 4, 0);
            Titlelbl.Name = "Titlelbl";
            Titlelbl.Size = new Size(1313, 78);
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
            BodyLayoutpnl.Location = new Point(6, 5);
            BodyLayoutpnl.Margin = new Padding(4, 5, 4, 5);
            BodyLayoutpnl.Name = "BodyLayoutpnl";
            BodyLayoutpnl.Size = new Size(1447, 870);
            BodyLayoutpnl.TabIndex = 11;
            // 
            // noDatalbl
            // 
            noDatalbl.AutoSize = true;
            noDatalbl.BackColor = Color.FromArgb(113, 96, 232);
            noDatalbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            noDatalbl.ForeColor = Color.Coral;
            noDatalbl.Location = new Point(392, 358);
            noDatalbl.Margin = new Padding(4, 0, 4, 0);
            noDatalbl.Name = "noDatalbl";
            noDatalbl.Size = new Size(0, 38);
            noDatalbl.TabIndex = 23;
            // 
            // searchpbox
            // 
            searchpbox.BackgroundImage = Properties.Resources.MagnifyingGlass;
            searchpbox.BackgroundImageLayout = ImageLayout.Stretch;
            searchpbox.Cursor = Cursors.Hand;
            searchpbox.Location = new Point(1379, 38);
            searchpbox.Margin = new Padding(4, 5, 4, 5);
            searchpbox.Name = "searchpbox";
            searchpbox.Size = new Size(36, 42);
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
            customInputnud.Location = new Point(1293, 37);
            customInputnud.Margin = new Padding(4, 5, 4, 5);
            customInputnud.Name = "customInputnud";
            customInputnud.Size = new Size(76, 39);
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
            recentScannedGridView.Location = new Point(23, 118);
            recentScannedGridView.Margin = new Padding(4, 5, 4, 5);
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
            recentScannedGridView.Size = new Size(1403, 683);
            recentScannedGridView.TabIndex = 13;
            // 
            // radioButtonpnl
            // 
            radioButtonpnl.Controls.Add(customrbtn);
            radioButtonpnl.Controls.Add(tenrbtn);
            radioButtonpnl.Controls.Add(fiverbtn);
            radioButtonpnl.Controls.Add(tworbtn);
            radioButtonpnl.Location = new Point(696, 12);
            radioButtonpnl.Margin = new Padding(4, 5, 4, 5);
            radioButtonpnl.Name = "radioButtonpnl";
            radioButtonpnl.Size = new Size(573, 85);
            radioButtonpnl.TabIndex = 12;
            // 
            // customrbtn
            // 
            customrbtn.AutoSize = true;
            customrbtn.Cursor = Cursors.Hand;
            customrbtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            customrbtn.ForeColor = Color.FromArgb(0, 126, 249);
            customrbtn.Location = new Point(459, 27);
            customrbtn.Margin = new Padding(4, 5, 4, 5);
            customrbtn.Name = "customrbtn";
            customrbtn.Size = new Size(118, 35);
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
            tenrbtn.Location = new Point(307, 27);
            tenrbtn.Margin = new Padding(4, 5, 4, 5);
            tenrbtn.Name = "tenrbtn";
            tenrbtn.Size = new Size(150, 35);
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
            fiverbtn.Location = new Point(164, 27);
            fiverbtn.Margin = new Padding(4, 5, 4, 5);
            fiverbtn.Name = "fiverbtn";
            fiverbtn.Size = new Size(141, 35);
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
            tworbtn.Location = new Point(4, 27);
            tworbtn.Margin = new Padding(4, 5, 4, 5);
            tworbtn.Name = "tworbtn";
            tworbtn.Size = new Size(143, 34);
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
            Borderpnl.Location = new Point(23, 115);
            Borderpnl.Margin = new Padding(4, 5, 4, 5);
            Borderpnl.Name = "Borderpnl";
            Borderpnl.Size = new Size(1457, 880);
            Borderpnl.TabIndex = 14;
            // 
            // DisplayBoard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1503, 1015);
            Controls.Add(Titlelbl);
            Controls.Add(Borderpnl);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
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
    }
}