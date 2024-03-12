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
            Bodypnl = new Panel();
            expandpicbox = new PictureBox();
            InnerBodypnl = new Panel();
            dashpnl = new Panel();
            Settingsbtn = new Button();
            DisplayBoardbtn = new Button();
            ManualInputbtn = new Button();
            EditPartsbtn = new Button();
            AgedWIPbtn = new Button();
            WIPTrackerbtn = new Button();
            HomePagebtn = new Button();
            Usernamepnl = new Panel();
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
            selectionpnl.SuspendLayout();
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
            expandpicbox.Image = Properties.Resources.output_onlinepngtools1;
            expandpicbox.Location = new Point(3, 1);
            expandpicbox.Name = "expandpicbox";
            expandpicbox.Size = new Size(26, 26);
            expandpicbox.SizeMode = PictureBoxSizeMode.StretchImage;
            expandpicbox.TabIndex = 4;
            expandpicbox.TabStop = false;
            expandpicbox.Visible = false;
            expandpicbox.Click += expandpicbox_Click;
            expandpicbox.MouseEnter += enlargeImage;
            expandpicbox.MouseLeave += shrinkImage;
            // 
            // InnerBodypnl
            // 
            InnerBodypnl.Dock = DockStyle.Fill;
            InnerBodypnl.Location = new Point(0, 0);
            InnerBodypnl.Name = "InnerBodypnl";
            InnerBodypnl.Size = new Size(1052, 606);
            InnerBodypnl.TabIndex = 5;
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
            dashpnl.Controls.Add(HomePagebtn);
            dashpnl.Controls.Add(Usernamepnl);
            dashpnl.Controls.Add(selectionpnl);
            dashpnl.Dock = DockStyle.Left;
            dashpnl.Location = new Point(0, 0);
            dashpnl.Margin = new Padding(0);
            dashpnl.Name = "dashpnl";
            dashpnl.Size = new Size(149, 612);
            dashpnl.TabIndex = 2;
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
            Settingsbtn.Location = new Point(0, 572);
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
            // HomePagebtn
            // 
            HomePagebtn.BackgroundImageLayout = ImageLayout.Stretch;
            HomePagebtn.Dock = DockStyle.Top;
            HomePagebtn.FlatAppearance.BorderSize = 0;
            HomePagebtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            HomePagebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 51, 73);
            HomePagebtn.FlatStyle = FlatStyle.Flat;
            HomePagebtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            HomePagebtn.ForeColor = Color.FromArgb(0, 126, 249);
            HomePagebtn.ImageAlign = ContentAlignment.MiddleLeft;
            HomePagebtn.Location = new Point(0, 113);
            HomePagebtn.Name = "HomePagebtn";
            HomePagebtn.Size = new Size(149, 40);
            HomePagebtn.TabIndex = 9;
            HomePagebtn.Text = "Home Area";
            HomePagebtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            HomePagebtn.UseVisualStyleBackColor = true;
            HomePagebtn.Click += HomeAreabtn_Click;
            HomePagebtn.MouseEnter += hoverButton;
            HomePagebtn.MouseLeave += unHoverButton;
            // 
            // Usernamepnl
            // 
            Usernamepnl.Controls.Add(timePeriodlbl);
            Usernamepnl.Controls.Add(collapsepicbox);
            Usernamepnl.Controls.Add(userimagepicbox);
            Usernamepnl.Controls.Add(usernamelbl);
            Usernamepnl.Dock = DockStyle.Top;
            Usernamepnl.Location = new Point(0, 0);
            Usernamepnl.Name = "Usernamepnl";
            Usernamepnl.Size = new Size(149, 113);
            Usernamepnl.TabIndex = 4;
            // 
            // timePeriodlbl
            // 
            timePeriodlbl.AutoSize = true;
            timePeriodlbl.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            timePeriodlbl.ForeColor = Color.FromArgb(0, 126, 249);
            timePeriodlbl.Location = new Point(1, 98);
            timePeriodlbl.Name = "timePeriodlbl";
            timePeriodlbl.Size = new Size(67, 12);
            timePeriodlbl.TabIndex = 8;
            timePeriodlbl.Text = "Current Period:";
            // 
            // collapsepicbox
            // 
            collapsepicbox.Image = Properties.Resources.output_onlinepngtools1;
            collapsepicbox.Location = new Point(117, 4);
            collapsepicbox.Name = "collapsepicbox";
            collapsepicbox.Size = new Size(24, 26);
            collapsepicbox.SizeMode = PictureBoxSizeMode.StretchImage;
            collapsepicbox.TabIndex = 7;
            collapsepicbox.TabStop = false;
            collapsepicbox.Click += collapsepicbox_Click;
            collapsepicbox.MouseEnter += enlargeImage;
            collapsepicbox.MouseLeave += shrinkImage;
            // 
            // userimagepicbox
            // 
            userimagepicbox.Image = Properties.Resources.output_onlinepngtools__2_;
            userimagepicbox.Location = new Point(45, 7);
            userimagepicbox.Name = "userimagepicbox";
            userimagepicbox.Size = new Size(63, 63);
            userimagepicbox.SizeMode = PictureBoxSizeMode.StretchImage;
            userimagepicbox.TabIndex = 5;
            userimagepicbox.TabStop = false;
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
            Name = "HomePage";
            Text = "Form1";
            Load += Form1_Load;
            Bodypnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)expandpicbox).EndInit();
            dashpnl.ResumeLayout(false);
            Usernamepnl.ResumeLayout(false);
            Usernamepnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)collapsepicbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)userimagepicbox).EndInit();
            selectionpnl.ResumeLayout(false);
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
        private Button ManualInputbtn;
        private Button EditPartsbtn;
        private Button AgedWIPbtn;
        private Button WIPTrackerbtn;
        private Button HomePagebtn;
        private Panel Usernamepnl;
        private Label timePeriodlbl;
        private PictureBox userimagepicbox;
        private Label usernamelbl;
        private PictureBox collapsepicbox;
        private Panel selectionpnl;
        private Panel currentFormpnl;
        private TableLayoutPanel manualTablepnl;
        private Button Settingsbtn;
        private PictureBox expandpicbox;
        private Panel InnerBodypnl;
    }
}