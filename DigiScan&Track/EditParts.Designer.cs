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
            AgedGridView = new DataGridView();
            tableaubtn = new Button();
            agedlbl = new Label();
            excelbtn = new Button();
            agedtxt = new TextBox();
            agedcmb = new ComboBox();
            OuterBorderpnl = new Panel();
            ((System.ComponentModel.ISupportInitialize)editSysGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            InnerBorderpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AgedGridView).BeginInit();
            OuterBorderpnl.SuspendLayout();
            SuspendLayout();
            // 
            // editSysGridView
            // 
            editSysGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            editSysGridView.Location = new Point(643, 85);
            editSysGridView.Name = "editSysGridView";
            editSysGridView.RowTemplate.Height = 25;
            editSysGridView.Size = new Size(506, 488);
            editSysGridView.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(133, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(442, 419);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(337, 194);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(217, 33);
            comboBox1.TabIndex = 7;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(171, 271);
            label2.Name = "label2";
            label2.Size = new Size(145, 47);
            label2.TabIndex = 8;
            label2.Text = "Scan 2D Barcode from Unit:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // searchtxt
            // 
            searchtxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchtxt.Location = new Point(322, 280);
            searchtxt.Name = "searchtxt";
            searchtxt.Size = new Size(244, 29);
            searchtxt.TabIndex = 9;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(170, 197);
            label1.Name = "label1";
            label1.Size = new Size(172, 28);
            label1.TabIndex = 6;
            label1.Text = "Select Part Number:";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(144, 124);
            label3.Name = "label3";
            label3.Size = new Size(224, 28);
            label3.TabIndex = 10;
            label3.Text = "Search for Part to Edit";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaptionText;
            pictureBox2.Location = new Point(139, 343);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(431, 2);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(144, 357);
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
            Titlelbl.Size = new Size(776, 47);
            Titlelbl.TabIndex = 14;
            Titlelbl.Text = "DigiScan && Track - Shortcuts\r\n";
            Titlelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InnerBorderpnl
            // 
            InnerBorderpnl.Anchor = AnchorStyles.None;
            InnerBorderpnl.BackColor = Color.FromArgb(46, 51, 73);
            InnerBorderpnl.Controls.Add(AgedGridView);
            InnerBorderpnl.Controls.Add(tableaubtn);
            InnerBorderpnl.Controls.Add(agedlbl);
            InnerBorderpnl.Controls.Add(excelbtn);
            InnerBorderpnl.Controls.Add(agedtxt);
            InnerBorderpnl.Controls.Add(agedcmb);
            InnerBorderpnl.Location = new Point(414, 217);
            InnerBorderpnl.Name = "InnerBorderpnl";
            InnerBorderpnl.Size = new Size(1013, 522);
            InnerBorderpnl.TabIndex = 11;
            // 
            // AgedGridView
            // 
            AgedGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AgedGridView.Location = new Point(16, 57);
            AgedGridView.Name = "AgedGridView";
            AgedGridView.RowTemplate.Height = 25;
            AgedGridView.Size = new Size(982, 450);
            AgedGridView.TabIndex = 2;
            // 
            // tableaubtn
            // 
            tableaubtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tableaubtn.Location = new Point(911, 9);
            tableaubtn.Name = "tableaubtn";
            tableaubtn.Size = new Size(69, 42);
            tableaubtn.TabIndex = 10;
            tableaubtn.Text = "Tableau Metrics";
            tableaubtn.UseVisualStyleBackColor = true;
            // 
            // agedlbl
            // 
            agedlbl.AutoSize = true;
            agedlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            agedlbl.Location = new Point(16, 19);
            agedlbl.Name = "agedlbl";
            agedlbl.Size = new Size(166, 21);
            agedlbl.TabIndex = 8;
            agedlbl.Text = "Search Days as Aged";
            // 
            // excelbtn
            // 
            excelbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            excelbtn.Location = new Point(827, 9);
            excelbtn.Name = "excelbtn";
            excelbtn.Size = new Size(69, 42);
            excelbtn.TabIndex = 9;
            excelbtn.Text = "Excel Export";
            excelbtn.UseVisualStyleBackColor = true;
            // 
            // agedtxt
            // 
            agedtxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            agedtxt.Location = new Point(347, 16);
            agedtxt.Name = "agedtxt";
            agedtxt.Size = new Size(175, 29);
            agedtxt.TabIndex = 7;
            // 
            // agedcmb
            // 
            agedcmb.BackColor = SystemColors.Window;
            agedcmb.FlatStyle = FlatStyle.Popup;
            agedcmb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            agedcmb.FormattingEnabled = true;
            agedcmb.Items.AddRange(new object[] { "=", "<", ">", "<=", ">=", "Range" });
            agedcmb.Location = new Point(188, 16);
            agedcmb.Name = "agedcmb";
            agedcmb.Size = new Size(149, 29);
            agedcmb.TabIndex = 6;
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
            ClientSize = new Size(1207, 612);
            Controls.Add(OuterBorderpnl);
            Controls.Add(Titlelbl);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(searchtxt);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(editSysGridView);
            Name = "EditParts";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)editSysGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            InnerBorderpnl.ResumeLayout(false);
            InnerBorderpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AgedGridView).EndInit();
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
        private DataGridView AgedGridView;
        private Button tableaubtn;
        private Label agedlbl;
        private Button excelbtn;
        private TextBox agedtxt;
        private ComboBox agedcmb;
        private Panel OuterBorderpnl;
    }
}