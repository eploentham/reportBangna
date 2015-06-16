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
        private CheckNhso1 setData(CheckNhso1 cNhso1, DataTable dt)
        {
            cNhso1.checknhsoId = dt.Rows[0][cNhso1.checknhsoId].ToString();//yyyymmdd_rownumber
            cNhso1.rowID = dt.Rows[0][cNhso1.rowID].ToString();
            cNhso1.patientName = dt.Rows[0][cNhso1.patientName].ToString();
            cNhso1.visitDate = dt.Rows[0][cNhso1.visitDate].ToString();
            cNhso1.visitTime = dt.Rows[0][cNhso1.visitTime].ToString();

            cNhso1.chronic1 = dt.Rows[0][cNhso1.chronic1].ToString();
            cNhso1.chronic2 = dt.Rows[0][cNhso1.chronic2].ToString();
            cNhso1.chronic3 = dt.Rows[0][cNhso1.chronic3].ToString();
            cNhso1.chronic4 = dt.Rows[0][cNhso1.chronic4].ToString();
            cNhso1.chronic5 = dt.Rows[0][cNhso1.chronic5].ToString();
            cNhso1.chronic6 = dt.Rows[0][cNhso1.chronic6].ToString();
            cNhso1.chronic7 = dt.Rows[0][cNhso1.chronic7].ToString();
            cNhso1.chronic8 = dt.Rows[0][cNhso1.chronic8].ToString();
            cNhso1.chronic9 = dt.Rows[0][cNhso1.chronic9].ToString();
            cNhso1.chronic10 = dt.Rows[0][cNhso1.chronic10].ToString();

            cNhso1.dia1 = dt.Rows[0][cNhso1.dia1].ToString();
            cNhso1.dia2 = dt.Rows[0][cNhso1.dia2].ToString();
            cNhso1.dia3 = dt.Rows[0][cNhso1.dia3].ToString();
            cNhso1.dia4 = dt.Rows[0][cNhso1.dia4].ToString();
            cNhso1.dia5 = dt.Rows[0][cNhso1.dia5].ToString();
            cNhso1.dia6 = dt.Rows[0][cNhso1.dia6].ToString();
            cNhso1.dia7 = dt.Rows[0][cNhso1.dia7].ToString();
            cNhso1.dia8 = dt.Rows[0][cNhso1.dia8].ToString();
            cNhso1.dia9 = dt.Rows[0][cNhso1.dia9].ToString();
            cNhso1.dia10 = dt.Rows[0][cNhso1.dia10].ToString();

            cNhso1.drug1 = dt.Rows[0][cNhso1.drug1].ToString();
            cNhso1.drug2 = dt.Rows[0][cNhso1.drug2].ToString();
            cNhso1.drug3 = dt.Rows[0][cNhso1.drug3].ToString();
            cNhso1.drug4 = dt.Rows[0][cNhso1.drug4].ToString();
            cNhso1.drug5 = dt.Rows[0][cNhso1.drug5].ToString();
            cNhso1.drug6 = dt.Rows[0][cNhso1.drug6].ToString();
            cNhso1.drug7 = dt.Rows[0][cNhso1.drug7].ToString();
            cNhso1.drug8 = dt.Rows[0][cNhso1.drug8].ToString();
            cNhso1.drug9 = dt.Rows[0][cNhso1.drug9].ToString();
            cNhso1.drug10 = dt.Rows[0][cNhso1.drug10].ToString();
            cNhso1.drug11 = dt.Rows[0][cNhso1.drug11].ToString();
            cNhso1.drug12 = dt.Rows[0][cNhso1.drug12].ToString();
            cNhso1.drug13 = dt.Rows[0][cNhso1.drug13].ToString();
            cNhso1.drug14 = dt.Rows[0][cNhso1.drug14].ToString();
            cNhso1.drug15 = dt.Rows[0][cNhso1.drug15].ToString();
            cNhso1.drug16 = dt.Rows[0][cNhso1.drug16].ToString();
            cNhso1.drug17 = dt.Rows[0][cNhso1.drug17].ToString();
            cNhso1.drug18 = dt.Rows[0][cNhso1.drug18].ToString();
            cNhso1.drug19 = dt.Rows[0][cNhso1.drug19].ToString();
            cNhso1.drug20 = dt.Rows[0][cNhso1.drug20].ToString();
            cNhso1.drug21 = dt.Rows[0][cNhso1.drug21].ToString();
            cNhso1.drug22 = dt.Rows[0][cNhso1.drug22].ToString();
            cNhso1.drug23 = dt.Rows[0][cNhso1.drug23].ToString();
            cNhso1.drug24 = dt.Rows[0][cNhso1.drug24].ToString();
            cNhso1.drug25 = dt.Rows[0][cNhso1.drug25].ToString();
            cNhso1.drug26 = dt.Rows[0][cNhso1.drug26].ToString();
            cNhso1.drug27 = dt.Rows[0][cNhso1.drug27].ToString();
            cNhso1.drug28 = dt.Rows[0][cNhso1.drug28].ToString();
            cNhso1.drug29 = dt.Rows[0][cNhso1.drug29].ToString();
            cNhso1.drug30 = dt.Rows[0][cNhso1.drug30].ToString();

            cNhso1.hn = dt.Rows[0][cNhso1.hn].ToString();
            cNhso1.vn = dt.Rows[0][cNhso1.vn].ToString();
            cNhso1.labName1 = dt.Rows[0][cNhso1.labName1].ToString();
            cNhso1.labName2 = dt.Rows[0][cNhso1.labName2].ToString();
            cNhso1.labName10 = dt.Rows[0][cNhso1.labName10].ToString();
            cNhso1.labName3 = dt.Rows[0][cNhso1.labName3].ToString();
            cNhso1.labName4 = dt.Rows[0][cNhso1.labName4].ToString();
            cNhso1.labName5 = dt.Rows[0][cNhso1.labName5].ToString();
            cNhso1.labName6 = dt.Rows[0][cNhso1.labName6].ToString();
            cNhso1.labName7 = dt.Rows[0][cNhso1.labName7].ToString();
            cNhso1.labName8 = dt.Rows[0][cNhso1.labName8].ToString();
            cNhso1.labName9 = dt.Rows[0][cNhso1.labName9].ToString();
            cNhso1.labResult1 = dt.Rows[0][cNhso1.labResult1].ToString();
            cNhso1.labResult2 = dt.Rows[0][cNhso1.labResult2].ToString();
            cNhso1.labResult3 = dt.Rows[0][cNhso1.labResult3].ToString();
            cNhso1.labResult4 = dt.Rows[0][cNhso1.labResult4].ToString();
            cNhso1.labResult5 = dt.Rows[0][cNhso1.labResult5].ToString();
            cNhso1.labResult6 = dt.Rows[0][cNhso1.labResult6].ToString();
            cNhso1.labResult7 = dt.Rows[0][cNhso1.labResult7].ToString();
            cNhso1.labResult8 = dt.Rows[0][cNhso1.labResult8].ToString();
            cNhso1.labResult9 = dt.Rows[0][cNhso1.labResult9].ToString();
            cNhso1.labResult10 = dt.Rows[0][cNhso1.labResult10].ToString();
            cNhso1.labValue1 = dt.Rows[0][cNhso1.labValue1].ToString();
            cNhso1.labValue2 = dt.Rows[0][cNhso1.labValue2].ToString();
            cNhso1.labValue3 = dt.Rows[0][cNhso1.labValue3].ToString();
            cNhso1.labValue4 = dt.Rows[0][cNhso1.labValue4].ToString();
            cNhso1.labValue5 = dt.Rows[0][cNhso1.labValue5].ToString();
            cNhso1.labValue6 = dt.Rows[0][cNhso1.labValue6].ToString();
            cNhso1.labValue7 = dt.Rows[0][cNhso1.labValue7].ToString();
            cNhso1.labValue8 = dt.Rows[0][cNhso1.labValue8].ToString();
            cNhso1.labValue9 = dt.Rows[0][cNhso1.labValue9].ToString();
            cNhso1.labValue10 = dt.Rows[0][cNhso1.labValue10].ToString();

            cNhso1.editDia = dt.Rows[0][cNhso1.editDia].ToString();
            cNhso1.editDrug = dt.Rows[0][cNhso1.editDrug].ToString();
            cNhso1.branchID = dt.Rows[0][cNhso1.branchID].ToString();

            cNhso1.dia1Ori = dt.Rows[0][cNhso1.dia1Ori].ToString();
            cNhso1.dia2Ori = dt.Rows[0][cNhso1.dia2Ori].ToString();
            cNhso1.dia3Or1 = dt.Rows[0][cNhso1.dia3Or1].ToString();
            cNhso1.dia4Ori = dt.Rows[0][cNhso1.dia4Ori].ToString();
            cNhso1.dia5Ori = dt.Rows[0][cNhso1.dia5Ori].ToString();
            cNhso1.dia6Ori = dt.Rows[0][cNhso1.dia6Ori].ToString();
            cNhso1.dia7Ori = dt.Rows[0][cNhso1.dia7Ori].ToString();
            cNhso1.dia8Ori = dt.Rows[0][cNhso1.dia8Ori].ToString();
            cNhso1.dia9Ori = dt.Rows[0][cNhso1.dia9Ori].ToString();
            cNhso1.dia10Ori = dt.Rows[0][cNhso1.dia10Ori].ToString();
            //cNhso1.table = "checknhso";
            //cNhso1.cNhso1kField = "checknhso_id";
            cNhso1.rowEdit = "edit1";
            return cNhso1;
        }
        public DataRow setDataRow(DataTable dt, DataRow dr, int row)
        {
            dr[cNhso1.checknhsoId] = dt.Rows[row][cNhso1.checknhsoId].ToString();//yyyymmdd_rownumber
            dr[cNhso1.rowID] = dt.Rows[row][cNhso1.rowID].ToString();
            dr[cNhso1.patientName] = dt.Rows[row][cNhso1.patientName].ToString();
            dr[cNhso1.visitDate] = dt.Rows[row][cNhso1.visitDate].ToString();
            dr[cNhso1.visitTime] = dt.Rows[row][cNhso1.visitTime].ToString();

            dr[cNhso1.chronic1] = dt.Rows[row][cNhso1.chronic1].ToString();
            dr[cNhso1.chronic2] = dt.Rows[row][cNhso1.chronic2].ToString();
            dr[cNhso1.chronic3] = dt.Rows[row][cNhso1.chronic3].ToString();
            dr[cNhso1.chronic4] = dt.Rows[row][cNhso1.chronic4].ToString();
            dr[cNhso1.chronic5] = dt.Rows[row][cNhso1.chronic5].ToString();
            dr[cNhso1.chronic6] = dt.Rows[row][cNhso1.chronic6].ToString();
            dr[cNhso1.chronic7] = dt.Rows[row][cNhso1.chronic7].ToString();
            dr[cNhso1.chronic8] = dt.Rows[row][cNhso1.chronic8].ToString();
            dr[cNhso1.chronic9] = dt.Rows[row][cNhso1.chronic9].ToString();
            dr[cNhso1.chronic10] = dt.Rows[row][cNhso1.chronic10].ToString();

            dr[cNhso1.dia1] = dt.Rows[row][cNhso1.dia1].ToString();
            dr[cNhso1.dia2] = dt.Rows[row][cNhso1.dia2].ToString();
            dr[cNhso1.dia3] = dt.Rows[row][cNhso1.dia3].ToString();
            dr[cNhso1.dia4] = dt.Rows[row][cNhso1.dia4].ToString();
            dr[cNhso1.dia5] = dt.Rows[row][cNhso1.dia5].ToString();
            dr[cNhso1.dia6] = dt.Rows[row][cNhso1.dia6].ToString();
            dr[cNhso1.dia7] = dt.Rows[row][cNhso1.dia7].ToString();
            dr[cNhso1.dia8] = dt.Rows[row][cNhso1.dia8].ToString();
            dr[cNhso1.dia9] = dt.Rows[row][cNhso1.dia9].ToString();
            dr[cNhso1.dia10] = dt.Rows[row][cNhso1.dia10].ToString();

            dr[cNhso1.drug1] = dt.Rows[row][cNhso1.drug1].ToString();
            dr[cNhso1.drug2] = dt.Rows[row][cNhso1.drug2].ToString();
            dr[cNhso1.drug3] = dt.Rows[row][cNhso1.drug3].ToString();
            dr[cNhso1.drug4] = dt.Rows[row][cNhso1.drug4].ToString();
            dr[cNhso1.drug5] = dt.Rows[row][cNhso1.drug5].ToString();
            dr[cNhso1.drug6] = dt.Rows[row][cNhso1.drug6].ToString();
            dr[cNhso1.drug7] = dt.Rows[row][cNhso1.drug7].ToString();
            dr[cNhso1.drug8] = dt.Rows[row][cNhso1.drug8].ToString();
            dr[cNhso1.drug9] = dt.Rows[row][cNhso1.drug9].ToString();
            dr[cNhso1.drug10] = dt.Rows[row][cNhso1.drug10].ToString();
            dr[cNhso1.drug11] = dt.Rows[row][cNhso1.drug11].ToString();
            dr[cNhso1.drug12] = dt.Rows[row][cNhso1.drug12].ToString();
            dr[cNhso1.drug13] = dt.Rows[row][cNhso1.drug13].ToString();
            dr[cNhso1.drug14] = dt.Rows[row][cNhso1.drug14].ToString();
            dr[cNhso1.drug15] = dt.Rows[row][cNhso1.drug15].ToString();
            dr[cNhso1.drug16] = dt.Rows[row][cNhso1.drug16].ToString();
            dr[cNhso1.drug17] = dt.Rows[row][cNhso1.drug17].ToString();
            dr[cNhso1.drug18] = dt.Rows[row][cNhso1.drug18].ToString();
            dr[cNhso1.drug19] = dt.Rows[row][cNhso1.drug19].ToString();
            dr[cNhso1.drug20] = dt.Rows[row][cNhso1.drug20].ToString();
            dr[cNhso1.drug21] = dt.Rows[row][cNhso1.drug21].ToString();
            dr[cNhso1.drug22] = dt.Rows[row][cNhso1.drug22].ToString();
            dr[cNhso1.drug23] = dt.Rows[row][cNhso1.drug23].ToString();
            dr[cNhso1.drug24] = dt.Rows[row][cNhso1.drug24].ToString();
            dr[cNhso1.drug25] = dt.Rows[row][cNhso1.drug25].ToString();
            dr[cNhso1.drug26] = dt.Rows[row][cNhso1.drug26].ToString();
            dr[cNhso1.drug27] = dt.Rows[row][cNhso1.drug27].ToString();
            dr[cNhso1.drug28] = dt.Rows[row][cNhso1.drug28].ToString();
            dr[cNhso1.drug29] = dt.Rows[row][cNhso1.drug29].ToString();
            dr[cNhso1.drug30] = dt.Rows[row][cNhso1.drug30].ToString();

            dr[cNhso1.hn] = dt.Rows[row][cNhso1.hn].ToString();
            dr[cNhso1.vn] = dt.Rows[row][cNhso1.vn].ToString();
            dr[cNhso1.labName1] = dt.Rows[row][cNhso1.labName1].ToString();
            dr[cNhso1.labName2] = dt.Rows[row][cNhso1.labName2].ToString();
            dr[cNhso1.labName10] = dt.Rows[row][cNhso1.labName10].ToString();
            dr[cNhso1.labName3] = dt.Rows[row][cNhso1.labName3].ToString();
            dr[cNhso1.labName4] = dt.Rows[row][cNhso1.labName4].ToString();
            dr[cNhso1.labName5] = dt.Rows[row][cNhso1.labName5].ToString();
            dr[cNhso1.labName6] = dt.Rows[row][cNhso1.labName6].ToString();
            dr[cNhso1.labName7] = dt.Rows[row][cNhso1.labName7].ToString();
            dr[cNhso1.labName8] = dt.Rows[row][cNhso1.labName8].ToString();
            dr[cNhso1.labName9] = dt.Rows[row][cNhso1.labName9].ToString();
            dr[cNhso1.labResult1] = dt.Rows[row][cNhso1.labResult1].ToString();
            dr[cNhso1.labResult2] = dt.Rows[row][cNhso1.labResult2].ToString();
            dr[cNhso1.labResult3] = dt.Rows[row][cNhso1.labResult3].ToString();
            dr[cNhso1.labResult4] = dt.Rows[row][cNhso1.labResult4].ToString();
            dr[cNhso1.labResult5] = dt.Rows[row][cNhso1.labResult5].ToString();
            dr[cNhso1.labResult6] = dt.Rows[row][cNhso1.labResult6].ToString();
            dr[cNhso1.labResult7] = dt.Rows[row][cNhso1.labResult7].ToString();
            dr[cNhso1.labResult8] = dt.Rows[row][cNhso1.labResult8].ToString();
            dr[cNhso1.labResult9] = dt.Rows[row][cNhso1.labResult9].ToString();
            dr[cNhso1.labResult10] = dt.Rows[row][cNhso1.labResult10].ToString();
            dr[cNhso1.labValue1] = dt.Rows[row][cNhso1.labValue1].ToString();
            dr[cNhso1.labValue2] = dt.Rows[row][cNhso1.labValue2].ToString();
            dr[cNhso1.labValue3] = dt.Rows[row][cNhso1.labValue3].ToString();
            dr[cNhso1.labValue4] = dt.Rows[row][cNhso1.labValue4].ToString();
            dr[cNhso1.labValue5] = dt.Rows[row][cNhso1.labValue5].ToString();
            dr[cNhso1.labValue6] = dt.Rows[row][cNhso1.labValue6].ToString();
            dr[cNhso1.labValue7] = dt.Rows[row][cNhso1.labValue7].ToString();
            dr[cNhso1.labValue8] = dt.Rows[row][cNhso1.labValue8].ToString();
            dr[cNhso1.labValue9] = dt.Rows[row][cNhso1.labValue9].ToString();
            dr[cNhso1.labValue10] = dt.Rows[row][cNhso1.labValue10].ToString();

            dr[cNhso1.editDia] = dt.Rows[row][cNhso1.editDia].ToString();
            dr[cNhso1.editDrug] = dt.Rows[row][cNhso1.editDrug].ToString();
            dr[cNhso1.branchID] = dt.Rows[row][cNhso1.branchID].ToString();

            dr[cNhso1.dia1Ori] = dt.Rows[row][cNhso1.dia1Ori].ToString();
            dr[cNhso1.dia2Ori] = dt.Rows[row][cNhso1.dia2Ori].ToString();
            dr[cNhso1.dia3Or1] = dt.Rows[row][cNhso1.dia3Or1].ToString();
            dr[cNhso1.dia4Ori] = dt.Rows[row][cNhso1.dia4Ori].ToString();
            dr[cNhso1.dia5Ori] = dt.Rows[row][cNhso1.dia5Ori].ToString();
            dr[cNhso1.dia6Ori] = dt.Rows[row][cNhso1.dia6Ori].ToString();
            dr[cNhso1.dia7Ori] = dt.Rows[row][cNhso1.dia7Ori].ToString();
            dr[cNhso1.dia8Ori] = dt.Rows[row][cNhso1.dia8Ori].ToString();
            dr[cNhso1.dia9Ori] = dt.Rows[row][cNhso1.dia9Ori].ToString();
            dr[cNhso1.dia10Ori] = dt.Rows[row][cNhso1.dia10Ori].ToString();
            //cNhso1.table = "checknhso";
            //cNhso1.cNhso1kField = "checknhso_id";
            dr[cNhso1.rowEdit] = "edit1";
            return dr;
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
        private String update(CheckNhso1 cNhso1)
        {
            String sql = "", chk = "";

            cNhso1.patientName = cNhso1.patientName.Replace("'", "''");
            cNhso1.dia1 = cNhso1.dia1.Replace("'", "''");


            sql = "UcNhso1date " + cNhso1.table + " Set " + cNhso1.patientName + "='" + cNhso1.patientName + "'," +
                cNhso1.hn + "='" + cNhso1.hn + "', " +
                cNhso1.vn + "='" + cNhso1.vn + "', " +
                cNhso1.visitDate + "='" + cNhso1.visitDate + "', " +
                cNhso1.visitTime + "='" + cNhso1.visitTime + "', " +
                //cNhso1.rowID + "='" + cNhso1.rowID + "', " +
                cNhso1.chronic1 + "='" + cNhso1.chronic1 + "', " +
                cNhso1.chronic2 + "='" + cNhso1.chronic2 + "', " +
                cNhso1.chronic3 + "='" + cNhso1.chronic3 + "', " +
                cNhso1.chronic4 + "='" + cNhso1.chronic4 + "', " +
                cNhso1.chronic5 + "='" + cNhso1.chronic5 + "', " +
                cNhso1.chronic6 + "='" + cNhso1.chronic6 + "', " +
                cNhso1.chronic7 + "='" + cNhso1.chronic7 + "', " +
                cNhso1.chronic8 + "='" + cNhso1.chronic8 + "', " +
                cNhso1.chronic9 + "='" + cNhso1.chronic9 + "', " +
                cNhso1.chronic10 + "='" + cNhso1.chronic10 + "', " +
                cNhso1.dia1 + "='" + cNhso1.dia1 + "', " +
                cNhso1.dia2 + "='" + cNhso1.dia2 + "', " +
                cNhso1.dia3 + "='" + cNhso1.dia3 + "', " +
                cNhso1.dia4 + "='" + cNhso1.dia4 + "', " +
                cNhso1.dia5 + "='" + cNhso1.dia5 + "', " +
                cNhso1.dia6 + "='" + cNhso1.dia6 + "', " +
                cNhso1.dia7 + "='" + cNhso1.dia7 + "', " +
                cNhso1.dia8 + "='" + cNhso1.dia8 + "', " +
                cNhso1.dia9 + "='" + cNhso1.dia9 + "', " +
                cNhso1.dia10 + "='" + cNhso1.dia10 + "', " +
                cNhso1.drug1 + "='" + cNhso1.drug1 + "', " +
                cNhso1.drug2 + "='" + cNhso1.drug2 + "', " +
                cNhso1.drug3 + "='" + cNhso1.drug3 + "', " +
                cNhso1.drug4 + "='" + cNhso1.drug4 + "', " +
                cNhso1.drug5 + "='" + cNhso1.drug5 + "', " +
                cNhso1.drug6 + "='" + cNhso1.drug6 + "', " +
                cNhso1.drug7 + "='" + cNhso1.drug7 + "', " +
                cNhso1.drug8 + "='" + cNhso1.drug8 + "', " +
                cNhso1.drug9 + "='" + cNhso1.drug9 + "', " +
                cNhso1.drug10 + "='" + cNhso1.drug10 + "', " +
                cNhso1.drug11 + "='" + cNhso1.drug11 + "', " +
                cNhso1.drug12 + "='" + cNhso1.drug12 + "', " +
                cNhso1.drug13 + "='" + cNhso1.drug13 + "', " +
                cNhso1.drug14 + "='" + cNhso1.drug14 + "', " +
                cNhso1.drug15 + "='" + cNhso1.drug15 + "', " +
                cNhso1.drug16 + "='" + cNhso1.drug16 + "', " +
                cNhso1.drug17 + "='" + cNhso1.drug17 + "', " +
                cNhso1.drug18 + "='" + cNhso1.drug18 + "', " +
                cNhso1.drug19 + "='" + cNhso1.drug19 + "', " +
                cNhso1.drug20 + "='" + cNhso1.drug20 + "', " +
                cNhso1.drug21 + "='" + cNhso1.drug21 + "', " +
                cNhso1.drug22 + "='" + cNhso1.drug22 + "', " +
                cNhso1.drug23 + "='" + cNhso1.drug23 + "', " +
                cNhso1.drug24 + "='" + cNhso1.drug24 + "', " +
                cNhso1.drug25 + "='" + cNhso1.drug25 + "', " +
                cNhso1.drug26 + "='" + cNhso1.drug26 + "', " +
                cNhso1.drug27 + "='" + cNhso1.drug27 + "', " +
                cNhso1.drug28 + "='" + cNhso1.drug28 + "', " +
                cNhso1.drug29 + "='" + cNhso1.drug29 + "', " +
                cNhso1.drug30 + "='" + cNhso1.drug30 + "', " +
                cNhso1.labName1 + "='" + cNhso1.labName1 + "', " +
                cNhso1.labResult1 + "='" + cNhso1.labResult1 + "', " +
                cNhso1.labValue1 + "='" + cNhso1.labValue1 + "', " +
                cNhso1.labName2 + "='" + cNhso1.labName2 + "', " +
                cNhso1.labResult2 + "='" + cNhso1.labResult2 + "', " +
                cNhso1.labValue2 + "='" + cNhso1.labValue2 + "', " +
                cNhso1.labName3 + "='" + cNhso1.labName3 + "', " +
                cNhso1.labResult3 + "='" + cNhso1.labResult3 + "', " +
                cNhso1.labValue3 + "='" + cNhso1.labValue3 + "', " +
                cNhso1.labName4 + "='" + cNhso1.labName4 + "', " +
                cNhso1.labResult4 + "='" + cNhso1.labResult4 + "', " +
                cNhso1.labValue4 + "='" + cNhso1.labValue4 + "', " +
                cNhso1.labName5 + "='" + cNhso1.labName5 + "', " +
                cNhso1.labResult5 + "='" + cNhso1.labResult5 + "', " +
                cNhso1.labName6 + "='" + cNhso1.labName6 + "', " +
                cNhso1.labResult6 + "='" + cNhso1.labResult6 + "', " +
                cNhso1.labValue6 + "='" + cNhso1.labValue6 + "', " +
                cNhso1.labName7 + "='" + cNhso1.labName7 + "', " +
                cNhso1.labResult7 + "='" + cNhso1.labResult7 + "', " +
                cNhso1.labValue7 + "='" + cNhso1.labValue7 + "', " +
                cNhso1.labName8 + "='" + cNhso1.labName8 + "', " +
                cNhso1.labResult8 + "='" + cNhso1.labResult8 + "', " +
                cNhso1.labValue8 + "='" + cNhso1.labValue8 + "', " +
                cNhso1.labName9 + "='" + cNhso1.labName9 + "', " +
                cNhso1.labResult9 + "='" + cNhso1.labResult9 + "', " +
                cNhso1.labValue9 + "='" + cNhso1.labValue9 + "', " +
                cNhso1.labName10 + "='" + cNhso1.labName10 + "', " +
                cNhso1.labResult10 + "='" + cNhso1.labResult10 + "', " +
                cNhso1.labValue10 + "='" + cNhso1.labValue10 + "', " +
                cNhso1.editDrug + "='" + cNhso1.editDrug + "', " +
                cNhso1.editDia + "='" + cNhso1.editDia + "' " +
                "Where " + cNhso1.pkField + "='" + cNhso1.checknhsoId + "'";
            try
            {
                chk = connBua.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "ucNhso1date CheckNhso1");
            }
            finally
            {
            }
            return chk;
        }
        private String insert(CheckNhso1 cNhso1, ConnectDB c, String client)
        {
            String sql = "", chk = "";
            if (cNhso1.checknhsoId.Equals(""))
            {
                cNhso1.checknhsoId = cNhso1.visitDate.Replace("-","")+cNhso1.visitTime+cNhso1.rowID;
            }
            try
            {
                cNhso1.dia1Ori = cNhso1.dia1;
                cNhso1.dia2Ori = cNhso1.dia2;
                cNhso1.dia3Or1 = cNhso1.dia3;
                cNhso1.dia4Ori = cNhso1.dia4;
                cNhso1.dia5Ori = cNhso1.dia5;
                cNhso1.dia6Ori = cNhso1.dia6;
                cNhso1.dia7Ori = cNhso1.dia7;
                cNhso1.dia8Ori = cNhso1.dia8;
                cNhso1.dia9Ori = cNhso1.dia9;
                cNhso1.dia10Ori = cNhso1.dia10;
                if (cNhso1.checknhsoId.Length > 3)
                {
                    cNhso1.branchID = cNhso1.checknhsoId.Substring(0, 3);
                }
                else
                {
                    cNhso1.branchID = conn.server;
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
                    "Values " + cNhso1.table + " ('" + cNhso1.checknhsoId + "','" + cNhso1.patientName + "','" + cNhso1.hn + "','" +
                    cNhso1.vn + "','" + cNhso1.visitDate + "','" + cNhso1.visitTime + "','" +
                    cNhso1.rowID + "','" + cNhso1.chronic1 + "','" + cNhso1.chronic2 + "','" +
                    cNhso1.chronic3 + "','" + cNhso1.chronic4 + "','" + cNhso1.chronic5 + "','" +
                    cNhso1.chronic6 + "','" + cNhso1.chronic7 + "','" + cNhso1.chronic8 + "','" +
                    cNhso1.chronic9 + "','" + cNhso1.chronic10 + "','" + cNhso1.dia1 + "','" +
                    cNhso1.dia2 + "','" + cNhso1.dia3 + "','" + cNhso1.dia4 + "','" +
                    cNhso1.dia5 + "','" + cNhso1.dia6 + "','" + cNhso1.dia7 + "','" +
                    cNhso1.dia8 + "','" + cNhso1.dia9+ "','" + cNhso1.dia10 + "','" +
                    cNhso1.drug1 + "','" + cNhso1.drug2 + "','" +
                    cNhso1.drug3 + "','" + cNhso1.drug4 + "','" + cNhso1.drug5 + "','" +
                    cNhso1.drug6 + "','" + cNhso1.drug7 + "','" + cNhso1.drug8 + "','" +
                    cNhso1.drug9 + "','" + cNhso1.drug10 + "','" + cNhso1.drug11 + "','" +
                    cNhso1.drug12 + "','" + cNhso1.drug13 + "','" + cNhso1.drug14 + "','" +
                    cNhso1.drug15 + "','" + cNhso1.drug16 + "','" + cNhso1.drug17 + "','" +
                    cNhso1.drug18 + "','" + cNhso1.drug19 + "','" + cNhso1.drug20 + "','" +
                    cNhso1.drug21 + "','" + cNhso1.drug22 + "','" + cNhso1.drug23 + "','" + 
                    cNhso1.drug24 + "','" + cNhso1.drug25 + "','" + cNhso1.drug26 + "','" + 
                    cNhso1.drug27 + "','" + cNhso1.drug28 + "','" + cNhso1.drug29 + "','" + 
                    cNhso1.drug30 + "','" +
                    cNhso1.labName1 + "','" + cNhso1.labResult1 + "','" + cNhso1.labValue1 + "','" +
                    cNhso1.labName2 + "','" + cNhso1.labResult2 + "','" + cNhso1.labValue2 + "','" +
                    cNhso1.labName3 + "','" + cNhso1.labResult3 + "','" + cNhso1.labValue3 + "','" +
                    cNhso1.labName4 + "','" + cNhso1.labResult4 + "','" + cNhso1.labValue4 + "','" +
                    cNhso1.labName5 + "','" + cNhso1.labResult5 + "','" + cNhso1.labValue5 + "','" +
                    cNhso1.labName6 + "','" + cNhso1.labResult6 + "','" + cNhso1.labValue6 + "','" +
                    cNhso1.labName7 + "','" + cNhso1.labResult7 + "','" + cNhso1.labValue7 + "','" +
                    cNhso1.labName8 + "','" + cNhso1.labResult8 + "','" + cNhso1.labValue8 + "','" +
                    cNhso1.labName9 + "','" + cNhso1.labResult9 + "','" + cNhso1.labValue9 + "','" +
                    cNhso1.labName10 + "','" + cNhso1.labResult10 + "','" + cNhso1.labValue10+"','"+
                    cNhso1.rowEdit + "','" + cNhso1.editDia + "','" + cNhso1.editDrug +"','"+
                    cNhso1.statusActive+"','"+cNhso1.branchID+"','"+cNhso1.dia1Ori+"','"+
                    cNhso1.dia2Ori+"','"+cNhso1.dia3Or1+"','"+cNhso1.dia4Ori+"','"+
                    cNhso1.dia5Ori + "','" + cNhso1.dia6Ori + "','" + cNhso1.dia7Ori + "','" +
                    cNhso1.dia8Ori + "','" + cNhso1.dia9Ori + "','" + cNhso1.dia10Ori +
                    "') ";
                chk = c.ExecuteNonQuery(sql);
                chk = cNhso1.checknhsoId;
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
        //cNhso1ublic String insertCheckNhsoClient(CheckNhso1 cNhso1)
        //{

        //}
        public String insertCHeckNhso(CheckNhso1 cNhso1, Boolean isBranch)
        {
            CheckNhso1 item = new CheckNhso1();
            String chk = "";
            item = selectByPk(cNhso1.checknhsoId);
            if (item.checknhsoId == "")
            {
                //cNhso1.statusDecNhso1osit = "0";
                //cNhso1.statusReccNhso1 = "1";
                if (isBranch)
                {
                    chk = insert(cNhso1, connClient,"_client");
                }
                else
                {
                    chk = insert(cNhso1, connBua,"");
                }
                //chk = insert(cNhso1);
            }
            else
            {
                chk = update(cNhso1);
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
            sql = "Select "+cNhso1.visitDate+", count(1) as cnt, "+cNhso1.branchID+" From "+cNhso1.table+"_client GroucNhso1 By "+cNhso1.visitDate+","+cNhso1.branchID;
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
                        //labWhere = " ((" + visitDateWhere + " and " + cNhso1.labName1 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue1 + ")=1 Then Convert(float," + cNhso1.labValue1 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        //+ " ((" + visitDateWhere + " and " + cNhso1.labName2 + " like '" + labId + "%') and cast(" + cNhso1.labValue2 + " as float)  between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        //+ " ((" + visitDateWhere + " and " + cNhso1.labName3 + " like '" + labId + "%') and cast(" + cNhso1.labValue3 + " as float) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        //+ " ((" + visitDateWhere + " and " + cNhso1.labName4 + " like '" + labId + "%') and cast(" + cNhso1.labValue4 + " as float) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        //+ " ((" + visitDateWhere + " and " + cNhso1.labName5 + " like '" + labId + "%') and cast(" + cNhso1.labValue5 + " as float) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        //+ " ((" + visitDateWhere + " and " + cNhso1.labName6 + " like '" + labId + "%') and cast(" + cNhso1.labValue6 + " as float) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        //+ " ((" + visitDateWhere + " and " + cNhso1.labName7 + " like '" + labId + "%') and cast(" + cNhso1.labValue7 + " as float) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        //+ " ((" + visitDateWhere + " and " + cNhso1.labName8 + " like '" + labId + "%') and cast(" + cNhso1.labValue8 + " as float) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        //+ " ((" + visitDateWhere + " and " + cNhso1.labName9 + " like '" + labId + "%') and cast(" + cNhso1.labValue9 + " as float) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        //+ " ((" + visitDateWhere + " and " + cNhso1.labName10 + " like '" + labId + "%') and cast(" + cNhso1.labValue10 + " as float) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float))  ";

                        labWhere = " ((" + visitDateWhere + " and " + cNhso1.labName1 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue1 + ")=1 Then Convert(float," + cNhso1.labValue1 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName2 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue2 + ")=1 Then Convert(float," + cNhso1.labValue2 + ") else NULL end)  between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName3 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue3 + ")=1 Then Convert(float," + cNhso1.labValue3 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName4 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue4 + ")=1 Then Convert(float," + cNhso1.labValue4 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName5 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue5 + ")=1 Then Convert(float," + cNhso1.labValue5 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName6 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue6 + ")=1 Then Convert(float," + cNhso1.labValue6 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName7 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue7 + ")=1 Then Convert(float," + cNhso1.labValue7 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName8 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue8 + ")=1 Then Convert(float," + cNhso1.labValue8 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName9 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue9 + ")=1 Then Convert(float," + cNhso1.labValue9 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + cNhso1.labName10 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue10 + ")=1 Then Convert(float," + cNhso1.labValue10 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float))  ";
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
            //select cNhso1ATIENT_T01.MNC_HN_NO,cNhso1ATIENT_T01.MNC_cNhso1RE_NO,
            //cNhso1ATIENT_T01.MNC_DATE,cNhso1ATIENT_T01.MNC_TIME,
            //cNhso1atient_t09.MNC_DIA_CD,
            //cNhso1ATIENT_T09_1.CHRONICCODE,
            //cNhso1HARMACY_T06.MNC_cNhso1H_CD,
            //cNhso1harmacy_m01.MNC_cNhso1H_TN

            //from cNhso1ATIENT_T01

            //left join cNhso1ATIENT_T09_1 on cNhso1atient_t01.MNC_ID_NAM = cNhso1ATIENT_T09_1.MNC_IDNUM
            //left join cNhso1ATIENT_T09 on cNhso1atient_t01.MNC_cNhso1RE_NO =cNhso1atient_t09.MNC_cNhso1RE_NO and
            //cNhso1atient_t01.MNC_date =cNhso1atient_t09.MNC_date
            //left join cNhso1atient_m18 on cNhso1atient_t09.MNC_DIA_CD = cNhso1atient_m18 .MNC_DIA_CD
            //left join cNhso1HARMACY_T05 on cNhso1atient_t01.MNC_cNhso1RE_NO = cNhso1HARMACY_T05.MNC_cNhso1RE_NO and
            //cNhso1atient_t01.MNC_date = cNhso1HARMACY_T05.mnc_date
            //left join cNhso1HARMACY_T06 on cNhso1harmacy_t05.MNC_CFR_NO = cNhso1harmacy_t06.MNC_CFR_NO and
            //cNhso1harmacy_t05.MNC_CFG_DAT = cNhso1harmacy_t06.MNC_CFR_dat
            //left join cNhso1HARMACY_M01 on cNhso1harmacy_t06.MNC_cNhso1H_CD = cNhso1harmacy_m01.MNC_cNhso1H_CD

            //where cNhso1ATIENT_T01.MNC_DATE BETWEEN '01/01/2014' AND '01/01/2014'

            //and cNhso1atient_t01.MNC_FN_TYcNhso1_CD in ('44','45','46','47','48','49')
 
            //order by cNhso1ATIENT_T01.MNC_HN_NO

            String sql = "";
            DataTable dt = new DataTable();
            if (chkDrug.Equals("1")) // drug only
            {
                String[] lab1;
                String labWhere = "", labFrom = "", drugWhere="", drugFrom="";
                if (!labSearch1.Equals(""))
                {
                    labFrom = "inner join LAB_T01 ON t01.MNC_cNhso1RE_NO = LAB_T01.MNC_cNhso1RE_NO AND t01.MNC_DATE = LAB_T01.MNC_DATE " +
                "inner join LAB_T05 ON LAB_T01.MNC_REQ_NO = LAB_T05.MNC_REQ_NO AND LAB_T01.MNC_REQ_DAT = LAB_T05.MNC_REQ_DAT ";
                    if (!labSearch2.Equals(""))
                    {
                        //lab1 = labSearch1.ScNhso1lit(new char[] { ',' });
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
                        labFrom = "inner join LAB_T01 ON t01.MNC_cNhso1RE_NO = LAB_T01.MNC_cNhso1RE_NO AND t01.MNC_DATE = LAB_T01.MNC_DATE " +
                "inner join LAB_T05 ON LAB_T01.MNC_REQ_NO = LAB_T05.MNC_REQ_NO AND LAB_T01.MNC_REQ_DAT = LAB_T05.MNC_REQ_DAT ";
                    }
                    labWhere += " and lab_t05.mnc_lb_cd = '" + labId + "' ";
                }
                
                if (!drugSearch.Equals(""))
                {
                        drugFrom = "inner join cNhso1HARMACY_T05 cNhso1hart05 on t01.MNC_cNhso1RE_NO = cNhso1hart05.MNC_cNhso1RE_NO and t01.mnc_hn_no = cNhso1hart05.mnc_hn_no " +
                "and t01.mnc_hn_yr = cNhso1hart05.mnc_hn_yr " +
                            "inner join cNhso1HARMACY_T06 cNhso1hart06 on cNhso1hart05.MNC_CFR_NO = cNhso1hart06.MNC_CFR_NO and cNhso1hart05.MNC_CFG_DAT = cNhso1hart06.MNC_CFR_dat " +
                "inner join cNhso1HARMACY_M01 on cNhso1hart06.MNC_cNhso1H_CD = cNhso1harmacy_m01.MNC_cNhso1H_CD ";
                        drugWhere = "and cNhso1harmacy_m01.mnc_cNhso1h_tn like '" + drugSearch + "%' ";
                    }
                sql = "Select distinct t01.MNC_HN_NO,t01.MNC_cNhso1RE_NO, t01.MNC_DATE,t01.MNC_TIME, " +
                            //"t09.MNC_DIA_CD,t091.CHRONICCODE, " +
                "m01.mnc_fname_t, mnc_lname_t, m02.mnc_cNhso1fix_dsc, t01.mnc_vn_no, t01.mnc_vn_seq, t01.mnc_vn_sum " +
                " from cNhso1ATIENT_T01 t01 " +
                "Left Join cNhso1atient_m01 m01 on m01.mnc_hn_no = t01.mnc_hn_no " +
                "Left Join cNhso1atient_m02 m02 on m01.mnc_cNhso1fix_cdt = m02.mnc_cNhso1fix_cd " +
                drugFrom + labFrom +
                            //"left join cNhso1ATIENT_T09 t09 on t01.MNC_cNhso1RE_NO = t09.MNC_cNhso1RE_NO and t01.MNC_date = t09.MNC_date " +
                "where t01.MNC_DATE BETWEEN '" + dateStart + "' AND '" + dateEnd + "' " +
                "and t01.MNC_FN_TYcNhso1_CD in ('44','45','46','47','48','49') " +
                drugWhere + labWhere +
                "Order by t01.MNC_HN_NO";
               
            }
            else
            {
                sql = "Select t01.MNC_HN_NO,t01.MNC_cNhso1RE_NO, t01.MNC_DATE,t01.MNC_TIME, " +
                    //"t09.MNC_DIA_CD,t091.CHRONICCODE, " +
                "m01.mnc_fname_t, mnc_lname_t, m02.mnc_cNhso1fix_dsc, t01.mnc_vn_no, t01.mnc_vn_seq, t01.mnc_vn_sum " +
                " from cNhso1ATIENT_T01 t01 " +
                "Left Join cNhso1atient_m01 m01 on m01.mnc_hn_no = t01.mnc_hn_no " +
                "Left Join cNhso1atient_m02 m02 on m01.mnc_cNhso1fix_cdt = m02.mnc_cNhso1fix_cd " +
                    //"left join cNhso1ATIENT_T09_1 t091 on t01.MNC_ID_NAM = t091.MNC_IDNUM " +
                    //"left join cNhso1ATIENT_T09 t09 on t01.MNC_cNhso1RE_NO = t09.MNC_cNhso1RE_NO and t01.MNC_date = t09.MNC_date " +
                "where t01.MNC_DATE BETWEEN '" + dateStart + "' AND '" + dateEnd + "' " +
                "and t01.MNC_FN_TYcNhso1_CD in ('44','45','46','47','48','49') " +
                "and t01.mnc_hn_no = '2179721 ' "+
                "Order by t01.MNC_HN_NO";
            }
            
            dt = conn.selectData(sql);
            return dt;
        }
        public DataTable selectDiaCDbyVN(String dateStart, String dateEnd, String hn, String vn, String cNhso1reNo)
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select t09.MNC_DIA_CD " +
                "From cNhso1ATIENT_T01 t01 " +
                "left join cNhso1ATIENT_T09 t09 on t01.MNC_cNhso1RE_NO = t09.MNC_cNhso1RE_NO and t01.MNC_date = t09.MNC_date " +
                "where t01.MNC_DATE BETWEEN '" + dateStart + "' AND '" + dateEnd + "' " +
                "and t01.MNC_FN_TYcNhso1_CD in ('44','45','46','47','48','49') " + " and t01.mnc_hn_no = '" + hn + "' " +
                "and t01.mnc_vn_no = '" + vn + "'"+
                "and t01.mnc_cNhso1re_no = '" + cNhso1reNo + "'";
                //"Order By t01.mnc_date, t01.mnc_hn_no ";
            dt = conn.selectData(sql);
            return dt;
        }
        public DataTable selectChronicbyVN(String dateStart, String dateEnd, String hn, String vn, String cNhso1reNo)
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select t091.chroniccode " +
                "From cNhso1ATIENT_T01 t01 " +
                "left join cNhso1ATIENT_T09_1 t091 on t01.MNC_ID_NAM = t091.MNC_IDNUM " +
                "where t01.MNC_DATE BETWEEN '" + dateStart + "' AND '" + dateEnd + "' " +
                "and t01.MNC_FN_TYcNhso1_CD in ('44','45','46','47','48','49') " + " and t01.mnc_hn_no = '" + hn + "' " +
                "and t01.mnc_vn_no = '"+vn+"' "+
                "and t01.mnc_cNhso1re_no = '" + cNhso1reNo + "'";
            dt = conn.selectData(sql);
            return dt;
        }
        public DataTable selectDrugbyVN(String dateStart, String dateEnd, String hn, String vn, String cNhso1reNo)
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select cNhso1hart06.MNC_cNhso1H_CD, cNhso1harmacy_m01.MNC_cNhso1H_TN " +
                "From cNhso1ATIENT_T01 t01 " +
                "left join cNhso1HARMACY_T05 cNhso1hart05 on t01.MNC_cNhso1RE_NO = cNhso1hart05.MNC_cNhso1RE_NO and t01.MNC_date = cNhso1hart05.mnc_date " +
                "left join cNhso1HARMACY_T06 cNhso1hart06 on cNhso1hart05.MNC_CFR_NO = cNhso1hart06.MNC_CFR_NO and cNhso1hart05.MNC_CFG_DAT = cNhso1hart06.MNC_CFR_dat " +
                "left join cNhso1HARMACY_M01 on cNhso1hart06.MNC_cNhso1H_CD = cNhso1harmacy_m01.MNC_cNhso1H_CD " +
                "where t01.MNC_DATE BETWEEN '" + dateStart + "' AND '" + dateEnd + "' " +
                "and t01.MNC_FN_TYcNhso1_CD in ('44','45','46','47','48','49') " + " and t01.mnc_hn_no = '" + hn + "' " +
                "and t01.mnc_vn_no = '" + vn + "' and cNhso1HARMACY_M01.mnc_cNhso1h_tycNhso1_flg = 'cNhso1' "+
                "and t01.mnc_cNhso1re_no = '" + cNhso1reNo + "'";
            dt = conn.selectData(sql);
            return dt;
        }
        public DataTable selectLabbyVN(String dateStart, String dateEnd, String hn, String vn, String cNhso1reNo)
        {
            //select cNhso1ATIENT_T01.MNC_HN_NO,cNhso1ATIENT_T01.MNC_cNhso1RE_NO,
            //cNhso1ATIENT_T01.MNC_DATE,cNhso1ATIENT_T01.MNC_TIME,
            //cNhso1atient_t09.MNC_DIA_CD,
            //cNhso1ATIENT_T09_1.CHRONICCODE,
            //cNhso1HARMACY_T06.MNC_cNhso1H_CD,
            //cNhso1harmacy_m01.MNC_cNhso1H_TN,
            //lab_t05.MNC_LB_CD,lab_m01.MNC_LB_DSC,
            //lab_t05.MNC_RES_VALUE,
            //lab_t05.MNC_STS
            //from cNhso1ATIENT_T01
            //left join cNhso1ATIENT_T09_1 on cNhso1atient_t01.MNC_ID_NAM = cNhso1ATIENT_T09_1.MNC_IDNUM
            //left join cNhso1ATIENT_T09 on cNhso1atient_t01.MNC_cNhso1RE_NO =cNhso1atient_t09.MNC_cNhso1RE_NO and
            //cNhso1atient_t01.MNC_date =cNhso1atient_t09.MNC_date
            //left join cNhso1atient_m18 on cNhso1atient_t09.MNC_DIA_CD = cNhso1atient_m18 .MNC_DIA_CD
            //left join cNhso1HARMACY_T05 on cNhso1atient_t01.MNC_cNhso1RE_NO = cNhso1HARMACY_T05.MNC_cNhso1RE_NO and
            //cNhso1atient_t01.MNC_date = cNhso1HARMACY_T05.mnc_date
            //left join cNhso1HARMACY_T06 on cNhso1harmacy_t05.MNC_CFR_NO = cNhso1harmacy_t06.MNC_CFR_NO and
            //cNhso1harmacy_t05.MNC_CFG_DAT = cNhso1harmacy_t06.MNC_CFR_dat
            //left join cNhso1HARMACY_M01 on cNhso1harmacy_t06.MNC_cNhso1H_CD = cNhso1harmacy_m01.MNC_cNhso1H_CD
            //left join LAB_T01 on  cNhso1atient_t01.MNC_cNhso1RE_NO = lab_t01.MNC_cNhso1RE_NO and
            //cNhso1atient_t01.MNC_date = LAB_T01.mnc_date
            //left join LAB_T05 on lab_t01.MNC_REQ_NO = lab_t05.MNC_REQ_NO and
            //lab_t01.MNC_REQ_DAT = lab_t05.MNC_REQ_DAT
            //left join LAB_M01 on lab_t05.MNC_LB_CD = lab_m01.MNC_LB_CD
            //where cNhso1ATIENT_T01.MNC_DATE BETWEEN '03/02/2014' AND '03/02/2014'
            //and cNhso1atient_t01.MNC_FN_TYcNhso1_CD in ('44','45','46','47','48','49')
            //and lab_t05.MNC_LB_CD in ('ch002','ch250','ch003','ch004','ch040','ch037','ch039','ch036','ch038',
            //'se005','se038','se047','ch006','ch007','ch008','ch009','se165') 
            //order by cNhso1ATIENT_T01.MNC_HN_NO


//            SELECT LAB_T05.MNC_LB_CD, LAB_M01.MNC_LB_DSC, LAB_T05.MNC_RES_VALUE, LAB_T05.MNC_STS, LAB_T05.MNC_REQ_YR, LAB_T05.MNC_REQ_NO, LAB_T05.MNC_REQ_DAT, LAB_T05.MNC_LB_CD AS ExcNhso1r1, 
//                  LAB_T05.MNC_LB_RES_CD, LAB_T05.MNC_RES, LAB_T05.MNC_RES_VALUE AS ExcNhso1r2, LAB_T05.MNC_LB_USR, LAB_T05.MNC_STS AS ExcNhso1r3, LAB_T05.MNC_RES_MIN, LAB_T05.MNC_RES_MAX, 
//                  LAB_T05.MNC_LB_RES, LAB_T05.MNC_RES_UNT, LAB_T05.MNC_LB_ACT, LAB_T05.MNC_STAMcNhso1_DAT, LAB_T05.MNC_STAMcNhso1_TIM, LAB_T05.MNC_LAB_cNhso1RN
//FROM     cNhso1ATIENT_T01 AS t01 LEFT OUTER JOIN
//                  LAB_T01 ON t01.MNC_cNhso1RE_NO = LAB_T01.MNC_cNhso1RE_NO AND t01.MNC_DATE = LAB_T01.MNC_DATE LEFT OUTER JOIN
//                  LAB_T05 ON LAB_T01.MNC_REQ_NO = LAB_T05.MNC_REQ_NO AND LAB_T01.MNC_REQ_DAT = LAB_T05.MNC_REQ_DAT LEFT OUTER JOIN
//                  LAB_M01 ON LAB_T05.MNC_LB_CD = LAB_M01.MNC_LB_CD
//WHERE  (t01.MNC_DATE BETWEEN '2014-03-31' AND '2014-03-31') AND (t01.MNC_FN_TYcNhso1_CD IN ('44', '45', '46', '47', '48', '49')) AND (t01.MNC_HN_NO = '5077727') AND (LAB_T05.MNC_LB_CD IN ('ch002', 'ch250', 'ch003', 'ch004', 
//                  'ch040', 'ch037', 'ch039', 'ch036', 'ch038', 'se005', 'se038', 'se047', 'ch006', 'ch007', 'ch008', 'ch009', 'se165'))


            String sql = "";
            DataTable dt = new DataTable();
            sql = "SELECT distinct LAB_T05.MNC_LB_CD, LAB_M01.MNC_LB_DSC, LAB_T05.MNC_RES_VALUE, LAB_T05.MNC_STS " +
                "FROM     cNhso1ATIENT_T01 t01 " +
                "left join LAB_T01 ON t01.MNC_cNhso1RE_NO = LAB_T01.MNC_cNhso1RE_NO AND t01.MNC_DATE = LAB_T01.MNC_DATE " +
                "left join LAB_T05 ON LAB_T01.MNC_REQ_NO = LAB_T05.MNC_REQ_NO AND LAB_T01.MNC_REQ_DAT = LAB_T05.MNC_REQ_DAT " +
                "left join LAB_M01 ON LAB_T05.MNC_LB_CD = LAB_M01.MNC_LB_CD " +
                "where t01.MNC_DATE BETWEEN '" + dateStart + "' AND '" + dateEnd + "' " +
                "and t01.MNC_FN_TYcNhso1_CD in ('44','45','46','47','48','49') " + " and t01.mnc_hn_no = '" + hn + "' " +
                "and t01.mnc_vn_no = '" + vn + "'  "+
                "and t01.mnc_cNhso1re_no = '" + cNhso1reNo + "'  " +
                "and  (LAB_T05.MNC_LB_CD IN ('ch002', 'ch250', 'ch003', 'ch004', 'ch040', 'ch037', "+
                "'ch039', 'ch036', 'ch038', 'se005', 'se038', 'se047', 'ch006', 'ch007', 'ch008', 'ch009', 'se165')) "+
                "and lab_t05.mnc_res <> '' and LAB_T05.MNC_LAB_cNhso1RN = '1' ";
            dt = conn.selectData(sql);
            return dt;
        }
    }
}
