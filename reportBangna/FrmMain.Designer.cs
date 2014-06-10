namespace reportBangna
{
    partial class FrmMain
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("รายงานยอดคนไข้แยกตามสิทธิ์");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("รายงานยอดคนไข้แยกตามสิทธิ์ตามวัน");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("รายงานตรวจสุขภาพก่อนเข้างานตามวัน");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("รายงานยอดตรวจคนไข้แยกตามแพทย์");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("รายงานหมอเก่ง", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("OPD");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("รายงานการใช้ฟิลม์ประจำวัน");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("รายงานการใช้ฟิลม์ประจำเดือน");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("X-Ray", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("ป้อนข้อมูลรับใบStaff Note");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("เวชระเบียน", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("ป้อนเกียรติบัตรเด็กแรกเกิด");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("แผนกห้องคลอด", new System.Windows.Forms.TreeNode[] {
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Checkยอดผู้ป่วยประกันสังคม");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("ประกันสังคม", new System.Windows.Forms.TreeNode[] {
            treeNode14});
            this.tv1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tv1
            // 
            this.tv1.BackColor = System.Drawing.Color.Pink;
            this.tv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tv1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tv1.ItemHeight = 40;
            this.tv1.Location = new System.Drawing.Point(20, 21);
            this.tv1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tv1.Name = "tv1";
            treeNode1.Name = "nMisDailypatientsumPaid";
            treeNode1.Text = "รายงานยอดคนไข้แยกตามสิทธิ์";
            treeNode2.Name = "nMisMonthlypatientsumPaidDay";
            treeNode2.Text = "รายงานยอดคนไข้แยกตามสิทธิ์ตามวัน";
            treeNode3.Name = "nDailyCheckup";
            treeNode3.Text = "รายงานตรวจสุขภาพก่อนเข้างานตามวัน";
            treeNode4.Name = "nDailySummaryDoctor";
            treeNode4.Text = "รายงานยอดตรวจคนไข้แยกตามแพทย์";
            treeNode5.Name = "nMis";
            treeNode5.Text = "รายงานหมอเก่ง";
            treeNode6.Name = "nOPD";
            treeNode6.Text = "OPD";
            treeNode7.Name = "nXrayDailyUseFilm";
            treeNode7.Text = "รายงานการใช้ฟิลม์ประจำวัน";
            treeNode8.Name = "nXrayMonthlyUseFilm";
            treeNode8.Text = "รายงานการใช้ฟิลม์ประจำเดือน";
            treeNode9.Name = "nXray";
            treeNode9.Text = "X-Ray";
            treeNode10.Name = "nChkStaffNote";
            treeNode10.Text = "ป้อนข้อมูลรับใบStaff Note";
            treeNode11.Name = "nRecord";
            treeNode11.Text = "เวชระเบียน";
            treeNode12.Name = "nCertificatesChild";
            treeNode12.Text = "ป้อนเกียรติบัตรเด็กแรกเกิด";
            treeNode13.Name = "nLabor";
            treeNode13.Text = "แผนกห้องคลอด";
            treeNode14.Name = "nCheckNHSO";
            treeNode14.Text = "Checkยอดผู้ป่วยประกันสังคม";
            treeNode15.Name = "nNHSO";
            treeNode15.Text = "ประกันสังคม";
            this.tv1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode9,
            treeNode11,
            treeNode13,
            treeNode15});
            this.tv1.Size = new System.Drawing.Size(719, 583);
            this.tv1.TabIndex = 5;
            this.tv1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv1_AfterSelect);
            this.tv1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv1_NodeMouseDoubleClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(759, 626);
            this.Controls.Add(this.tv1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tv1;

    }
}

