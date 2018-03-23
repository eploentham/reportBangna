namespace reportBangna
{
    partial class FrmSSOAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSSOPath = new System.Windows.Forms.Button();
            this.txtSSOPathAccess = new System.Windows.Forms.TextBox();
            this.btnSSOOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSSOSavePath = new System.Windows.Forms.TextBox();
            this.btnSSOPathSave = new System.Windows.Forms.Button();
            this.btnSSOGenData = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSSCnt = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHCODE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOPService = new System.Windows.Forms.TextBox();
            this.txtHNAME = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSESSNO = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtSSOBillTran = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pB1 = new System.Windows.Forms.ProgressBar();
            this.chk32 = new System.Windows.Forms.RadioButton();
            this.chk64 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path SS Data";
            // 
            // btnSSOPath
            // 
            this.btnSSOPath.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSSOPath.Location = new System.Drawing.Point(115, 27);
            this.btnSSOPath.Name = "btnSSOPath";
            this.btnSSOPath.Size = new System.Drawing.Size(38, 23);
            this.btnSSOPath.TabIndex = 1;
            this.btnSSOPath.Text = "...";
            this.btnSSOPath.UseVisualStyleBackColor = true;
            this.btnSSOPath.Click += new System.EventHandler(this.btnSSOPath_Click);
            // 
            // txtSSOPathAccess
            // 
            this.txtSSOPathAccess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSSOPathAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSOPathAccess.Location = new System.Drawing.Point(168, 29);
            this.txtSSOPathAccess.Name = "txtSSOPathAccess";
            this.txtSSOPathAccess.Size = new System.Drawing.Size(559, 19);
            this.txtSSOPathAccess.TabIndex = 2;
            // 
            // btnSSOOk
            // 
            this.btnSSOOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSSOOk.Location = new System.Drawing.Point(733, 27);
            this.btnSSOOk.Name = "btnSSOOk";
            this.btnSSOOk.Size = new System.Drawing.Size(75, 23);
            this.btnSSOOk.TabIndex = 3;
            this.btnSSOOk.Text = "ดึงข้อมูล";
            this.btnSSOOk.UseVisualStyleBackColor = true;
            this.btnSSOOk.Click += new System.EventHandler(this.btnSSOOk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Path XML Data";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk64);
            this.groupBox1.Controls.Add(this.chk32);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.txtSSCnt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSSOPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSSOOk);
            this.groupBox1.Controls.Add(this.txtSSOPathAccess);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 132);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Access SS Data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pB1);
            this.groupBox2.Controls.Add(this.txtSSOBillTran);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtSESSNO);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtHNAME);
            this.groupBox2.Controls.Add(this.txtOPService);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtHCODE);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnSSOGenData);
            this.groupBox2.Controls.Add(this.btnSSOPathSave);
            this.groupBox2.Controls.Add(this.txtSSOSavePath);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(814, 369);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gen XML";
            // 
            // txtSSOSavePath
            // 
            this.txtSSOSavePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSSOSavePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSOSavePath.Location = new System.Drawing.Point(168, 29);
            this.txtSSOSavePath.Name = "txtSSOSavePath";
            this.txtSSOSavePath.Size = new System.Drawing.Size(559, 19);
            this.txtSSOSavePath.TabIndex = 5;
            // 
            // btnSSOPathSave
            // 
            this.btnSSOPathSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSSOPathSave.Location = new System.Drawing.Point(115, 29);
            this.btnSSOPathSave.Name = "btnSSOPathSave";
            this.btnSSOPathSave.Size = new System.Drawing.Size(38, 23);
            this.btnSSOPathSave.TabIndex = 6;
            this.btnSSOPathSave.Text = "...";
            this.btnSSOPathSave.UseVisualStyleBackColor = true;
            this.btnSSOPathSave.Click += new System.EventHandler(this.btnSSOPathSave_Click);
            // 
            // btnSSOGenData
            // 
            this.btnSSOGenData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSSOGenData.Location = new System.Drawing.Point(733, 340);
            this.btnSSOGenData.Name = "btnSSOGenData";
            this.btnSSOGenData.Size = new System.Drawing.Size(75, 23);
            this.btnSSOGenData.TabIndex = 7;
            this.btnSSOGenData.Text = "Gen Data";
            this.btnSSOGenData.UseVisualStyleBackColor = true;
            this.btnSSOGenData.Click += new System.EventHandler(this.btnSSOGenData_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(743, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "จำนวนข้อมูล out patient";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "ประจำเดือน";
            // 
            // txtSSCnt
            // 
            this.txtSSCnt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSSCnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSCnt.Location = new System.Drawing.Point(168, 65);
            this.txtSSCnt.Name = "txtSSCnt";
            this.txtSSCnt.Size = new System.Drawing.Size(109, 19);
            this.txtSSCnt.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(168, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(109, 19);
            this.textBox2.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "HCODE";
            // 
            // txtHCODE
            // 
            this.txtHCODE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHCODE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHCODE.Location = new System.Drawing.Point(168, 97);
            this.txtHCODE.Name = "txtHCODE";
            this.txtHCODE.Size = new System.Drawing.Size(100, 19);
            this.txtHCODE.TabIndex = 9;
            this.txtHCODE.Text = "HCODE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "OPService";
            // 
            // txtOPService
            // 
            this.txtOPService.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOPService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOPService.Location = new System.Drawing.Point(168, 272);
            this.txtOPService.Name = "txtOPService";
            this.txtOPService.Size = new System.Drawing.Size(194, 19);
            this.txtOPService.TabIndex = 11;
            this.txtOPService.Text = "OPService";
            // 
            // txtHNAME
            // 
            this.txtHNAME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHNAME.Location = new System.Drawing.Point(168, 122);
            this.txtHNAME.Name = "txtHNAME";
            this.txtHNAME.Size = new System.Drawing.Size(559, 19);
            this.txtHNAME.TabIndex = 12;
            this.txtHNAME.Text = "โรงพยาบาลบางนา5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "HNAME";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "SESSNO";
            // 
            // txtSESSNO
            // 
            this.txtSESSNO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSESSNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSESSNO.Location = new System.Drawing.Point(168, 147);
            this.txtSESSNO.Name = "txtSESSNO";
            this.txtSESSNO.Size = new System.Drawing.Size(100, 19);
            this.txtSESSNO.TabIndex = 14;
            this.txtSESSNO.Text = "0001";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "โรงพยาบาล";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(168, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // txtSSOBillTran
            // 
            this.txtSSOBillTran.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSSOBillTran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSOBillTran.Location = new System.Drawing.Point(168, 247);
            this.txtSSOBillTran.Name = "txtSSOBillTran";
            this.txtSSOBillTran.Size = new System.Drawing.Size(194, 19);
            this.txtSSOBillTran.TabIndex = 19;
            this.txtSSOBillTran.Text = "BillTran";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "BillTran";
            // 
            // pB1
            // 
            this.pB1.Location = new System.Drawing.Point(6, 308);
            this.pB1.Name = "pB1";
            this.pB1.Size = new System.Drawing.Size(802, 23);
            this.pB1.TabIndex = 20;
            // 
            // chk32
            // 
            this.chk32.AutoSize = true;
            this.chk32.Location = new System.Drawing.Point(589, 93);
            this.chk32.Name = "chk32";
            this.chk32.Size = new System.Drawing.Size(37, 17);
            this.chk32.TabIndex = 9;
            this.chk32.TabStop = true;
            this.chk32.Text = "32";
            this.chk32.UseVisualStyleBackColor = true;
            // 
            // chk64
            // 
            this.chk64.AutoSize = true;
            this.chk64.Location = new System.Drawing.Point(690, 93);
            this.chk64.Name = "chk64";
            this.chk64.Size = new System.Drawing.Size(37, 17);
            this.chk64.TabIndex = 10;
            this.chk64.TabStop = true;
            this.chk64.Text = "64";
            this.chk64.UseVisualStyleBackColor = true;
            // 
            // FrmSSOAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSSOAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSSOAdd";
            this.Load += new System.EventHandler(this.FrmSSOAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSSOPath;
        private System.Windows.Forms.TextBox txtSSOPathAccess;
        private System.Windows.Forms.Button btnSSOOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSSOSavePath;
        private System.Windows.Forms.Button btnSSOPathSave;
        private System.Windows.Forms.Button btnSSOGenData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtSSCnt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHCODE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOPService;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHNAME;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSESSNO;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSSOBillTran;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ProgressBar pB1;
        private System.Windows.Forms.RadioButton chk64;
        private System.Windows.Forms.RadioButton chk32;
    }
}