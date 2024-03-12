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
            Titlelbl = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            timestamptxt = new DateTimePicker();
            resetbtn = new Button();
            submitbtn = new Button();
            notestxt = new TextBox();
            noteslbl = new Label();
            reasontxt = new TextBox();
            reasonlbl = new Label();
            inputTimestamplbl = new Label();
            nocheckbox = new CheckBox();
            yescheckbox = new CheckBox();
            timestamplbl = new Label();
            workstationcmbox = new ComboBox();
            workstationlbl = new Label();
            departmentcmbox = new ComboBox();
            departmentlbl = new Label();
            lineManagertxt = new TextBox();
            lineManagerlbl = new Label();
            batchNumtxt = new TextBox();
            batchNumlbl = new Label();
            serialNumtxt = new TextBox();
            serialNumlbl = new Label();
            partNumcmbox = new ComboBox();
            partNumberlbl = new Label();
            label2 = new Label();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // Titlelbl
            // 
            Titlelbl.AutoSize = true;
            Titlelbl.BackColor = Color.Transparent;
            Titlelbl.Font = new Font("Taurus Mono Outline", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            Titlelbl.ForeColor = Color.White;
            Titlelbl.Location = new Point(140, 10);
            Titlelbl.Name = "Titlelbl";
            Titlelbl.Size = new Size(857, 47);
            Titlelbl.TabIndex = 11;
            Titlelbl.Text = "DigiScan && Track - Manual Input";
            Titlelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.FromArgb(24, 30, 54);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(16, 69);
            panel4.Name = "panel4";
            panel4.Size = new Size(1020, 528);
            panel4.TabIndex = 13;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(46, 51, 73);
            panel5.Controls.Add(timestamptxt);
            panel5.Controls.Add(resetbtn);
            panel5.Controls.Add(submitbtn);
            panel5.Controls.Add(notestxt);
            panel5.Controls.Add(noteslbl);
            panel5.Controls.Add(reasontxt);
            panel5.Controls.Add(reasonlbl);
            panel5.Controls.Add(inputTimestamplbl);
            panel5.Controls.Add(nocheckbox);
            panel5.Controls.Add(yescheckbox);
            panel5.Controls.Add(timestamplbl);
            panel5.Controls.Add(workstationcmbox);
            panel5.Controls.Add(workstationlbl);
            panel5.Controls.Add(departmentcmbox);
            panel5.Controls.Add(departmentlbl);
            panel5.Controls.Add(lineManagertxt);
            panel5.Controls.Add(lineManagerlbl);
            panel5.Controls.Add(batchNumtxt);
            panel5.Controls.Add(batchNumlbl);
            panel5.Controls.Add(serialNumtxt);
            panel5.Controls.Add(serialNumlbl);
            panel5.Controls.Add(partNumcmbox);
            panel5.Controls.Add(partNumberlbl);
            panel5.Location = new Point(4, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(1013, 522);
            panel5.TabIndex = 11;
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
            // 
            // notestxt
            // 
            notestxt.Location = new Point(667, 417);
            notestxt.Multiline = true;
            notestxt.Name = "notestxt";
            notestxt.Size = new Size(252, 61);
            notestxt.TabIndex = 29;
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
            // reasontxt
            // 
            reasontxt.Location = new Point(667, 321);
            reasontxt.Multiline = true;
            reasontxt.Name = "reasontxt";
            reasontxt.Size = new Size(252, 56);
            reasontxt.TabIndex = 27;
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
            // lineManagertxt
            // 
            lineManagertxt.Location = new Point(78, 338);
            lineManagertxt.Name = "lineManagertxt";
            lineManagertxt.Size = new Size(256, 23);
            lineManagertxt.TabIndex = 16;
            lineManagertxt.TextAlign = HorizontalAlignment.Center;
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
            // batchNumtxt
            // 
            batchNumtxt.Location = new Point(81, 245);
            batchNumtxt.Name = "batchNumtxt";
            batchNumtxt.Size = new Size(256, 23);
            batchNumtxt.TabIndex = 14;
            batchNumtxt.TextAlign = HorizontalAlignment.Center;
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
            // serialNumtxt
            // 
            serialNumtxt.Location = new Point(78, 147);
            serialNumtxt.Name = "serialNumtxt";
            serialNumtxt.Size = new Size(256, 23);
            serialNumtxt.TabIndex = 12;
            serialNumtxt.TextAlign = HorizontalAlignment.Center;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(177, 98);
            label2.Name = "label2";
            label2.Size = new Size(93, 18);
            label2.TabIndex = 12;
            label2.Text = "User Name";
            // 
            // ManualInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1052, 609);
            Controls.Add(Titlelbl);
            Controls.Add(panel4);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManualInput";
            Text = "Form1";
            Load += Form1_Load;
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button5;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label Titlelbl;
        private Panel panel4;
        private Panel panel5;
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
        private Label label2;
    }
}