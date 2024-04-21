namespace DigiScan_Track
{
    partial class HomePageShortcuts
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageShortcuts));
            OuterBorderpnl = new Panel();
            InnerBorderpnl = new Panel();
            Departmentcmb = new ComboBox();
            Shortcutlbl = new Label();
            Departmentlbl = new Label();
            HomepageImageflow = new FlowLayoutPanel();
            Titlelbl = new Label();
            shortcutpnl = new Panel();
            shortcutsHelppbox = new PictureBox();
            ShortcutsHelp = new ToolTip(components);
            OuterBorderpnl.SuspendLayout();
            InnerBorderpnl.SuspendLayout();
            shortcutpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)shortcutsHelppbox).BeginInit();
            SuspendLayout();
            // 
            // OuterBorderpnl
            // 
            OuterBorderpnl.Anchor = AnchorStyles.None;
            OuterBorderpnl.BackColor = Color.FromArgb(24, 30, 54);
            OuterBorderpnl.Controls.Add(InnerBorderpnl);
            OuterBorderpnl.Location = new Point(16, 69);
            OuterBorderpnl.Name = "OuterBorderpnl";
            OuterBorderpnl.Size = new Size(1020, 528);
            OuterBorderpnl.TabIndex = 11;
            // 
            // InnerBorderpnl
            // 
            InnerBorderpnl.Anchor = AnchorStyles.None;
            InnerBorderpnl.BackColor = Color.FromArgb(46, 51, 73);
            InnerBorderpnl.Controls.Add(Departmentcmb);
            InnerBorderpnl.Controls.Add(Shortcutlbl);
            InnerBorderpnl.Controls.Add(Departmentlbl);
            InnerBorderpnl.Controls.Add(HomepageImageflow);
            InnerBorderpnl.Location = new Point(4, 3);
            InnerBorderpnl.Name = "InnerBorderpnl";
            InnerBorderpnl.Size = new Size(1013, 522);
            InnerBorderpnl.TabIndex = 11;
            // 
            // Departmentcmb
            // 
            Departmentcmb.BackColor = Color.FromArgb(46, 51, 73);
            Departmentcmb.Cursor = Cursors.Hand;
            Departmentcmb.DrawMode = DrawMode.OwnerDrawFixed;
            Departmentcmb.DropDownStyle = ComboBoxStyle.DropDownList;
            Departmentcmb.FlatStyle = FlatStyle.Popup;
            Departmentcmb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Departmentcmb.ForeColor = Color.White;
            Departmentcmb.FormattingEnabled = true;
            Departmentcmb.Location = new Point(849, 21);
            Departmentcmb.Name = "Departmentcmb";
            Departmentcmb.Size = new Size(147, 30);
            Departmentcmb.TabIndex = 11;
            Departmentcmb.DrawItem += ComboBox_DrawItem;
            Departmentcmb.SelectedIndexChanged += Departmentcmb_SelectedIndexChanged;
            // 
            // Shortcutlbl
            // 
            Shortcutlbl.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Shortcutlbl.ForeColor = Color.White;
            Shortcutlbl.Location = new Point(15, 18);
            Shortcutlbl.Name = "Shortcutlbl";
            Shortcutlbl.Size = new Size(573, 35);
            Shortcutlbl.TabIndex = 11;
            Shortcutlbl.Text = "Select Shortcut to be taken to apropriate page";
            // 
            // Departmentlbl
            // 
            Departmentlbl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Departmentlbl.ForeColor = Color.White;
            Departmentlbl.Location = new Point(594, 26);
            Departmentlbl.Name = "Departmentlbl";
            Departmentlbl.Size = new Size(249, 24);
            Departmentlbl.TabIndex = 12;
            Departmentlbl.Text = "Select Your Departmental Area:\r\n";
            // 
            // HomepageImageflow
            // 
            HomepageImageflow.Anchor = AnchorStyles.None;
            HomepageImageflow.Location = new Point(19, 46);
            HomepageImageflow.Name = "HomepageImageflow";
            HomepageImageflow.Size = new Size(981, 460);
            HomepageImageflow.TabIndex = 13;
            // 
            // Titlelbl
            // 
            Titlelbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Titlelbl.BackColor = Color.Transparent;
            Titlelbl.Font = new Font("Taurus Mono Outline", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            Titlelbl.ForeColor = Color.White;
            Titlelbl.Location = new Point(116, 10);
            Titlelbl.Name = "Titlelbl";
            Titlelbl.Size = new Size(820, 47);
            Titlelbl.TabIndex = 12;
            Titlelbl.Text = "DigiScan && Track - Shortcuts\r\n";
            Titlelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // shortcutpnl
            // 
            shortcutpnl.Controls.Add(shortcutsHelppbox);
            shortcutpnl.Controls.Add(OuterBorderpnl);
            shortcutpnl.Controls.Add(Titlelbl);
            shortcutpnl.Dock = DockStyle.Fill;
            shortcutpnl.Location = new Point(0, 0);
            shortcutpnl.Margin = new Padding(2, 2, 2, 2);
            shortcutpnl.Name = "shortcutpnl";
            shortcutpnl.Size = new Size(1052, 609);
            shortcutpnl.TabIndex = 13;
            // 
            // shortcutsHelppbox
            // 
            shortcutsHelppbox.BackColor = Color.FromArgb(46, 51, 73);
            shortcutsHelppbox.Cursor = Cursors.Help;
            shortcutsHelppbox.Image = (Image)resources.GetObject("shortcutsHelppbox.Image");
            shortcutsHelppbox.Location = new Point(1015, 10);
            shortcutsHelppbox.Name = "shortcutsHelppbox";
            shortcutsHelppbox.Size = new Size(25, 25);
            shortcutsHelppbox.SizeMode = PictureBoxSizeMode.Zoom;
            shortcutsHelppbox.TabIndex = 21;
            shortcutsHelppbox.TabStop = false;
            ShortcutsHelp.SetToolTip(shortcutsHelppbox, resources.GetString("shortcutsHelppbox.ToolTip"));
            // 
            // ShortcutsHelp
            // 
            ShortcutsHelp.ToolTipIcon = ToolTipIcon.Info;
            ShortcutsHelp.ToolTipTitle = "Shortcuts Help";
            // 
            // HomePageShortcuts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1052, 609);
            Controls.Add(shortcutpnl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomePageShortcuts";
            Text = "Form1";
            Load += Form1_Load;
            OuterBorderpnl.ResumeLayout(false);
            InnerBorderpnl.ResumeLayout(false);
            shortcutpnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)shortcutsHelppbox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel OuterBorderpnl;
        private Label Titlelbl;
        private Panel InnerBorderpnl;
        private FlowLayoutPanel HomepageImageflow;
        private ComboBox Departmentcmb;
        private Label Shortcutlbl;
        private Label Departmentlbl;
        private Panel shortcutpnl;
        private PictureBox shortcutsHelppbox;
        private ToolTip ShortcutsHelp;
    }
}