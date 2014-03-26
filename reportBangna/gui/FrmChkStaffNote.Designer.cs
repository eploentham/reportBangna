namespace reportBangna.gui
{
    partial class FrmChkStaffNote
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
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.chNoReceive = new System.Windows.Forms.RadioButton();
            this.chkReceive = new System.Windows.Forms.RadioButton();
            this.chkAll = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDep = new System.Windows.Forms.Label();
            this.labelPaidName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDateSearch = new System.Windows.Forms.DateTimePicker();
            this.txtHn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.labePatientName = new System.Windows.Forms.Label();
            this.chkReeiveStaffNote = new System.Windows.Forms.CheckBox();
            this.btnSearchVn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVn = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvView
            // 
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Location = new System.Drawing.Point(12, 138);
            this.dgvView.Name = "dgvView";
            this.dgvView.Size = new System.Drawing.Size(676, 335);
            this.dgvView.TabIndex = 0;
            this.dgvView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvView_CellDoubleClick);
            this.dgvView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvView_CellEndEdit);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1131, 109);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "เงื่อนไข";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.chNoReceive);
            this.panel2.Controls.Add(this.chkReceive);
            this.panel2.Controls.Add(this.chkAll);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtpDate);
            this.panel2.Location = new System.Drawing.Point(6, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 84);
            this.panel2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // chNoReceive
            // 
            this.chNoReceive.AutoSize = true;
            this.chNoReceive.Location = new System.Drawing.Point(246, 28);
            this.chNoReceive.Name = "chNoReceive";
            this.chNoReceive.Size = new System.Drawing.Size(76, 17);
            this.chNoReceive.TabIndex = 7;
            this.chNoReceive.TabStop = true;
            this.chNoReceive.Text = "ยังไม่ได้รับ";
            this.chNoReceive.UseVisualStyleBackColor = true;
            this.chNoReceive.Click += new System.EventHandler(this.chNoReceive_Click);
            // 
            // chkReceive
            // 
            this.chkReceive.AutoSize = true;
            this.chkReceive.Location = new System.Drawing.Point(137, 28);
            this.chkReceive.Name = "chkReceive";
            this.chkReceive.Size = new System.Drawing.Size(65, 17);
            this.chkReceive.TabIndex = 6;
            this.chkReceive.TabStop = true;
            this.chkReceive.Text = "ที่รับแล้ว";
            this.chkReceive.UseVisualStyleBackColor = true;
            this.chkReceive.CheckedChanged += new System.EventHandler(this.chkReceive_CheckedChanged);
            this.chkReceive.Click += new System.EventHandler(this.chkReceive_Click);
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(17, 29);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(58, 17);
            this.chkAll.TabIndex = 5;
            this.chkAll.TabStop = true;
            this.chkAll.Text = "ทั้งหมด";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            this.chkAll.Click += new System.EventHandler(this.chkAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(209, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "ค้นหา";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "วันที่ :";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(65, 3);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(137, 20);
            this.dtpDate.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelDep);
            this.panel1.Controls.Add(this.labelPaidName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtpDateSearch);
            this.panel1.Controls.Add(this.txtHn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.labePatientName);
            this.panel1.Controls.Add(this.chkReeiveStaffNote);
            this.panel1.Controls.Add(this.btnSearchVn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtVn);
            this.panel1.Location = new System.Drawing.Point(384, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 84);
            this.panel1.TabIndex = 6;
            // 
            // labelDep
            // 
            this.labelDep.AutoSize = true;
            this.labelDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelDep.Location = new System.Drawing.Point(568, 48);
            this.labelDep.Name = "labelDep";
            this.labelDep.Size = new System.Drawing.Size(60, 24);
            this.labelDep.TabIndex = 14;
            this.labelDep.Text = "label3";
            // 
            // labelPaidName
            // 
            this.labelPaidName.AutoSize = true;
            this.labelPaidName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelPaidName.Location = new System.Drawing.Point(377, 46);
            this.labelPaidName.Name = "labelPaidName";
            this.labelPaidName.Size = new System.Drawing.Size(60, 24);
            this.labelPaidName.TabIndex = 13;
            this.labelPaidName.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "วันที่ :";
            // 
            // dtpDateSearch
            // 
            this.dtpDateSearch.Location = new System.Drawing.Point(43, 18);
            this.dtpDateSearch.Name = "dtpDateSearch";
            this.dtpDateSearch.Size = new System.Drawing.Size(95, 20);
            this.dtpDateSearch.TabIndex = 11;
            // 
            // txtHn
            // 
            this.txtHn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtHn.Location = new System.Drawing.Point(202, 16);
            this.txtHn.Name = "txtHn";
            this.txtHn.Size = new System.Drawing.Size(115, 29);
            this.txtHn.TabIndex = 10;
            this.txtHn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHn_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(148, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "HN :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(650, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labePatientName
            // 
            this.labePatientName.AutoSize = true;
            this.labePatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labePatientName.Location = new System.Drawing.Point(38, 43);
            this.labePatientName.Name = "labePatientName";
            this.labePatientName.Size = new System.Drawing.Size(60, 24);
            this.labePatientName.TabIndex = 7;
            this.labePatientName.Text = "label3";
            // 
            // chkReeiveStaffNote
            // 
            this.chkReeiveStaffNote.AutoSize = true;
            this.chkReeiveStaffNote.Location = new System.Drawing.Point(529, 19);
            this.chkReeiveStaffNote.Name = "chkReeiveStaffNote";
            this.chkReeiveStaffNote.Size = new System.Drawing.Size(103, 17);
            this.chkReeiveStaffNote.TabIndex = 6;
            this.chkReeiveStaffNote.Text = "ได้รับ Staff Note";
            this.chkReeiveStaffNote.UseVisualStyleBackColor = true;
            this.chkReeiveStaffNote.KeyUp += new System.Windows.Forms.KeyEventHandler(this.chkReeiveStaffNote_KeyUp);
            // 
            // btnSearchVn
            // 
            this.btnSearchVn.Location = new System.Drawing.Point(464, 15);
            this.btnSearchVn.Name = "btnSearchVn";
            this.btnSearchVn.Size = new System.Drawing.Size(48, 23);
            this.btnSearchVn.TabIndex = 5;
            this.btnSearchVn.Text = "ค้นหา";
            this.btnSearchVn.UseVisualStyleBackColor = true;
            this.btnSearchVn.Click += new System.EventHandler(this.btnSearchVn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(323, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "VN :";
            // 
            // txtVn
            // 
            this.txtVn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtVn.Location = new System.Drawing.Point(375, 15);
            this.txtVn.Name = "txtVn";
            this.txtVn.Size = new System.Drawing.Size(83, 29);
            this.txtVn.TabIndex = 3;
            this.txtVn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtVn_KeyUp);
            // 
            // FrmChkStaffNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 485);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvView);
            this.Name = "FrmChkStaffNote";
            this.Text = "FrmChkStaffNote";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmChkStaffNote_Load);
            this.Resize += new System.EventHandler(this.FrmChkStaffNote_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchVn;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton chNoReceive;
        private System.Windows.Forms.RadioButton chkReceive;
        private System.Windows.Forms.RadioButton chkAll;
        private System.Windows.Forms.CheckBox chkReeiveStaffNote;
        private System.Windows.Forms.Label labePatientName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtHn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDateSearch;
        private System.Windows.Forms.Label labelPaidName;
        private System.Windows.Forms.Label labelDep;
        private System.Windows.Forms.Label label3;
    }
}