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
            editSysGridView = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)editSysGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            InnerBorderpnl.SuspendLayout();
            OuterBorderpnl.SuspendLayout();
            SuspendLayout();
            // 
            // editSysGridView
            // 
            editSysGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            editSysGridView.Location = new Point(498, 12);
            editSysGridView.Name = "editSysGridView";
            editSysGridView.RowTemplate.Height = 25;
            editSysGridView.Size = new Size(506, 474);
            editSysGridView.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(18, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(442, 419);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(222, 120);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(217, 33);
            comboBox1.TabIndex = 7;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(56, 197);
            label2.Name = "label2";
            label2.Size = new Size(145, 47);
            label2.TabIndex = 8;
            label2.Text = "Scan 2D Barcode from Unit:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // searchtxt
            // 
            searchtxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchtxt.Location = new Point(207, 206);
            searchtxt.Name = "searchtxt";
            searchtxt.Size = new Size(244, 29);
            searchtxt.TabIndex = 9;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 123);
            label1.Name = "label1";
            label1.Size = new Size(172, 28);
            label1.TabIndex = 6;
            label1.Text = "Select Part Number:";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(29, 50);
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
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
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
            InnerBorderpnl.Controls.Add(label4);
            InnerBorderpnl.Controls.Add(label1);
            InnerBorderpnl.Controls.Add(pictureBox2);
            InnerBorderpnl.Controls.Add(comboBox1);
            InnerBorderpnl.Controls.Add(label3);
            InnerBorderpnl.Controls.Add(label2);
            InnerBorderpnl.Controls.Add(searchtxt);
            InnerBorderpnl.Controls.Add(pictureBox1);
            InnerBorderpnl.Controls.Add(editSysGridView);
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
            ((System.ComponentModel.ISupportInitialize)editSysGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            InnerBorderpnl.ResumeLayout(false);
            InnerBorderpnl.PerformLayout();
            OuterBorderpnl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView editSysGridView;
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
    }
}