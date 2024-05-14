namespace DigiScan_Track
{
    partial class PartEditPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            agedlbl = new Label();
            panel1 = new Panel();
            furtherDetailspnl = new Panel();
            timestamptxt = new DateTimePicker();
            usertextbox = new RichTextBox();
            richTextBox20 = new RichTextBox();
            reasonTxtbox = new RichTextBox();
            richTextBox22 = new RichTextBox();
            storagetxtbox = new RichTextBox();
            richTextBox24 = new RichTextBox();
            partTobeEditedGridView = new DataGridView();
            SearchButton = new PictureBox();
            userInputpnl = new Panel();
            storagechbox = new CheckBox();
            richTextBox15 = new RichTextBox();
            timeOutrtxt = new RichTextBox();
            richTextBox11 = new RichTextBox();
            timeInrtxt = new RichTextBox();
            richTextBox12 = new RichTextBox();
            workstationrtxt = new RichTextBox();
            richTextBox9 = new RichTextBox();
            departmentrtxt = new RichTextBox();
            richTextBox7 = new RichTextBox();
            batchNumrtxt = new RichTextBox();
            richTextBox5 = new RichTextBox();
            serialNumrtxt = new RichTextBox();
            richTextBox3 = new RichTextBox();
            partNumrtxt = new RichTextBox();
            richTextBox1 = new RichTextBox();
            furtherDetailsgridview = new DataGridView();
            richTextBoxtooltip = new ToolTip(components);
            Borderpnl = new Panel();
            panel1.SuspendLayout();
            furtherDetailspnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)partTobeEditedGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SearchButton).BeginInit();
            userInputpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)furtherDetailsgridview).BeginInit();
            SuspendLayout();
            // 
            // agedlbl
            // 
            agedlbl.AutoSize = true;
            agedlbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            agedlbl.ForeColor = Color.White;
            agedlbl.Location = new Point(17, 20);
            agedlbl.Margin = new Padding(4, 0, 4, 0);
            agedlbl.Name = "agedlbl";
            agedlbl.Size = new Size(286, 40);
            agedlbl.TabIndex = 10;
            agedlbl.Text = "Change Part Details";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 51, 73);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(furtherDetailspnl);
            panel1.Controls.Add(partTobeEditedGridView);
            panel1.Controls.Add(SearchButton);
            panel1.Controls.Add(userInputpnl);
            panel1.Controls.Add(agedlbl);
            panel1.Controls.Add(furtherDetailsgridview);
            panel1.Location = new Point(17, 127);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1409, 597);
            panel1.TabIndex = 11;
            // 
            // furtherDetailspnl
            // 
            furtherDetailspnl.BackColor = Color.FromArgb(113, 96, 232);
            furtherDetailspnl.Controls.Add(timestamptxt);
            furtherDetailspnl.Controls.Add(usertextbox);
            furtherDetailspnl.Controls.Add(richTextBox20);
            furtherDetailspnl.Controls.Add(reasonTxtbox);
            furtherDetailspnl.Controls.Add(richTextBox22);
            furtherDetailspnl.Controls.Add(storagetxtbox);
            furtherDetailspnl.Controls.Add(richTextBox24);
            furtherDetailspnl.Location = new Point(251, 416);
            furtherDetailspnl.Name = "furtherDetailspnl";
            furtherDetailspnl.Size = new Size(792, 68);
            furtherDetailspnl.TabIndex = 19;
            furtherDetailspnl.Visible = false;
            // 
            // timestamptxt
            // 
            timestamptxt.CalendarFont = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            timestamptxt.CalendarTitleBackColor = SystemColors.ControlText;
            timestamptxt.CalendarTitleForeColor = Color.AliceBlue;
            timestamptxt.Cursor = Cursors.Hand;
            timestamptxt.CustomFormat = "dd/MM/yyyy hh:mm";
            timestamptxt.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            timestamptxt.Format = DateTimePickerFormat.Custom;
            timestamptxt.Location = new Point(4, 16);
            timestamptxt.Margin = new Padding(4, 5, 4, 5);
            timestamptxt.Name = "timestamptxt";
            timestamptxt.Size = new Size(267, 37);
            timestamptxt.TabIndex = 36;
            timestamptxt.Visible = false;
            // 
            // usertextbox
            // 
            usertextbox.Anchor = AnchorStyles.None;
            usertextbox.BackColor = Color.BlanchedAlmond;
            usertextbox.BorderStyle = BorderStyle.FixedSingle;
            usertextbox.Cursor = Cursors.Hand;
            usertextbox.DetectUrls = false;
            usertextbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usertextbox.Location = new Point(567, 0);
            usertextbox.Name = "usertextbox";
            usertextbox.Size = new Size(226, 68);
            usertextbox.TabIndex = 6;
            usertextbox.Tag = "BatchNumber";
            usertextbox.Text = "";
            richTextBoxtooltip.SetToolTip(usertextbox, "User - The user who last worked on\r\n this part and entered it into storage");
            // 
            // richTextBox20
            // 
            richTextBox20.BackColor = Color.FromArgb(113, 96, 232);
            richTextBox20.BorderStyle = BorderStyle.None;
            richTextBox20.Dock = DockStyle.Left;
            richTextBox20.Location = new Point(561, 0);
            richTextBox20.Name = "richTextBox20";
            richTextBox20.Size = new Size(6, 68);
            richTextBox20.TabIndex = 4;
            richTextBox20.Text = "";
            // 
            // reasonTxtbox
            // 
            reasonTxtbox.BackColor = Color.BlanchedAlmond;
            reasonTxtbox.BorderStyle = BorderStyle.FixedSingle;
            reasonTxtbox.Cursor = Cursors.Hand;
            reasonTxtbox.Dock = DockStyle.Left;
            reasonTxtbox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            reasonTxtbox.Location = new Point(283, 0);
            reasonTxtbox.Name = "reasonTxtbox";
            reasonTxtbox.Size = new Size(278, 68);
            reasonTxtbox.TabIndex = 3;
            reasonTxtbox.Tag = "SerialNumber";
            reasonTxtbox.Text = "";
            richTextBoxtooltip.SetToolTip(reasonTxtbox, "Reason for Storage - The reason that \r\nthe part has been entered into storage ");
            // 
            // richTextBox22
            // 
            richTextBox22.BackColor = Color.FromArgb(113, 96, 232);
            richTextBox22.BorderStyle = BorderStyle.None;
            richTextBox22.Dock = DockStyle.Left;
            richTextBox22.Location = new Point(277, 0);
            richTextBox22.Name = "richTextBox22";
            richTextBox22.Size = new Size(6, 68);
            richTextBox22.TabIndex = 2;
            richTextBox22.Text = "";
            // 
            // storagetxtbox
            // 
            storagetxtbox.BackColor = Color.BlanchedAlmond;
            storagetxtbox.BorderStyle = BorderStyle.FixedSingle;
            storagetxtbox.Cursor = Cursors.Hand;
            storagetxtbox.Dock = DockStyle.Left;
            storagetxtbox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            storagetxtbox.ForeColor = Color.Coral;
            storagetxtbox.Location = new Point(0, 0);
            storagetxtbox.Name = "storagetxtbox";
            storagetxtbox.Size = new Size(277, 68);
            storagetxtbox.TabIndex = 1;
            storagetxtbox.Tag = "PartNumber";
            storagetxtbox.Text = "";
            richTextBoxtooltip.SetToolTip(storagetxtbox, "Storage Date - The date this \r\npart entered this workstation");
            // 
            // richTextBox24
            // 
            richTextBox24.BorderStyle = BorderStyle.FixedSingle;
            richTextBox24.Location = new Point(0, 0);
            richTextBox24.Name = "richTextBox24";
            richTextBox24.Size = new Size(223, 151);
            richTextBox24.TabIndex = 0;
            richTextBox24.Text = "";
            // 
            // partTobeEditedGridView
            // 
            partTobeEditedGridView.AllowUserToAddRows = false;
            partTobeEditedGridView.AllowUserToDeleteRows = false;
            partTobeEditedGridView.AllowUserToResizeColumns = false;
            partTobeEditedGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(46, 51, 73);
            partTobeEditedGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            partTobeEditedGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            partTobeEditedGridView.BackgroundColor = Color.FromArgb(46, 51, 73);
            partTobeEditedGridView.BorderStyle = BorderStyle.None;
            partTobeEditedGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            partTobeEditedGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            partTobeEditedGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            partTobeEditedGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.White;
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle13.SelectionForeColor = Color.White;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            partTobeEditedGridView.DefaultCellStyle = dataGridViewCellStyle13;
            partTobeEditedGridView.EnableHeadersVisualStyles = false;
            partTobeEditedGridView.GridColor = Color.Silver;
            partTobeEditedGridView.Location = new Point(17, 80);
            partTobeEditedGridView.Margin = new Padding(4, 5, 4, 5);
            partTobeEditedGridView.MultiSelect = false;
            partTobeEditedGridView.Name = "partTobeEditedGridView";
            partTobeEditedGridView.ReadOnly = true;
            partTobeEditedGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            partTobeEditedGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            partTobeEditedGridView.RowHeadersVisible = false;
            partTobeEditedGridView.RowHeadersWidth = 62;
            partTobeEditedGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = Color.White;
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle15.SelectionForeColor = Color.White;
            partTobeEditedGridView.RowsDefaultCellStyle = dataGridViewCellStyle15;
            partTobeEditedGridView.RowTemplate.Height = 50;
            partTobeEditedGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            partTobeEditedGridView.Size = new Size(1370, 107);
            partTobeEditedGridView.TabIndex = 30;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.Transparent;
            SearchButton.BackgroundImage = Properties.Resources.spanner;
            SearchButton.BackgroundImageLayout = ImageLayout.Stretch;
            SearchButton.Cursor = Cursors.Hand;
            SearchButton.Location = new Point(641, 497);
            SearchButton.Margin = new Padding(4, 5, 4, 5);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(80, 80);
            SearchButton.TabIndex = 23;
            SearchButton.TabStop = false;
            SearchButton.Click += InputEdit_Click;
            // 
            // userInputpnl
            // 
            userInputpnl.BackColor = Color.BlanchedAlmond;
            userInputpnl.Controls.Add(storagechbox);
            userInputpnl.Controls.Add(richTextBox15);
            userInputpnl.Controls.Add(timeOutrtxt);
            userInputpnl.Controls.Add(richTextBox11);
            userInputpnl.Controls.Add(timeInrtxt);
            userInputpnl.Controls.Add(richTextBox12);
            userInputpnl.Controls.Add(workstationrtxt);
            userInputpnl.Controls.Add(richTextBox9);
            userInputpnl.Controls.Add(departmentrtxt);
            userInputpnl.Controls.Add(richTextBox7);
            userInputpnl.Controls.Add(batchNumrtxt);
            userInputpnl.Controls.Add(richTextBox5);
            userInputpnl.Controls.Add(serialNumrtxt);
            userInputpnl.Controls.Add(richTextBox3);
            userInputpnl.Controls.Add(partNumrtxt);
            userInputpnl.Controls.Add(richTextBox1);
            userInputpnl.Location = new Point(16, 195);
            userInputpnl.Name = "userInputpnl";
            userInputpnl.Size = new Size(1371, 68);
            userInputpnl.TabIndex = 17;
            // 
            // storagechbox
            // 
            storagechbox.AutoSize = true;
            storagechbox.BackColor = Color.White;
            storagechbox.Cursor = Cursors.Hand;
            storagechbox.Location = new Point(1291, 25);
            storagechbox.Name = "storagechbox";
            storagechbox.Size = new Size(22, 21);
            storagechbox.TabIndex = 18;
            storagechbox.Tag = "InStorage";
            storagechbox.UseVisualStyleBackColor = false;
            storagechbox.CheckedChanged += storagechbox_CheckedChanged;
            // 
            // richTextBox15
            // 
            richTextBox15.BackColor = Color.FromArgb(113, 96, 232);
            richTextBox15.BorderStyle = BorderStyle.None;
            richTextBox15.Dock = DockStyle.Left;
            richTextBox15.Location = new Point(1219, 0);
            richTextBox15.Name = "richTextBox15";
            richTextBox15.Size = new Size(6, 68);
            richTextBox15.TabIndex = 16;
            richTextBox15.Text = "";
            // 
            // timeOutrtxt
            // 
            timeOutrtxt.BackColor = Color.BlanchedAlmond;
            timeOutrtxt.BorderStyle = BorderStyle.FixedSingle;
            timeOutrtxt.Cursor = Cursors.Hand;
            timeOutrtxt.Dock = DockStyle.Left;
            timeOutrtxt.Location = new Point(1026, 0);
            timeOutrtxt.Name = "timeOutrtxt";
            timeOutrtxt.Size = new Size(193, 68);
            timeOutrtxt.TabIndex = 15;
            timeOutrtxt.Tag = "WSTimestampOUT";
            timeOutrtxt.Text = "";
            richTextBoxtooltip.SetToolTip(timeOutrtxt, "Timestamp OUT - the time when \r\nthe part left the users workstation ");
            // 
            // richTextBox11
            // 
            richTextBox11.BackColor = Color.FromArgb(113, 96, 232);
            richTextBox11.BorderStyle = BorderStyle.None;
            richTextBox11.Dock = DockStyle.Left;
            richTextBox11.Location = new Point(1020, 0);
            richTextBox11.Name = "richTextBox11";
            richTextBox11.Size = new Size(6, 68);
            richTextBox11.TabIndex = 14;
            richTextBox11.Text = "";
            // 
            // timeInrtxt
            // 
            timeInrtxt.BackColor = Color.BlanchedAlmond;
            timeInrtxt.BorderStyle = BorderStyle.FixedSingle;
            timeInrtxt.Cursor = Cursors.Hand;
            timeInrtxt.Dock = DockStyle.Left;
            timeInrtxt.Location = new Point(827, 0);
            timeInrtxt.Name = "timeInrtxt";
            timeInrtxt.Size = new Size(193, 68);
            timeInrtxt.TabIndex = 13;
            timeInrtxt.Tag = "WSTimestampIN";
            timeInrtxt.Text = "";
            richTextBoxtooltip.SetToolTip(timeInrtxt, "Timestamp IN - the time when the \r\npart entered the users workstation");
            // 
            // richTextBox12
            // 
            richTextBox12.BackColor = Color.FromArgb(113, 96, 232);
            richTextBox12.BorderStyle = BorderStyle.None;
            richTextBox12.Dock = DockStyle.Left;
            richTextBox12.Location = new Point(821, 0);
            richTextBox12.Name = "richTextBox12";
            richTextBox12.Size = new Size(6, 68);
            richTextBox12.TabIndex = 12;
            richTextBox12.Text = "";
            // 
            // workstationrtxt
            // 
            workstationrtxt.BackColor = Color.BlanchedAlmond;
            workstationrtxt.BorderStyle = BorderStyle.FixedSingle;
            workstationrtxt.Cursor = Cursors.Hand;
            workstationrtxt.Dock = DockStyle.Left;
            workstationrtxt.Location = new Point(643, 0);
            workstationrtxt.Name = "workstationrtxt";
            workstationrtxt.Size = new Size(178, 68);
            workstationrtxt.TabIndex = 10;
            workstationrtxt.Tag = "Workstation";
            workstationrtxt.Text = "";
            richTextBoxtooltip.SetToolTip(workstationrtxt, "Workstation - which aspect of \r\nthe workline the user works on");
            // 
            // richTextBox9
            // 
            richTextBox9.BackColor = Color.FromArgb(113, 96, 232);
            richTextBox9.BorderStyle = BorderStyle.None;
            richTextBox9.Dock = DockStyle.Left;
            richTextBox9.Location = new Point(637, 0);
            richTextBox9.Name = "richTextBox9";
            richTextBox9.Size = new Size(6, 68);
            richTextBox9.TabIndex = 9;
            richTextBox9.Text = "";
            // 
            // departmentrtxt
            // 
            departmentrtxt.BackColor = Color.BlanchedAlmond;
            departmentrtxt.BorderStyle = BorderStyle.FixedSingle;
            departmentrtxt.Cursor = Cursors.Hand;
            departmentrtxt.Dock = DockStyle.Left;
            departmentrtxt.Location = new Point(473, 0);
            departmentrtxt.Name = "departmentrtxt";
            departmentrtxt.Size = new Size(164, 68);
            departmentrtxt.TabIndex = 8;
            departmentrtxt.Tag = "Department";
            departmentrtxt.Text = "";
            richTextBoxtooltip.SetToolTip(departmentrtxt, "Department - where the \r\nuser's workstation is located");
            // 
            // richTextBox7
            // 
            richTextBox7.BackColor = Color.FromArgb(113, 96, 232);
            richTextBox7.BorderStyle = BorderStyle.None;
            richTextBox7.Dock = DockStyle.Left;
            richTextBox7.Location = new Point(467, 0);
            richTextBox7.Name = "richTextBox7";
            richTextBox7.Size = new Size(6, 68);
            richTextBox7.TabIndex = 7;
            richTextBox7.Text = "";
            // 
            // batchNumrtxt
            // 
            batchNumrtxt.BackColor = Color.BlanchedAlmond;
            batchNumrtxt.BorderStyle = BorderStyle.FixedSingle;
            batchNumrtxt.Cursor = Cursors.Hand;
            batchNumrtxt.Dock = DockStyle.Left;
            batchNumrtxt.Location = new Point(317, 0);
            batchNumrtxt.Name = "batchNumrtxt";
            batchNumrtxt.Size = new Size(150, 68);
            batchNumrtxt.TabIndex = 6;
            batchNumrtxt.Tag = "BatchNumber";
            batchNumrtxt.Text = "";
            richTextBoxtooltip.SetToolTip(batchNumrtxt, "Batch Number - preceded \r\nby BAT on the barcode");
            // 
            // richTextBox5
            // 
            richTextBox5.BackColor = Color.FromArgb(113, 96, 232);
            richTextBox5.BorderStyle = BorderStyle.None;
            richTextBox5.Dock = DockStyle.Left;
            richTextBox5.Location = new Point(311, 0);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.Size = new Size(6, 68);
            richTextBox5.TabIndex = 4;
            richTextBox5.Text = "";
            // 
            // serialNumrtxt
            // 
            serialNumrtxt.BackColor = Color.BlanchedAlmond;
            serialNumrtxt.BorderStyle = BorderStyle.FixedSingle;
            serialNumrtxt.Cursor = Cursors.Hand;
            serialNumrtxt.Dock = DockStyle.Left;
            serialNumrtxt.Location = new Point(161, 0);
            serialNumrtxt.Name = "serialNumrtxt";
            serialNumrtxt.Size = new Size(150, 68);
            serialNumrtxt.TabIndex = 3;
            serialNumrtxt.Tag = "SerialNumber";
            serialNumrtxt.Text = "";
            richTextBoxtooltip.SetToolTip(serialNumrtxt, "Serial Number - the unique \r\nidentifier for the part");
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = Color.FromArgb(113, 96, 232);
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.Dock = DockStyle.Left;
            richTextBox3.Location = new Point(155, 0);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(6, 68);
            richTextBox3.TabIndex = 2;
            richTextBox3.Text = "";
            // 
            // partNumrtxt
            // 
            partNumrtxt.BackColor = Color.BlanchedAlmond;
            partNumrtxt.BorderStyle = BorderStyle.FixedSingle;
            partNumrtxt.Cursor = Cursors.Hand;
            partNumrtxt.Dock = DockStyle.Left;
            partNumrtxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            partNumrtxt.ForeColor = Color.Coral;
            partNumrtxt.Location = new Point(0, 0);
            partNumrtxt.Name = "partNumrtxt";
            partNumrtxt.Size = new Size(155, 68);
            partNumrtxt.TabIndex = 1;
            partNumrtxt.Tag = "PartNumber";
            partNumrtxt.Text = "";
            richTextBoxtooltip.SetToolTip(partNumrtxt, "Part Number - in bold on the \r\nbarcode and engraved on the part");
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(223, 151);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // furtherDetailsgridview
            // 
            furtherDetailsgridview.AllowUserToAddRows = false;
            furtherDetailsgridview.AllowUserToDeleteRows = false;
            furtherDetailsgridview.AllowUserToResizeColumns = false;
            furtherDetailsgridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(46, 51, 73);
            furtherDetailsgridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            furtherDetailsgridview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            furtherDetailsgridview.BackgroundColor = Color.FromArgb(46, 51, 73);
            furtherDetailsgridview.BorderStyle = BorderStyle.None;
            furtherDetailsgridview.CellBorderStyle = DataGridViewCellBorderStyle.None;
            furtherDetailsgridview.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            furtherDetailsgridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle17.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle17.SelectionBackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle17.SelectionForeColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            furtherDetailsgridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            furtherDetailsgridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle18.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = Color.White;
            dataGridViewCellStyle18.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle18.SelectionForeColor = Color.White;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.False;
            furtherDetailsgridview.DefaultCellStyle = dataGridViewCellStyle18;
            furtherDetailsgridview.EnableHeadersVisualStyles = false;
            furtherDetailsgridview.GridColor = Color.Silver;
            furtherDetailsgridview.Location = new Point(330, 337);
            furtherDetailsgridview.Margin = new Padding(4, 5, 4, 5);
            furtherDetailsgridview.MultiSelect = false;
            furtherDetailsgridview.Name = "furtherDetailsgridview";
            furtherDetailsgridview.ReadOnly = true;
            furtherDetailsgridview.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.BackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle19.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle19.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            furtherDetailsgridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            furtherDetailsgridview.RowHeadersVisible = false;
            furtherDetailsgridview.RowHeadersWidth = 62;
            furtherDetailsgridview.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle20.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle20.ForeColor = Color.White;
            dataGridViewCellStyle20.SelectionBackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle20.SelectionForeColor = Color.White;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.True;
            furtherDetailsgridview.RowsDefaultCellStyle = dataGridViewCellStyle20;
            furtherDetailsgridview.RowTemplate.Height = 50;
            furtherDetailsgridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            furtherDetailsgridview.Size = new Size(714, 70);
            furtherDetailsgridview.TabIndex = 31;
            // 
            // richTextBoxtooltip
            // 
            richTextBoxtooltip.AutomaticDelay = 100;
            richTextBoxtooltip.AutoPopDelay = 5000;
            richTextBoxtooltip.InitialDelay = 100;
            richTextBoxtooltip.ReshowDelay = 20;
            richTextBoxtooltip.ToolTipTitle = "Info";
            // 
            // Borderpnl
            // 
            Borderpnl.Anchor = AnchorStyles.None;
            Borderpnl.BackColor = Color.FromArgb(24, 30, 54);
            Borderpnl.Location = new Point(12, 121);
            Borderpnl.Margin = new Padding(4, 5, 4, 5);
            Borderpnl.Name = "Borderpnl";
            Borderpnl.Size = new Size(1420, 610);
            Borderpnl.TabIndex = 14;
            // 
            // PartEditPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            Controls.Add(panel1);
            Controls.Add(Borderpnl);
            Margin = new Padding(4, 5, 4, 5);
            Name = "PartEditPage";
            Size = new Size(1447, 870);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            furtherDetailspnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)partTobeEditedGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)SearchButton).EndInit();
            userInputpnl.ResumeLayout(false);
            userInputpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)furtherDetailsgridview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label agedlbl;
        private Panel panel1;
        private Panel userInputpnl;
        private RichTextBox workstationrtxt;
        private RichTextBox richTextBox9;
        private RichTextBox departmentrtxt;
        private RichTextBox richTextBox7;
        private RichTextBox batchNumrtxt;
        private RichTextBox richTextBox5;
        private RichTextBox serialNumrtxt;
        private RichTextBox richTextBox3;
        private RichTextBox partNumrtxt;
        private RichTextBox richTextBox1;
        private RichTextBox timeOutrtxt;
        private RichTextBox richTextBox11;
        private RichTextBox timeInrtxt;
        private RichTextBox richTextBox12;
        private RichTextBox richTextBox15;
        private CheckBox storagechbox;
        private ToolTip richTextBoxtooltip;
        private PictureBox SearchButton;
        private DataGridView partTobeEditedGridView;
        private DataGridView furtherDetailsgridview;
        private Panel furtherDetailspnl;
        private RichTextBox usertextbox;
        private RichTextBox richTextBox20;
        private RichTextBox reasonTxtbox;
        private RichTextBox richTextBox22;
        private RichTextBox storagetxtbox;
        private RichTextBox richTextBox24;
        private Panel Borderpnl;
        private DateTimePicker timestamptxt;
    }
}
