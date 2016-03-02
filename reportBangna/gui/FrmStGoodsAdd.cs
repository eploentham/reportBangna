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
            cboVen = bc.vendb.getCboVendor(cboVen);
            cboGoodsGroup = bc.ggdb.getCboStGoodsGroup(cboGoodsGroup);
            SetControl();
        }
        private void SetControl()
        {
            good = new StGoods();
            good = bc.gooddb.selectByPk(id);
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

            cboVen.Text = bc.getTextCboItem(cboVen, good.VenId);
            cboGoodsGroup.Text = bc.getTextCboItem(cboGoodsGroup,good.TypeId);
            btnUnActive.Visible = false;
            chkActive.Checked = good.Active=="1" ? true : false;
            ChkUnActive.Checked = good.Active == "1" ? false : true;
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
            good.TypeId = bc.getIdCboItemByText(cboGoodsGroup,cboGoodsGroup.Text);
            good.VenId = bc.getIdCboItemByText(cboVen, cboVen.Text);
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
                //MessageBox.Show("ไม่ได้ป้อนรหัส", "ป้อนข้อมูลไม่ครบ");
                //return;
                txtCode.Text = bc.gooddb.getMaxGoods();
            }
            getGoods();
            if (bc.gooddb.insertGoods(good).Length >= 1)
            {
                MessageBox.Show("บันทึกข้อมูล เรียบร้อย", "บันทึกข้อมูล");
                this.Dispose();
                //this.Hide();
            }
        }

        private void txtCode_Enter(object sender, EventArgs e)
        {
            txtCode.BackColor = Color.LightYellow;
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            txtCode.BackColor = Color.White;
        }

        private void txtCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNameT.SelectAll();
                txtNameT.Focus();
            }
        }

        private void txtNameT_Enter(object sender, EventArgs e)
        {
            txtNameT.BackColor = Color.LightYellow;
        }

        private void txtNameT_Leave(object sender, EventArgs e)
        {
            txtNameT.BackColor = Color.White;
        }

        private void txtNameT_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNameE.SelectAll();
                txtNameE.Focus();
            }
        }

        private void txtNameE_Enter(object sender, EventArgs e)
        {
            txtNameE.BackColor = Color.LightYellow;
        }

        private void txtNameE_Leave(object sender, EventArgs e)
        {
            txtNameE.BackColor = Color.White;
        }

        private void txtNameE_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNameGen.SelectAll();
                txtNameGen.Focus();
            }
        }

        private void txtNameGen_Enter(object sender, EventArgs e)
        {
            txtNameGen.BackColor = Color.LightYellow;
        }

        private void txtNameGen_Leave(object sender, EventArgs e)
        {
            txtNameGen.BackColor = Color.White;
        }

        private void txtNameGen_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNameBng.SelectAll();
                txtNameBng.Focus();
            }
        }

        private void txtNameBng_Enter(object sender, EventArgs e)
        {
            txtNameBng.BackColor = Color.LightYellow;
        }

        private void txtNameBng_Leave(object sender, EventArgs e)
        {
            txtNameBng.BackColor = Color.White;
        }

        private void txtNameBng_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //txtPrice.SelectAll();
                txtPrice.Focus();
            }
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            txtPrice.BackColor = Color.LightYellow;
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            txtPrice.BackColor = Color.White;
        }

        private void txtPrice_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //txtOnHand.SelectAll();
                txtOnHand.Focus();
            }
        }

        private void txtOnHand_Enter(object sender, EventArgs e)
        {
            txtOnHand.BackColor = Color.LightYellow;
        }

        private void txtOnHand_Leave(object sender, EventArgs e)
        {
            txtOnHand.BackColor = Color.White;
        }

        private void txtOnHand_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDescription.SelectAll();
                txtDescription.Focus();
            }
        }

        private void txtDescription_Enter(object sender, EventArgs e)
        {
            txtDescription.BackColor = Color.LightYellow;
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            txtDescription.BackColor = Color.White;
        }

        private void txtDescription_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtRemark.SelectAll();
                txtRemark.Focus();
            }
        }

        private void txtRemark_Enter(object sender, EventArgs e)
        {
            txtRemark.BackColor = Color.LightYellow;
        }

        private void txtRemark_Leave(object sender, EventArgs e)
        {
            txtRemark.BackColor = Color.White;
        }

        private void txtRemark_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBarcode.SelectAll();
                txtBarcode.Focus();
            }
        }

        private void txtBarcode_Enter(object sender, EventArgs e)
        {
            txtBarcode.BackColor = Color.LightYellow;
        }

        private void txtBarcode_Leave(object sender, EventArgs e)
        {
            txtBarcode.BackColor = Color.White;
        }

        private void txtBarcode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //txtBarcode.SelectAll();
                //txtBarcode.Focus();
            }
        }

        private void ChkUnActive_Click(object sender, EventArgs e)
        {
            btnUnActive.Visible = true;
        }

        private void chkActive_Click(object sender, EventArgs e)
        {
            btnUnActive.Visible = false;
        }

        private void btnUnActive_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการยกเลิก", "ยกเลิก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                bc.gooddb.VoidStGoods(txtId.Text);
                this.Dispose();
            }
        }
    }
}
