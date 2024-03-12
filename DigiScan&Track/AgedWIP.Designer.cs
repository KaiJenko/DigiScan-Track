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
            agedtxt = new TextBox();
            agedcmb = new ComboBox();
            excelbtn = new Button();
            tableaubtn = new Button();
            Titlelbl = new Label();
            InnerBorderpnl = new Panel();
            OuterBorderpnl = new Panel();
            ((System.ComponentModel.ISupportInitialize)AgedGridView).BeginInit();
            InnerBorderpnl.SuspendLayout();
            OuterBorderpnl.SuspendLayout();
            SuspendLayout();
            // 
            // AgedGridView
            // 
            AgedGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AgedGridView.Location = new Point(16, 57);
            AgedGridView.Name = "AgedGridView";
            AgedGridView.RowTemplate.Height = 25;
            AgedGridView.Size = new Size(982, 450);
            AgedGridView.TabIndex = 2;
            // 
            // agedlbl
            // 
            agedlbl.AutoSize = true;
            agedlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            agedlbl.Location = new Point(16, 19);
            agedlbl.Name = "agedlbl";
            agedlbl.Size = new Size(166, 21);
            agedlbl.TabIndex = 8;
            agedlbl.Text = "Search Days as Aged";
            // 
            // agedtxt
            // 
            agedtxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            agedtxt.Location = new Point(347, 16);
            agedtxt.Name = "agedtxt";
            agedtxt.Size = new Size(175, 29);
            agedtxt.TabIndex = 7;
            // 
            // agedcmb
            // 
            agedcmb.BackColor = SystemColors.Window;
            agedcmb.FlatStyle = FlatStyle.Popup;
            agedcmb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            agedcmb.FormattingEnabled = true;
            agedcmb.Items.AddRange(new object[] { "=", "<", ">", "<=", ">=", "Range" });
            agedcmb.Location = new Point(188, 16);
            agedcmb.Name = "agedcmb";
            agedcmb.Size = new Size(149, 29);
            agedcmb.TabIndex = 6;
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
            InnerBorderpnl.Controls.Add(AgedGridView);
            InnerBorderpnl.Controls.Add(tableaubtn);
            InnerBorderpnl.Controls.Add(agedlbl);
            InnerBorderpnl.Controls.Add(excelbtn);
            InnerBorderpnl.Controls.Add(agedtxt);
            InnerBorderpnl.Controls.Add(agedcmb);
            InnerBorderpnl.Location = new Point(4, 3);
            InnerBorderpnl.Name = "InnerBorderpnl";
            InnerBorderpnl.Size = new Size(1013, 522);
            InnerBorderpnl.TabIndex = 11;
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
            OuterBorderpnl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView AgedGridView;
        private Label agedlbl;
        private TextBox agedtxt;
        private ComboBox agedcmb;
        private Button excelbtn;
        private Button tableaubtn;
        private Label Titlelbl;
        private Panel InnerBorderpnl;
        private Panel OuterBorderpnl;
    }
}