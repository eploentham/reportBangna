using reportBangna.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace reportBangna.objdb
{
    class CheckNhso1DB
    {
        Config1 cf;
        public ConnectDB conn;
        private ConnectDB connBua;
        private ConnectDB connClient;
        public CheckNhso1 cNhso1;
        public CheckNhso1DB()
        {
            initConfig();
        }
        private void initConfig()
        {
            cf = new Config1();
            conn = new ConnectDB("mainhis");
            connBua = new ConnectDB("bangna");
            connClient = new ConnectDB("");
            cNhso1 = new CheckNhso1();
            cNhso1.checknhsoId = "checknhso_id";//yyyymmdd_rownumber
            cNhso1.rowID = "row_id";
            cNhso1.patientName = "patient_name";
            cNhso1.visitDate = "visit_date";
            cNhso1.visitTime = "visit_time";
            cNhso1.chronic1 = "chronic1";
            cNhso1.chronic10 = "chronic10";
            cNhso1.chronic2 = "chronic2";
            cNhso1.chronic3 = "chronic3";
            cNhso1.chronic4 = "chronic4";
            cNhso1.chronic5 = "chronic5";
            cNhso1.chronic6 = "chronic6";
            cNhso1.chronic7 = "chronic7";
            cNhso1.chronic8 = "chronic8";
            cNhso1.chronic9 = "chronic9";
            cNhso1.dia1 = "dia1";
            cNhso1.dia2 = "dia2";
            cNhso1.dia3 = "dia3";
            cNhso1.dia4 = "dia4";
            cNhso1.dia5 = "dia5";
            cNhso1.dia6 = "dia6";
            cNhso1.dia7 = "dia7";
            cNhso1.dia8 = "dia8";
            cNhso1.dia9 = "dia9";
            cNhso1.dia10 = "dia10";
            cNhso1.drug1 = "drug1";
            cNhso1.drug2 = "drug2";
            cNhso1.drug3 = "drug3";
            cNhso1.drug4 = "drug4";
            cNhso1.drug5 = "drug5";
            cNhso1.drug6 = "drug6";
            cNhso1.drug7 = "drug7";
            cNhso1.drug8 = "drug8";
            cNhso1.drug9 = "drug9";
            cNhso1.drug10 = "drug10";
            cNhso1.drug11 = "drug11";
            cNhso1.drug12 = "drug12";
            cNhso1.drug13 = "drug13";
            cNhso1.drug14 = "drug14";
            cNhso1.drug15 = "drug15";
            cNhso1.drug16 = "drug16";
            cNhso1.drug17 = "drug17";
            cNhso1.drug18 = "drug18";
            cNhso1.drug19 = "drug19";
            cNhso1.drug20 = "drug20";
            cNhso1.drug21 = "drug21";
            cNhso1.drug22 = "drug22";
            cNhso1.drug23 = "drug23";
            cNhso1.drug24 = "drug24";
            cNhso1.drug25 = "drug25";
            cNhso1.drug26 = "drug26";
            cNhso1.drug27 = "drug27";
            cNhso1.drug28 = "drug28";
            cNhso1.drug29 = "drug29";
            cNhso1.drug30 = "drug30";

            cNhso1.hn = "hn";
            cNhso1.vn = "vn";
            cNhso1.labName1 = "labname1";
            cNhso1.labName2 = "labname2";
            cNhso1.labName10 = "labname10";
            cNhso1.labName3 = "labname3";
            cNhso1.labName4 = "labname4";
            cNhso1.labName5 = "labname5";
            cNhso1.labName6 = "labname6";
            cNhso1.labName7 = "labname7";
            cNhso1.labName8 = "labname8";
            cNhso1.labName9 = "labname9";
            cNhso1.labResult1 = "labresult1";
            cNhso1.labResult2 = "labresult2";
            cNhso1.labResult3 = "labresult3";
            cNhso1.labResult4 = "labresult4";
            cNhso1.labResult5 = "labresult5";
            cNhso1.labResult6 = "labresult6";
            cNhso1.labResult7 = "labresult7";
            cNhso1.labResult8 = "labresult8";
            cNhso1.labResult9 = "labresult9";
            cNhso1.labResult10 = "labresult10";
            cNhso1.labValue1 = "labvalue1";
            cNhso1.labValue2 = "labvalue2";
            cNhso1.labValue3 = "labvalue3";
            cNhso1.labValue4 = "labvalue4";
            cNhso1.labValue5 = "labvalue5";
            cNhso1.labValue6 = "labvalue6";
            cNhso1.labValue7 = "labvalue7";
            cNhso1.labValue8 = "labvalue8";
            cNhso1.labValue9 = "labvalue9";
            cNhso1.labValue10 = "labvalue10";
            cNhso1.table = "checknhso";
            cNhso1.pkField = "checknhso_id";
            cNhso1.rowEdit = "edit1";
            cNhso1.editDia = "edit_dia";
            cNhso1.editDrug = "edit_drug";
            cNhso1.statusActive = "status_active";
            cNhso1.branchID = "branch_id";
            cNhso1.dia1Ori = "dia1_original";
            cNhso1.dia2Ori = "dia2_original";
            cNhso1.dia3Or1 = "dia3_original";
            cNhso1.dia4Ori = "dia4_original";
            cNhso1.dia5Ori = "dia5_original";
            cNhso1.dia6Ori = "dia6_original";
            cNhso1.dia7Ori = "dia7_original";
            cNhso1.dia8Ori = "dia8_original";
            cNhso1.dia9Ori = "dia9_original";
            cNhso1.dia10Ori = "dia10_original";
        }
        private CheckNhso1 setData(CheckNhso1 p, DataTable dt)
        {
            p.checknhsoId = dt.Rows[0][cNhso1.checknhsoId].ToString();//yyyymmdd_rownumber
            p.rowID = dt.Rows[0][cNhso1.rowID].ToString();
            p.patientName = dt.Rows[0][cNhso1.patientName].ToString();
            p.visitDate = dt.Rows[0][cNhso1.visitDate].ToString();
            p.visitTime = dt.Rows[0][cNhso1.visitTime].ToString();

            p.chronic1 = dt.Rows[0][cNhso1.chronic1].ToString();
            p.chronic2 = dt.Rows[0][cNhso1.chronic2].ToString();
            p.chronic3 = dt.Rows[0][cNhso1.chronic3].ToString();
            p.chronic4 = dt.Rows[0][cNhso1.chronic4].ToString();
            p.chronic5 = dt.Rows[0][cNhso1.chronic5].ToString();
            p.chronic6 = dt.Rows[0][cNhso1.chronic6].ToString();
            p.chronic7 = dt.Rows[0][cNhso1.chronic7].ToString();
            p.chronic8 = dt.Rows[0][cNhso1.chronic8].ToString();
            p.chronic9 = dt.Rows[0][cNhso1.chronic9].ToString();
            p.chronic10 = dt.Rows[0][cNhso1.chronic10].ToString();

            p.dia1 = dt.Rows[0][cNhso1.dia1].ToString();
            p.dia2 = dt.Rows[0][cNhso1.dia2].ToString();
            p.dia3 = dt.Rows[0][cNhso1.dia3].ToString();
            p.dia4 = dt.Rows[0][cNhso1.dia4].ToString();
            p.dia5 = dt.Rows[0][cNhso1.dia5].ToString();
            p.dia6 = dt.Rows[0][cNhso1.dia6].ToString();
            p.dia7 = dt.Rows[0][cNhso1.dia7].ToString();
            p.dia8 = dt.Rows[0][cNhso1.dia8].ToString();
            p.dia9 = dt.Rows[0][cNhso1.dia9].ToString();
            p.dia10 = dt.Rows[0][cNhso1.dia10].ToString();

            p.drug1 = dt.Rows[0][cNhso1.drug1].ToString();
            p.drug2 = dt.Rows[0][cNhso1.drug2].ToString();
            p.drug3 = dt.Rows[0][cNhso1.drug3].ToString();
            p.drug4 = dt.Rows[0][cNhso1.drug4].ToString();
            p.drug5 = dt.Rows[0][cNhso1.drug5].ToString();
            p.drug6 = dt.Rows[0][cNhso1.drug6].ToString();
            p.drug7 = dt.Rows[0][cNhso1.drug7].ToString();
            p.drug8 = dt.Rows[0][cNhso1.drug8].ToString();
            p.drug9 = dt.Rows[0][cNhso1.drug9].ToString();
            p.drug10 = dt.Rows[0][cNhso1.drug10].ToString();
            p.drug11 = dt.Rows[0][cNhso1.drug11].ToString();
            p.drug12 = dt.Rows[0][cNhso1.drug12].ToString();
            p.drug13 = dt.Rows[0][cNhso1.drug13].ToString();
            p.drug14 = dt.Rows[0][cNhso1.drug14].ToString();
            p.drug15 = dt.Rows[0][cNhso1.drug15].ToString();
            p.drug16 = dt.Rows[0][cNhso1.drug16].ToString();
            p.drug17 = dt.Rows[0][cNhso1.drug17].ToString();
            p.drug18 = dt.Rows[0][cNhso1.drug18].ToString();
            p.drug19 = dt.Rows[0][cNhso1.drug19].ToString();
            p.drug20 = dt.Rows[0][cNhso1.drug20].ToString();
            p.drug21 = dt.Rows[0][cNhso1.drug21].ToString();
            p.drug22 = dt.Rows[0][cNhso1.drug22].ToString();
            p.drug23 = dt.Rows[0][cNhso1.drug23].ToString();
            p.drug24 = dt.Rows[0][cNhso1.drug24].ToString();
            p.drug25 = dt.Rows[0][cNhso1.drug25].ToString();
            p.drug26 = dt.Rows[0][cNhso1.drug26].ToString();
            p.drug27 = dt.Rows[0][cNhso1.drug27].ToString();
            p.drug28 = dt.Rows[0][cNhso1.drug28].ToString();
            p.drug29 = dt.Rows[0][cNhso1.drug29].ToString();
            p.drug30 = dt.Rows[0][cNhso1.drug30].ToString();

            p.hn = dt.Rows[0][cNhso1.hn].ToString();
            p.vn = dt.Rows[0][cNhso1.vn].ToString();
            p.labName1 = dt.Rows[0][cNhso1.labName1].ToString();
            p.labName2 = dt.Rows[0][cNhso1.labName2].ToString();
            p.labName10 = dt.Rows[0][cNhso1.labName10].ToString();
            p.labName3 = dt.Rows[0][cNhso1.labName3].ToString();
            p.labName4 = dt.Rows[0][cNhso1.labName4].ToString();
            p.labName5 = dt.Rows[0][cNhso1.labName5].ToString();
            p.labName6 = dt.Rows[0][cNhso1.labName6].ToString();
            p.labName7 = dt.Rows[0][cNhso1.labName7].ToString();
            p.labName8 = dt.Rows[0][cNhso1.labName8].ToString();
            p.labName9 = dt.Rows[0][cNhso1.labName9].ToString();
            p.labResult1 = dt.Rows[0][cNhso1.labResult1].ToString();
            p.labResult2 = dt.Rows[0][cNhso1.labResult2].ToString();
            p.labResult3 = dt.Rows[0][cNhso1.labResult3].ToString();
            p.labResult4 = dt.Rows[0][cNhso1.labResult4].ToString();
            p.labResult5 = dt.Rows[0][cNhso1.labResult5].ToString();
            p.labResult6 = dt.Rows[0][cNhso1.labResult6].ToString();
            p.labResult7 = dt.Rows[0][cNhso1.labResult7].ToString();
            p.labResult8 = dt.Rows[0][cNhso1.labResult8].ToString();
            p.labResult9 = dt.Rows[0][cNhso1.labResult9].ToString();
            p.labResult10 = dt.Rows[0][cNhso1.labResult10].ToString();
            p.labValue1 = dt.Rows[0][cNhso1.labValue1].ToString();
            p.labValue2 = dt.Rows[0][cNhso1.labValue2].ToString();
            p.labValue3 = dt.Rows[0][cNhso1.labValue3].ToString();
            p.labValue4 = dt.Rows[0][cNhso1.labValue4].ToString();
            p.labValue5 = dt.Rows[0][cNhso1.labValue5].ToString();
            p.labValue6 = dt.Rows[0][cNhso1.labValue6].ToString();
            p.labValue7 = dt.Rows[0][cNhso1.labValue7].ToString();
            p.labValue8 = dt.Rows[0][cNhso1.labValue8].ToString();
            p.labValue9 = dt.Rows[0][cNhso1.labValue9].ToString();
            p.labValue10 = dt.Rows[0][cNhso1.labValue10].ToString();

            p.editDia = dt.Rows[0][cNhso1.editDia].ToString();
            p.editDrug = dt.Rows[0][cNhso1.editDrug].ToString();
            p.branchID = dt.Rows[0][cNhso1.branchID].ToString();

            p.dia1Ori = dt.Rows[0][cNhso1.dia1Ori].ToString();
            p.dia2Ori = dt.Rows[0][cNhso1.dia2Ori].ToString();
            p.dia3Or1 = dt.Rows[0][cNhso1.dia3Or1].ToString();
            p.dia4Ori = dt.Rows[0][cNhso1.dia4Ori].ToString();
            p.dia5Ori = dt.Rows[0][cNhso1.dia5Ori].ToString();
            p.dia6Ori = dt.Rows[0][cNhso1.dia6Ori].ToString();
            p.dia7Ori = dt.Rows[0][cNhso1.dia7Ori].ToString();
            p.dia8Ori = dt.Rows[0][cNhso1.dia8Ori].ToString();
            p.dia9Ori = dt.Rows[0][cNhso1.dia9Ori].ToString();
            p.dia10Ori = dt.Rows[0][cNhso1.dia10Ori].ToString();
            //p.table = "checknhso";
            //p.pkField = "checknhso_id";
            p.rowEdit = "edit1";
            return p;
        }
        public CheckNhso1 selectByPk(String sadId)
        {
            CheckNhso1 item = new CheckNhso1();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + cNhso1.table + " Where " + cNhso1.pkField + "='" + sadId + "'";
            dt = connBua.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        private String update(CheckNhso1 p)
        {
            String sql = "", chk = "";

            p.patientName = p.patientName.Replace("'", "''");
            p.dia1 = p.dia1.Replace("'", "''");


            sql = "Update " + cNhso1.table + " Set " + cNhso1.patientName + "='" + p.patientName + "'," +
                cNhso1.hn + "='" + p.hn + "', " +
                cNhso1.vn + "='" + p.vn + "', " +
                cNhso1.visitDate + "='" + p.visitDate + "', " +
                cNhso1.visitTime + "='" + p.visitTime + "', " +
                //cNhso1.rowID + "='" + p.rowID + "', " +
                cNhso1.chronic1 + "='" + p.chronic1 + "', " +
                cNhso1.chronic2 + "='" + p.chronic2 + "', " +
                cNhso1.chronic3 + "='" + p.chronic3 + "', " +
                cNhso1.chronic4 + "='" + p.chronic4 + "', " +
                cNhso1.chronic5 + "='" + p.chronic5 + "', " +
                cNhso1.chronic6 + "='" + p.chronic6 + "', " +
                cNhso1.chronic7 + "='" + p.chronic7 + "', " +
                cNhso1.chronic8 + "='" + p.chronic8 + "', " +
                cNhso1.chronic9 + "='" + p.chronic9 + "', " +
                cNhso1.chronic10 + "='" + p.chronic10 + "', " +
                cNhso1.dia1 + "='" + p.dia1 + "', " +
                cNhso1.dia2 + "='" + p.dia2 + "', " +
                cNhso1.dia3 + "='" + p.dia3 + "', " +
                cNhso1.dia4 + "='" + p.dia4 + "', " +
                cNhso1.dia5 + "='" + p.dia5 + "', " +
                cNhso1.dia6 + "='" + p.dia6 + "', " +
                cNhso1.dia7 + "='" + p.dia7 + "', " +
                cNhso1.dia8 + "='" + p.dia8 + "', " +
                cNhso1.dia9 + "='" + p.dia9 + "', " +
                cNhso1.dia10 + "='" + p.dia10 + "', " +
                cNhso1.drug1 + "='" + p.drug1 + "', " +
                cNhso1.drug2 + "='" + p.drug2 + "', " +
                cNhso1.drug3 + "='" + p.drug3 + "', " +
                cNhso1.drug4 + "='" + p.drug4 + "', " +
                cNhso1.drug5 + "='" + p.drug5 + "', " +
                cNhso1.drug6 + "='" + p.drug6 + "', " +
                cNhso1.drug7 + "='" + p.drug7 + "', " +
                cNhso1.drug8 + "='" + p.drug8 + "', " +
                cNhso1.drug9 + "='" + p.drug9 + "', " +
                cNhso1.drug10 + "='" + p.drug10 + "', " +
                cNhso1.drug11 + "='" + p.drug11 + "', " +
                cNhso1.drug12 + "='" + p.drug12 + "', " +
                cNhso1.drug13 + "='" + p.drug13 + "', " +
                cNhso1.drug14 + "='" + p.drug14 + "', " +
                cNhso1.drug15 + "='" + p.drug15 + "', " +
                cNhso1.drug16 + "='" + p.drug16 + "', " +
                cNhso1.drug17 + "='" + p.drug17 + "', " +
                cNhso1.drug18 + "='" + p.drug18 + "', " +
                cNhso1.drug19 + "='" + p.drug19 + "', " +
                cNhso1.drug20 + "='" + p.drug20 + "', " +
                cNhso1.drug21 + "='" + p.drug21 + "', " +
                cNhso1.drug22 + "='" + p.drug22 + "', " +
                cNhso1.drug23 + "='" + p.drug23 + "', " +
                cNhso1.drug24 + "='" + p.drug24 + "', " +
                cNhso1.drug25 + "='" + p.drug25 + "', " +
                cNhso1.drug26 + "='" + p.drug26 + "', " +
                cNhso1.drug27 + "='" + p.drug27 + "', " +
                cNhso1.drug28 + "='" + p.drug28 + "', " +
                cNhso1.drug29 + "='" + p.drug29 + "', " +
                cNhso1.drug30 + "='" + p.drug30 + "', " +
                cNhso1.labName1 + "='" + p.labName1 + "', " +
                cNhso1.labResult1 + "='" + p.labResult1 + "', " +
                cNhso1.labValue1 + "='" + p.labValue1 + "', " +
                cNhso1.labName2 + "='" + p.labName2 + "', " +
                cNhso1.labResult2 + "='" + p.labResult2 + "', " +
                cNhso1.labValue2 + "='" + p.labValue2 + "', " +
                cNhso1.labName3 + "='" + p.labName3 + "', " +
                cNhso1.labResult3 + "='" + p.labResult3 + "', " +
                cNhso1.labValue3 + "='" + p.labValue3 + "', " +
                cNhso1.labName4 + "='" + p.labName4 + "', " +
                cNhso1.labResult4 + "='" + p.labResult4 + "', " +
                cNhso1.labValue4 + "='" + p.labValue4 + "', " +
                cNhso1.labName5 + "='" + p.labName5 + "', " +
                cNhso1.labResult5 + "='" + p.labResult5 + "', " +
                cNhso1.labName6 + "='" + p.labName6 + "', " +
                cNhso1.labResult6 + "='" + p.labResult6 + "', " +
                cNhso1.labValue6 + "='" + p.labValue6 + "', " +
                cNhso1.labName7 + "='" + p.labName7 + "', " +
                cNhso1.labResult7 + "='" + p.labResult7 + "', " +
                cNhso1.labValue7 + "='" + p.labValue7 + "', " +
                cNhso1.labName8 + "='" + p.labName8 + "', " +
                cNhso1.labResult8 + "='" + p.labResult8 + "', " +
                cNhso1.labValue8 + "='" + p.labValue8 + "', " +
                cNhso1.labName9 + "='" + p.labName9 + "', " +
                cNhso1.labResult9 + "='" + p.labResult9 + "', " +
                cNhso1.labValue9 + "='" + p.labValue9 + "', " +
                cNhso1.labName10 + "='" + p.labName10 + "', " +
                cNhso1.labResult10 + "='" + p.labResult10 + "', " +
                cNhso1.labValue10 + "='" + p.labValue10 + "', " +
                cNhso1.editDrug + "='" + p.editDrug + "', " +
                cNhso1.editDia + "='" + p.editDia + "' " +
                "Where " + cNhso1.pkField + "='" + p.checknhsoId + "'";
            try
            {
                chk = connBua.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update CheckNhso1");
            }
            finally
            {
            }
            return chk;
        }
        private String insert(CheckNhso1 p, ConnectDB c, String client)
        {
            String sql = "", chk = "";
            if (p.checknhsoId.Equals(""))
            {
                p.checknhsoId = p.visitDate.Replace("-","")+p.visitTime+p.rowID;
            }
            try
            {
                p.dia1Ori = p.dia1;
                p.dia2Ori = p.dia2;
                p.dia3Or1 = p.dia3;
                p.dia4Ori = p.dia4;
                p.dia5Ori = p.dia5;
                p.dia6Ori = p.dia6;
                p.dia7Ori = p.dia7;
                p.dia8Ori = p.dia8;
                p.dia9Ori = p.dia9;
                p.dia10Ori = p.dia10;
                if (p.checknhsoId.Length > 3)
                {
                    p.branchID = p.checknhsoId.Substring(0, 3);
                }
                else
                {
                    p.branchID = conn.server;
                }
                
                sql = "Insert Into " + cNhso1.table+client+" ("+cNhso1.checknhsoId+","+cNhso1.patientName+","+cNhso1.hn+","+
                    cNhso1.vn+","+cNhso1.visitDate+","+cNhso1.visitTime+","+
                    cNhso1.rowID+","+cNhso1.chronic1+","+cNhso1.chronic2+","+
                    cNhso1.chronic3+","+cNhso1.chronic4+","+cNhso1.chronic5+","+
                    cNhso1.chronic6+","+cNhso1.chronic7+","+cNhso1.chronic8+","+
                    cNhso1.chronic9+","+cNhso1.chronic10+","+cNhso1.dia1+","+
                    cNhso1.dia2+","+cNhso1.dia3+","+cNhso1.dia4+","+
                    cNhso1.dia5+","+cNhso1.dia6+","+cNhso1.dia7+","+
                    cNhso1.dia8+","+cNhso1.dia9+"," + cNhso1.dia10+","+
                    cNhso1.drug1+","+cNhso1.drug2+","+
                    cNhso1.drug3+","+cNhso1.drug4+","+cNhso1.drug5+","+
                    cNhso1.drug6+","+cNhso1.drug7+","+cNhso1.drug8+","+
                    cNhso1.drug9+","+cNhso1.drug10+","+cNhso1.drug11+","+
                    cNhso1.drug12+","+cNhso1.drug13+","+cNhso1.drug14+","+
                    cNhso1.drug15+","+cNhso1.drug16+","+cNhso1.drug17+","+
                    cNhso1.drug18+","+cNhso1.drug19+","+cNhso1.drug20+","+
                    cNhso1.drug21 + ","+cNhso1.drug22 + "," + cNhso1.drug23 + "," + 
                    cNhso1.drug24 + "," +cNhso1.drug25 + "," + cNhso1.drug26 + "," + 
                    cNhso1.drug27 + "," +cNhso1.drug28 + "," + cNhso1.drug29 + "," + 
                    cNhso1.drug30 + "," +
                    cNhso1.labName1+","+cNhso1.labResult1+","+cNhso1.labValue1 + "," +
                    cNhso1.labName2+","+cNhso1.labResult2+","+cNhso1.labValue2+","+
                    cNhso1.labName3+","+cNhso1.labResult3+","+cNhso1.labValue3+","+
                    cNhso1.labName4+","+cNhso1.labResult4+","+cNhso1.labValue4+","+
                    cNhso1.labName5+","+cNhso1.labResult5+","+cNhso1.labValue5+","+
                    cNhso1.labName6+","+cNhso1.labResult6+","+cNhso1.labValue6+","+
                    cNhso1.labName7+","+cNhso1.labResult7+","+cNhso1.labValue7+","+
                    cNhso1.labName8+","+cNhso1.labResult8+","+cNhso1.labValue8+","+
                    cNhso1.labName9+","+cNhso1.labResult9+","+cNhso1.labValue9+","+
                    cNhso1.labName10+","+cNhso1.labResult10+","+cNhso1.labValue10+","+
                    cNhso1.rowEdit + "," + cNhso1.editDia + "," + cNhso1.editDrug +"," +
                    cNhso1.statusActive+","+cNhso1.branchID+","+cNhso1.dia1Ori+","+
                    cNhso1.dia2Ori+","+cNhso1.dia3Or1+","+cNhso1.dia4Ori+","+
                    cNhso1.dia5Ori+","+cNhso1.dia6Ori + "," + cNhso1.dia7Ori + "," + 
                    cNhso1.dia8Ori + "," + cNhso1.dia9Ori + "," + cNhso1.dia10Ori  + 
                    ") " +
                    "Values " + p.table + " ('" + p.checknhsoId + "','" + p.patientName + "','" + p.hn + "','" +
                    p.vn + "','" + p.visitDate + "','" + p.visitTime + "','" +
                    p.rowID + "','" + p.chronic1 + "','" + p.chronic2 + "','" +
                    p.chronic3 + "','" + p.chronic4 + "','" + p.chronic5 + "','" +
                    p.chronic6 + "','" + p.chronic7 + "','" + p.chronic8 + "','" +
                    p.chronic9 + "','" + p.chronic10 + "','" + p.dia1 + "','" +
                    p.dia2 + "','" + p.dia3 + "','" + p.dia4 + "','" +
                    p.dia5 + "','" + p.dia6 + "','" + p.dia7 + "','" +
                    p.dia8 + "','" + p.dia9+ "','" + p.dia10 + "','" +
                    p.drug1 + "','" + p.drug2 + "','" +
                    p.drug3 + "','" + p.drug4 + "','" + p.drug5 + "','" +
                    p.drug6 + "','" + p.drug7 + "','" + p.drug8 + "','" +
                    p.drug9 + "','" + p.drug10 + "','" + p.drug11 + "','" +
                    p.drug12 + "','" + p.drug13 + "','" + p.drug14 + "','" +
                    p.drug15 + "','" + p.drug16 + "','" + p.drug17 + "','" +
                    p.drug18 + "','" + p.drug19 + "','" + p.drug20 + "','" +
                    p.drug21 + "','" + p.drug22 + "','" + p.drug23 + "','" + 
                    p.drug24 + "','" + p.drug25 + "','" + p.drug26 + "','" + 
                    p.drug27 + "','" + p.drug28 + "','" + p.drug29 + "','" + 
                    p.drug30 + "','" +
                    p.labName1 + "','" + p.labResult1 + "','" + p.labValue1 + "','" +
                    p.labName2 + "','" + p.labResult2 + "','" + p.labValue2 + "','" +
                    p.labName3 + "','" + p.labResult3 + "','" + p.labValue3 + "','" +
                    p.labName4 + "','" + p.labResult4 + "','" + p.labValue4 + "','" +
                    p.labName5 + "','" + p.labResult5 + "','" + p.labValue5 + "','" +
                    p.labName6 + "','" + p.labResult6 + "','" + p.labValue6 + "','" +
                    p.labName7 + "','" + p.labResult7 + "','" + p.labValue7 + "','" +
                    p.labName8 + "','" + p.labResult8 + "','" + p.labValue8 + "','" +
                    p.labName9 + "','" + p.labResult9 + "','" + p.labValue9 + "','" +
                    p.labName10 + "','" + p.labResult10 + "','" + p.labValue10+"','"+
                    p.rowEdit + "','" + p.editDia + "','" + p.editDrug +"','"+
                    p.statusActive+"','"+p.branchID+"','"+p.dia1Ori+"','"+
                    p.dia2Ori+"','"+p.dia3Or1+"','"+p.dia4Ori+"','"+
                    p.dia5Ori + "','" + p.dia6Ori + "','" + p.dia7Ori + "','" +
                    p.dia8Ori + "','" + p.dia9Ori + "','" + p.dia10Ori +
                    "') ";
                chk = c.ExecuteNonQuery(sql);
                chk = p.checknhsoId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "insert CheckNhso1");
            }
            finally
            {
            }
            return chk;
        }
        public void deleteAllClient()
        {
            String sql = "";
            sql = "delete from checknhso_client";
            connClient.ExecuteNonQuery(sql);
        }
        //public String insertCheckNhsoClient(CheckNhso1 p)
        //{

        //}
        public String insertCHeckNhso(CheckNhso1 p, Boolean isBranch)
        {
            CheckNhso1 item = new CheckNhso1();
            String chk = "";
            item = selectByPk(p.checknhsoId);
            if (item.checknhsoId == "")
            {
                //p.statusDeposit = "0";
                //p.statusRecp = "1";
                if (isBranch)
                {
                    chk = insert(p, connClient,"_client");
                }
                else
                {
                    chk = insert(p, connBua,"");
                }
                //chk = insert(p);
            }
            else
            {
                chk = update(p);
            }
            return chk;
        }
        public DataTable selectByDate(String dateStart, String dateEnd)
        {
            String sql = "";
            DataTable dt = new DataTable();

            sql = "Select * From " + cNhso1.table
                + " Where " +cNhso1.visitDate + " >='" + dateStart + "' and " + cNhso1.visitDate + "<='" + dateEnd + "' and " + cNhso1.statusActive + "='1' "
                + "Order By " + cNhso1.visitDate + "," + cNhso1.rowID;
            dt = connBua.selectData(sql);
            return dt;
        }
        public String selectImportDataByDate()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select "+cNhso1.visitDate+", count(1) as cnt, "+cNhso1.branchID+" From "+cNhso1.table+"_client Group By "+cNhso1.visitDate+","+cNhso1.branchID;
            dt = connClient.selectData(sql);
            sql = "";
            for(int i=0;i<dt.Rows.Count;i++){
                sql += "date "+dt.Rows[i]["visit_date"].ToString()+" number "+dt.Rows[i]["cnt"].ToString()+" branch "+dt.Rows[i][cNhso1.branchID].ToString()+Environment.NewLine;
            }
            return sql;
        }
        public DataTable selectImport()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From "+cNhso1.table+"_client";
            dt = connClient.selectData(sql);
            return dt;
        }
        public DataTable selectByDate(String dateStart, String dateEnd, String chkDrug,
            String drugSearch, String labSearch1, String labSearch2, String labId, Boolean StatusLabError, Boolean doctorEdit, String branchId)
        {
            String sql = "";
            DataTable dt = new DataTable();
            String[] lab1;
            String labWhere = "", labFrom = "", drugWhere = "", drugFrom = "", statusActiceWhere="", visitDateWhere="", branchIdWhere="";
            String doctorWhere = "";
            Double aa=0.0;

            statusActiceWhere = " "+cNhso1.statusActive + "='1' ";
            visitDateWhere = cNhso1.visitDate + " >='" + dateStart + "' and " + cNhso1.visitDate + "<='" + dateEnd+"' ";
            branchIdWhere = cNhso1.branchID + " = '" + branchId + "' ";
            if (!labSearch1.Equals(""))
            {

            }
            if (!labId.Equals(""))
            {
                if (StatusLabError)
                {
                    labWhere = " ((" + visitDateWhere + " and " + cNhso1.labName1 + " like '" + labId + "%') and " + cNhso1.labValue1 + " like '%" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName2 + " like '" + labId + "%') and " + cNhso1.labValue2 + " like '%" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName3 + " like '" + labId + "%') and " + cNhso1.labValue3 + " like '%" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName4 + " like '" + labId + "%') and " + cNhso1.labValue4 + " like '%" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName5 + " like '" + labId + "%') and " + cNhso1.labValue5 + " like '%" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName6 + " like '" + labId + "%') and " + cNhso1.labValue6 + " like '%" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName7 + " like '" + labId + "%') and " + cNhso1.labValue7 + " like '%" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName8 + " like '" + labId + "%') and " + cNhso1.labValue8 + " like '%" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName9 + " like '" + labId + "%') and " + cNhso1.labValue9 + " like '%" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName10 + " like '" + labId + "%') and " + cNhso1.labValue10 + " like '%" + labSearch1 + "%')  ";
                }
                else
                {
                    if (double.TryParse(labSearch1, out aa))
                    {
                        labWhere = " ((" + visitDateWhere + " and " + cNhso1.labName1 + " like '" + labId + "%') and " + cNhso1.labValue1 + " between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName2 + " like '" + labId + "%') and " + cNhso1.labValue2 + " between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName3 + " like '" + labId + "%') and " + cNhso1.labValue3 + " between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName4 + " like '" + labId + "%') and " + cNhso1.labValue4 + " between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName5 + " like '" + labId + "%') and " + cNhso1.labValue5 + " between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName6 + " like '" + labId + "%') and " + cNhso1.labValue6 + " between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName7 + " like '" + labId + "%') and " + cNhso1.labValue7 + " between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName8 + " like '" + labId + "%') and " + cNhso1.labValue8 + " between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName9 + " like '" + labId + "%') and " + cNhso1.labValue9 + " between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName10 + " like '" + labId + "%') and " + cNhso1.labValue10 + " between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float))  ";
                    }
                    else
                    {
                        labWhere = " ((" + visitDateWhere + " and " + cNhso1.labName1 + " like '" + labId + "%') and " + cNhso1.labValue1 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName2 + " like '" + labId + "%') and " + cNhso1.labValue2 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName3 + " like '" + labId + "%') and " + cNhso1.labValue3 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName4 + " like '" + labId + "%') and " + cNhso1.labValue4 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName5 + " like '" + labId + "%') and " + cNhso1.labValue5 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName6 + " like '" + labId + "%') and " + cNhso1.labValue6 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName7 + " like '" + labId + "%') and " + cNhso1.labValue7 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName8 + " like '" + labId + "%') and " + cNhso1.labValue8 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName9 + " like '" + labId + "%') and " + cNhso1.labValue9 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName10 + " like '" + labId + "%') and " + cNhso1.labValue10 + " like '" + labSearch1 + "%')  ";
                    }
                }
            }
            else
            {
                labWhere = " (" + cNhso1.visitDate + " >='" + dateStart + "' and " + cNhso1.visitDate + "<='" + dateEnd + "') ";
            }
            if (!drugSearch.Equals(""))
            {
                drugWhere = " (" + visitDateWhere + " and " + statusActiceWhere + " and " + branchIdWhere + " and " + cNhso1.drug1 + " like '" + drugSearch + "%') or ("
                    + visitDateWhere + " and " + statusActiceWhere + " and " + branchIdWhere + " and " + cNhso1.drug2 + " like '" + drugSearch + "%') or ("
                    + visitDateWhere + " and " + statusActiceWhere + " and " + branchIdWhere + " and " + cNhso1.drug3 + " like '" + drugSearch + "%') or ("
                    + visitDateWhere + " and " + statusActiceWhere + " and " + branchIdWhere + " and " + cNhso1.drug4 + " like '" + drugSearch + "%') or ("
                    + visitDateWhere + " and " + statusActiceWhere + " and " + branchIdWhere + " and " + cNhso1.drug5 + " like '" + drugSearch + "%') or ("
                    + visitDateWhere + " and " + statusActiceWhere + " and " + branchIdWhere + " and " + cNhso1.drug6 + " like '" + drugSearch + "%') or ("
                    + visitDateWhere + " and " + statusActiceWhere + " and " + branchIdWhere + " and " + cNhso1.drug7 + " like '" + drugSearch + "%') or ("
                    + visitDateWhere + " and " + statusActiceWhere + " and " + branchIdWhere + " and " + cNhso1.drug8 + " like '" + drugSearch + "%') or ("
                    + visitDateWhere + " and " + statusActiceWhere + " and " + branchIdWhere + " and " + cNhso1.drug9 + " like '" + drugSearch + "%') or ("
                    + visitDateWhere + " and " + statusActiceWhere + " and " + branchIdWhere + " and " + cNhso1.drug10 + " like '" + drugSearch + "%') or ("
                    + visitDateWhere + " and " + statusActiceWhere + " and " + branchIdWhere + " and " + cNhso1.drug11 + " like '" + drugSearch + "%') or ("
                    + visitDateWhere + " and " + statusActiceWhere + " and " + branchIdWhere + " and " + cNhso1.drug12 + " like '" + drugSearch + "%') or ("
                    + visitDateWhere + " and " + statusActiceWhere + " and " + branchIdWhere + " and " + cNhso1.drug13 + " like '" + drugSearch + "%') or ("
                    + visitDateWhere + " and " + statusActiceWhere + " and " + branchIdWhere + " and " + cNhso1.drug14 + " like '" + drugSearch + "%') or ("
                    + visitDateWhere + " and " + statusActiceWhere + " and " + branchIdWhere + " and " + cNhso1.drug15 + " like '" + drugSearch + "%') or ("
                    + visitDateWhere + " and " + statusActiceWhere + " and " + branchIdWhere + " and " + cNhso1.drug16 + " like '" + drugSearch + "%') or ("
                    + visitDateWhere + " and " + statusActiceWhere + " and " + branchIdWhere + " and " + cNhso1.drug17 + " like '" + drugSearch + "%') or ("
                    + visitDateWhere + " and " + statusActiceWhere + " and " + branchIdWhere + " and " + cNhso1.drug18 + " like '" + drugSearch + "%') or ("
                    + visitDateWhere + " and " + statusActiceWhere + " and " + branchIdWhere + " and " + cNhso1.drug19 + " like '" + drugSearch + "%') or ("
                    + visitDateWhere + " and " + statusActiceWhere + " and " + branchIdWhere + " and " + cNhso1.drug20 + " like '" + drugSearch + "%') ";
            }
            else
            {
                drugWhere = visitDateWhere + " and " + statusActiceWhere + " and " + branchIdWhere;
            }
            if (doctorEdit)
            {
                doctorWhere = " and "+cNhso1.editDia+"<>''";
            }
            sql = "Select * From " + cNhso1.table
                //+ " Where " + drugWhere+" and "+labWhere+doctorWhere+" and "+cNhso1.statusActive+"='1' "+" and "+cNhso1.branchID+" = '"+branchId+"' "
                + " Where " + drugWhere + " and " + labWhere + doctorWhere //+ " and " + cNhso1.branchID + " = '" + branchId + "' "
                +"Order By "+cNhso1.visitDate+","+cNhso1.rowID;
            dt = connBua.selectData(sql);
            return dt;
        }
        public DataTable selectPatientByDate(String dateStart, String dateEnd, String chkDrug,
            String drugSearch, String labSearch1, String labSearch2, String labId)
        {
            //select PATIENT_T01.MNC_HN_NO,PATIENT_T01.MNC_PRE_NO,
            //PATIENT_T01.MNC_DATE,PATIENT_T01.MNC_TIME,
            //patient_t09.MNC_DIA_CD,
            //PATIENT_T09_1.CHRONICCODE,
            //PHARMACY_T06.MNC_PH_CD,
            //pharmacy_m01.MNC_PH_TN

            //from PATIENT_T01

            //left join PATIENT_T09_1 on patient_t01.MNC_ID_NAM = PATIENT_T09_1.MNC_IDNUM
            //left join PATIENT_T09 on patient_t01.MNC_PRE_NO =patient_t09.MNC_PRE_NO and
            //patient_t01.MNC_date =patient_t09.MNC_date
            //left join patient_m18 on patient_t09.MNC_DIA_CD = patient_m18 .MNC_DIA_CD
            //left join PHARMACY_T05 on patient_t01.MNC_PRE_NO = PHARMACY_T05.MNC_PRE_NO and
            //patient_t01.MNC_date = PHARMACY_T05.mnc_date
            //left join PHARMACY_T06 on pharmacy_t05.MNC_CFR_NO = pharmacy_t06.MNC_CFR_NO and
            //pharmacy_t05.MNC_CFG_DAT = pharmacy_t06.MNC_CFR_dat
            //left join PHARMACY_M01 on pharmacy_t06.MNC_PH_CD = pharmacy_m01.MNC_PH_CD

            //where PATIENT_T01.MNC_DATE BETWEEN '01/01/2014' AND '01/01/2014'

            //and patient_t01.MNC_FN_TYP_CD in ('44','45','46','47','48','49')
 
            //order by PATIENT_T01.MNC_HN_NO

            String sql = "";
            DataTable dt = new DataTable();
            if (chkDrug.Equals("1")) // drug only
            {
                String[] lab1;
                String labWhere = "", labFrom = "", drugWhere="", drugFrom="";
                if (!labSearch1.Equals(""))
                {
                    labFrom = "inner join LAB_T01 ON t01.MNC_PRE_NO = LAB_T01.MNC_PRE_NO AND t01.MNC_DATE = LAB_T01.MNC_DATE " +
                "inner join LAB_T05 ON LAB_T01.MNC_REQ_NO = LAB_T05.MNC_REQ_NO AND LAB_T01.MNC_REQ_DAT = LAB_T05.MNC_REQ_DAT ";
                    if (!labSearch2.Equals(""))
                    {
                        //lab1 = labSearch1.Split(new char[] { ',' });
                        labWhere = " and lab_t05.mnc_res_value >= " + labSearch1 + " and lab_t05.mnc_res_value <= " + labSearch2;
                    }
                    else
                    {
                        labWhere = " and lab_t05.mnc_res_value = '" + labSearch1 + "' ";
                    }
                }
                if (!labId.Equals(""))
                {
                    if (labFrom.Equals(""))
                    {
                        labFrom = "inner join LAB_T01 ON t01.MNC_PRE_NO = LAB_T01.MNC_PRE_NO AND t01.MNC_DATE = LAB_T01.MNC_DATE " +
                "inner join LAB_T05 ON LAB_T01.MNC_REQ_NO = LAB_T05.MNC_REQ_NO AND LAB_T01.MNC_REQ_DAT = LAB_T05.MNC_REQ_DAT ";
                    }
                    labWhere += " and lab_t05.mnc_lb_cd = '" + labId + "' ";
                }
                
                if (!drugSearch.Equals(""))
                {
                        drugFrom = "inner join PHARMACY_T05 phart05 on t01.MNC_PRE_NO = phart05.MNC_PRE_NO and t01.mnc_hn_no = phart05.mnc_hn_no " +
                "and t01.mnc_hn_yr = phart05.mnc_hn_yr " +
                            "inner join PHARMACY_T06 phart06 on phart05.MNC_CFR_NO = phart06.MNC_CFR_NO and phart05.MNC_CFG_DAT = phart06.MNC_CFR_dat " +
                "inner join PHARMACY_M01 on phart06.MNC_PH_CD = pharmacy_m01.MNC_PH_CD ";
                        drugWhere = "and pharmacy_m01.mnc_ph_tn like '" + drugSearch + "%' ";
                    }
                sql = "Select distinct t01.MNC_HN_NO,t01.MNC_PRE_NO, t01.MNC_DATE,t01.MNC_TIME, " +
                            //"t09.MNC_DIA_CD,t091.CHRONICCODE, " +
                "m01.mnc_fname_t, mnc_lname_t, m02.mnc_pfix_dsc, t01.mnc_vn_no, t01.mnc_vn_seq, t01.mnc_vn_sum " +
                " from PATIENT_T01 t01 " +
                "Left Join patient_m01 m01 on m01.mnc_hn_no = t01.mnc_hn_no " +
                "Left Join patient_m02 m02 on m01.mnc_pfix_cdt = m02.mnc_pfix_cd " +
                drugFrom + labFrom +
                            //"left join PATIENT_T09 t09 on t01.MNC_PRE_NO = t09.MNC_PRE_NO and t01.MNC_date = t09.MNC_date " +
                "where t01.MNC_DATE BETWEEN '" + dateStart + "' AND '" + dateEnd + "' " +
                "and t01.MNC_FN_TYP_CD in ('44','45','46','47','48','49') " +
                drugWhere + labWhere +
                "Order by t01.MNC_HN_NO";
               
            }
            else
            {
                sql = "Select t01.MNC_HN_NO,t01.MNC_PRE_NO, t01.MNC_DATE,t01.MNC_TIME, " +
                    //"t09.MNC_DIA_CD,t091.CHRONICCODE, " +
                "m01.mnc_fname_t, mnc_lname_t, m02.mnc_pfix_dsc, t01.mnc_vn_no, t01.mnc_vn_seq, t01.mnc_vn_sum " +
                " from PATIENT_T01 t01 " +
                "Left Join patient_m01 m01 on m01.mnc_hn_no = t01.mnc_hn_no " +
                "Left Join patient_m02 m02 on m01.mnc_pfix_cdt = m02.mnc_pfix_cd " +
                    //"left join PATIENT_T09_1 t091 on t01.MNC_ID_NAM = t091.MNC_IDNUM " +
                    //"left join PATIENT_T09 t09 on t01.MNC_PRE_NO = t09.MNC_PRE_NO and t01.MNC_date = t09.MNC_date " +
                "where t01.MNC_DATE BETWEEN '" + dateStart + "' AND '" + dateEnd + "' " +
                "and t01.MNC_FN_TYP_CD in ('44','45','46','47','48','49') " +
                "and t01.mnc_hn_no = '2179721 ' "+
                "Order by t01.MNC_HN_NO";
            }
            
            dt = conn.selectData(sql);
            return dt;
        }
        public DataTable selectDiaCDbyVN(String dateStart, String dateEnd, String hn, String vn, String preNo)
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select t09.MNC_DIA_CD " +
                "From PATIENT_T01 t01 " +
                "left join PATIENT_T09 t09 on t01.MNC_PRE_NO = t09.MNC_PRE_NO and t01.MNC_date = t09.MNC_date " +
                "where t01.MNC_DATE BETWEEN '" + dateStart + "' AND '" + dateEnd + "' " +
                "and t01.MNC_FN_TYP_CD in ('44','45','46','47','48','49') " + " and t01.mnc_hn_no = '" + hn + "' " +
                "and t01.mnc_vn_no = '" + vn + "'"+
                "and t01.mnc_pre_no = '" + preNo + "'";
                //"Order By t01.mnc_date, t01.mnc_hn_no ";
            dt = conn.selectData(sql);
            return dt;
        }
        public DataTable selectChronicbyVN(String dateStart, String dateEnd, String hn, String vn, String preNo)
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select t091.chroniccode " +
                "From PATIENT_T01 t01 " +
                "left join PATIENT_T09_1 t091 on t01.MNC_ID_NAM = t091.MNC_IDNUM " +
                "where t01.MNC_DATE BETWEEN '" + dateStart + "' AND '" + dateEnd + "' " +
                "and t01.MNC_FN_TYP_CD in ('44','45','46','47','48','49') " + " and t01.mnc_hn_no = '" + hn + "' " +
                "and t01.mnc_vn_no = '"+vn+"' "+
                "and t01.mnc_pre_no = '" + preNo + "'";
            dt = conn.selectData(sql);
            return dt;
        }
        public DataTable selectDrugbyVN(String dateStart, String dateEnd, String hn, String vn, String preNo)
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select phart06.MNC_PH_CD, pharmacy_m01.MNC_PH_TN " +
                "From PATIENT_T01 t01 " +
                "left join PHARMACY_T05 phart05 on t01.MNC_PRE_NO = phart05.MNC_PRE_NO and t01.MNC_date = phart05.mnc_date " +
                "left join PHARMACY_T06 phart06 on phart05.MNC_CFR_NO = phart06.MNC_CFR_NO and phart05.MNC_CFG_DAT = phart06.MNC_CFR_dat " +
                "left join PHARMACY_M01 on phart06.MNC_PH_CD = pharmacy_m01.MNC_PH_CD " +
                "where t01.MNC_DATE BETWEEN '" + dateStart + "' AND '" + dateEnd + "' " +
                "and t01.MNC_FN_TYP_CD in ('44','45','46','47','48','49') " + " and t01.mnc_hn_no = '" + hn + "' " +
                "and t01.mnc_vn_no = '" + vn + "' and PHARMACY_M01.mnc_ph_typ_flg = 'P' "+
                "and t01.mnc_pre_no = '" + preNo + "'";
            dt = conn.selectData(sql);
            return dt;
        }
        public DataTable selectLabbyVN(String dateStart, String dateEnd, String hn, String vn, String preNo)
        {
            //select PATIENT_T01.MNC_HN_NO,PATIENT_T01.MNC_PRE_NO,
            //PATIENT_T01.MNC_DATE,PATIENT_T01.MNC_TIME,
            //patient_t09.MNC_DIA_CD,
            //PATIENT_T09_1.CHRONICCODE,
            //PHARMACY_T06.MNC_PH_CD,
            //pharmacy_m01.MNC_PH_TN,
            //lab_t05.MNC_LB_CD,lab_m01.MNC_LB_DSC,
            //lab_t05.MNC_RES_VALUE,
            //lab_t05.MNC_STS
            //from PATIENT_T01
            //left join PATIENT_T09_1 on patient_t01.MNC_ID_NAM = PATIENT_T09_1.MNC_IDNUM
            //left join PATIENT_T09 on patient_t01.MNC_PRE_NO =patient_t09.MNC_PRE_NO and
            //patient_t01.MNC_date =patient_t09.MNC_date
            //left join patient_m18 on patient_t09.MNC_DIA_CD = patient_m18 .MNC_DIA_CD
            //left join PHARMACY_T05 on patient_t01.MNC_PRE_NO = PHARMACY_T05.MNC_PRE_NO and
            //patient_t01.MNC_date = PHARMACY_T05.mnc_date
            //left join PHARMACY_T06 on pharmacy_t05.MNC_CFR_NO = pharmacy_t06.MNC_CFR_NO and
            //pharmacy_t05.MNC_CFG_DAT = pharmacy_t06.MNC_CFR_dat
            //left join PHARMACY_M01 on pharmacy_t06.MNC_PH_CD = pharmacy_m01.MNC_PH_CD
            //left join LAB_T01 on  patient_t01.MNC_PRE_NO = lab_t01.MNC_PRE_NO and
            //patient_t01.MNC_date = LAB_T01.mnc_date
            //left join LAB_T05 on lab_t01.MNC_REQ_NO = lab_t05.MNC_REQ_NO and
            //lab_t01.MNC_REQ_DAT = lab_t05.MNC_REQ_DAT
            //left join LAB_M01 on lab_t05.MNC_LB_CD = lab_m01.MNC_LB_CD
            //where PATIENT_T01.MNC_DATE BETWEEN '03/02/2014' AND '03/02/2014'
            //and patient_t01.MNC_FN_TYP_CD in ('44','45','46','47','48','49')
            //and lab_t05.MNC_LB_CD in ('ch002','ch250','ch003','ch004','ch040','ch037','ch039','ch036','ch038',
            //'se005','se038','se047','ch006','ch007','ch008','ch009','se165') 
            //order by PATIENT_T01.MNC_HN_NO


//            SELECT LAB_T05.MNC_LB_CD, LAB_M01.MNC_LB_DSC, LAB_T05.MNC_RES_VALUE, LAB_T05.MNC_STS, LAB_T05.MNC_REQ_YR, LAB_T05.MNC_REQ_NO, LAB_T05.MNC_REQ_DAT, LAB_T05.MNC_LB_CD AS Expr1, 
//                  LAB_T05.MNC_LB_RES_CD, LAB_T05.MNC_RES, LAB_T05.MNC_RES_VALUE AS Expr2, LAB_T05.MNC_LB_USR, LAB_T05.MNC_STS AS Expr3, LAB_T05.MNC_RES_MIN, LAB_T05.MNC_RES_MAX, 
//                  LAB_T05.MNC_LB_RES, LAB_T05.MNC_RES_UNT, LAB_T05.MNC_LB_ACT, LAB_T05.MNC_STAMP_DAT, LAB_T05.MNC_STAMP_TIM, LAB_T05.MNC_LAB_PRN
//FROM     PATIENT_T01 AS t01 LEFT OUTER JOIN
//                  LAB_T01 ON t01.MNC_PRE_NO = LAB_T01.MNC_PRE_NO AND t01.MNC_DATE = LAB_T01.MNC_DATE LEFT OUTER JOIN
//                  LAB_T05 ON LAB_T01.MNC_REQ_NO = LAB_T05.MNC_REQ_NO AND LAB_T01.MNC_REQ_DAT = LAB_T05.MNC_REQ_DAT LEFT OUTER JOIN
//                  LAB_M01 ON LAB_T05.MNC_LB_CD = LAB_M01.MNC_LB_CD
//WHERE  (t01.MNC_DATE BETWEEN '2014-03-31' AND '2014-03-31') AND (t01.MNC_FN_TYP_CD IN ('44', '45', '46', '47', '48', '49')) AND (t01.MNC_HN_NO = '5077727') AND (LAB_T05.MNC_LB_CD IN ('ch002', 'ch250', 'ch003', 'ch004', 
//                  'ch040', 'ch037', 'ch039', 'ch036', 'ch038', 'se005', 'se038', 'se047', 'ch006', 'ch007', 'ch008', 'ch009', 'se165'))


            String sql = "";
            DataTable dt = new DataTable();
            sql = "SELECT distinct LAB_T05.MNC_LB_CD, LAB_M01.MNC_LB_DSC, LAB_T05.MNC_RES_VALUE, LAB_T05.MNC_STS " +
                "FROM     PATIENT_T01 t01 " +
                "left join LAB_T01 ON t01.MNC_PRE_NO = LAB_T01.MNC_PRE_NO AND t01.MNC_DATE = LAB_T01.MNC_DATE " +
                "left join LAB_T05 ON LAB_T01.MNC_REQ_NO = LAB_T05.MNC_REQ_NO AND LAB_T01.MNC_REQ_DAT = LAB_T05.MNC_REQ_DAT " +
                "left join LAB_M01 ON LAB_T05.MNC_LB_CD = LAB_M01.MNC_LB_CD " +
                "where t01.MNC_DATE BETWEEN '" + dateStart + "' AND '" + dateEnd + "' " +
                "and t01.MNC_FN_TYP_CD in ('44','45','46','47','48','49') " + " and t01.mnc_hn_no = '" + hn + "' " +
                "and t01.mnc_vn_no = '" + vn + "'  "+
                "and t01.mnc_pre_no = '" + preNo + "'  " +
                "and  (LAB_T05.MNC_LB_CD IN ('ch002', 'ch250', 'ch003', 'ch004', 'ch040', 'ch037', "+
                "'ch039', 'ch036', 'ch038', 'se005', 'se038', 'se047', 'ch006', 'ch007', 'ch008', 'ch009', 'se165')) "+
                "and lab_t05.mnc_res <> '' and LAB_T05.MNC_LAB_PRN = '1' ";
            dt = conn.selectData(sql);
            return dt;
        }
    }
}
