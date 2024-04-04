namespace DigiScan_Track
{
    partial class SettingsPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Titlelbl = new Label();
            OuterBorderpnl = new Panel();
            InnerBorderpnl = new Panel();
            panel1 = new Panel();
            emailLinklbl = new LinkLabel();
            label1 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            OuterBorderpnl.SuspendLayout();
            InnerBorderpnl.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Titlelbl
            // 
            Titlelbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Titlelbl.BackColor = Color.Transparent;
            Titlelbl.Font = new Font("Taurus Mono Outline", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            Titlelbl.ForeColor = Color.White;
            Titlelbl.Location = new Point(149, 21);
            Titlelbl.Margin = new Padding(4, 0, 4, 0);
            Titlelbl.Name = "Titlelbl";
            Titlelbl.Size = new Size(1208, 78);
            Titlelbl.TabIndex = 15;
            Titlelbl.Text = "DigiScan && Track - Settings";
            Titlelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OuterBorderpnl
            // 
            OuterBorderpnl.Anchor = AnchorStyles.None;
            OuterBorderpnl.BackColor = Color.FromArgb(24, 30, 54);
            OuterBorderpnl.Controls.Add(InnerBorderpnl);
            OuterBorderpnl.Location = new Point(13, 104);
            OuterBorderpnl.Margin = new Padding(4, 5, 4, 5);
            OuterBorderpnl.Name = "OuterBorderpnl";
            OuterBorderpnl.Size = new Size(1457, 880);
            OuterBorderpnl.TabIndex = 16;
            // 
            // InnerBorderpnl
            // 
            InnerBorderpnl.Anchor = AnchorStyles.None;
            InnerBorderpnl.BackColor = Color.FromArgb(46, 51, 73);
            InnerBorderpnl.Controls.Add(panel1);
            InnerBorderpnl.Controls.Add(pictureBox1);
            InnerBorderpnl.Location = new Point(5, 5);
            InnerBorderpnl.Margin = new Padding(4, 5, 4, 5);
            InnerBorderpnl.Name = "InnerBorderpnl";
            InnerBorderpnl.Size = new Size(1447, 870);
            InnerBorderpnl.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Controls.Add(emailLinklbl);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(31, 92);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(620, 685);
            panel1.TabIndex = 14;
            // 
            // emailLinklbl
            // 
            emailLinklbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailLinklbl.LinkColor = Color.FromArgb(128, 255, 255);
            emailLinklbl.Location = new Point(232, 116);
            emailLinklbl.Name = "emailLinklbl";
            emailLinklbl.Size = new Size(342, 47);
            emailLinklbl.TabIndex = 16;
            emailLinklbl.TabStop = true;
            emailLinklbl.Text = "DigiScan&Track@Queries.com\r\n";
            emailLinklbl.LinkClicked += Email_LinkClicked;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(46, 51, 73);
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 116);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(240, 37);
            label1.TabIndex = 13;
            label1.Text = "For Any Queries:";
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(46, 51, 73);
            label4.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Coral;
            label4.Location = new Point(15, 9);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(190, 47);
            label4.TabIndex = 12;
            label4.Text = "Useful Links";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(24, 30, 54);
            pictureBox1.Location = new Point(26, 85);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(631, 698);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // SettingsPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1503, 1015);
            Controls.Add(OuterBorderpnl);
            Controls.Add(Titlelbl);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "SettingsPage";
            Text = "SettingsPage";
            OuterBorderpnl.ResumeLayout(false);
            InnerBorderpnl.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label Titlelbl;
        private Panel OuterBorderpnl;
        private Panel InnerBorderpnl;
        private Panel panel1;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label1;
        private LinkLabel queryEmailllbl;
        private LinkLabel emailLinklbl;
    }
}