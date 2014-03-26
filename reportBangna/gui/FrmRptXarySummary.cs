using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using reportBangna.objdb;
using System.Reflection;
using System.Configuration;

namespace reportBangna.gui
{
    public partial class FrmRptXarySummary : Form
    {
        ConnectDB conn;
        public String reportName="";
        private void initConfig()
        {
            conn = new ConnectDB();
        }
        private DataTable createRptXraySummary()
        {
            DataTable dt = new DataTable();
            String sql = "";
            sql = "Select ";
            dt = conn.selectData(sql);
            return dt;
        }
        public FrmRptXarySummary()
        {
            InitializeComponent();
            initConfig();
        }

        private void FrmRptXarySummary_Load(object sender, EventArgs e)
        {
            //textBox1.Text  = Assembly.GetEntryAssembly().FullName;
            //AppDomainSetup setup = new AppDomainSetup();
            //AppSettingsReader appReader = new AppSettingsReader();
            //string diPath = (string)appReader.GetValue("DirectoryPath", typeof(string));
            //textBox1.Text = System.Environment.CurrentDirectory; ;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            FrmReport frm = new FrmReport();
            if (reportName == "XrayDailyUseFilm")
            {
                frm.reportName = "xraysummary";
                frm.setRptXraySummaryView(dtpStart.Value, dtpEnd.Value);
                frm.Show(this);
            }
            else if (reportName == "XrayMonthlyUseFilm")
            {
                //MessageBox.Show("aaaa");
                frm.reportName = reportName;
                frm.setRptXraySummaryMountView(dtpStart.Value, dtpEnd.Value);
                frm.Show(this);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
