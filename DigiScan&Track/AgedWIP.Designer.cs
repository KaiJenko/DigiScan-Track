namespace DigiScan_Track
{
    partial class AgedWIP
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            agedlbl = new Label();
            excelbtn = new Button();
            tableaubtn = new Button();
            Titlelbl = new Label();
            InnerBorderpnl = new Panel();
            SeachButton = new PictureBox();
            Agedgridview = new DataGridView();
            furtherDetailsgridview = new DataGridView();
            counttrackbarlbl = new Label();
            agedDaystrackbar = new TrackBar();
            radiobuttonpnl = new Panel();
            equalsrbtn = new RadioButton();
            greaterThanrbtn = new RadioButton();
            rangerbtn = new RadioButton();
            lessThanrbtn = new RadioButton();
            OuterBorderpnl = new Panel();
            InnerBorderpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SeachButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Agedgridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)furtherDetailsgridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)agedDaystrackbar).BeginInit();
            radiobuttonpnl.SuspendLayout();
            OuterBorderpnl.SuspendLayout();
            SuspendLayout();
            // 
            // agedlbl
            // 
            agedlbl.AutoSize = true;
            agedlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            agedlbl.ForeColor = Color.Coral;
            agedlbl.Location = new Point(16, 23);
            agedlbl.Name = "agedlbl";
            agedlbl.Size = new Size(166, 21);
            agedlbl.TabIndex = 8;
            agedlbl.Text = "Search Days as Aged";
            // 
            // excelbtn
            // 
            excelbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            excelbtn.Location = new Point(827, 9);
            excelbtn.Name = "excelbtn";
            excelbtn.Size = new Size(69, 42);
            excelbtn.TabIndex = 9;
            excelbtn.Text = "Excel Export";
            excelbtn.UseVisualStyleBackColor = true;
            // 
            // tableaubtn
            // 
            tableaubtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tableaubtn.Location = new Point(911, 9);
            tableaubtn.Name = "tableaubtn";
            tableaubtn.Size = new Size(69, 42);
            tableaubtn.TabIndex = 10;
            tableaubtn.Text = "Tableau Metrics";
            tableaubtn.UseVisualStyleBackColor = true;
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
            Titlelbl.Size = new Size(749, 47);
            Titlelbl.TabIndex = 13;
            Titlelbl.Text = "DigiScan && Track - Aged WIP\r\n";
            Titlelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InnerBorderpnl
            // 
            InnerBorderpnl.Anchor = AnchorStyles.None;
            InnerBorderpnl.BackColor = Color.FromArgb(46, 51, 73);
            InnerBorderpnl.Controls.Add(SeachButton);
            InnerBorderpnl.Controls.Add(Agedgridview);
            InnerBorderpnl.Controls.Add(furtherDetailsgridview);
            InnerBorderpnl.Controls.Add(counttrackbarlbl);
            InnerBorderpnl.Controls.Add(agedDaystrackbar);
            InnerBorderpnl.Controls.Add(radiobuttonpnl);
            InnerBorderpnl.Controls.Add(tableaubtn);
            InnerBorderpnl.Controls.Add(agedlbl);
            InnerBorderpnl.Controls.Add(excelbtn);
            InnerBorderpnl.Location = new Point(4, 3);
            InnerBorderpnl.Name = "InnerBorderpnl";
            InnerBorderpnl.Size = new Size(1013, 522);
            InnerBorderpnl.TabIndex = 11;
            // 
            // SeachButton
            // 
            SeachButton.BackgroundImage = Properties.Resources.MagnifyingGlass1;
            SeachButton.BackgroundImageLayout = ImageLayout.Stretch;
            SeachButton.Location = new Point(570, 13);
            SeachButton.Name = "SeachButton";
            SeachButton.Size = new Size(20, 20);
            SeachButton.TabIndex = 21;
            SeachButton.TabStop = false;
            SeachButton.Click += SearchButton_Click;
            // 
            // Agedgridview
            // 
            Agedgridview.BackgroundColor = Color.FromArgb(45, 66, 91);
            Agedgridview.BorderStyle = BorderStyle.None;
            Agedgridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            Agedgridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            Agedgridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            Agedgridview.DefaultCellStyle = dataGridViewCellStyle6;
            Agedgridview.GridColor = Color.White;
            Agedgridview.Location = new Point(50, 68);
            Agedgridview.Name = "Agedgridview";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            Agedgridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            Agedgridview.RowHeadersVisible = false;
            Agedgridview.RowHeadersWidth = 62;
            dataGridViewCellStyle8.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            Agedgridview.RowsDefaultCellStyle = dataGridViewCellStyle8;
            Agedgridview.RowTemplate.Height = 25;
            Agedgridview.Size = new Size(326, 439);
            Agedgridview.TabIndex = 20;
            // 
            // furtherDetailsgridview
            // 
            furtherDetailsgridview.BackgroundColor = Color.FromArgb(45, 66, 91);
            furtherDetailsgridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            furtherDetailsgridview.Location = new Point(430, 68);
            furtherDetailsgridview.Name = "furtherDetailsgridview";
            furtherDetailsgridview.RowHeadersWidth = 62;
            furtherDetailsgridview.RowTemplate.Height = 25;
            furtherDetailsgridview.Size = new Size(525, 439);
            furtherDetailsgridview.TabIndex = 19;
            // 
            // counttrackbarlbl
            // 
            counttrackbarlbl.AutoSize = true;
            counttrackbarlbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            counttrackbarlbl.ForeColor = Color.Coral;
            counttrackbarlbl.Location = new Point(544, 9);
            counttrackbarlbl.Name = "counttrackbarlbl";
            counttrackbarlbl.Size = new Size(23, 25);
            counttrackbarlbl.TabIndex = 18;
            counttrackbarlbl.Text = "0";
            // 
            // agedDaystrackbar
            // 
            agedDaystrackbar.Location = new Point(302, 33);
            agedDaystrackbar.Maximum = 50;
            agedDaystrackbar.Name = "agedDaystrackbar";
            agedDaystrackbar.Size = new Size(510, 45);
            agedDaystrackbar.TabIndex = 17;
            agedDaystrackbar.Scroll += agedDaystrackbar_Scroll;
            // 
            // radiobuttonpnl
            // 
            radiobuttonpnl.Controls.Add(equalsrbtn);
            radiobuttonpnl.Controls.Add(greaterThanrbtn);
            radiobuttonpnl.Controls.Add(rangerbtn);
            radiobuttonpnl.Controls.Add(lessThanrbtn);
            radiobuttonpnl.Location = new Point(187, 5);
            radiobuttonpnl.Name = "radiobuttonpnl";
            radiobuttonpnl.Size = new Size(109, 59);
            radiobuttonpnl.TabIndex = 15;
            // 
            // equalsrbtn
            // 
            equalsrbtn.AutoSize = true;
            equalsrbtn.Checked = true;
            equalsrbtn.ForeColor = Color.Coral;
            equalsrbtn.Location = new Point(2, 3);
            equalsrbtn.Margin = new Padding(2);
            equalsrbtn.Name = "equalsrbtn";
            equalsrbtn.Size = new Size(33, 19);
            equalsrbtn.TabIndex = 11;
            equalsrbtn.TabStop = true;
            equalsrbtn.Text = "=";
            equalsrbtn.UseVisualStyleBackColor = true;
            // 
            // greaterThanrbtn
            // 
            greaterThanrbtn.AutoSize = true;
            greaterThanrbtn.ForeColor = Color.Coral;
            greaterThanrbtn.Location = new Point(49, 35);
            greaterThanrbtn.Margin = new Padding(2);
            greaterThanrbtn.Name = "greaterThanrbtn";
            greaterThanrbtn.Size = new Size(33, 19);
            greaterThanrbtn.TabIndex = 14;
            greaterThanrbtn.Text = ">";
            greaterThanrbtn.UseVisualStyleBackColor = true;
            // 
            // rangerbtn
            // 
            rangerbtn.AutoSize = true;
            rangerbtn.ForeColor = Color.Coral;
            rangerbtn.Location = new Point(49, 4);
            rangerbtn.Margin = new Padding(2);
            rangerbtn.Name = "rangerbtn";
            rangerbtn.Size = new Size(58, 19);
            rangerbtn.TabIndex = 12;
            rangerbtn.Text = "Range";
            rangerbtn.UseVisualStyleBackColor = true;
            // 
            // lessThanrbtn
            // 
            lessThanrbtn.AutoSize = true;
            lessThanrbtn.ForeColor = Color.Coral;
            lessThanrbtn.Location = new Point(2, 35);
            lessThanrbtn.Margin = new Padding(2);
            lessThanrbtn.Name = "lessThanrbtn";
            lessThanrbtn.Size = new Size(33, 19);
            lessThanrbtn.TabIndex = 13;
            lessThanrbtn.Text = "<";
            lessThanrbtn.UseVisualStyleBackColor = true;
            // 
            // OuterBorderpnl
            // 
            OuterBorderpnl.Anchor = AnchorStyles.None;
            OuterBorderpnl.BackColor = Color.FromArgb(24, 30, 54);
            OuterBorderpnl.Controls.Add(InnerBorderpnl);
            OuterBorderpnl.Location = new Point(16, 69);
            OuterBorderpnl.Name = "OuterBorderpnl";
            OuterBorderpnl.Size = new Size(1020, 528);
            OuterBorderpnl.TabIndex = 14;
            // 
            // AgedWIP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1052, 609);
            Controls.Add(Titlelbl);
            Controls.Add(OuterBorderpnl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgedWIP";
            Text = "Form1";
            Load += Form1_Load;
            InnerBorderpnl.ResumeLayout(false);
            InnerBorderpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SeachButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)Agedgridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)furtherDetailsgridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)agedDaystrackbar).EndInit();
            radiobuttonpnl.ResumeLayout(false);
            radiobuttonpnl.PerformLayout();
            OuterBorderpnl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label agedlbl;
        private Button excelbtn;
        private Button tableaubtn;
        private Label Titlelbl;
        private Panel InnerBorderpnl;
        private Panel OuterBorderpnl;
        private RadioButton greaterThanrbtn;
        private RadioButton lessThanrbtn;
        private RadioButton rangerbtn;
        private RadioButton equalsrbtn;
        private Panel radiobuttonpnl;
        private TrackBar agedDaystrackbar;
        private Label counttrackbarlbl;
        private DataGridView furtherDetailsgridview;
        private DataGridView Agedgridview;
        private PictureBox SeachButton;
    }
}