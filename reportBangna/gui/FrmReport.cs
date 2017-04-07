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
using Microsoft.Reporting.WinForms;
//using Microsoft.Reporting.WinForms;


namespace reportBangna.gui
{
    public partial class FrmReport : Form
    {
        private ConnectDB conn;
        private reportDB reportdb;
        public String reportName { get; set; }
         
        private void initConfig()
        {
            //MessageBox.Show("inifConfig aaaaa");
            conn = new ConnectDB("mainhis");
            //MessageBox.Show("initConfig bbbb");
            reportdb = new reportDB(conn);
            //MessageBox.Show("initConfig cccc");
        }
        public FrmReport()
        {
            InitializeComponent();
            initConfig();
        }
        public DataTable getXraySummaryView(DateTime dateStart, DateTime dateEnd)
        {
            conn = new ConnectDB("mainhis");
            reportdb.conn = conn;
            return reportdb.xraySummary(dateStart, dateEnd);
        }
        public DataTable getXraySummaryMountView(DateTime dateStart, DateTime dateEnd)
        {
            conn = new ConnectDB("mainhis");
            reportdb.conn = conn;
            return reportdb.xraySummaryMount(dateStart, dateEnd);
        }
        public DataTable getDailypatientsumPaidView(DateTime dateStart, DateTime dateEnd, ProgressBar pb)
        {
            conn = new ConnectDB("mainhis");
            reportdb.conn = conn;
            return reportdb.dailypatientsumpaid(dateStart, dateEnd, pb);
        }
        public DataTable getDailypatientsumPaidDayView(DateTime dateStart, DateTime dateEnd, ProgressBar pb)
        {
            conn = new ConnectDB("bangna");
            reportdb.conn = conn;
            return reportdb.dailypatientsumpaidDay(dateStart, dateEnd,pb);
        }
        public DataTable getDailyCheckupView(DateTime dateStart, DateTime dateEnd, ProgressBar pb)
        {
            conn = new ConnectDB("bangna");
            reportdb.conn = conn;
            return reportdb.dailyCheckup(dateStart, dateEnd, pb);
        }
        public DataTable getDailySummaryDoctorView(DateTime dateStart, DateTime dateEnd, ProgressBar pb)
        {
            conn = new ConnectDB("mainhis");
            reportdb.conn = conn;
            return reportdb.dailySummaryDoctor(dateStart, dateEnd);
        }
        public void setRptXraySummaryView(DateTime dateStart, DateTime dateEnd)
        {
            try
            {
                ReportDataSource rds = new ReportDataSource("xraySummary", getXraySummaryView(dateStart, dateEnd));
                //MessageBox.Show("bbbb");
                rV1.LocalReport.DataSources.Add(rds);
                //rV1.LocalReport.ReportPath = "d:\\source\\reportBangna\\reportBangna\\report\\xraysummary.rdlc";
                rV1.LocalReport.ReportPath = System.Environment.CurrentDirectory + "\\report\\xraysummary.rdlc";
                ReportParameter reportParaHeader1 = new ReportParameter();
                reportParaHeader1.Name = "header1";
                reportParaHeader1.Values.Add("โรงพยาบาล บางนา5");
                rV1.LocalReport.SetParameters(reportParaHeader1);
                ReportParameter reportParaHeader2 = new ReportParameter();
                reportParaHeader2.Name = "header2";
                reportParaHeader2.Values.Add("รายงานยอด XRAY");
                rV1.LocalReport.SetParameters(reportParaHeader2);
                ReportParameter reportParaHeader3 = new ReportParameter();
                reportParaHeader3.Name = "header3";
                reportParaHeader3.Values.Add("ประจำวันที่ "+dateStart.ToString("dd-MM-yyyy")+" ถึงวันที่  "+dateEnd.ToString("dd-MM-yyyy"));
                rV1.LocalReport.SetParameters(reportParaHeader3);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }
        }
        public void setRptXraySummaryMountView(DateTime dateStart, DateTime dateEnd)
        {
            try
            {
                ReportDataSource rds = new ReportDataSource("xray_SummaryMount", getXraySummaryMountView(dateStart, dateEnd));
                //MessageBox.Show("bbbb");
                rV1.LocalReport.DataSources.Add(rds);
                //rV1.LocalReport.ReportPath = "d:\\source\\reportBangna\\reportBangna\\report\\xray_SummaryMount.rdlc";
                rV1.LocalReport.ReportPath = System.Environment.CurrentDirectory + "\\report\\xray_summaryMount.rdlc";
                ReportParameter reportParaHeader1 = new ReportParameter();
                reportParaHeader1.Name = "header1";
                reportParaHeader1.Values.Add("โรงพยาบาล บางนา5");
                rV1.LocalReport.SetParameters(reportParaHeader1);
                ReportParameter reportParaHeader2 = new ReportParameter();
                reportParaHeader2.Name = "header2";
                reportParaHeader2.Values.Add("รายงานสรุปยอด XRAY");
                rV1.LocalReport.SetParameters(reportParaHeader2);
                ReportParameter reportParaHeader3 = new ReportParameter();
                reportParaHeader3.Name = "header3";
                reportParaHeader3.Values.Add("ประจำวันที่ " + dateStart.ToString("dd-MM-yyyy") + " ถึงวันที่  " + dateEnd.ToString("dd-MM-yyyy"));
                rV1.LocalReport.SetParameters(reportParaHeader3);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }
        }
        public void setRptDailypatientsumPaidView(DateTime dateStart, DateTime dateEnd, ProgressBar pb)
        {
            try
            {
                ReportDataSource rds = new ReportDataSource("Dailypatientsumpaid", getDailypatientsumPaidView(dateStart, dateEnd, pb));
                //MessageBox.Show("bbbb");
                rV1.LocalReport.DataSources.Add(rds);
                //rV1.LocalReport.ReportPath = "d:\\source\\reportBangna\\reportBangna\\report\\xray_SummaryMount.rdlc";
                rV1.LocalReport.ReportPath = System.Environment.CurrentDirectory + "\\report\\DailypatientsumPaid.rdlc";
                ReportParameter reportParaHeader1 = new ReportParameter();
                reportParaHeader1.Name = "header1";
                reportParaHeader1.Values.Add("โรงพยาบาล บางนา5");
                rV1.LocalReport.SetParameters(reportParaHeader1);
                ReportParameter reportParaHeader2 = new ReportParameter();
                reportParaHeader2.Name = "header2";
                reportParaHeader2.Values.Add("รายงานสรุปยอดคนไข้แยกตามสิทธิ");
                rV1.LocalReport.SetParameters(reportParaHeader2);
                ReportParameter reportParaHeader3 = new ReportParameter();
                reportParaHeader3.Name = "header3";
                reportParaHeader3.Values.Add("ประจำวันที่ " + dateStart.ToString("dd-MM-yyyy") + " ถึงวันที่  " + dateEnd.ToString("dd-MM-yyyy"));
                rV1.LocalReport.SetParameters(reportParaHeader3);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }
        }
        public void setRptDailypatientsumPaidDayView(DateTime dateStart, DateTime dateEnd, ProgressBar pb)
        {
            try
            {
                ReportDataSource rds = new ReportDataSource("DailypatientsumPaidDay", getDailypatientsumPaidDayView(dateStart, dateEnd,pb));
                //MessageBox.Show("bbbb");
                rV1.LocalReport.DataSources.Add(rds);
                rV1.LocalReport.ReportPath = "d:\\source\\bangna\\reportBangna\\reportBangna\\report\\DailypatientsumPaidDay.rdlc";
                rV1.LocalReport.ReportPath = System.Environment.CurrentDirectory + "\\report\\DailypatientsumPaidDay.rdlc";
                ReportParameter reportParaHeader1 = new ReportParameter();
                reportParaHeader1.Name = "header1";
                reportParaHeader1.Values.Add("โรงพยาบาล บางนา5");
                rV1.LocalReport.SetParameters(reportParaHeader1);
                ReportParameter reportParaHeader2 = new ReportParameter();
                reportParaHeader2.Name = "header2";
                reportParaHeader2.Values.Add("รายงานสรุปยอดคนไข้แยกตามสิทธิเรียงตามวันที่");
                rV1.LocalReport.SetParameters(reportParaHeader2);
                ReportParameter reportParaHeader3 = new ReportParameter();
                reportParaHeader3.Name = "header3";
                reportParaHeader3.Values.Add("ประจำวันที่ " + dateStart.ToString("dd-MM-yyyy") + " ถึงวันที่  " + dateEnd.ToString("dd-MM-yyyy"));
                rV1.LocalReport.SetParameters(reportParaHeader3);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }
        }
        public void setRptDailySummaryDoctor(DateTime dateStart, DateTime dateEnd, ProgressBar pb)
        {
            try
            {
                ReportDataSource rds = new ReportDataSource("DailySummaryDoctor", getDailySummaryDoctorView(dateStart, dateEnd, pb));
                //MessageBox.Show("bbbb");
                rV1.LocalReport.DataSources.Add(rds);
                //rV1.LocalReport.ReportPath = "d:\\source\\reportBangna\\reportBangna\\report\\DailypatientsumPaidDay.rdlc";
                rV1.LocalReport.ReportPath = System.Environment.CurrentDirectory + "\\report\\DailySummaryDoctor.rdlc";
                ReportParameter reportParaHeader1 = new ReportParameter();
                reportParaHeader1.Name = "header1";
                reportParaHeader1.Values.Add("โรงพยาบาล บางนา5");
                rV1.LocalReport.SetParameters(reportParaHeader1);
                ReportParameter reportParaHeader2 = new ReportParameter();
                reportParaHeader2.Name = "header2";
                reportParaHeader2.Values.Add("รายงานยอดตรวจคนไข้แยกตามแพทย์ ");
                rV1.LocalReport.SetParameters(reportParaHeader2);
                ReportParameter reportParaHeader3 = new ReportParameter();
                reportParaHeader3.Name = "header3";
                reportParaHeader3.Values.Add("ประจำวันที่ " + dateStart.ToString("dd-MM-yyyy") + " ถึงวันที่  " + dateEnd.ToString("dd-MM-yyyy"));
                rV1.LocalReport.SetParameters(reportParaHeader3);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }
        }
        public void setRptDailyCheckupView(DateTime dateStart, DateTime dateEnd, ProgressBar pb)
        {
            try
            {
                ReportDataSource rds = new ReportDataSource("DailyCheckup", getDailyCheckupView(dateStart, dateEnd, pb));
                //MessageBox.Show("bbbb");
                rV1.LocalReport.DataSources.Add(rds);
                //rV1.LocalReport.ReportPath = "d:\\source\\reportBangna\\reportBangna\\report\\DailypatientsumPaidDay.rdlc";
                rV1.LocalReport.ReportPath = System.Environment.CurrentDirectory + "\\report\\DailyCheckup.rdlc";
                ReportParameter reportParaHeader1 = new ReportParameter();
                reportParaHeader1.Name = "header1";
                reportParaHeader1.Values.Add("โรงพยาบาล บางนา5");
                rV1.LocalReport.SetParameters(reportParaHeader1);
                ReportParameter reportParaHeader2 = new ReportParameter();
                reportParaHeader2.Name = "header2";
                reportParaHeader2.Values.Add("รายงานสรุปยอดคนไข้ตรวจสุขภาพก่อนเข้างาน");
                rV1.LocalReport.SetParameters(reportParaHeader2);
                ReportParameter reportParaHeader3 = new ReportParameter();
                reportParaHeader3.Name = "header3";
                reportParaHeader3.Values.Add("ประจำวันที่ " + dateStart.ToString("dd-MM-yyyy") + " ถึงวันที่  " + dateEnd.ToString("dd-MM-yyyy"));
                rV1.LocalReport.SetParameters(reportParaHeader3);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }
        }
        private void setResize()
        {
            rV1.Size = new Size(this.Width - 40, this.Height - 70);
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("aaaa");

            //MessageBox.Show("cccc");
            this.rV1.RefreshReport();
            //MessageBox.Show("dddd");
            setResize();
        }

        private void FrmReport_Resize(object sender, EventArgs e)
        {
            setResize();
        }
    }
}
