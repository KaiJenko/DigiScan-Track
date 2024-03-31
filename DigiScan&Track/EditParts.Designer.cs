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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
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
            panel1 = new Panel();
            SearchButton = new PictureBox();
            partNumbercmbox = new ComboBox();
            label5 = new Label();
            OuterBorderpnl = new Panel();
            xbtn = new Button();
            toEditGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            InnerBorderpnl.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SearchButton).BeginInit();
            OuterBorderpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toEditGridView).BeginInit();
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
            label4.Location = new Point(29, 241);
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
            // panel1
            // 
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
            panel1.Location = new Point(22, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 411);
            panel1.TabIndex = 14;
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
            // xbtn
            // 
            xbtn.Location = new Point(988, 28);
            xbtn.Margin = new Padding(2);
            xbtn.Name = "xbtn";
            xbtn.Size = new Size(45, 20);
            xbtn.TabIndex = 16;
            xbtn.Text = "X";
            xbtn.UseVisualStyleBackColor = true;
            xbtn.Visible = false;
            xbtn.Click += xbtn_Click;
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
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Coral;
            dataGridViewCellStyle2.Padding = new Padding(25, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
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
            toEditGridView.Location = new Point(487, 24);
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
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            toEditGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            toEditGridView.RowTemplate.Height = 25;
            toEditGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            toEditGridView.Size = new Size(507, 472);
            toEditGridView.TabIndex = 29;
            // 
            // EditParts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1052, 609);
            Controls.Add(xbtn);
            Controls.Add(Titlelbl);
            Controls.Add(OuterBorderpnl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditParts";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            InnerBorderpnl.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SearchButton).EndInit();
            OuterBorderpnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)toEditGridView).EndInit();
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
        private Button xbtn;
        private DataGridView toEditGridView;
    }
}