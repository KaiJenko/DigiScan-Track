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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            agedlbl = new Label();
            panel1 = new Panel();
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
            partTobeEditedGridView = new DataGridView();
            richTextBoxtooltip = new ToolTip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SearchButton).BeginInit();
            userInputpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)partTobeEditedGridView).BeginInit();
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
            panel1.BackColor = Color.DodgerBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(SearchButton);
            panel1.Controls.Add(userInputpnl);
            panel1.Controls.Add(partTobeEditedGridView);
            panel1.Controls.Add(agedlbl);
            panel1.Location = new Point(17, 183);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1409, 540);
            panel1.TabIndex = 11;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.Transparent;
            SearchButton.BackgroundImage = Properties.Resources.spanner;
            SearchButton.BackgroundImageLayout = ImageLayout.Stretch;
            SearchButton.Location = new Point(634, 406);
            SearchButton.Margin = new Padding(4, 5, 4, 5);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(147, 127);
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
            userInputpnl.Location = new Point(13, 320);
            userInputpnl.Name = "userInputpnl";
            userInputpnl.Size = new Size(1374, 68);
            userInputpnl.TabIndex = 17;
            // 
            // storagechbox
            // 
            storagechbox.AutoSize = true;
            storagechbox.BackColor = Color.White;
            storagechbox.Location = new Point(1321, 25);
            storagechbox.Name = "storagechbox";
            storagechbox.Size = new Size(22, 21);
            storagechbox.TabIndex = 18;
            storagechbox.Tag = "InStorage";
            storagechbox.UseVisualStyleBackColor = false;
            // 
            // storagertxt
            // 
            storagertxt.BackColor = Color.White;
            storagertxt.BorderStyle = BorderStyle.FixedSingle;
            storagertxt.Dock = DockStyle.Left;
            storagertxt.Enabled = false;
            storagertxt.Location = new Point(1285, 0);
            storagertxt.Name = "storagertxt";
            storagertxt.Size = new Size(89, 68);
            storagertxt.TabIndex = 17;
            storagertxt.Text = "";
            richTextBoxtooltip.SetToolTip(storagertxt, "Storage - tick the checkbox if the part is \r\neither currently/will be located in storage");
            // 
            // richTextBox15
            // 
            richTextBox15.BackColor = Color.FromArgb(46, 51, 73);
            richTextBox15.BorderStyle = BorderStyle.None;
            richTextBox15.Dock = DockStyle.Left;
            richTextBox15.Location = new Point(1280, 0);
            richTextBox15.Name = "richTextBox15";
            richTextBox15.Size = new Size(5, 68);
            richTextBox15.TabIndex = 16;
            richTextBox15.Text = "";
            // 
            // timeOutrtxt
            // 
            timeOutrtxt.BackColor = Color.White;
            timeOutrtxt.BorderStyle = BorderStyle.FixedSingle;
            timeOutrtxt.Dock = DockStyle.Left;
            timeOutrtxt.Location = new Point(1080, 0);
            timeOutrtxt.Name = "timeOutrtxt";
            timeOutrtxt.Size = new Size(200, 68);
            timeOutrtxt.TabIndex = 15;
            timeOutrtxt.Tag = "WSTimestampOUT";
            timeOutrtxt.Text = "";
            richTextBoxtooltip.SetToolTip(timeOutrtxt, "Timestamp OUT - the time when \r\nthe part left the users workstation ");
            // 
            // richTextBox11
            // 
            richTextBox11.BackColor = Color.FromArgb(46, 51, 73);
            richTextBox11.BorderStyle = BorderStyle.None;
            richTextBox11.Dock = DockStyle.Left;
            richTextBox11.Location = new Point(1075, 0);
            richTextBox11.Name = "richTextBox11";
            richTextBox11.Size = new Size(5, 68);
            richTextBox11.TabIndex = 14;
            richTextBox11.Text = "";
            // 
            // timeInrtxt
            // 
            timeInrtxt.BackColor = Color.White;
            timeInrtxt.BorderStyle = BorderStyle.FixedSingle;
            timeInrtxt.Dock = DockStyle.Left;
            timeInrtxt.Location = new Point(875, 0);
            timeInrtxt.Name = "timeInrtxt";
            timeInrtxt.Size = new Size(200, 68);
            timeInrtxt.TabIndex = 13;
            timeInrtxt.Tag = "WSTimestampIN";
            timeInrtxt.Text = "";
            richTextBoxtooltip.SetToolTip(timeInrtxt, "Timestamp IN - the time when the \r\npart entered the users workstation");
            // 
            // richTextBox12
            // 
            richTextBox12.BackColor = Color.FromArgb(46, 51, 73);
            richTextBox12.BorderStyle = BorderStyle.None;
            richTextBox12.Dock = DockStyle.Left;
            richTextBox12.Location = new Point(870, 0);
            richTextBox12.Name = "richTextBox12";
            richTextBox12.Size = new Size(5, 68);
            richTextBox12.TabIndex = 12;
            richTextBox12.Text = "";
            // 
            // workstationrtxt
            // 
            workstationrtxt.BackColor = Color.White;
            workstationrtxt.BorderStyle = BorderStyle.FixedSingle;
            workstationrtxt.Dock = DockStyle.Left;
            workstationrtxt.Location = new Point(700, 0);
            workstationrtxt.Name = "workstationrtxt";
            workstationrtxt.Size = new Size(170, 68);
            workstationrtxt.TabIndex = 10;
            workstationrtxt.Tag = "Workstation";
            workstationrtxt.Text = "";
            richTextBoxtooltip.SetToolTip(workstationrtxt, "Workstation - which aspect of \r\nthe workline the user works on");
            // 
            // richTextBox9
            // 
            richTextBox9.BackColor = Color.FromArgb(46, 51, 73);
            richTextBox9.BorderStyle = BorderStyle.None;
            richTextBox9.Dock = DockStyle.Left;
            richTextBox9.Location = new Point(695, 0);
            richTextBox9.Name = "richTextBox9";
            richTextBox9.Size = new Size(5, 68);
            richTextBox9.TabIndex = 9;
            richTextBox9.Text = "";
            // 
            // departmentrtxt
            // 
            departmentrtxt.BackColor = Color.White;
            departmentrtxt.BorderStyle = BorderStyle.FixedSingle;
            departmentrtxt.Dock = DockStyle.Left;
            departmentrtxt.Location = new Point(525, 0);
            departmentrtxt.Name = "departmentrtxt";
            departmentrtxt.Size = new Size(170, 68);
            departmentrtxt.TabIndex = 8;
            departmentrtxt.Tag = "Department";
            departmentrtxt.Text = "";
            richTextBoxtooltip.SetToolTip(departmentrtxt, "Department - where the \r\nuser's workstation is located");
            // 
            // richTextBox7
            // 
            richTextBox7.BackColor = Color.FromArgb(46, 51, 73);
            richTextBox7.BorderStyle = BorderStyle.None;
            richTextBox7.Dock = DockStyle.Left;
            richTextBox7.Location = new Point(520, 0);
            richTextBox7.Name = "richTextBox7";
            richTextBox7.Size = new Size(5, 68);
            richTextBox7.TabIndex = 7;
            richTextBox7.Text = "";
            // 
            // batchNumrtxt
            // 
            batchNumrtxt.BackColor = Color.White;
            batchNumrtxt.BorderStyle = BorderStyle.FixedSingle;
            batchNumrtxt.Dock = DockStyle.Left;
            batchNumrtxt.Location = new Point(350, 0);
            batchNumrtxt.Name = "batchNumrtxt";
            batchNumrtxt.Size = new Size(170, 68);
            batchNumrtxt.TabIndex = 6;
            batchNumrtxt.Tag = "BatchNumber";
            batchNumrtxt.Text = "";
            richTextBoxtooltip.SetToolTip(batchNumrtxt, "Batch Number - preceded \r\nby BAT on the barcode");
            // 
            // richTextBox5
            // 
            richTextBox5.BackColor = Color.FromArgb(46, 51, 73);
            richTextBox5.BorderStyle = BorderStyle.None;
            richTextBox5.Dock = DockStyle.Left;
            richTextBox5.Location = new Point(345, 0);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.Size = new Size(5, 68);
            richTextBox5.TabIndex = 4;
            richTextBox5.Text = "";
            // 
            // serialNumrtxt
            // 
            serialNumrtxt.BackColor = Color.White;
            serialNumrtxt.BorderStyle = BorderStyle.FixedSingle;
            serialNumrtxt.Dock = DockStyle.Left;
            serialNumrtxt.Location = new Point(175, 0);
            serialNumrtxt.Name = "serialNumrtxt";
            serialNumrtxt.Size = new Size(170, 68);
            serialNumrtxt.TabIndex = 3;
            serialNumrtxt.Tag = "SerialNumber";
            serialNumrtxt.Text = "";
            richTextBoxtooltip.SetToolTip(serialNumrtxt, "Serial Number - the unique \r\nidentifier for the part");
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = Color.FromArgb(46, 51, 73);
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.Dock = DockStyle.Left;
            richTextBox3.Location = new Point(170, 0);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(5, 68);
            richTextBox3.TabIndex = 2;
            richTextBox3.Text = "";
            // 
            // partNumrtxt
            // 
            partNumrtxt.BackColor = Color.White;
            partNumrtxt.BorderStyle = BorderStyle.FixedSingle;
            partNumrtxt.Dock = DockStyle.Left;
            partNumrtxt.Location = new Point(0, 0);
            partNumrtxt.Name = "partNumrtxt";
            partNumrtxt.Size = new Size(170, 68);
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
            richTextBox1.Size = new Size(223, 150);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // partTobeEditedGridView
            // 
            partTobeEditedGridView.AllowUserToAddRows = false;
            partTobeEditedGridView.AllowUserToDeleteRows = false;
            partTobeEditedGridView.BackgroundColor = Color.FromArgb(46, 51, 73);
            partTobeEditedGridView.BorderStyle = BorderStyle.None;
            partTobeEditedGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            partTobeEditedGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            partTobeEditedGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            partTobeEditedGridView.DefaultCellStyle = dataGridViewCellStyle2;
            partTobeEditedGridView.GridColor = Color.White;
            partTobeEditedGridView.Location = new Point(13, 87);
            partTobeEditedGridView.Margin = new Padding(4, 5, 4, 5);
            partTobeEditedGridView.Name = "partTobeEditedGridView";
            partTobeEditedGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            partTobeEditedGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            partTobeEditedGridView.RowHeadersVisible = false;
            partTobeEditedGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            partTobeEditedGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            partTobeEditedGridView.RowTemplate.Height = 25;
            partTobeEditedGridView.Size = new Size(1374, 178);
            partTobeEditedGridView.TabIndex = 16;
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
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "PartEditPage";
            Size = new Size(1447, 870);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SearchButton).EndInit();
            userInputpnl.ResumeLayout(false);
            userInputpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)partTobeEditedGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label agedlbl;
        private Panel panel1;
        private DataGridView partTobeEditedGridView;
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
    }
}
