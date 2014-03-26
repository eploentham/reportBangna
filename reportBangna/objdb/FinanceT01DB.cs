using reportBangna.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace reportBangna.objdb
{
    class FinanceT01DB
    {
        public ConnectDB conn;
        public FinanceT01 ft01;
        private Config1 config1;
        public FinanceT01DB(ConnectDB c)
        {
            conn = c;
            ft01 = new FinanceT01();
            config1 = new Config1();
            ft01.MNC_AD_DAT="MNC_AD_DAT";
            ft01.MNC_ADMIT_DAY="MNC_ADMIT_DAY";
            ft01.MNC_AN_NO="MNC_AN_NO";
            ft01.MNC_AN_YR="MNC_AN_YR";
            ft01.MNC_AR_DOC_CD="MNC_AR_DOC_CD";
            ft01.MNC_AR_DOC_DAT="MNC_AR_DOC_DAT";
            ft01.MNC_AR_DOC_NO="MNC_AR_DOC_NO";
            ft01.MNC_AR_DOC_YR="MNC_AR_DOC_YR";
            ft01.MNC_CARD_ID="MNC_CARD_ID";
            ft01.MNC_CARD_NO="MNC_CARD_NO";
            ft01.MNC_CHARGE_PRI="MNC_CHARGE_PRI";
            ft01.MNC_CLO_FLG="MNC_CLO_FLG";
            ft01.MNC_COM_CD="MNC_COM_CD";
            ft01.MNC_COM_SUB_CD="MNC_COM_SUB_CD";
            ft01.MNC_CONFIRM_FLG="MNC_CONFIRM_FLG";
            ft01.MNC_DAT_END="MNC_DAT_END";
            ft01.MNC_DATE="MNC_DATE";
            ft01.MNC_DEP_NO="MNC_DEP_NO";
            ft01.MNC_DIA_DSC="MNC_DIA_DSC";
            ft01.MNC_DIS_PER="MNC_DIS_PER";
            ft01.MNC_DIS_TOT="MNC_DIS_TOT";
            ft01.MNC_DOC_CD="MNC_DOC_CD";
            ft01.MNC_DOC_DAT="MNC_DOC_DAT";
            ft01.MNC_DOC_NO="MNC_DOC_NO";
            ft01.MNC_DOC_STS="MNC_DOC_STS";
            ft01.MNC_DOC_TIM="MNC_DOC_TIM";
            ft01.MNC_DOC_YR="MNC_DOC_YR";
            ft01.MNC_DOT_CD_CREDIT="MNC_DOT_CD_CREDIT";
            ft01.MNC_FLG_STS="MNC_FLG_STS";
            ft01.MNC_FN_TYP_CD="MNC_FN_TYP_CD";
            ft01.MNC_HN_NO="MNC_HN_NO";
            ft01.MNC_HN_YR="MNC_HN_YR";
            ft01.MNC_HR_NO="MNC_HR_NO";
            ft01.MNC_IMPT_STS="MNC_IMPT_STS";
            ft01.MNC_IP_ADD1="MNC_IP_ADD1";
            ft01.MNC_IP_ADD2="MNC_IP_ADD2";
            ft01.MNC_IP_ADD3="MNC_IP_ADD3";
            ft01.MNC_IP_ADD4="MNC_IP_ADD4";
            ft01.MNC_JOB_CD="MNC_JOB_CD";
            ft01.MNC_JOB_NO="MNC_JOB_NO";
            ft01.MNC_JOB_YR="MNC_JOB_YR";
            ft01.MNC_PAY_CARD="MNC_PAY_CARD";
            ft01.MNC_PAY_CASH="MNC_PAY_CASH";
            ft01.MNC_PRAKUN_CODE="MNC_PRAKUN_CODE";
            ft01.MNC_PRE_NO="MNC_PRE_NO";
            ft01.MNC_RES_MAS="MNC_RES_MAS";
            ft01.MNC_SEC_NO="MNC_SEC_NO";
            ft01.MNC_SPLIT_DOC="MNC_SPLIT_DOC";
            ft01.MNC_SPLIT_FLG="MNC_SPLIT_FLG";
            ft01.MNC_STAMP_DAT="MNC_STAMP_DAT";
            ft01.MNC_STAMP_TIM="MNC_STAMP_TIM";
            ft01.MNC_SUM_COS="MNC_SUM_COS";
            ft01.MNC_SUM_DIS="MNC_SUM_DIS";
            ft01.MNC_SUM_PRI="MNC_SUM_PRI";
            ft01.MNC_USR_CD="MNC_USR_CD";
            ft01.MNC_USR_DIS="MNC_USR_DIS";
            ft01.MNC_USR_INT="MNC_USR_INT";
            ft01.MNC_USR_UPD="MNC_USR_UPD";
            ft01.pkField="ft01_id";
            ft01.Ft01Id = "ft01_id";
            ft01.MNC_DAT_END = "mnc_dat_end";
            ft01.groupId = "group_id";
            ft01.ft01Active = "ft01_active";
            ft01.patientFullname = "patient_fullname";
            ft01.companyName = "company_name";

            ft01.table="r_finance_t01";
            
        }
        public DataTable selectByMncDateEnd(String dateStart,String dateEnd)
        {
            DataTable dt = new DataTable();
            String sql = "";
            sql = "Select * From Finance_t04 "+
                "Where mnc_dat_end >= '"+dateStart +"' and mnc_dat_end <='" + dateEnd + 
                "' and MNC_close_STS = 'Y' Order By mnc_dat_end, mnc_job_cd, mnc_job_no";
            dt = conn.selectData(sql);
            return dt;
        }
        public DataTable selectByMncJobNo(String jobYear,String jobNo, String jobCd)
        {
            DataTable dt = new DataTable();
            String sql = "";
            sql = "Select ft01.* "+
                "From Finance_t01 ft01 "+                
                "Where ft01.mnc_job_no ='" + jobNo + "' and ft01.mnc_job_yr = '" + jobYear +
                "' and ft01.MNC_DOC_STS <> 'V' and ft01.mnc_job_cd ='" + jobCd + "' " +
                "Order By ft01.mnc_stamp_dat, ft01.mnc_stamp_tim";
            dt = conn.selectData(sql);
            return dt;
        }
        public DataTable selectByMncJobNoWithName(String jobYear, String jobNo, String jobCd)
        {
            DataTable dt = new DataTable();
            String sql = "";
            sql = "Select ft01.*,pm01.mnc_fname_t, pm01.mnc_lname_t, pm02.mnc_pfix_dsc, pm24.mnc_com_dsc " +
                "From Finance_t01 ft01 " +
                "Inner join patient_m01 pm01 On ft01.mnc_hn_no = pm01.mnc_hn_no and ft01.mnc_hn_yr = pm01.mnc_hn_yr " +
                "Inner join patient_m02 pm02 On pm01.mnc_pfix_cdt = pm02.mnc_pfix_cd " +
                "Inner join patient_m24 pm24 On pm01.mnc_com_cd = pm24.mnc_com_cd "+
                "Where ft01.mnc_job_no ='" + jobNo + "' and ft01.mnc_job_yr = '" + jobYear +
                "' and ft01.MNC_DOC_STS <> 'V' and ft01.mnc_job_cd ='" + jobCd + "' " +
                "Order By ft01.mnc_stamp_dat, ft01.mnc_stamp_tim";
            dt = conn.selectData(sql);
            return dt;
        }
        public DataTable selectByMncJobNoFix1518(String jobYear, String jobNo, String jobCd)
        {
            DataTable dt = new DataTable();
            String sql = "";
            sql = "Select * From Finance_t01 " +
                "Where mnc_job_no ='" + jobNo + "' and mnc_job_yr = '" + jobYear +
                "' and FINANCE_T01.MNC_DOC_STS <> 'V' and mnc_job_cd ='" + jobCd + "' and mnc_fn_typ_cd in ('15','18')" +
                "Order By mnc_stamp_dat, mnc_stamp_tim";
            dt = conn.selectData(sql);
            return dt;
        }
        public DataTable selectAll()
        {
            DataTable dt = new DataTable();
            String sql = "";
            sql = "Select * From "+ft01.table+
                "Where "+ft01.ft01Active+"='1'  Order By "+ft01.MNC_DAT_END+","+ft01.MNC_JOB_CD+","+ft01.MNC_JOB_NO;
            dt = conn.selectData(sql);
            return dt;
        }
        public DataTable selectByMncDateEnd(String dateEnd)
        {
            DataTable dt = new DataTable();
            String sql = "";
            sql = "Select * From " + ft01.table +
                "Where " + ft01.ft01Active + "='1' "+
                "Order By " + ft01.MNC_DAT_END + "," + ft01.MNC_JOB_CD + "," + ft01.MNC_JOB_NO;
            dt = conn.selectData(sql);
            return dt;
        }
        private String deleteAll(ConnectDB c)
        {
            String sql = "", chk="";
            //sql = "Delete From " + ft01.table;
            sql = "Update " + ft01.table +" Set "+ft01.ft01Active+"='3'";
            chk = c.ExecuteNonQueryNoClose(sql);
            return chk;
        }
        private String insert(FinanceT01 p, ConnectDB c)
        {
            String sql = "", chk = "";
            p.patientFullname = p.patientFullname.Replace("'", "''");
            p.companyName = p.companyName.Replace("'", "''");
            sql = "Insert Into "+ft01.table+"("+ ft01.pkField+","+ft01.MNC_AD_DAT+","+ft01.MNC_ADMIT_DAY+","+
                ft01.MNC_AN_NO+","+ft01.MNC_AN_YR+","+
                ft01.MNC_AR_DOC_CD+","+ft01.MNC_AR_DOC_DAT+","+
                ft01.MNC_AR_DOC_NO+","+ft01.MNC_AR_DOC_YR+","+
                ft01.MNC_CARD_ID+","+ft01.MNC_CARD_NO+","+
                ft01.MNC_CHARGE_PRI+","+ft01.MNC_CLO_FLG+","+
                ft01.MNC_COM_CD+","+ft01.MNC_COM_SUB_CD+","+
                ft01.MNC_CONFIRM_FLG+","+ft01.MNC_DAT_END+","+
                ft01.MNC_DATE+","+ft01.MNC_DEP_NO+","+
                ft01.MNC_DIA_DSC+","+ft01.MNC_DIS_PER+","+
                ft01.MNC_DIS_TOT+","+ft01.MNC_DOC_CD+","+
                ft01.MNC_DOC_DAT+","+ft01.MNC_DOC_NO+","+
                ft01.MNC_DOC_STS+","+ft01.MNC_DOC_TIM+","+
                ft01.MNC_DOC_YR+","+ft01.MNC_DOT_CD_CREDIT+","+
                ft01.MNC_FLG_STS+","+ft01.MNC_FN_TYP_CD+","+
                ft01.MNC_HN_NO+","+ft01.MNC_HN_YR+","+
                ft01.MNC_HR_NO+","+ft01.MNC_IMPT_STS+","+
                ft01.MNC_IP_ADD1+","+ft01.MNC_IP_ADD2+","+
                ft01.MNC_IP_ADD3+","+ft01.MNC_IP_ADD4+","+
                ft01.MNC_JOB_CD+","+ft01.MNC_JOB_NO+","+
                ft01.MNC_JOB_YR+","+ft01.MNC_PAY_CARD+","+
                ft01.MNC_PAY_CASH+","+ft01.MNC_PRAKUN_CODE+","+
                ft01.MNC_PRE_NO+","+ft01.MNC_RES_MAS+","+
                ft01.MNC_SEC_NO+","+ft01.MNC_SPLIT_DOC+","+
                ft01.MNC_SPLIT_FLG+","+ft01.MNC_STAMP_DAT+","+
                ft01.MNC_STAMP_TIM+","+ft01.MNC_SUM_COS+","+
                ft01.MNC_SUM_DIS+","+ft01.MNC_SUM_PRI+","+
                ft01.MNC_USR_CD+","+ft01.MNC_USR_DIS+","+
                ft01.MNC_USR_INT+","+ft01.MNC_USR_UPD+","+
                ft01.groupId + "," + ft01.ft01Active +","+
                ft01.companyName+","+ft01.patientFullname+ ") " +
                "values('" + p.Ft01Id+"','" + p.MNC_AD_DAT + "','" + p.MNC_ADMIT_DAY + "','" +
                p.MNC_AN_NO + "','" + p.MNC_AN_YR + "','" +
                p.MNC_AR_DOC_CD + "','" + p.MNC_AR_DOC_DAT + "','" +
                p.MNC_AR_DOC_NO + "','" + p.MNC_AR_DOC_YR + "','" +
                p.MNC_CARD_ID + "','" + p.MNC_CARD_NO + "','" +
                p.MNC_CHARGE_PRI + "','" + p.MNC_CLO_FLG + "','" +
                p.MNC_COM_CD + "','" + p.MNC_COM_SUB_CD + "','" +
                p.MNC_CONFIRM_FLG + "','" + p.MNC_DAT_END + "','" +
                p.MNC_DATE + "','" + p.MNC_DEP_NO + "','" +
                p.MNC_DIA_DSC + "','" + p.MNC_DIS_PER + "','" +
                p.MNC_DIS_TOT + "','" + p.MNC_DOC_CD + "','" +
                p.MNC_DOC_DAT + "','" + p.MNC_DOC_NO + "','" +
                p.MNC_DOC_STS + "','" + p.MNC_DOC_TIM + "','" +
                p.MNC_DOC_YR + "','" + p.MNC_DOT_CD_CREDIT + "','" +
                p.MNC_FLG_STS + "','" + p.MNC_FN_TYP_CD + "','" +
                p.MNC_HN_NO + "','" + p.MNC_HN_YR + "','" +
                p.MNC_HR_NO + "','" + p.MNC_IMPT_STS + "','" +
                p.MNC_IP_ADD1 + "','" + p.MNC_IP_ADD2 + "','" +
                p.MNC_IP_ADD3 + "','" + p.MNC_IP_ADD4 + "','" +
                p.MNC_JOB_CD + "','" + p.MNC_JOB_NO + "','" +
                p.MNC_JOB_YR + "'," + p.MNC_PAY_CARD + "," +
                p.MNC_PAY_CASH + ",'" + p.MNC_PRAKUN_CODE + "','" +
                p.MNC_PRE_NO + "','" + p.MNC_RES_MAS + "','" +
                p.MNC_SEC_NO + "','" + p.MNC_SPLIT_DOC + "','" +
                p.MNC_SPLIT_FLG + "','" + p.MNC_STAMP_DAT + "','" +
                p.MNC_STAMP_TIM + "'," + p.MNC_SUM_COS + "," +
                p.MNC_SUM_DIS + "," + p.MNC_SUM_PRI + ",'" +
                p.MNC_USR_CD + "','" + p.MNC_USR_DIS + "','" +
                p.MNC_USR_INT + "','" + p.MNC_USR_UPD+"','"+
                p.groupId +"','"+p.ft01Active +"','"+
                p.companyName+"','"+p.patientFullname+ "')";

            chk = c.ExecuteNonQueryNoClose(sql);
            return chk;
        }
        public String insertFT01ByDateEndFormCloseDay(String dateStart,String dateEnd, ProgressBar pb)
        {
            pb.Show();
            DataTable dt = new DataTable();
            DataTable dtFt04 = new DataTable();
            FinanceT01 rft01 = new FinanceT01();
            ConnectDB connBua = new ConnectDB("bangna");
            String sql = "", chk = "", jobCd = "", jobNo = "", jobYr = "", strError = "", dateEnddb="";
            DateTime mncDated = new DateTime();
            DateTime mncDocDated = new DateTime();
            DateTime mncStampDated = new DateTime();
            dtFt04 = selectByMncDateEnd(dateStart,dateEnd);
            connBua.OpenConnection();
            if (dtFt04.Rows.Count > 0)
            {
                pb.Minimum = 0;
                pb.Maximum = dtFt04.Rows.Count;
                deleteAll(connBua);
                for (int j = 0; j < dtFt04.Rows.Count; j++)
                {
                    pb.Value = j;
                    jobCd = dtFt04.Rows[j]["mnc_job_cd"].ToString();
                    jobNo = dtFt04.Rows[j]["mnc_job_runno"].ToString();
                    jobYr = dtFt04.Rows[j]["mnc_job_yr"].ToString();
                    dateEnddb = config1.datetoDB(dtFt04.Rows[j]["mnc_dat_end"].ToString());
                    //if (flag == "withpatientname")
                    //{
                    //    dt = selectByMncJobNoWithName(jobYr, jobNo, jobCd);
                    //}
                    //else
                    //{
                    dt = selectByMncJobNoWithName(jobYr, jobNo, jobCd);
                    //}
                    
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        rft01.patientFullname = dt.Rows[i]["mnc_pfix_dsc"].ToString() + " " + dt.Rows[i]["mnc_fname_t"].ToString() + " " + dt.Rows[i]["mnc_lname_t"].ToString();
                        rft01.companyName = dt.Rows[i]["mnc_com_dsc"].ToString();
                        rft01.MNC_AD_DAT = config1.datetoDB(dt.Rows[i][ft01.MNC_AD_DAT].ToString());                        
                        rft01.MNC_ADMIT_DAY = dt.Rows[i][ft01.MNC_ADMIT_DAY].ToString();
                        rft01.MNC_AN_NO = dt.Rows[i][ft01.MNC_AN_NO].ToString();
                        rft01.MNC_AN_YR = dt.Rows[i][ft01.MNC_AN_YR].ToString();
                        rft01.MNC_AR_DOC_CD = dt.Rows[i][ft01.MNC_AR_DOC_CD].ToString();
                        rft01.MNC_AR_DOC_DAT = dt.Rows[i][ft01.MNC_AR_DOC_DAT].ToString();
                        rft01.MNC_AR_DOC_NO = dt.Rows[i][ft01.MNC_AR_DOC_NO].ToString();
                        rft01.MNC_AR_DOC_YR = dt.Rows[i][ft01.MNC_AR_DOC_YR].ToString();
                        rft01.MNC_CARD_ID = dt.Rows[i][ft01.MNC_CARD_ID].ToString();
                        rft01.MNC_CARD_NO = dt.Rows[i][ft01.MNC_CARD_NO].ToString();
                        rft01.MNC_CHARGE_PRI = dt.Rows[i][ft01.MNC_CHARGE_PRI].ToString();
                        rft01.MNC_CLO_FLG = dt.Rows[i][ft01.MNC_CLO_FLG].ToString();
                        rft01.MNC_COM_CD = dt.Rows[i][ft01.MNC_COM_CD].ToString();
                        rft01.MNC_COM_SUB_CD = dt.Rows[i][ft01.MNC_COM_SUB_CD].ToString();
                        rft01.MNC_CONFIRM_FLG = dt.Rows[i][ft01.MNC_CONFIRM_FLG].ToString();
                        rft01.MNC_DAT_END = dateEnddb;
                        //mncDated = DateTime.Parse(dt.Rows[i][ft01.MNC_DATE].ToString());
                        //mncDate = mncDated.Year.ToString() + "-" + mncDated.Month.ToString("00") + "-" + mncDated.Day.ToString("00");
                        rft01.MNC_DATE = config1.datetoDB(dt.Rows[i][ft01.MNC_DATE]);
                        rft01.MNC_DEP_NO = dt.Rows[i][ft01.MNC_DEP_NO].ToString();
                        rft01.MNC_DIA_DSC = dt.Rows[i][ft01.MNC_DIA_DSC].ToString();
                        rft01.MNC_DIS_PER = dt.Rows[i][ft01.MNC_DIS_PER].ToString();
                        rft01.MNC_DIS_TOT = dt.Rows[i][ft01.MNC_DIS_TOT].ToString();
                        rft01.MNC_DOC_CD = dt.Rows[i][ft01.MNC_DOC_CD].ToString();
                        rft01.MNC_DOC_DAT = config1.datetoDB(dt.Rows[i][ft01.MNC_DOC_DAT]);
                        rft01.MNC_DOC_NO = dt.Rows[i][ft01.MNC_DOC_NO].ToString();
                        rft01.MNC_DOC_STS = dt.Rows[i][ft01.MNC_DOC_STS].ToString();
                        rft01.MNC_DOC_TIM = dt.Rows[i][ft01.MNC_DOC_TIM].ToString();
                        rft01.MNC_DOC_YR = dt.Rows[i][ft01.MNC_DOC_YR].ToString();
                        rft01.MNC_DOT_CD_CREDIT = dt.Rows[i][ft01.MNC_DOT_CD_CREDIT].ToString();
                        rft01.MNC_FLG_STS = dt.Rows[i][ft01.MNC_FLG_STS].ToString();
                        rft01.MNC_FN_TYP_CD = dt.Rows[i][ft01.MNC_FN_TYP_CD].ToString();
                        rft01.MNC_HN_NO = dt.Rows[i][ft01.MNC_HN_NO].ToString();
                        rft01.MNC_HN_YR = dt.Rows[i][ft01.MNC_HN_YR].ToString();
                        rft01.MNC_HR_NO = dt.Rows[i][ft01.MNC_HR_NO].ToString();
                        rft01.MNC_IMPT_STS = dt.Rows[i][ft01.MNC_IMPT_STS].ToString();
                        rft01.MNC_IP_ADD1 = dt.Rows[i][ft01.MNC_IP_ADD1].ToString();
                        rft01.MNC_IP_ADD2 = dt.Rows[i][ft01.MNC_IP_ADD2].ToString();
                        rft01.MNC_IP_ADD3 = dt.Rows[i][ft01.MNC_IP_ADD3].ToString();
                        rft01.MNC_IP_ADD4 = dt.Rows[i][ft01.MNC_IP_ADD4].ToString();
                        rft01.MNC_JOB_CD = dt.Rows[i][ft01.MNC_JOB_CD].ToString();
                        rft01.MNC_JOB_NO = dt.Rows[i][ft01.MNC_JOB_NO].ToString();
                        rft01.MNC_JOB_YR = dt.Rows[i][ft01.MNC_JOB_YR].ToString();
                        rft01.MNC_PAY_CARD = dt.Rows[i][ft01.MNC_PAY_CARD].ToString();
                        rft01.MNC_PAY_CASH = dt.Rows[i][ft01.MNC_PAY_CASH].ToString();
                        rft01.MNC_PRAKUN_CODE = dt.Rows[i][ft01.MNC_PRAKUN_CODE].ToString();
                        rft01.MNC_PRE_NO = dt.Rows[i][ft01.MNC_PRE_NO].ToString();
                        rft01.MNC_RES_MAS = dt.Rows[i][ft01.MNC_RES_MAS].ToString();
                        rft01.MNC_SEC_NO = dt.Rows[i][ft01.MNC_SEC_NO].ToString();
                        rft01.MNC_SPLIT_DOC = dt.Rows[i][ft01.MNC_SPLIT_DOC].ToString();
                        rft01.MNC_SPLIT_FLG = dt.Rows[i][ft01.MNC_SPLIT_FLG].ToString();
                        rft01.MNC_STAMP_DAT = config1.datetoDB(dt.Rows[i][ft01.MNC_STAMP_DAT]);
                        rft01.MNC_STAMP_TIM = dt.Rows[i][ft01.MNC_STAMP_TIM].ToString();
                        rft01.MNC_SUM_COS = dt.Rows[i][ft01.MNC_SUM_COS].ToString();
                        rft01.MNC_SUM_DIS = dt.Rows[i][ft01.MNC_SUM_DIS].ToString();
                        rft01.MNC_SUM_PRI = dt.Rows[i][ft01.MNC_SUM_PRI].ToString();
                        rft01.MNC_USR_CD = dt.Rows[i][ft01.MNC_USR_CD].ToString();
                        rft01.MNC_USR_DIS = dt.Rows[i][ft01.MNC_USR_DIS].ToString();
                        rft01.MNC_USR_INT = dt.Rows[i][ft01.MNC_USR_INT].ToString();
                        rft01.MNC_USR_UPD = dt.Rows[i][ft01.MNC_USR_UPD].ToString();
                        if (rft01.MNC_FN_TYP_CD.Equals("13"))
                        {
                            sql = "";
                        }
                        rft01.ft01Active = "1";
                        try
                        {
                            rft01.Ft01Id = rft01.getGenID();
                            rft01.groupId = setGroupId(dt.Rows[i][ft01.MNC_FN_TYP_CD].ToString().Trim());
                            //rft01.groupId = dt.Rows[i][ft01.MNC_FN_TYP_CD].ToString();
                            insert(rft01, connBua);
                        }
                        catch (Exception ex)
                        {
                            strError += " "+ex.Message;
                        }
                    }
                }
                
            }
            connBua.CloseConnection();
            return chk;
        }
        private string setGroupId(String paidId)
        {
            String groupId = "";
            //if ((paidId == "44") || (paidId == "45") || (paidId == "46") || 
            //    (paidId == "47") || (paidId == "48") || (paidId == "49") || (paidId == "13")
            //    ||(paidId == "94") || (paidId == "95") ) //ประกันสังคม
            //{
            //    groupId = "ประกันสังคม";
            //}
            if ((paidId == "44") || (paidId == "45") || (paidId == "46") ||
            (paidId == "47") || (paidId == "48") || (paidId == "49") 
            || (paidId == "94") || (paidId == "95")) //ประกันสังคม
            {
                groupId = "ประกันสังคม";
            }
            
            else if ((paidId == "02") || (paidId == "10") || (paidId == "12") || (paidId == "18"))
            {
                groupId = "เงินสด";
            }
            else if ((paidId == "05") )
            {
                groupId = "บริษัทประกัน";
            }
            
            else if ((paidId == "11") || (paidId == "15"))
            {
                groupId = "สัญญาบริษัท";
            }
        
            else if (paidId == "06")
            {
                groupId = "พ.ร.บ";
            }
            else if (paidId == "13")
            {
                groupId = "กองทุน";
            }
            else
            {
                groupId = "อื่นๆ";
            }
            return groupId;
        }
        public String insertFT01ByDateEndFormCloseDayFix1518(String dateStart, String dateEnd, ProgressBar pb)
        {
            pb.Show();
            DataTable dt = new DataTable();
            DataTable dtFt04 = new DataTable();
            FinanceT01 rft01 = new FinanceT01();
            ConnectDB connBua = new ConnectDB("bangna");
            String sql = "", chk = "", jobCd = "", jobNo = "", jobYr = "", strError = "", dateEnddb = "";
            DateTime mncDated = new DateTime();
            DateTime mncDocDated = new DateTime();
            DateTime mncStampDated = new DateTime();
            dtFt04 = selectByMncDateEnd(dateStart, dateEnd);
            connBua.OpenConnection();
            if (dtFt04.Rows.Count > 0)
            {
                pb.Minimum = 0;
                pb.Maximum = dtFt04.Rows.Count;
                deleteAll(connBua);
                for (int j = 0; j < dtFt04.Rows.Count; j++)
                {
                    pb.Value = j;
                    jobCd = dtFt04.Rows[j]["mnc_job_cd"].ToString();
                    jobNo = dtFt04.Rows[j]["mnc_job_runno"].ToString();
                    jobYr = dtFt04.Rows[j]["mnc_job_yr"].ToString();
                    dateEnddb = config1.datetoDB(dtFt04.Rows[j]["mnc_dat_end"].ToString());
                    dt = selectByMncJobNoFix1518(jobYr, jobNo, jobCd);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        rft01.MNC_AD_DAT = config1.datetoDB(dt.Rows[i][ft01.MNC_AD_DAT].ToString());
                        rft01.MNC_ADMIT_DAY = dt.Rows[i][ft01.MNC_ADMIT_DAY].ToString();
                        rft01.MNC_AN_NO = dt.Rows[i][ft01.MNC_AN_NO].ToString();
                        rft01.MNC_AN_YR = dt.Rows[i][ft01.MNC_AN_YR].ToString();
                        rft01.MNC_AR_DOC_CD = dt.Rows[i][ft01.MNC_AR_DOC_CD].ToString();
                        rft01.MNC_AR_DOC_DAT = dt.Rows[i][ft01.MNC_AR_DOC_DAT].ToString();
                        rft01.MNC_AR_DOC_NO = dt.Rows[i][ft01.MNC_AR_DOC_NO].ToString();
                        rft01.MNC_AR_DOC_YR = dt.Rows[i][ft01.MNC_AR_DOC_YR].ToString();
                        rft01.MNC_CARD_ID = dt.Rows[i][ft01.MNC_CARD_ID].ToString();
                        rft01.MNC_CARD_NO = dt.Rows[i][ft01.MNC_CARD_NO].ToString();
                        rft01.MNC_CHARGE_PRI = dt.Rows[i][ft01.MNC_CHARGE_PRI].ToString();
                        rft01.MNC_CLO_FLG = dt.Rows[i][ft01.MNC_CLO_FLG].ToString();
                        rft01.MNC_COM_CD = dt.Rows[i][ft01.MNC_COM_CD].ToString();
                        rft01.MNC_COM_SUB_CD = dt.Rows[i][ft01.MNC_COM_SUB_CD].ToString();
                        rft01.MNC_CONFIRM_FLG = dt.Rows[i][ft01.MNC_CONFIRM_FLG].ToString();
                        rft01.MNC_DAT_END = dateEnddb;
                        //mncDated = DateTime.Parse(dt.Rows[i][ft01.MNC_DATE].ToString());
                        //mncDate = mncDated.Year.ToString() + "-" + mncDated.Month.ToString("00") + "-" + mncDated.Day.ToString("00");
                        rft01.MNC_DATE = config1.datetoDB(dt.Rows[i][ft01.MNC_DATE]);
                        rft01.MNC_DEP_NO = dt.Rows[i][ft01.MNC_DEP_NO].ToString();
                        rft01.MNC_DIA_DSC = dt.Rows[i][ft01.MNC_DIA_DSC].ToString();
                        rft01.MNC_DIS_PER = dt.Rows[i][ft01.MNC_DIS_PER].ToString();
                        rft01.MNC_DIS_TOT = dt.Rows[i][ft01.MNC_DIS_TOT].ToString();
                        rft01.MNC_DOC_CD = dt.Rows[i][ft01.MNC_DOC_CD].ToString();
                        rft01.MNC_DOC_DAT = config1.datetoDB(dt.Rows[i][ft01.MNC_DOC_DAT]);
                        rft01.MNC_DOC_NO = dt.Rows[i][ft01.MNC_DOC_NO].ToString();
                        rft01.MNC_DOC_STS = dt.Rows[i][ft01.MNC_DOC_STS].ToString();
                        rft01.MNC_DOC_TIM = dt.Rows[i][ft01.MNC_DOC_TIM].ToString();
                        rft01.MNC_DOC_YR = dt.Rows[i][ft01.MNC_DOC_YR].ToString();
                        rft01.MNC_DOT_CD_CREDIT = dt.Rows[i][ft01.MNC_DOT_CD_CREDIT].ToString();
                        rft01.MNC_FLG_STS = dt.Rows[i][ft01.MNC_FLG_STS].ToString();
                        rft01.MNC_FN_TYP_CD = dt.Rows[i][ft01.MNC_FN_TYP_CD].ToString();
                        rft01.MNC_HN_NO = dt.Rows[i][ft01.MNC_HN_NO].ToString();
                        rft01.MNC_HN_YR = dt.Rows[i][ft01.MNC_HN_YR].ToString();
                        rft01.MNC_HR_NO = dt.Rows[i][ft01.MNC_HR_NO].ToString();
                        rft01.MNC_IMPT_STS = dt.Rows[i][ft01.MNC_IMPT_STS].ToString();
                        rft01.MNC_IP_ADD1 = dt.Rows[i][ft01.MNC_IP_ADD1].ToString();
                        rft01.MNC_IP_ADD2 = dt.Rows[i][ft01.MNC_IP_ADD2].ToString();
                        rft01.MNC_IP_ADD3 = dt.Rows[i][ft01.MNC_IP_ADD3].ToString();
                        rft01.MNC_IP_ADD4 = dt.Rows[i][ft01.MNC_IP_ADD4].ToString();
                        rft01.MNC_JOB_CD = dt.Rows[i][ft01.MNC_JOB_CD].ToString();
                        rft01.MNC_JOB_NO = dt.Rows[i][ft01.MNC_JOB_NO].ToString();
                        rft01.MNC_JOB_YR = dt.Rows[i][ft01.MNC_JOB_YR].ToString();
                        rft01.MNC_PAY_CARD = dt.Rows[i][ft01.MNC_PAY_CARD].ToString();
                        rft01.MNC_PAY_CASH = dt.Rows[i][ft01.MNC_PAY_CASH].ToString();
                        rft01.MNC_PRAKUN_CODE = dt.Rows[i][ft01.MNC_PRAKUN_CODE].ToString();
                        rft01.MNC_PRE_NO = dt.Rows[i][ft01.MNC_PRE_NO].ToString();
                        rft01.MNC_RES_MAS = dt.Rows[i][ft01.MNC_RES_MAS].ToString();
                        rft01.MNC_SEC_NO = dt.Rows[i][ft01.MNC_SEC_NO].ToString();
                        rft01.MNC_SPLIT_DOC = dt.Rows[i][ft01.MNC_SPLIT_DOC].ToString();
                        rft01.MNC_SPLIT_FLG = dt.Rows[i][ft01.MNC_SPLIT_FLG].ToString();
                        rft01.MNC_STAMP_DAT = config1.datetoDB(dt.Rows[i][ft01.MNC_STAMP_DAT]);
                        rft01.MNC_STAMP_TIM = dt.Rows[i][ft01.MNC_STAMP_TIM].ToString();
                        rft01.MNC_SUM_COS = dt.Rows[i][ft01.MNC_SUM_COS].ToString();
                        rft01.MNC_SUM_DIS = dt.Rows[i][ft01.MNC_SUM_DIS].ToString();
                        rft01.MNC_SUM_PRI = dt.Rows[i][ft01.MNC_SUM_PRI].ToString();
                        rft01.MNC_USR_CD = dt.Rows[i][ft01.MNC_USR_CD].ToString();
                        rft01.MNC_USR_DIS = dt.Rows[i][ft01.MNC_USR_DIS].ToString();
                        rft01.MNC_USR_INT = dt.Rows[i][ft01.MNC_USR_INT].ToString();
                        rft01.MNC_USR_UPD = dt.Rows[i][ft01.MNC_USR_UPD].ToString();
                        rft01.ft01Active = "1";
                        try
                        {
                            rft01.Ft01Id = rft01.getGenID();
                            rft01.groupId = setGroupId(dt.Rows[i][ft01.MNC_FN_TYP_CD].ToString().Trim());
                            //rft01.groupId = dt.Rows[i][ft01.MNC_FN_TYP_CD].ToString();
                            insert(rft01, connBua);
                        }
                        catch (Exception ex)
                        {
                            strError += " " + ex.Message;
                        }
                    }
                }

            }
            connBua.CloseConnection();
            return chk;
        }
    }
}
