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
    public partial class FrmHosRiskAdd : Form
    {
        HosRiskDB hrdb;

        public FrmHosRiskAdd()
        {
            InitializeComponent();
            initConfig();
        }
        private void initConfig()
        {
            hrdb = new HosRiskDB();
            cboInFormDeptRisk = hrdb.getCboInFormDeptRisk(cboInFormDeptRisk);
            cboDeptRisk = hrdb.getCboInFormDeptRisk(cboDeptRisk);
            cboLocalRisk = hrdb.getCboLocalRisk(cboLocalRisk);
            cboPsychiatryPrimary = hrdb.getCboPsychiatryPrimary(cboPsychiatryPrimary);
            cboPsychiatrySecond = hrdb.getCboPsychiatryPrimary(cboPsychiatrySecond);
            cboIncidentProgram = hrdb.getCboIncidentProgram(cboIncidentProgram);
            cboIncidentType = hrdb.getCboIncidentType(cboIncidentType);
            cboIncidentCate = hrdb.getCboIncidentCate(cboIncidentCate);
            cboIncidentStype = hrdb.getCboIncidentStype(cboIncidentStype);

            cboCongenital1 = hrdb.getCboCongenital1(cboCongenital1);
            cboCongenital2 = hrdb.getCboCongenital1(cboCongenital2);
            cboCongenital3 = hrdb.getCboCongenital1(cboCongenital3);
            cboCongenital4 = hrdb.getCboCongenital1(cboCongenital4);
            setControl("");
            tab1.TabPages[0].Text = "ข้อมูลความเสี่ยง";
            tab1.TabPages[1].Text = "การวิเคราะห์";
            tab1.TabPages[2].Text = "การประเมิน";
        }
        private HosRisk setHosRisk()
        {
            HosRisk hr = new HosRisk();
            hr.congenital1 = cboCongenital1.Text;
            hr.congenital2 = cboCongenital2.Text;
            hr.congenital3 = cboCongenital3.Text;
            hr.congenital4 = cboCongenital4.Text;
            hr.congenital5 = "";
            hr.dateRisk = dtpDate.Value.Year.ToString() + "-" + dtpDate.Value.ToString("MM-dd");
            hr.deptRisk = cboDeptRisk.Text;
            hr.firstName = txtFirstName.Text;
            hr.HN = txtHN.Text;
            hr.Id = txtHosRiskId.Text;
            hr.ImportanceLevel = cboImportanceLevel.Text;
            hr.IncidentCate = cboIncidentCate.Text;
            hr.IncidentPreliminary = txtIncidentPreliminary.Text;
            hr.IncidentProgram = cboIncidentProgram.Text;
            hr.IncidentStype = cboIncidentStype.Text;
            hr.IncidentSummary = txtIncidentSummary.Text;
            hr.IncidentType = cboIncidentType.Text;
            hr.informDeptRisk = cboInFormDeptRisk.Text;
            hr.InformType = "inform_type";
            hr.lastName = txtLastName.Text;
            hr.localRisk = cboLocalRisk.Text;
            hr.PsychiatryPrimary = cboPsychiatryPrimary.Text;
            hr.PsychiatrySecond = cboPsychiatrySecond.Text;
            hr.riskId = cboRiskId.Text;
            hr.SolveId = "solve_id";
            hr.timeRisk = txtTime.Text;
            hr.visitDate = "visit_date";
            hr.VN = "";
            hr.Ward = "";
            //hr.Active = "hos_rick_active";
            return hr;
        }
        private void setControl(String hosRiskID)
        {
            HosRisk hr = new HosRisk();
            hr = hrdb.selectByPk(hosRiskID);
            cboCongenital1.Text=hr.congenital1;
            cboCongenital2.Text=hr.congenital2;
            cboCongenital3.Text=hr.congenital3;
            cboCongenital4.Text = hr.congenital4;
            //hr.congenital5 = "";
            //hr.dateRisk = dtpDate.Value.Year.ToString() + "-" + dtpDate.Value.ToString("MM-dd"); ;
            cboDeptRisk.Text=hr.deptRisk;
            txtFirstName.Text=hr.firstName;
            txtHN.Text=hr.HN ;
            txtHosRiskId.Text=hr.Id;
            cboImportanceLevel.Text=hr.ImportanceLevel;
            cboIncidentCate.Text=hr.IncidentCate;
            txtIncidentPreliminary.Text=hr.IncidentPreliminary;
            cboIncidentProgram.Text=hr.IncidentProgram;
            cboIncidentStype.Text=hr.IncidentStype;
            txtIncidentSummary.Text=hr.IncidentSummary;
            cboIncidentType.Text=hr.IncidentType;
            cboInFormDeptRisk.Text=hr.informDeptRisk;
            //hr.InformType = "inform_type";
            txtLastName.Text=hr.lastName;
            cboLocalRisk.Text=hr.localRisk;
            cboPsychiatryPrimary.Text=hr.PsychiatryPrimary;
            cboPsychiatrySecond.Text=hr.PsychiatrySecond;
            cboRiskId.Text=hr.riskId;
            //hr.SolveId = "solve_id";
            txtTime.Text=hr.timeRisk;
            //hr.visitDate = "visit_date";
            //hr.VN = "";
            //hr.Ward = "";
        }
        private void saveHosRisk()
        {
            HosRisk hr = new HosRisk();
            hr = setHosRisk();
            String chk = hrdb.insertHosRisk(hr);
            MessageBox.Show("  "+chk, "");
        }

        private void FrmHosRiskAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveHosRisk();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            FrmHosRiskView frm = new FrmHosRiskView();
            frm.Show();
            this.Hide();
        }

        private void btnUpdateAnalyze_Click(object sender, EventArgs e)
        {
            String chkAP = "", chkAE = "", chkAT = "", chkAV = "", chkAL = "", chkAO = "";
            HosRisk hr = new HosRisk();
            if (chkAP1.Checked)
            {
                hr.AnalyzePatient = "1";
                hr.AnalyzePatientOther = "";
            }
            else if (chkAP2.Checked)
            {
                hr.AnalyzePatient = "2";
                hr.AnalyzePatientOther = "";
            }
            else if (chkAP3.Checked)
            {
                hr.AnalyzePatient = "3";
                hr.AnalyzePatientOther = "";
            }
            else if (chkAP4.Checked)
            {
                hr.AnalyzePatient = "4";
                hr.AnalyzePatientOther = "";
            }
            else if (chkAPOther.Checked)
            {
                hr.AnalyzePatient = "other";
                hr.AnalyzePatientOther = txtAPOther.Text;
            }
            chkAP = hrdb.UpdateAnalyzePatient(txtHosRiskId.Text,hr.AnalyzePatient, hr.AnalyzePatientOther);
            if (chkAE1.Checked)
            {
                hr.AnalyzeEmp = "1";
                hr.AnalyzeEmpOther = "";
            }
            else if (chkAE2.Checked)
            {
                hr.AnalyzeEmp = "2";
                hr.AnalyzeEmpOther = "";
            }
            else if (chkAE3.Checked)
            {
                hr.AnalyzeEmp = "3";
                hr.AnalyzeEmpOther = "";
            }
            else if (chkAE4.Checked)
            {
                hr.AnalyzeEmp = "4";
                hr.AnalyzeEmpOther = "";
            }
            else if (chkAE5.Checked)
            {
                hr.AnalyzeEmp = "5";
                hr.AnalyzeEmpOther = "";
            }
            else if (chkAE6.Checked)
            {
                hr.AnalyzeEmp = "6";
                hr.AnalyzeEmpOther = "";
            }
            else if (chkAEOther.Checked)
            {
                hr.AnalyzeEmp = "other";
                hr.AnalyzeEmpOther = txtAEOther.Text;
            }
            chkAE = hrdb.UpdateAnalyzeEmp(txtHosRiskId.Text, hr.AnalyzeEmp, hr.AnalyzeEmpOther);
            if (chkAT1.Checked)
            {
                hr.AnalyzeTeam = "1";
                hr.AnalyzeTeamOther = "";
            }
            else if (chkAT2.Checked)
            {
                hr.AnalyzeTeam = "2";
                hr.AnalyzeTeamOther = "";
            }
            else if (chkAT3.Checked)
            {
                hr.AnalyzeTeam = "3";
                hr.AnalyzeTeamOther = "";
            }
            else if (chkAT4.Checked)
            {
                hr.AnalyzeTeam = "4";
                hr.AnalyzeTeamOther = "";
            }
            else if (chkAT5.Checked)
            {
                hr.AnalyzeTeam = "5";
                hr.AnalyzeTeamOther = "";
            }
            else if (chkATOther.Checked)
            {
                hr.AnalyzeTeam = "other";
                hr.AnalyzeTeamOther = txtATOther.Text;
            }
            chkAT = hrdb.UpdateAnalyzeTeam(txtHosRiskId.Text, hr.AnalyzeTeam, hr.AnalyzeTeamOther);
            if (chkAV1.Checked)
            {
                hr.AnalyzeEnvir = "1";
                hr.AnalyzeEnvirOther = "";
            }
            else if (chkAV2.Checked)
            {
                hr.AnalyzeEnvir = "2";
                hr.AnalyzeEnvirOther = "";
            }
            else if (chkAVOther.Checked)
            {
                hr.AnalyzeEnvir = "other";
                hr.AnalyzeEnvirOther = txtAVOther.Text;
            }
            chkAV = hrdb.UpdateAnalyzeEnvir(txtHosRiskId.Text, hr.AnalyzeEnvir, hr.AnalyzeEnvirOther);
            if (chkAL1.Checked)
            {
                hr.AnalyzePolice = "1";
                hr.AnalyzePoliceOther = "";
            }
            else if (chkAL2.Checked)
            {
                hr.AnalyzePolice = "2";
                hr.AnalyzePoliceOther = "";
            }
            else if (chkAL3.Checked)
            {
                hr.AnalyzePolice = "3";
                hr.AnalyzePoliceOther = "";
            }
            else if (chkALOther.Checked)
            {
                hr.AnalyzePolice = "other";
                hr.AnalyzePoliceOther = txtAPOther.Text;
            }
            chkAL = hrdb.UpdateAnalyzePolice(txtHosRiskId.Text, hr.AnalyzePolice, hr.AnalyzePoliceOther);
            if (chkAO1.Checked)
            {
                hr.AnalyzeOrg = "1";
                hr.AnalyzeOrgOther = "";
            }
            else if (chkAO2.Checked)
            {
                hr.AnalyzeOrg = "2";
                hr.AnalyzeOrgOther = "";
            }
            else if (chkAOOther.Checked)
            {
                hr.AnalyzeOrg = "other";
                hr.AnalyzeOrgOther = txtAOOther.Text;
            }
            chkAO = hrdb.UpdateAnalyzeOrg(txtHosRiskId.Text, hr.AnalyzeOrg, hr.AnalyzeOrgOther);
            MessageBox.Show(" UpdateAnalyzePatient " + chkAP + " UpdateAnalyzeEmp " + chkAE + " UpdateAnalyzeTeam " + chkAT + " UpdateAnalyzeEnvir " + chkAV + " UpdateAnalyzePolice " + chkAL + " UpdateAnalyzeOrg " + chkAO, "");
        }

        private void btnUpdateViolence_Click(object sender, EventArgs e)
        {
            String chkVA1 = "", chkDept="";
            HosRisk hr = new HosRisk();
            if (chkVA.Checked)
            {
                hr.ViolenceLevel = "A";                
            }
            else if (chkVB.Checked)
            {
                hr.ViolenceLevel = "B";                
            }
            else if (chkVC.Checked)
            {
                hr.ViolenceLevel = "C";
            }
            else if (chkVD.Checked)
            {
                hr.ViolenceLevel = "D";
            }
            else if (chkVE.Checked)
            {
                hr.ViolenceLevel = "E";
            }
            else if (chkVF.Checked)
            {
                hr.ViolenceLevel = "F";
            }
            else if (chkVG.Checked)
            {
                hr.ViolenceLevel = "G";
            }
            else if (chkVH.Checked)
            {
                hr.ViolenceLevel = "H";
            }
            else if (chkVI.Checked)
            {
                hr.ViolenceLevel = "I";
            }
            chkVA1 = hrdb.UpdateVielenceLEvel(txtHosRiskId.Text, hr.ViolenceLevel);

            if (chkDeptMSO.Checked)
            {
                hr.deptConcerned = "MSO";
                hr.deptWard = "";
            }
            else if (chkDeptHRD.Checked)
            {
                hr.deptConcerned = "HRD";
                hr.deptWard = "";
            }
            else if (chkDeptENV.Checked)
            {
                hr.deptConcerned = "ENV";
                hr.deptWard = "";
            }
            else if (chkDeptMM.Checked)
            {
                hr.deptConcerned = "MM";
                hr.deptWard = "";
            }
            else if (chkDeptPCIM.Checked)
            {
                hr.deptConcerned = "PCIM";
                hr.deptWard = "";
            }
            else if (chkDeptPCIL.Checked)
            {
                hr.deptConcerned = "PCIL";
                hr.deptWard = "";
            }
            else if (chkDeptNSO.Checked)
            {
                hr.deptConcerned = "NSO";
                hr.deptWard = "";
            }
            else if (chkDeptIC.Checked)
            {
                hr.deptConcerned = "IC";
                hr.deptWard = "";
            }
            else if (chkDeptIM.Checked)
            {
                hr.deptConcerned = "IM";
                hr.deptWard = "";
            }
            else if (chkDeptPCIOPD.Checked)
            {
                hr.deptConcerned = "PCIOPD";
                hr.deptWard = "";
            }
            else if (chkDeptPCIW.Checked)
            {
                hr.deptConcerned = "PCIW";
                hr.deptWard = "";
            }
            else if (chkDeptPCIP.Checked)
            {
                hr.deptConcerned = "PCIP";
                hr.deptWard = "";
            }
            else if (chkDeptOther.Checked)
            {
                hr.deptConcerned = "other";
                hr.deptWard = cboDeptWard.Text;
            }
            chkDept = hrdb.UpdateDeptConcerned(txtHosRiskId.Text, hr.deptConcerned, hr.deptWard);
            MessageBox.Show("  btnUpdateViolence_Click " + chkVA1 + " deptConcerned " + chkDept, "");
        }
    }
}
