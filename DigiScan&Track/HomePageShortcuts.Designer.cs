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
            Shortcutlbl = new Label();
            OuterBorderpnl = new Panel();
            InnerBorderpnl = new Panel();
            HomepageImageflow = new FlowLayoutPanel();
            Departmentcmb = new ComboBox();
            Departmentlbl = new Label();
            Titlelbl = new Label();
            OuterBorderpnl.SuspendLayout();
            InnerBorderpnl.SuspendLayout();
            SuspendLayout();
            // 
            // Shortcutlbl
            // 
            Shortcutlbl.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Shortcutlbl.Location = new Point(15, 6);
            Shortcutlbl.Name = "Shortcutlbl";
            Shortcutlbl.Size = new Size(573, 35);
            Shortcutlbl.TabIndex = 11;
            Shortcutlbl.Text = "Select Shortcut to be taken to apropriate page";
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
            InnerBorderpnl.Controls.Add(HomepageImageflow);
            InnerBorderpnl.Controls.Add(Departmentcmb);
            InnerBorderpnl.Controls.Add(Shortcutlbl);
            InnerBorderpnl.Controls.Add(Departmentlbl);
            InnerBorderpnl.Location = new Point(4, 3);
            InnerBorderpnl.Name = "InnerBorderpnl";
            InnerBorderpnl.Size = new Size(1013, 522);
            InnerBorderpnl.TabIndex = 11;
            // 
            // HomepageImageflow
            // 
            HomepageImageflow.Anchor = AnchorStyles.None;
            HomepageImageflow.Location = new Point(19, 46);
            HomepageImageflow.Name = "HomepageImageflow";
            HomepageImageflow.Size = new Size(981, 460);
            HomepageImageflow.TabIndex = 13;
            // 
            // Departmentcmb
            // 
            Departmentcmb.Cursor = Cursors.Hand;
            Departmentcmb.DropDownStyle = ComboBoxStyle.DropDownList;
            Departmentcmb.FlatStyle = FlatStyle.Popup;
            Departmentcmb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Departmentcmb.ForeColor = SystemColors.InfoText;
            Departmentcmb.FormattingEnabled = true;
            Departmentcmb.Location = new Point(849, 9);
            Departmentcmb.Name = "Departmentcmb";
            Departmentcmb.Size = new Size(147, 29);
            Departmentcmb.TabIndex = 11;
            Departmentcmb.SelectedIndexChanged += Departmentcmb_SelectedIndexChanged;
            // 
            // Departmentlbl
            // 
            Departmentlbl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Departmentlbl.Location = new Point(594, 14);
            Departmentlbl.Name = "Departmentlbl";
            Departmentlbl.Size = new Size(249, 24);
            Departmentlbl.TabIndex = 12;
            Departmentlbl.Text = "Select Your Departmental Area:\r\n";
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
            Titlelbl.TabIndex = 12;
            Titlelbl.Text = "DigiScan && Track - Shortcuts\r\n";
            Titlelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HomePageShortcuts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1052, 609);
            Controls.Add(OuterBorderpnl);
            Controls.Add(Titlelbl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomePageShortcuts";
            Text = "Form1";
            Load += Form1_Load;
            OuterBorderpnl.ResumeLayout(false);
            InnerBorderpnl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button5;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label Shortcutlbl;
        private Panel OuterBorderpnl;
        private Panel InnerBorderpnl;
        private FlowLayoutPanel HomepageImageflow;
        private ComboBox Departmentcmb;
        private Label Departmentlbl;
        private Label Titlelbl;
    }
}