namespace reportBangna.gui
{
    partial class FrmCertificatesView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvView
            // 
            this.dgvView.BackgroundColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.GridColor = System.Drawing.Color.Pink;
            this.dgvView.Location = new System.Drawing.Point(16, 121);
            this.dgvView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvView.Name = "dgvView";
            this.dgvView.Size = new System.Drawing.Size(1301, 830);
            this.dgvView.TabIndex = 0;
            this.dgvView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvView_CellDoubleClick);
            this.dgvView.DoubleClick += new System.EventHandler(this.dgvView_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ปี :";
            // 
            // cboYear
            // 
            this.cboYear.BackColor = System.Drawing.Color.Pink;
            this.cboYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(93, 38);
            this.cboYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(160, 28);
            this.cboYear.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "เดือน :";
            // 
            // cboMonth
            // 
            this.cboMonth.BackColor = System.Drawing.Color.Pink;
            this.cboMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(517, 38);
            this.cboMonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(160, 28);
            this.cboMonth.TabIndex = 4;
            this.cboMonth.Click += new System.EventHandler(this.cboMonth_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Pink;
            this.btnAdd.Location = new System.Drawing.Point(1131, 15);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(187, 80);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "ป้อนใหม่";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmCertificatesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1337, 962);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCertificatesView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCertificatesView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCertificatesView_FormClosing);
            this.Load += new System.EventHandler(this.FrmCertificatesView_Load);
            this.Resize += new System.EventHandler(this.FrmCertificatesView_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.Button btnAdd;
    }
}