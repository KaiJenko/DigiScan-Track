namespace DigiScan_Track
{
    partial class EditParts
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditParts));
            pictureBox1 = new PictureBox();
            departmentcmbox = new ComboBox();
            label2 = new Label();
            searchtxt = new TextBox();
            label1 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            Titlelbl = new Label();
            InnerBorderpnl = new Panel();
            toEditGridView = new DataGridView();
            panel1 = new Panel();
            submitAddpbox = new PictureBox();
            addPartcmbox = new ComboBox();
            addParttxt = new TextBox();
            SearchButton = new PictureBox();
            partNumbercmbox = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            OuterBorderpnl = new Panel();
            crossOffpbox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            InnerBorderpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toEditGridView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)submitAddpbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SearchButton).BeginInit();
            OuterBorderpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)crossOffpbox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(24, 30, 54);
            pictureBox1.Location = new Point(18, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(442, 419);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // departmentcmbox
            // 
            departmentcmbox.BackColor = Color.FromArgb(46, 51, 73);
            departmentcmbox.Cursor = Cursors.Hand;
            departmentcmbox.DrawMode = DrawMode.OwnerDrawFixed;
            departmentcmbox.DropDownStyle = ComboBoxStyle.DropDownList;
            departmentcmbox.FlatStyle = FlatStyle.Flat;
            departmentcmbox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            departmentcmbox.ForeColor = Color.White;
            departmentcmbox.FormattingEnabled = true;
            departmentcmbox.Location = new Point(214, 30);
            departmentcmbox.Name = "departmentcmbox";
            departmentcmbox.Size = new Size(201, 30);
            departmentcmbox.TabIndex = 7;
            departmentcmbox.SelectedIndexChanged += departmentcmbox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(46, 51, 73);
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(55, 125);
            label2.Name = "label2";
            label2.Size = new Size(148, 47);
            label2.TabIndex = 8;
            label2.Text = "Scan 2D Barcode from Unit:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // searchtxt
            // 
            searchtxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchtxt.Location = new Point(214, 137);
            searchtxt.Name = "searchtxt";
            searchtxt.Size = new Size(201, 29);
            searchtxt.TabIndex = 9;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(46, 51, 73);
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(38, 86);
            label1.Name = "label1";
            label1.Size = new Size(171, 28);
            label1.TabIndex = 6;
            label1.Text = "Select Part Number:";
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(46, 51, 73);
            label3.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 2);
            label3.Name = "label3";
            label3.Size = new Size(224, 28);
            label3.TabIndex = 10;
            label3.Text = "Search for Part to Edit";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaptionText;
            pictureBox2.Location = new Point(2, 235);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(431, 2);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(46, 51, 73);
            label4.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(4, 241);
            label4.Name = "label4";
            label4.Size = new Size(382, 28);
            label4.TabIndex = 12;
            label4.Text = "Add New Part Number - Admin Only";
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
            Titlelbl.Size = new Size(803, 47);
            Titlelbl.TabIndex = 14;
            Titlelbl.Text = "DigiScan && Track - Edit Parts\r\n";
            Titlelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InnerBorderpnl
            // 
            InnerBorderpnl.Anchor = AnchorStyles.None;
            InnerBorderpnl.BackColor = Color.FromArgb(46, 51, 73);
            InnerBorderpnl.Controls.Add(toEditGridView);
            InnerBorderpnl.Controls.Add(panel1);
            InnerBorderpnl.Controls.Add(pictureBox1);
            InnerBorderpnl.Location = new Point(4, 3);
            InnerBorderpnl.Name = "InnerBorderpnl";
            InnerBorderpnl.Size = new Size(1013, 522);
            InnerBorderpnl.TabIndex = 11;
            // 
            // toEditGridView
            // 
            toEditGridView.AllowUserToAddRows = false;
            toEditGridView.AllowUserToDeleteRows = false;
            toEditGridView.AllowUserToResizeColumns = false;
            toEditGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(113, 96, 232);
            toEditGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            toEditGridView.BackgroundColor = Color.FromArgb(113, 96, 232);
            toEditGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            toEditGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            toEditGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.Coral;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle7.SelectionForeColor = Color.Coral;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            toEditGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            toEditGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            toEditGridView.Cursor = Cursors.Hand;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            toEditGridView.DefaultCellStyle = dataGridViewCellStyle8;
            toEditGridView.EnableHeadersVisualStyles = false;
            toEditGridView.GridColor = Color.Silver;
            toEditGridView.Location = new Point(480, 24);
            toEditGridView.MultiSelect = false;
            toEditGridView.Name = "toEditGridView";
            toEditGridView.ReadOnly = true;
            toEditGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            toEditGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            toEditGridView.RowHeadersVisible = false;
            toEditGridView.RowHeadersWidth = 62;
            toEditGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            toEditGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            toEditGridView.RowTemplate.Height = 25;
            toEditGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            toEditGridView.Size = new Size(510, 472);
            toEditGridView.TabIndex = 29;
            toEditGridView.CellContentClick += toEditGridView_CellContentClick;
            toEditGridView.CellMouseEnter += toEditgridview_CellMouseEnter;
            toEditGridView.CellMouseLeave += toEditgridview_CellMouseLeave;
            toEditGridView.CellPainting += toEditGridView_CellPainting;
            // 
            // panel1
            // 
            panel1.Controls.Add(submitAddpbox);
            panel1.Controls.Add(addPartcmbox);
            panel1.Controls.Add(addParttxt);
            panel1.Controls.Add(SearchButton);
            panel1.Controls.Add(partNumbercmbox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(searchtxt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(departmentcmbox);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(22, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 411);
            panel1.TabIndex = 14;
            // 
            // submitAddpbox
            // 
            submitAddpbox.BackColor = Color.White;
            submitAddpbox.BackgroundImage = (Image)resources.GetObject("submitAddpbox.BackgroundImage");
            submitAddpbox.BackgroundImageLayout = ImageLayout.Stretch;
            submitAddpbox.Cursor = Cursors.Hand;
            submitAddpbox.Location = new Point(391, 361);
            submitAddpbox.Name = "submitAddpbox";
            submitAddpbox.Size = new Size(20, 20);
            submitAddpbox.TabIndex = 27;
            submitAddpbox.TabStop = false;
            submitAddpbox.Click += submitAddpbox_Click;
            // 
            // addPartcmbox
            // 
            addPartcmbox.BackColor = Color.FromArgb(46, 51, 73);
            addPartcmbox.Cursor = Cursors.Hand;
            addPartcmbox.DrawMode = DrawMode.OwnerDrawFixed;
            addPartcmbox.DropDownStyle = ComboBoxStyle.DropDownList;
            addPartcmbox.FlatStyle = FlatStyle.Flat;
            addPartcmbox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addPartcmbox.ForeColor = Color.White;
            addPartcmbox.FormattingEnabled = true;
            addPartcmbox.Location = new Point(214, 296);
            addPartcmbox.Name = "addPartcmbox";
            addPartcmbox.Size = new Size(201, 30);
            addPartcmbox.TabIndex = 24;
            addPartcmbox.SelectedIndexChanged += departmentcmbox_SelectedIndexChanged;
            // 
            // addParttxt
            // 
            addParttxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addParttxt.Location = new Point(214, 358);
            addParttxt.Name = "addParttxt";
            addParttxt.Size = new Size(201, 29);
            addParttxt.TabIndex = 23;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.White;
            SearchButton.BackgroundImage = Properties.Resources.MagnifyingGlass1;
            SearchButton.BackgroundImageLayout = ImageLayout.Stretch;
            SearchButton.Cursor = Cursors.Hand;
            SearchButton.Location = new Point(390, 141);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(20, 20);
            SearchButton.TabIndex = 22;
            SearchButton.TabStop = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // partNumbercmbox
            // 
            partNumbercmbox.BackColor = Color.FromArgb(46, 51, 73);
            partNumbercmbox.Cursor = Cursors.Hand;
            partNumbercmbox.DrawMode = DrawMode.OwnerDrawFixed;
            partNumbercmbox.DropDownStyle = ComboBoxStyle.DropDownList;
            partNumbercmbox.Enabled = false;
            partNumbercmbox.FlatStyle = FlatStyle.Flat;
            partNumbercmbox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            partNumbercmbox.ForeColor = Color.White;
            partNumbercmbox.FormattingEnabled = true;
            partNumbercmbox.Location = new Point(214, 83);
            partNumbercmbox.Name = "partNumbercmbox";
            partNumbercmbox.Size = new Size(201, 30);
            partNumbercmbox.TabIndex = 14;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(46, 51, 73);
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(45, 33);
            label5.Name = "label5";
            label5.Size = new Size(164, 28);
            label5.TabIndex = 13;
            label5.Text = "Select Department:";
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(46, 51, 73);
            label6.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(36, 298);
            label6.Name = "label6";
            label6.Size = new Size(188, 28);
            label6.TabIndex = 25;
            label6.Text = "Choose Department:";
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(46, 51, 73);
            label7.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(43, 357);
            label7.Name = "label7";
            label7.Size = new Size(179, 29);
            label7.TabIndex = 26;
            label7.Text = "Input Part Number:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // OuterBorderpnl
            // 
            OuterBorderpnl.Anchor = AnchorStyles.None;
            OuterBorderpnl.BackColor = Color.FromArgb(24, 30, 54);
            OuterBorderpnl.Controls.Add(InnerBorderpnl);
            OuterBorderpnl.Location = new Point(16, 69);
            OuterBorderpnl.Name = "OuterBorderpnl";
            OuterBorderpnl.Size = new Size(1020, 528);
            OuterBorderpnl.TabIndex = 15;
            // 
            // crossOffpbox
            // 
            crossOffpbox.BackgroundImage = (Image)resources.GetObject("crossOffpbox.BackgroundImage");
            crossOffpbox.BackgroundImageLayout = ImageLayout.Stretch;
            crossOffpbox.Cursor = Cursors.Hand;
            crossOffpbox.Location = new Point(981, 31);
            crossOffpbox.Name = "crossOffpbox";
            crossOffpbox.Size = new Size(29, 26);
            crossOffpbox.TabIndex = 0;
            crossOffpbox.TabStop = false;
            crossOffpbox.Visible = false;
            crossOffpbox.Click += crossOffpbox_Click;
            // 
            // EditParts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1052, 609);
            Controls.Add(crossOffpbox);
            Controls.Add(Titlelbl);
            Controls.Add(OuterBorderpnl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditParts";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            InnerBorderpnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)toEditGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)submitAddpbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)SearchButton).EndInit();
            OuterBorderpnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)crossOffpbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private ComboBox departmentcmbox;
        private Label label2;
        private TextBox searchtxt;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label4;
        private Label Titlelbl;
        private Panel InnerBorderpnl;
        private Panel OuterBorderpnl;
        private Panel panel1;
        private ComboBox partNumbercmbox;
        private Label label5;
        private PictureBox SearchButton;
        private DataGridView toEditGridView;
        private ComboBox addPartcmbox;
        private TextBox addParttxt;
        private Label label6;
        private Label label7;
        private PictureBox submitAddpbox;
        private PictureBox crossOffpbox;
    }
}