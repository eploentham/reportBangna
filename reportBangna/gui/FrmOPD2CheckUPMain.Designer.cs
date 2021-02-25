namespace reportBangna.gui
{
    partial class FrmOPD2CheckUPMain
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
            this.btnPrintOPD2 = new System.Windows.Forms.Button();
            this.btnPrintOPD21 = new System.Windows.Forms.Button();
            this.btnPrintOPD21TrueStar = new System.Windows.Forms.Button();
            this.btnPrintLicenseDriver = new System.Windows.Forms.Button();
            this.cboDept = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRpt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnGrf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrintOPD2
            // 
            this.btnPrintOPD2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnPrintOPD2.Location = new System.Drawing.Point(117, 60);
            this.btnPrintOPD2.Name = "btnPrintOPD2";
            this.btnPrintOPD2.Size = new System.Drawing.Size(284, 41);
            this.btnPrintOPD2.TabIndex = 130;
            this.btnPrintOPD2.Text = "Print ใบรับรองแพทย์อาชีวะ";
            this.btnPrintOPD2.UseVisualStyleBackColor = true;
            this.btnPrintOPD2.Click += new System.EventHandler(this.btnPrintOPD2_Click);
            // 
            // btnPrintOPD21
            // 
            this.btnPrintOPD21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnPrintOPD21.Location = new System.Drawing.Point(117, 126);
            this.btnPrintOPD21.Name = "btnPrintOPD21";
            this.btnPrintOPD21.Size = new System.Drawing.Size(284, 41);
            this.btnPrintOPD21.TabIndex = 131;
            this.btnPrintOPD21.Text = "Print ใบรับรองแพทย์ การตรวจสุขภาพแรงงานต่างด้าว";
            this.btnPrintOPD21.UseVisualStyleBackColor = true;
            this.btnPrintOPD21.Click += new System.EventHandler(this.btnPrintOPD21_Click);
            // 
            // btnPrintOPD21TrueStar
            // 
            this.btnPrintOPD21TrueStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnPrintOPD21TrueStar.Location = new System.Drawing.Point(117, 199);
            this.btnPrintOPD21TrueStar.Name = "btnPrintOPD21TrueStar";
            this.btnPrintOPD21TrueStar.Size = new System.Drawing.Size(284, 54);
            this.btnPrintOPD21TrueStar.TabIndex = 132;
            this.btnPrintOPD21TrueStar.Text = "Print ใบรับรองแพทย์ การตรวจสุขภาพแรงงานต่างด้าว\r\nTrue Star";
            this.btnPrintOPD21TrueStar.UseVisualStyleBackColor = true;
            // 
            // btnPrintLicenseDriver
            // 
            this.btnPrintLicenseDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnPrintLicenseDriver.Location = new System.Drawing.Point(117, 275);
            this.btnPrintLicenseDriver.Name = "btnPrintLicenseDriver";
            this.btnPrintLicenseDriver.Size = new System.Drawing.Size(284, 41);
            this.btnPrintLicenseDriver.TabIndex = 133;
            this.btnPrintLicenseDriver.Text = "Print ใบรับรองแพทย์ ใบขับขี่";
            this.btnPrintLicenseDriver.UseVisualStyleBackColor = true;
            // 
            // cboDept
            // 
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Items.AddRange(new object[] {
            "OPD1",
            "OPD2",
            "OPD3",
            "ER",
            "Dental"});
            this.cboDept.Location = new System.Drawing.Point(210, 357);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(191, 21);
            this.cboDept.TabIndex = 134;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 135;
            this.label1.Text = "แผนก";
            // 
            // btnRpt
            // 
            this.btnRpt.Location = new System.Drawing.Point(326, 384);
            this.btnRpt.Name = "btnRpt";
            this.btnRpt.Size = new System.Drawing.Size(75, 23);
            this.btnRpt.TabIndex = 136;
            this.btnRpt.Text = "OK";
            this.btnRpt.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 137;
            this.label2.Text = "วันที่";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(284, 329);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(117, 20);
            this.dtpDate.TabIndex = 138;
            // 
            // btnGrf
            // 
            this.btnGrf.Location = new System.Drawing.Point(245, 384);
            this.btnGrf.Name = "btnGrf";
            this.btnGrf.Size = new System.Drawing.Size(75, 23);
            this.btnGrf.TabIndex = 139;
            this.btnGrf.Text = "View";
            this.btnGrf.UseVisualStyleBackColor = true;
            // 
            // FrmOPD2CheckUPMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 465);
            this.Controls.Add(this.btnGrf);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRpt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDept);
            this.Controls.Add(this.btnPrintLicenseDriver);
            this.Controls.Add(this.btnPrintOPD21TrueStar);
            this.Controls.Add(this.btnPrintOPD21);
            this.Controls.Add(this.btnPrintOPD2);
            this.Name = "FrmOPD2CheckUPMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOPD2CheckUPMain";
            this.Load += new System.EventHandler(this.FrmOPD2CheckUPMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrintOPD2;
        private System.Windows.Forms.Button btnPrintOPD21;
        private System.Windows.Forms.Button btnPrintOPD21TrueStar;
        private System.Windows.Forms.Button btnPrintLicenseDriver;
        private System.Windows.Forms.ComboBox cboDept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRpt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnGrf;
    }
}