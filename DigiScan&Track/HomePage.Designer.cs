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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            Bodypnl = new Panel();
            expandpicbox = new PictureBox();
            InnerBodypnl = new Panel();
            dashpnl = new Panel();
            SettingsPagebtn = new Button();
            DisplayBoardbtn = new Button();
            ManualInputbtn = new Button();
            EditPartsbtn = new Button();
            AgedWIPbtn = new Button();
            WIPTrackerbtn = new Button();
            HomePageShortcutsbtn = new Button();
            Usernamepnl = new Panel();
            loginbtn = new Button();
            periodOnlinelbl = new Label();
            timePeriodlbl = new Label();
            collapsepicbox = new PictureBox();
            userimagepicbox = new PictureBox();
            usernamelbl = new Label();
            selectionpnl = new Panel();
            currentFormpnl = new Panel();
            manualTablepnl = new TableLayoutPanel();
            Bodypnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)expandpicbox).BeginInit();
            dashpnl.SuspendLayout();
            Usernamepnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)collapsepicbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userimagepicbox).BeginInit();
            manualTablepnl.SuspendLayout();
            SuspendLayout();
            // 
            // Bodypnl
            // 
            Bodypnl.Controls.Add(expandpicbox);
            Bodypnl.Controls.Add(InnerBodypnl);
            Bodypnl.Dock = DockStyle.Fill;
            Bodypnl.Location = new Point(152, 3);
            Bodypnl.Name = "Bodypnl";
            Bodypnl.Size = new Size(1052, 606);
            Bodypnl.TabIndex = 3;
            // 
            // expandpicbox
            // 
            expandpicbox.Cursor = Cursors.PanEast;
            expandpicbox.Image = Properties.Resources.output_onlinepngtools1;
            expandpicbox.Location = new Point(3, 1);
            expandpicbox.Name = "expandpicbox";
            expandpicbox.Size = new Size(26, 26);
            expandpicbox.SizeMode = PictureBoxSizeMode.StretchImage;
            expandpicbox.TabIndex = 4;
            expandpicbox.TabStop = false;
            expandpicbox.Visible = false;
            expandpicbox.Click += Expandpicbox_Click;
            expandpicbox.MouseEnter += EnlargeImage;
            expandpicbox.MouseLeave += ShrinkImage;
            // 
            // InnerBodypnl
            // 
            InnerBodypnl.Dock = DockStyle.Fill;
            InnerBodypnl.Location = new Point(0, 0);
            InnerBodypnl.Name = "InnerBodypnl";
            InnerBodypnl.Size = new Size(1052, 606);
            InnerBodypnl.TabIndex = 5;
            InnerBodypnl.ControlAdded += InnerBodypnl_ControlAdded;
            // 
            // dashpnl
            // 
            dashpnl.BackColor = Color.FromArgb(24, 30, 54);
            dashpnl.Controls.Add(SettingsPagebtn);
            dashpnl.Controls.Add(DisplayBoardbtn);
            dashpnl.Controls.Add(ManualInputbtn);
            dashpnl.Controls.Add(EditPartsbtn);
            dashpnl.Controls.Add(AgedWIPbtn);
            dashpnl.Controls.Add(WIPTrackerbtn);
            dashpnl.Controls.Add(HomePageShortcutsbtn);
            dashpnl.Controls.Add(Usernamepnl);
            dashpnl.Controls.Add(selectionpnl);
            dashpnl.Controls.Add(currentFormpnl);
            dashpnl.Dock = DockStyle.Left;
            dashpnl.Location = new Point(0, 0);
            dashpnl.Margin = new Padding(0);
            dashpnl.Name = "dashpnl";
            dashpnl.Size = new Size(148, 612);
            dashpnl.TabIndex = 2;
            // 
            // SettingsPagebtn
            // 
            SettingsPagebtn.BackgroundImageLayout = ImageLayout.Stretch;
            SettingsPagebtn.Cursor = Cursors.Hand;
            SettingsPagebtn.Dock = DockStyle.Bottom;
            SettingsPagebtn.FlatAppearance.BorderSize = 0;
            SettingsPagebtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            SettingsPagebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 51, 73);
            SettingsPagebtn.FlatStyle = FlatStyle.Flat;
            SettingsPagebtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            SettingsPagebtn.ForeColor = Color.FromArgb(0, 126, 249);
            SettingsPagebtn.ImageAlign = ContentAlignment.MiddleLeft;
            SettingsPagebtn.Location = new Point(0, 572);
            SettingsPagebtn.Name = "SettingsPagebtn";
            SettingsPagebtn.Size = new Size(148, 40);
            SettingsPagebtn.TabIndex = 11;
            SettingsPagebtn.Text = "Settings";
            SettingsPagebtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            SettingsPagebtn.UseVisualStyleBackColor = true;
            SettingsPagebtn.Click += Settingsbtn_Click;
            // 
            // DisplayBoardbtn
            // 
            DisplayBoardbtn.BackgroundImageLayout = ImageLayout.Stretch;
            DisplayBoardbtn.Cursor = Cursors.Hand;
            DisplayBoardbtn.Dock = DockStyle.Top;
            DisplayBoardbtn.FlatAppearance.BorderSize = 0;
            DisplayBoardbtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            DisplayBoardbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 51, 73);
            DisplayBoardbtn.FlatStyle = FlatStyle.Flat;
            DisplayBoardbtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DisplayBoardbtn.ForeColor = Color.FromArgb(0, 126, 249);
            DisplayBoardbtn.ImageAlign = ContentAlignment.MiddleLeft;
            DisplayBoardbtn.Location = new Point(0, 371);
            DisplayBoardbtn.Name = "DisplayBoardbtn";
            DisplayBoardbtn.Size = new Size(148, 50);
            DisplayBoardbtn.TabIndex = 10;
            DisplayBoardbtn.Text = "Display Board";
            DisplayBoardbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            DisplayBoardbtn.UseVisualStyleBackColor = true;
            DisplayBoardbtn.Click += DisplayBoardbtn_Click;
            DisplayBoardbtn.MouseEnter += HoverButton;
            DisplayBoardbtn.MouseLeave += UnHoverButton;
            // 
            // ManualInputbtn
            // 
            ManualInputbtn.BackgroundImageLayout = ImageLayout.Stretch;
            ManualInputbtn.Cursor = Cursors.Hand;
            ManualInputbtn.Dock = DockStyle.Top;
            ManualInputbtn.FlatAppearance.BorderSize = 0;
            ManualInputbtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            ManualInputbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 51, 73);
            ManualInputbtn.FlatStyle = FlatStyle.Flat;
            ManualInputbtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ManualInputbtn.ForeColor = Color.FromArgb(0, 126, 249);
            ManualInputbtn.ImageAlign = ContentAlignment.MiddleLeft;
            ManualInputbtn.Location = new Point(0, 321);
            ManualInputbtn.Name = "ManualInputbtn";
            ManualInputbtn.Size = new Size(148, 50);
            ManualInputbtn.TabIndex = 7;
            ManualInputbtn.Text = "Manual Input";
            ManualInputbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            ManualInputbtn.UseVisualStyleBackColor = true;
            ManualInputbtn.Click += ManualInputbtn_Click;
            ManualInputbtn.MouseEnter += HoverButton;
            ManualInputbtn.MouseLeave += UnHoverButton;
            // 
            // EditPartsbtn
            // 
            EditPartsbtn.BackgroundImageLayout = ImageLayout.Stretch;
            EditPartsbtn.Cursor = Cursors.Hand;
            EditPartsbtn.Dock = DockStyle.Top;
            EditPartsbtn.FlatAppearance.BorderSize = 0;
            EditPartsbtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            EditPartsbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 51, 73);
            EditPartsbtn.FlatStyle = FlatStyle.Flat;
            EditPartsbtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            EditPartsbtn.ForeColor = Color.FromArgb(0, 126, 249);
            EditPartsbtn.ImageAlign = ContentAlignment.MiddleLeft;
            EditPartsbtn.Location = new Point(0, 271);
            EditPartsbtn.Name = "EditPartsbtn";
            EditPartsbtn.Size = new Size(148, 50);
            EditPartsbtn.TabIndex = 6;
            EditPartsbtn.Text = "Edit Parts";
            EditPartsbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            EditPartsbtn.UseVisualStyleBackColor = true;
            EditPartsbtn.Click += EditPartsbtn_Click;
            EditPartsbtn.MouseEnter += HoverButton;
            EditPartsbtn.MouseLeave += UnHoverButton;
            // 
            // AgedWIPbtn
            // 
            AgedWIPbtn.BackgroundImageLayout = ImageLayout.Stretch;
            AgedWIPbtn.Cursor = Cursors.Hand;
            AgedWIPbtn.Dock = DockStyle.Top;
            AgedWIPbtn.FlatAppearance.BorderSize = 0;
            AgedWIPbtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            AgedWIPbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 51, 73);
            AgedWIPbtn.FlatStyle = FlatStyle.Flat;
            AgedWIPbtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AgedWIPbtn.ForeColor = Color.FromArgb(0, 126, 249);
            AgedWIPbtn.ImageAlign = ContentAlignment.MiddleLeft;
            AgedWIPbtn.Location = new Point(0, 221);
            AgedWIPbtn.Name = "AgedWIPbtn";
            AgedWIPbtn.Size = new Size(148, 50);
            AgedWIPbtn.TabIndex = 8;
            AgedWIPbtn.Text = "Aged WIP";
            AgedWIPbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            AgedWIPbtn.UseVisualStyleBackColor = true;
            AgedWIPbtn.Click += AgedWIPbtn_Click;
            AgedWIPbtn.MouseEnter += HoverButton;
            AgedWIPbtn.MouseLeave += UnHoverButton;
            // 
            // WIPTrackerbtn
            // 
            WIPTrackerbtn.BackgroundImageLayout = ImageLayout.Stretch;
            WIPTrackerbtn.Cursor = Cursors.Hand;
            WIPTrackerbtn.Dock = DockStyle.Top;
            WIPTrackerbtn.FlatAppearance.BorderSize = 0;
            WIPTrackerbtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            WIPTrackerbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 51, 73);
            WIPTrackerbtn.FlatStyle = FlatStyle.Flat;
            WIPTrackerbtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            WIPTrackerbtn.ForeColor = Color.FromArgb(0, 126, 249);
            WIPTrackerbtn.ImageAlign = ContentAlignment.MiddleLeft;
            WIPTrackerbtn.Location = new Point(0, 171);
            WIPTrackerbtn.Name = "WIPTrackerbtn";
            WIPTrackerbtn.Size = new Size(148, 50);
            WIPTrackerbtn.TabIndex = 5;
            WIPTrackerbtn.Text = "WIP Tracker";
            WIPTrackerbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            WIPTrackerbtn.UseVisualStyleBackColor = true;
            WIPTrackerbtn.Click += WIPTrackerbtn_Click;
            WIPTrackerbtn.MouseEnter += HoverButton;
            WIPTrackerbtn.MouseLeave += UnHoverButton;
            // 
            // HomePageShortcutsbtn
            // 
            HomePageShortcutsbtn.BackgroundImageLayout = ImageLayout.Stretch;
            HomePageShortcutsbtn.Cursor = Cursors.Hand;
            HomePageShortcutsbtn.Dock = DockStyle.Top;
            HomePageShortcutsbtn.FlatAppearance.BorderSize = 0;
            HomePageShortcutsbtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            HomePageShortcutsbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 51, 73);
            HomePageShortcutsbtn.FlatStyle = FlatStyle.Flat;
            HomePageShortcutsbtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            HomePageShortcutsbtn.ForeColor = Color.FromArgb(0, 126, 249);
            HomePageShortcutsbtn.ImageAlign = ContentAlignment.MiddleLeft;
            HomePageShortcutsbtn.Location = new Point(0, 121);
            HomePageShortcutsbtn.Name = "HomePageShortcutsbtn";
            HomePageShortcutsbtn.Size = new Size(148, 50);
            HomePageShortcutsbtn.TabIndex = 9;
            HomePageShortcutsbtn.Text = "Home Area";
            HomePageShortcutsbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            HomePageShortcutsbtn.UseVisualStyleBackColor = true;
            HomePageShortcutsbtn.Click += HomeAreabtn_Click;
            HomePageShortcutsbtn.MouseEnter += HoverButton;
            HomePageShortcutsbtn.MouseLeave += UnHoverButton;
            // 
            // Usernamepnl
            // 
            Usernamepnl.Controls.Add(loginbtn);
            Usernamepnl.Controls.Add(periodOnlinelbl);
            Usernamepnl.Controls.Add(timePeriodlbl);
            Usernamepnl.Controls.Add(collapsepicbox);
            Usernamepnl.Controls.Add(userimagepicbox);
            Usernamepnl.Controls.Add(usernamelbl);
            Usernamepnl.Dock = DockStyle.Top;
            Usernamepnl.Location = new Point(0, 0);
            Usernamepnl.Name = "Usernamepnl";
            Usernamepnl.Size = new Size(148, 121);
            Usernamepnl.TabIndex = 4;
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.Transparent;
            loginbtn.BackgroundImage = Properties.Resources.Border;
            loginbtn.BackgroundImageLayout = ImageLayout.Stretch;
            loginbtn.Cursor = Cursors.Hand;
            loginbtn.FlatAppearance.BorderSize = 0;
            loginbtn.FlatStyle = FlatStyle.Flat;
            loginbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginbtn.ForeColor = Color.White;
            loginbtn.Location = new Point(37, 68);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(78, 34);
            loginbtn.TabIndex = 31;
            loginbtn.Text = "LOG IN";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += Loginbtn_Click;
            // 
            // periodOnlinelbl
            // 
            periodOnlinelbl.AutoSize = true;
            periodOnlinelbl.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            periodOnlinelbl.ForeColor = Color.FromArgb(0, 126, 249);
            periodOnlinelbl.Location = new Point(66, 107);
            periodOnlinelbl.Name = "periodOnlinelbl";
            periodOnlinelbl.Size = new Size(0, 12);
            periodOnlinelbl.TabIndex = 9;
            // 
            // timePeriodlbl
            // 
            timePeriodlbl.AutoSize = true;
            timePeriodlbl.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            timePeriodlbl.ForeColor = Color.FromArgb(0, 126, 249);
            timePeriodlbl.Location = new Point(1, 106);
            timePeriodlbl.Name = "timePeriodlbl";
            timePeriodlbl.Size = new Size(67, 12);
            timePeriodlbl.TabIndex = 8;
            timePeriodlbl.Text = "Current Period:";
            // 
            // collapsepicbox
            // 
            collapsepicbox.Cursor = Cursors.PanWest;
            collapsepicbox.Image = Properties.Resources.output_onlinepngtools1;
            collapsepicbox.Location = new Point(117, 4);
            collapsepicbox.Name = "collapsepicbox";
            collapsepicbox.Size = new Size(24, 26);
            collapsepicbox.SizeMode = PictureBoxSizeMode.StretchImage;
            collapsepicbox.TabIndex = 7;
            collapsepicbox.TabStop = false;
            collapsepicbox.Click += Collapsepicbox_Click;
            collapsepicbox.MouseEnter += EnlargeImage;
            collapsepicbox.MouseLeave += ShrinkImage;
            // 
            // userimagepicbox
            // 
            userimagepicbox.Image = Properties.Resources.output_onlinepngtools__2_;
            userimagepicbox.Location = new Point(45, 5);
            userimagepicbox.Name = "userimagepicbox";
            userimagepicbox.Size = new Size(63, 63);
            userimagepicbox.SizeMode = PictureBoxSizeMode.Zoom;
            userimagepicbox.TabIndex = 5;
            userimagepicbox.TabStop = false;
            // 
            // usernamelbl
            // 
            usernamelbl.AutoSize = true;
            usernamelbl.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            usernamelbl.ForeColor = Color.FromArgb(0, 126, 249);
            usernamelbl.Location = new Point(15, 73);
            usernamelbl.Name = "usernamelbl";
            usernamelbl.Size = new Size(93, 18);
            usernamelbl.TabIndex = 6;
            usernamelbl.Text = "User Name";
            usernamelbl.Visible = false;
            // 
            // selectionpnl
            // 
            selectionpnl.BackColor = Color.FromArgb(0, 126, 249);
            selectionpnl.Location = new Point(12, 169);
            selectionpnl.Name = "selectionpnl";
            selectionpnl.Size = new Size(2, 40);
            selectionpnl.TabIndex = 5;
            // 
            // currentFormpnl
            // 
            currentFormpnl.BackColor = Color.FromArgb(0, 126, 249);
            currentFormpnl.Location = new Point(3, 159);
            currentFormpnl.Name = "currentFormpnl";
            currentFormpnl.Size = new Size(2, 40);
            currentFormpnl.TabIndex = 6;
            // 
            // manualTablepnl
            // 
            manualTablepnl.ColumnCount = 2;
            manualTablepnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.34466F));
            manualTablepnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.65534F));
            manualTablepnl.Controls.Add(dashpnl, 0, 0);
            manualTablepnl.Controls.Add(Bodypnl, 1, 0);
            manualTablepnl.Dock = DockStyle.Fill;
            manualTablepnl.Location = new Point(0, 0);
            manualTablepnl.Name = "manualTablepnl";
            manualTablepnl.RowCount = 1;
            manualTablepnl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            manualTablepnl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            manualTablepnl.Size = new Size(1207, 612);
            manualTablepnl.TabIndex = 1;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1207, 612);
            Controls.Add(manualTablepnl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HomePage";
            Text = "DigiScan&Track";
            Load += Form1_Load;
            Bodypnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)expandpicbox).EndInit();
            dashpnl.ResumeLayout(false);
            Usernamepnl.ResumeLayout(false);
            Usernamepnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)collapsepicbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)userimagepicbox).EndInit();
            manualTablepnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button5;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel Bodypnl;
        private Panel dashpnl;
        private Button DisplayBoardbtn;
        private Button AgedWIPbtn;
        private Button WIPTrackerbtn;
        private Panel Usernamepnl;
        private Label timePeriodlbl;
        private PictureBox userimagepicbox;
        private Label usernamelbl;
        private PictureBox collapsepicbox;
        private Panel selectionpnl;
        private TableLayoutPanel manualTablepnl;
        private Button SettingsPagebtn;
        private PictureBox expandpicbox;
        public Button HomePageShortcutsbtn;
        public Button EditPartsbtn;
        public Button ManualInputbtn;
        public Panel InnerBodypnl;
        public Panel currentFormpnl;
        private Label periodOnlinelbl;
        private Button loginbtn;
    }
}