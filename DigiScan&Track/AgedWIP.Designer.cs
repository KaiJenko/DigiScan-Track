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
            AgedGridView = new DataGridView();
            agedlbl = new Label();
            excelbtn = new Button();
            tableaubtn = new Button();
            Titlelbl = new Label();
            InnerBorderpnl = new Panel();
            furtherDetailsgridview = new DataGridView();
            counttrackbarlbl = new Label();
            agedDaystrackbar = new TrackBar();
            panel1 = new Panel();
            radioButton1 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            OuterBorderpnl = new Panel();
            ((System.ComponentModel.ISupportInitialize)AgedGridView).BeginInit();
            InnerBorderpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)furtherDetailsgridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)agedDaystrackbar).BeginInit();
            panel1.SuspendLayout();
            OuterBorderpnl.SuspendLayout();
            SuspendLayout();
            // 
            // AgedGridView
            // 
            AgedGridView.BackgroundColor = Color.FromArgb(45, 66, 91);
            AgedGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AgedGridView.Location = new Point(54, 70);
            AgedGridView.Name = "AgedGridView";
            AgedGridView.RowHeadersWidth = 62;
            AgedGridView.RowTemplate.Height = 25;
            AgedGridView.Size = new Size(313, 439);
            AgedGridView.TabIndex = 2;
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
            InnerBorderpnl.Controls.Add(furtherDetailsgridview);
            InnerBorderpnl.Controls.Add(counttrackbarlbl);
            InnerBorderpnl.Controls.Add(AgedGridView);
            InnerBorderpnl.Controls.Add(agedDaystrackbar);
            InnerBorderpnl.Controls.Add(panel1);
            InnerBorderpnl.Controls.Add(tableaubtn);
            InnerBorderpnl.Controls.Add(agedlbl);
            InnerBorderpnl.Controls.Add(excelbtn);
            InnerBorderpnl.Location = new Point(4, 3);
            InnerBorderpnl.Name = "InnerBorderpnl";
            InnerBorderpnl.Size = new Size(1013, 522);
            InnerBorderpnl.TabIndex = 11;
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
            counttrackbarlbl.Location = new Point(551, 9);
            counttrackbarlbl.Name = "counttrackbarlbl";
            counttrackbarlbl.Size = new Size(23, 25);
            counttrackbarlbl.TabIndex = 18;
            counttrackbarlbl.Text = "0";
            // 
            // agedDaystrackbar
            // 
            agedDaystrackbar.Location = new Point(335, 33);
            agedDaystrackbar.Maximum = 50;
            agedDaystrackbar.Name = "agedDaystrackbar";
            agedDaystrackbar.Size = new Size(451, 45);
            agedDaystrackbar.TabIndex = 17;
            agedDaystrackbar.Scroll += agedDaystrackbar_Scroll;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(radioButton4);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton3);
            panel1.Location = new Point(187, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(109, 59);
            panel1.TabIndex = 15;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = Color.Coral;
            radioButton1.Location = new Point(2, 3);
            radioButton1.Margin = new Padding(2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(33, 19);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "=";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.ForeColor = Color.Coral;
            radioButton4.Location = new Point(49, 35);
            radioButton4.Margin = new Padding(2);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(33, 19);
            radioButton4.TabIndex = 14;
            radioButton4.TabStop = true;
            radioButton4.Text = ">";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = Color.Coral;
            radioButton2.Location = new Point(49, 4);
            radioButton2.Margin = new Padding(2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(58, 19);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "Range";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.ForeColor = Color.Coral;
            radioButton3.Location = new Point(2, 35);
            radioButton3.Margin = new Padding(2);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(33, 19);
            radioButton3.TabIndex = 13;
            radioButton3.TabStop = true;
            radioButton3.Text = "<";
            radioButton3.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)AgedGridView).EndInit();
            InnerBorderpnl.ResumeLayout(false);
            InnerBorderpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)furtherDetailsgridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)agedDaystrackbar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            OuterBorderpnl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView AgedGridView;
        private Label agedlbl;
        private Button excelbtn;
        private Button tableaubtn;
        private Label Titlelbl;
        private Panel InnerBorderpnl;
        private Panel OuterBorderpnl;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Panel panel1;
        private TrackBar agedDaystrackbar;
        private Label counttrackbarlbl;
        private DataGridView furtherDetailsgridview;
    }
}