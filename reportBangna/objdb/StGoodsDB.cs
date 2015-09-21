using reportBangna.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace reportBangna.objdb
{
    public class StGoodsDB
    {
        private ConnectDB connBua;
        public StGoods good;
        public ConnectDB connMainHIS;
        private LogWriter lw;
        public StGoodsDB(ConnectDB c)
        {
            connBua = c;
            initConfig();
        }
        private void initConfig()
        {
            lw = new LogWriter();
            connMainHIS = new ConnectDB("mainhis");
            good = new StGoods();

            good.Active = "active";
            good.Code = "goods_code";
            good.CodeBng = "goods_code_bng";
            good.Id = "goods_id";
            good.NameE = "goods_name_e";
            good.NameT = "goods_name_t";
            good.NameBng = "goods_name_bng";
            good.NameGen = "goods_name_generic";
            good.Price = "price";
            good.TypeId = "type_id";
            good.VenId = "ven_id";
            good.onHand = "onhand";
            good.remark = "remark";
            good.description = "description";

            good.table = "stock_b_goods";
            good.pkField = "goods_id";
        }
        private StGoods setData(StGoods p, DataTable dt)
        {
            p.Active = dt.Rows[0][good.Active].ToString();
            p.Code = dt.Rows[0][good.Code].ToString();
            p.CodeBng = dt.Rows[0][good.CodeBng].ToString();
            p.Id = dt.Rows[0][good.Id].ToString();
            p.NameE = dt.Rows[0][good.NameE].ToString();
            p.NameT = dt.Rows[0][good.NameT].ToString();
            p.NameBng = dt.Rows[0][good.NameBng].ToString();
            p.NameGen = dt.Rows[0][good.NameGen].ToString();
            p.Price = dt.Rows[0][good.Price].ToString();
            p.TypeId = dt.Rows[0][good.TypeId].ToString();
            p.VenId = dt.Rows[0][good.VenId].ToString();
            p.onHand = dt.Rows[0][good.onHand].ToString();
            if (p.onHand.Equals(""))
            {
                p.onHand = "0";
            }
            p.remark = dt.Rows[0][good.remark].ToString();
            p.description = dt.Rows[0][good.description].ToString();
            return p;
        }
        public StGoods selectByPk(String id)
        {
            StGoods item = new StGoods();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + good.table + " Where " + good.pkField + "='" + id + "'";
            dt = connBua.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        public DataTable selectAll()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + good.table + " Where " + good.Active + "='1'";
            dt = connBua.selectData(sql);
            
            return dt;
        }
        private String insert(StGoods p)
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
                sql = "Insert Into " + good.table + "(" + good.pkField + "," + good.Active + "," + good.Code + "," +
                    good.CodeBng + "," + good.NameE + "," + good.NameT + "," +
                    good.NameBng + "," + good.NameGen + "," + good.Price + "," +
                    good.TypeId + "," + good.VenId + "," + good.onHand + "," +
                    good.remark + "," + good.description + ") " +
                    "Values('" + p.Id + "','" + p.Active + "','" + p.Code + "','" +
                    p.CodeBng + "','" + p.NameE + "','" + p.NameT + "','" +
                    p.NameBng + "','" + p.NameGen + "','" + p.Price + "','" +
                    p.TypeId + "','" + p.VenId + "','" + p.onHand + "','" +
                    p.remark + "','" + p.description + "') ";
                chk = connBua.ExecuteNonQuery(sql);
                //chk = p.RowNumber;
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "insert StGoods");
            }

            return chk;
        }
        public String update(StGoods p)
        {
            String sql = "", chk = "";
            try
            {
                //p.dateModi = " CAST(year(GETDATE()) AS NVARCHAR)+'-'+ RIGHT('00' + CAST(month(GETDATE()) AS NVARCHAR), 2)+'-'+ RIGHT('00' + CAST(day(GETDATE()) AS NVARCHAR), 2)";
                sql = "Update " + good.table + " Set " + good.Code + "='" + p.Code + "'," +
                    good.CodeBng + "='" + p.CodeBng + "'," +
                    good.NameE + "='" + p.NameE + "'," +
                    good.NameT + "='" + p.NameT + "'," +
                    good.NameBng + "='" + p.NameBng + "'," +
                    good.NameGen + "='" + p.NameGen + "'," +
                    good.Price + "='" + p.Price + "'," +
                    good.TypeId + "='" + p.TypeId + "'," +
                    good.VenId + "='" + p.VenId + "'," +
                    good.onHand + "='" + p.onHand + "'," +
                    good.remark + "='" + p.remark + "', " +
                    good.description + "='" + p.description + "' " +
                    

                    "Where " + good.pkField + "='" + p.Id + "'";
                chk = connBua.ExecuteNonQuery(sql);
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update StGoods");
            }
            return chk;
        }
        public String insertGoods(StGoods p)
        {
            StGoods item = new StGoods();
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
        public String VoidStGoods(String Id)
        {
            String sql = "", chk = "";
            sql = "Update " + good.table + " Set " + good.Active + " = '3' " +
                "Where " + good.pkField + "='" + Id + "'";
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
