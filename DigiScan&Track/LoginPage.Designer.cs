namespace DigiScan_Track
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            oldUserpnl = new Panel();
            ouPasswordtxt = new TextBox();
            ouUsernametxt = new TextBox();
            registerLinklbl = new Label();
            newUserlbl = new Label();
            clearFieldslbl = new Label();
            loginbtn = new Button();
            divider4pnl = new FlowLayoutPanel();
            ouPasswordpbox = new PictureBox();
            divider5pnl = new FlowLayoutPanel();
            ouUsernamepbox = new PictureBox();
            loginlbl = new Label();
            ouLogopbox = new PictureBox();
            newUserpnl = new Panel();
            retypePasswordtxt = new TextBox();
            dividerpnl = new FlowLayoutPanel();
            retypepbox = new PictureBox();
            employeeIDtxt = new TextBox();
            divider1pnl = new FlowLayoutPanel();
            employeeIDpbox = new PictureBox();
            passwordtxt = new TextBox();
            fullNametxt = new TextBox();
            signInLinklbl = new Label();
            concurrentUserlbl = new Label();
            clearLabels1lbl = new Label();
            createLoginbtn = new Button();
            divider2pnl = new FlowLayoutPanel();
            passwordpbox = new PictureBox();
            divider3pnl = new FlowLayoutPanel();
            fullNamepbox = new PictureBox();
            enterDetailslbl = new Label();
            logopbox = new PictureBox();
            oldUserpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ouPasswordpbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ouUsernamepbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ouLogopbox).BeginInit();
            newUserpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)retypepbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeIDpbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordpbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fullNamepbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logopbox).BeginInit();
            SuspendLayout();
            // 
            // oldUserpnl
            // 
            oldUserpnl.BackColor = Color.White;
            oldUserpnl.Controls.Add(ouPasswordtxt);
            oldUserpnl.Controls.Add(ouUsernametxt);
            oldUserpnl.Controls.Add(registerLinklbl);
            oldUserpnl.Controls.Add(newUserlbl);
            oldUserpnl.Controls.Add(clearFieldslbl);
            oldUserpnl.Controls.Add(loginbtn);
            oldUserpnl.Controls.Add(divider4pnl);
            oldUserpnl.Controls.Add(ouPasswordpbox);
            oldUserpnl.Controls.Add(divider5pnl);
            oldUserpnl.Controls.Add(ouUsernamepbox);
            oldUserpnl.Controls.Add(loginlbl);
            oldUserpnl.Controls.Add(ouLogopbox);
            oldUserpnl.Location = new Point(376, 45);
            oldUserpnl.Name = "oldUserpnl";
            oldUserpnl.Size = new Size(310, 490);
            oldUserpnl.TabIndex = 0;
            // 
            // ouPasswordtxt
            // 
            ouPasswordtxt.BorderStyle = BorderStyle.None;
            ouPasswordtxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ouPasswordtxt.ForeColor = Color.RosyBrown;
            ouPasswordtxt.Location = new Point(87, 325);
            ouPasswordtxt.Name = "ouPasswordtxt";
            ouPasswordtxt.PlaceholderText = "Password";
            ouPasswordtxt.Size = new Size(169, 18);
            ouPasswordtxt.TabIndex = 12;
            ouPasswordtxt.Tag = "Password";
            ouPasswordtxt.UseSystemPasswordChar = true;
            // 
            // ouUsernametxt
            // 
            ouUsernametxt.BorderStyle = BorderStyle.None;
            ouUsernametxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ouUsernametxt.ForeColor = Color.RosyBrown;
            ouUsernametxt.Location = new Point(87, 260);
            ouUsernametxt.Multiline = true;
            ouUsernametxt.Name = "ouUsernametxt";
            ouUsernametxt.PlaceholderText = "Username";
            ouUsernametxt.Size = new Size(169, 23);
            ouUsernametxt.TabIndex = 11;
            ouUsernametxt.Tag = "Username";
            // 
            // registerLinklbl
            // 
            registerLinklbl.AutoSize = true;
            registerLinklbl.Cursor = Cursors.Hand;
            registerLinklbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            registerLinklbl.ForeColor = Color.Coral;
            registerLinklbl.Location = new Point(157, 442);
            registerLinklbl.Name = "registerLinklbl";
            registerLinklbl.Size = new Size(66, 16);
            registerLinklbl.TabIndex = 10;
            registerLinklbl.Text = "Register";
            registerLinklbl.Click += RegisterLinklbl_Click;
            // 
            // newUserlbl
            // 
            newUserlbl.AutoSize = true;
            newUserlbl.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            newUserlbl.ForeColor = Color.FromArgb(0, 126, 249);
            newUserlbl.Location = new Point(90, 441);
            newUserlbl.Name = "newUserlbl";
            newUserlbl.Size = new Size(72, 17);
            newUserlbl.TabIndex = 9;
            newUserlbl.Text = "New User?";
            // 
            // clearFieldslbl
            // 
            clearFieldslbl.AutoSize = true;
            clearFieldslbl.Cursor = Cursors.Hand;
            clearFieldslbl.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            clearFieldslbl.ForeColor = Color.FromArgb(0, 126, 249);
            clearFieldslbl.Location = new Point(183, 372);
            clearFieldslbl.Name = "clearFieldslbl";
            clearFieldslbl.Size = new Size(76, 17);
            clearFieldslbl.TabIndex = 8;
            clearFieldslbl.Text = "Clear Fields";
            clearFieldslbl.Click += ClearFieldslbl_Click;
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.FromArgb(61, 154, 226);
            loginbtn.Cursor = Cursors.Hand;
            loginbtn.FlatStyle = FlatStyle.Flat;
            loginbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            loginbtn.ForeColor = Color.White;
            loginbtn.Location = new Point(56, 388);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(200, 33);
            loginbtn.TabIndex = 7;
            loginbtn.Text = "LOG IN";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += Loginbtn_Click;
            // 
            // divider4pnl
            // 
            divider4pnl.BackColor = Color.Black;
            divider4pnl.Location = new Point(56, 350);
            divider4pnl.Name = "divider4pnl";
            divider4pnl.Size = new Size(200, 1);
            divider4pnl.TabIndex = 6;
            // 
            // ouPasswordpbox
            // 
            ouPasswordpbox.Image = (Image)resources.GetObject("ouPasswordpbox.Image");
            ouPasswordpbox.Location = new Point(54, 319);
            ouPasswordpbox.Name = "ouPasswordpbox";
            ouPasswordpbox.Size = new Size(30, 30);
            ouPasswordpbox.SizeMode = PictureBoxSizeMode.Zoom;
            ouPasswordpbox.TabIndex = 5;
            ouPasswordpbox.TabStop = false;
            // 
            // divider5pnl
            // 
            divider5pnl.BackColor = Color.Black;
            divider5pnl.Location = new Point(56, 286);
            divider5pnl.Name = "divider5pnl";
            divider5pnl.Size = new Size(200, 1);
            divider5pnl.TabIndex = 4;
            // 
            // ouUsernamepbox
            // 
            ouUsernamepbox.Image = (Image)resources.GetObject("ouUsernamepbox.Image");
            ouUsernamepbox.Location = new Point(56, 255);
            ouUsernamepbox.Name = "ouUsernamepbox";
            ouUsernamepbox.Size = new Size(25, 25);
            ouUsernamepbox.SizeMode = PictureBoxSizeMode.Zoom;
            ouUsernamepbox.TabIndex = 3;
            ouUsernamepbox.TabStop = false;
            // 
            // loginlbl
            // 
            loginlbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            loginlbl.ForeColor = Color.Coral;
            loginlbl.ImageAlign = ContentAlignment.MiddleRight;
            loginlbl.Location = new Point(60, 146);
            loginlbl.Name = "loginlbl";
            loginlbl.Size = new Size(210, 36);
            loginlbl.TabIndex = 2;
            loginlbl.Text = "ENTER LOGIN BELOW";
            loginlbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ouLogopbox
            // 
            ouLogopbox.Image = (Image)resources.GetObject("ouLogopbox.Image");
            ouLogopbox.Location = new Point(90, 31);
            ouLogopbox.Name = "ouLogopbox";
            ouLogopbox.Size = new Size(140, 100);
            ouLogopbox.SizeMode = PictureBoxSizeMode.Zoom;
            ouLogopbox.TabIndex = 0;
            ouLogopbox.TabStop = false;
            // 
            // newUserpnl
            // 
            newUserpnl.BackColor = Color.White;
            newUserpnl.Controls.Add(retypePasswordtxt);
            newUserpnl.Controls.Add(dividerpnl);
            newUserpnl.Controls.Add(retypepbox);
            newUserpnl.Controls.Add(employeeIDtxt);
            newUserpnl.Controls.Add(divider1pnl);
            newUserpnl.Controls.Add(employeeIDpbox);
            newUserpnl.Controls.Add(passwordtxt);
            newUserpnl.Controls.Add(fullNametxt);
            newUserpnl.Controls.Add(signInLinklbl);
            newUserpnl.Controls.Add(concurrentUserlbl);
            newUserpnl.Controls.Add(clearLabels1lbl);
            newUserpnl.Controls.Add(createLoginbtn);
            newUserpnl.Controls.Add(divider2pnl);
            newUserpnl.Controls.Add(passwordpbox);
            newUserpnl.Controls.Add(divider3pnl);
            newUserpnl.Controls.Add(fullNamepbox);
            newUserpnl.Controls.Add(enterDetailslbl);
            newUserpnl.Controls.Add(logopbox);
            newUserpnl.Location = new Point(376, 45);
            newUserpnl.Name = "newUserpnl";
            newUserpnl.Size = new Size(310, 490);
            newUserpnl.TabIndex = 13;
            newUserpnl.Visible = false;
            // 
            // retypePasswordtxt
            // 
            retypePasswordtxt.BorderStyle = BorderStyle.None;
            retypePasswordtxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            retypePasswordtxt.ForeColor = Color.RosyBrown;
            retypePasswordtxt.Location = new Point(87, 337);
            retypePasswordtxt.Name = "retypePasswordtxt";
            retypePasswordtxt.PlaceholderText = "Retype Password";
            retypePasswordtxt.Size = new Size(169, 18);
            retypePasswordtxt.TabIndex = 18;
            retypePasswordtxt.Tag = "Retype Password";
            retypePasswordtxt.UseSystemPasswordChar = true;
            // 
            // dividerpnl
            // 
            dividerpnl.BackColor = Color.Black;
            dividerpnl.Location = new Point(56, 362);
            dividerpnl.Name = "dividerpnl";
            dividerpnl.Size = new Size(200, 1);
            dividerpnl.TabIndex = 17;
            // 
            // retypepbox
            // 
            retypepbox.Image = (Image)resources.GetObject("retypepbox.Image");
            retypepbox.Location = new Point(54, 331);
            retypepbox.Name = "retypepbox";
            retypepbox.Size = new Size(30, 30);
            retypepbox.SizeMode = PictureBoxSizeMode.Zoom;
            retypepbox.TabIndex = 16;
            retypepbox.TabStop = false;
            // 
            // employeeIDtxt
            // 
            employeeIDtxt.BorderStyle = BorderStyle.None;
            employeeIDtxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            employeeIDtxt.ForeColor = Color.RosyBrown;
            employeeIDtxt.Location = new Point(87, 251);
            employeeIDtxt.Multiline = true;
            employeeIDtxt.Name = "employeeIDtxt";
            employeeIDtxt.PlaceholderText = "Employee ID";
            employeeIDtxt.Size = new Size(169, 23);
            employeeIDtxt.TabIndex = 15;
            employeeIDtxt.Tag = "Employee ID";
            // 
            // divider1pnl
            // 
            divider1pnl.BackColor = Color.Black;
            divider1pnl.Location = new Point(56, 275);
            divider1pnl.Name = "divider1pnl";
            divider1pnl.Size = new Size(200, 1);
            divider1pnl.TabIndex = 14;
            // 
            // employeeIDpbox
            // 
            employeeIDpbox.Image = (Image)resources.GetObject("employeeIDpbox.Image");
            employeeIDpbox.Location = new Point(56, 244);
            employeeIDpbox.Name = "employeeIDpbox";
            employeeIDpbox.Size = new Size(25, 25);
            employeeIDpbox.SizeMode = PictureBoxSizeMode.Zoom;
            employeeIDpbox.TabIndex = 13;
            employeeIDpbox.TabStop = false;
            // 
            // passwordtxt
            // 
            passwordtxt.BorderStyle = BorderStyle.None;
            passwordtxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            passwordtxt.ForeColor = Color.RosyBrown;
            passwordtxt.Location = new Point(87, 292);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.PlaceholderText = "Password";
            passwordtxt.Size = new Size(169, 18);
            passwordtxt.TabIndex = 12;
            passwordtxt.Tag = "Password";
            passwordtxt.UseSystemPasswordChar = true;
            // 
            // fullNametxt
            // 
            fullNametxt.BorderStyle = BorderStyle.None;
            fullNametxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            fullNametxt.ForeColor = Color.RosyBrown;
            fullNametxt.Location = new Point(87, 204);
            fullNametxt.Multiline = true;
            fullNametxt.Name = "fullNametxt";
            fullNametxt.PlaceholderText = "Full Name";
            fullNametxt.Size = new Size(169, 23);
            fullNametxt.TabIndex = 11;
            fullNametxt.Tag = "Full Name";
            // 
            // signInLinklbl
            // 
            signInLinklbl.AutoSize = true;
            signInLinklbl.Cursor = Cursors.Hand;
            signInLinklbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            signInLinklbl.ForeColor = Color.Coral;
            signInLinklbl.Location = new Point(171, 442);
            signInLinklbl.Name = "signInLinklbl";
            signInLinklbl.Size = new Size(54, 16);
            signInLinklbl.TabIndex = 10;
            signInLinklbl.Text = "Sign In";
            signInLinklbl.Click += SignInLinklbl_Click;
            // 
            // concurrentUserlbl
            // 
            concurrentUserlbl.AutoSize = true;
            concurrentUserlbl.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            concurrentUserlbl.ForeColor = Color.FromArgb(0, 126, 249);
            concurrentUserlbl.Location = new Point(74, 441);
            concurrentUserlbl.Name = "concurrentUserlbl";
            concurrentUserlbl.Size = new Size(102, 17);
            concurrentUserlbl.TabIndex = 9;
            concurrentUserlbl.Text = "Already a User?";
            // 
            // clearLabels1lbl
            // 
            clearLabels1lbl.AutoSize = true;
            clearLabels1lbl.Cursor = Cursors.Hand;
            clearLabels1lbl.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            clearLabels1lbl.ForeColor = Color.FromArgb(0, 126, 249);
            clearLabels1lbl.Location = new Point(183, 372);
            clearLabels1lbl.Name = "clearLabels1lbl";
            clearLabels1lbl.Size = new Size(76, 17);
            clearLabels1lbl.TabIndex = 8;
            clearLabels1lbl.Text = "Clear Fields";
            clearLabels1lbl.Click += ClearFieldslbl_Click;
            // 
            // createLoginbtn
            // 
            createLoginbtn.BackColor = Color.FromArgb(61, 154, 226);
            createLoginbtn.Cursor = Cursors.Hand;
            createLoginbtn.FlatStyle = FlatStyle.Flat;
            createLoginbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            createLoginbtn.ForeColor = Color.White;
            createLoginbtn.Location = new Point(56, 388);
            createLoginbtn.Name = "createLoginbtn";
            createLoginbtn.Size = new Size(200, 33);
            createLoginbtn.TabIndex = 7;
            createLoginbtn.Text = "CREATE LOGIN";
            createLoginbtn.UseVisualStyleBackColor = false;
            createLoginbtn.Click += CreateLoginbtn_Click;
            // 
            // divider2pnl
            // 
            divider2pnl.BackColor = Color.Black;
            divider2pnl.Location = new Point(56, 317);
            divider2pnl.Name = "divider2pnl";
            divider2pnl.Size = new Size(200, 1);
            divider2pnl.TabIndex = 6;
            // 
            // passwordpbox
            // 
            passwordpbox.Image = (Image)resources.GetObject("passwordpbox.Image");
            passwordpbox.Location = new Point(54, 286);
            passwordpbox.Name = "passwordpbox";
            passwordpbox.Size = new Size(30, 30);
            passwordpbox.SizeMode = PictureBoxSizeMode.Zoom;
            passwordpbox.TabIndex = 5;
            passwordpbox.TabStop = false;
            // 
            // divider3pnl
            // 
            divider3pnl.BackColor = Color.Black;
            divider3pnl.Location = new Point(56, 228);
            divider3pnl.Name = "divider3pnl";
            divider3pnl.Size = new Size(200, 1);
            divider3pnl.TabIndex = 4;
            // 
            // fullNamepbox
            // 
            fullNamepbox.Image = (Image)resources.GetObject("fullNamepbox.Image");
            fullNamepbox.Location = new Point(56, 197);
            fullNamepbox.Name = "fullNamepbox";
            fullNamepbox.Size = new Size(25, 25);
            fullNamepbox.SizeMode = PictureBoxSizeMode.Zoom;
            fullNamepbox.TabIndex = 3;
            fullNamepbox.TabStop = false;
            // 
            // enterDetailslbl
            // 
            enterDetailslbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            enterDetailslbl.ForeColor = Color.Coral;
            enterDetailslbl.ImageAlign = ContentAlignment.MiddleRight;
            enterDetailslbl.Location = new Point(54, 146);
            enterDetailslbl.Name = "enterDetailslbl";
            enterDetailslbl.Size = new Size(221, 36);
            enterDetailslbl.TabIndex = 2;
            enterDetailslbl.Text = "ENTER DETAILS BELOW";
            enterDetailslbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logopbox
            // 
            logopbox.Image = (Image)resources.GetObject("logopbox.Image");
            logopbox.Location = new Point(90, 31);
            logopbox.Name = "logopbox";
            logopbox.Size = new Size(140, 100);
            logopbox.SizeMode = PictureBoxSizeMode.Zoom;
            logopbox.TabIndex = 0;
            logopbox.TabStop = false;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1052, 609);
            Controls.Add(newUserpnl);
            Controls.Add(oldUserpnl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginPage";
            Text = "Form1";
            oldUserpnl.ResumeLayout(false);
            oldUserpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ouPasswordpbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ouUsernamepbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ouLogopbox).EndInit();
            newUserpnl.ResumeLayout(false);
            newUserpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)retypepbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeIDpbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordpbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)fullNamepbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)logopbox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel oldUserpnl;
        private PictureBox ouLogopbox;
        private FlowLayoutPanel divider4pnl;
        private FlowLayoutPanel divider5pnl;
        private PictureBox ouUsernamepbox;
        private Label loginlbl;
        private PictureBox ouPasswordpbox;
        private Button loginbtn;
        private Label clearFieldslbl;
        private TextBox ouPasswordtxt;
        private TextBox ouUsernametxt;
        private Label registerLinklbl;
        private Label newUserlbl;
        private Panel newUserpnl;
        private TextBox passwordtxt;
        private TextBox fullNametxt;
        private Label signInLinklbl;
        private Label concurrentUserlbl;
        private Label clearLabels1lbl;
        private Button createLoginbtn;
        private FlowLayoutPanel divider2pnl;
        private PictureBox passwordpbox;
        private FlowLayoutPanel divider3pnl;
        private PictureBox fullNamepbox;
        private Label enterDetailslbl;
        private PictureBox logopbox;
        private TextBox employeeIDtxt;
        private FlowLayoutPanel divider1pnl;
        private PictureBox employeeIDpbox;
        private TextBox retypePasswordtxt;
        private FlowLayoutPanel dividerpnl;
        private PictureBox retypepbox;
    }
}