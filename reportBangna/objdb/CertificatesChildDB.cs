using reportBangna.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace reportBangna.objdb
{
    class CertificatesChildDB
    {
        private ConnectDB conn;
        public CertificatesChild cC;
        public CertificatesChildDB()
        {
            conn = new ConnectDB("bangna");
            initConfig();
        }
        public CertificatesChildDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            cC = new CertificatesChild();
            cC.birthDay = "birth_day";
            cC.birthDayDate = "birth_day_date";
            cC.birthDayTime = "birth_day_time";
            cC.certifiId = "certifi_id";
            cC.childName = "chlid_name";
            cC.childSex = "child_sex";
            cC.childSurname = "child_surname";
            cC.childWeigth = "child_weigth";
            cC.dateCancel = "date_cancel";
            cC.dateCreate = "date_create";
            cC.dateModi = "date_modi";
            cC.doctorName = "doctor_name";
            cC.fatherName = "father_name";
            cC.fatherSurname = "father_surname";
            cC.motherName = "mother_name";
            cC.motherSurname = "mother_surname";
            cC.username = "user_name";
            cC.certifiActive = "certifi_active";
            cC.pkField = "certifi_id";
            cC.table = "certificates_child";
            cC.statusSurname = "status_surname";
            cC.birthDayMonth = "birth_day_month";
            cC.birthDayYear = "birth_day_year";
        }
        public CertificatesChild selectCertificatesByPk(String certifiId)
        {
            CertificatesChild item = new CertificatesChild();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From "+cC.table+" Where "+cC.pkField+"='"+certifiId+"'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item.birthDay = dt.Rows[0][cC.birthDay].ToString();
                item.birthDayDate = dt.Rows[0][cC.birthDayDate].ToString();
                item.birthDayTime = dt.Rows[0][cC.birthDayTime].ToString();
                item.certifiId = dt.Rows[0][cC.certifiId].ToString();
                item.childName = dt.Rows[0][cC.childName].ToString();
                item.childSex = dt.Rows[0][cC.childSex].ToString();
                item.childSurname = dt.Rows[0][cC.childSurname].ToString();
                item.childWeigth = dt.Rows[0][cC.childWeigth].ToString();
                item.dateCancel = dt.Rows[0][cC.dateCancel].ToString();
                item.dateCreate = dt.Rows[0][cC.dateCreate].ToString();
                item.dateModi = dt.Rows[0][cC.dateModi].ToString();
                item.doctorName = dt.Rows[0][cC.doctorName].ToString();
                item.fatherName = dt.Rows[0][cC.fatherName].ToString();
                item.fatherSurname = dt.Rows[0][cC.fatherSurname].ToString();
                item.motherName = dt.Rows[0][cC.motherName].ToString();
                item.motherSurname = dt.Rows[0][cC.motherSurname].ToString();
                item.username = dt.Rows[0][cC.username].ToString();
                item.certifiActive = dt.Rows[0][cC.certifiActive].ToString();
                item.statusSurname = dt.Rows[0][cC.statusSurname].ToString();
                item.birthDayYear = dt.Rows[0][cC.birthDayYear].ToString();
                item.birthDayMonth = dt.Rows[0][cC.birthDayMonth].ToString();
            }
            return item;
        }
        public DataTable selectByYearMonth(String year, String monthName)
        {
            String sql = "", chk = "";
            DataTable dt = new DataTable();
            sql = "Select * From "+cC.table +
                " Where "+cC.birthDayYear+"='"+year+"' and "+cC.birthDayMonth+"='"+monthName +"' and "+cC.certifiActive+" = '1' "+
                "Order By "+cC.dateCreate;
            dt = conn.selectData(sql);
            return dt;
        }
        private String insert(CertificatesChild p)
        {
            String sql = "", chk = "";
            if (p.certifiId == "")
            {
                p.certifiId = p.getGenID();
            }
            try
            {
                p.dateCreate = DateTime.Now.Year.ToString()  + DateTime.Now.ToString("-MM-dd HH:MM");

                sql = "Insert Into " + cC.table + " (" + cC.pkField + "," + cC.birthDay + "," +
                    cC.birthDayDate + "," + cC.birthDayTime + "," +
                    cC.certifiActive + "," + cC.childName + "," +
                    cC.childSex + "," + cC.childSurname + ","
                    + cC.childWeigth + "," + cC.dateCreate + "," +
                    cC.doctorName + "," + cC.fatherName + "," +
                    cC.fatherSurname + "," + cC.motherName + "," +
                    cC.motherSurname + "," + cC.username+","+
                    cC.birthDayYear +","+cC.birthDayMonth +","+
                    cC.statusSurname+ ")" +
                    "Values('" + p.certifiId + "','" + p.birthDay + "','" +
                    p.birthDayDate + "','" + p.birthDayTime + "','" +
                    "1','" + p.childName + "','" +
                    p.childSex + "','" + p.childSurname + "','" +
                    p.childWeigth + "','" + p.dateCreate + "','" +
                    p.doctorName + "','" + p.fatherName + "','" +
                    p.fatherSurname + "','" + p.motherName + "','" + 
                    p.motherSurname + "','" + p.username +"','"+
                    p.birthDayYear+"','"+p.birthDayMonth +"','"+
                    p.statusSurname+ "')";
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception("ExecuteNonQuery::Error occured.", ex);
            }
            finally
            {

            }
            return chk;
        }
        public String insertCertifi(CertificatesChild p)
        {
            CertificatesChild item = new CertificatesChild();
            String chk = "";
            item = selectCertificatesByPk(p.certifiId);
            if (item.certifiId == "")
            {
                chk = insert(p);
            }
            else
            {
                chk = update(p);
            }
            return chk;
        }
        public String update(CertificatesChild p)
        {
            String sql = "", chk = "";
            try
            {
                p.dateModi = DateTime.Now.Year.ToString() + DateTime.Now.ToString("-MM-dd HH:MM");
                p.childName = p.childName.Replace("''", "'");
                p.childSurname = p.childSurname.Replace("''", "'");
                p.doctorName = p.doctorName.Replace("''", "'");
                p.fatherName = p.fatherName.Replace("''", "'");
                p.fatherSurname = p.fatherSurname.Replace("''", "'");
                p.motherName = p.motherName.Replace("''", "'");
                p.motherSurname = p.motherSurname.Replace("''", "'");
                p.username = p.username.Replace("''", "'");
                sql = "Update " + cC.table + " Set " + cC.birthDay + "='" + p.birthDay + "'," +
                cC.birthDayDate + "='" + p.birthDayDate + "'," +
                cC.birthDayTime + "='" + p.birthDayTime + "'," +
                cC.childName + "='" + p.childName + "'," +
                cC.childSex + "='" + p.childSex + "'," +
                cC.childSurname + "='" + p.childSurname + "'," +
                cC.childWeigth + "='" + p.childWeigth + "'," +
                //cC.childSex + "='" + p.childSex + "'," +
                cC.doctorName + "='" + p.doctorName + "'," +
                cC.fatherName + "='" + p.fatherName + "'," +
                cC.fatherSurname + "='" + p.fatherSurname + "'," +
                cC.motherName + "='" + p.motherName + "'," +
                cC.motherSurname + "='" + p.motherSurname + "'," +
                cC.username + "='" + p.username + "', " +
                cC.statusSurname + "='" + p.statusSurname + "', " +
                cC.birthDayMonth + "='" + p.birthDayMonth + "', " +
                cC.birthDayYear + "='" + p.birthDayYear + "', " +
                cC.dateModi + "='" + p.dateModi + "' " +
                "Where " + cC.certifiId + "='" + p.certifiId + "'";
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String updateUnActive(String certifiId)
        {
            String sql = "", chk = "";
            sql = "Update "+cC.table +" Set "+cC.certifiActive +" = '3' "+
                "Where "+cC.pkField+"='"+certifiId+"'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
            }

            return chk;
        }
        public String updateActive(String certifiId)
        {
            String sql = "", chk = "";
            sql = "Update " + cC.table + " Set " + cC.certifiActive + " = '1' " +
                "Where " + cC.pkField + "='" + certifiId + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
            }

            return chk;
        }
    }
}
