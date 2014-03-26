using reportBangna.objdb;
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
    public partial class FrmCertificatesAdd : Form
    {
        CertificatesChild cC ;
        CertificatesChildDB cCdb ;
        Config1 config1;
        public delegate void ChangedEventHandler(object sender, EventArgs e);
        private void setBirthDay()
        {
            nudDay.Value = dtpBirthDay.Value.Day;
            txtYear.Text = String.Concat( dtpBirthDay.Value.Year+543);
            cboMonth.Text = config1.getMonth(dtpBirthDay.Value.Month.ToString("00"));
            if (dtpBirthDay.Value.DayOfWeek.ToString() == "Monday")
            {
                chkMonday.Checked = true;
                textBox2.Text = "วันจันทร์  "+dtpBirthDay.Value.ToString("dd MMMMM yyyy");
            }
            else if (dtpBirthDay.Value.DayOfWeek.ToString() == "Tuesday")
            {
                chkTuesday.Checked = true;
                textBox2.Text = "วันอังคาร  " + dtpBirthDay.Value.ToString("dd MMMMM yyyy");
            } if (dtpBirthDay.Value.DayOfWeek.ToString() == "Wednesday")
            {
                chkWednesday.Checked = true;
                textBox2.Text = "วันพุธ  " + dtpBirthDay.Value.ToString("dd MMMMM yyyy");
            } if (dtpBirthDay.Value.DayOfWeek.ToString() == "Thursday")
            {
                chkThurday.Checked = true;
                textBox2.Text = "วันพฤหัสบดี  " + dtpBirthDay.Value.ToString("dd MMMMM yyyy");
            } if (dtpBirthDay.Value.DayOfWeek.ToString() == "Friday")
            {
                chkFriday.Checked = true;
                textBox2.Text = "วันศุกร์  " + dtpBirthDay.Value.ToString("dd MMMMM yyyy");
            } if (dtpBirthDay.Value.DayOfWeek.ToString() == "Saturday")
            {
                chkSaturday.Checked = true;
                textBox2.Text = "วันเสาร์  " + dtpBirthDay.Value.ToString("dd MMMMM yyyy");
            } if (dtpBirthDay.Value.DayOfWeek.ToString() == "Sunday")
            {
                chkSunday.Checked = true;
                textBox2.Text = "วันอาทิตย์  " + dtpBirthDay.Value.ToString("dd MMMMM yyyy");
            }
            
        }
        private void setChildName()
        {
            if (chkMale.Checked)
            {
                if (chkUseFather.Checked)
                {
                    textBox1.Text = "เด็กชาย " + txtChildName.Text + " " + txtFartherSurname.Text;
                }
                else if (chkUseMother.Checked)
                {
                    textBox1.Text = "เด็กชาย " + txtChildName.Text + " " + txtMotherSurname.Text;
                }
                else
                {
                    textBox1.Text = "เด็กชาย " + txtChildName.Text + " " + txtChildSurname.Text;
                }
            }
            else
            {
                if (chkUseFather.Checked)
                {
                    textBox1.Text = "เด็กหญิง " + txtChildName.Text + " " + txtFartherSurname.Text;
                }
                else if (chkUseMother.Checked)
                {
                    textBox1.Text = "เด็กหญิง " + txtChildName.Text + " " + txtMotherSurname.Text;
                }
                else
                {
                    textBox1.Text = "เด็กหญิง " + txtChildName.Text + " " + txtChildSurname.Text;
                }
            }
            //textBox1.Text = label16.Text;
        }
        public FrmCertificatesAdd()
        {
            InitializeComponent();
            initConfig();
            config1.setCboMonth(cboMonth);
            dtpBirthDay.Value = System.DateTime.Now;
            //txtYear.Text = System.DateTime.Now.Year.ToString();
            //nudDay.Value = System.DateTime.Now.Day;
            setBirthDay();
            textBox1.Text = "";
            
        }

        private void initConfig()
        {
            config1 = new Config1();
            cC = new CertificatesChild();
            cCdb = new CertificatesChildDB();
            nudDay.Enabled = false;
            cboMonth.Enabled = false;
            txtYear.Enabled = false;
            chkMonday.Enabled = false;
            chkTuesday.Enabled = false;
            chkWednesday.Enabled = false;
            chkThurday.Enabled = false;
            chkFriday.Enabled = false;
            chkSaturday.Enabled = false;
            chkSunday.Enabled = false;
            config1.setCboDoctor(cboDoctor);
        }

        public void setCertifiChild(String certifiId)
        {
            cC = cCdb.selectCertificatesByPk(certifiId);
            txtCertifiId.Text = cC.certifiId;
            txtChildName.Text = cC.childName;
            txtChildSurname.Text = cC.childSurname;
            txtFartherSurname.Text = cC.fatherSurname;
            txtFatherName.Text = cC.fatherName;
            txtMotherName.Text = cC.motherName;
            txtMotherSurname.Text = cC.motherSurname;
            cboDoctor.Text = cC.doctorName;
            textBox3.Text = "นาย  "+cC.fatherName+"  "+cC.fatherSurname;
            textBox4.Text = "นางสาว  " + cC.motherName + "  " + cC.motherSurname;
            if (cC.childSex == "1")
            {
                chkMale.Checked = true;
            }
            else
            {
                chkFemale.Checked = true;
            }
            if (cC.birthDay == "จันทร์")
            {
                chkMonday.Checked = true;
            }
            else if (cC.birthDay == "อังคาร")
            {
                chkTuesday.Checked = true;
            }
            else if (cC.birthDay == "พุธ")
            {
                chkWednesday.Checked = true;
            }
            else if (cC.birthDay == "พฤหัสบดี")
            {
                chkThurday.Checked = true;
            }
            else if (cC.birthDay == "ศุกร์")
            {
                chkFriday.Checked = true;
            }
            else if (cC.birthDay == "เสาร์")
            {
                chkSaturday.Checked = true;
            }
            else if (cC.birthDay == "อาทิตย์")
            {
                chkSunday.Checked = true;
            }
            if (cC.statusSurname == "1")
            {
                chkUseFather.Checked = true;
            }
            else
            {
                chkUseMother.Checked = true;
            }
            if (cC.birthDayDate.Length > 4)
            {
                txtYear.Text = cC.birthDayYear;
                nudDay.Value = Decimal.Parse(cC.birthDayDate.Substring(0, 2));
            }
            if (cC.birthDayDate != "")
            {
                dtpBirthDay.Value = DateTime.Parse(cC.birthDayDate);
            }
            if (cC.childWeigth != "")
            {
                txtWeigth.Value = Decimal.Parse(cC.childWeigth);
            }
            txtBirthDayTime.Text = cC.birthDayTime;
            setBirthDay();
            setChildName();
        }
        private Boolean getCertifiChild()
        {
            if (txtChildName.Text == "")
            {
                MessageBox.Show("ไม่พบชื่อเด็ก");
                return false;
            }
            if (txtFatherName.Text == "")
            {
                MessageBox.Show("ไม่พบชื่อบิดา");
                return false;
            }
            if (txtFatherName.Text == "")
            {
                MessageBox.Show("ไม่พบชื่อมารดา");
                return false;
            }
            if (txtWeigth.Text == "")
            {
                MessageBox.Show("ไม่พบน้ำหนักเด็ก");
                return false;
            }
            if (txtBirthDayTime.Text == "")
            {
                MessageBox.Show("ไม่พบเวลาเกิด");
                return false;
            }
            if (nudDay.Text == "")
            {
                MessageBox.Show("ไม่พบวันเกิดเด็ก");
                return false;
            }
            if (dtpBirthDay.Value.DayOfWeek.ToString() == "1")
            {
                chkMonday.Checked = true;
            }
            if (chkMonday.Checked)
            {
                cC.birthDay = "จันทร์";
            }
            else if (chkTuesday.Checked)
            {
                cC.birthDay = "อังคาร";
            }
            else if (chkWednesday.Checked)
            {
                cC.birthDay = "พุธ";
            }
            else if (chkThurday.Checked)
            {
                cC.birthDay = "พฤหัสบดี";
            }
            else if (chkFriday.Checked)
            {
                cC.birthDay = "ศุกร์";
            }
            else if (chkSaturday.Checked)
            {
                cC.birthDay = "เสาร์";
            }
            else if (chkSunday.Checked)
            {
                cC.birthDay = "อาทิตย์";
            }
            if (chkMale.Checked)
            {
                cC.childSex = "1";
            }
            else if (chkFemale.Checked)
            {
                cC.childSex = "2";
            }
            if (chkUseFather.Checked)
            {
                cC.statusSurname = "1";
            }
            else
            {
                cC.statusSurname = "2";
            }
            cC.birthDayDate = nudDay.Value.ToString("00") + " " + cboMonth.Text + " " + txtYear.Text;
            cC.birthDayTime = txtBirthDayTime.Text;
            cC.childName = txtChildName.Text.Trim();
            cC.childSurname = txtChildSurname.Text.Trim();
            cC.childWeigth = txtWeigth.Text;
            cC.doctorName = cboDoctor.Text.Trim();
            cC.fatherName = txtFatherName.Text.Trim();
            cC.fatherSurname = txtFartherSurname.Text.Trim();
            cC.motherName = txtMotherName.Text;
            cC.motherSurname = txtMotherSurname.Text.Trim();
            cC.username = cboUsername.Text;
            cC.birthDayYear = txtYear.Text;
            cC.birthDayMonth = cboMonth.Text.Trim();
            return true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FrmCertificatesAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String chk = "";
            if (getCertifiChild())
            {
                chk = cCdb.insertCertifi(cC);
                if (chk == "1")
                {
                    MessageBox.Show("บันทึกข้อมูลเรียบร้อย");
                    this.Dispose();
                }
            }
        }

        private void dtpBirthDay_ValueChanged(object sender, EventArgs e)
        {
            setBirthDay();
        }

        private void txtChildName_KeyUp(object sender, KeyEventArgs e)
        {
            setChildName();
        }

        private void txtChildSurname_KeyUp(object sender, KeyEventArgs e)
        {
            setChildName();
        }

        private void txtFartherSurname_KeyUp(object sender, KeyEventArgs e)
        {
            setChildName();
            setFatherName();
        }

        private void txtMotherSurname_KeyUp(object sender, KeyEventArgs e)
        {
            setChildName();
            setMotherName();
        }

        private void chkMale_CheckedChanged(object sender, EventArgs e)
        {
            setChildName();
        }

        private void chkFemale_CheckedChanged(object sender, EventArgs e)
        {
            setChildName();
        }

        private void chkUseFather_CheckedChanged(object sender, EventArgs e)
        {
            setChildName();
        }

        private void chkUseMother_CheckedChanged(object sender, EventArgs e)
        {
            setChildName();
        }

        private void txtBirthDayTime_Enter(object sender, EventArgs e)
        {
            txtBirthDayTime.BackColor = Color.Pink;
        }

        private void txtBirthDayTime_Leave(object sender, EventArgs e)
        {
            txtBirthDayTime.BackColor = Color.White;
        }

        private void txtWeigth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtFatherName_TextChanged(object sender, EventArgs e)
        {
            setFatherName();
        }
        private void setFatherName()
        {
            textBox3.Text = "นาย  " + txtFatherName.Text + "  " + txtFartherSurname.Text;
        }
        private void setMotherName()
        {
            textBox4.Text = "นาย  " + txtMotherName.Text + "  " + txtMotherSurname.Text;
        }

        private void txtFartherSurname_TextChanged(object sender, EventArgs e)
        {
            //setFatherName();
        }

        private void txtMotherName_TextChanged(object sender, EventArgs e)
        {
            setMotherName();
        }
    }
}
