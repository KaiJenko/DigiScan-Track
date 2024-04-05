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
            linkspnl = new Panel();
            emailLinklbl = new LinkLabel();
            emaillbl = new Label();
            linkTitlelbl = new Label();
            pictureBox1 = new PictureBox();
            colourModelbl = new Label();
            colourSchemellbl = new LinkLabel();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            linkLabel2 = new LinkLabel();
            linkClickpnl = new PictureBox();
            OuterBorderpnl.SuspendLayout();
            InnerBorderpnl.SuspendLayout();
            linkspnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)linkClickpnl).BeginInit();
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
            InnerBorderpnl.Controls.Add(linkspnl);
            InnerBorderpnl.Controls.Add(pictureBox1);
            InnerBorderpnl.Location = new Point(5, 5);
            InnerBorderpnl.Margin = new Padding(4, 5, 4, 5);
            InnerBorderpnl.Name = "InnerBorderpnl";
            InnerBorderpnl.Size = new Size(1447, 870);
            InnerBorderpnl.TabIndex = 11;
            // 
            // linkspnl
            // 
            linkspnl.Controls.Add(linkLabel2);
            linkspnl.Controls.Add(label2);
            linkspnl.Controls.Add(linkLabel1);
            linkspnl.Controls.Add(label1);
            linkspnl.Controls.Add(colourSchemellbl);
            linkspnl.Controls.Add(colourModelbl);
            linkspnl.Controls.Add(emailLinklbl);
            linkspnl.Controls.Add(emaillbl);
            linkspnl.Controls.Add(linkTitlelbl);
            linkspnl.Controls.Add(linkClickpnl);
            linkspnl.Location = new Point(31, 91);
            linkspnl.Margin = new Padding(4, 5, 4, 5);
            linkspnl.Name = "linkspnl";
            linkspnl.Size = new Size(620, 685);
            linkspnl.TabIndex = 14;
            // 
            // emailLinklbl
            // 
            emailLinklbl.BackColor = Color.FromArgb(24, 30, 54);
            emailLinklbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailLinklbl.LinkColor = Color.FromArgb(128, 255, 255);
            emailLinklbl.Location = new Point(254, 110);
            emailLinklbl.Name = "emailLinklbl";
            emailLinklbl.Size = new Size(342, 47);
            emailLinklbl.TabIndex = 16;
            emailLinklbl.TabStop = true;
            emailLinklbl.Text = "DigiScan&Track@Queries.com\r\n";
            emailLinklbl.LinkClicked += Email_LinkClicked;
            // 
            // emaillbl
            // 
            emaillbl.BackColor = Color.FromArgb(24, 30, 54);
            emaillbl.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emaillbl.ForeColor = Color.White;
            emaillbl.Location = new Point(37, 110);
            emaillbl.Margin = new Padding(4, 0, 4, 0);
            emaillbl.Name = "emaillbl";
            emaillbl.Size = new Size(240, 37);
            emaillbl.TabIndex = 13;
            emaillbl.Text = "For Any Queries:";
            // 
            // linkTitlelbl
            // 
            linkTitlelbl.BackColor = Color.FromArgb(46, 51, 73);
            linkTitlelbl.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            linkTitlelbl.ForeColor = Color.Coral;
            linkTitlelbl.Location = new Point(15, 9);
            linkTitlelbl.Margin = new Padding(4, 0, 4, 0);
            linkTitlelbl.Name = "linkTitlelbl";
            linkTitlelbl.Size = new Size(190, 47);
            linkTitlelbl.TabIndex = 12;
            linkTitlelbl.Text = "Useful Links";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(24, 30, 54);
            pictureBox1.Location = new Point(26, 85);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(630, 698);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // colourModelbl
            // 
            colourModelbl.BackColor = Color.FromArgb(24, 30, 54);
            colourModelbl.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            colourModelbl.ForeColor = Color.White;
            colourModelbl.Location = new Point(37, 176);
            colourModelbl.Margin = new Padding(4, 0, 4, 0);
            colourModelbl.Name = "colourModelbl";
            colourModelbl.Size = new Size(296, 37);
            colourModelbl.TabIndex = 17;
            colourModelbl.Text = "Change Colour Mode:";
            // 
            // colourSchemellbl
            // 
            colourSchemellbl.BackColor = Color.FromArgb(24, 30, 54);
            colourSchemellbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            colourSchemellbl.LinkColor = Color.FromArgb(128, 255, 255);
            colourSchemellbl.Location = new Point(305, 176);
            colourSchemellbl.Name = "colourSchemellbl";
            colourSchemellbl.Size = new Size(188, 47);
            colourSchemellbl.TabIndex = 18;
            colourSchemellbl.TabStop = true;
            colourSchemellbl.Text = "Colour Schema";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(24, 30, 54);
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(37, 246);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(296, 37);
            label1.TabIndex = 19;
            label1.Text = "How to Use the App:";
            // 
            // linkLabel1
            // 
            linkLabel1.BackColor = Color.FromArgb(24, 30, 54);
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.FromArgb(128, 255, 255);
            linkLabel1.Location = new Point(290, 246);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(188, 47);
            linkLabel1.TabIndex = 20;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "App Help";
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(24, 30, 54);
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(37, 316);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(302, 37);
            label2.TabIndex = 21;
            label2.Text = "Understanding Tableau:";
            // 
            // linkLabel2
            // 
            linkLabel2.BackColor = Color.FromArgb(24, 30, 54);
            linkLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.LinkColor = Color.FromArgb(128, 255, 255);
            linkLabel2.Location = new Point(330, 316);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(188, 47);
            linkLabel2.TabIndex = 22;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Tableau Help";
            // 
            // linkClickpnl
            // 
            linkClickpnl.BackColor = Color.FromArgb(24, 30, 54);
            linkClickpnl.Location = new Point(15, 92);
            linkClickpnl.Margin = new Padding(4, 5, 4, 5);
            linkClickpnl.Name = "linkClickpnl";
            linkClickpnl.Size = new Size(588, 277);
            linkClickpnl.TabIndex = 15;
            linkClickpnl.TabStop = false;
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
            linkspnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)linkClickpnl).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label Titlelbl;
        private Panel OuterBorderpnl;
        private Panel InnerBorderpnl;
        private Panel linkspnl;
        private Label linkTitlelbl;
        private PictureBox pictureBox1;
        private Label emaillbl;
        private LinkLabel queryEmailllbl;
        private LinkLabel emailLinklbl;
        private LinkLabel colourSchemellbl;
        private Label colourModelbl;
        private LinkLabel linkLabel2;
        private Label label2;
        private LinkLabel linkLabel1;
        private Label label1;
        private PictureBox linkClickpnl;
    }
}