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
            HomePageheader = new Panel();
            Userimgbox = new PictureBox();
            Usernamelbl = new Label();
            DisplayBoardbtn = new Button();
            ManualInputbtn = new Button();
            EditPartsbtn = new Button();
            AgedWIPbtn = new Button();
            HomeAreabtn = new Button();
            Titlelbl = new Label();
            WIPTrackerbtn = new Button();
            HomePagefooter = new Panel();
            editSysGridView = new DataGridView();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            searchtxt = new TextBox();
            label1 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            HomePageheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Userimgbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editSysGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // HomePageheader
            // 
            HomePageheader.BackColor = Color.Red;
            HomePageheader.Controls.Add(Userimgbox);
            HomePageheader.Controls.Add(Usernamelbl);
            HomePageheader.Controls.Add(DisplayBoardbtn);
            HomePageheader.Controls.Add(ManualInputbtn);
            HomePageheader.Controls.Add(EditPartsbtn);
            HomePageheader.Controls.Add(AgedWIPbtn);
            HomePageheader.Controls.Add(HomeAreabtn);
            HomePageheader.Controls.Add(Titlelbl);
            HomePageheader.Controls.Add(WIPTrackerbtn);
            HomePageheader.Location = new Point(0, -4);
            HomePageheader.Name = "HomePageheader";
            HomePageheader.Size = new Size(1211, 75);
            HomePageheader.TabIndex = 0;
            // 
            // Userimgbox
            // 
            Userimgbox.Image = Properties.Resources.UserImage;
            Userimgbox.Location = new Point(1024, 16);
            Userimgbox.Name = "Userimgbox";
            Userimgbox.Size = new Size(58, 50);
            Userimgbox.SizeMode = PictureBoxSizeMode.StretchImage;
            Userimgbox.TabIndex = 6;
            Userimgbox.TabStop = false;
            // 
            // Usernamelbl
            // 
            Usernamelbl.BackColor = Color.Transparent;
            Usernamelbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Usernamelbl.ForeColor = Color.White;
            Usernamelbl.Location = new Point(1095, 27);
            Usernamelbl.Name = "Usernamelbl";
            Usernamelbl.Size = new Size(100, 26);
            Usernamelbl.TabIndex = 5;
            Usernamelbl.Text = "Username";
            // 
            // DisplayBoardbtn
            // 
            DisplayBoardbtn.Location = new Point(892, 26);
            DisplayBoardbtn.Name = "DisplayBoardbtn";
            DisplayBoardbtn.Size = new Size(91, 26);
            DisplayBoardbtn.TabIndex = 2;
            DisplayBoardbtn.Text = "Display Board";
            DisplayBoardbtn.UseVisualStyleBackColor = true;
            DisplayBoardbtn.Click += DisplayBoardbtn_Click;
            // 
            // ManualInputbtn
            // 
            ManualInputbtn.Location = new Point(774, 27);
            ManualInputbtn.Name = "ManualInputbtn";
            ManualInputbtn.Size = new Size(96, 26);
            ManualInputbtn.TabIndex = 2;
            ManualInputbtn.Text = "Manual Input";
            ManualInputbtn.UseVisualStyleBackColor = true;
            ManualInputbtn.Click += ManualInputbtn_Click;
            // 
            // EditPartsbtn
            // 
            EditPartsbtn.Location = new Point(672, 27);
            EditPartsbtn.Name = "EditPartsbtn";
            EditPartsbtn.Size = new Size(82, 26);
            EditPartsbtn.TabIndex = 2;
            EditPartsbtn.Text = "Edit Parts";
            EditPartsbtn.UseVisualStyleBackColor = true;
            EditPartsbtn.Click += EditPartsbtn_Click;
            // 
            // AgedWIPbtn
            // 
            AgedWIPbtn.Location = new Point(563, 27);
            AgedWIPbtn.Name = "AgedWIPbtn";
            AgedWIPbtn.Size = new Size(82, 26);
            AgedWIPbtn.TabIndex = 4;
            AgedWIPbtn.Text = "Aged WIP";
            AgedWIPbtn.UseVisualStyleBackColor = true;
            AgedWIPbtn.Click += AgedWIPbtn_Click;
            // 
            // HomeAreabtn
            // 
            HomeAreabtn.Location = new Point(343, 27);
            HomeAreabtn.Name = "HomeAreabtn";
            HomeAreabtn.Size = new Size(82, 26);
            HomeAreabtn.TabIndex = 3;
            HomeAreabtn.Text = "Home Area";
            HomeAreabtn.UseVisualStyleBackColor = true;
            HomeAreabtn.Click += HomeAreabtn_Click;
            // 
            // Titlelbl
            // 
            Titlelbl.AutoSize = true;
            Titlelbl.BackColor = Color.Transparent;
            Titlelbl.Font = new Font("Yu Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Titlelbl.ForeColor = Color.White;
            Titlelbl.Location = new Point(45, 6);
            Titlelbl.Name = "Titlelbl";
            Titlelbl.Size = new Size(261, 70);
            Titlelbl.TabIndex = 2;
            Titlelbl.Text = "Part Management \r\nand Edit System\r\n";
            Titlelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WIPTrackerbtn
            // 
            WIPTrackerbtn.Location = new Point(454, 27);
            WIPTrackerbtn.Name = "WIPTrackerbtn";
            WIPTrackerbtn.Size = new Size(82, 26);
            WIPTrackerbtn.TabIndex = 1;
            WIPTrackerbtn.Text = "WIP Tracker";
            WIPTrackerbtn.UseVisualStyleBackColor = true;
            WIPTrackerbtn.Click += WIPTrackerbtn_Click;
            // 
            // HomePagefooter
            // 
            HomePagefooter.BackColor = Color.DimGray;
            HomePagefooter.Location = new Point(-1, 579);
            HomePagefooter.Name = "HomePagefooter";
            HomePagefooter.Size = new Size(1211, 34);
            HomePagefooter.TabIndex = 1;
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
            // EditParts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 612);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(searchtxt);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(editSysGridView);
            Controls.Add(HomePagefooter);
            Controls.Add(HomePageheader);
            Name = "EditParts";
            Text = "Form1";
            Load += Form1_Load;
            HomePageheader.ResumeLayout(false);
            HomePageheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Userimgbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)editSysGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel HomePageheader;
        private Button WIPTrackerbtn;
        private Panel HomePagefooter;
        private Label Titlelbl;
        private Label Usernamelbl;
        private Button DisplayBoardbtn;
        private Button ManualInputbtn;
        private Button EditPartsbtn;
        private Button AgedWIPbtn;
        private Button HomeAreabtn;
        private PictureBox Userimgbox;
        private DataGridView editSysGridView;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox searchtxt;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label4;
    }
}