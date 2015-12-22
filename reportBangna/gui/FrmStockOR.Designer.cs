namespace reportBangna
{
    partial class FrmStockOR
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
            this.btnVendor = new System.Windows.Forms.Button();
            this.btnGoods = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnAdjust = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVendor
            // 
            this.btnVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnVendor.Location = new System.Drawing.Point(146, 49);
            this.btnVendor.Name = "btnVendor";
            this.btnVendor.Size = new System.Drawing.Size(190, 37);
            this.btnVendor.TabIndex = 0;
            this.btnVendor.Text = "ข้อมูลผู้ขาย";
            this.btnVendor.UseVisualStyleBackColor = true;
            // 
            // btnGoods
            // 
            this.btnGoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnGoods.Location = new System.Drawing.Point(146, 92);
            this.btnGoods.Name = "btnGoods";
            this.btnGoods.Size = new System.Drawing.Size(190, 37);
            this.btnGoods.TabIndex = 1;
            this.btnGoods.Text = "ข้อมูลสินค้า";
            this.btnGoods.UseVisualStyleBackColor = true;
            // 
            // btnReceive
            // 
            this.btnReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnReceive.Location = new System.Drawing.Point(146, 164);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(190, 37);
            this.btnReceive.TabIndex = 2;
            this.btnReceive.Text = "รับสินค้าเข้าคลัง";
            this.btnReceive.UseVisualStyleBackColor = true;
            // 
            // btnDraw
            // 
            this.btnDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnDraw.Location = new System.Drawing.Point(146, 207);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(190, 37);
            this.btnDraw.TabIndex = 3;
            this.btnDraw.Text = "ผู้เบิกสินค้า";
            this.btnDraw.UseVisualStyleBackColor = true;
            // 
            // btnAdjust
            // 
            this.btnAdjust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnAdjust.Location = new System.Drawing.Point(146, 250);
            this.btnAdjust.Name = "btnAdjust";
            this.btnAdjust.Size = new System.Drawing.Size(190, 37);
            this.btnAdjust.TabIndex = 4;
            this.btnAdjust.Text = "ตัดจ่าย";
            this.btnAdjust.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(146, 324);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(190, 37);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "รายงาน";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // FrmStockOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 442);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnAdjust);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.btnGoods);
            this.Controls.Add(this.btnVendor);
            this.Name = "FrmStockOR";
            this.Text = "FrmStockOR";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVendor;
        private System.Windows.Forms.Button btnGoods;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnAdjust;
        private System.Windows.Forms.Button btnReport;
    }
}