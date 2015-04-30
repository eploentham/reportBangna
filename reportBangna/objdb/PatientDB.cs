using reportBangna.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace reportBangna.objdb
{
    public class PatientDB
    {
        Config1 cf;
        public ConnectDB conn;
        Patient pa;
        public PatientDB()
        {
            initConfig();
        }
        private void initConfig()
        {
            cf = new Config1();
            pa = new Patient();
            //connBua = new ConnectDB("bangna");
            conn = new ConnectDB("mainhis");
            pa.Age = "";
            pa.Hn = "";
            pa.Name = "";
            
            pa.pkField = "";
            pa.table = "";
        }
        public Patient selectPatinet(String hn)
        {
            DataTable dt = new DataTable();
            String sql = "";
            sql = "Select m01.MNC_HN_NO,m02.MNC_PFIX_DSC as prefix, " +
                "m01.MNC_FNAME_T,m01.MNC_LNAME_T,m01.MNC_AGE " +
                "From  patient_m01 m01 " +
                " inner join patient_m02 m02 on m01.MNC_PFIX_CDT =m02.MNC_PFIX_CD " +
                " Where m01.MNC_HN_NO = '" + hn + "' ";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                pa.Hn = dt.Rows[0]["MNC_HN_NO"].ToString();
                pa.Age = dt.Rows[0]["MNC_AGE"].ToString();
                pa.Name = dt.Rows[0]["prefix"].ToString() + " " + dt.Rows[0]["MNC_FNAME_T"].ToString() + " " + dt.Rows[0]["MNC_LNAME_T"].ToString();
            }
            return pa;
        }
        public Patient selectPatinet1(String hn)
        {
            DataTable dt = new DataTable();
            String sql = "";
            sql = "Select m01.MNC_HN_NO,m02.MNC_PFIX_DSC as prefix, " +
                "m01.MNC_FNAME_T,m01.MNC_LNAME_T,m01.MNC_AGE " +
                "From  patient_m01 m01 " +
                " inner join patient_m02 m02 on m01.MNC_PFIX_CDT =m02.MNC_PFIX_CD " +
                " Where m01.MNC_HN_NO like '" + hn + "%' ";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                pa.Hn = dt.Rows[0]["MNC_HN_NO"].ToString();
                pa.Age = dt.Rows[0]["MNC_AGE"].ToString();
                pa.Name = dt.Rows[0]["prefix"].ToString() + " " + dt.Rows[0]["MNC_FNAME_T"].ToString() + " " + dt.Rows[0]["MNC_LNAME_T"].ToString();
            }
            return pa;
        }
    }
}
