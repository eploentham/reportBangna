using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using reportBangna.gui;

namespace reportBangna
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRptXarySummary frmRptXray = new FrmRptXarySummary();
            frmRptXray.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void tv1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            String nodeSelect = "";
            nodeSelect = tv1.SelectedNode.Name.ToString();
            if (nodeSelect == "nXrayDailyUseFilm")
            {
                FrmRptXarySummary frm = new FrmRptXarySummary();
                frm.reportName = "XrayDailyUseFilm";
                frm.Show(this);
            }
            else if (nodeSelect == "nXrayMonthlyUseFilm")
            {
                FrmRptXarySummary frm = new FrmRptXarySummary();
                frm.reportName = "XrayMonthlyUseFilm";
                frm.Show(this);
            }
            else if (nodeSelect == "nMisDailypatientsumPaid")
            {
                FrmDailypatientsumpaid frm = new FrmDailypatientsumpaid();
                frm.reportName = "MisDailypatientsumPaid";
                frm.Show(this);
            }
            else if (nodeSelect == "nMisMonthlypatientsumPaidDay")
            {
                FrmDailypatientsumpaid frm = new FrmDailypatientsumpaid();
                frm.reportName = "MisMonthlypatientsumPaidDay";
                frm.Show(this);
            }
            else if (nodeSelect == "nCertificatesChild")
            {
                FrmCertificatesView frm = new FrmCertificatesView();
                //frm.setData("","");
                frm.Show(this);
            }
            else if (nodeSelect == "nDailyCheckup")
            {
                FrmDailypatientsumpaid frm = new FrmDailypatientsumpaid();
                frm.reportName = "DailyCheckup";
                frm.Show(this);
            }
            else if (nodeSelect == "nDailySummaryDoctor")
            {
                FrmDailypatientsumpaid frm = new FrmDailypatientsumpaid();
                frm.reportName = "DailySummaryDoctor";
                frm.Show(this);
            }
            else if (nodeSelect == "nChkStaffNote")
            {
                FrmChkStaffNote frm = new FrmChkStaffNote();
                //frm.setData("","");
                frm.Show(this);
            }
            else if (nodeSelect == "nCheckNHSO")
            {
                FrmCheckNHSO frm = new FrmCheckNHSO();
                //frm.setData("","");
                frm.Show(this);
            }
        }

        private void tv1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
