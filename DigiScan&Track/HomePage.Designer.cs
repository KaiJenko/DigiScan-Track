namespace DigiScan_Track
{
    partial class HomePage
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
            HomePagefooter = new Panel();
            Shortcutlbl = new Label();
            Departmentcmb = new ComboBox();
            Departmentlbl = new Label();
            HomepageImageflow = new FlowLayoutPanel();
            dashpnl = new Panel();
            Settingsbtn = new Button();
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
            currentFormpnl = new Panel();
            expandpicbox = new PictureBox();
            dashpnl.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)collapsepicbox).BeginInit();
            selectionpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)expandpicbox).BeginInit();
            SuspendLayout();
            // 
            // HomePagefooter
            // 
            HomePagefooter.BackColor = Color.DimGray;
            HomePagefooter.Location = new Point(-1, 579);
            HomePagefooter.Name = "HomePagefooter";
            HomePagefooter.Size = new Size(1212, 34);
            HomePagefooter.TabIndex = 1;
            // 
            // Shortcutlbl
            // 
            Shortcutlbl.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Shortcutlbl.Location = new Point(3, 0);
            Shortcutlbl.Name = "Shortcutlbl";
            Shortcutlbl.Size = new Size(625, 41);
            Shortcutlbl.TabIndex = 2;
            Shortcutlbl.Text = "Select Shortcut to be taken to apropriate page";
            // 
            // Departmentcmb
            // 
            Departmentcmb.Cursor = Cursors.Hand;
            Departmentcmb.DropDownStyle = ComboBoxStyle.DropDownList;
            Departmentcmb.FlatStyle = FlatStyle.Popup;
            Departmentcmb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Departmentcmb.ForeColor = SystemColors.InfoText;
            Departmentcmb.FormattingEnabled = true;
            Departmentcmb.Location = new Point(1037, 35);
            Departmentcmb.Name = "Departmentcmb";
            Departmentcmb.Size = new Size(147, 29);
            Departmentcmb.TabIndex = 3;
            Departmentcmb.SelectedIndexChanged += Departmentcmb_SelectedIndexChanged;
            // 
            // Departmentlbl
            // 
            Departmentlbl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Departmentlbl.Location = new Point(782, 40);
            Departmentlbl.Name = "Departmentlbl";
            Departmentlbl.Size = new Size(249, 24);
            Departmentlbl.TabIndex = 4;
            Departmentlbl.Text = "Select Your Departmental Area:\r\n";
            // 
            // HomepageImageflow
            // 
            HomepageImageflow.Location = new Point(183, 130);
            HomepageImageflow.Name = "HomepageImageflow";
            HomepageImageflow.Size = new Size(1001, 411);
            HomepageImageflow.TabIndex = 5;
            // 
            // dashpnl
            // 
            dashpnl.BackColor = Color.FromArgb(24, 30, 54);
            dashpnl.Controls.Add(Settingsbtn);
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
            dashpnl.Location = new Point(0, 0);
            dashpnl.Margin = new Padding(0);
            dashpnl.Name = "dashpnl";
            dashpnl.Size = new Size(149, 611);
            dashpnl.TabIndex = 6;
            // 
            // Settingsbtn
            // 
            Settingsbtn.BackgroundImageLayout = ImageLayout.Stretch;
            Settingsbtn.Dock = DockStyle.Bottom;
            Settingsbtn.FlatAppearance.BorderSize = 0;
            Settingsbtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Settingsbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 51, 73);
            Settingsbtn.FlatStyle = FlatStyle.Flat;
            Settingsbtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Settingsbtn.ForeColor = Color.FromArgb(0, 126, 249);
            Settingsbtn.ImageAlign = ContentAlignment.MiddleLeft;
            Settingsbtn.Location = new Point(0, 571);
            Settingsbtn.Name = "Settingsbtn";
            Settingsbtn.Size = new Size(149, 40);
            Settingsbtn.TabIndex = 11;
            Settingsbtn.Text = "Settings";
            Settingsbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            Settingsbtn.UseVisualStyleBackColor = true;
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
            pictureBox1.Location = new Point(117, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
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
            // 
            // selectionpnl
            // 
            selectionpnl.BackColor = Color.FromArgb(0, 126, 249);
            selectionpnl.Controls.Add(currentFormpnl);
            selectionpnl.Location = new Point(12, 169);
            selectionpnl.Name = "selectionpnl";
            selectionpnl.Size = new Size(2, 40);
            selectionpnl.TabIndex = 5;
            // 
            // currentFormpnl
            // 
            currentFormpnl.BackColor = Color.FromArgb(0, 126, 249);
            currentFormpnl.Location = new Point(0, 0);
            currentFormpnl.Name = "currentFormpnl";
            currentFormpnl.Size = new Size(2, 40);
            currentFormpnl.TabIndex = 6;
            // 
            // expandpicbox
            // 
            expandpicbox.Image = Properties.Resources.output_onlinepngtools1;
            expandpicbox.Location = new Point(155, 4);
            expandpicbox.Name = "expandpicbox";
            expandpicbox.Size = new Size(26, 26);
            expandpicbox.SizeMode = PictureBoxSizeMode.StretchImage;
            expandpicbox.TabIndex = 7;
            expandpicbox.TabStop = false;
            expandpicbox.Visible = false;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 611);
            Controls.Add(expandpicbox);
            Controls.Add(dashpnl);
            Controls.Add(HomepageImageflow);
            Controls.Add(Departmentcmb);
            Controls.Add(Shortcutlbl);
            Controls.Add(HomePagefooter);
            Controls.Add(Departmentlbl);
            Name = "HomePage";
            Text = "Form1";
            Load += Form1_Load;
            dashpnl.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)collapsepicbox).EndInit();
            selectionpnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)expandpicbox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel HomePagefooter;
        private Label Shortcutlbl;
        private ComboBox Departmentcmb;
        private Label Departmentlbl;
        private FlowLayoutPanel HomepageImageflow;
        private Panel dashpnl;
        private Button Settingsbtn;
        private Button DisplayBoardbtn;
        private Button ManualInputbtn;
        private Button EditPartsbtn;
        private Button AgedWIPbtn;
        private Button WIPTrackerbtn;
        private Button HomeAreabtn;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label usernamelbl;
        private PictureBox collapsepicbox;
        private Panel selectionpnl;
        private Panel currentFormpnl;
        private PictureBox expandpicbox;
    }
}