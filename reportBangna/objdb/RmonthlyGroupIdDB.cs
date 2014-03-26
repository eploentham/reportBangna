using reportBangna.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace reportBangna.objdb
{
    class RmonthlyGroupIdDB
    {
        public ConnectDB conn;
        public RmonthlyGroupId rmg;
        private Config1 config1;
        public RmonthlyGroupIdDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        public RmonthlyGroupIdDB()
        {
            conn = new ConnectDB("bangna");
            initConfig();
        }
        private void initConfig()
        {
            rmg = new RmonthlyGroupId();
            config1 = new Config1();
            rmg.amountAccident = "amount_accident";
            rmg.amountCash = "amount_cash";
            rmg.amountContract = "amount_contract";
            rmg.amountOther = "amount_other";
            rmg.amountSsnBangna = "amount_ssn_bangna";
            rmg.amountInsur = "amount_insur";
            rmg.amountWork = "amount_work";
            rmg.qtyWork = "qty_work";
            rmg.qtyAccident = "qty_accident";
            rmg.qtyCash = "qty_cash";
            rmg.qtyContract = "qty_contract";
            rmg.qtyOther = "qty_other";
            rmg.qtySsnBangna = "qty_ssn_bangna";
            rmg.qtyInsur = "qty_Insur";
            rmg.table = "R_MONTHLY_GROUP_ID";
            rmg.visitDate = "visit_date";
            rmg.pkField = "visit_date";
            rmg.sort1 = "sort1";
            rmg.group1 = "group1";
        }
        public DataTable selectAll()
        {
            DataTable dt = new DataTable();
            String sql = "";
            sql = "Select * From " + rmg.table+" "+
                " Order By " + rmg.sort1;
            dt = conn.selectData(sql);
            return dt;
        }
        private String deleteAll(ConnectDB c)
        {
            String sql = "", chk = "";
            sql = "Delete From R_MONTHLY_GROUP_ID";
            //sql = "Update " + ft01.table + " Set " + ft01.ft01Active + "='3'";
            chk = c.ExecuteNonQuery(sql);
            return chk;
        }
        private String insert(RmonthlyGroupId p)
        {
            String sql = "", chk = "";
            p.sort1 = p.visitDate;
            p.visitDate = config1.dateDBtoShow(p.visitDate);
            if (p.qtyWork.Equals("13"))
            {
                sql = "";
            }
            sql = "Insert Into " + rmg.table + "(" + rmg.visitDate + "," + rmg.amountAccident + "," +
                rmg.amountCash+","+rmg.amountContract+","+
                rmg.amountOther + "," + rmg.amountSsnBangna + "," +
                rmg.amountInsur + ","+rmg.amountWork+"," + rmg.qtyAccident + "," +
                rmg.qtyCash + "," + rmg.qtyContract + "," +
                rmg.qtyOther + "," + rmg.qtySsnBangna + "," +
                rmg.qtyInsur +","+rmg.group1 + ","+rmg.qtyWork+" ) " +

                "Values('"+p.visitDate+"',"+p.amountAccident+","+
                p.amountCash+","+p.amountContract+","+
                p.amountOther+","+p.amountSsnBangna+","+
                p.amountInsur+","+p.amountWork+","+p.qtyAccident+","+
                p.qtyCash+","+p.qtyContract+","+
                p.qtyOther+","+p.qtySsnBangna+","+
                p.qtyInsur+",'"+p.group1+"','"+p.qtyWork+"')";

            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public void setRMonthlyGroupId(String dateStart, String dateEnd,ProgressBar pb)
        {
            //1. ดึงวันที่ตามต้องการ
            //2. insert วันที่ลง table
            //3. 
            pb.Show();
            pb.Minimum = 0;
            ConnectDB connBua = new ConnectDB("bangna");
            ConnectDB connMainHis = new ConnectDB("mainhis");
            FinanceT01DB ft01db = new FinanceT01DB(connMainHis);
            FinanceT01 ft01 = new FinanceT01();
            DataTable dtFt01 = new DataTable();
            //dtFt01 = ft01db.selectAll();
            DataTable dtDate = new DataTable();
            RmonthlyGroupId p = new RmonthlyGroupId();
            String sql = "", visitDate = "", groupId = "", cnt = "", amount = "";
            deleteAll(connBua);

            ft01db.insertFT01ByDateEndFormCloseDay(dateStart, dateEnd,pb);
            sql = "Select " + ft01db.ft01.MNC_DAT_END + " From " + ft01db.ft01.table +
                " Where " + ft01db.ft01.MNC_DAT_END + " >='" + dateStart + "' and " + ft01db.ft01.MNC_DAT_END + " <='" + dateEnd + "' " +
                "Group By " + ft01db.ft01.MNC_DAT_END + " " +
                "Order By " + ft01db.ft01.MNC_DAT_END;
            dtDate = connBua.selectData(sql);
            pb.Value = 0;
            pb.Maximum = dtDate.Rows.Count;
            for (int i = 0; i < dtDate.Rows.Count; i++)
            {
                pb.Value = i;
                visitDate = dtDate.Rows[i][ft01db.ft01.MNC_DAT_END].ToString();
                sql = "Select count(1) as cnt, SUM(" + ft01db.ft01.MNC_SUM_PRI + ") AS " + ft01db.ft01.MNC_SUM_PRI + "," + 
                    ft01db.ft01.groupId + "," + ft01db.ft01.MNC_DAT_END + 
                    " From " + ft01db.ft01.table +
                    " Where " + ft01db.ft01.MNC_DAT_END + " ='" + visitDate + "' and " + ft01db.ft01.ft01Active + "='1' " +
                    "Group By " + ft01db.ft01.MNC_DAT_END + "," + ft01db.ft01.groupId + " " +
                    "Order By " + ft01db.ft01.MNC_DAT_END + "," + ft01db.ft01.groupId;
                dtFt01 = connBua.selectData(sql);
                p = new RmonthlyGroupId();
                p.amountAccident = "0";
                p.amountCash = "0";
                p.amountContract = "0";
                p.amountOther = "0";
                p.amountSsnBangna = "0";
                p.amountInsur = "0";
                p.amountWork = "0";
                p.qtyAccident = "0";
                p.qtyCash = "0";
                p.qtyContract = "0"; ;
                p.qtyOther = "0";
                p.qtySsnBangna = "0";
                p.qtyInsur = "0";
                p.qtyWork = "0";
                p.group1 = "1";
                for (int j = 0; j < dtFt01.Rows.Count; j++)
                {
                    cnt = dtFt01.Rows[j]["cnt"].ToString();
                    amount = dtFt01.Rows[j][ft01db.ft01.MNC_SUM_PRI].ToString();
                    groupId = dtFt01.Rows[j][ft01db.ft01.groupId].ToString();
                    if (visitDate == "")
                    {
                        continue;
                    }
                    p.visitDate = visitDate;
                    if (groupId == "เงินสด")
                    {
                        p.qtyCash = config1.NumberNull(dtFt01.Rows[j]["cnt"].ToString());
                        p.amountCash = config1.NumberNull(dtFt01.Rows[j][ft01db.ft01.MNC_SUM_PRI].ToString());
                    }
                    else if (groupId == "ประกันสังคม")
                    {
                        if (visitDate == "2013-06-23")
                        {
                            sql = "";
                        }
                        p.qtySsnBangna = config1.NumberNull(dtFt01.Rows[j]["cnt"].ToString());
                        p.amountSsnBangna = config1.NumberNull(dtFt01.Rows[j][ft01db.ft01.MNC_SUM_PRI].ToString());
                    }
                   
                    else if (groupId == "สัญญาบริษัท")
                    {
                        p.qtyContract = config1.NumberNull(dtFt01.Rows[j]["cnt"].ToString());
                        p.amountContract = config1.NumberNull(dtFt01.Rows[j][ft01db.ft01.MNC_SUM_PRI].ToString());
                    }
                    else if (groupId == "พ.ร.บ")
                    {
                        p.qtyAccident = config1.NumberNull(dtFt01.Rows[j]["cnt"].ToString());
                        p.amountAccident = config1.NumberNull(dtFt01.Rows[j][ft01db.ft01.MNC_SUM_PRI].ToString());
                    }

                    else if (groupId == "กองทุน")
                    {
                        p.qtyWork = config1.NumberNull(dtFt01.Rows[j]["cnt"].ToString());
                        p.amountWork = config1.NumberNull(dtFt01.Rows[j][ft01db.ft01.MNC_SUM_PRI].ToString());
                    }
                    else if (groupId == "บริษัทประกัน")
                    {
                        p.qtyInsur = config1.NumberNull(dtFt01.Rows[j]["cnt"].ToString());
                        p.amountInsur = config1.NumberNull(dtFt01.Rows[j][ft01db.ft01.MNC_SUM_PRI].ToString());
                    }

                    else if (groupId == "อื่นๆ")
                    {
                        p.qtyOther = config1.NumberNull(dtFt01.Rows[j]["cnt"].ToString());
                        p.amountOther = config1.NumberNull(dtFt01.Rows[j][ft01db.ft01.MNC_SUM_PRI].ToString());
                    }
                    else
                    {

                    }
                    
                }
                if (p.visitDate != "")
                {
                    insert(p);
                }
                
            }
            pb.Hide();
        }
        public void setDailyCheckup(String dateStart, String dateEnd, ProgressBar pb)
        {
            //1. ดึงวันที่ตามต้องการ
            //2. insert วันที่ลง table
            //3. 
            pb.Show();
            pb.Minimum = 0;
            ConnectDB connBua = new ConnectDB("bangna");
            ConnectDB connMainHis = new ConnectDB("mainhis");
            FinanceT01DB ft01db = new FinanceT01DB(connMainHis);
            FinanceT01 ft01 = new FinanceT01();
            DataTable dtFt01 = new DataTable();
            //dtFt01 = ft01db.selectAll();
            DataTable dtDate = new DataTable();
            RmonthlyGroupId p = new RmonthlyGroupId();
            String sql = "", visitDate = "", groupId = "", cnt = "", amount = "";
            deleteAll(connBua);
            ft01db.insertFT01ByDateEndFormCloseDayFix1518(dateStart, dateEnd, pb);
            sql = "Select " + ft01db.ft01.MNC_DAT_END + " From " + ft01db.ft01.table +
                " Where " + ft01db.ft01.MNC_DAT_END + " >='" + dateStart + "' and " + ft01db.ft01.MNC_DAT_END + " <='" + dateEnd + "' " +
                "Group By " + ft01db.ft01.MNC_DAT_END + " " +
                "Order By " + ft01db.ft01.MNC_DAT_END;
            dtDate = connBua.selectData(sql);
            pb.Value = 0;
            pb.Maximum = dtDate.Rows.Count;
            for (int i = 0; i < dtDate.Rows.Count; i++)
            {
                pb.Value = i;
                visitDate = dtDate.Rows[i][ft01db.ft01.MNC_DAT_END].ToString();
                sql = "Select count(1) as cnt, SUM(" + ft01db.ft01.MNC_SUM_PRI + "-" + ft01db.ft01.MNC_DIS_TOT + ") AS " + ft01db.ft01.MNC_SUM_PRI + "," +
                    ft01db.ft01.MNC_DAT_END +
                    " From " + ft01db.ft01.table +
                    " Where " + ft01db.ft01.MNC_DAT_END + " ='" + visitDate + "' and " + ft01db.ft01.ft01Active + "='1' " +
                    "Group By " + ft01db.ft01.MNC_DAT_END +" " +
                    "Order By " + ft01db.ft01.MNC_DAT_END ;
                dtFt01 = connBua.selectData(sql);
                p = new RmonthlyGroupId();
                p.amountAccident = "0";
                p.amountCash = "0";
                p.amountContract = "0";
                p.amountOther = "0";
                p.amountSsnBangna = "0";
                p.amountInsur = "0";
                p.amountWork = "0";
                p.qtyAccident = "0";
                p.qtyCash = "0";
                p.qtyContract = "0"; ;
                p.qtyOther = "0";
                p.qtySsnBangna = "0";
                p.qtyInsur = "0";
                p.qtyWork = "0";

                for (int j = 0; j < dtFt01.Rows.Count; j++)
                {
                    cnt = dtFt01.Rows[j]["cnt"].ToString();
                    amount = dtFt01.Rows[j][ft01db.ft01.MNC_SUM_PRI].ToString();
                    //groupId = dtFt01.Rows[j][ft01db.ft01.groupId].ToString();
                    if (visitDate == "")
                    {
                        continue;
                    }
                    p.visitDate = visitDate;

                    p.qtyCash = config1.NumberNull(dtFt01.Rows[j]["cnt"].ToString());
                    p.amountCash = config1.NumberNull(dtFt01.Rows[j][ft01db.ft01.MNC_SUM_PRI].ToString());
                }
                if (p.visitDate != "")
                {
                    insert(p);
                }

            }
            pb.Hide();
        }
    }
}