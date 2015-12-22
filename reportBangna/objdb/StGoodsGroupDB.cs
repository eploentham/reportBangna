﻿using reportBangna.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace reportBangna.objdb
{
    public class StGoodsGroupDB
    {
        ConnectDB conn;
        public StGoodsGroup itg;
        public StGoodsGroupDB(ConnectDB c)
        {
            conn= c;
            initConfig();
        }
        private void initConfig()
        {
            itg = new StGoodsGroup();
            itg.Active = "item_group_active";
            itg.Id = "item_group_id";
            itg.NameE = "item_group_name_e";
            itg.NameT = "item_group_name_t";
            itg.Remark = "item_group_remark";
            itg.Sort1 = "sort1";
            itg.dateCancel = "date_cancel";
            itg.dateCreate = "date_create";
            itg.dateModi = "date_modi";
            //itg.DatePlaceRecord = "date_place_record";
            itg.userCancel = "user_cancel";
            itg.userCreate = "user_create";
            itg.userModi = "user_modi";

            itg.table = "b_item_group";
            itg.pkField = "item_group_id";
        }
        private StGoodsGroup setData(StGoodsGroup item, DataTable dt)
        {
            item.Active = dt.Rows[0][itg.Active].ToString();
            //item.Code = dt.Rows[0][itg.Code].ToString();
            item.Id = dt.Rows[0][itg.Id].ToString();
            item.NameE = dt.Rows[0][itg.NameE].ToString();
            item.NameT = dt.Rows[0][itg.NameT].ToString();
            item.Remark = dt.Rows[0][itg.Remark].ToString();
            item.Sort1 = dt.Rows[0][itg.Sort1].ToString();
            item.dateCancel = dt.Rows[0][itg.dateCancel].ToString();
            item.dateCreate = dt.Rows[0][itg.dateCreate].ToString();
            item.dateModi = dt.Rows[0][itg.dateModi].ToString();
            //item.DatePlaceRecord = dt.Rows[0][mo.DatePlaceRecord].ToString();
            item.userCancel = dt.Rows[0][itg.userCancel].ToString();
            item.userCreate = dt.Rows[0][itg.userCreate].ToString();
            item.userModi = dt.Rows[0][itg.userModi].ToString();

            return item;
        }
        public DataTable selectAll()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + itg.table + " Where " + itg.Active + "='1' Order By "+itg.Sort1;
            dt = conn.selectData(sql);

            return dt;
        }
        public StGoodsGroup selectByPk(String cuId)
        {
            StGoodsGroup item = new StGoodsGroup();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + itg.table + " Where " + itg.pkField + "='" + cuId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        public String selectMax()
        {
            //ItemGroup item = new ItemGroup();
            String sql = "", cnt="999";
            DataTable dt = new DataTable();
            sql = "Select count(1) as cnt  From " + itg.table ;
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                cnt = "000" + String.Concat(int.Parse(dt.Rows[0]["cnt"].ToString()) + 1);
                cnt = cnt.Substring(cnt.Length - 3); ;
            }
            return cnt;
        }

        public String selectSortMax()
        {
            String sql = "";
            int cnt = 0;
            DataTable dt = new DataTable();
            sql = "Select count(1) as cnt  From " + itg.table;
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                cnt = (100 + int.Parse(dt.Rows[0]["cnt"].ToString()) + 1);
                //cnt = cnt.Substring(cnt.Length - 3); ;
            }
            return cnt.ToString();
        }
        public StGoodsGroup selectByNameT(String cuId)
        {
            StGoodsGroup item = new StGoodsGroup();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + itg.table + " Where " + itg.NameT + "='" + cuId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        public String selectByNameT1(String cuId)
        {
            StGoodsGroup item = new StGoodsGroup();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select "+itg.Id+" From " + itg.table + " Where " + itg.NameT + "='" + cuId.Replace("'","''") + "'";
            dt = conn.selectData(sql);
            sql = "";
            if (dt.Rows.Count > 0)
            {
                sql = dt.Rows[0][itg.Id].ToString();
            }
            return sql;
        }
        //public ItemGroup selectByCode(String cuId)
        //{
        //    ItemGroup item = new ItemGroup();
        //    String sql = "";

        //    sql = "Select * From " + itg.table + " Where " + itg.Code + "='" + cuId + "' and " + itg.Active + "='1' ";
        //    //dt = conn.selectData(sql);
        //    DataTable dt = conn.selectData(sql);
        //    if (dt.Rows.Count > 0)
        //    {
        //        item = setData(item, dt);
        //    }
        //    return item;
        //}
        private String insert(StGoodsGroup p)
        {
            String sql = "", chk = "";
            if (p.Id.Equals(""))
            {
                p.Id = "itg" + p.getGenID();
            }

            if (p.Sort1.Equals(""))
            {
                p.Sort1 = "999";
            }
            p.NameE = p.NameE.Replace("''", "'");
            p.NameT = p.NameT.Replace("''", "'");
            p.Remark = p.Remark.Replace("''", "'");

            sql = "Insert Into " + itg.table + " (" + itg.pkField + "," + itg.Active + "," + itg.NameE + "," +
                itg.NameT + "," + itg.Remark + "," + itg.Sort1 + "," + 
                itg.dateCancel /*+ "," + itg.dateCreate*/ + "," + itg.dateModi + "," + 
                itg.userCancel + "," + itg.userCreate + "," + itg.userModi + ") " +
                "Values('" + p.Id + "','" + p.Active + "','" + p.NameE + "','" +
                p.NameT + "','" + p.Remark + "','" + p.Sort1 + "','" + 
                p.dateCancel /*+ "'," +p.dateGenDB*/ + ",'" + p.dateModi + "','" + 
                p.userCancel + "','" +p.userCreate + "','" + p.userModi + "')";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "insert StGoodsGroup");
            }
            finally
            {
            }
            return chk;
        }
        private String update(StGoodsGroup p)
        {
            String sql = "", chk = "";

            p.NameE = p.NameE.Replace("''", "'");
            p.NameT = p.NameT.Replace("''", "'");
            p.Remark = p.Remark.Replace("''", "'");
            if (p.Sort1.Equals(""))
            {
                p.Sort1 = "999";
            }
            sql = "Update " + itg.table + " Set " + itg.NameE + "='" + p.NameE + "', " +
                //itg.NameE + "='" + p.NameE + "', " +
                itg.NameT + "='" + p.NameT + "', " +
                itg.Remark + "='" + p.Remark + "', " +
                itg.Sort1 + "='" + p.Sort1 + "', " +
                itg.userModi + "='" + p.userModi + "' " +
                //itg.dateModi + "=" + p.dateGenDB + " " +

                "Where " + itg.pkField + "='" + p.Id + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update StGoodsGroup");
            }
            finally
            {
            }
            return chk;
        }
        public String insertStGoodsGroup(StGoodsGroup p)
        {
            StGoodsGroup item = new StGoodsGroup();
            String chk = "";
            item = selectByPk(p.Id);
            if (item.Id == "")
            {
                p.Active = "1";
                if (p.Sort1.Equals(""))
                {
                    p.Sort1 = selectMax();
                }
                chk = insert(p);
            }
            else
            {
                chk = update(p);
            }
            return chk;
        }
        public String deleteAll()
        {
            String sql = "", chk = "";
            sql = "Delete From " + itg.table;
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public ComboBox getCboStGoodsGroup(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectAll();
            c.Items.Clear();
            //String aaa = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][itg.Id].ToString();
                item.Text = dt.Rows[i][itg.NameT].ToString();
                c.Items.Add(item);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return c;
        }
        public String VoidStGoodsGroup(String saleId)
        {
            String sql = "", chk = "";
            sql = "Update " + itg.table + " Set " + itg.Active + "='3' " +
                "Where " + itg.pkField + "='" + saleId + "'";
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public List<StGoodsGroup> getListStGoodsGroup(List<StGoodsGroup> item)
        {
            //ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectAll();
            //c.Items.Clear();
            //String aaa = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                StGoodsGroup itg1 = new StGoodsGroup();
                itg1.Active = dt.Rows[i][itg.Active].ToString();
                //item.Code = dt.Rows[0][itg.Code].ToString();
                itg1.Id = dt.Rows[i][itg.Id].ToString();
                itg1.NameE = dt.Rows[i][itg.NameE].ToString();
                itg1.NameT = dt.Rows[i][itg.NameT].ToString();
                itg1.Remark = dt.Rows[i][itg.Remark].ToString();
                itg1.Sort1 = dt.Rows[i][itg.Sort1].ToString();
                itg1.dateCancel = dt.Rows[i][itg.dateCancel].ToString();
                itg1.dateCreate = dt.Rows[i][itg.dateCreate].ToString();
                itg1.dateModi = dt.Rows[i][itg.dateModi].ToString();
                //item.DatePlaceRecord = dt.Rows[0][mo.DatePlaceRecord].ToString();
                itg1.userCancel = dt.Rows[i][itg.userCancel].ToString();
                itg1.userCreate = dt.Rows[i][itg.userCreate].ToString();
                itg1.userModi = dt.Rows[i][itg.userModi].ToString();
                item.Add(itg1);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return item;
        }
        public ComboBox getCboStGoodsGroupByList(ComboBox c, List<StGoodsGroup> litg)
        {
            ComboBoxItem item = new ComboBoxItem();
            //DataTable dt = selectAll();
            c.Items.Clear();
            //String aaa = "";
            foreach (StGoodsGroup i in litg)
            {
                item = new ComboBoxItem();
                item.Value = i.Id;
                item.Text = i.NameT;
                c.Items.Add(item);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return c;
        }
    }
}
