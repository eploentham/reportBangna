//using CrystalDecisions.CrystalReports.Engine;
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
    public partial class FrmReport1 : Form
    {
        BangnaControl bc;
        public FrmReport1(BangnaControl b)
        {
            InitializeComponent();
            bc = b;
        }
        public FrmReport1()
        {
            InitializeComponent();
        }
        public void setReportLabBillSummary(DataTable dt)
        {
            String chk = "";
            //ReportDocument rpt = new ReportDocument();
            try
            {
                //cc.lw.WriteLog("rpt.setReportResult OK ");
                //rpt.Load(Environment.CurrentDirectory + "\\repor\\LabBillSummary.rpt");
                //rpt.SetDataSource(dt);
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                //ds.Tables[0].TableName = "patientdead";
                //rpt.SetDataSource(ds);
                //cc.lw.WriteLog("rpt.setReportResult OK SetDataSource");

                //rpt.SetParameterValue("compName", cc.cp.NameT);
                //rpt.SetParameterValue("compAddress1", cc.cp.AddressT);
                //rpt.SetParameterValue("compAddress2", "Tel " + cc.cp.Tele + " FAX " + cc.cp.Fax + " Email " + cc.cp.Email);
                //rpt.SetParameterValue("taxid", cc.cp.TaxId);

                //rpt.SetParameterValue("custName", rs.CustNameT);
                //rpt.SetParameterValue("custAddress", rs.CustAddressT);
                //rpt.SetParameterValue("machinery", rs.Machinery);
                //rpt.SetParameterValue("measurecompany", cc.cp.NameT);
                //rpt.SetParameterValue("methodmeasure", rs.MethodMeasure);

                //rpt.SetParameterValue("summary", rs.Summary);
                //rpt.SetParameterValue("line1", cc.cp.quLine1);
                //rpt.SetParameterValue("line2", cc.cp.quLine1);
                //rpt.SetParameterValue("line3", cc.cp.quLine1);
                //rpt.SetParameterValue("datedueperiod", rs.InvDuePeriod);
                ////rpt.SetParameterValue("duedate", "");
                //rpt.SetParameterValue("amount", rs.Amount);
                //rpt.SetParameterValue("total", rs.Total);

                //rpt.SetParameterValue("vatrate", rs.VatRate);

                //rpt.SetParameterValue("nettotal", rs.Nettotal);
                //rpt.SetParameterValue("contactName", qu.ContactName);

                //rpt.SetParameterValue("line2", inv.StaffPlaceRecordPosition);
                //rpt.SetParameterValue("staffplacerecordname", inv.StaffPlaceRecordName);
                //rpt.SetParameterValue("line3", "ลูกค้า/ผู้ประสานงาน/ผู้รัลผิดชอบการตรวจ");

                //this.crystalReportViewer1.ReportSource = rpt;
                //this.crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                chk = ex.Message.ToString();
                //cc.lw.WriteLog("rpt.setReportResult Error " + chk);
            }
        }
        public void setReportPatientDead(DataTable dt)
        {
            String chk = "";
            //ReportDocument rpt = new ReportDocument();
            try
            {
                //cc.lw.WriteLog("rpt.setReportResult OK ");
                //rpt.Load(Environment.CurrentDirectory + "\\ReportCrystal\\PatientDeadPrint.rpt");
                //rpt.SetDataSource(dt);
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                //ds.Tables[0].TableName = "patientdead";
                //rpt.SetDataSource(ds);
                //cc.lw.WriteLog("rpt.setReportResult OK SetDataSource");

                //rpt.SetParameterValue("compName", cc.cp.NameT);
                //rpt.SetParameterValue("compAddress1", cc.cp.AddressT);
                //rpt.SetParameterValue("compAddress2", "Tel " + cc.cp.Tele + " FAX " + cc.cp.Fax + " Email " + cc.cp.Email);
                //rpt.SetParameterValue("taxid", cc.cp.TaxId);

                //rpt.SetParameterValue("custName", rs.CustNameT);
                //rpt.SetParameterValue("custAddress", rs.CustAddressT);
                //rpt.SetParameterValue("machinery", rs.Machinery);
                //rpt.SetParameterValue("measurecompany", cc.cp.NameT);
                //rpt.SetParameterValue("methodmeasure", rs.MethodMeasure);

                //rpt.SetParameterValue("summary", rs.Summary);
                //rpt.SetParameterValue("line1", cc.cp.quLine1);
                //rpt.SetParameterValue("line2", cc.cp.quLine1);
                //rpt.SetParameterValue("line3", cc.cp.quLine1);
                //rpt.SetParameterValue("datedueperiod", rs.InvDuePeriod);
                ////rpt.SetParameterValue("duedate", "");
                //rpt.SetParameterValue("amount", rs.Amount);
                //rpt.SetParameterValue("total", rs.Total);

                //rpt.SetParameterValue("vatrate", rs.VatRate);

                //rpt.SetParameterValue("nettotal", rs.Nettotal);
                //rpt.SetParameterValue("contactName", qu.ContactName);

                //rpt.SetParameterValue("line2", inv.StaffPlaceRecordPosition);
                //rpt.SetParameterValue("staffplacerecordname", inv.StaffPlaceRecordName);
                //rpt.SetParameterValue("line3", "ลูกค้า/ผู้ประสานงาน/ผู้รัลผิดชอบการตรวจ");

                //this.crystalReportViewer1.ReportSource = rpt;
                //this.crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                chk = ex.Message.ToString();
                //cc.lw.WriteLog("rpt.setReportResult Error " + chk);
            }
        }
        private void FrmReport1_Load(object sender, EventArgs e)
        {

        }
    }
}
