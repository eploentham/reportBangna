namespace reportBangna.gui
{
    partial class FrmCheckNHSOAdd
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
            this.pB1 = new System.Windows.Forms.ProgressBar();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lB1 = new System.Windows.Forms.ListBox();
            this.dgvAdd = new System.Windows.Forms.DataGridView();
            this.btnImport = new System.Windows.Forms.Button();
            this.chkUnDel = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // pB1
            // 
            this.pB1.Location = new System.Drawing.Point(12, 553);
            this.pB1.Name = "pB1";
            this.pB1.Size = new System.Drawing.Size(883, 23);
            this.pB1.TabIndex = 0;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(273, 26);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(122, 22);
            this.dtpEnd.TabIndex = 7;
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(90, 26);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(124, 22);
            this.dtpStart.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "ถึงวันที่";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "ตั้งแต่วันที่";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(520, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 36);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Convert";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lB1
            // 
            this.lB1.FormattingEnabled = true;
            this.lB1.ItemHeight = 16;
            this.lB1.Location = new System.Drawing.Point(23, 60);
            this.lB1.Name = "lB1";
            this.lB1.Size = new System.Drawing.Size(872, 484);
            this.lB1.TabIndex = 9;
            // 
            // dgvAdd
            // 
            this.dgvAdd.AllowDrop = true;
            this.dgvAdd.AllowUserToAddRows = false;
            this.dgvAdd.AllowUserToDeleteRows = false;
            this.dgvAdd.AllowUserToResizeRows = false;
            this.dgvAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdd.Location = new System.Drawing.Point(725, 6);
            this.dgvAdd.MultiSelect = false;
            this.dgvAdd.Name = "dgvAdd";
            this.dgvAdd.RowTemplate.Height = 24;
            this.dgvAdd.Size = new System.Drawing.Size(165, 42);
            this.dgvAdd.TabIndex = 10;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(770, 18);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(120, 36);
            this.btnImport.TabIndex = 11;
            this.btnImport.Text = "นำเข้าจากสาขา";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnChk_Click);
            // 
            // chkUnDel
            // 
            this.chkUnDel.AutoSize = true;
            this.chkUnDel.Location = new System.Drawing.Point(411, 18);
            this.chkUnDel.Name = "chkUnDel";
            this.chkUnDel.Size = new System.Drawing.Size(90, 21);
            this.chkUnDel.TabIndex = 12;
            this.chkUnDel.Text = "ไม่ลบข้อมูล";
            this.chkUnDel.UseVisualStyleBackColor = true;
            // 
            // FrmCheckNHSOAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 588);
            this.Controls.Add(this.chkUnDel);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.dgvAdd);
            this.Controls.Add(this.lB1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pB1);
            this.Name = "FrmCheckNHSOAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCheckNHSOAdd";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCheckNHSOAdd_FormClosing);
            this.Load += new System.EventHandler(this.FrmCheckNHSOAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pB1;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lB1;
        private System.Windows.Forms.DataGridView dgvAdd;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.CheckBox chkUnDel;
    }
}