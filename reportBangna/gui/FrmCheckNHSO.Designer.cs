namespace reportBangna.gui
{
    partial class FrmCheckNHSO
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cboBranch = new System.Windows.Forms.ComboBox();
            this.chkDoctorEdit = new System.Windows.Forms.CheckBox();
            this.chkLabError = new System.Windows.Forms.CheckBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtLabSearch2 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboLab = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLabSearch1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.pB1 = new System.Windows.Forms.ProgressBar();
            this.btnOK = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudDrug = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudChronic = new System.Windows.Forms.NumericUpDown();
            this.chkDrug = new System.Windows.Forms.CheckBox();
            this.dgvAdd = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChronic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdd)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.cboBranch);
            this.groupBox1.Controls.Add(this.chkDoctorEdit);
            this.groupBox1.Controls.Add(this.chkLabError);
            this.groupBox1.Controls.Add(this.btnConvert);
            this.groupBox1.Controls.Add(this.txtLabSearch2);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.cboLab);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtLabSearch1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.pB1);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(922, 58);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(799, 31);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(56, 23);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cboBranch
            // 
            this.cboBranch.FormattingEnabled = true;
            this.cboBranch.Location = new System.Drawing.Point(463, 11);
            this.cboBranch.Margin = new System.Windows.Forms.Padding(2);
            this.cboBranch.Name = "cboBranch";
            this.cboBranch.Size = new System.Drawing.Size(92, 21);
            this.cboBranch.TabIndex = 28;
            // 
            // chkDoctorEdit
            // 
            this.chkDoctorEdit.AutoSize = true;
            this.chkDoctorEdit.Location = new System.Drawing.Point(387, 12);
            this.chkDoctorEdit.Margin = new System.Windows.Forms.Padding(2);
            this.chkDoctorEdit.Name = "chkDoctorEdit";
            this.chkDoctorEdit.Size = new System.Drawing.Size(76, 17);
            this.chkDoctorEdit.TabIndex = 27;
            this.chkDoctorEdit.Text = "doctor edit";
            this.chkDoctorEdit.UseVisualStyleBackColor = true;
            // 
            // chkLabError
            // 
            this.chkLabError.AutoSize = true;
            this.chkLabError.Location = new System.Drawing.Point(302, 12);
            this.chkLabError.Margin = new System.Windows.Forms.Padding(2);
            this.chkLabError.Name = "chkLabError";
            this.chkLabError.Size = new System.Drawing.Size(83, 17);
            this.chkLabError.TabIndex = 26;
            this.chkLabError.Text = "ดึง Lab error";
            this.chkLabError.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(676, 11);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(2);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(26, 39);
            this.btnConvert.TabIndex = 25;
            this.btnConvert.Text = "...";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtLabSearch2
            // 
            this.txtLabSearch2.Location = new System.Drawing.Point(505, 36);
            this.txtLabSearch2.Margin = new System.Windows.Forms.Padding(2);
            this.txtLabSearch2.Name = "txtLabSearch2";
            this.txtLabSearch2.Size = new System.Drawing.Size(50, 20);
            this.txtLabSearch2.TabIndex = 24;
            this.txtLabSearch2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLabSearch2_KeyUp);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(614, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 37);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboLab
            // 
            this.cboLab.FormattingEnabled = true;
            this.cboLab.Location = new System.Drawing.Point(215, 34);
            this.cboLab.Margin = new System.Windows.Forms.Padding(2);
            this.cboLab.Name = "cboLab";
            this.cboLab.Size = new System.Drawing.Size(224, 21);
            this.cboLab.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(158, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "ค้นหา lab :";
            // 
            // txtLabSearch1
            // 
            this.txtLabSearch1.Location = new System.Drawing.Point(452, 36);
            this.txtLabSearch1.Margin = new System.Windows.Forms.Padding(2);
            this.txtLabSearch1.Name = "txtLabSearch1";
            this.txtLabSearch1.Size = new System.Drawing.Size(50, 20);
            this.txtLabSearch1.TabIndex = 19;
            this.txtLabSearch1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLabSearch_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "ค้นหา ยา :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(60, 34);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(76, 20);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(708, 12);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 37);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Export Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // pB1
            // 
            this.pB1.Location = new System.Drawing.Point(800, 19);
            this.pB1.Name = "pB1";
            this.pB1.Size = new System.Drawing.Size(31, 23);
            this.pB1.TabIndex = 7;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(560, 11);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(48, 39);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "ดึงข้อมูล";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(197, 11);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(92, 20);
            this.dtpEnd.TabIndex = 3;
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(60, 11);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(94, 20);
            this.dtpStart.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ถึงวันที่";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ตั้งแต่วันที่";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Lab";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(296, 29);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(34, 20);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Drug";
            // 
            // nudDrug
            // 
            this.nudDrug.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDrug.Location = new System.Drawing.Point(225, 29);
            this.nudDrug.Margin = new System.Windows.Forms.Padding(2);
            this.nudDrug.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudDrug.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDrug.Name = "nudDrug";
            this.nudDrug.Size = new System.Drawing.Size(34, 20);
            this.nudDrug.TabIndex = 12;
            this.nudDrug.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Chronic";
            // 
            // nudChronic
            // 
            this.nudChronic.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudChronic.Location = new System.Drawing.Point(152, 29);
            this.nudChronic.Margin = new System.Windows.Forms.Padding(2);
            this.nudChronic.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudChronic.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudChronic.Name = "nudChronic";
            this.nudChronic.Size = new System.Drawing.Size(34, 20);
            this.nudChronic.TabIndex = 10;
            this.nudChronic.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // chkDrug
            // 
            this.chkDrug.AutoSize = true;
            this.chkDrug.Checked = true;
            this.chkDrug.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDrug.Location = new System.Drawing.Point(44, 30);
            this.chkDrug.Margin = new System.Windows.Forms.Padding(2);
            this.chkDrug.Name = "chkDrug";
            this.chkDrug.Size = new System.Drawing.Size(69, 17);
            this.chkDrug.TabIndex = 9;
            this.chkDrug.Text = "เอาแต่ยา";
            this.chkDrug.UseVisualStyleBackColor = true;
            // 
            // dgvAdd
            // 
            this.dgvAdd.AllowDrop = true;
            this.dgvAdd.AllowUserToAddRows = false;
            this.dgvAdd.AllowUserToDeleteRows = false;
            this.dgvAdd.AllowUserToResizeRows = false;
            this.dgvAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdd.Location = new System.Drawing.Point(3, 74);
            this.dgvAdd.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAdd.MultiSelect = false;
            this.dgvAdd.Name = "dgvAdd";
            this.dgvAdd.RowTemplate.Height = 24;
            this.dgvAdd.Size = new System.Drawing.Size(781, 505);
            this.dgvAdd.TabIndex = 2;
            this.dgvAdd.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvAdd_CellBeginEdit);
            this.dgvAdd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdd_CellDoubleClick);
            this.dgvAdd.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdd_CellEndEdit);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.chkDrug);
            this.groupBox2.Controls.Add(this.nudChronic);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nudDrug);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(791, 92);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(414, 81);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Visible = false;
            // 
            // FrmCheckNHSO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 588);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvAdd);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCheckNHSO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCheckNHSO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCheckNHSO_Load);
            this.Resize += new System.EventHandler(this.FrmCheckNHSO_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChronic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar pB1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAdd;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.CheckBox chkDrug;
        private System.Windows.Forms.NumericUpDown nudChronic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudDrug;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtLabSearch1;
        private System.Windows.Forms.ComboBox cboLab;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtLabSearch2;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkLabError;
        private System.Windows.Forms.CheckBox chkDoctorEdit;
        private System.Windows.Forms.ComboBox cboBranch;
        private System.Windows.Forms.Button btnUpdate;
    }
}