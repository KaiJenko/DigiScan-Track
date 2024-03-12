namespace DigiScan_Track
{
    partial class DisplayBoard
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
            agedlbl = new Label();
            agedcmb = new ComboBox();
            dataGridView1 = new DataGridView();
            Titlelbl = new Label();
            BodyLayoutpnl = new Panel();
            Borderpnl = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            BodyLayoutpnl.SuspendLayout();
            Borderpnl.SuspendLayout();
            SuspendLayout();
            // 
            // agedlbl
            // 
            agedlbl.AutoSize = true;
            agedlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            agedlbl.Location = new Point(28, 18);
            agedlbl.Name = "agedlbl";
            agedlbl.Size = new Size(394, 21);
            agedlbl.TabIndex = 9;
            agedlbl.Text = "This Board Displays Everything Scanned in the last";
            // 
            // agedcmb
            // 
            agedcmb.BackColor = SystemColors.Window;
            agedcmb.FlatStyle = FlatStyle.Popup;
            agedcmb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            agedcmb.FormattingEnabled = true;
            agedcmb.Items.AddRange(new object[] { " 2  Minutes ", " 5  Minutes", "10 Minutes", " 1  Hour" });
            agedcmb.Location = new Point(428, 15);
            agedcmb.Name = "agedcmb";
            agedcmb.Size = new Size(149, 29);
            agedcmb.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(992, 459);
            dataGridView1.TabIndex = 11;
            // 
            // Titlelbl
            // 
            Titlelbl.AutoSize = true;
            Titlelbl.BackColor = Color.Transparent;
            Titlelbl.Font = new Font("Taurus Mono Outline", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            Titlelbl.ForeColor = Color.White;
            Titlelbl.Location = new Point(95, 10);
            Titlelbl.Name = "Titlelbl";
            Titlelbl.Size = new Size(884, 47);
            Titlelbl.TabIndex = 12;
            Titlelbl.Text = "DigiScan && Track - Display Board";
            Titlelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BodyLayoutpnl
            // 
            BodyLayoutpnl.BackColor = Color.FromArgb(46, 51, 73);
            BodyLayoutpnl.Controls.Add(dataGridView1);
            BodyLayoutpnl.Controls.Add(agedcmb);
            BodyLayoutpnl.Controls.Add(agedlbl);
            BodyLayoutpnl.Location = new Point(4, 3);
            BodyLayoutpnl.Name = "BodyLayoutpnl";
            BodyLayoutpnl.Size = new Size(1013, 522);
            BodyLayoutpnl.TabIndex = 11;
            // 
            // Borderpnl
            // 
            Borderpnl.Anchor = AnchorStyles.None;
            Borderpnl.BackColor = Color.FromArgb(24, 30, 54);
            Borderpnl.Controls.Add(BodyLayoutpnl);
            Borderpnl.Location = new Point(16, 69);
            Borderpnl.Name = "Borderpnl";
            Borderpnl.Size = new Size(1020, 528);
            Borderpnl.TabIndex = 14;
            // 
            // DisplayBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1052, 609);
            Controls.Add(Titlelbl);
            Controls.Add(Borderpnl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DisplayBoard";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            BodyLayoutpnl.ResumeLayout(false);
            BodyLayoutpnl.PerformLayout();
            Borderpnl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label agedlbl;
        private ComboBox agedcmb;
        private DataGridView dataGridView1;
        private Label Titlelbl;
        private Panel BodyLayoutpnl;
        private Panel Borderpnl;
    }
}