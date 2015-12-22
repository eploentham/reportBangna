using reportBangna.object1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace reportBangna.gui
{
    public partial class FrmStVendorAdd : Form
    {
        BangnaControl bc;
        StVendor ven;
        Boolean pageLoad = false, keyDistrict = false;

        String id = "";
        public FrmStVendorAdd(BangnaControl c, String venId)
        {
            InitializeComponent();
            bc = c;
            id = venId;
            initConfig();
        }
        private void initConfig()
        {
            ven = new StVendor();
            setControl();
        }
        private void setControl()
        {
            ven = bc.vendb.selectByPk(id);
            txtId.Text = ven.Id;
            txtAddressE.Text = ven.AddressE;
            txtAddressT.Text = ven.AddressT;
            txtCode.Text = ven.Code;
            txtCodeBng.Text = ven.CodeBng;
            txtContact.Text = ven.ContactName;
            txtContactEmail.Text = ven.ContactEmail;
            txtContactTel.Text = ven.ContactTel;
            TxtFax.Text = ven.Fax;
            txtNameE.Text = ven.NameE;
            txtNameT.Text = ven.NameT;
            txtRemark.Text = ven.Remark;
            txtTaxID.Text = ven.TaxId;
            txtTele.Text = ven.Tele;
            txtWebSite.Text = ven.WebSite;
            txtZipcode.Text = ven.Zipcode;

            label19.Text = ven.districtId;
            if (label19.Text.Length > 4)
            {
                cboDistrict = bc.didb.getCboDist1(cboDistrict, label19.Text);
                cboAmphur = bc.amdb.getCboAmphur1(cboAmphur, label19.Text.Substring(0, 4));
                cboProvince = bc.prdb.getCboProv1(cboProvince, label19.Text.Substring(0, 2));
            }
            chkActive.Checked = ven.Active=="1" ? true : false;
            ChkUnActive.Checked = ven.Active == "1" ? false : true;
            btnUnActive.Visible = false;
        }
        private void getVendor() {
            ven.Id = txtId.Text;
            ven.AddressE = txtAddressE.Text;
            ven.AddressT= txtAddressT.Text;
            ven.Code= txtCode.Text;
            ven.CodeBng= txtCodeBng.Text;
            ven.ContactName= txtContact.Text;
            ven.ContactEmail= txtContactEmail.Text;
            ven.ContactTel= txtContactTel.Text;
            ven.Fax= TxtFax.Text;
            ven.NameE= txtNameE.Text;
            ven.NameT= txtNameT.Text;
            ven.Remark= txtRemark.Text;
            ven.TaxId= txtTaxID.Text;
            ven.Tele= txtTele.Text;
            ven.WebSite= txtWebSite.Text;
            ven.Zipcode= txtZipcode.Text;
            //ven.c

            ven.amphurId = bc.cf.getValueCboItem(cboAmphur);
            ven.districtId = bc.cf.getValueCboItem(cboDistrict);
            ven.provinceId = bc.cf.getValueCboItem(cboProvince);
            ven.Active = chkActive.Checked ? "1" : "0";

        }
        private void FrmStVendorAdd_Load(object sender, EventArgs e)
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
                txtCode.Text = bc.vendb.getMaxVendor();
            }
            getVendor();
            if (bc.vendb.insertVendor(ven).Length >= 1)
            {
                MessageBox.Show("บันทึกข้อมูล เรียบร้อย", "บันทึกข้อมูล");
                this.Dispose();
                //this.Hide();
            }
        }

        private void cboDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!pageLoad)
            {
                String aaa = "";
                aaa = bc.cf.getValueCboItem(cboDistrict);
                label19.Text = aaa;
            }
        }

        private void cboDistrict_Enter(object sender, EventArgs e)
        {
            //keyDistrict = true;
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
                txtAddressT.SelectAll();
                txtAddressT.Focus();
            }
        }

        private void txtAddressT_Enter(object sender, EventArgs e)
        {
            txtAddressT.BackColor = Color.LightYellow;
        }

        private void txtAddressT_Leave(object sender, EventArgs e)
        {
            txtAddressT.BackColor = Color.White;
        }

        private void txtAddressT_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAddressE.SelectAll();
                txtAddressE.Focus();
            }
        }

        private void txtAddressE_Enter(object sender, EventArgs e)
        {
            txtAddressE.BackColor = Color.LightYellow;
        }

        private void txtAddressE_Leave(object sender, EventArgs e)
        {
            txtAddressE.BackColor = Color.White;
        }

        private void txtAddressE_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTele.SelectAll();
                txtTele.Focus();
            }
        }

        private void txtTele_Enter(object sender, EventArgs e)
        {
            txtTele.BackColor = Color.LightYellow;
        }

        private void txtTele_Leave(object sender, EventArgs e)
        {
            txtTele.BackColor = Color.White;
        }

        private void txtTele_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtFax.SelectAll();
                TxtFax.Focus();
            }
        }

        private void TxtFax_Enter(object sender, EventArgs e)
        {
            TxtFax.BackColor = Color.LightYellow;
        }

        private void TxtFax_Leave(object sender, EventArgs e)
        {
            TxtFax.BackColor = Color.White;
        }

        private void TxtFax_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTaxID.SelectAll();
                txtTaxID.Focus();
            }
        }

        private void txtTaxID_Enter(object sender, EventArgs e)
        {
            txtTaxID.BackColor = Color.LightYellow;
        }

        private void txtTaxID_Leave(object sender, EventArgs e)
        {
            txtTaxID.BackColor = Color.White;
        }

        private void txtTaxID_KeyUp(object sender, KeyEventArgs e)
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
                txtContact.SelectAll();
                txtContact.Focus();
            }
        }

        private void txtContact_Enter(object sender, EventArgs e)
        {
            txtContact.BackColor = Color.LightYellow;
        }

        private void txtContact_Leave(object sender, EventArgs e)
        {
            txtContact.BackColor = Color.White;
        }

        private void txtContact_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtContactTel.SelectAll();
                txtContactTel.Focus();
            }
        }

        private void txtContactTel_Enter(object sender, EventArgs e)
        {
            txtContactTel.BackColor = Color.LightYellow;
        }

        private void txtContactTel_Leave(object sender, EventArgs e)
        {
            txtContactTel.BackColor = Color.White;
        }

        private void txtContactTel_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtContactEmail.SelectAll();
                txtContactEmail.Focus();
            }
        }

        private void txtContactEmail_Enter(object sender, EventArgs e)
        {
            txtContactEmail.BackColor = Color.LightYellow;
        }

        private void txtContactEmail_Leave(object sender, EventArgs e)
        {
            txtContactEmail.BackColor = Color.White;
        }

        private void txtContactEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtWebSite.SelectAll();
                txtWebSite.Focus();
            }
        }

        private void txtWebSite_Enter(object sender, EventArgs e)
        {
            txtWebSite.BackColor = Color.LightYellow;
        }

        private void txtWebSite_Leave(object sender, EventArgs e)
        {
            txtWebSite.BackColor = Color.White;
        }

        private void txtWebSite_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //txtWebSite.SelectAll();
                //txtWebSite.Focus();
            }
        }

        private void btnUnActive_Click(object sender, EventArgs e)
        {
            
        }

        private void ChkUnActive_Click(object sender, EventArgs e)
        {
            btnUnActive.Visible = true;
        }

        private void chkActive_Click(object sender, EventArgs e)
        {
            btnUnActive.Visible = false;
        }

        private void cboDistrict_KeyUp(object sender, KeyEventArgs e)
        {
            Debug.WriteLine("keyDistrict "+ keyDistrict);
            if ((e.KeyCode == Keys.Enter) && (keyDistrict))
            {
                try
                {
                    Debug.WriteLine("keyDistrict 11111 " + keyDistrict);
                    cboDistrict = bc.didb.getCboDist1(cboDistrict, label19.Text);
                    cboAmphur = bc.amdb.getCboAmphur1(cboAmphur, label19.Text.Substring(0, 4));
                    cboProvince = bc.prdb.getCboProv1(cboProvince, label19.Text.Substring(0, 2));
                    txtZipcode.Text = bc.didb.selectZipCodeByPk(label19.Text);
                    if (bc.getValueCboItem(cboProvince).Equals("10"))
                    {
                        txtAddrT.Text = txtAddressT.Text + " แขวง " + cboDistrict.Text + " เขต " + cboAmphur.Text + " จังหวัด " + cboProvince.Text + " รหัสไปรษณีย์ " + txtZipcode.Text;
                    }
                    else
                    {
                        txtAddrT.Text = txtAddressT.Text + " อำเภอ " + cboDistrict.Text + " ตำบล " + cboAmphur.Text + " จังหวัด " + cboProvince.Text + " รหัสไปรษณีย์ " + txtZipcode.Text;
                    }
                }
                catch (Exception ex)
                {
                    bc.lw.WriteLog("FrmCustAdd.cboDistrict_KeyUp Error " + ex.Message);
                }


                txtAddressE.SelectAll();
                txtAddressE.Focus();
            }
            else if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                keyDistrict = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                keyDistrict = true;
                //    aaa = cc.cf.getValueCboItem(cboDistrict);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (cboDistrict.Text.Length >= 3)
                {
                    cboDistrict = bc.didb.getCboDistrict1(cboDistrict, cboDistrict.Text);
                }
            }
        }
    }
}
