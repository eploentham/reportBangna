using reportBangna.object1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace reportBangna.gui
{
    public partial class FrmStGoodsAdd : Form
    {
        BangnaControl bc;
        StGoods good;
        Boolean pageLoad = false;
        String id = "";
        public FrmStGoodsAdd(BangnaControl c, String Id)
        {
            InitializeComponent();
            bc = c;
            id = Id;
            initConfig();
        }
        private void initConfig()
        {
            good = new StGoods();
            good = bc.gooddb.selectByPk(id);
            cboVen = bc.vendb.getCboVendor(cboVen);

            SetControl();

        }
        private void SetControl()
        {
            txtCode.Text = good.Code;
            txtCodeBng.Text = good.CodeBng;
            txtId.Text = good.Id;
            txtNameBng.Text = good.NameBng;
            txtNameE.Text = good.NameE;
            txtNameGen.Text = good.NameGen;
            txtNameT.Text = good.NameT;
            txtOnHand.Value = Decimal.Parse(good.onHand);
            txtPrice.Value = Decimal.Parse(good.Price);
            txtRemark.Text = good.remark;
            txtDescription.Text = good.description;
            cboVen.Text = good.VenId;
            cboType.Text = good.TypeId;
        }
        private void getGoods()
        {
            good.Code = txtCode.Text;
            good.CodeBng = txtCodeBng.Text;
            good.description = txtDescription.Text;
            good.Id = txtId.Text;
            good.NameBng = txtNameBng.Text;
            good.NameE = txtNameE.Text;
            good.NameGen = txtNameGen.Text;
            good.NameT = txtNameT.Text;
            good.onHand = txtOnHand.Value.ToString();
            good.Price = txtPrice.Value.ToString();
            good.remark = txtRemark.Text;
            good.TypeId = cboType.Text;
            good.VenId = cboVen.Text;
        }

        private void FrmStGoodsAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNameT.Text.Equals(""))
            {
                MessageBox.Show("ไม่ได้ป้อนชื่อ", "ป้อนข้อมูลไม่ครบ");
                return;
            }
            if (txtCode.Text.Equals(""))
            {
                MessageBox.Show("ไม่ได้ป้อนรหัส", "ป้อนข้อมูลไม่ครบ");
                return;
            }
            getGoods();
            if (bc.gooddb.insertGoods(good).Length >= 1)
            {
                MessageBox.Show("บันทึกข้อมูล เรียบร้อย", "บันทึกข้อมูล");
                this.Dispose();
                //this.Hide();
            }
        }
    }
}
