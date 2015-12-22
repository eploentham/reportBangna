namespace reportBangna.gui
{
    partial class FrmOPDCheckUPView
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
            this.chkActive = new System.Windows.Forms.RadioButton();
            this.chkUnActive = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.SuspendLayout();
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(670, 16);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(56, 17);
            this.chkActive.TabIndex = 56;
            this.chkActive.TabStop = true;
            this.chkActive.Text = "ใช้งาน";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // chkUnActive
            // 
            this.chkUnActive.AutoSize = true;
            this.chkUnActive.Location = new System.Drawing.Point(783, 16);
            this.chkUnActive.Name = "chkUnActive";
            this.chkUnActive.Size = new System.Drawing.Size(57, 17);
            this.chkUnActive.TabIndex = 55;
            this.chkUnActive.TabStop = true;
            this.chkUnActive.Text = "ยกเลิก";
            this.chkUnActive.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(940, 12);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 39);
            this.btnAdd.TabIndex = 54;
            this.btnAdd.Text = "ป้อนใหม่";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvView
            // 
            this.dgvView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Location = new System.Drawing.Point(11, 66);
            this.dgvView.Margin = new System.Windows.Forms.Padding(2);
            this.dgvView.Name = "dgvView";
            this.dgvView.RowTemplate.Height = 24;
            this.dgvView.Size = new System.Drawing.Size(985, 434);
            this.dgvView.TabIndex = 53;
            this.dgvView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvView_CellDoubleClick);
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(70, 19);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(94, 20);
            this.dtpStart.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "วันที่ :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(270, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(94, 20);
            this.dateTimePicker1.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "ถึงวันที่ :";
            // 
            // FrmOPDCheckUPView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 728);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.chkUnActive);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvView);
            this.Name = "FrmOPDCheckUPView";
            this.Text = "FrmOPDCheckUPView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmOPDCheckUPView_Load);
            this.Resize += new System.EventHandler(this.FrmOPDCheckUPView_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton chkActive;
        private System.Windows.Forms.RadioButton chkUnActive;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
    }
}