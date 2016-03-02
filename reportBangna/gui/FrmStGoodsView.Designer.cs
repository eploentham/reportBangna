namespace reportBangna.gui
{
    partial class FrmStGoodsView
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
            this.dgvSum = new System.Windows.Forms.DataGridView();
            this.chkActive = new System.Windows.Forms.RadioButton();
            this.chkUnActive = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tC = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSum)).BeginInit();
            this.tC.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSum
            // 
            this.dgvSum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSum.Location = new System.Drawing.Point(5, 5);
            this.dgvSum.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSum.Name = "dgvSum";
            this.dgvSum.RowTemplate.Height = 24;
            this.dgvSum.Size = new System.Drawing.Size(985, 434);
            this.dgvSum.TabIndex = 47;
            this.dgvSum.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvView_CellDoubleClick);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(670, 15);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(56, 17);
            this.chkActive.TabIndex = 52;
            this.chkActive.TabStop = true;
            this.chkActive.Text = "ใช้งาน";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // chkUnActive
            // 
            this.chkUnActive.AutoSize = true;
            this.chkUnActive.Location = new System.Drawing.Point(783, 15);
            this.chkUnActive.Name = "chkUnActive";
            this.chkUnActive.Size = new System.Drawing.Size(57, 17);
            this.chkUnActive.TabIndex = 51;
            this.chkUnActive.TabStop = true;
            this.chkUnActive.Text = "ยกเลิก";
            this.chkUnActive.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(940, 11);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 39);
            this.btnAdd.TabIndex = 50;
            this.btnAdd.Text = "ป้อนใหม่";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tC
            // 
            this.tC.Controls.Add(this.tabPage1);
            this.tC.Location = new System.Drawing.Point(12, 55);
            this.tC.Name = "tC";
            this.tC.SelectedIndex = 0;
            this.tC.Size = new System.Drawing.Size(1021, 548);
            this.tC.TabIndex = 53;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvSum);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1013, 522);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // FrmStGoodsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 651);
            this.Controls.Add(this.tC);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.chkUnActive);
            this.Controls.Add(this.btnAdd);
            this.Name = "FrmStGoodsView";
            this.Text = "FrmStGoodsView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmStGoodsView_Load);
            this.Resize += new System.EventHandler(this.FrmStGoodsView_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSum)).EndInit();
            this.tC.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSum;
        private System.Windows.Forms.RadioButton chkActive;
        private System.Windows.Forms.RadioButton chkUnActive;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabControl tC;
        private System.Windows.Forms.TabPage tabPage1;
    }
}