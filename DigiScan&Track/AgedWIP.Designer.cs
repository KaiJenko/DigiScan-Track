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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            agedlbl = new Label();
            excelbtn = new Button();
            tableaubtn = new Button();
            Titlelbl = new Label();
            InnerBorderpnl = new Panel();
            moreInfolbl = new Label();
            rangepnl = new Panel();
            lowerRangenud = new NumericUpDown();
            higherRangenud = new NumericUpDown();
            lowerlbl = new Label();
            upperlbl = new Label();
            searchpbox = new PictureBox();
            Agedgridview = new DataGridView();
            furtherDetailsgridview = new DataGridView();
            counttrackbarlbl = new Label();
            agedDaystrackbar = new TrackBar();
            radioButtonpnl = new Panel();
            equalsrbtn = new RadioButton();
            greaterThanrbtn = new RadioButton();
            rangerbtn = new RadioButton();
            lessThanrbtn = new RadioButton();
            OuterBorderpnl = new Panel();
            InnerBorderpnl.SuspendLayout();
            rangepnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lowerRangenud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)higherRangenud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchpbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Agedgridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)furtherDetailsgridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)agedDaystrackbar).BeginInit();
            radioButtonpnl.SuspendLayout();
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
            InnerBorderpnl.Controls.Add(moreInfolbl);
            InnerBorderpnl.Controls.Add(rangepnl);
            InnerBorderpnl.Controls.Add(searchpbox);
            InnerBorderpnl.Controls.Add(Agedgridview);
            InnerBorderpnl.Controls.Add(furtherDetailsgridview);
            InnerBorderpnl.Controls.Add(counttrackbarlbl);
            InnerBorderpnl.Controls.Add(agedDaystrackbar);
            InnerBorderpnl.Controls.Add(radioButtonpnl);
            InnerBorderpnl.Controls.Add(tableaubtn);
            InnerBorderpnl.Controls.Add(agedlbl);
            InnerBorderpnl.Controls.Add(excelbtn);
            InnerBorderpnl.Location = new Point(4, 3);
            InnerBorderpnl.Name = "InnerBorderpnl";
            InnerBorderpnl.Size = new Size(1013, 522);
            InnerBorderpnl.TabIndex = 11;
            // 
            // moreInfolbl
            // 
            moreInfolbl.AutoSize = true;
            moreInfolbl.BackColor = Color.FromArgb(45, 66, 91);
            moreInfolbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            moreInfolbl.ForeColor = Color.Coral;
            moreInfolbl.Location = new Point(459, 260);
            moreInfolbl.Name = "moreInfolbl";
            moreInfolbl.Size = new Size(413, 21);
            moreInfolbl.TabIndex = 27;
            moreInfolbl.Text = "Please select a row for more information on that part";
            // 
            // rangepnl
            // 
            rangepnl.Controls.Add(lowerRangenud);
            rangepnl.Controls.Add(higherRangenud);
            rangepnl.Controls.Add(lowerlbl);
            rangepnl.Controls.Add(upperlbl);
            rangepnl.Location = new Point(383, 32);
            rangepnl.Margin = new Padding(2);
            rangepnl.Name = "rangepnl";
            rangepnl.Size = new Size(369, 31);
            rangepnl.TabIndex = 26;
            rangepnl.Visible = false;
            // 
            // lowerRangenud
            // 
            lowerRangenud.Location = new Point(136, 7);
            lowerRangenud.Margin = new Padding(2);
            lowerRangenud.Name = "lowerRangenud";
            lowerRangenud.Size = new Size(50, 23);
            lowerRangenud.TabIndex = 22;
            // 
            // higherRangenud
            // 
            higherRangenud.Location = new Point(317, 7);
            higherRangenud.Margin = new Padding(2);
            higherRangenud.Name = "higherRangenud";
            higherRangenud.Size = new Size(50, 23);
            higherRangenud.TabIndex = 23;
            // 
            // lowerlbl
            // 
            lowerlbl.AutoSize = true;
            lowerlbl.BackColor = Color.Transparent;
            lowerlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lowerlbl.ForeColor = Color.Coral;
            lowerlbl.Location = new Point(11, 7);
            lowerlbl.Name = "lowerlbl";
            lowerlbl.Size = new Size(114, 21);
            lowerlbl.TabIndex = 24;
            lowerlbl.Text = "Lower Bound:";
            // 
            // upperlbl
            // 
            upperlbl.AutoSize = true;
            upperlbl.BackColor = Color.Transparent;
            upperlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            upperlbl.ForeColor = Color.Coral;
            upperlbl.Location = new Point(191, 7);
            upperlbl.Name = "upperlbl";
            upperlbl.Size = new Size(115, 21);
            upperlbl.TabIndex = 25;
            upperlbl.Text = "Upper Bound:";
            // 
            // searchpbox
            // 
            searchpbox.BackgroundImage = Properties.Resources.MagnifyingGlass1;
            searchpbox.BackgroundImageLayout = ImageLayout.Stretch;
            searchpbox.Location = new Point(573, 15);
            searchpbox.Name = "searchpbox";
            searchpbox.Size = new Size(20, 15);
            searchpbox.TabIndex = 21;
            searchpbox.TabStop = false;
            searchpbox.Click += SearchButton_Click;
            // 
            // Agedgridview
            // 
            Agedgridview.BackgroundColor = Color.FromArgb(45, 66, 91);
            Agedgridview.BorderStyle = BorderStyle.None;
            Agedgridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Agedgridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Agedgridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            Agedgridview.DefaultCellStyle = dataGridViewCellStyle2;
            Agedgridview.GridColor = Color.White;
            Agedgridview.Location = new Point(50, 68);
            Agedgridview.Name = "Agedgridview";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            Agedgridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            Agedgridview.RowHeadersVisible = false;
            Agedgridview.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            Agedgridview.RowsDefaultCellStyle = dataGridViewCellStyle4;
            Agedgridview.RowTemplate.Height = 25;
            Agedgridview.Size = new Size(290, 439);
            Agedgridview.TabIndex = 20;
            Agedgridview.CellContentClick += Agedgridview_CellContentClick;
            // 
            // furtherDetailsgridview
            // 
            furtherDetailsgridview.AllowUserToAddRows = false;
            furtherDetailsgridview.AllowUserToDeleteRows = false;
            furtherDetailsgridview.BackgroundColor = Color.FromArgb(45, 66, 91);
            furtherDetailsgridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            furtherDetailsgridview.Location = new Point(379, 213);
            furtherDetailsgridview.Name = "furtherDetailsgridview";
            furtherDetailsgridview.ReadOnly = true;
            furtherDetailsgridview.RowHeadersVisible = false;
            furtherDetailsgridview.RowHeadersWidth = 62;
            furtherDetailsgridview.RowTemplate.Height = 25;
            furtherDetailsgridview.Size = new Size(597, 115);
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
            // radioButtonpnl
            // 
            radioButtonpnl.Controls.Add(equalsrbtn);
            radioButtonpnl.Controls.Add(greaterThanrbtn);
            radioButtonpnl.Controls.Add(rangerbtn);
            radioButtonpnl.Controls.Add(lessThanrbtn);
            radioButtonpnl.Location = new Point(187, 5);
            radioButtonpnl.Name = "radioButtonpnl";
            radioButtonpnl.Size = new Size(109, 59);
            radioButtonpnl.TabIndex = 15;
            // 
            // equalsrbtn
            // 
            equalsrbtn.AutoSize = true;
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
            greaterThanrbtn.TabStop = true;
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
            rangerbtn.TabStop = true;
            rangerbtn.Text = "Range";
            rangerbtn.UseVisualStyleBackColor = true;
            rangerbtn.CheckedChanged += rangerbtn_Click;
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
            lessThanrbtn.TabStop = true;
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
            rangepnl.ResumeLayout(false);
            rangepnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lowerRangenud).EndInit();
            ((System.ComponentModel.ISupportInitialize)higherRangenud).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchpbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Agedgridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)furtherDetailsgridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)agedDaystrackbar).EndInit();
            radioButtonpnl.ResumeLayout(false);
            radioButtonpnl.PerformLayout();
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
        private Panel radioButtonpnl;
        private TrackBar agedDaystrackbar;
        private Label counttrackbarlbl;
        private DataGridView furtherDetailsgridview;
        private DataGridView Agedgridview;
        private PictureBox searchpbox;
        private NumericUpDown lowerRangenud;
        private NumericUpDown higherRangenud;
        private Label upperlbl;
        private Label lowerlbl;
        private Panel rangepnl;
        private Label moreInfolbl;
    }
}