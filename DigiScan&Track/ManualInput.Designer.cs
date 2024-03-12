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
            ManualInputlbl = new Label();
            BodyLayoutpnl = new Panel();
            partNumberlbl = new Label();
            partNumcmbox = new ComboBox();
            serialNumlbl = new Label();
            serialNumtxt = new TextBox();
            batchNumlbl = new Label();
            batchNumtxt = new TextBox();
            lineManagerlbl = new Label();
            lineManagertxt = new TextBox();
            departmentlbl = new Label();
            departmentcmbox = new ComboBox();
            workstationlbl = new Label();
            workstationcmbox = new ComboBox();
            timestamplbl = new Label();
            yescheckbox = new CheckBox();
            nocheckbox = new CheckBox();
            inputTimestamplbl = new Label();
            reasonlbl = new Label();
            reasontxt = new TextBox();
            noteslbl = new Label();
            notestxt = new TextBox();
            submitbtn = new Button();
            resetbtn = new Button();
            timestamptxt = new DateTimePicker();
            Borderpnl = new Panel();
            BodyLayoutpnl.SuspendLayout();
            Borderpnl.SuspendLayout();
            SuspendLayout();
            // 
            // ManualInputlbl
            // 
            ManualInputlbl.AutoSize = true;
            ManualInputlbl.BackColor = Color.Transparent;
            ManualInputlbl.Font = new Font("Taurus Mono Outline", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            ManualInputlbl.ForeColor = Color.White;
            ManualInputlbl.Location = new Point(117, 10);
            ManualInputlbl.Name = "ManualInputlbl";
            ManualInputlbl.Size = new Size(857, 47);
            ManualInputlbl.TabIndex = 11;
            ManualInputlbl.Text = "DigiScan && Track - Manual Input";
            ManualInputlbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BodyLayoutpnl
            // 
            BodyLayoutpnl.BackColor = Color.FromArgb(46, 51, 73);
            BodyLayoutpnl.Controls.Add(timestamptxt);
            BodyLayoutpnl.Controls.Add(resetbtn);
            BodyLayoutpnl.Controls.Add(submitbtn);
            BodyLayoutpnl.Controls.Add(notestxt);
            BodyLayoutpnl.Controls.Add(noteslbl);
            BodyLayoutpnl.Controls.Add(reasontxt);
            BodyLayoutpnl.Controls.Add(reasonlbl);
            BodyLayoutpnl.Controls.Add(inputTimestamplbl);
            BodyLayoutpnl.Controls.Add(nocheckbox);
            BodyLayoutpnl.Controls.Add(yescheckbox);
            BodyLayoutpnl.Controls.Add(timestamplbl);
            BodyLayoutpnl.Controls.Add(workstationcmbox);
            BodyLayoutpnl.Controls.Add(workstationlbl);
            BodyLayoutpnl.Controls.Add(departmentcmbox);
            BodyLayoutpnl.Controls.Add(departmentlbl);
            BodyLayoutpnl.Controls.Add(lineManagertxt);
            BodyLayoutpnl.Controls.Add(lineManagerlbl);
            BodyLayoutpnl.Controls.Add(batchNumtxt);
            BodyLayoutpnl.Controls.Add(batchNumlbl);
            BodyLayoutpnl.Controls.Add(serialNumtxt);
            BodyLayoutpnl.Controls.Add(serialNumlbl);
            BodyLayoutpnl.Controls.Add(partNumcmbox);
            BodyLayoutpnl.Controls.Add(partNumberlbl);
            BodyLayoutpnl.Location = new Point(4, 3);
            BodyLayoutpnl.Name = "BodyLayoutpnl";
            BodyLayoutpnl.Size = new Size(1013, 522);
            BodyLayoutpnl.TabIndex = 11;
            // 
            // partNumberlbl
            // 
            partNumberlbl.AutoSize = true;
            partNumberlbl.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            partNumberlbl.ForeColor = Color.FromArgb(0, 126, 249);
            partNumberlbl.Location = new Point(103, 28);
            partNumberlbl.Name = "partNumberlbl";
            partNumberlbl.Size = new Size(205, 24);
            partNumberlbl.TabIndex = 9;
            partNumberlbl.Text = "Select Part Number *";
            // 
            // partNumcmbox
            // 
            partNumcmbox.BackColor = Color.FromArgb(24, 30, 54);
            partNumcmbox.FlatStyle = FlatStyle.Flat;
            partNumcmbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            partNumcmbox.ForeColor = Color.White;
            partNumcmbox.FormattingEnabled = true;
            partNumcmbox.Items.AddRange(new object[] { "TY9378", "PT1456" });
            partNumcmbox.Location = new Point(125, 60);
            partNumcmbox.Name = "partNumcmbox";
            partNumcmbox.Size = new Size(155, 29);
            partNumcmbox.TabIndex = 10;
            partNumcmbox.Text = "Part Number";
            // 
            // serialNumlbl
            // 
            serialNumlbl.AutoSize = true;
            serialNumlbl.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            serialNumlbl.ForeColor = Color.FromArgb(0, 126, 249);
            serialNumlbl.Location = new Point(98, 115);
            serialNumlbl.Name = "serialNumlbl";
            serialNumlbl.Size = new Size(210, 24);
            serialNumlbl.TabIndex = 11;
            serialNumlbl.Text = "Input Serial Number *";
            // 
            // serialNumtxt
            // 
            serialNumtxt.Location = new Point(78, 147);
            serialNumtxt.Name = "serialNumtxt";
            serialNumtxt.Size = new Size(256, 23);
            serialNumtxt.TabIndex = 12;
            serialNumtxt.TextAlign = HorizontalAlignment.Center;
            // 
            // batchNumlbl
            // 
            batchNumlbl.AutoSize = true;
            batchNumlbl.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            batchNumlbl.ForeColor = Color.FromArgb(0, 126, 249);
            batchNumlbl.Location = new Point(103, 212);
            batchNumlbl.Name = "batchNumlbl";
            batchNumlbl.Size = new Size(209, 24);
            batchNumlbl.TabIndex = 13;
            batchNumlbl.Text = "Input Batch Number *";
            // 
            // batchNumtxt
            // 
            batchNumtxt.Location = new Point(81, 245);
            batchNumtxt.Name = "batchNumtxt";
            batchNumtxt.Size = new Size(256, 23);
            batchNumtxt.TabIndex = 14;
            batchNumtxt.TextAlign = HorizontalAlignment.Center;
            // 
            // lineManagerlbl
            // 
            lineManagerlbl.AutoSize = true;
            lineManagerlbl.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lineManagerlbl.ForeColor = Color.FromArgb(0, 126, 249);
            lineManagerlbl.Location = new Point(115, 301);
            lineManagerlbl.Name = "lineManagerlbl";
            lineManagerlbl.Size = new Size(190, 24);
            lineManagerlbl.TabIndex = 15;
            lineManagerlbl.Text = "Input Line Manager";
            // 
            // lineManagertxt
            // 
            lineManagertxt.Location = new Point(78, 338);
            lineManagertxt.Name = "lineManagertxt";
            lineManagertxt.Size = new Size(256, 23);
            lineManagertxt.TabIndex = 16;
            lineManagertxt.TextAlign = HorizontalAlignment.Center;
            // 
            // departmentlbl
            // 
            departmentlbl.AutoSize = true;
            departmentlbl.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            departmentlbl.ForeColor = Color.FromArgb(0, 126, 249);
            departmentlbl.Location = new Point(103, 397);
            departmentlbl.Name = "departmentlbl";
            departmentlbl.Size = new Size(195, 24);
            departmentlbl.TabIndex = 17;
            departmentlbl.Text = "Select Department *";
            // 
            // departmentcmbox
            // 
            departmentcmbox.BackColor = Color.FromArgb(24, 30, 54);
            departmentcmbox.FlatStyle = FlatStyle.Flat;
            departmentcmbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            departmentcmbox.ForeColor = Color.White;
            departmentcmbox.FormattingEnabled = true;
            departmentcmbox.Items.AddRange(new object[] { "Nacelles", "Military", "Gears" });
            departmentcmbox.Location = new Point(125, 436);
            departmentcmbox.Name = "departmentcmbox";
            departmentcmbox.Size = new Size(155, 29);
            departmentcmbox.TabIndex = 18;
            departmentcmbox.Text = "Department";
            // 
            // workstationlbl
            // 
            workstationlbl.AutoSize = true;
            workstationlbl.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            workstationlbl.ForeColor = Color.FromArgb(0, 126, 249);
            workstationlbl.Location = new Point(687, 29);
            workstationlbl.Name = "workstationlbl";
            workstationlbl.Size = new Size(196, 24);
            workstationlbl.TabIndex = 19;
            workstationlbl.Text = "Select Workstation *";
            // 
            // workstationcmbox
            // 
            workstationcmbox.BackColor = Color.FromArgb(24, 30, 54);
            workstationcmbox.FlatStyle = FlatStyle.Flat;
            workstationcmbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            workstationcmbox.ForeColor = Color.White;
            workstationcmbox.FormattingEnabled = true;
            workstationcmbox.Items.AddRange(new object[] { "TY9378", "PT1456" });
            workstationcmbox.Location = new Point(709, 60);
            workstationcmbox.Name = "workstationcmbox";
            workstationcmbox.Size = new Size(151, 29);
            workstationcmbox.TabIndex = 20;
            workstationcmbox.Text = "Workstation";
            // 
            // timestamplbl
            // 
            timestamplbl.AutoSize = true;
            timestamplbl.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            timestamplbl.ForeColor = Color.FromArgb(0, 126, 249);
            timestamplbl.Location = new Point(655, 121);
            timestamplbl.Name = "timestamplbl";
            timestamplbl.Size = new Size(294, 24);
            timestamplbl.TabIndex = 21;
            timestamplbl.Text = "Timestamp Need Backdating? \r\n";
            // 
            // yescheckbox
            // 
            yescheckbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            yescheckbox.ForeColor = Color.White;
            yescheckbox.Location = new Point(700, 152);
            yescheckbox.Name = "yescheckbox";
            yescheckbox.Size = new Size(74, 45);
            yescheckbox.TabIndex = 22;
            yescheckbox.Text = "Yes";
            yescheckbox.UseVisualStyleBackColor = true;
            yescheckbox.CheckedChanged += yescheckbox_CheckedChanged;
            // 
            // nocheckbox
            // 
            nocheckbox.Checked = true;
            nocheckbox.CheckState = CheckState.Checked;
            nocheckbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nocheckbox.ForeColor = Color.White;
            nocheckbox.Location = new Point(816, 153);
            nocheckbox.Name = "nocheckbox";
            nocheckbox.Size = new Size(74, 45);
            nocheckbox.TabIndex = 23;
            nocheckbox.Text = "No";
            nocheckbox.UseVisualStyleBackColor = true;
            nocheckbox.CheckedChanged += nocheckbox_CheckedChanged;
            // 
            // inputTimestamplbl
            // 
            inputTimestamplbl.AutoSize = true;
            inputTimestamplbl.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            inputTimestamplbl.ForeColor = Color.FromArgb(0, 126, 249);
            inputTimestamplbl.Location = new Point(709, 210);
            inputTimestamplbl.Name = "inputTimestamplbl";
            inputTimestamplbl.Size = new Size(164, 24);
            inputTimestamplbl.TabIndex = 24;
            inputTimestamplbl.Text = "Input Timestamp";
            // 
            // reasonlbl
            // 
            reasonlbl.AutoSize = true;
            reasonlbl.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            reasonlbl.ForeColor = Color.FromArgb(0, 126, 249);
            reasonlbl.Location = new Point(672, 291);
            reasonlbl.Name = "reasonlbl";
            reasonlbl.Size = new Size(251, 24);
            reasonlbl.TabIndex = 26;
            reasonlbl.Text = "Reason for Manual Input *";
            // 
            // reasontxt
            // 
            reasontxt.Location = new Point(667, 321);
            reasontxt.Multiline = true;
            reasontxt.Name = "reasontxt";
            reasontxt.Size = new Size(252, 56);
            reasontxt.TabIndex = 27;
            // 
            // noteslbl
            // 
            noteslbl.AutoSize = true;
            noteslbl.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            noteslbl.ForeColor = Color.FromArgb(0, 126, 249);
            noteslbl.Location = new Point(757, 392);
            noteslbl.Name = "noteslbl";
            noteslbl.Size = new Size(64, 24);
            noteslbl.TabIndex = 28;
            noteslbl.Text = "Notes";
            // 
            // notestxt
            // 
            notestxt.Location = new Point(667, 417);
            notestxt.Multiline = true;
            notestxt.Name = "notestxt";
            notestxt.Size = new Size(252, 61);
            notestxt.TabIndex = 29;
            // 
            // submitbtn
            // 
            submitbtn.BackColor = Color.Transparent;
            submitbtn.BackgroundImage = Properties.Resources.output_onlinepngtools__4_;
            submitbtn.BackgroundImageLayout = ImageLayout.Stretch;
            submitbtn.FlatAppearance.BorderSize = 0;
            submitbtn.FlatStyle = FlatStyle.Flat;
            submitbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            submitbtn.ForeColor = Color.White;
            submitbtn.Location = new Point(462, 153);
            submitbtn.Name = "submitbtn";
            submitbtn.Size = new Size(104, 63);
            submitbtn.TabIndex = 30;
            submitbtn.Text = "Submit Form";
            submitbtn.UseVisualStyleBackColor = false;
            submitbtn.Click += submitbtn_Click;
            // 
            // resetbtn
            // 
            resetbtn.BackColor = Color.Transparent;
            resetbtn.BackgroundImage = Properties.Resources.output_onlinepngtools__4_;
            resetbtn.BackgroundImageLayout = ImageLayout.Stretch;
            resetbtn.FlatAppearance.BorderSize = 0;
            resetbtn.FlatStyle = FlatStyle.Flat;
            resetbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            resetbtn.ForeColor = Color.White;
            resetbtn.Location = new Point(462, 245);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(104, 63);
            resetbtn.TabIndex = 31;
            resetbtn.Text = "Reset Form";
            resetbtn.UseVisualStyleBackColor = false;
            resetbtn.Click += resetbtn_Click;
            // 
            // timestamptxt
            // 
            timestamptxt.CalendarFont = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            timestamptxt.CalendarTitleBackColor = SystemColors.ControlText;
            timestamptxt.CalendarTitleForeColor = Color.AliceBlue;
            timestamptxt.CustomFormat = "dd/MM/yyyy hh:mm";
            timestamptxt.Enabled = false;
            timestamptxt.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            timestamptxt.Format = DateTimePickerFormat.Custom;
            timestamptxt.Location = new Point(695, 244);
            timestamptxt.Name = "timestamptxt";
            timestamptxt.Size = new Size(188, 27);
            timestamptxt.TabIndex = 33;
            // 
            // Borderpnl
            // 
            Borderpnl.Anchor = AnchorStyles.None;
            Borderpnl.BackColor = Color.FromArgb(24, 30, 54);
            Borderpnl.Controls.Add(BodyLayoutpnl);
            Borderpnl.Location = new Point(16, 69);
            Borderpnl.Name = "Borderpnl";
            Borderpnl.Size = new Size(1020, 528);
            Borderpnl.TabIndex = 13;
            // 
            // ManualInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1052, 609);
            Controls.Add(ManualInputlbl);
            Controls.Add(Borderpnl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManualInput";
            Text = "Form1";
            Load += Form1_Load;
            BodyLayoutpnl.ResumeLayout(false);
            BodyLayoutpnl.PerformLayout();
            Borderpnl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button5;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label ManualInputlbl;
        private Panel BodyLayoutpnl;
        private DateTimePicker timestamptxt;
        private Button resetbtn;
        private Button submitbtn;
        private TextBox notestxt;
        private Label noteslbl;
        private TextBox reasontxt;
        private Label reasonlbl;
        private Label inputTimestamplbl;
        private CheckBox nocheckbox;
        private CheckBox yescheckbox;
        private Label timestamplbl;
        private ComboBox workstationcmbox;
        private Label workstationlbl;
        private ComboBox departmentcmbox;
        private Label departmentlbl;
        private TextBox lineManagertxt;
        private Label lineManagerlbl;
        private TextBox batchNumtxt;
        private Label batchNumlbl;
        private TextBox serialNumtxt;
        private Label serialNumlbl;
        private ComboBox partNumcmbox;
        private Label partNumberlbl;
        private Panel Borderpnl;
    }
}