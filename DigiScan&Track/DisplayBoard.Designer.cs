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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            agedlbl = new Label();
            Titlelbl = new Label();
            BodyLayoutpnl = new Panel();
            radioButtonpnl = new Panel();
            sixtyrbtn = new RadioButton();
            tenrbtn = new RadioButton();
            fiverbtn = new RadioButton();
            tworbtn = new RadioButton();
            recentScannedGridView = new DataGridView();
            Borderpnl = new Panel();
            BodyLayoutpnl.SuspendLayout();
            radioButtonpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)recentScannedGridView).BeginInit();
            Borderpnl.SuspendLayout();
            SuspendLayout();
            // 
            // agedlbl
            // 
            agedlbl.AutoSize = true;
            agedlbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            agedlbl.ForeColor = Color.White;
            agedlbl.Location = new Point(28, 18);
            agedlbl.Name = "agedlbl";
            agedlbl.Size = new Size(460, 25);
            agedlbl.TabIndex = 9;
            agedlbl.Text = "This Board Displays Everything Scanned in the last:";
            // 
            // Titlelbl
            // 
            Titlelbl.AutoSize = true;
            Titlelbl.BackColor = Color.Transparent;
            Titlelbl.Font = new Font("Taurus Mono Outline", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            Titlelbl.ForeColor = Color.White;
            Titlelbl.Location = new Point(95, 10);
            Titlelbl.Name = "Titlelbl";
            Titlelbl.Size = new Size(884, 47);
            Titlelbl.TabIndex = 12;
            Titlelbl.Text = "DigiScan && Track - Display Board";
            Titlelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BodyLayoutpnl
            // 
            BodyLayoutpnl.BackColor = Color.FromArgb(46, 51, 73);
            BodyLayoutpnl.Controls.Add(radioButtonpnl);
            BodyLayoutpnl.Controls.Add(recentScannedGridView);
            BodyLayoutpnl.Controls.Add(agedlbl);
            BodyLayoutpnl.Location = new Point(4, 3);
            BodyLayoutpnl.Name = "BodyLayoutpnl";
            BodyLayoutpnl.Size = new Size(1013, 522);
            BodyLayoutpnl.TabIndex = 11;
            // 
            // radioButtonpnl
            // 
            radioButtonpnl.Controls.Add(sixtyrbtn);
            radioButtonpnl.Controls.Add(tenrbtn);
            radioButtonpnl.Controls.Add(fiverbtn);
            radioButtonpnl.Controls.Add(tworbtn);
            radioButtonpnl.Location = new Point(515, 5);
            radioButtonpnl.Name = "radioButtonpnl";
            radioButtonpnl.Size = new Size(402, 51);
            radioButtonpnl.TabIndex = 12;
            // 
            // sixtyrbtn
            // 
            sixtyrbtn.AutoSize = true;
            sixtyrbtn.Checked = true;
            sixtyrbtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            sixtyrbtn.ForeColor = Color.FromArgb(0, 126, 249);
            sixtyrbtn.Location = new Point(321, 16);
            sixtyrbtn.Name = "sixtyrbtn";
            sixtyrbtn.Size = new Size(72, 24);
            sixtyrbtn.TabIndex = 3;
            sixtyrbtn.TabStop = true;
            sixtyrbtn.Tag = "60";
            sixtyrbtn.Text = "1 Hour";
            sixtyrbtn.UseVisualStyleBackColor = true;
            sixtyrbtn.CheckedChanged += radioButton_CheckedChanged;
            // 
            // tenrbtn
            // 
            tenrbtn.AutoSize = true;
            tenrbtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            tenrbtn.ForeColor = Color.FromArgb(0, 126, 249);
            tenrbtn.Location = new Point(215, 16);
            tenrbtn.Name = "tenrbtn";
            tenrbtn.Size = new Size(100, 24);
            tenrbtn.TabIndex = 2;
            tenrbtn.Tag = "10";
            tenrbtn.Text = "10 Minutes";
            tenrbtn.UseVisualStyleBackColor = true;
            tenrbtn.CheckedChanged += radioButton_CheckedChanged;
            // 
            // fiverbtn
            // 
            fiverbtn.AutoSize = true;
            fiverbtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            fiverbtn.ForeColor = Color.FromArgb(0, 126, 249);
            fiverbtn.Location = new Point(115, 16);
            fiverbtn.Name = "fiverbtn";
            fiverbtn.Size = new Size(94, 24);
            fiverbtn.TabIndex = 1;
            fiverbtn.Tag = "5";
            fiverbtn.Text = "5 Minutes";
            fiverbtn.UseVisualStyleBackColor = true;
            fiverbtn.CheckedChanged += radioButton_CheckedChanged;
            // 
            // tworbtn
            // 
            tworbtn.AutoSize = true;
            tworbtn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            tworbtn.ForeColor = Color.FromArgb(0, 126, 249);
            tworbtn.Location = new Point(3, 16);
            tworbtn.Name = "tworbtn";
            tworbtn.Size = new Size(106, 24);
            tworbtn.TabIndex = 0;
            tworbtn.Tag = "2";
            tworbtn.Text = " 2  Minutes ";
            tworbtn.UseVisualStyleBackColor = true;
            tworbtn.CheckedChanged += radioButton_CheckedChanged;
            // 
            // recentScannedGridView
            // 
            recentScannedGridView.BackgroundColor = Color.FromArgb(45, 66, 91);
            recentScannedGridView.BorderStyle = BorderStyle.None;
            recentScannedGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            recentScannedGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            recentScannedGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            recentScannedGridView.DefaultCellStyle = dataGridViewCellStyle6;
            recentScannedGridView.GridColor = Color.White;
            recentScannedGridView.Location = new Point(14, 62);
            recentScannedGridView.Name = "recentScannedGridView";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            recentScannedGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            recentScannedGridView.RowHeadersVisible = false;
            recentScannedGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle8.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            recentScannedGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            recentScannedGridView.RowTemplate.Height = 25;
            recentScannedGridView.Size = new Size(989, 443);
            recentScannedGridView.TabIndex = 11;
            // 
            // Borderpnl
            // 
            Borderpnl.Anchor = AnchorStyles.None;
            Borderpnl.BackColor = Color.FromArgb(24, 30, 54);
            Borderpnl.Controls.Add(BodyLayoutpnl);
            Borderpnl.Location = new Point(16, 69);
            Borderpnl.Name = "Borderpnl";
            Borderpnl.Size = new Size(1020, 528);
            Borderpnl.TabIndex = 14;
            // 
            // DisplayBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1052, 609);
            Controls.Add(Titlelbl);
            Controls.Add(Borderpnl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DisplayBoard";
            Text = "Form1";
            Load += Form1_Load;
            BodyLayoutpnl.ResumeLayout(false);
            BodyLayoutpnl.PerformLayout();
            radioButtonpnl.ResumeLayout(false);
            radioButtonpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)recentScannedGridView).EndInit();
            Borderpnl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label agedlbl;
        private Label Titlelbl;
        private Panel BodyLayoutpnl;
        private Panel Borderpnl;
        private Panel radioButtonpnl;
        private RadioButton fiverbtn;
        private RadioButton tworbtn;
        private DataGridView recentScannedGridView;
        private RadioButton sixtyrbtn;
        private RadioButton tenrbtn;
    }
}