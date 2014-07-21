using reportBangna.objdb;
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
    public partial class FrmDailypatientsumpaid : Form
    {
        ConnectDB conn;
        public String reportName = "";
        private void initConfig()
        {
            conn = new ConnectDB("mainhis");
            pB1.Hide();
        }
        public FrmDailypatientsumpaid()
        {
            InitializeComponent();
            initConfig();
        }

        private void FrmDailypatientsumpaid_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            FrmReport frm = new FrmReport();
            if (reportName == "MisMonthlypatientsumPaidDay")
            {
                frm.reportName = "MonthlypatientsumPaidDay";
                //RmonthlyGroupIdDB rmgdb = new RmonthlyGroupIdDB();
                String sql = "", datestart = "", dateend = "";
                datestart = dtpStart.Value.Year.ToString() + "-" + dtpStart.Value.ToString("MM-dd");
                dateend = dtpEnd.Value.Year.ToString() + "-" + dtpEnd.Value.ToString("MM-dd");
                //rmgdb.setRMonthlyGroupId(datestart, dateend);
                frm.setRptDailypatientsumPaidDayView(dtpStart.Value, dtpEnd.Value,pB1);
            }
            else if (reportName == "DailyCheckup")
            {
                String sql = "", datestart = "", dateend = "";
                datestart = dtpStart.Value.Year.ToString() + "-" + dtpStart.Value.ToString("MM-dd");
                dateend = dtpEnd.Value.Year.ToString() + "-" + dtpEnd.Value.ToString("MM-dd");

                frm.setRptDailyCheckupView(dtpStart.Value, dtpEnd.Value, pB1);
            }
            else if (reportName == "DailySummaryDoctor")
            {
                String sql = "", datestart = "", dateend = "";
                datestart = dtpStart.Value.Year.ToString() + "-" + dtpStart.Value.ToString("MM-dd");
                dateend = dtpEnd.Value.Year.ToString() + "-" + dtpEnd.Value.ToString("MM-dd");

                frm.setRptDailySummaryDoctor(dtpStart.Value, dtpEnd.Value, pB1);
            }
            else
            {
                frm.reportName = "DailypatientsumPaid";
                frm.setRptDailypatientsumPaidView(dtpStart.Value, dtpEnd.Value, pB1);
            }
            Cursor.Current = cursor;
            frm.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FinanceT01DB ft01db = new FinanceT01DB(conn);

            //ft01db.insertFT01ByDateEndFormCloseDay("2013-06-01");
            
        }
    }
}
