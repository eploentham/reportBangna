using reportBangna.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace reportBangna.objdb
{
    public class StReceiveGoodsDB
    {
        private ConnectDB connBua;
        public ConnectDB connMainHIS;
        private LogWriter lw;
        public StReceiveGoods recg;
        public StReceiveGoodsDB(ConnectDB c)
        {
            connBua = c;
        }
        private void initConfig()
        {
            recg = new StReceiveGoods();
            recg.Amount = "";
            recg.Discount = "";
            recg.GoodsId = "";
            recg.Id = "";
            recg.Price = "";
            recg.Qty = "";
            recg.RecId = "";
            recg.Remark = "";
            recg.Total = "";

            recg.table = "";
            recg.pkField = "";

            recg.Active = "";
        }
        private StReceiveGoods setData(StReceiveGoods p, DataTable dt)
        {
            p.Active = dt.Rows[0][recg.Active].ToString();
            p.Amount = dt.Rows[0][recg.Amount].ToString();
            p.Discount = dt.Rows[0][recg.Discount].ToString();
            p.GoodsId = dt.Rows[0][recg.GoodsId].ToString();
            p.Id = dt.Rows[0][recg.Id].ToString();
            p.Price = dt.Rows[0][recg.Price].ToString();
            p.Qty = dt.Rows[0][recg.Qty].ToString();
            p.RecId = dt.Rows[0][recg.RecId].ToString();
            p.Remark = dt.Rows[0][recg.Remark].ToString();
            p.Total = dt.Rows[0][recg.Total].ToString();
            //p.Active = dt.Rows[0][recg.Active].ToString();

            return p;
        }
        public StReceiveGoods selectByPk(String id)
        {
            StReceiveGoods item = new StReceiveGoods();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + recg.table + " Where " + recg.pkField + "='" + id + "'";
            dt = connBua.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        private String insert(StReceiveGoods p)
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
                sql = "Insert Into " + recg.table + "(" + recg.pkField + "," + recg.Active + "," + recg.Amount + "," +
                    recg.Discount + "," + recg.GoodsId + "," + recg.Price + "," +
                    recg.Qty + "," + recg.RecId + "," + recg.Remark + "," +
                    recg.Total + ") " +
                    "Values('" + p.Id + "','" + p.Active + "','" + p.Amount + "','" +
                    p.Discount + "','" + p.GoodsId + "','" + p.Price + "','" +
                    p.Qty + "','" + p.RecId + "','" + p.Remark + "','" +
                    p.Total + "') ";
                chk = connBua.ExecuteNonQuery(sql);
                //chk = p.RowNumber;
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "insert StReceiveGoods");
            }

            return chk;
        }
        public String update(StReceiveGoods p)
        {
            String sql = "", chk = "";
            try
            {
                //p.dateModi = " CAST(year(GETDATE()) AS NVARCHAR)+'-'+ RIGHT('00' + CAST(month(GETDATE()) AS NVARCHAR), 2)+'-'+ RIGHT('00' + CAST(day(GETDATE()) AS NVARCHAR), 2)";
                sql = "Update " + recg.table + " Set " + recg.Amount + "='" + p.Amount + "'," +
                    recg.Discount + "='" + p.Discount + "'," +
                    recg.GoodsId + "='" + p.GoodsId + "'," +
                    recg.Price + "='" + p.Price + "'," +
                    recg.Qty + "='" + p.Qty + "'," +
                    recg.RecId + "='" + p.RecId + "'," +
                    recg.Remark + "='" + p.Remark + "'," +
                    recg.Remark + "='" + p.Remark + "'," +
                    recg.Total + "='" + p.Total + "' " +
                    

                    "Where " + recg.pkField + "='" + p.Id + "'";
                chk = connBua.ExecuteNonQuery(sql);
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update StReceiveGoods");
            }
            return chk;
        }
        public String insertStReceiveGoods(StReceiveGoods p)
        {
            StReceiveGoods item = new StReceiveGoods();
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
        public String VoidStReceiveGoods(String Id)
        {
            String sql = "", chk = "";
            sql = "Update " + recg.table + " Set " + recg.Active + " = '3' " +
                "Where " + recg.pkField + "='" + Id + "'";
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
