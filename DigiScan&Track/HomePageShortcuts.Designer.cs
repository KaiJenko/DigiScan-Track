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
            OuterBorderpnl = new Panel();
            InnerBorderpnl = new Panel();
            Departmentcmb = new ComboBox();
            Shortcutlbl = new Label();
            Departmentlbl = new Label();
            HomepageImageflow = new FlowLayoutPanel();
            Titlelbl = new Label();
            shortcutpnl = new Panel();
            OuterBorderpnl.SuspendLayout();
            InnerBorderpnl.SuspendLayout();
            shortcutpnl.SuspendLayout();
            SuspendLayout();
            // 
            // OuterBorderpnl
            // 
            OuterBorderpnl.Anchor = AnchorStyles.None;
            OuterBorderpnl.BackColor = Color.FromArgb(24, 30, 54);
            OuterBorderpnl.Controls.Add(InnerBorderpnl);
            OuterBorderpnl.Location = new Point(23, 115);
            OuterBorderpnl.Margin = new Padding(4, 5, 4, 5);
            OuterBorderpnl.Name = "OuterBorderpnl";
            OuterBorderpnl.Size = new Size(1457, 880);
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
            InnerBorderpnl.Location = new Point(6, 5);
            InnerBorderpnl.Margin = new Padding(4, 5, 4, 5);
            InnerBorderpnl.Name = "InnerBorderpnl";
            InnerBorderpnl.Size = new Size(1447, 870);
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
            Departmentcmb.Location = new Point(1213, 35);
            Departmentcmb.Margin = new Padding(4, 5, 4, 5);
            Departmentcmb.Name = "Departmentcmb";
            Departmentcmb.Size = new Size(208, 40);
            Departmentcmb.TabIndex = 11;
            Departmentcmb.DrawItem += ComboBox_DrawItem;
            Departmentcmb.SelectedIndexChanged += Departmentcmb_SelectedIndexChanged;
            // 
            // Shortcutlbl
            // 
            Shortcutlbl.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Shortcutlbl.ForeColor = Color.White;
            Shortcutlbl.Location = new Point(21, 30);
            Shortcutlbl.Margin = new Padding(4, 0, 4, 0);
            Shortcutlbl.Name = "Shortcutlbl";
            Shortcutlbl.Size = new Size(819, 58);
            Shortcutlbl.TabIndex = 11;
            Shortcutlbl.Text = "Select Shortcut to be taken to apropriate page";
            // 
            // Departmentlbl
            // 
            Departmentlbl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Departmentlbl.ForeColor = Color.White;
            Departmentlbl.Location = new Point(849, 43);
            Departmentlbl.Margin = new Padding(4, 0, 4, 0);
            Departmentlbl.Name = "Departmentlbl";
            Departmentlbl.Size = new Size(356, 40);
            Departmentlbl.TabIndex = 12;
            Departmentlbl.Text = "Select Your Departmental Area:\r\n";
            // 
            // HomepageImageflow
            // 
            HomepageImageflow.Anchor = AnchorStyles.None;
            HomepageImageflow.Location = new Point(27, 77);
            HomepageImageflow.Margin = new Padding(4, 5, 4, 5);
            HomepageImageflow.Name = "HomepageImageflow";
            HomepageImageflow.Size = new Size(1401, 767);
            HomepageImageflow.TabIndex = 13;
            // 
            // Titlelbl
            // 
            Titlelbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Titlelbl.BackColor = Color.Transparent;
            Titlelbl.Font = new Font("Taurus Mono Outline", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            Titlelbl.ForeColor = Color.White;
            Titlelbl.Location = new Point(166, 17);
            Titlelbl.Margin = new Padding(4, 0, 4, 0);
            Titlelbl.Name = "Titlelbl";
            Titlelbl.Size = new Size(1171, 78);
            Titlelbl.TabIndex = 12;
            Titlelbl.Text = "DigiScan && Track - Shortcuts\r\n";
            Titlelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // shortcutpnl
            // 
            shortcutpnl.Controls.Add(OuterBorderpnl);
            shortcutpnl.Controls.Add(Titlelbl);
            shortcutpnl.Dock = DockStyle.Fill;
            shortcutpnl.Location = new Point(0, 0);
            shortcutpnl.Name = "shortcutpnl";
            shortcutpnl.Size = new Size(1503, 1015);
            shortcutpnl.TabIndex = 13;
            // 
            // HomePageShortcuts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1503, 1015);
            Controls.Add(shortcutpnl);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "HomePageShortcuts";
            Text = "Form1";
            Load += Form1_Load;
            OuterBorderpnl.ResumeLayout(false);
            InnerBorderpnl.ResumeLayout(false);
            shortcutpnl.ResumeLayout(false);
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
    }
}