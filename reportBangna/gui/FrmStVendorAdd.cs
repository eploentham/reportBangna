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
            
        }
        private void setControl()
        {
            ven = bc.vendb.selectByPk(id);
            txtId.Text = ven.Id;
            txtAddressE.Text = ven.AddressE;
            txtAddressT.Text = ven.AddressT;
            txtCode.Text = ven.Code;
            txtCodeBng.Text = ven.Code;
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
                cboDistrict = bc.didb.getCboDist1(cboDistrict, label18.Text);
                cboAmphur = bc.amdb.getCboAmphur1(cboAmphur, label18.Text.Substring(0, 4));
                cboProvince = bc.prdb.getCboProv1(cboProvince, label18.Text.Substring(0, 2));
            }
        }
        private void getVendor() {
            ven.Id = txtId.Text;
            ven.AddressE = txtAddressE.Text;
            ven.AddressT= txtAddressT.Text;
            ven.Code= txtCode.Text;
            ven.Code= txtCodeBng.Text;
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

            ven.amphurId = bc.cf.getValueCboItem(cboAmphur);
            ven.districtId = bc.cf.getValueCboItem(cboDistrict);
            ven.provinceId = bc.cf.getValueCboItem(cboProvince);
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
                MessageBox.Show("ไม่ได้ป้อนรหัส", "ป้อนข้อมูลไม่ครบ");
                return;
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
            keyDistrict = true;
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
