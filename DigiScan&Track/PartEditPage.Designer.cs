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
            richTextBox18 = new RichTextBox();
            richTextBox19 = new RichTextBox();
            richTextBox20 = new RichTextBox();
            richTextBox21 = new RichTextBox();
            richTextBox22 = new RichTextBox();
            richTextBox23 = new RichTextBox();
            richTextBox24 = new RichTextBox();
            furtherDetailsgridview = new DataGridView();
            partTobeEditedGridView = new DataGridView();
            SearchButton = new PictureBox();
            userInputpnl = new Panel();
            storagechbox = new CheckBox();
            storagertxt = new RichTextBox();
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
            richTextBoxtooltip = new ToolTip(components);
            panel1.SuspendLayout();
            furtherDetailspnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)furtherDetailsgridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)partTobeEditedGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SearchButton).BeginInit();
            userInputpnl.SuspendLayout();
            SuspendLayout();
            // 
            // agedlbl
            // 
            agedlbl.AutoSize = true;
            agedlbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            agedlbl.ForeColor = Color.White;
            agedlbl.Location = new Point(12, 12);
            agedlbl.Name = "agedlbl";
            agedlbl.Size = new Size(186, 25);
            agedlbl.TabIndex = 10;
            agedlbl.Text = "Change Part Details";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(113, 96, 232);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(furtherDetailspnl);
            panel1.Controls.Add(furtherDetailsgridview);
            panel1.Controls.Add(partTobeEditedGridView);
            panel1.Controls.Add(SearchButton);
            panel1.Controls.Add(userInputpnl);
            panel1.Controls.Add(agedlbl);
            panel1.Location = new Point(12, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(987, 359);
            panel1.TabIndex = 11;
            // 
            // furtherDetailspnl
            // 
            furtherDetailspnl.BackColor = Color.FromArgb(46, 51, 73);
            furtherDetailspnl.Controls.Add(richTextBox18);
            furtherDetailspnl.Controls.Add(richTextBox19);
            furtherDetailspnl.Controls.Add(richTextBox20);
            furtherDetailspnl.Controls.Add(richTextBox21);
            furtherDetailspnl.Controls.Add(richTextBox22);
            furtherDetailspnl.Controls.Add(richTextBox23);
            furtherDetailspnl.Controls.Add(richTextBox24);
            furtherDetailspnl.Location = new Point(231, 240);
            furtherDetailspnl.Margin = new Padding(2);
            furtherDetailspnl.Name = "furtherDetailspnl";
            furtherDetailspnl.Size = new Size(499, 41);
            furtherDetailspnl.TabIndex = 19;
            // 
            // richTextBox18
            // 
            richTextBox18.BackColor = Color.FromArgb(113, 96, 232);
            richTextBox18.BorderStyle = BorderStyle.None;
            richTextBox18.Dock = DockStyle.Left;
            richTextBox18.Location = new Point(496, 0);
            richTextBox18.Margin = new Padding(2);
            richTextBox18.Name = "richTextBox18";
            richTextBox18.Size = new Size(4, 41);
            richTextBox18.TabIndex = 7;
            richTextBox18.Text = "";
            // 
            // richTextBox19
            // 
            richTextBox19.BackColor = Color.BlanchedAlmond;
            richTextBox19.BorderStyle = BorderStyle.FixedSingle;
            richTextBox19.Cursor = Cursors.Hand;
            richTextBox19.Dock = DockStyle.Left;
            richTextBox19.Location = new Point(350, 0);
            richTextBox19.Margin = new Padding(2);
            richTextBox19.Name = "richTextBox19";
            richTextBox19.Size = new Size(146, 41);
            richTextBox19.TabIndex = 6;
            richTextBox19.Tag = "BatchNumber";
            richTextBox19.Text = "";
            richTextBoxtooltip.SetToolTip(richTextBox19, "User - The user who last worked on\r\n this part and entered it into storage");
            // 
            // richTextBox20
            // 
            richTextBox20.BackColor = Color.FromArgb(113, 96, 232);
            richTextBox20.BorderStyle = BorderStyle.None;
            richTextBox20.Dock = DockStyle.Left;
            richTextBox20.Location = new Point(346, 0);
            richTextBox20.Margin = new Padding(2);
            richTextBox20.Name = "richTextBox20";
            richTextBox20.Size = new Size(4, 41);
            richTextBox20.TabIndex = 4;
            richTextBox20.Text = "";
            // 
            // richTextBox21
            // 
            richTextBox21.BackColor = Color.BlanchedAlmond;
            richTextBox21.BorderStyle = BorderStyle.FixedSingle;
            richTextBox21.Cursor = Cursors.Hand;
            richTextBox21.Dock = DockStyle.Left;
            richTextBox21.Location = new Point(150, 0);
            richTextBox21.Margin = new Padding(2);
            richTextBox21.Name = "richTextBox21";
            richTextBox21.Size = new Size(196, 41);
            richTextBox21.TabIndex = 3;
            richTextBox21.Tag = "SerialNumber";
            richTextBox21.Text = "";
            richTextBoxtooltip.SetToolTip(richTextBox21, "Reason for Storage - The reason that \r\nthe part has been entered into storage ");
            // 
            // richTextBox22
            // 
            richTextBox22.BackColor = Color.FromArgb(113, 96, 232);
            richTextBox22.BorderStyle = BorderStyle.None;
            richTextBox22.Dock = DockStyle.Left;
            richTextBox22.Location = new Point(146, 0);
            richTextBox22.Margin = new Padding(2);
            richTextBox22.Name = "richTextBox22";
            richTextBox22.Size = new Size(4, 41);
            richTextBox22.TabIndex = 2;
            richTextBox22.Text = "";
            // 
            // richTextBox23
            // 
            richTextBox23.BackColor = Color.BlanchedAlmond;
            richTextBox23.BorderStyle = BorderStyle.FixedSingle;
            richTextBox23.Cursor = Cursors.Hand;
            richTextBox23.Dock = DockStyle.Left;
            richTextBox23.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox23.ForeColor = Color.Coral;
            richTextBox23.Location = new Point(0, 0);
            richTextBox23.Margin = new Padding(2);
            richTextBox23.Name = "richTextBox23";
            richTextBox23.Size = new Size(146, 41);
            richTextBox23.TabIndex = 1;
            richTextBox23.Tag = "PartNumber";
            richTextBox23.Text = "";
            richTextBoxtooltip.SetToolTip(richTextBox23, "Storage Date - The date this \r\npart entered this workstation");
            // 
            // richTextBox24
            // 
            richTextBox24.BorderStyle = BorderStyle.FixedSingle;
            richTextBox24.Location = new Point(0, 0);
            richTextBox24.Margin = new Padding(2);
            richTextBox24.Name = "richTextBox24";
            richTextBox24.Size = new Size(157, 92);
            richTextBox24.TabIndex = 0;
            richTextBox24.Text = "";
            // 
            // furtherDetailsgridview
            // 
            furtherDetailsgridview.AllowUserToAddRows = false;
            furtherDetailsgridview.AllowUserToDeleteRows = false;
            furtherDetailsgridview.AllowUserToResizeColumns = false;
            furtherDetailsgridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(46, 51, 73);
            furtherDetailsgridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            furtherDetailsgridview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            furtherDetailsgridview.BackgroundColor = Color.FromArgb(46, 51, 73);
            furtherDetailsgridview.BorderStyle = BorderStyle.None;
            furtherDetailsgridview.CellBorderStyle = DataGridViewCellBorderStyle.None;
            furtherDetailsgridview.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            furtherDetailsgridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            furtherDetailsgridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            furtherDetailsgridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.White;
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle13.SelectionForeColor = Color.White;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            furtherDetailsgridview.DefaultCellStyle = dataGridViewCellStyle13;
            furtherDetailsgridview.EnableHeadersVisualStyles = false;
            furtherDetailsgridview.GridColor = Color.Silver;
            furtherDetailsgridview.Location = new Point(231, 162);
            furtherDetailsgridview.MultiSelect = false;
            furtherDetailsgridview.Name = "furtherDetailsgridview";
            furtherDetailsgridview.ReadOnly = true;
            furtherDetailsgridview.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            furtherDetailsgridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            furtherDetailsgridview.RowHeadersVisible = false;
            furtherDetailsgridview.RowHeadersWidth = 62;
            furtherDetailsgridview.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = Color.White;
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle15.SelectionForeColor = Color.White;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            furtherDetailsgridview.RowsDefaultCellStyle = dataGridViewCellStyle15;
            furtherDetailsgridview.RowTemplate.Height = 25;
            furtherDetailsgridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            furtherDetailsgridview.Size = new Size(500, 73);
            furtherDetailsgridview.TabIndex = 31;
            // 
            // partTobeEditedGridView
            // 
            partTobeEditedGridView.AllowUserToAddRows = false;
            partTobeEditedGridView.AllowUserToDeleteRows = false;
            partTobeEditedGridView.AllowUserToResizeColumns = false;
            partTobeEditedGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(46, 51, 73);
            partTobeEditedGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            partTobeEditedGridView.BackgroundColor = Color.FromArgb(46, 51, 73);
            partTobeEditedGridView.BorderStyle = BorderStyle.None;
            partTobeEditedGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            partTobeEditedGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle17.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle17.SelectionBackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle17.SelectionForeColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            partTobeEditedGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            partTobeEditedGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle18.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = Color.White;
            dataGridViewCellStyle18.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle18.SelectionForeColor = Color.White;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.False;
            partTobeEditedGridView.DefaultCellStyle = dataGridViewCellStyle18;
            partTobeEditedGridView.EnableHeadersVisualStyles = false;
            partTobeEditedGridView.GridColor = Color.Silver;
            partTobeEditedGridView.Location = new Point(12, 53);
            partTobeEditedGridView.MultiSelect = false;
            partTobeEditedGridView.Name = "partTobeEditedGridView";
            partTobeEditedGridView.ReadOnly = true;
            partTobeEditedGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.BackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle19.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle19.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            partTobeEditedGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            partTobeEditedGridView.RowHeadersVisible = false;
            partTobeEditedGridView.RowHeadersWidth = 62;
            partTobeEditedGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle20.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle20.ForeColor = Color.White;
            dataGridViewCellStyle20.SelectionBackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle20.SelectionForeColor = Color.White;
            partTobeEditedGridView.RowsDefaultCellStyle = dataGridViewCellStyle20;
            partTobeEditedGridView.RowTemplate.Height = 25;
            partTobeEditedGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            partTobeEditedGridView.Size = new Size(959, 49);
            partTobeEditedGridView.TabIndex = 30;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.Transparent;
            SearchButton.BackgroundImage = Properties.Resources.spanner;
            SearchButton.BackgroundImageLayout = ImageLayout.Stretch;
            SearchButton.Cursor = Cursors.Hand;
            SearchButton.Location = new Point(450, 292);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(57, 57);
            SearchButton.TabIndex = 23;
            SearchButton.TabStop = false;
            SearchButton.Click += InputEdit_Click;
            // 
            // userInputpnl
            // 
            userInputpnl.BackColor = Color.FromArgb(46, 51, 73);
            userInputpnl.Controls.Add(storagechbox);
            userInputpnl.Controls.Add(storagertxt);
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
            userInputpnl.Location = new Point(11, 106);
            userInputpnl.Margin = new Padding(2);
            userInputpnl.Name = "userInputpnl";
            userInputpnl.Size = new Size(960, 41);
            userInputpnl.TabIndex = 17;
            // 
            // storagechbox
            // 
            storagechbox.AutoSize = true;
            storagechbox.BackColor = Color.White;
            storagechbox.Cursor = Cursors.Hand;
            storagechbox.Location = new Point(902, 15);
            storagechbox.Margin = new Padding(2);
            storagechbox.Name = "storagechbox";
            storagechbox.Size = new Size(15, 14);
            storagechbox.TabIndex = 18;
            storagechbox.Tag = "InStorage";
            storagechbox.UseVisualStyleBackColor = false;
            // 
            // storagertxt
            // 
            storagertxt.BackColor = Color.BlanchedAlmond;
            storagertxt.BorderStyle = BorderStyle.FixedSingle;
            storagertxt.Dock = DockStyle.Left;
            storagertxt.Enabled = false;
            storagertxt.Location = new Point(864, 0);
            storagertxt.Margin = new Padding(2);
            storagertxt.Name = "storagertxt";
            storagertxt.Size = new Size(96, 41);
            storagertxt.TabIndex = 17;
            storagertxt.Text = "";
            richTextBoxtooltip.SetToolTip(storagertxt, "Storage - tick the checkbox if the part is \r\neither currently/will be located in storage");
            // 
            // richTextBox15
            // 
            richTextBox15.BackColor = Color.FromArgb(113, 96, 232);
            richTextBox15.BorderStyle = BorderStyle.None;
            richTextBox15.Dock = DockStyle.Left;
            richTextBox15.Location = new Point(860, 0);
            richTextBox15.Margin = new Padding(2);
            richTextBox15.Name = "richTextBox15";
            richTextBox15.Size = new Size(4, 41);
            richTextBox15.TabIndex = 16;
            richTextBox15.Text = "";
            // 
            // timeOutrtxt
            // 
            timeOutrtxt.BackColor = Color.BlanchedAlmond;
            timeOutrtxt.BorderStyle = BorderStyle.FixedSingle;
            timeOutrtxt.Cursor = Cursors.Hand;
            timeOutrtxt.Dock = DockStyle.Left;
            timeOutrtxt.Location = new Point(724, 0);
            timeOutrtxt.Margin = new Padding(2);
            timeOutrtxt.Name = "timeOutrtxt";
            timeOutrtxt.Size = new Size(136, 41);
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
            richTextBox11.Location = new Point(720, 0);
            richTextBox11.Margin = new Padding(2);
            richTextBox11.Name = "richTextBox11";
            richTextBox11.Size = new Size(4, 41);
            richTextBox11.TabIndex = 14;
            richTextBox11.Text = "";
            // 
            // timeInrtxt
            // 
            timeInrtxt.BackColor = Color.BlanchedAlmond;
            timeInrtxt.BorderStyle = BorderStyle.FixedSingle;
            timeInrtxt.Cursor = Cursors.Hand;
            timeInrtxt.Dock = DockStyle.Left;
            timeInrtxt.Location = new Point(584, 0);
            timeInrtxt.Margin = new Padding(2);
            timeInrtxt.Name = "timeInrtxt";
            timeInrtxt.Size = new Size(136, 41);
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
            richTextBox12.Location = new Point(580, 0);
            richTextBox12.Margin = new Padding(2);
            richTextBox12.Name = "richTextBox12";
            richTextBox12.Size = new Size(4, 41);
            richTextBox12.TabIndex = 12;
            richTextBox12.Text = "";
            // 
            // workstationrtxt
            // 
            workstationrtxt.BackColor = Color.BlanchedAlmond;
            workstationrtxt.BorderStyle = BorderStyle.FixedSingle;
            workstationrtxt.Cursor = Cursors.Hand;
            workstationrtxt.Dock = DockStyle.Left;
            workstationrtxt.Location = new Point(454, 0);
            workstationrtxt.Margin = new Padding(2);
            workstationrtxt.Name = "workstationrtxt";
            workstationrtxt.Size = new Size(126, 41);
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
            richTextBox9.Location = new Point(450, 0);
            richTextBox9.Margin = new Padding(2);
            richTextBox9.Name = "richTextBox9";
            richTextBox9.Size = new Size(4, 41);
            richTextBox9.TabIndex = 9;
            richTextBox9.Text = "";
            // 
            // departmentrtxt
            // 
            departmentrtxt.BackColor = Color.BlanchedAlmond;
            departmentrtxt.BorderStyle = BorderStyle.FixedSingle;
            departmentrtxt.Cursor = Cursors.Hand;
            departmentrtxt.Dock = DockStyle.Left;
            departmentrtxt.Location = new Point(334, 0);
            departmentrtxt.Margin = new Padding(2);
            departmentrtxt.Name = "departmentrtxt";
            departmentrtxt.Size = new Size(116, 41);
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
            richTextBox7.Location = new Point(330, 0);
            richTextBox7.Margin = new Padding(2);
            richTextBox7.Name = "richTextBox7";
            richTextBox7.Size = new Size(4, 41);
            richTextBox7.TabIndex = 7;
            richTextBox7.Text = "";
            // 
            // batchNumrtxt
            // 
            batchNumrtxt.BackColor = Color.BlanchedAlmond;
            batchNumrtxt.BorderStyle = BorderStyle.FixedSingle;
            batchNumrtxt.Cursor = Cursors.Hand;
            batchNumrtxt.Dock = DockStyle.Left;
            batchNumrtxt.Location = new Point(224, 0);
            batchNumrtxt.Margin = new Padding(2);
            batchNumrtxt.Name = "batchNumrtxt";
            batchNumrtxt.Size = new Size(106, 41);
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
            richTextBox5.Location = new Point(220, 0);
            richTextBox5.Margin = new Padding(2);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.Size = new Size(4, 41);
            richTextBox5.TabIndex = 4;
            richTextBox5.Text = "";
            // 
            // serialNumrtxt
            // 
            serialNumrtxt.BackColor = Color.BlanchedAlmond;
            serialNumrtxt.BorderStyle = BorderStyle.FixedSingle;
            serialNumrtxt.Cursor = Cursors.Hand;
            serialNumrtxt.Dock = DockStyle.Left;
            serialNumrtxt.Location = new Point(114, 0);
            serialNumrtxt.Margin = new Padding(2);
            serialNumrtxt.Name = "serialNumrtxt";
            serialNumrtxt.Size = new Size(106, 41);
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
            richTextBox3.Location = new Point(110, 0);
            richTextBox3.Margin = new Padding(2);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(4, 41);
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
            partNumrtxt.Margin = new Padding(2);
            partNumrtxt.Name = "partNumrtxt";
            partNumrtxt.Size = new Size(110, 41);
            partNumrtxt.TabIndex = 1;
            partNumrtxt.Tag = "PartNumber";
            partNumrtxt.Text = "";
            richTextBoxtooltip.SetToolTip(partNumrtxt, "Part Number - in bold on the \r\nbarcode and engraved on the part");
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Margin = new Padding(2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(157, 92);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // richTextBoxtooltip
            // 
            richTextBoxtooltip.AutomaticDelay = 100;
            richTextBoxtooltip.AutoPopDelay = 5000;
            richTextBoxtooltip.InitialDelay = 100;
            richTextBoxtooltip.ReshowDelay = 20;
            richTextBoxtooltip.ToolTipTitle = "Info";
            // 
            // PartEditPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            Controls.Add(panel1);
            Name = "PartEditPage";
            Size = new Size(1013, 522);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            furtherDetailspnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)furtherDetailsgridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)partTobeEditedGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)SearchButton).EndInit();
            userInputpnl.ResumeLayout(false);
            userInputpnl.PerformLayout();
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
        private RichTextBox storagertxt;
        private ToolTip richTextBoxtooltip;
        private PictureBox SearchButton;
        private DataGridView partTobeEditedGridView;
        private DataGridView furtherDetailsgridview;
        private Panel furtherDetailspnl;
        private RichTextBox richTextBox18;
        private RichTextBox richTextBox19;
        private RichTextBox richTextBox20;
        private RichTextBox richTextBox21;
        private RichTextBox richTextBox22;
        private RichTextBox richTextBox23;
        private RichTextBox richTextBox24;
    }
}
