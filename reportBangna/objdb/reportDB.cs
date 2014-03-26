using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
namespace reportBangna.objdb
{
    public class reportDB
    {
        public ConnectDB conn;
        public ConnectDB connBua;
        private FinanceT01DB ft01db;
        private RmonthlyGroupIdDB rmgdb;
        public reportDB(ConnectDB c)
        {
            conn = c;
            connBua = new ConnectDB("bangna");
            ft01db = new FinanceT01DB(c);
            rmgdb = new RmonthlyGroupIdDB(connBua);
        }
        public DataTable xraySummary(DateTime dateStart, DateTime dateEnd)
        {
            DataTable dt = new DataTable();
            String sql = "", datestart="", dateend="";
            datestart = dateStart.Year.ToString() + "-" + dateStart.ToString("MM-dd");
            dateend = dateEnd.Year.ToString() + "-" + dateEnd.ToString("MM-dd");
            //sql = "SELECT        XRAY_T01.MNC_HN_YR, XRAY_T01.MNC_HN_NO, PATIENT_M02.MNC_PFIX_DSC, PATIENT_M01.MNC_FNAME_T, PATIENT_M01.MNC_LNAME_T, " +
            //             "XRAY_T01.MNC_REQ_YR, XRAY_T01.MNC_REQ_NO, XRAY_T01.MNC_REQ_DAT, PHARMACY_M01.MNC_PH_CD, XRAY_T05.MNC_XR_USE, "+
            //             "XRAY_T05.MNC_XR_BAD, PHARMACY_M01.MNC_PH_TN, XRAY_M01.MNC_XR_DSC, XRAY_T01.MNC_REQ_STS "+
            //            "   FROM            XRAY_T05 INNER JOIN "+
            //             "XRAY_T01 ON XRAY_T05.MNC_REQ_YR = XRAY_T01.MNC_REQ_YR AND XRAY_T05.MNC_REQ_NO = XRAY_T01.MNC_REQ_NO INNER JOIN "+
            //             "PHARMACY_M01 ON XRAY_T05.MNC_PH_CD = PHARMACY_M01.MNC_PH_CD INNER JOIN "+
            //             "PATIENT_M01 ON XRAY_T01.MNC_HN_YR = PATIENT_M01.MNC_HN_YR AND XRAY_T01.MNC_HN_NO = PATIENT_M01.MNC_HN_NO INNER JOIN "+
            //             "PATIENT_M02 ON PATIENT_M01.MNC_PFIX_CDT = PATIENT_M02.MNC_PFIX_CD INNER JOIN "+
            //             "XRAY_M01 ON XRAY_T05.MNC_XR_CD = XRAY_M01.MNC_XR_CD; ";
            sql = "SELECT XRAY_T01.MNC_HN_NO, PATIENT_M02.MNC_PFIX_DSC, PATIENT_M01.MNC_FNAME_T, PATIENT_M01.MNC_LNAME_T, " +
                    "PHARMACY_M01.MNC_PH_CD, PHARMACY_M01.MNC_PH_TN, "+
                    "Case XRAY_M01.MNC_XR_DSC "+
                    "When 'CHEST PA UPRIGHT (CHECK UP PROGRAM)' Then 'CHEST PA UPRIGHT(P.)' " +
                    "When 'CHEST PA UPRIGHT' Then 'CHEST PA(U.)' " +
                    "When 'CHEST PA (CHECK UP200)' Then '(CHECK UP200)' " +
                    "When 'CT BRAIN WITH CONTRACT.' Then 'CT Brain (contract)' " +
                    "When '' Then '' " +
                    "When '' Then '' " +
                    "Else XRAY_M01.MNC_XR_DSC End as MNC_XR_DSC " +
                    ", XRAY_T01.MNC_REQ_STS, " +
                    "Case FINANCE_M02.MNC_FN_TYP_DSC "+
                    "When 'ประกันสังคม (บ.1)' Then 'ปกส(บ.1)' " +
                    "When 'ประกันสังคม (บ.2)' Then 'ปกส(บ.2)' " +
                    "When 'ประกันสังคม (บ.5)' Then 'ปกส(บ.5)' "+
                    "When 'ประกันสังคมอิสระ (บ.1)' Then 'ปกต(บ.1)' " +
                    "When 'ประกันสังคมอิสระ (บ.5)' Then 'ปกต(บ.5)' " +
                    "When 'ตรวจสุขภาพ (เงินสด)' Then 'ตส(เงินสด)' "+
                    "When 'ตรวจสุขภาพ (บริษัท)' Then 'ตส(บริษัท)' " +
                    "When 'ตรวจสุขภาพ (PACKAGE)' Then 'ตส(PACKAGE)' " +
                    "When 'ลูกหนี้ประกันสังคม รพ.เมืองสมุทรปากน้ำ' Then 'ลูกหนี้(ปากน้ำ)' " +
                    
                    
                    "When 'ลูกหนี้บางนา 1' Then 'ลูกหนี้(บ.1)' " +
                    "When 'บริษัทประกัน' Then 'บ.ประกัน' " +
                    "When '' Then '' " +
                    "When '' Then '' " +
                    "When '' Then '' " +
                    "Else MNC_FN_TYP_DSC "+
                    "End as MNC_FN_TYP_DSC, " +
                     "XRAY_T05.MNC_XR_USE, XRAY_T05.MNC_XR_BAD, XRAY_T01.MNC_REQ_DAT, XRAY_T01.MNC_REQ_TIM " +
                    "FROM            XRAY_T05 INNER JOIN " +
                    "XRAY_T01 ON XRAY_T05.MNC_REQ_YR = XRAY_T01.MNC_REQ_YR AND XRAY_T05.MNC_REQ_NO = XRAY_T01.MNC_REQ_NO INNER JOIN " +
                    "PHARMACY_M01 ON XRAY_T05.MNC_PH_CD = PHARMACY_M01.MNC_PH_CD INNER JOIN " +
                    "PATIENT_M01 ON XRAY_T01.MNC_HN_YR = PATIENT_M01.MNC_HN_YR AND XRAY_T01.MNC_HN_NO = PATIENT_M01.MNC_HN_NO INNER JOIN " +
                    "PATIENT_M02 ON PATIENT_M01.MNC_PFIX_CDT = PATIENT_M02.MNC_PFIX_CD INNER JOIN " +
                    "XRAY_M01 ON XRAY_T05.MNC_XR_CD = XRAY_M01.MNC_XR_CD INNER JOIN " +
                    "FINANCE_M02 ON XRAY_T01.MNC_FN_TYP_CD = FINANCE_M02.MNC_FN_TYP_CD "+
                    "Where XRAY_T01.mnc_req_dat >= '" + datestart + "' and XRAY_T01.mnc_req_dat <= '" + dateend + "' "+
                    "Order By XRAY_T01.mnc_req_dat, XRAY_T01.MNC_REQ_TIM ";
            dt = conn.selectData(sql);
            return dt;
        }
        public DataTable xraySummaryMount(DateTime dateStart, DateTime dateEnd)
        {
            DataTable dt = new DataTable();
            String sql = "", datestart = "", dateend = "";
            datestart = dateStart.Year.ToString() + "-" + dateStart.ToString("MM-dd");
            dateend = dateEnd.Year.ToString() + "-" + dateEnd.ToString("MM-dd");
            //sql = "SELECT        XRAY_T01.MNC_HN_YR, XRAY_T01.MNC_HN_NO, PATIENT_M02.MNC_PFIX_DSC, PATIENT_M01.MNC_FNAME_T, PATIENT_M01.MNC_LNAME_T, " +
            //             "XRAY_T01.MNC_REQ_YR, XRAY_T01.MNC_REQ_NO, XRAY_T01.MNC_REQ_DAT, PHARMACY_M01.MNC_PH_CD, XRAY_T05.MNC_XR_USE, "+
            //             "XRAY_T05.MNC_XR_BAD, PHARMACY_M01.MNC_PH_TN, XRAY_M01.MNC_XR_DSC, XRAY_T01.MNC_REQ_STS "+
            //            "   FROM            XRAY_T05 INNER JOIN "+
            //             "XRAY_T01 ON XRAY_T05.MNC_REQ_YR = XRAY_T01.MNC_REQ_YR AND XRAY_T05.MNC_REQ_NO = XRAY_T01.MNC_REQ_NO INNER JOIN "+
            //             "PHARMACY_M01 ON XRAY_T05.MNC_PH_CD = PHARMACY_M01.MNC_PH_CD INNER JOIN "+
            //             "PATIENT_M01 ON XRAY_T01.MNC_HN_YR = PATIENT_M01.MNC_HN_YR AND XRAY_T01.MNC_HN_NO = PATIENT_M01.MNC_HN_NO INNER JOIN "+
            //             "PATIENT_M02 ON PATIENT_M01.MNC_PFIX_CDT = PATIENT_M02.MNC_PFIX_CD INNER JOIN "+
            //             "XRAY_M01 ON XRAY_T05.MNC_XR_CD = XRAY_M01.MNC_XR_CD; ";
            sql = "SELECT PHARMACY_M01.MNC_PH_CD, PHARMACY_M01.MNC_PH_TN, " +
                    "sum(XRAY_T05.MNC_XR_USE) as MNC_XR_USE, sum(XRAY_T05.MNC_XR_BAD) as MNC_XR_BAD, count(1) as cnt " +
                    "FROM XRAY_T05 " +
                    "INNER JOIN XRAY_T01 ON XRAY_T05.MNC_REQ_YR = XRAY_T01.MNC_REQ_YR AND XRAY_T05.MNC_REQ_NO = XRAY_T01.MNC_REQ_NO " +
                    "INNER JOIN PHARMACY_M01 ON XRAY_T05.MNC_PH_CD = PHARMACY_M01.MNC_PH_CD " +
                    //"INNER JOIN PATIENT_M01 ON XRAY_T01.MNC_HN_YR = PATIENT_M01.MNC_HN_YR AND XRAY_T01.MNC_HN_NO = PATIENT_M01.MNC_HN_NO " +
                    //"INNER JOIN PATIENT_M02 ON PATIENT_M01.MNC_PFIX_CDT = PATIENT_M02.MNC_PFIX_CD " +
                    //"INNER JOIN XRAY_M01 ON XRAY_T05.MNC_XR_CD = XRAY_M01.MNC_XR_CD " +
                    //"INNER JOIN FINANCE_M02 ON XRAY_T01.MNC_FN_TYP_CD = FINANCE_M02.MNC_FN_TYP_CD " +
                    "Where XRAY_T01.mnc_req_dat >= '" + datestart + "' and XRAY_T01.mnc_req_dat <= '" + dateend + "' " +
                    "Group By PHARMACY_M01.MNC_PH_CD, PHARMACY_M01.MNC_PH_TN " +
                    "Order By PHARMACY_M01.MNC_PH_CD ";
            dt = conn.selectData(sql);
            return dt;
        }
        public DataTable dailypatientsumpaid(DateTime dateStart, DateTime dateEnd)
        {
            ConnectDB connBua = new ConnectDB("bangna");
            DataTable dt = new DataTable();
            String sql = "", datestart = "", dateend = "";
            datestart = dateStart.Year.ToString() + "-" + dateStart.ToString("MM-dd");
            dateend = dateEnd.Year.ToString() + "-" + dateEnd.ToString("MM-dd");

         //   sql = "select  count(ft01.MNC_FN_TYP_CD) as MNC_FN_TYP_CD,finance_m02.MNC_FN_TYP_DSC " +

         //       "from finance_t01 as ft01 "+
         //  "INNER JOIN FINANCE_m02  ON  ft01.MNC_FN_TYP_CD =  FINANCE_M02.MNC_FN_TYP_CD " +
        //   " where  ft01.mnc_doc_sts not like 'v' " +
         
           // "and ft01.mnc_doc_dat >= '" + datestart + "' and ft01.mnc_doc_dat <= '" + dateend + "' " +

           
        //   " group by finance_m02.MNC_FN_TYP_DSC";


      // sql =" select Finance_T01.mnc_fn_typ_cd,Finance_m02.MNC_FN_TYP_DSC,count(*) as NO "+
      //  ",Finance_m02.MNC_FN_STS "+
		
      //  ",sum(mnc_PAY_CASH) as SUMAMT "+
      //  ",sum(MNC_PAY_CARD) as paycard "+
      //  ",sum(mnc_dis_tot) as DISAMT "+

      // " from finance_t01 "+
      // " inner join FINANCE_M02 on finance_m02.MNC_FN_TYP_CD = finance_t01.MNC_FN_TYP_CD "+
      // " inner join FINANCE_T04 on finance_t01.MNC_JOB_NO = finance_t04.MNC_JOB_RUNNO "+
      // " where Finance_T01.mnc_fn_typ_cd = Finance_m02.mnc_fn_typ_cd "+
	  
      //  " and finance_t01.mnc_job_yr = '2556' "+

      // " and mnc_doc_sts = 'F'" +
      // " and finance_t04.MNC_DAT_END >= '" + datestart + "' " +
      //     " and finance_t04.mnc_dat_end <='"+dateend+"' "+
    
      //"  group by Finance_T01.mnc_fn_typ_cd,Finance_m02.MNC_FN_TYP_DSC, "+
      // " Finance_m02.MNC_FN_STS ";
            ft01db.insertFT01ByDateEndFormCloseDay(datestart,dateend, new ProgressBar());
            sql = " select group_id as MNC_FN_TYP_DSC ,count(*) as NO " +
            ",sum(mnc_PAY_CASH) as SUMAMT " +
            ",sum(MNC_PAY_CARD) as paycard " +
            ",sum(mnc_dis_tot) as DISAMT " +

            " from r_finance_t01 " +        
            " where r_finance_t01.mnc_job_yr = '2556' " +

            " and mnc_doc_sts = 'F'" +
            " and r_finance_t01.MNC_DAT_END >= '" + dateend + "' " +
            " and r_finance_t01.mnc_dat_end <='" + dateend + "' " +
            " and r_finance_t01.ft01_active = '1' "+

            "  group by group_id ";

           dt = connBua.selectData(sql);
            return dt;
        }
        public DataTable dailypatientsumpaidDay(DateTime dateStart, DateTime dateEnd, ProgressBar pb)
        {
            ConnectDB connBua = new ConnectDB("bangna");
            DataTable dt = new DataTable();
            String sql = "", datestart = "", dateend = "";
            datestart = dateStart.Year.ToString() + "-" + dateStart.ToString("MM-dd");
            dateend = dateEnd.Year.ToString() + "-" + dateEnd.ToString("MM-dd");
            rmgdb.setRMonthlyGroupId(datestart, dateend,pb);
            dt = rmgdb.selectAll();
            
            return dt;
        }
        public DataTable dailyCheckup(DateTime dateStart, DateTime dateEnd, ProgressBar pb)
        {
            ConnectDB connBua = new ConnectDB("bangna");
            DataTable dt = new DataTable();
            String sql = "", datestart = "", dateend = "";
            datestart = dateStart.Year.ToString() + "-" + dateStart.ToString("MM-dd");
            dateend = dateEnd.Year.ToString() + "-" + dateEnd.ToString("MM-dd");
            rmgdb.setDailyCheckup(datestart, dateend, pb);
            dt = rmgdb.selectAll();

            return dt;
        }
        public DataTable dailySummaryDoctor(DateTime dateStart, DateTime dateEnd)
        {
            //ConnectDB connBua = new ConnectDB("bangna");
            DataTable dt = new DataTable();
            String sql = "", datestart = "", dateend = "";
            datestart = dateStart.Year.ToString() + "-" + dateStart.ToString("MM-dd");
            dateend = dateEnd.Year.ToString() + "-" + dateEnd.ToString("MM-dd");
            //rmgdb.setRMonthlyGroupId(datestart, dateend, pb);
            //dt = rmgdb.selectAll();
            sql = "select   patient_t01.MNC_DOT_CD as Doctor_id,patient_m02.MNC_PFIX_DSC as prefix, "+

            "patient_m26.MNC_DOT_FNAME as Fname,patient_m26.MNC_DOT_LNAME as Lname,count( patient_t01.mnc_dot_cd) as Amount "+

            "from patient_t01 " +
           " inner join patient_m26 on patient_t01.mnc_dot_cd = patient_m26.MNC_DOT_CD "+
           " inner join patient_m02 on patient_m26.MNC_DOT_PFIX =patient_m02.MNC_PFIX_CD "+

           " where patient_t01.mnc_date >= '" + datestart + "' " +
           " and patient_t01.mnc_date <= '"+ dateend+"' "+

         //  " and r_finance_t01.MNC_DAT_END >= '" + dateend + "' " +
          //  " and r_finance_t01.mnc_dat_end <='" + dateend + "' " +

            "and patient_t01.MNC_STS <> 'C' "+
            "and patient_t01.mnc_dot_cd != '00009' "+
            "and patient_t01.mnc_dot_cd != '00147' "+

           " group by patient_t01.mnc_dot_cd,patient_m26.MNC_DOT_FNAME "+
           " ,patient_m26.MNC_DOT_LNAME,MNC_DOT_PFIX,patient_m02.MNC_PFIX_DSC " +
           " order by patient_t01.mnc_dot_cd ";
            dt = conn.selectData(sql);
            return dt;
        }
    }
}
