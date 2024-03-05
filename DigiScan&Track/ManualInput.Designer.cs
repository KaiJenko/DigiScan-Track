namespace DigiScan_Track
{
    partial class ManualInput
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
            manualTablepnl = new TableLayoutPanel();
            HomePageheader = new Panel();
            Titlelbl = new Label();
            dashpnl = new Panel();
            DisplayBoardbtn = new Button();
            ManualInputbtn = new Button();
            EditPartsbtn = new Button();
            AgedWIPbtn = new Button();
            WIPTrackerbtn = new Button();
            HomeAreabtn = new Button();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            usernamelbl = new Label();
            collapsepicbox = new PictureBox();
            selectionpnl = new Panel();
            panel1 = new Panel();
            expandpicbox = new PictureBox();
            manualTablepnl.SuspendLayout();
            HomePageheader.SuspendLayout();
            dashpnl.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)collapsepicbox).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)expandpicbox).BeginInit();
            SuspendLayout();
            // 
            // manualTablepnl
            // 
            manualTablepnl.ColumnCount = 2;
            manualTablepnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.344656F));
            manualTablepnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.65534F));
            manualTablepnl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            manualTablepnl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            manualTablepnl.Controls.Add(HomePageheader, 0, 0);
            manualTablepnl.Controls.Add(dashpnl, 0, 1);
            manualTablepnl.Controls.Add(panel1, 1, 1);
            manualTablepnl.Dock = DockStyle.Fill;
            manualTablepnl.Location = new Point(0, 0);
            manualTablepnl.Name = "manualTablepnl";
            manualTablepnl.RowCount = 2;
            manualTablepnl.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5816994F));
            manualTablepnl.RowStyles.Add(new RowStyle(SizeType.Percent, 87.4183044F));
            manualTablepnl.Size = new Size(1207, 612);
            manualTablepnl.TabIndex = 1;
            // 
            // HomePageheader
            // 
            HomePageheader.BackColor = Color.Red;
            manualTablepnl.SetColumnSpan(HomePageheader, 2);
            HomePageheader.Controls.Add(Titlelbl);
            HomePageheader.Dock = DockStyle.Top;
            HomePageheader.Location = new Point(0, 0);
            HomePageheader.Margin = new Padding(0);
            HomePageheader.Name = "HomePageheader";
            HomePageheader.Size = new Size(1207, 75);
            HomePageheader.TabIndex = 1;
            // 
            // Titlelbl
            // 
            Titlelbl.AutoSize = true;
            Titlelbl.BackColor = Color.Transparent;
            Titlelbl.Font = new Font("Yu Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Titlelbl.ForeColor = Color.White;
            Titlelbl.Location = new Point(36, 22);
            Titlelbl.Name = "Titlelbl";
            Titlelbl.Size = new Size(264, 35);
            Titlelbl.TabIndex = 2;
            Titlelbl.Text = "Manual Part Input \r\n";
            Titlelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dashpnl
            // 
            dashpnl.BackColor = Color.FromArgb(24, 30, 54);
            dashpnl.Controls.Add(DisplayBoardbtn);
            dashpnl.Controls.Add(ManualInputbtn);
            dashpnl.Controls.Add(EditPartsbtn);
            dashpnl.Controls.Add(AgedWIPbtn);
            dashpnl.Controls.Add(WIPTrackerbtn);
            dashpnl.Controls.Add(HomeAreabtn);
            dashpnl.Controls.Add(panel2);
            dashpnl.Controls.Add(collapsepicbox);
            dashpnl.Controls.Add(selectionpnl);
            dashpnl.Dock = DockStyle.Left;
            dashpnl.Location = new Point(0, 77);
            dashpnl.Margin = new Padding(0);
            dashpnl.Name = "dashpnl";
            dashpnl.Size = new Size(149, 535);
            dashpnl.TabIndex = 2;
            // 
            // DisplayBoardbtn
            // 
            DisplayBoardbtn.BackgroundImageLayout = ImageLayout.Stretch;
            DisplayBoardbtn.Dock = DockStyle.Top;
            DisplayBoardbtn.FlatAppearance.BorderSize = 0;
            DisplayBoardbtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            DisplayBoardbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 51, 73);
            DisplayBoardbtn.FlatStyle = FlatStyle.Flat;
            DisplayBoardbtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DisplayBoardbtn.ForeColor = Color.FromArgb(0, 126, 249);
            DisplayBoardbtn.ImageAlign = ContentAlignment.MiddleLeft;
            DisplayBoardbtn.Location = new Point(0, 313);
            DisplayBoardbtn.Name = "DisplayBoardbtn";
            DisplayBoardbtn.Size = new Size(149, 40);
            DisplayBoardbtn.TabIndex = 10;
            DisplayBoardbtn.Text = "Display Board";
            DisplayBoardbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            DisplayBoardbtn.UseVisualStyleBackColor = true;
            DisplayBoardbtn.Click += DisplayBoardbtn_Click;
            DisplayBoardbtn.MouseEnter += hoverButton;
            DisplayBoardbtn.MouseLeave += unHoverButton;
            // 
            // ManualInputbtn
            // 
            ManualInputbtn.BackgroundImageLayout = ImageLayout.Stretch;
            ManualInputbtn.Dock = DockStyle.Top;
            ManualInputbtn.FlatAppearance.BorderSize = 0;
            ManualInputbtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            ManualInputbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 51, 73);
            ManualInputbtn.FlatStyle = FlatStyle.Flat;
            ManualInputbtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ManualInputbtn.ForeColor = Color.FromArgb(0, 126, 249);
            ManualInputbtn.ImageAlign = ContentAlignment.MiddleLeft;
            ManualInputbtn.Location = new Point(0, 273);
            ManualInputbtn.Name = "ManualInputbtn";
            ManualInputbtn.Size = new Size(149, 40);
            ManualInputbtn.TabIndex = 7;
            ManualInputbtn.Text = "Manual Input";
            ManualInputbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            ManualInputbtn.UseVisualStyleBackColor = true;
            ManualInputbtn.Click += ManualInputbtn_Click;
            ManualInputbtn.MouseEnter += hoverButton;
            ManualInputbtn.MouseLeave += unHoverButton;
            // 
            // EditPartsbtn
            // 
            EditPartsbtn.BackgroundImageLayout = ImageLayout.Stretch;
            EditPartsbtn.Dock = DockStyle.Top;
            EditPartsbtn.FlatAppearance.BorderSize = 0;
            EditPartsbtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            EditPartsbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 51, 73);
            EditPartsbtn.FlatStyle = FlatStyle.Flat;
            EditPartsbtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            EditPartsbtn.ForeColor = Color.FromArgb(0, 126, 249);
            EditPartsbtn.ImageAlign = ContentAlignment.MiddleLeft;
            EditPartsbtn.Location = new Point(0, 233);
            EditPartsbtn.Name = "EditPartsbtn";
            EditPartsbtn.Size = new Size(149, 40);
            EditPartsbtn.TabIndex = 6;
            EditPartsbtn.Text = "Edit Parts";
            EditPartsbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            EditPartsbtn.UseVisualStyleBackColor = true;
            EditPartsbtn.Click += EditPartsbtn_Click;
            EditPartsbtn.MouseEnter += hoverButton;
            EditPartsbtn.MouseLeave += unHoverButton;
            // 
            // AgedWIPbtn
            // 
            AgedWIPbtn.BackgroundImageLayout = ImageLayout.Stretch;
            AgedWIPbtn.Dock = DockStyle.Top;
            AgedWIPbtn.FlatAppearance.BorderSize = 0;
            AgedWIPbtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            AgedWIPbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 51, 73);
            AgedWIPbtn.FlatStyle = FlatStyle.Flat;
            AgedWIPbtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AgedWIPbtn.ForeColor = Color.FromArgb(0, 126, 249);
            AgedWIPbtn.ImageAlign = ContentAlignment.MiddleLeft;
            AgedWIPbtn.Location = new Point(0, 193);
            AgedWIPbtn.Name = "AgedWIPbtn";
            AgedWIPbtn.Size = new Size(149, 40);
            AgedWIPbtn.TabIndex = 8;
            AgedWIPbtn.Text = "Aged WIP";
            AgedWIPbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            AgedWIPbtn.UseVisualStyleBackColor = true;
            AgedWIPbtn.Click += AgedWIPbtn_Click;
            AgedWIPbtn.MouseEnter += hoverButton;
            AgedWIPbtn.MouseLeave += unHoverButton;
            // 
            // WIPTrackerbtn
            // 
            WIPTrackerbtn.BackgroundImageLayout = ImageLayout.Stretch;
            WIPTrackerbtn.Dock = DockStyle.Top;
            WIPTrackerbtn.FlatAppearance.BorderSize = 0;
            WIPTrackerbtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            WIPTrackerbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 51, 73);
            WIPTrackerbtn.FlatStyle = FlatStyle.Flat;
            WIPTrackerbtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            WIPTrackerbtn.ForeColor = Color.FromArgb(0, 126, 249);
            WIPTrackerbtn.ImageAlign = ContentAlignment.MiddleLeft;
            WIPTrackerbtn.Location = new Point(0, 153);
            WIPTrackerbtn.Name = "WIPTrackerbtn";
            WIPTrackerbtn.Size = new Size(149, 40);
            WIPTrackerbtn.TabIndex = 5;
            WIPTrackerbtn.Text = "WIP Tracker";
            WIPTrackerbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            WIPTrackerbtn.UseVisualStyleBackColor = true;
            WIPTrackerbtn.Click += WIPTrackerbtn_Click;
            WIPTrackerbtn.MouseEnter += hoverButton;
            WIPTrackerbtn.MouseLeave += unHoverButton;
            // 
            // HomeAreabtn
            // 
            HomeAreabtn.BackgroundImageLayout = ImageLayout.Stretch;
            HomeAreabtn.Dock = DockStyle.Top;
            HomeAreabtn.FlatAppearance.BorderSize = 0;
            HomeAreabtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            HomeAreabtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 51, 73);
            HomeAreabtn.FlatStyle = FlatStyle.Flat;
            HomeAreabtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            HomeAreabtn.ForeColor = Color.FromArgb(0, 126, 249);
            HomeAreabtn.ImageAlign = ContentAlignment.MiddleLeft;
            HomeAreabtn.Location = new Point(0, 113);
            HomeAreabtn.Name = "HomeAreabtn";
            HomeAreabtn.Size = new Size(149, 40);
            HomeAreabtn.TabIndex = 9;
            HomeAreabtn.Text = "Home Area";
            HomeAreabtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            HomeAreabtn.UseVisualStyleBackColor = true;
            HomeAreabtn.Click += HomeAreabtn_Click;
            HomeAreabtn.MouseEnter += hoverButton;
            HomeAreabtn.MouseLeave += unHoverButton;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(usernamelbl);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(149, 113);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(1, 98);
            label1.Name = "label1";
            label1.Size = new Size(67, 12);
            label1.TabIndex = 8;
            label1.Text = "Current Period:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.output_onlinepngtools1;
            pictureBox1.Location = new Point(121, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += collapsepicbox_Click;
            pictureBox1.MouseEnter += collapsepicbox_MouseEnter_1;
            pictureBox1.MouseLeave += collapsepicbox_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.output_onlinepngtools__2_;
            pictureBox2.Location = new Point(45, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // usernamelbl
            // 
            usernamelbl.AutoSize = true;
            usernamelbl.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            usernamelbl.ForeColor = Color.FromArgb(0, 126, 249);
            usernamelbl.Location = new Point(29, 73);
            usernamelbl.Name = "usernamelbl";
            usernamelbl.Size = new Size(93, 18);
            usernamelbl.TabIndex = 6;
            usernamelbl.Text = "User Name";
            // 
            // collapsepicbox
            // 
            collapsepicbox.Image = Properties.Resources.output_onlinepngtools1;
            collapsepicbox.Location = new Point(119, 0);
            collapsepicbox.Name = "collapsepicbox";
            collapsepicbox.Size = new Size(24, 26);
            collapsepicbox.SizeMode = PictureBoxSizeMode.StretchImage;
            collapsepicbox.TabIndex = 3;
            collapsepicbox.TabStop = false;
            collapsepicbox.Click += collapsepicbox_Click;
            collapsepicbox.MouseEnter += collapsepicbox_MouseEnter_1;
            collapsepicbox.MouseLeave += collapsepicbox_MouseLeave;
            // 
            // selectionpnl
            // 
            selectionpnl.BackColor = Color.FromArgb(0, 126, 249);
            selectionpnl.Location = new Point(12, 169);
            selectionpnl.Name = "selectionpnl";
            selectionpnl.Size = new Size(2, 40);
            selectionpnl.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(expandpicbox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(152, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(1052, 529);
            panel1.TabIndex = 3;
            // 
            // expandpicbox
            // 
            expandpicbox.Image = Properties.Resources.output_onlinepngtools1;
            expandpicbox.Location = new Point(3, -3);
            expandpicbox.Name = "expandpicbox";
            expandpicbox.Size = new Size(26, 26);
            expandpicbox.SizeMode = PictureBoxSizeMode.StretchImage;
            expandpicbox.TabIndex = 4;
            expandpicbox.TabStop = false;
            expandpicbox.Visible = false;
            expandpicbox.Click += expandpicbox_Click;
            // 
            // ManualInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1207, 612);
            Controls.Add(manualTablepnl);
            Name = "ManualInput";
            Text = "Form1";
            Load += Form1_Load;
            manualTablepnl.ResumeLayout(false);
            HomePageheader.ResumeLayout(false);
            HomePageheader.PerformLayout();
            dashpnl.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)collapsepicbox).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)expandpicbox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel manualTablepnl;
        private Panel HomePageheader;
        private Button DisplayBoardbtn;
        private Button ManualInputbtn;
        private Button EditPartsbtn;
        private Button AgedWIPbtn;
        private Label Titlelbl;
        private Button WIPTrackerbtn;
        private Panel dashpnl;
        private PictureBox collapsepicbox;
        private PictureBox expandpicbox;
        private Panel panel1;
        private Button HomeAreabtn;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label usernamelbl;
        private Button button5;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Label label1;
        private Panel selectionpnl;
    }
}