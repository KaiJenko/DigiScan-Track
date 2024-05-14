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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
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
            resetbtn = new Button();
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
            editHelppbox = new PictureBox();
            EditHelp = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            InnerBorderpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toEditGridView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)submitAddpbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SearchButton).BeginInit();
            OuterBorderpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)crossOffpbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editHelppbox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(24, 30, 54);
            pictureBox1.Location = new Point(25, 85);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(632, 698);
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
            departmentcmbox.Location = new Point(305, 50);
            departmentcmbox.Margin = new Padding(5);
            departmentcmbox.Name = "departmentcmbox";
            departmentcmbox.Size = new Size(286, 40);
            departmentcmbox.TabIndex = 7;
            departmentcmbox.SelectedIndexChanged += Departmentcmbox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(46, 51, 73);
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(78, 209);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(212, 78);
            label2.TabIndex = 8;
            label2.Text = "Scan 2D Barcode from Unit:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // searchtxt
            // 
            searchtxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchtxt.Location = new Point(305, 228);
            searchtxt.Margin = new Padding(5);
            searchtxt.Name = "searchtxt";
            searchtxt.Size = new Size(286, 39);
            searchtxt.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(46, 51, 73);
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(42, 143);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(249, 32);
            label1.TabIndex = 6;
            label1.Text = "Select Part Number:";
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(46, 51, 73);
            label3.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(5, 3);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(320, 47);
            label3.TabIndex = 10;
            label3.Text = "Search for Part to Edit";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaptionText;
            pictureBox2.Location = new Point(3, 391);
            pictureBox2.Margin = new Padding(5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(615, 3);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(46, 51, 73);
            label4.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(5, 402);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(545, 47);
            label4.TabIndex = 12;
            label4.Text = "Add New Part Number - Admin Only";
            // 
            // Titlelbl
            // 
            Titlelbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Titlelbl.BackColor = Color.Transparent;
            Titlelbl.Font = new Font("Taurus Mono Outline", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            Titlelbl.ForeColor = Color.White;
            Titlelbl.Location = new Point(65, 16);
            Titlelbl.Margin = new Padding(5, 0, 5, 0);
            Titlelbl.Name = "Titlelbl";
            Titlelbl.Size = new Size(1288, 78);
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
            InnerBorderpnl.Location = new Point(5, 5);
            InnerBorderpnl.Margin = new Padding(5);
            InnerBorderpnl.Name = "InnerBorderpnl";
            InnerBorderpnl.Size = new Size(1447, 870);
            InnerBorderpnl.TabIndex = 11;
            // 
            // toEditGridView
            // 
            toEditGridView.AllowUserToAddRows = false;
            toEditGridView.AllowUserToDeleteRows = false;
            toEditGridView.AllowUserToResizeColumns = false;
            toEditGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(113, 96, 232);
            toEditGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            toEditGridView.BackgroundColor = Color.FromArgb(113, 96, 232);
            toEditGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            toEditGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            toEditGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Coral;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle2.SelectionForeColor = Color.Coral;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            toEditGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            toEditGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            toEditGridView.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            toEditGridView.DefaultCellStyle = dataGridViewCellStyle3;
            toEditGridView.EnableHeadersVisualStyles = false;
            toEditGridView.GridColor = Color.Silver;
            toEditGridView.Location = new Point(685, 40);
            toEditGridView.Margin = new Padding(5);
            toEditGridView.MultiSelect = false;
            toEditGridView.Name = "toEditGridView";
            toEditGridView.ReadOnly = true;
            toEditGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            toEditGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            toEditGridView.RowHeadersVisible = false;
            toEditGridView.RowHeadersWidth = 62;
            toEditGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            toEditGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            toEditGridView.RowTemplate.Height = 50;
            toEditGridView.RowTemplate.Resizable = DataGridViewTriState.False;
            toEditGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            toEditGridView.Size = new Size(728, 787);
            toEditGridView.TabIndex = 29;
            toEditGridView.CellContentClick += ToEditGridView_CellContentClick;
            toEditGridView.CellMouseEnter += ToEditgridview_CellMouseEnter;
            toEditGridView.CellMouseLeave += ToEditgridview_CellMouseLeave;
            toEditGridView.CellPainting += ToEditGridView_CellPainting;
            // 
            // panel1
            // 
            panel1.Controls.Add(resetbtn);
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
            panel1.Location = new Point(32, 91);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(620, 685);
            panel1.TabIndex = 14;
            // 
            // resetbtn
            // 
            resetbtn.BackColor = Color.Transparent;
            resetbtn.BackgroundImage = (Image)resources.GetObject("resetbtn.BackgroundImage");
            resetbtn.BackgroundImageLayout = ImageLayout.Stretch;
            resetbtn.Cursor = Cursors.Hand;
            resetbtn.FlatAppearance.BorderSize = 0;
            resetbtn.FlatStyle = FlatStyle.Flat;
            resetbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            resetbtn.ForeColor = Color.White;
            resetbtn.Location = new Point(492, 287);
            resetbtn.Margin = new Padding(5);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(98, 41);
            resetbtn.TabIndex = 33;
            resetbtn.Text = "Reset";
            resetbtn.UseVisualStyleBackColor = false;
            resetbtn.Click += resetbtn_Click;
            // 
            // submitAddpbox
            // 
            submitAddpbox.BackColor = Color.White;
            submitAddpbox.BackgroundImage = (Image)resources.GetObject("submitAddpbox.BackgroundImage");
            submitAddpbox.BackgroundImageLayout = ImageLayout.Stretch;
            submitAddpbox.Cursor = Cursors.Hand;
            submitAddpbox.Location = new Point(558, 598);
            submitAddpbox.Margin = new Padding(5);
            submitAddpbox.Name = "submitAddpbox";
            submitAddpbox.Size = new Size(28, 34);
            submitAddpbox.TabIndex = 27;
            submitAddpbox.TabStop = false;
            submitAddpbox.Click += SubmitAddpbox_Click;
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
            addPartcmbox.Location = new Point(305, 493);
            addPartcmbox.Margin = new Padding(5);
            addPartcmbox.Name = "addPartcmbox";
            addPartcmbox.Size = new Size(286, 40);
            addPartcmbox.TabIndex = 24;
            addPartcmbox.SelectedIndexChanged += Departmentcmbox_SelectedIndexChanged;
            // 
            // addParttxt
            // 
            addParttxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addParttxt.Location = new Point(305, 597);
            addParttxt.Margin = new Padding(5);
            addParttxt.Name = "addParttxt";
            addParttxt.Size = new Size(286, 39);
            addParttxt.TabIndex = 23;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.White;
            SearchButton.BackgroundImage = Properties.Resources.MagnifyingGlass;
            SearchButton.BackgroundImageLayout = ImageLayout.Stretch;
            SearchButton.Cursor = Cursors.Hand;
            SearchButton.Location = new Point(557, 232);
            SearchButton.Margin = new Padding(5);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(28, 34);
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
            partNumbercmbox.Items.AddRange(new object[] { "\"\"" });
            partNumbercmbox.Location = new Point(305, 138);
            partNumbercmbox.Margin = new Padding(5);
            partNumbercmbox.Name = "partNumbercmbox";
            partNumbercmbox.Size = new Size(286, 40);
            partNumbercmbox.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(46, 51, 73);
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(52, 55);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(238, 32);
            label5.TabIndex = 13;
            label5.Text = "Select Department:";
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(46, 51, 73);
            label6.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(38, 493);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(268, 47);
            label6.TabIndex = 25;
            label6.Text = "Choose Department:";
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(46, 51, 73);
            label7.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(50, 593);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(255, 48);
            label7.TabIndex = 26;
            label7.Text = "Input Part Number:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // OuterBorderpnl
            // 
            OuterBorderpnl.Anchor = AnchorStyles.None;
            OuterBorderpnl.BackColor = Color.FromArgb(24, 30, 54);
            OuterBorderpnl.Controls.Add(InnerBorderpnl);
            OuterBorderpnl.Location = new Point(23, 115);
            OuterBorderpnl.Margin = new Padding(5);
            OuterBorderpnl.Name = "OuterBorderpnl";
            OuterBorderpnl.Size = new Size(1457, 880);
            OuterBorderpnl.TabIndex = 15;
            // 
            // crossOffpbox
            // 
            crossOffpbox.BackgroundImage = (Image)resources.GetObject("crossOffpbox.BackgroundImage");
            crossOffpbox.BackgroundImageLayout = ImageLayout.Stretch;
            crossOffpbox.Cursor = Cursors.Hand;
            crossOffpbox.Location = new Point(1402, 52);
            crossOffpbox.Margin = new Padding(5);
            crossOffpbox.Name = "crossOffpbox";
            crossOffpbox.Size = new Size(42, 43);
            crossOffpbox.TabIndex = 0;
            crossOffpbox.TabStop = false;
            crossOffpbox.Visible = false;
            crossOffpbox.Click += CrossOffpbox_Click;
            // 
            // editHelppbox
            // 
            editHelppbox.BackColor = Color.FromArgb(46, 51, 73);
            editHelppbox.Cursor = Cursors.Help;
            editHelppbox.Image = (Image)resources.GetObject("editHelppbox.Image");
            editHelppbox.Location = new Point(1452, 16);
            editHelppbox.Margin = new Padding(5);
            editHelppbox.Name = "editHelppbox";
            editHelppbox.Size = new Size(35, 41);
            editHelppbox.SizeMode = PictureBoxSizeMode.Zoom;
            editHelppbox.TabIndex = 21;
            editHelppbox.TabStop = false;
            EditHelp.SetToolTip(editHelppbox, "Select a part from the table and it will take you to a page\r\nwhere the parts details can be changed. User must have\r\nAdmin rights to make edits on parts.\r\n");
            // 
            // EditHelp
            // 
            EditHelp.ToolTipIcon = ToolTipIcon.Info;
            EditHelp.ToolTipTitle = "Edit Parts Help";
            // 
            // EditParts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1503, 1015);
            Controls.Add(editHelppbox);
            Controls.Add(crossOffpbox);
            Controls.Add(Titlelbl);
            Controls.Add(OuterBorderpnl);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
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
            ((System.ComponentModel.ISupportInitialize)editHelppbox).EndInit();
            ResumeLayout(false);
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
        private Button resetbtn;
        private PictureBox editHelppbox;
        private ToolTip EditHelp;
        public PictureBox crossOffpbox;
        public Panel InnerBorderpnl;
    }
}