namespace reportBangna.gui
{
    partial class FrmBillLabCheckExcel
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
            this.bthPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.pB1 = new System.Windows.Forms.ProgressBar();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chkBn1 = new System.Windows.Forms.RadioButton();
            this.chkBn2 = new System.Windows.Forms.RadioButton();
            this.chkBn5 = new System.Windows.Forms.RadioButton();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.cboPeriod = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnPrnSum = new System.Windows.Forms.Button();
            this.btnPrnDetail = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmailTo = new System.Windows.Forms.TextBox();
            this.btnEmail = new System.Windows.Forms.Button();
            this.txtEmailSubject = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPrnDetailItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bthPath
            // 
            this.bthPath.Location = new System.Drawing.Point(130, 44);
            this.bthPath.Name = "bthPath";
            this.bthPath.Size = new System.Drawing.Size(35, 23);
            this.bthPath.TabIndex = 0;
            this.bthPath.Text = "...";
            this.bthPath.UseVisualStyleBackColor = true;
            this.bthPath.Click += new System.EventHandler(this.bthPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "เปิด File Excel";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(171, 47);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(466, 20);
            this.txtPath.TabIndex = 2;
            // 
            // pB1
            // 
            this.pB1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pB1.Location = new System.Drawing.Point(0, 278);
            this.pB1.Name = "pB1";
            this.pB1.Size = new System.Drawing.Size(816, 23);
            this.pB1.TabIndex = 3;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(643, 44);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "เปิด Excel";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(31, 150);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(109, 33);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Check Data";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // chkBn1
            // 
            this.chkBn1.AutoSize = true;
            this.chkBn1.Location = new System.Drawing.Point(171, 87);
            this.chkBn1.Name = "chkBn1";
            this.chkBn1.Size = new System.Drawing.Size(67, 17);
            this.chkBn1.TabIndex = 7;
            this.chkBn1.TabStop = true;
            this.chkBn1.Text = "bangna1";
            this.chkBn1.UseVisualStyleBackColor = true;
            // 
            // chkBn2
            // 
            this.chkBn2.AutoSize = true;
            this.chkBn2.Location = new System.Drawing.Point(331, 89);
            this.chkBn2.Name = "chkBn2";
            this.chkBn2.Size = new System.Drawing.Size(67, 17);
            this.chkBn2.TabIndex = 8;
            this.chkBn2.TabStop = true;
            this.chkBn2.Text = "bangna2";
            this.chkBn2.UseVisualStyleBackColor = true;
            // 
            // chkBn5
            // 
            this.chkBn5.AutoSize = true;
            this.chkBn5.Location = new System.Drawing.Point(485, 89);
            this.chkBn5.Name = "chkBn5";
            this.chkBn5.Size = new System.Drawing.Size(67, 17);
            this.chkBn5.TabIndex = 9;
            this.chkBn5.TabStop = true;
            this.chkBn5.Text = "bangna5";
            this.chkBn5.UseVisualStyleBackColor = true;
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(171, 114);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(121, 21);
            this.cboYear.TabIndex = 10;
            // 
            // cboMonth
            // 
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(431, 119);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(121, 21);
            this.cboMonth.TabIndex = 11;
            // 
            // cboPeriod
            // 
            this.cboPeriod.FormattingEnabled = true;
            this.cboPeriod.Location = new System.Drawing.Point(660, 119);
            this.cboPeriod.Name = "cboPeriod";
            this.cboPeriod.Size = new System.Drawing.Size(121, 21);
            this.cboPeriod.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "ปี";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "เดือน";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(629, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "งวด";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(193, 150);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(109, 33);
            this.btnInsert.TabIndex = 16;
            this.btnInsert.Text = "Insert Data";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnPrnSum
            // 
            this.btnPrnSum.Location = new System.Drawing.Point(415, 150);
            this.btnPrnSum.Name = "btnPrnSum";
            this.btnPrnSum.Size = new System.Drawing.Size(109, 33);
            this.btnPrnSum.TabIndex = 17;
            this.btnPrnSum.Text = "Print สรุป";
            this.btnPrnSum.UseVisualStyleBackColor = true;
            this.btnPrnSum.Click += new System.EventHandler(this.btnPrnSum_Click);
            // 
            // btnPrnDetail
            // 
            this.btnPrnDetail.Location = new System.Drawing.Point(556, 150);
            this.btnPrnDetail.Name = "btnPrnDetail";
            this.btnPrnDetail.Size = new System.Drawing.Size(109, 33);
            this.btnPrnDetail.TabIndex = 18;
            this.btnPrnDetail.Text = "Print รายละเอียดบุคคล";
            this.btnPrnDetail.UseVisualStyleBackColor = true;
            this.btnPrnDetail.Click += new System.EventHandler(this.btnPrnDetail_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Email TO :";
            // 
            // txtEmailTo
            // 
            this.txtEmailTo.Location = new System.Drawing.Point(100, 200);
            this.txtEmailTo.Name = "txtEmailTo";
            this.txtEmailTo.Size = new System.Drawing.Size(298, 20);
            this.txtEmailTo.TabIndex = 20;
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(422, 213);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(109, 33);
            this.btnEmail.TabIndex = 21;
            this.btnEmail.Text = "send email";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // txtEmailSubject
            // 
            this.txtEmailSubject.Location = new System.Drawing.Point(100, 226);
            this.txtEmailSubject.Name = "txtEmailSubject";
            this.txtEmailSubject.Size = new System.Drawing.Size(298, 20);
            this.txtEmailSubject.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Subject :";
            // 
            // btnPrnDetailItem
            // 
            this.btnPrnDetailItem.Location = new System.Drawing.Point(689, 150);
            this.btnPrnDetailItem.Name = "btnPrnDetailItem";
            this.btnPrnDetailItem.Size = new System.Drawing.Size(115, 33);
            this.btnPrnDetailItem.TabIndex = 24;
            this.btnPrnDetailItem.Text = "Print รายละเอียดItem";
            this.btnPrnDetailItem.UseVisualStyleBackColor = true;
            // 
            // FrmBillLabCheckExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 301);
            this.Controls.Add(this.btnPrnDetailItem);
            this.Controls.Add(this.txtEmailSubject);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.txtEmailTo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPrnDetail);
            this.Controls.Add(this.btnPrnSum);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboPeriod);
            this.Controls.Add(this.cboMonth);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.chkBn5);
            this.Controls.Add(this.chkBn2);
            this.Controls.Add(this.chkBn1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.pB1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bthPath);
            this.Name = "FrmBillLabCheckExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBillLabCheckExcel";
            this.Load += new System.EventHandler(this.FrmBillLabCheckExcel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bthPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.ProgressBar pB1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton chkBn1;
        private System.Windows.Forms.RadioButton chkBn2;
        private System.Windows.Forms.RadioButton chkBn5;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.ComboBox cboPeriod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnPrnSum;
        private System.Windows.Forms.Button btnPrnDetail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmailTo;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.TextBox txtEmailSubject;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPrnDetailItem;
        //private Microsoft.AnalysisServices.AdomdClient.AdomdDataAdapter adomdDataAdapter1;
    }
}