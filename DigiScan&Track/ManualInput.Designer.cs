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
            departmentcmbox = new ComboBox();
            lineManagertxt = new TextBox();
            lineManagerlbl = new Label();
            batchNumtxt = new TextBox();
            batchNumlbl = new Label();
            serialNumtxt = new TextBox();
            serialNumlbl = new Label();
            panel1 = new Panel();
            workstationlbl = new Label();
            partNumberlbl = new Label();
            departmentlbl = new Label();
            workstationcmbox = new ComboBox();
            partNumcmbox = new ComboBox();
            Borderpnl = new Panel();
            BodyLayoutpnl.SuspendLayout();
            panel1.SuspendLayout();
            Borderpnl.SuspendLayout();
            SuspendLayout();
            // 
            // ManualInputlbl
            // 
            ManualInputlbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ManualInputlbl.BackColor = Color.Transparent;
            ManualInputlbl.Font = new Font("Taurus Mono Outline", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            ManualInputlbl.ForeColor = Color.White;
            ManualInputlbl.Location = new Point(125, 18);
            ManualInputlbl.Margin = new Padding(4, 0, 4, 0);
            ManualInputlbl.Name = "ManualInputlbl";
            ManualInputlbl.Size = new Size(1279, 78);
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
            BodyLayoutpnl.Controls.Add(departmentcmbox);
            BodyLayoutpnl.Controls.Add(lineManagertxt);
            BodyLayoutpnl.Controls.Add(lineManagerlbl);
            BodyLayoutpnl.Controls.Add(batchNumtxt);
            BodyLayoutpnl.Controls.Add(batchNumlbl);
            BodyLayoutpnl.Controls.Add(serialNumtxt);
            BodyLayoutpnl.Controls.Add(serialNumlbl);
            BodyLayoutpnl.Controls.Add(panel1);
            BodyLayoutpnl.Location = new Point(6, 5);
            BodyLayoutpnl.Margin = new Padding(4, 5, 4, 5);
            BodyLayoutpnl.Name = "BodyLayoutpnl";
            BodyLayoutpnl.Size = new Size(1447, 870);
            BodyLayoutpnl.TabIndex = 11;
            // 
            // timestamptxt
            // 
            timestamptxt.CalendarFont = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            timestamptxt.CalendarTitleBackColor = SystemColors.ControlText;
            timestamptxt.CalendarTitleForeColor = Color.AliceBlue;
            timestamptxt.Cursor = Cursors.Hand;
            timestamptxt.CustomFormat = "dd/MM/yyyy hh:mm";
            timestamptxt.Enabled = false;
            timestamptxt.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            timestamptxt.Format = DateTimePickerFormat.Custom;
            timestamptxt.Location = new Point(584, 687);
            timestamptxt.Margin = new Padding(4, 5, 4, 5);
            timestamptxt.Name = "timestamptxt";
            timestamptxt.Size = new Size(267, 37);
            timestamptxt.TabIndex = 33;
            // 
            // resetbtn
            // 
            resetbtn.BackColor = Color.Transparent;
            resetbtn.BackgroundImage = Properties.Resources.Border;
            resetbtn.BackgroundImageLayout = ImageLayout.Stretch;
            resetbtn.Cursor = Cursors.Hand;
            resetbtn.FlatAppearance.BorderSize = 0;
            resetbtn.FlatStyle = FlatStyle.Flat;
            resetbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            resetbtn.ForeColor = Color.White;
            resetbtn.Location = new Point(741, 760);
            resetbtn.Margin = new Padding(4, 5, 4, 5);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(149, 105);
            resetbtn.TabIndex = 31;
            resetbtn.Text = "Reset Form";
            resetbtn.UseVisualStyleBackColor = false;
            resetbtn.Click += Resetbtn_Click;
            // 
            // submitbtn
            // 
            submitbtn.BackColor = Color.Transparent;
            submitbtn.BackgroundImage = Properties.Resources.Border;
            submitbtn.BackgroundImageLayout = ImageLayout.Stretch;
            submitbtn.Cursor = Cursors.Hand;
            submitbtn.FlatAppearance.BorderSize = 0;
            submitbtn.FlatStyle = FlatStyle.Flat;
            submitbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            submitbtn.ForeColor = Color.White;
            submitbtn.Location = new Point(549, 760);
            submitbtn.Margin = new Padding(4, 5, 4, 5);
            submitbtn.Name = "submitbtn";
            submitbtn.Size = new Size(149, 105);
            submitbtn.TabIndex = 30;
            submitbtn.Text = "Submit Form";
            submitbtn.UseVisualStyleBackColor = false;
            submitbtn.Click += Submitbtn_Click;
            // 
            // notestxt
            // 
            notestxt.Location = new Point(1011, 508);
            notestxt.Margin = new Padding(4, 5, 4, 5);
            notestxt.Multiline = true;
            notestxt.Name = "notestxt";
            notestxt.Size = new Size(364, 99);
            notestxt.TabIndex = 29;
            // 
            // noteslbl
            // 
            noteslbl.AutoSize = true;
            noteslbl.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            noteslbl.ForeColor = Color.FromArgb(0, 126, 249);
            noteslbl.Location = new Point(1147, 460);
            noteslbl.Margin = new Padding(4, 0, 4, 0);
            noteslbl.Name = "noteslbl";
            noteslbl.Size = new Size(96, 33);
            noteslbl.TabIndex = 28;
            noteslbl.Text = "Notes";
            // 
            // reasontxt
            // 
            reasontxt.Location = new Point(76, 508);
            reasontxt.Margin = new Padding(4, 5, 4, 5);
            reasontxt.Multiline = true;
            reasontxt.Name = "reasontxt";
            reasontxt.Size = new Size(364, 91);
            reasontxt.TabIndex = 27;
            // 
            // reasonlbl
            // 
            reasonlbl.AutoSize = true;
            reasonlbl.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            reasonlbl.ForeColor = Color.FromArgb(0, 126, 249);
            reasonlbl.Location = new Point(76, 460);
            reasonlbl.Margin = new Padding(4, 0, 4, 0);
            reasonlbl.Name = "reasonlbl";
            reasonlbl.Size = new Size(376, 33);
            reasonlbl.TabIndex = 26;
            reasonlbl.Text = "Reason for Manual Input *";
            // 
            // inputTimestamplbl
            // 
            inputTimestamplbl.AutoSize = true;
            inputTimestamplbl.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            inputTimestamplbl.ForeColor = Color.FromArgb(0, 126, 249);
            inputTimestamplbl.Location = new Point(600, 623);
            inputTimestamplbl.Margin = new Padding(4, 0, 4, 0);
            inputTimestamplbl.Name = "inputTimestamplbl";
            inputTimestamplbl.Size = new Size(248, 33);
            inputTimestamplbl.TabIndex = 24;
            inputTimestamplbl.Text = "Input Timestamp";
            // 
            // nocheckbox
            // 
            nocheckbox.Checked = true;
            nocheckbox.CheckState = CheckState.Checked;
            nocheckbox.Cursor = Cursors.Hand;
            nocheckbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nocheckbox.ForeColor = Color.White;
            nocheckbox.Location = new Point(756, 525);
            nocheckbox.Margin = new Padding(4, 5, 4, 5);
            nocheckbox.Name = "nocheckbox";
            nocheckbox.Size = new Size(106, 75);
            nocheckbox.TabIndex = 23;
            nocheckbox.Text = "No";
            nocheckbox.UseVisualStyleBackColor = true;
            nocheckbox.CheckedChanged += Nocheckbox_CheckedChanged;
            // 
            // yescheckbox
            // 
            yescheckbox.Cursor = Cursors.Hand;
            yescheckbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            yescheckbox.ForeColor = Color.White;
            yescheckbox.Location = new Point(611, 525);
            yescheckbox.Margin = new Padding(4, 5, 4, 5);
            yescheckbox.Name = "yescheckbox";
            yescheckbox.Size = new Size(106, 75);
            yescheckbox.TabIndex = 22;
            yescheckbox.Text = "Yes";
            yescheckbox.UseVisualStyleBackColor = true;
            yescheckbox.CheckedChanged += Yescheckbox_CheckedChanged;
            // 
            // timestamplbl
            // 
            timestamplbl.AutoSize = true;
            timestamplbl.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            timestamplbl.ForeColor = Color.FromArgb(0, 126, 249);
            timestamplbl.Location = new Point(516, 460);
            timestamplbl.Margin = new Padding(4, 0, 4, 0);
            timestamplbl.Name = "timestamplbl";
            timestamplbl.Size = new Size(441, 33);
            timestamplbl.TabIndex = 21;
            timestamplbl.Text = "Timestamp Need Backdating? \r\n";
            // 
            // departmentcmbox
            // 
            departmentcmbox.BackColor = Color.FromArgb(46, 51, 73);
            departmentcmbox.Cursor = Cursors.Hand;
            departmentcmbox.DrawMode = DrawMode.OwnerDrawFixed;
            departmentcmbox.DropDownStyle = ComboBoxStyle.DropDownList;
            departmentcmbox.FlatStyle = FlatStyle.Flat;
            departmentcmbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            departmentcmbox.ForeColor = Color.White;
            departmentcmbox.FormattingEnabled = true;
            departmentcmbox.Location = new Point(156, 132);
            departmentcmbox.Margin = new Padding(4, 5, 4, 5);
            departmentcmbox.Name = "departmentcmbox";
            departmentcmbox.Size = new Size(220, 40);
            departmentcmbox.TabIndex = 18;
            departmentcmbox.SelectedIndexChanged += Departmentcmbox_SelectedIndexChanged;
            // 
            // lineManagertxt
            // 
            lineManagertxt.Location = new Point(1011, 317);
            lineManagertxt.Margin = new Padding(4, 5, 4, 5);
            lineManagertxt.Name = "lineManagertxt";
            lineManagertxt.Size = new Size(364, 31);
            lineManagertxt.TabIndex = 16;
            lineManagertxt.TextAlign = HorizontalAlignment.Center;
            // 
            // lineManagerlbl
            // 
            lineManagerlbl.AutoSize = true;
            lineManagerlbl.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lineManagerlbl.ForeColor = Color.FromArgb(0, 126, 249);
            lineManagerlbl.Location = new Point(1054, 262);
            lineManagerlbl.Margin = new Padding(4, 0, 4, 0);
            lineManagerlbl.Name = "lineManagerlbl";
            lineManagerlbl.Size = new Size(282, 33);
            lineManagerlbl.TabIndex = 15;
            lineManagerlbl.Text = "Input Line Manager";
            // 
            // batchNumtxt
            // 
            batchNumtxt.Location = new Point(549, 317);
            batchNumtxt.Margin = new Padding(4, 5, 4, 5);
            batchNumtxt.Name = "batchNumtxt";
            batchNumtxt.Size = new Size(364, 31);
            batchNumtxt.TabIndex = 14;
            batchNumtxt.TextAlign = HorizontalAlignment.Center;
            // 
            // batchNumlbl
            // 
            batchNumlbl.AutoSize = true;
            batchNumlbl.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            batchNumlbl.ForeColor = Color.FromArgb(0, 126, 249);
            batchNumlbl.Location = new Point(579, 262);
            batchNumlbl.Margin = new Padding(4, 0, 4, 0);
            batchNumlbl.Name = "batchNumlbl";
            batchNumlbl.Size = new Size(312, 33);
            batchNumlbl.TabIndex = 13;
            batchNumlbl.Text = "Input Batch Number *";
            // 
            // serialNumtxt
            // 
            serialNumtxt.Location = new Point(76, 317);
            serialNumtxt.Margin = new Padding(4, 5, 4, 5);
            serialNumtxt.Name = "serialNumtxt";
            serialNumtxt.Size = new Size(364, 31);
            serialNumtxt.TabIndex = 12;
            serialNumtxt.TextAlign = HorizontalAlignment.Center;
            // 
            // serialNumlbl
            // 
            serialNumlbl.AutoSize = true;
            serialNumlbl.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            serialNumlbl.ForeColor = Color.FromArgb(0, 126, 249);
            serialNumlbl.Location = new Point(101, 262);
            serialNumlbl.Margin = new Padding(4, 0, 4, 0);
            serialNumlbl.Name = "serialNumlbl";
            serialNumlbl.Size = new Size(314, 33);
            serialNumlbl.TabIndex = 11;
            serialNumlbl.Text = "Input Serial Number *";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(workstationlbl);
            panel1.Controls.Add(partNumberlbl);
            panel1.Controls.Add(departmentlbl);
            panel1.Controls.Add(workstationcmbox);
            panel1.Controls.Add(partNumcmbox);
            panel1.Location = new Point(76, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 150);
            panel1.TabIndex = 34;
            // 
            // workstationlbl
            // 
            workstationlbl.AutoSize = true;
            workstationlbl.BackColor = Color.Transparent;
            workstationlbl.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            workstationlbl.ForeColor = Color.FromArgb(0, 126, 249);
            workstationlbl.Location = new Point(503, 25);
            workstationlbl.Margin = new Padding(4, 0, 4, 0);
            workstationlbl.Name = "workstationlbl";
            workstationlbl.Size = new Size(297, 33);
            workstationlbl.TabIndex = 19;
            workstationlbl.Text = "Select Workstation *";
            // 
            // partNumberlbl
            // 
            partNumberlbl.AutoSize = true;
            partNumberlbl.BackColor = Color.Transparent;
            partNumberlbl.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            partNumberlbl.ForeColor = Color.FromArgb(0, 126, 249);
            partNumberlbl.Location = new Point(951, 25);
            partNumberlbl.Margin = new Padding(4, 0, 4, 0);
            partNumberlbl.Name = "partNumberlbl";
            partNumberlbl.Size = new Size(308, 33);
            partNumberlbl.TabIndex = 9;
            partNumberlbl.Text = "Select Part Number *";
            // 
            // departmentlbl
            // 
            departmentlbl.AutoSize = true;
            departmentlbl.BackColor = Color.Transparent;
            departmentlbl.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            departmentlbl.ForeColor = Color.FromArgb(0, 126, 249);
            departmentlbl.Location = new Point(46, 25);
            departmentlbl.Margin = new Padding(4, 0, 4, 0);
            departmentlbl.Name = "departmentlbl";
            departmentlbl.Size = new Size(294, 33);
            departmentlbl.TabIndex = 17;
            departmentlbl.Text = "Select Department *";
            // 
            // workstationcmbox
            // 
            workstationcmbox.BackColor = Color.FromArgb(46, 51, 73);
            workstationcmbox.Cursor = Cursors.Hand;
            workstationcmbox.DrawMode = DrawMode.OwnerDrawFixed;
            workstationcmbox.DropDownStyle = ComboBoxStyle.DropDownList;
            workstationcmbox.FlatStyle = FlatStyle.Flat;
            workstationcmbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            workstationcmbox.ForeColor = Color.White;
            workstationcmbox.FormattingEnabled = true;
            workstationcmbox.Items.AddRange(new object[] { "Goods Out" });
            workstationcmbox.Location = new Point(549, 78);
            workstationcmbox.Margin = new Padding(4, 5, 4, 5);
            workstationcmbox.Name = "workstationcmbox";
            workstationcmbox.Size = new Size(214, 40);
            workstationcmbox.TabIndex = 20;
            // 
            // partNumcmbox
            // 
            partNumcmbox.BackColor = Color.FromArgb(46, 51, 73);
            partNumcmbox.Cursor = Cursors.Hand;
            partNumcmbox.DrawMode = DrawMode.OwnerDrawFixed;
            partNumcmbox.DropDownStyle = ComboBoxStyle.DropDownList;
            partNumcmbox.FlatStyle = FlatStyle.Flat;
            partNumcmbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            partNumcmbox.ForeColor = Color.White;
            partNumcmbox.FormattingEnabled = true;
            partNumcmbox.Location = new Point(996, 78);
            partNumcmbox.Margin = new Padding(4, 5, 4, 5);
            partNumcmbox.Name = "partNumcmbox";
            partNumcmbox.Size = new Size(220, 40);
            partNumcmbox.TabIndex = 10;
            // 
            // Borderpnl
            // 
            Borderpnl.Anchor = AnchorStyles.None;
            Borderpnl.BackColor = Color.FromArgb(24, 30, 54);
            Borderpnl.Controls.Add(BodyLayoutpnl);
            Borderpnl.Location = new Point(23, 115);
            Borderpnl.Margin = new Padding(4, 5, 4, 5);
            Borderpnl.Name = "Borderpnl";
            Borderpnl.Size = new Size(1457, 880);
            Borderpnl.TabIndex = 13;
            // 
            // ManualInput
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1503, 1015);
            Controls.Add(ManualInputlbl);
            Controls.Add(Borderpnl);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ManualInput";
            Text = "Form1";
            Load += Form1_Load;
            BodyLayoutpnl.ResumeLayout(false);
            BodyLayoutpnl.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Borderpnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
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
        private Panel panel1;
    }
}