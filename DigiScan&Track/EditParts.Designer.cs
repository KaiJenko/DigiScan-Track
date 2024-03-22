namespace DigiScan_Track
{
    partial class EditParts
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
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            searchtxt = new TextBox();
            label1 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            Titlelbl = new Label();
            InnerBorderpnl = new Panel();
            OuterBorderpnl = new Panel();
            panel1 = new Panel();
            label5 = new Label();
            comboBox2 = new ComboBox();
            recentScannedGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            InnerBorderpnl.SuspendLayout();
            OuterBorderpnl.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)recentScannedGridView).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(24, 30, 54);
            pictureBox1.Location = new Point(18, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(442, 419);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(46, 51, 73);
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(214, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(201, 33);
            comboBox1.TabIndex = 7;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(46, 51, 73);
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(64, 127);
            label2.Name = "label2";
            label2.Size = new Size(145, 47);
            label2.TabIndex = 8;
            label2.Text = "Scan 2D Barcode from Unit:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // searchtxt
            // 
            searchtxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchtxt.Location = new Point(214, 137);
            searchtxt.Name = "searchtxt";
            searchtxt.Size = new Size(201, 29);
            searchtxt.TabIndex = 9;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(46, 51, 73);
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(41, 89);
            label1.Name = "label1";
            label1.Size = new Size(172, 28);
            label1.TabIndex = 6;
            label1.Text = "Select Part Number:";
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(46, 51, 73);
            label3.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 2);
            label3.Name = "label3";
            label3.Size = new Size(224, 28);
            label3.TabIndex = 10;
            label3.Text = "Search for Part to Edit";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaptionText;
            pictureBox2.Location = new Point(24, 269);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(431, 2);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(46, 51, 73);
            label4.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(29, 283);
            label4.Name = "label4";
            label4.Size = new Size(352, 28);
            label4.TabIndex = 12;
            label4.Text = "Add New Part Number - Admin Only";
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
            Titlelbl.Size = new Size(803, 47);
            Titlelbl.TabIndex = 14;
            Titlelbl.Text = "DigiScan && Track - Edit Parts\r\n";
            Titlelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InnerBorderpnl
            // 
            InnerBorderpnl.Anchor = AnchorStyles.None;
            InnerBorderpnl.BackColor = Color.FromArgb(46, 51, 73);
            InnerBorderpnl.Controls.Add(recentScannedGridView);
            InnerBorderpnl.Controls.Add(panel1);
            InnerBorderpnl.Controls.Add(pictureBox1);
            InnerBorderpnl.Location = new Point(4, 3);
            InnerBorderpnl.Name = "InnerBorderpnl";
            InnerBorderpnl.Size = new Size(1013, 522);
            InnerBorderpnl.TabIndex = 11;
            // 
            // OuterBorderpnl
            // 
            OuterBorderpnl.Anchor = AnchorStyles.None;
            OuterBorderpnl.BackColor = Color.FromArgb(24, 30, 54);
            OuterBorderpnl.Controls.Add(InnerBorderpnl);
            OuterBorderpnl.Location = new Point(16, 69);
            OuterBorderpnl.Name = "OuterBorderpnl";
            OuterBorderpnl.Size = new Size(1020, 528);
            OuterBorderpnl.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(searchtxt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(22, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 411);
            panel1.TabIndex = 14;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(46, 51, 73);
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(47, 35);
            label5.Name = "label5";
            label5.Size = new Size(166, 28);
            label5.TabIndex = 13;
            label5.Text = "Select Department:";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(46, 51, 73);
            comboBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.ForeColor = Color.White;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(214, 83);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(201, 33);
            comboBox2.TabIndex = 14;
            // 
            // recentScannedGridView
            // 
            recentScannedGridView.BackgroundColor = Color.FromArgb(24, 30, 54);
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
            recentScannedGridView.Location = new Point(476, 25);
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
            recentScannedGridView.Size = new Size(518, 464);
            recentScannedGridView.TabIndex = 15;
            // 
            // EditParts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1052, 609);
            Controls.Add(Titlelbl);
            Controls.Add(OuterBorderpnl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditParts";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            InnerBorderpnl.ResumeLayout(false);
            OuterBorderpnl.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)recentScannedGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox searchtxt;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label4;
        private Label Titlelbl;
        private Panel InnerBorderpnl;
        private Panel OuterBorderpnl;
        private Panel panel1;
        private ComboBox comboBox2;
        private Label label5;
        private DataGridView recentScannedGridView;
    }
}