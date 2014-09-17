using reportBangna.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace reportBangna.objdb
{
    class ReadmitDB
    {
        Config1 cf;
        public ConnectDB conn;
        DataTable dt1 = new DataTable();
        public ReadmitDB()
        {
            initConfig();
        }
        private void initConfig()
        {
            cf = new Config1();
            conn = new ConnectDB("mainhis");
        }
        public DataTable selectReadmit(String dateStart, String dateEnd)
        {
            //String sql = "SELECT  t09.MNC_HN_NO, t08.MNC_AN_no,t08.MNC_AN_YR,t08.MNC_AD_DATE,t08.MNC_AD_TIME, " +
            //            "t08.MNC_DS_DATE, t08.MNC_DS_TIME, m02.MNC_PFIX_DSC,  " +
            //            "m01.MNC_FNAME_T, m01.MNC_LNAME_T,f02.MNC_FN_TYP_dsc, t09.MNC_DIA_CD " +
            //            "FROM    patient_t09 AS t09 INNER JOIN " +
            //            "PATIENT_M01 AS m01 ON t09.MNC_HN_NO = m01.MNC_HN_NO INNER JOIN " +
            //            "PATIENT_M02 AS m02 ON m02.MNC_PFIX_CD = m01.MNC_PFIX_CDT inner join " +
            //            "PATIENT_T08 as t08 on t08.MNC_DATE = t09.MNC_DATE and t08.MNC_PRE_NO = t09.MNC_PRE_NO inner join " +
            //            "FINANCE_M02 as f02 on t08.MNC_FN_TYP_CD = f02.mnc_fn_typ_cd " +
            //            "WHERE  (t08.MNC_AD_DATE >= '" + dateStart + "') and (t08.MNC_AD_DATE <= '" + dateEnd + "')  " +
            //            "Order By  t09.MNC_HN_NO";
            String sql = "SELECT  t08.MNC_HN_NO, t08.MNC_AN_no,t08.MNC_AN_YR,t08.MNC_AD_DATE,t08.MNC_AD_TIME, " +
                        "t08.MNC_DS_DATE, t08.MNC_DS_TIME, m02.MNC_PFIX_DSC,  " +
                        "m01.MNC_FNAME_T, m01.MNC_LNAME_T,f02.MNC_FN_TYP_dsc,t08.mnc_pre_no,t08.mnc_vn_no,t01.MNC_DATE " +
                        "FROM patient_t08 AS t08 INNER JOIN " +
                        "PATIENT_M01 AS m01 ON t08.MNC_HN_NO = m01.MNC_HN_NO INNER JOIN " +
                        "PATIENT_M02 AS m02 ON m02.MNC_PFIX_CD = m01.MNC_PFIX_CDT inner join " +
                        "PATIENT_T01 as t01 on t01.MNC_DATE = t08.MNC_DATE and t01.MNC_PRE_NO = t08.MNC_PRE_NO inner join " +
                        "FINANCE_M02 as f02 on t08.MNC_FN_TYP_CD = f02.mnc_fn_typ_cd " +
                        "WHERE  (t08.MNC_AD_DATE >= '" + dateStart + "') and (t08.MNC_AD_DATE <= '" + dateEnd + "')  " +
                        "Order By  t08.MNC_AD_DATE,t08.mnc_pre_no, t08.MNC_HN_NO";
            DataTable dt = new DataTable();

            dt = conn.selectDataNoClose(sql);
            return dt;
        }
        public DataTable SelectReadmit24(String hn, String dateAdmit, String an)
        {
            String date24 = "";
            if (hn.Equals("5076410"))
            {
                date24 = "";
            }
            String sql = "SELECT  t09.MNC_HN_NO, t08.MNC_AN_no,t08.MNC_AN_YR,t08.MNC_AD_DATE,t08.MNC_AD_TIME, " +
                        "t08.MNC_DS_DATE, t08.MNC_DS_TIME,  " +
                        " t09.MNC_DIA_CD " +
                        "FROM    patient_t09 AS t09 INNER JOIN " +
                        //"PATIENT_M01 AS m01 ON t09.MNC_HN_NO = m01.MNC_HN_NO INNER JOIN " +
                        //"PATIENT_M02 AS m02 ON m02.MNC_PFIX_CD = m01.MNC_PFIX_CDT inner join " +
                        "PATIENT_T08 as t08 on t08.MNC_HN_NO = t09.MNC_HN_NO and t08.mnc_an_no = t09.mnc_an_no " +
                        //"FINANCE_M02 as f02 on t08.MNC_FN_TYP_CD = f02.mnc_fn_typ_cd " +
                        "WHERE  (t09.MNC_HN_NO = '" + hn + "') and (t08.MNC_DS_DATE >= dateadd(hour, -24,'" + dateAdmit + "'))  and (t08.MNC_DS_DATE < '" + dateAdmit + "') " +
                        //" and t08.MNC_AN_no <> '"+an +"' " +
                        "Order By  t09.MNC_HN_NO";
            //DataTable dt = new DataTable();
            dt1.Clear();
            dt1 = conn.selectDataNoClose(sql);
            return dt1;
        }
        public DataTable SelectReadmit48(String hn, String dateAdmit, String an, String preno)
        {
            String date24 = "";

            String sql = "SELECT  t09.MNC_HN_NO, t08.MNC_AN_no,t08.MNC_AN_YR,t08.MNC_AD_DATE,t08.MNC_AD_TIME, " +
                        "t08.MNC_DS_DATE, t08.MNC_DS_TIME,  " +
                        " t09.MNC_DIA_CD " +
                        "FROM    patient_t09 AS t09 INNER JOIN " +
                        //"PATIENT_M01 AS m01 ON t09.MNC_HN_NO = m01.MNC_HN_NO INNER JOIN " +
                        //"PATIENT_M02 AS m02 ON m02.MNC_PFIX_CD = m01.MNC_PFIX_CDT inner join " +
                        "PATIENT_T08 as t08 on t08.MNC_HN_NO = t09.MNC_HN_NO and t08.mnc_an_no = t09.mnc_an_no " +
                        //"FINANCE_M02 as f02 on t08.MNC_FN_TYP_CD = f02.mnc_fn_typ_cd " +
                        "WHERE  (t09.MNC_HN_NO = '" + hn + "') and (t08.MNC_DS_DATE >= dateadd(hour, -48,'" + dateAdmit + "'))  and (t08.MNC_DS_DATE < '" + dateAdmit + "') " +
                        " and t09.MNC_pre_no <> '" + preno + "' " +
                        "Order By  t09.MNC_HN_NO";
            //DataTable dt = new DataTable();
            dt1.Clear();
            dt1 = conn.selectDataNoClose(sql);
            return dt1;
        }
        public DataTable SelectReadmit28D(String hn, String dateAdmit, String an)
        {
            String date24 = "";

            String sql = "SELECT  t09.MNC_HN_NO, t08.MNC_AN_no,t08.MNC_AN_YR,t08.MNC_AD_DATE,t08.MNC_AD_TIME, " +
                        "t08.MNC_DS_DATE, t08.MNC_DS_TIME,  " +
                        " t09.MNC_DIA_CD " +
                        "FROM    patient_t09 AS t09 INNER JOIN " +
                //"PATIENT_M01 AS m01 ON t09.MNC_HN_NO = m01.MNC_HN_NO INNER JOIN " +
                //"PATIENT_M02 AS m02 ON m02.MNC_PFIX_CD = m01.MNC_PFIX_CDT inner join " +
                        "PATIENT_T08 as t08 on t08.MNC_HN_NO = t09.MNC_HN_NO and t08.mnc_an_no = t09.mnc_an_no " +
                //"FINANCE_M02 as f02 on t08.MNC_FN_TYP_CD = f02.mnc_fn_typ_cd " +
                        "WHERE  (t09.MNC_HN_NO = '" + hn + "') and (t08.MNC_DS_DATE >= dateadd(hour, -672,'" + dateAdmit + "'))  and (t08.MNC_DS_DATE < '" + dateAdmit + "') " +
                //" and t08.MNC_AN_no <> '" + an + "' " +
                        "Order By  t09.MNC_HN_NO";
            //DataTable dt = new DataTable();
            dt1.Clear();
            dt1 = conn.selectDataNoClose(sql);
            return dt1;
        }
        public String SelectReadmitDia(String hn, String visitDate, String preno)
        {
            String dia = "";
            String sql = "SELECT  t09.MNC_DIA_CD " +
                        "FROM patient_t09 AS t09  " +
                        //"PATIENT_M01 AS m01 ON t09.MNC_HN_NO = m01.MNC_HN_NO INNER JOIN " +
                        //"PATIENT_M02 AS m02 ON m02.MNC_PFIX_CD = m01.MNC_PFIX_CDT inner join " +
                        //"PATIENT_T08 as t08 on t08.MNC_HN_NO = t09.MNC_HN_NO inner join " +
                        //"FINANCE_M02 as f02 on t08.MNC_FN_TYP_CD = f02.mnc_fn_typ_cd " +
                        "WHERE  (t09.MNC_HN_NO = '" + hn + "') and (t09.mnc_date = '" + visitDate + "') and (t09.mnc_pre_no = '" + preno + "') " +
                        "Order By  t09.MNC_HN_NO";
            if (hn.Equals("5053664"))
            {
                dia = "";
            }
            dt1.Clear();
            dt1 = conn.selectDataNoClose(sql);
            if (dt1.Rows.Count > 0)
            {
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    dia += dt1.Rows[i]["MNC_DIA_CD"].ToString()+", ";
                }
            }
            return dia;
        }
        public DataTable SelectReVisit48H(String hn, String dateAdmit, String an)
        {
            String date24 = "";

            String sql = "SELECT  t01.MNC_HN_NO, t01.MNC_pre_no,t01.mnc_vn_no, " +
                        "t01.MNC_DATE,t09.MNC_DIA_CD  " +
                        "  " +
                        "FROM    patient_t01 AS t01  " +
                        " left join PATIENT_t09 AS t09 ON t01.MNC_DATE = t09.MNC_DATE and t01.MNC_PRE_NO = t09.MNC_PRE_NO " +
                //"PATIENT_M02 AS m02 ON m02.MNC_PFIX_CD = m01.MNC_PFIX_CDT inner join " +
                        //"PATIENT_T08 as t08 on t08.MNC_HN_NO = t09.MNC_HN_NO and t08.mnc_an_no = t09.mnc_an_no " +
                //"FINANCE_M02 as f02 on t08.MNC_FN_TYP_CD = f02.mnc_fn_typ_cd " +
                        "WHERE  (t01.MNC_HN_NO = '" + hn + "') and (t01.MNC_DATE <= dateadd(hour, +48,'" + dateAdmit + "'))  and (t01.MNC_DATE > '" + dateAdmit + "') and t01.MNC_STS = 'F' " +
                //" and t08.MNC_AN_no <> '" + an + "' " +
                        "Order By  t01.MNC_HN_NO";
            //DataTable dt = new DataTable();
            dt1.Clear();
            dt1 = conn.selectDataNoClose(sql);
            return dt1;
        }
    }
}
