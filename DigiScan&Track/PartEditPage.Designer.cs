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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            agedlbl = new Label();
            panel1 = new Panel();
            partTobeEditedGridView = new DataGridView();
            userInputGridView = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)partTobeEditedGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userInputGridView).BeginInit();
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
            panel1.BackColor = Color.DodgerBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(userInputGridView);
            panel1.Controls.Add(partTobeEditedGridView);
            panel1.Controls.Add(agedlbl);
            panel1.Location = new Point(71, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(860, 325);
            panel1.TabIndex = 11;
            // 
            // partTobeEditedGridView
            // 
            partTobeEditedGridView.BackgroundColor = Color.FromArgb(46, 51, 73);
            partTobeEditedGridView.BorderStyle = BorderStyle.None;
            partTobeEditedGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            partTobeEditedGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            partTobeEditedGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            partTobeEditedGridView.DefaultCellStyle = dataGridViewCellStyle6;
            partTobeEditedGridView.GridColor = Color.White;
            partTobeEditedGridView.Location = new Point(12, 52);
            partTobeEditedGridView.Name = "partTobeEditedGridView";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            partTobeEditedGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            partTobeEditedGridView.RowHeadersVisible = false;
            partTobeEditedGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle8.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            partTobeEditedGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            partTobeEditedGridView.RowTemplate.Height = 25;
            partTobeEditedGridView.Size = new Size(832, 107);
            partTobeEditedGridView.TabIndex = 16;
            // 
            // userInputGridView
            // 
            userInputGridView.BackgroundColor = Color.FromArgb(46, 51, 73);
            userInputGridView.BorderStyle = BorderStyle.None;
            userInputGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            userInputGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            userInputGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            userInputGridView.DefaultCellStyle = dataGridViewCellStyle2;
            userInputGridView.GridColor = Color.White;
            userInputGridView.Location = new Point(12, 195);
            userInputGridView.Name = "userInputGridView";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            userInputGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            userInputGridView.RowHeadersVisible = false;
            userInputGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            userInputGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            userInputGridView.RowTemplate.Height = 25;
            userInputGridView.Size = new Size(832, 107);
            userInputGridView.TabIndex = 17;
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
            ((System.ComponentModel.ISupportInitialize)partTobeEditedGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)userInputGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label agedlbl;
        private Panel panel1;
        private DataGridView partTobeEditedGridView;
        private DataGridView userInputGridView;
    }
}
