namespace reportBangna.gui
{
    partial class FrmStReceiveAdd
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
            this.dgvAdd = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRecCode = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDateRec = new System.Windows.Forms.DateTimePicker();
            this.txtDateInv = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboVen = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNettotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRecCodeEx = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUnActive = new System.Windows.Forms.Button();
            this.ChkUnActive = new System.Windows.Forms.RadioButton();
            this.chkActive = new System.Windows.Forms.RadioButton();
            this.cboGoods = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDateExp = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTotal1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtRemark1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdd
            // 
            this.dgvAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdd.Location = new System.Drawing.Point(11, 160);
            this.dgvAdd.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAdd.Name = "dgvAdd";
            this.dgvAdd.RowTemplate.Height = 24;
            this.dgvAdd.Size = new System.Drawing.Size(985, 437);
            this.dgvAdd.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(37, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "เลขที่ :";
            // 
            // txtRecCode
            // 
            this.txtRecCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtRecCode.Location = new System.Drawing.Point(115, 14);
            this.txtRecCode.Name = "txtRecCode";
            this.txtRecCode.Size = new System.Drawing.Size(136, 22);
            this.txtRecCode.TabIndex = 50;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtDescription.Location = new System.Drawing.Point(115, 40);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(315, 22);
            this.txtDescription.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(37, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "รายละเอียด :";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtId.Location = new System.Drawing.Point(257, 14);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(27, 22);
            this.txtId.TabIndex = 54;
            this.txtId.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(37, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "วันที่รับ :";
            // 
            // txtDateRec
            // 
            this.txtDateRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtDateRec.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateRec.Location = new System.Drawing.Point(115, 69);
            this.txtDateRec.Name = "txtDateRec";
            this.txtDateRec.Size = new System.Drawing.Size(100, 22);
            this.txtDateRec.TabIndex = 55;
            // 
            // txtDateInv
            // 
            this.txtDateInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtDateInv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateInv.Location = new System.Drawing.Point(822, 69);
            this.txtDateInv.Name = "txtDateInv";
            this.txtDateInv.Size = new System.Drawing.Size(100, 22);
            this.txtDateInv.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(706, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 56;
            this.label4.Text = "วันที่ invoice :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(706, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 58;
            this.label5.Text = "Vendor :";
            // 
            // cboVen
            // 
            this.cboVen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboVen.FormattingEnabled = true;
            this.cboVen.Location = new System.Drawing.Point(822, 17);
            this.cboVen.Name = "cboVen";
            this.cboVen.Size = new System.Drawing.Size(199, 24);
            this.cboVen.TabIndex = 59;
            this.cboVen.SelectedIndexChanged += new System.EventHandler(this.cboVen_SelectedIndexChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtTotal.Location = new System.Drawing.Point(764, 614);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(189, 22);
            this.txtTotal.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(686, 617);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 60;
            this.label6.Text = "รวม :";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtDiscount.Location = new System.Drawing.Point(764, 640);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(189, 22);
            this.txtDiscount.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(686, 643);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 62;
            this.label7.Text = "ส่วนลด :";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtAmount.Location = new System.Drawing.Point(764, 666);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(189, 22);
            this.txtAmount.TabIndex = 65;
            // 
            // txtVat
            // 
            this.txtVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtVat.Location = new System.Drawing.Point(764, 692);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(189, 22);
            this.txtVat.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(686, 695);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 66;
            this.label8.Text = "vat :";
            // 
            // txtNettotal
            // 
            this.txtNettotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtNettotal.Location = new System.Drawing.Point(764, 718);
            this.txtNettotal.Name = "txtNettotal";
            this.txtNettotal.Size = new System.Drawing.Size(189, 22);
            this.txtNettotal.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(686, 721);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 68;
            this.label9.Text = "รวมสุทธิ :";
            // 
            // txtRecCodeEx
            // 
            this.txtRecCodeEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtRecCodeEx.Location = new System.Drawing.Point(822, 44);
            this.txtRecCodeEx.Name = "txtRecCodeEx";
            this.txtRecCodeEx.Size = new System.Drawing.Size(199, 22);
            this.txtRecCodeEx.TabIndex = 71;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.Location = new System.Drawing.Point(706, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 16);
            this.label10.TabIndex = 70;
            this.label10.Text = "เลขที่ใบรับของ :";
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtRemark.Location = new System.Drawing.Point(144, 614);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(411, 22);
            this.txtRemark.TabIndex = 73;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label11.Location = new System.Drawing.Point(66, 617);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 16);
            this.label11.TabIndex = 72;
            this.label11.Text = "หมายเหตุ :";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSave.Location = new System.Drawing.Point(969, 71);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(52, 23);
            this.btnSave.TabIndex = 77;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnUnActive
            // 
            this.btnUnActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnUnActive.Location = new System.Drawing.Point(402, 697);
            this.btnUnActive.Name = "btnUnActive";
            this.btnUnActive.Size = new System.Drawing.Size(86, 23);
            this.btnUnActive.TabIndex = 76;
            this.btnUnActive.Text = "ยกเลิกการใช้งาน";
            this.btnUnActive.UseVisualStyleBackColor = true;
            // 
            // ChkUnActive
            // 
            this.ChkUnActive.AutoSize = true;
            this.ChkUnActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ChkUnActive.Location = new System.Drawing.Point(317, 697);
            this.ChkUnActive.Margin = new System.Windows.Forms.Padding(2);
            this.ChkUnActive.Name = "ChkUnActive";
            this.ChkUnActive.Size = new System.Drawing.Size(60, 21);
            this.ChkUnActive.TabIndex = 75;
            this.ChkUnActive.TabStop = true;
            this.ChkUnActive.Text = "ยกเลิก";
            this.ChkUnActive.UseVisualStyleBackColor = true;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkActive.Location = new System.Drawing.Point(192, 697);
            this.chkActive.Margin = new System.Windows.Forms.Padding(2);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(61, 21);
            this.chkActive.TabIndex = 74;
            this.chkActive.TabStop = true;
            this.chkActive.Text = "ใช้งาน";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // cboGoods
            // 
            this.cboGoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboGoods.FormattingEnabled = true;
            this.cboGoods.Location = new System.Drawing.Point(51, 131);
            this.cboGoods.Name = "cboGoods";
            this.cboGoods.Size = new System.Drawing.Size(244, 24);
            this.cboGoods.TabIndex = 79;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label12.Location = new System.Drawing.Point(109, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 78;
            this.label12.Text = "Name :";
            // 
            // txtDateExp
            // 
            this.txtDateExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtDateExp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateExp.Location = new System.Drawing.Point(317, 131);
            this.txtDateExp.Name = "txtDateExp";
            this.txtDateExp.Size = new System.Drawing.Size(100, 22);
            this.txtDateExp.TabIndex = 81;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label13.Location = new System.Drawing.Point(342, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 16);
            this.label13.TabIndex = 80;
            this.label13.Text = "exp date :";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtQty.Location = new System.Drawing.Point(435, 131);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(66, 22);
            this.txtQty.TabIndex = 83;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label14.Location = new System.Drawing.Point(454, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 16);
            this.label14.TabIndex = 82;
            this.label14.Text = "qty :";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtPrice.Location = new System.Drawing.Point(507, 131);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(119, 22);
            this.txtPrice.TabIndex = 85;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label15.Location = new System.Drawing.Point(526, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 16);
            this.label15.TabIndex = 84;
            this.label15.Text = "Price :";
            // 
            // txtTotal1
            // 
            this.txtTotal1.Enabled = false;
            this.txtTotal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtTotal1.Location = new System.Drawing.Point(632, 131);
            this.txtTotal1.Name = "txtTotal1";
            this.txtTotal1.Size = new System.Drawing.Size(132, 22);
            this.txtTotal1.TabIndex = 87;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label16.Location = new System.Drawing.Point(651, 109);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 16);
            this.label16.TabIndex = 86;
            this.label16.Text = "Total :";
            // 
            // txtRemark1
            // 
            this.txtRemark1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtRemark1.Location = new System.Drawing.Point(770, 131);
            this.txtRemark1.Name = "txtRemark1";
            this.txtRemark1.Size = new System.Drawing.Size(183, 22);
            this.txtRemark1.TabIndex = 89;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label17.Location = new System.Drawing.Point(789, 109);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 16);
            this.label17.TabIndex = 88;
            this.label17.Text = "Remark ";
            // 
            // FrmStReceiveAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 750);
            this.Controls.Add(this.txtRemark1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtTotal1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtDateExp);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cboGoods);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUnActive);
            this.Controls.Add(this.ChkUnActive);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtRecCodeEx);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNettotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtVat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboVen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDateInv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDateRec);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRecCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAdd);
            this.Name = "FrmStReceiveAdd";
            this.Text = "FrmStReceive";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmStReceiveAdd_Load);
            this.Resize += new System.EventHandler(this.FrmStReceiveAdd_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecCode;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtDateRec;
        private System.Windows.Forms.DateTimePicker txtDateInv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboVen;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNettotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRecCodeEx;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUnActive;
        private System.Windows.Forms.RadioButton ChkUnActive;
        private System.Windows.Forms.RadioButton chkActive;
        private System.Windows.Forms.ComboBox cboGoods;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker txtDateExp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTotal1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtRemark1;
        private System.Windows.Forms.Label label17;
    }
}