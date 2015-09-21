using reportBangna.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace reportBangna.objdb
{
    public class StReceiveDB
    {
        private ConnectDB connBua;
        public ConnectDB connMainHIS;
        private LogWriter lw;
        public StReceive rec;
        public StReceiveDB(ConnectDB c)
        {
            connBua = c;
            initConfig();
        }
        private void initConfig()
        {
            rec = new StReceive();
            rec.Amount = "";
            rec.Code = "";
            rec.DateInv = "";
            rec.DateRec = "";
            rec.Description = "";
            rec.Discount = "";
            rec.Id = "";
            rec.NetTotal = "";
            rec.Remark = "";
            rec.Total = "";
            rec.Vat = "";
            rec.VatRate = "";
            rec.VenDoc = "";
            rec.VenId = "";
            rec.Active = "";

            rec.table = "";
            rec.pkField = "";

        }
        private StReceive setData(StReceive p, DataTable dt)
        {
            p.Active = dt.Rows[0][rec.Active].ToString();
            p.Amount = dt.Rows[0][rec.Amount].ToString();
            p.Code = dt.Rows[0][rec.Code].ToString();
            p.DateInv = dt.Rows[0][rec.DateInv].ToString();
            p.DateRec = dt.Rows[0][rec.DateRec].ToString();
            p.Description = dt.Rows[0][rec.Description].ToString();
            p.Discount = dt.Rows[0][rec.Discount].ToString();
            p.Id = dt.Rows[0][rec.Id].ToString();
            p.NetTotal = dt.Rows[0][rec.NetTotal].ToString();
            p.Remark = dt.Rows[0][rec.Remark].ToString();
            p.Total = dt.Rows[0][rec.Total].ToString();
            p.Vat = dt.Rows[0][rec.Vat].ToString();
            p.VatRate = dt.Rows[0][rec.VatRate].ToString();
            p.VenDoc = dt.Rows[0][rec.VenDoc].ToString();
            p.VenId = dt.Rows[0][rec.VenId].ToString();

            return p;
        }
        public StReceive selectByPk(String id)
        {
            StReceive item = new StReceive();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + rec.table + " Where " + rec.pkField + "='" + id + "'";
            dt = connBua.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        private String insert(StReceive p)
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
                //p.RowNumber = selectMaxRowNumber(p.YearId);
                p.Active = "1";
                sql = "Insert Into " + rec.table + "(" + rec.pkField + "," + rec.Active + "," + rec.Amount + "," +
                    rec.Code + "," + rec.DateInv + "," + rec.DateRec + "," +
                    rec.Description + "," + rec.Discount + "," + rec.NetTotal + "," +
                    rec.Remark + "," + rec.Total + "," + rec.Vat + "," +
                    rec.VatRate + "," + rec.VenDoc + "," + rec.VenId + ") " +
                    "Values('" + p.Id + "','" + p.Active + "','" + p.Amount + "','" +
                    p.Code + "','" + p.DateInv + "','" + p.DateRec + "','" +
                    p.Description + "','" + p.Discount + "','" + p.NetTotal + "','" +
                    p.Remark + "','" + p.Total + "','" + p.Vat + "','" +
                    p.VatRate + "','" + p.VenDoc + "," + p.VenId + "') ";
                chk = connBua.ExecuteNonQuery(sql);
                //chk = p.RowNumber;
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "insert StReceive");
            }

            return chk;
        }
        public String update(StReceive p)
        {
            String sql = "", chk = "";
            try
            {
                //p.dateModi = " CAST(year(GETDATE()) AS NVARCHAR)+'-'+ RIGHT('00' + CAST(month(GETDATE()) AS NVARCHAR), 2)+'-'+ RIGHT('00' + CAST(day(GETDATE()) AS NVARCHAR), 2)";
                sql = "Update " + rec.table + " Set " + rec.Amount + "='" + p.Amount + "'," +
                    rec.Code + "='" + p.Code + "'," +
                    rec.DateInv + "='" + p.DateInv + "'," +
                    rec.DateRec + "='" + p.DateRec + "'," +
                    rec.Description + "='" + p.Description + "'," +
                    rec.Discount + "='" + p.Discount + "'," +
                    rec.NetTotal + "='" + p.NetTotal + "'," +
                    rec.Remark + "='" + p.Remark + "'," +
                    rec.Total + "='" + p.Total + "'," +
                    rec.Vat + "='" + p.Vat + "'," +
                    rec.VatRate + "='" + p.VatRate + "', " +
                    rec.VenDoc + "='" + p.VenDoc + "', " +
                    rec.VenId + "='" + p.VenId + "' " +

                    "Where " + rec.pkField + "='" + p.Id + "'";
                chk = connBua.ExecuteNonQuery(sql);
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update StReceive");
            }
            return chk;
        }
        public String insertStReceive(StReceive p)
        {
            StReceive item = new StReceive();
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
        public String VoidStReceive(String Id)
        {
            String sql = "", chk = "";
            sql = "Update " + rec.table + " Set " + rec.Active + " = '3' " +
                "Where " + rec.pkField + "='" + Id + "'";
            try
            {
                chk = connBua.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
            }

            return chk;
        }
    }
}
