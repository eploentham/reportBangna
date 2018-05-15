using reportBangna.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace reportBangna.objdb
{
    class SSODB
    {
        Config1 cf;
        public ConnectDB conn;
        public ConnectDB connMain;
        public DataTable dtOutPatient;
        public int cntOutPatient = 0;
        public Boolean isConnectOpen = false;
        public String HCODE="", HNAME="", SESSNO="";
        public String fileOPService = "", fileBillTran="";

        public SSODB(String pathAccessSSO)
        {
            initConfig(pathAccessSSO,"");
        }
        public SSODB(String pathAccessSSO, String flag)
        {
            initConfig(pathAccessSSO,flag);
        }
        private void initConfig(String pathAccessSSO, String flag)
        {
            cf = new Config1();
            conn = new ConnectDB("sso", pathAccessSSO, flag);
            connMain = new ConnectDB("mainhis");
            dtOutPatient = selectOutPatient();
            cntOutPatient = dtOutPatient.Rows.Count;
            isConnectOpen = true;
        }
        public DataTable selectOutPatient()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * " +
                "From OutpatientHdr2 " +
                "Order By TransactionNumber ";
            dt = conn.selectData(sql);
            return dt;
        }
        public void genXML(String pathXML, ProgressBar pB1)
        {
            int i = 0;
            StringBuilder txtBill = new StringBuilder();
            StringBuilder txtItem = new StringBuilder();
            StringBuilder txtBillDisp = new StringBuilder();
            String date = System.DateTime.Now.ToString("yyyy-MM-dd");
            String time = System.DateTime.Now.ToString("HH:mm:ss");

            String station = "0001", authcode = "", dtran = "", invno = "", billno = "", hn = "", memberno = "", amount = "", paid = "", vercode = "", tflag = "", pid = "";
            String name ="", hmain="", payplan="", claimant="", otherpayplan="", otherpay="", hcode="";

            String providerid = "", dispid = "", prescdt = "", dispdt = "", prescd = "", itemcnt = "", BillDispchargeamt = "", BillDispclaimamt = "", reimburser = "";
            String benefitplan = "", dispestat = "", svid = "", daycover = "", BillDisppaid="", BillDispotherpay="";
            String sql = "";
            pB1.Minimum = 0;
            pB1.Maximum = cntOutPatient;

            foreach (DataRow row in dtOutPatient.Rows)
            {
                i++;
                pB1.Value = i;
                dtran = row["admitdate"].ToString();
                if (dtran.Length > 10)
                {
                    dtran = dtran.Substring(6, 4) + "-" + dtran.Substring(3, 2) + "-" + dtran.Substring(0, 2) + "T";
                    String time1 = "", time3 = "";
                    time1 = row["admitdate"].ToString().Substring(12);
                    String[] time2 = time1.Split(':');
                    if (time2.Length > 0)
                    {
                        if (time2[0].Length == 1)
                        {
                            time3 = "0";
                        }
                    }
                    time3 += time2[0] + ":" + time2[1] + ":" + time2[2];
                    dtran += time3;
                }
                //hcode = row["ServiceHospitalCode"].ToString();
                hcode = row["MainHospitalCode"].ToString();
                invno = row["TransactionNumber"].ToString();
                billno = row["TransactionNumber"].ToString();
                hn = row["hn"].ToString();
                amount = row["GrandTotal"].ToString();
                paid = row["TotalPatientPaid"].ToString();
                pid = row["IDCardNumber"].ToString();
                hmain = row["MainHospitalCode"].ToString();
                otherpay = row["TotalOthersPaid"].ToString();
                claimant = row["TotalSocialPaid"].ToString();
                tflag = "A";
                payplan = "80";
                hmain = hmain.Replace("00", "");
                txtBill.Append(station).Append("|").Append(authcode).Append("|").Append(dtran).Append("|").Append(hcode).Append("|").Append(invno)
                    .Append("|").Append(billno).Append("|").Append(hn).Append("|").Append(memberno).Append("|").Append(amount).Append("|").Append(paid)
                    .Append("|").Append(vercode).Append("|").Append(tflag).Append("|").Append(pid).Append("|").Append(name)
                    .Append("|").Append(hmain).Append("|").Append(payplan).Append("|").Append(claimant).Append("|").Append(otherpayplan)
                    .Append("|").Append(otherpay).Append(Environment.NewLine);

                providerid = station;
                sql = "Select phart05.mnc_req_no, phart05.mnc_req_dat, phart05.mnc_req_tim, sum(phart06.mnc_ph_pri) as mnc_ph_pri, count(phart06.mnc_ph_pri) as cnt " +
                    "From pharmacy_t05 phart05 " +
                    "left join PHARMACY_T06 phart06 on phart05.MNC_CFR_NO = phart06.MNC_CFR_NO and phart05.MNC_CFG_DAT = phart06.MNC_CFR_dat " +
                    "Where phart05.mnc_hn_no = '" + hn.Substring(2) + "' "+
                    "phart05.MNC_date = '" + dtran.Substring(0, dtran.IndexOf("T")) + "' and phart05.MNC_CFR_STS = 'a'  ";
                DataTable dtDisp = connMain.selectData(sql);
                foreach (DataRow rowDisp in dtDisp.Rows)
                {
                    String timeDisp = "", dateDisp="";
                    dispid = "000000000"+ rowDisp["mnc_req_no"].ToString();
                    timeDisp = "0" + rowDisp["mnc_req_tim"].ToString();
                    dateDisp = rowDisp["mnc_req_dat"].ToString();
                }

                txtBillDisp.Append(providerid).Append("|").Append(dispid).Append("|").Append(invno).Append("|").Append(hn).Append("|").Append(pid)
                    .Append("|").Append(prescdt).Append("|").Append(dispdt).Append("|").Append(prescd).Append("|").Append(itemcnt).Append("|").Append(BillDispchargeamt)
                    .Append("|").Append(BillDispclaimamt).Append("|").Append(BillDisppaid).Append("|").Append(BillDispotherpay).Append("|").Append(reimburser)
                    .Append("|").Append(benefitplan).Append("|").Append(dispestat).Append("|").Append(svid).Append("|").Append(daycover).Append(Environment.NewLine);

                sql = "Select phart06.MNC_PH_CD, pharmacy_m01.MNC_PH_TN ,PHARMACY_M05.MNC_PH_PRI01,PHARMACY_M05.MNC_PH_PRI02 " +
                        ",PHARMACY_M05.MNC_PH_PRI03,sum(phart06.MNC_PH_QTY) as MNC_PH_QTY, phart05.mnc_req_dat " +
                        "From PATIENT_T01 t01 " +
                        "left join PHARMACY_T05 phart05 on t01.MNC_PRE_NO = phart05.MNC_PRE_NO and t01.MNC_date = phart05.mnc_date " +
                        "left join PHARMACY_T06 phart06 on phart05.MNC_CFR_NO = phart06.MNC_CFR_NO and phart05.MNC_CFG_DAT = phart06.MNC_CFR_dat " +
                        "left join PHARMACY_M01 on phart06.MNC_PH_CD = pharmacy_m01.MNC_PH_CD " +
                        "left join PHARMACY_M05 on PHARMACY_M05.MNC_PH_CD = PHARMACY_M01.MNC_PH_CD " +
                        "where " +
                        " t01.mnc_hn_no = '" + hn.Substring(2) + "' " +
                        "and t01.MNC_date = '" + dtran.Substring(0, dtran.IndexOf("T")) + "' " +
                        " " +
                        "and phart05.MNC_CFR_STS = 'a' " +
                        "Group By phart06.MNC_PH_CD, pharmacy_m01.MNC_PH_TN ,PHARMACY_M05.MNC_PH_PRI01,PHARMACY_M05.MNC_PH_PRI02,PHARMACY_M05.MNC_PH_PRI03,phart05.mnc_req_dat " +
                        "Order By phart06.MNC_PH_CD";
                DataTable dtItem = connMain.selectData(sql);
                //txtItem.Clear();
                foreach (DataRow rowItem in dtItem.Rows)
                {
                    String svdate = "", billmuad = "", lccode = "", stdcode = "", desc = "", qty = "", up = "", chargeamt = "", claimup = "", claimamount = "";
                    String svrefid = "", claimcat = "";
                    billmuad = "1";
                    claimcat = "AA";
                    svrefid = "000000000" + i;
                    svrefid = svrefid.Substring(svrefid.Length - 9);
                    claimamount = rowItem["MNC_PH_PRI01"].ToString();
                    claimup = rowItem["MNC_PH_PRI01"].ToString();
                    chargeamt = rowItem["MNC_PH_PRI01"].ToString();
                    up = rowItem["MNC_PH_PRI01"].ToString();
                    qty = rowItem["MNC_PH_QTY"].ToString();
                    desc = rowItem["MNC_PH_TN"].ToString();
                    stdcode = rowItem["MNC_PH_CD"].ToString();
                    lccode = rowItem["MNC_PH_CD"].ToString();
                    svdate = rowItem["mnc_req_dat"].ToString();
                    txtItem.Append(invno).Append("|").Append(svdate).Append("|").Append(billmuad).Append("|").Append(lccode).Append("|").Append(stdcode)
                        .Append("|").Append(desc).Append("|").Append(qty).Append("|").Append(up).Append("|").Append(chargeamt).Append("|").Append(claimup)
                        .Append("|").Append(claimamount).Append("|").Append(svrefid).Append("|").Append(claimcat).Append(Environment.NewLine);


                }
            }

            using (StreamWriter writer =  new StreamWriter(@pathXML+"\\"+ fileBillTran + ".txt"))
            {
                writer.Write(@"<ClaimRec System=""OP"" PayPlan=""SS"" Version=""0.93"">");

                writer.WriteLine("<Header>");
                writer.WriteLine("<HCODE>"+ HCODE + "</HCODE>");
                writer.WriteLine("<HNAME>" + HNAME + "</HNAME>");
                writer.WriteLine("<DATETIME>" + date  + "T"+ time + "</DATETIME>");
                writer.WriteLine("<SESSNO>" + SESSNO + "</SESSNO>");
                writer.WriteLine("<RECCOUNT>" + cntOutPatient + "</RECCOUNT>");
                writer.WriteLine("</Header>");
                                
                writer.WriteLine("<BILLTRAN>");
                writer.WriteLine(txtBill.ToString());
                writer.WriteLine("</BILLTRAN>");

                writer.WriteLine("<BILLITEM>");
                writer.WriteLine(txtItem.ToString());
                writer.WriteLine("</BILLITEM>");

                writer.WriteLine("</ClainRec>");
                writer.WriteLine(@"<?EndNote Checksum="""">");
            }
        }
    }
}
