using reportBangna.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace reportBangna.objdb
{
    public class LabExDB
    {
        Config1 cf;
        public ConnectDB connBua;
        public ConnectDB conn;
        public LabEx labex;
        public LabExDB()
        {
            initConfig();
        }
        private void initConfig()
        {
            cf = new Config1();
            connBua = new ConnectDB("bangna");
            conn = new ConnectDB("mainhis");
            labex = new LabEx();
            labex.Active = "labex_active";
            labex.Description = "description";
            labex.Hn = "hn";
            labex.Id = "labex_id";
            labex.LabDate = "lab_date";
            labex.LabExDate = "labex_date";
            labex.PatientName = "patient_name";
            labex.Remark = "remark";
            labex.RowNumber = "row_number";
            labex.VisitDate = "visit_date";
            labex.VisitTime = "visit_time";
            labex.Vn = "vn";
            labex.YearId = "year_id";

            labex.table = "labex";
            labex.pkField = "labex_id";
        }
        private LabEx setData(LabEx p, DataTable dt)
        {
            p.Active = dt.Rows[0][labex.Active].ToString();
            p.Description = dt.Rows[0][labex.Description].ToString();
            p.Hn = dt.Rows[0][labex.Hn].ToString();
            p.Id = dt.Rows[0][labex.Id].ToString();
            p.LabDate = dt.Rows[0][labex.LabDate].ToString();
            p.LabExDate = dt.Rows[0][labex.LabExDate].ToString();
            p.PatientName = dt.Rows[0][labex.PatientName].ToString();
            p.Remark = dt.Rows[0][labex.Remark].ToString();
            p.RowNumber = dt.Rows[0][labex.RowNumber].ToString();
            p.VisitDate = dt.Rows[0][labex.VisitDate].ToString();
            p.VisitTime = dt.Rows[0][labex.VisitTime].ToString();
            p.Vn = dt.Rows[0][labex.Vn].ToString();
            p.YearId = dt.Rows[0][labex.YearId].ToString();

            return p;
        }
        public LabEx selectByPk(String Id)
        {
            LabEx item = new LabEx();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + labex.table + " Where " + labex.pkField + "='" + Id + "'";
            dt = connBua.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        public String selectMaxRowNumber(String yearId)
        {
            //Image1 item = new Image1();
            String sql = "";
            int cnt = 0;
            DataTable dt = new DataTable();
            sql = "Select Max(" + labex.RowNumber + ") as cnt From " + labex.table + " Where " + labex.YearId + "='" + yearId + "'";
            dt = connBua.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["cnt"] != null)
                {
                    if (dt.Rows[0]["cnt"].ToString().Equals(""))
                    {
                        cnt = 100000;
                    }
                    else
                    {
                        if (dt.Rows[0]["cnt"].ToString().Equals("0"))
                        {
                            cnt = 100000;
                        }
                        else
                        {
                            cnt = int.Parse(dt.Rows[0]["cnt"].ToString()) + 1;
                        }
                    }
                }
                else
                {
                    cnt = 100000;
                }
            }
            else
            {
                cnt = 100000;
            }
            return cnt.ToString();
        }
        private String insert(LabEx p)
        {
            String sql = "", chk = "";
            try
            {
                if (p.Id == "")
                {
                    p.Id = p.getGenID();
                }
                //p.monthId = "RIGHT('00' + CAST(month(GETDATE()) AS NVARCHAR), 2)";
                //p.yearId = "CAST(year(GETDATE()) AS NVARCHAR)";
                //p.dateCreate = " CAST(year(GETDATE()) AS NVARCHAR)+'-'+ RIGHT('00' + CAST(month(GETDATE()) AS NVARCHAR), 2)+'-'+ RIGHT('00' + CAST(day(GETDATE()) AS NVARCHAR), 2)"
                //    + "' '+ RIGHT('00' + CAST(hour(GETDATE()) AS NVARCHAR), 2)+':'+ RIGHT('00' + CAST(minute(GETDATE()) AS NVARCHAR), 2)+':'+ RIGHT('00' + CAST(second(GETDATE()) AS NVARCHAR), 2)";
                p.RowNumber = selectMaxRowNumber(p.YearId);
                p.Active = "1";
                sql = "Insert Into " + labex.table + "(" + labex.pkField + "," + labex.Active + "," + labex.Description + "," +
                    labex.Hn + "," + labex.LabDate + "," + labex.LabExDate + "," +
                    labex.PatientName + "," + labex.Remark + "," + labex.RowNumber + "," +
                    labex.VisitDate + "," + labex.VisitTime + "," + labex.Vn+","+labex.YearId + ") " +
                    "Values('" + p.Id + "','" + p.Active + "','" + p.Description + "','" +
                    p.Hn + "','" + p.LabDate + "','" + p.LabExDate + "','" +
                    p.PatientName + "','" + p.Remark + "','" + p.RowNumber + "','" +
                    p.VisitDate + "','" + p.VisitTime + "','" + p.Vn+"','"+p.YearId + "') ";
                chk = connBua.ExecuteNonQuery(sql);
                chk = p.RowNumber;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "insert LabEx");
            }

            return chk;
        }
        public String update(LabEx p)
        {
            String sql = "", chk = "";
            try
            {
                //p.dateModi = " CAST(year(GETDATE()) AS NVARCHAR)+'-'+ RIGHT('00' + CAST(month(GETDATE()) AS NVARCHAR), 2)+'-'+ RIGHT('00' + CAST(day(GETDATE()) AS NVARCHAR), 2)";
                sql = "Update " + labex.table + " Set " + labex.Description + "='" + p.Description + "'," +
                    labex.Hn + "='" + p.Hn + "'," +
                    labex.LabDate + "='" + p.LabDate + "'," +
                    labex.LabExDate + "='" + p.LabExDate + "'," +
                    labex.PatientName + "='" + p.PatientName + "'," +
                    labex.Remark + "='" + p.Remark + "'," +
                    labex.RowNumber + "='" + p.RowNumber + "'," +
                    labex.VisitDate + "='" + p.VisitDate + "'," +
                    labex.VisitTime + "='" + p.VisitTime + "'," +
                    labex.Vn + "='" + p.Vn + "'," +
                    labex.YearId + "='" + p.YearId + "' " +

                    "Where " + labex.pkField + "='" + p.Id + "'";
                chk = connBua.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update LabEx");
            }
            return chk;
        }
        public String insertLabEx(LabEx p)
        {
            LabEx item = new LabEx();
            String chk = "";
            item = selectByPk(p.Id);
            if (item.Id == "")
            {
                chk = insert(p);
            }
            else
            {
                chk = update(p);
            }
            return chk;
        }
        public String VoidLabEx(String Id)
        {
            String sql = "", chk = "";
            sql = "Update " + labex.table + " Set " + labex.Active + " = '3' " +
                "Where " + labex.pkField + "='" + Id + "'";
            try
            {
                chk = connBua.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
            }

            return chk;
        }
        public DataTable selectVisitByHn(String hn)
        {
            DataTable dt = new DataTable();
            String sql = "";
            sql = "Select   t01.MNC_HN_NO,m02.MNC_PFIX_DSC as prefix, " +
                "m01.MNC_FNAME_T,m01.MNC_LNAME_T,m01.MNC_AGE,t01.MNC_VN_NO,t01.MNC_VN_SEQ,t01.MNC_VN_SUM,t01.MNC_FN_TYP_CD " +
                "From patient_t01 t01 " +
                " inner join patient_m01 m01 on t01.MNC_HN_NO = m01.MNC_HN_NO " +
                " inner join patient_m02 m02 on m01.MNC_PFIX_CDT =m02.MNC_PFIX_CD " +
                " Where t01.MNC_HN_NO = '" + hn + "' " +
                "and t01.MNC_STS <> 'C' " +
                " Order by t01.mnc_dot_cd ";
            dt = conn.selectData(sql);

            return dt;
        }
        public DataTable selectByHn(String hn)
        {
            DataTable dt = new DataTable();
            String sql = "";
            sql = "Select   * " +
                "From " + labex.table + " " +
                " Where " + labex.Hn+ " = '" + hn + "' " +
                "and " + labex.Active+ " = '1' " +
                " Order by " + labex.RowNumber+ " ";
            dt = connBua.selectData(sql);

            return dt;
        }
    }
}
