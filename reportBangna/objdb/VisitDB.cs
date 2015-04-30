using reportBangna.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace reportBangna.objdb
{
    public class VisitDB
    {
        Config1 cf;
        public ConnectDB conn;
        public Visit vs;
        public String vnSearch = "";
        public VisitDB()
        {
            initConfig();
        }
        private void initConfig()
        {
            conn = new ConnectDB("mainhis");
            vs = new Visit();
            vs.HN = "";
            vs.PatientName = "";
            vs.vn = "";
            vs.VN = "";
            vs.vnseq = "";
            vs.vnsum = "";
            vs.VisitDate = "";

            vs.table = "";
            vs.pkField = "";
        }
        public Visit selectVisit(String vn)
        {
            DataTable dt = new DataTable();
            String sql = "";
            String[] aa = vn.Split('/');
            sql = "Select   m01.MNC_HN_NO,m02.MNC_PFIX_DSC as prefix, " +
                "m01.MNC_FNAME_T,m01.MNC_LNAME_T,m01.MNC_AGE,t01.MNC_VN_NO,t01.MNC_VN_SEQ,t01.MNC_VN_SUM " +
                "From  patient_m01 m01 on t01.mnc_dot_cd = m01.MNC_DOT_CD " +
                " inner join patient_m02 m02 on m01.MNC_DOT_PFIX =m02.MNC_PFIX_CD " +
                " inner join patient_t01 t01 on m01.MNC_HN_NO =t01.MNC_HN_NO " +
                " Where t01.MNC_VN_NO = '" + vn + "' and t01.MNC_VN_SEQ = '" + vn + "' and t01.MNC_VN_SUM='" + vn+"'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                vs.HN = dt.Rows[0]["MNC_HN_NO"].ToString();
                vs.VN = dt.Rows[0]["MNC_VN_NO"].ToString() + "." + dt.Rows[0]["MNC_VN_SEQ"].ToString() + "." + dt.Rows[0]["MNC_VN_SUM"].ToString();
                vs.vn = dt.Rows[0]["MNC_VN_NO"].ToString();
                vs.vnseq = dt.Rows[0]["MNC_VN_SEQ"].ToString();
                vs.vnsum = dt.Rows[0]["MNC_VN_SUM"].ToString();
                vs.PatientName = dt.Rows[0]["prefix"].ToString() + " " + dt.Rows[0]["MNC_FNAME_T"].ToString() + " " + dt.Rows[0]["MNC_LNAME_T"].ToString();
            }

            return vs;
        }
        public DataTable selectVisitByHn(String hn)
        {
            DataTable dt = new DataTable();
            String sql = "";
            sql = "Select   t01.MNC_HN_NO,m02.MNC_PFIX_DSC as prefix, " +
                "m01.MNC_FNAME_T,m01.MNC_LNAME_T,m01.MNC_AGE,t01.MNC_VN_NO,t01.MNC_VN_SEQ,t01.MNC_VN_SUM, " +
                "Case f02.MNC_FN_TYP_DSC " +
                    "When 'ประกันสังคม (บ.1)' Then 'ปกส(บ.1)' " +
                    "When 'ประกันสังคม (บ.2)' Then 'ปกส(บ.2)' " +
                    "When 'ประกันสังคม (บ.5)' Then 'ปกส(บ.5)' " +
                    "When 'ประกันสังคมอิสระ (บ.1)' Then 'ปกต(บ.1)' " +
                    "When 'ประกันสังคมอิสระ (บ.5)' Then 'ปกต(บ.5)' " +
                    "When 'ตรวจสุขภาพ (เงินสด)' Then 'ตส(เงินสด)' " +
                    "When 'ตรวจสุขภาพ (บริษัท)' Then 'ตส(บริษัท)' " +
                    "When 'ตรวจสุขภาพ (PACKAGE)' Then 'ตส(PACKAGE)' " +
                    "When 'ลูกหนี้ประกันสังคม รพ.เมืองสมุทรปากน้ำ' Then 'ลูกหนี้(ปากน้ำ)' " +


                    "When 'ลูกหนี้บางนา 1' Then 'ลูกหนี้(บ.1)' " +
                    "When 'บริษัทประกัน' Then 'บ.ประกัน' " +
                    "When '' Then '' " +
                    "When '' Then '' " +
                    "When '' Then '' " +
                    "Else MNC_FN_TYP_DSC " +
                    "End as MNC_FN_TYP_DSC, " +
                " t01.MNC_SHIF_MEMO,t01.MNC_FN_TYP_CD " +
                "From patient_t01 t01 " +
                " inner join patient_m01 m01 on t01.MNC_HN_NO = m01.MNC_HN_NO " +
                " inner join patient_m02 m02 on m01.MNC_PFIX_CDT =m02.MNC_PFIX_CD " +
                " inner join FINANCE_M02 f02 ON t01.MNC_FN_TYP_CD = f02.MNC_FN_TYP_CD " +
                " Where t01.MNC_HN_NO = '" + hn + "' " +
                "and t01.MNC_STS <> 'C' " +
                " Order by t01.MNC_HN_NO ";
            dt = conn.selectData(sql);

            return dt;
        }
        public DataTable selectVisitByHn1(String hn)
        {
            DataTable dt = new DataTable();
            String sql = "";
            sql = "Select   t01.MNC_HN_NO,m02.MNC_PFIX_DSC as prefix, " +
                "m01.MNC_FNAME_T,m01.MNC_LNAME_T,m01.MNC_AGE,t01.MNC_VN_NO,t01.MNC_VN_SEQ,t01.MNC_VN_SUM, "+
                "Case f02.MNC_FN_TYP_DSC " +
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
                    "Else MNC_FN_TYP_DSC " +
                    "End as MNC_FN_TYP_DSC, " +
                " t01.MNC_SHIF_MEMO,t01.MNC_FN_TYP_CD,t01.MNC_DATE,t01.MNC_time " +
                "From patient_t01 t01 " +
                " inner join patient_m01 m01 on t01.MNC_HN_NO = m01.MNC_HN_NO " +
                " inner join patient_m02 m02 on m01.MNC_PFIX_CDT =m02.MNC_PFIX_CD " +
                " inner join FINANCE_M02 f02 ON t01.MNC_FN_TYP_CD = f02.MNC_FN_TYP_CD " +
                " Where t01.MNC_HN_NO like '" + hn + "%' " +
                "and t01.MNC_STS <> 'C' " +
                " Order by t01.MNC_HN_NO ";
            dt = conn.selectData(sql);

            return dt;
        }
    }
}
