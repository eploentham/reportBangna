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
        public LogWriter lw;
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
            lw = new LogWriter();

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

            cNhso1.labName11 = "labname11";
            cNhso1.labResult11 = "labresult11";
            cNhso1.labValue11 = "labvalue11";
            cNhso1.labName12 = "labname12";
            cNhso1.labResult12 = "labresult12";
            cNhso1.labValue12 = "labvalue12";
            cNhso1.labName13 = "labname13";
            cNhso1.labResult13 = "labresult13";
            cNhso1.labValue13 = "labvalue13";
            cNhso1.labName14 = "labname14";
            cNhso1.labResult14 = "labresult14";
            cNhso1.labValue14 = "labvalue14";
            cNhso1.labName15 = "labname15";
            cNhso1.labResult15 = "labresult15";
            cNhso1.labValue15 = "labvalue15";
            cNhso1.labName16 = "labname16";
            cNhso1.labResult16 = "labresult16";
            cNhso1.labValue16 = "labvalue16";
            cNhso1.labName17 = "labname17";
            cNhso1.labResult17 = "labresult17";
            cNhso1.labValue17 = "labvalue17";
            cNhso1.labName18 = "labname18";
            cNhso1.labResult18 = "labresult18";
            cNhso1.labValue18 = "labvalue18";
            cNhso1.labName19 = "labname19";
            cNhso1.labResult19 = "labresult19";
            cNhso1.labValue19 = "labvalue19";
            cNhso1.labName20 = "labname20";
            cNhso1.labResult20 = "labresult20";
            cNhso1.labValue20 = "labvalue20";
            cNhso1.labName21 = "labname21";
            cNhso1.labResult21 = "labresult21";
            cNhso1.labValue21 = "labvalue21";
            cNhso1.labName22 = "labname22";
            cNhso1.labResult22 = "labresult22";
            cNhso1.labValue22 = "labvalue22";
            
            cNhso1.labName23 = "labname23";
            cNhso1.labResult23 = "labresult23";
            cNhso1.labValue23 = "labvalue23";
            cNhso1.labName24 = "labname24";
            cNhso1.labResult24 = "labresult24";
            cNhso1.labValue24 = "labvalue24";
            cNhso1.labName25 = "labname25";
            cNhso1.labResult25 = "labresult25";
            cNhso1.labValue25 = "labvalue25";
            cNhso1.labName26 = "labname26";
            cNhso1.labResult26 = "labresult26";
            cNhso1.labValue26 = "labvalue26";
            cNhso1.labName27 = "labname27";
            cNhso1.labResult27 = "labresult27";
            cNhso1.labValue27 = "labvalue27";
            cNhso1.labName28 = "labname28";
            cNhso1.labResult28 = "labresult28";
            cNhso1.labValue28 = "labvalue28";
            cNhso1.labName29 = "labname29";
            cNhso1.labResult29 = "labresult29";
            cNhso1.labValue29 = "labvalue29";
            cNhso1.labName30 = "labname30";
            cNhso1.labResult30 = "labresult30";
            cNhso1.labValue30 = "labvalue30";

            cNhso1.vnseq = "vn_seq";
            cNhso1.vnsum = "vn_sum";
            cNhso1.preno = "preno";
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

            p.labName20 = dt.Rows[0][cNhso1.labName20].ToString();
            p.labName11 = dt.Rows[0][cNhso1.labName11].ToString();
            p.labName12 = dt.Rows[0][cNhso1.labName12].ToString();
            p.labName13 = dt.Rows[0][cNhso1.labName13].ToString();
            p.labName14 = dt.Rows[0][cNhso1.labName14].ToString();
            p.labName15 = dt.Rows[0][cNhso1.labName15].ToString();
            p.labName16 = dt.Rows[0][cNhso1.labName16].ToString();
            p.labName17 = dt.Rows[0][cNhso1.labName17].ToString();
            p.labName18 = dt.Rows[0][cNhso1.labName18].ToString();
            p.labName19 = dt.Rows[0][cNhso1.labName19].ToString();

            p.labName21 = dt.Rows[0][cNhso1.labName21].ToString();
            p.labName22 = dt.Rows[0][cNhso1.labName22].ToString();
            p.labName23 = dt.Rows[0][cNhso1.labName23].ToString();
            p.labName24 = dt.Rows[0][cNhso1.labName24].ToString();
            p.labName25 = dt.Rows[0][cNhso1.labName25].ToString();
            p.labName26 = dt.Rows[0][cNhso1.labName26].ToString();
            p.labName27 = dt.Rows[0][cNhso1.labName27].ToString();
            p.labName28 = dt.Rows[0][cNhso1.labName28].ToString();
            p.labName29 = dt.Rows[0][cNhso1.labName29].ToString();
            p.labName30 = dt.Rows[0][cNhso1.labName30].ToString();

            p.labResult11 = dt.Rows[0][cNhso1.labResult11].ToString();
            p.labResult12 = dt.Rows[0][cNhso1.labResult12].ToString();
            p.labResult13 = dt.Rows[0][cNhso1.labResult13].ToString();
            p.labResult14 = dt.Rows[0][cNhso1.labResult14].ToString();
            p.labResult15 = dt.Rows[0][cNhso1.labResult15].ToString();
            p.labResult16 = dt.Rows[0][cNhso1.labResult16].ToString();
            p.labResult17 = dt.Rows[0][cNhso1.labResult17].ToString();
            p.labResult18 = dt.Rows[0][cNhso1.labResult18].ToString();
            p.labResult19 = dt.Rows[0][cNhso1.labResult19].ToString();
            p.labResult20 = dt.Rows[0][cNhso1.labResult20].ToString();
            p.labResult21 = dt.Rows[0][cNhso1.labResult21].ToString();
            p.labResult22 = dt.Rows[0][cNhso1.labResult22].ToString();
            p.labResult23 = dt.Rows[0][cNhso1.labResult23].ToString();
            p.labResult24 = dt.Rows[0][cNhso1.labResult24].ToString();
            p.labResult25 = dt.Rows[0][cNhso1.labResult25].ToString();
            p.labResult26 = dt.Rows[0][cNhso1.labResult26].ToString();
            p.labResult27 = dt.Rows[0][cNhso1.labResult27].ToString();
            p.labResult28 = dt.Rows[0][cNhso1.labResult28].ToString();
            p.labResult29 = dt.Rows[0][cNhso1.labResult29].ToString();
            p.labResult30 = dt.Rows[0][cNhso1.labResult30].ToString();

            p.labValue11 = dt.Rows[0][cNhso1.labValue11].ToString();
            p.labValue12 = dt.Rows[0][cNhso1.labValue12].ToString();
            p.labValue13 = dt.Rows[0][cNhso1.labValue13].ToString();
            p.labValue14 = dt.Rows[0][cNhso1.labValue14].ToString();
            p.labValue15 = dt.Rows[0][cNhso1.labValue15].ToString();
            p.labValue16 = dt.Rows[0][cNhso1.labValue16].ToString();
            p.labValue17 = dt.Rows[0][cNhso1.labValue17].ToString();
            p.labValue18 = dt.Rows[0][cNhso1.labValue18].ToString();
            p.labValue19 = dt.Rows[0][cNhso1.labValue19].ToString();
            p.labValue20 = dt.Rows[0][cNhso1.labValue20].ToString();
            p.labValue21 = dt.Rows[0][cNhso1.labValue21].ToString();
            p.labValue22 = dt.Rows[0][cNhso1.labValue22].ToString();
            p.labValue23 = dt.Rows[0][cNhso1.labValue23].ToString();
            p.labValue24 = dt.Rows[0][cNhso1.labValue24].ToString();
            p.labValue25 = dt.Rows[0][cNhso1.labValue25].ToString();
            p.labValue26 = dt.Rows[0][cNhso1.labValue26].ToString();
            p.labValue27 = dt.Rows[0][cNhso1.labValue27].ToString();
            p.labValue28 = dt.Rows[0][cNhso1.labValue28].ToString();
            p.labValue29 = dt.Rows[0][cNhso1.labValue29].ToString();
            p.labValue30 = dt.Rows[0][cNhso1.labValue30].ToString();

            p.vnseq = dt.Rows[0][cNhso1.vnseq].ToString();
            p.vnsum = dt.Rows[0][cNhso1.vnsum].ToString();
            p.preno = dt.Rows[0][cNhso1.preno].ToString();
            //cNhso1.table = "checknhso";
            //cNhso1.cNhso1kField = "checknhso_id";
            p.rowEdit = "edit1";
            return p;
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

            dr[cNhso1.labName11] = dt.Rows[row][cNhso1.labName11].ToString();
            dr[cNhso1.labName12] = dt.Rows[row][cNhso1.labName12].ToString();
            dr[cNhso1.labName13] = dt.Rows[row][cNhso1.labName13].ToString();
            dr[cNhso1.labName14] = dt.Rows[row][cNhso1.labName14].ToString();
            dr[cNhso1.labName15] = dt.Rows[row][cNhso1.labName15].ToString();
            dr[cNhso1.labName16] = dt.Rows[row][cNhso1.labName16].ToString();
            dr[cNhso1.labName17] = dt.Rows[row][cNhso1.labName17].ToString();
            dr[cNhso1.labName18] = dt.Rows[row][cNhso1.labName18].ToString();
            dr[cNhso1.labName19] = dt.Rows[row][cNhso1.labName19].ToString();
            dr[cNhso1.labName20] = dt.Rows[row][cNhso1.labName20].ToString();
            dr[cNhso1.labName21] = dt.Rows[row][cNhso1.labName21].ToString();
            dr[cNhso1.labName22] = dt.Rows[row][cNhso1.labName22].ToString();
            dr[cNhso1.labName23] = dt.Rows[row][cNhso1.labName23].ToString();
            dr[cNhso1.labName24] = dt.Rows[row][cNhso1.labName24].ToString();
            dr[cNhso1.labName25] = dt.Rows[row][cNhso1.labName25].ToString();
            dr[cNhso1.labName26] = dt.Rows[row][cNhso1.labName26].ToString();
            dr[cNhso1.labName27] = dt.Rows[row][cNhso1.labName27].ToString();
            dr[cNhso1.labName28] = dt.Rows[row][cNhso1.labName28].ToString();
            dr[cNhso1.labName29] = dt.Rows[row][cNhso1.labName29].ToString();
            dr[cNhso1.labName30] = dt.Rows[row][cNhso1.labName30].ToString();

            dr[cNhso1.labResult11] = dt.Rows[row][cNhso1.labResult11].ToString();
            dr[cNhso1.labResult12] = dt.Rows[row][cNhso1.labResult12].ToString();
            dr[cNhso1.labResult13] = dt.Rows[row][cNhso1.labResult13].ToString();
            dr[cNhso1.labResult14] = dt.Rows[row][cNhso1.labResult14].ToString();
            dr[cNhso1.labResult15] = dt.Rows[row][cNhso1.labResult15].ToString();
            dr[cNhso1.labResult16] = dt.Rows[row][cNhso1.labResult16].ToString();
            dr[cNhso1.labResult17] = dt.Rows[row][cNhso1.labResult17].ToString();
            dr[cNhso1.labResult18] = dt.Rows[row][cNhso1.labResult18].ToString();
            dr[cNhso1.labResult19] = dt.Rows[row][cNhso1.labResult19].ToString();
            dr[cNhso1.labResult20] = dt.Rows[row][cNhso1.labResult20].ToString();
            dr[cNhso1.labResult21] = dt.Rows[row][cNhso1.labResult21].ToString();
            dr[cNhso1.labResult22] = dt.Rows[row][cNhso1.labResult22].ToString();
            dr[cNhso1.labResult23] = dt.Rows[row][cNhso1.labResult23].ToString();
            dr[cNhso1.labResult24] = dt.Rows[row][cNhso1.labResult24].ToString();
            dr[cNhso1.labResult25] = dt.Rows[row][cNhso1.labResult25].ToString();
            dr[cNhso1.labResult26] = dt.Rows[row][cNhso1.labResult26].ToString();
            dr[cNhso1.labResult27] = dt.Rows[row][cNhso1.labResult27].ToString();
            dr[cNhso1.labResult28] = dt.Rows[row][cNhso1.labResult28].ToString();
            dr[cNhso1.labResult29] = dt.Rows[row][cNhso1.labResult29].ToString();
            dr[cNhso1.labResult30] = dt.Rows[row][cNhso1.labResult30].ToString();

            dr[cNhso1.labValue11] = dt.Rows[row][cNhso1.labValue11].ToString();
            dr[cNhso1.labValue12] = dt.Rows[row][cNhso1.labValue12].ToString();
            dr[cNhso1.labValue13] = dt.Rows[row][cNhso1.labValue13].ToString();
            dr[cNhso1.labValue14] = dt.Rows[row][cNhso1.labValue14].ToString();
            dr[cNhso1.labValue15] = dt.Rows[row][cNhso1.labValue15].ToString();
            dr[cNhso1.labValue16] = dt.Rows[row][cNhso1.labValue16].ToString();
            dr[cNhso1.labValue17] = dt.Rows[row][cNhso1.labValue17].ToString();
            dr[cNhso1.labValue18] = dt.Rows[row][cNhso1.labValue18].ToString();
            dr[cNhso1.labValue19] = dt.Rows[row][cNhso1.labValue19].ToString();
            dr[cNhso1.labValue20] = dt.Rows[row][cNhso1.labValue20].ToString();
            dr[cNhso1.labValue21] = dt.Rows[row][cNhso1.labValue21].ToString();
            dr[cNhso1.labValue22] = dt.Rows[row][cNhso1.labValue22].ToString();
            dr[cNhso1.labValue23] = dt.Rows[row][cNhso1.labValue23].ToString();
            dr[cNhso1.labValue24] = dt.Rows[row][cNhso1.labValue24].ToString();
            dr[cNhso1.labValue25] = dt.Rows[row][cNhso1.labValue25].ToString();
            dr[cNhso1.labValue26] = dt.Rows[row][cNhso1.labValue26].ToString();
            dr[cNhso1.labValue27] = dt.Rows[row][cNhso1.labValue27].ToString();
            dr[cNhso1.labValue28] = dt.Rows[row][cNhso1.labValue28].ToString();
            dr[cNhso1.labValue29] = dt.Rows[row][cNhso1.labValue29].ToString();
            dr[cNhso1.labValue30] = dt.Rows[row][cNhso1.labValue30].ToString();

            dr[cNhso1.vnseq] = dt.Rows[row][cNhso1.vnseq].ToString();
            dr[cNhso1.vnsum] = dt.Rows[row][cNhso1.vnsum].ToString();
            dr[cNhso1.preno] = dt.Rows[row][cNhso1.preno].ToString();

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
        private String update(CheckNhso1 p)
        {
            String sql = "", chk = "";

            cNhso1.patientName = cNhso1.patientName.Replace("'", "''");
            cNhso1.dia1 = cNhso1.dia1.Replace("'", "''");

            p.patientName = p.patientName.Replace("'", "''");
            p.dia2 = p.dia2.Replace("'", "''");
            p.dia1 = p.dia1.Replace("'", "''");
            p.dia3 = p.dia3.Replace("'", "''");
            p.dia4 = p.dia4.Replace("'", "''");
            p.dia5 = p.dia5.Replace("'", "''");
            p.dia6 = p.dia6.Replace("'", "''");
            p.dia7 = p.dia7.Replace("'", "''");
            p.dia8 = p.dia8.Replace("'", "''");
            p.dia9 = p.dia9.Replace("'", "''");
            p.dia10 = p.dia10.Replace("'", "''");
            p.drug1 = p.drug1.Replace("'", "''");
            p.drug2 = p.drug2.Replace("'", "''");
            p.drug3 = p.drug3.Replace("'", "''");
            p.drug4 = p.drug4.Replace("'", "''");
            p.drug5 = p.drug5.Replace("'", "''");
            p.drug6 = p.drug6.Replace("'", "''");
            p.drug7 = p.drug7.Replace("'", "''");
            p.drug8 = p.drug8.Replace("'", "''");
            p.drug9 = p.drug9.Replace("'", "''");
            p.drug10 = p.drug10.Replace("'", "''");
            p.drug11 = p.drug11.Replace("'", "''");
            p.drug12 = p.drug12.Replace("'", "''");
            p.drug13 = p.drug13.Replace("'", "''");
            p.drug14 = p.drug14.Replace("'", "''");
            p.drug15 = p.drug15.Replace("'", "''");
            p.drug16 = p.drug16.Replace("'", "''");
            p.drug17 = p.drug17.Replace("'", "''");
            p.drug18 = p.drug18.Replace("'", "''");
            p.drug19 = p.drug19.Replace("'", "''");
            p.drug20 = p.drug20.Replace("'", "''");
            p.drug21 = p.drug21.Replace("'", "''");
            p.drug22 = p.drug22.Replace("'", "''");
            p.drug23 = p.drug23.Replace("'", "''");
            p.drug24 = p.drug24.Replace("'", "''");
            p.drug25 = p.drug25.Replace("'", "''");
            p.drug26 = p.drug26.Replace("'", "''");
            p.drug27 = p.drug27.Replace("'", "''");
            p.drug28 = p.drug28.Replace("'", "''");
            p.drug29 = p.drug29.Replace("'", "''");
            p.drug30 = p.drug30.Replace("'", "''");
            p.labName1 = p.labName1.Replace("'", "''");
            p.labName2 = p.labName2.Replace("'", "''");
            p.labName3 = p.labName3.Replace("'", "''");
            p.labName4 = p.labName4.Replace("'", "''");
            p.labName5 = p.labName5.Replace("'", "''");
            p.labName6 = p.labName6.Replace("'", "''");
            p.labName7 = p.labName7.Replace("'", "''");
            p.labName8 = p.labName8.Replace("'", "''");
            p.labName9 = p.labName9.Replace("'", "''");
            p.labName10 = p.labName10.Replace("'", "''");
            p.labName11 = p.labName11.Replace("'", "''");
            p.labName12 = p.labName12.Replace("'", "''");
            p.labName13 = p.labName13.Replace("'", "''");
            p.labName14 = p.labName14.Replace("'", "''");
            p.labName15 = p.labName15.Replace("'", "''");
            p.labName16 = p.labName16.Replace("'", "''");
            p.labName17 = p.labName17.Replace("'", "''");
            p.labName18 = p.labName18.Replace("'", "''");
            p.labName19 = p.labName19.Replace("'", "''");
            p.labName20 = p.labName20.Replace("'", "''");
            p.labName21 = p.labName21.Replace("'", "''");
            p.labName22 = p.labName22.Replace("'", "''");
            p.labName23 = p.labName23.Replace("'", "''");
            p.labName24 = p.labName24.Replace("'", "''");
            p.labName25 = p.labName25.Replace("'", "''");
            p.labName26 = p.labName26.Replace("'", "''");
            p.labName27 = p.labName27.Replace("'", "''");
            p.labName28 = p.labName28.Replace("'", "''");
            p.labName29 = p.labName29.Replace("'", "''");
            p.labName30 = p.labName30.Replace("'", "''");

            p.labResult1 = p.labResult1.Replace("'", "''");
            p.labResult2 = p.labResult2.Replace("'", "''");
            p.labResult3 = p.labResult3.Replace("'", "''");
            p.labResult4 = p.labResult4.Replace("'", "''");
            p.labResult5 = p.labResult5.Replace("'", "''");
            p.labResult6 = p.labResult6.Replace("'", "''");
            p.labResult7 = p.labResult7.Replace("'", "''");
            p.labResult8 = p.labResult8.Replace("'", "''");
            p.labResult9 = p.labResult9.Replace("'", "''");
            p.labResult10 = p.labResult10.Replace("'", "''");
            p.labResult11 = p.labResult11.Replace("'", "''");
            p.labResult12 = p.labResult12.Replace("'", "''");
            p.labResult13 = p.labResult13.Replace("'", "''");
            p.labResult14 = p.labResult14.Replace("'", "''");
            p.labResult15 = p.labResult15.Replace("'", "''");
            p.labResult16 = p.labResult16.Replace("'", "''");
            p.labResult17 = p.labResult17.Replace("'", "''");
            p.labResult18 = p.labResult18.Replace("'", "''");
            p.labResult19 = p.labResult19.Replace("'", "''");
            p.labResult20 = p.labResult20.Replace("'", "''");
            p.labResult21 = p.labResult21.Replace("'", "''");
            p.labResult22 = p.labResult22.Replace("'", "''");
            p.labResult23 = p.labResult23.Replace("'", "''");
            p.labResult24 = p.labResult24.Replace("'", "''");
            p.labResult25 = p.labResult25.Replace("'", "''");
            p.labResult26 = p.labResult26.Replace("'", "''");
            p.labResult27 = p.labResult27.Replace("'", "''");
            p.labResult28 = p.labResult28.Replace("'", "''");
            p.labResult29 = p.labResult29.Replace("'", "''");
            p.labResult30 = p.labResult30.Replace("'", "''");

            p.labValue1 = p.labValue1.Replace("'", "''");
            p.labValue2 = p.labValue2.Replace("'", "''");
            p.labValue3 = p.labValue3.Replace("'", "''");
            p.labValue4 = p.labValue4.Replace("'", "''");
            p.labValue5 = p.labValue5.Replace("'", "''");
            p.labValue6 = p.labValue6.Replace("'", "''");
            p.labValue7 = p.labValue7.Replace("'", "''");
            p.labValue8 = p.labValue8.Replace("'", "''");
            p.labValue9 = p.labValue9.Replace("'", "''");
            p.labValue10 = p.labValue10.Replace("'", "''");
            p.labValue11 = p.labValue11.Replace("'", "''");
            p.labValue12 = p.labValue12.Replace("'", "''");
            p.labValue13 = p.labValue13.Replace("'", "''");
            p.labValue14 = p.labValue14.Replace("'", "''");
            p.labValue15 = p.labValue15.Replace("'", "''");
            p.labValue16 = p.labValue16.Replace("'", "''");
            p.labValue17 = p.labValue17.Replace("'", "''");
            p.labValue18 = p.labValue18.Replace("'", "''");
            p.labValue19 = p.labValue19.Replace("'", "''");
            p.labValue20 = p.labValue20.Replace("'", "''");
            p.labValue21 = p.labValue21.Replace("'", "''");
            p.labValue22 = p.labValue22.Replace("'", "''");
            p.labValue23 = p.labValue23.Replace("'", "''");
            p.labValue24 = p.labValue24.Replace("'", "''");
            p.labValue25 = p.labValue25.Replace("'", "''");
            p.labValue26 = p.labValue26.Replace("'", "''");
            p.labValue27 = p.labValue27.Replace("'", "''");
            p.labValue28 = p.labValue28.Replace("'", "''");
            p.labValue29 = p.labValue29.Replace("'", "''");
            p.labValue30 = p.labValue30.Replace("'", "''");


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
                cNhso1.editDia + "='" + p.editDia + "', " +
                cNhso1.labName11 + "='" + p.labName11 + "', " +
                cNhso1.labResult11 + "='" + p.labResult11 + "', " +
                cNhso1.labValue11 + "='" + p.labValue11 + "', " +
                cNhso1.labName12 + "='" + p.labName12 + "', " +
                cNhso1.labResult12 + "='" + p.labResult12 + "', " +
                cNhso1.labValue12 + "='" + p.labValue12 + "', " +
                cNhso1.labName13 + "='" + p.labName13 + "', " +
                cNhso1.labResult13 + "='" + p.labResult13 + "', " +
                cNhso1.labValue13 + "='" + p.labValue13 + "', " +
                cNhso1.labName14 + "='" + p.labName14 + "', " +
                cNhso1.labResult14 + "='" + p.labResult14 + "', " +
                cNhso1.labValue14 + "='" + p.labValue14 + "', " +
                cNhso1.labName15 + "='" + p.labName15 + "', " +
                cNhso1.labResult15 + "='" + p.labResult15 + "', " +
                cNhso1.labValue15 + "='" + p.labValue15 + "', " +
                cNhso1.labName16 + "='" + p.labName16 + "', " +
                cNhso1.labResult16 + "='" + p.labResult16 + "', " +
                cNhso1.labValue16 + "='" + p.labValue16 + "', " +
                cNhso1.labName17 + "='" + p.labName17 + "', " +
                cNhso1.labResult17 + "='" + p.labResult17 + "', " +
                cNhso1.labValue17 + "='" + p.labValue17 + "', " +
                cNhso1.labName18 + "='" + p.labName18 + "', " +
                cNhso1.labResult18 + "='" + p.labResult18 + "', " +
                cNhso1.labValue18 + "='" + p.labValue18 + "', " +
                cNhso1.labName19 + "='" + p.labName19 + "', " +
                cNhso1.labResult19 + "='" + p.labResult19 + "', " +
                cNhso1.labValue19 + "='" + p.labValue19 + "', " +
                cNhso1.labName20 + "='" + p.labName20 + "', " +
                cNhso1.labResult20 + "='" + p.labResult20 + "', " +
                cNhso1.labValue20 + "='" + p.labValue20 + "', " +
                cNhso1.labName21 + "='" + p.labName21 + "', " +
                cNhso1.labResult21 + "='" + p.labResult21 + "', " +
                cNhso1.labValue21 + "='" + p.labValue21 + "', " +
                cNhso1.labName22 + "='" + p.labName22 + "', " +
                cNhso1.labResult22 + "='" + p.labResult22 + "', " +
                cNhso1.labValue22 + "='" + p.labValue22 + "', " +
                cNhso1.labName23 + "='" + p.labName23 + "', " +
                cNhso1.labResult23 + "='" + p.labResult23 + "', " +
                cNhso1.labValue23 + "='" + p.labValue23 + "', " +
                cNhso1.labName24 + "='" + p.labName24 + "', " +
                cNhso1.labResult24 + "='" + p.labResult24 + "', " +
                cNhso1.labValue24 + "='" + p.labValue24 + "', " +
                cNhso1.labName25 + "='" + p.labName25 + "', " +
                cNhso1.labResult25 + "='" + p.labResult25 + "', " +
                cNhso1.labValue25 + "='" + p.labValue25 + "', " +
                cNhso1.labName26 + "='" + p.labName26 + "', " +
                cNhso1.labResult26 + "='" + p.labResult26 + "', " +
                cNhso1.labValue26 + "='" + p.labValue26 + "', " +
                cNhso1.labName27 + "='" + p.labName27 + "', " +
                cNhso1.labResult27 + "='" + p.labResult27 + "', " +
                cNhso1.labValue27 + "='" + p.labValue27 + "', " +
                cNhso1.labName28 + "='" + p.labName28 + "', " +
                cNhso1.labResult28 + "='" + p.labResult28 + "', " +
                cNhso1.labValue28 + "='" + p.labValue28 + "', " +
                cNhso1.labName29 + "='" + p.labName29 + "', " +
                cNhso1.labResult29 + "='" + p.labResult29 + "', " +
                cNhso1.labValue29 + "='" + p.labValue29 + "', " +
                cNhso1.labName30 + "='" + p.labName30 + "', " +
                cNhso1.labResult30 + "='" + p.labResult30 + "', " +
                cNhso1.labValue30 + "='" + p.labValue30 + "' " +
                " " +
                "Where " + cNhso1.pkField + "='" + p.checknhsoId + "'";
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
        public String updatePreno(String id, String preno, String vnseq, String vnsum)
        {
            String sql = "", chk = "";

                        
            sql = "Update " + cNhso1.table + " Set " + cNhso1.preno + "='" + preno + "'," +
                cNhso1.vnseq + "='" + vnseq + "', " +
                cNhso1.vnsum + "='" + vnsum + "' " +
                //cNhso1.visitDate + "='" + p.visitDate + "', " +                
                " " +
                "Where " + cNhso1.pkField + "='" + id + "'";
            try
            {
                chk = connBua.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "updatePreno CheckNhso1");
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
                p.checknhsoId = p.branchID+p.visitDate.Replace("-","")+p.visitTime.Replace(":", "") + p.rowID;
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
                p.patientName = p.patientName.Replace("'", "''");
                p.dia2 = p.dia2.Replace("'", "''");
                p.dia1 = p.dia1.Replace("'", "''");
                p.dia3 = p.dia3.Replace("'", "''");
                p.dia4 = p.dia4.Replace("'", "''");
                p.dia5 = p.dia5.Replace("'", "''");
                p.dia6 = p.dia6.Replace("'", "''");
                p.dia7 = p.dia7.Replace("'", "''");
                p.dia8 = p.dia8.Replace("'", "''");
                p.dia9 = p.dia9.Replace("'", "''");
                p.dia10 = p.dia10.Replace("'", "''");

                p.chronic1 = p.chronic1.Replace("'", "''");
                p.chronic2 = p.chronic2.Replace("'", "''");
                p.chronic3 = p.chronic3.Replace("'", "''");
                p.chronic4 = p.chronic4.Replace("'", "''");
                p.chronic5 = p.chronic5.Replace("'", "''");
                p.chronic6 = p.chronic6.Replace("'", "''");
                p.chronic7 = p.chronic7.Replace("'", "''");
                p.chronic8 = p.chronic8.Replace("'", "''");
                p.chronic9 = p.chronic9.Replace("'", "''");
                p.chronic10 = p.chronic10.Replace("'", "''");

                p.drug1 = p.drug1.Replace("'", "''");                
                p.drug2 = p.drug2.Replace("'", "''");
                p.drug3 = p.drug3.Replace("'", "''");
                p.drug4 = p.drug4.Replace("'", "''");
                p.drug5 = p.drug5.Replace("'", "''");
                p.drug6 = p.drug6.Replace("'", "''");
                p.drug7 = p.drug7.Replace("'", "''");
                p.drug8 = p.drug8.Replace("'", "''");
                p.drug9 = p.drug9.Replace("'", "''");
                p.drug10 = p.drug10.Replace("'", "''");
                p.drug11 = p.drug11.Replace("'", "''");
                p.drug12 = p.drug12.Replace("'", "''");
                p.drug13 = p.drug13.Replace("'", "''");
                p.drug14 = p.drug14.Replace("'", "''");
                p.drug15 = p.drug15.Replace("'", "''");
                p.drug16 = p.drug16.Replace("'", "''");
                p.drug17 = p.drug17.Replace("'", "''");
                p.drug18 = p.drug18.Replace("'", "''");
                p.drug19 = p.drug19.Replace("'", "''");
                p.drug20 = p.drug20.Replace("'", "''");
                p.drug21 = p.drug21.Replace("'", "''");
                p.drug22 = p.drug22.Replace("'", "''");
                p.drug23 = p.drug23.Replace("'", "''");
                p.drug24 = p.drug24.Replace("'", "''");
                p.drug25 = p.drug25.Replace("'", "''");
                p.drug26 = p.drug26.Replace("'", "''");
                p.drug27 = p.drug27.Replace("'", "''");
                p.drug28 = p.drug28.Replace("'", "''");
                p.drug29 = p.drug29.Replace("'", "''");
                p.drug30 = p.drug30.Replace("'", "''");
                p.labName1 = p.labName1.Replace("'", "''");
                p.labName2 = p.labName2.Replace("'", "''");
                p.labName3 = p.labName3.Replace("'", "''");
                p.labName4 = p.labName4.Replace("'", "''");
                p.labName5 = p.labName5.Replace("'", "''");
                p.labName6 = p.labName6.Replace("'", "''");
                p.labName7 = p.labName7.Replace("'", "''");
                p.labName8 = p.labName8.Replace("'", "''");
                p.labName9 = p.labName9.Replace("'", "''");
                p.labName10 = p.labName10.Replace("'", "''");
                p.labName11 = p.labName11.Replace("'", "''");
                p.labName12 = p.labName12.Replace("'", "''");
                p.labName13 = p.labName13.Replace("'", "''");
                p.labName14 = p.labName14.Replace("'", "''");
                p.labName15 = p.labName15.Replace("'", "''");
                p.labName16 = p.labName16.Replace("'", "''");
                p.labName17 = p.labName17.Replace("'", "''");
                p.labName18 = p.labName18.Replace("'", "''");
                p.labName19 = p.labName19.Replace("'", "''");
                p.labName20 = p.labName20.Replace("'", "''");
                p.labName21 = p.labName21.Replace("'", "''");
                p.labName22 = p.labName22.Replace("'", "''");
                p.labName23 = p.labName23.Replace("'", "''");
                p.labName24 = p.labName24.Replace("'", "''");
                p.labName25 = p.labName25.Replace("'", "''");
                p.labName26 = p.labName26.Replace("'", "''");
                p.labName27 = p.labName27.Replace("'", "''");
                p.labName28 = p.labName28.Replace("'", "''");
                p.labName29 = p.labName29.Replace("'", "''");
                p.labName30 = p.labName30.Replace("'", "''");

                p.labResult1 = p.labResult1.Replace("'", "''");
                p.labResult2 = p.labResult2.Replace("'", "''");
                p.labResult3 = p.labResult3.Replace("'", "''");
                p.labResult4 = p.labResult4.Replace("'", "''");
                p.labResult5 = p.labResult5.Replace("'", "''");
                p.labResult6 = p.labResult6.Replace("'", "''");
                p.labResult7 = p.labResult7.Replace("'", "''");
                p.labResult8 = p.labResult8.Replace("'", "''");
                p.labResult9 = p.labResult9.Replace("'", "''");
                p.labResult10 = p.labResult10.Replace("'", "''");
                p.labResult11 = p.labResult11.Replace("'", "''");
                p.labResult12 = p.labResult12.Replace("'", "''");
                p.labResult13 = p.labResult13.Replace("'", "''");
                p.labResult14 = p.labResult14.Replace("'", "''");
                p.labResult15 = p.labResult15.Replace("'", "''");
                p.labResult16 = p.labResult16.Replace("'", "''");
                p.labResult17 = p.labResult17.Replace("'", "''");
                p.labResult18 = p.labResult18.Replace("'", "''");
                p.labResult19 = p.labResult19.Replace("'", "''");
                p.labResult20 = p.labResult20.Replace("'", "''");
                p.labResult21 = p.labResult21.Replace("'", "''");
                p.labResult22 = p.labResult22.Replace("'", "''");
                p.labResult23 = p.labResult23.Replace("'", "''");
                p.labResult24 = p.labResult24.Replace("'", "''");
                p.labResult25 = p.labResult25.Replace("'", "''");
                p.labResult26 = p.labResult26.Replace("'", "''");
                p.labResult27 = p.labResult27.Replace("'", "''");
                p.labResult28 = p.labResult28.Replace("'", "''");
                p.labResult29 = p.labResult29.Replace("'", "''");
                p.labResult30 = p.labResult30.Replace("'", "''");

                p.labValue1 = p.labValue1.Replace("'", "''");
                p.labValue2 = p.labValue2.Replace("'", "''");
                p.labValue3 = p.labValue3.Replace("'", "''");
                p.labValue4 = p.labValue4.Replace("'", "''");
                p.labValue5 = p.labValue5.Replace("'", "''");
                p.labValue6 = p.labValue6.Replace("'", "''");
                p.labValue7 = p.labValue7.Replace("'", "''");
                p.labValue8 = p.labValue8.Replace("'", "''");
                p.labValue9 = p.labValue9.Replace("'", "''");
                p.labValue10 = p.labValue10.Replace("'", "''");
                p.labValue11 = p.labValue11.Replace("'", "''");
                p.labValue12 = p.labValue12.Replace("'", "''");
                p.labValue13 = p.labValue13.Replace("'", "''");
                p.labValue14 = p.labValue14.Replace("'", "''");
                p.labValue15 = p.labValue15.Replace("'", "''");
                p.labValue16 = p.labValue16.Replace("'", "''");
                p.labValue17 = p.labValue17.Replace("'", "''");
                p.labValue18 = p.labValue18.Replace("'", "''");
                p.labValue19 = p.labValue19.Replace("'", "''");
                p.labValue20 = p.labValue20.Replace("'", "''");
                p.labValue21 = p.labValue21.Replace("'", "''");
                p.labValue22 = p.labValue22.Replace("'", "''");
                p.labValue23 = p.labValue23.Replace("'", "''");
                p.labValue24 = p.labValue24.Replace("'", "''");
                p.labValue25 = p.labValue25.Replace("'", "''");
                p.labValue26 = p.labValue26.Replace("'", "''");
                p.labValue27 = p.labValue27.Replace("'", "''");
                p.labValue28 = p.labValue28.Replace("'", "''");
                p.labValue29 = p.labValue29.Replace("'", "''");
                p.labValue30 = p.labValue30.Replace("'", "''");

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
                    cNhso1.dia8Ori + "," + cNhso1.dia9Ori + "," + cNhso1.dia10Ori  + "," + 
                    cNhso1.labName11 + "," + cNhso1.labResult11 + "," + cNhso1.labValue11 + "," +
                    cNhso1.labName12 + "," + cNhso1.labResult12 + "," + cNhso1.labValue12 + "," +
                    cNhso1.labName13 + "," + cNhso1.labResult13 + "," + cNhso1.labValue13 + "," +
                    cNhso1.labName14 + "," + cNhso1.labResult14 + "," + cNhso1.labValue14 + "," +
                    cNhso1.labName15 + "," + cNhso1.labResult15 + "," + cNhso1.labValue15 + "," +
                    cNhso1.labName16 + "," + cNhso1.labResult16 + "," + cNhso1.labValue16 + "," +
                    cNhso1.labName17 + "," + cNhso1.labResult17 + "," + cNhso1.labValue17 + "," +
                    cNhso1.labName18 + "," + cNhso1.labResult18 + "," + cNhso1.labValue18 + "," +
                    cNhso1.labName19 + "," + cNhso1.labResult19 + "," + cNhso1.labValue19 + "," +
                    cNhso1.labName20 + "," + cNhso1.labResult20 + "," + cNhso1.labValue20 + "," +
                    cNhso1.labName21 + "," + cNhso1.labResult21 + "," + cNhso1.labValue21 + "," +
                    cNhso1.labName22 + "," + cNhso1.labResult22 + "," + cNhso1.labValue22 + "," +
                    cNhso1.labName23 + "," + cNhso1.labResult23 + "," + cNhso1.labValue23 + "," +
                    cNhso1.labName24 + "," + cNhso1.labResult24 + "," + cNhso1.labValue24 + "," +
                    cNhso1.labName25 + "," + cNhso1.labResult25 + "," + cNhso1.labValue25 + "," +
                    cNhso1.labName26 + "," + cNhso1.labResult26 + "," + cNhso1.labValue26 + "," +
                    cNhso1.labName27 + "," + cNhso1.labResult27 + "," + cNhso1.labValue27 + "," +
                    cNhso1.labName28 + "," + cNhso1.labResult28 + "," + cNhso1.labValue28 + "," +
                    cNhso1.labName29 + "," + cNhso1.labResult29 + "," + cNhso1.labValue29 + "," +
                    cNhso1.labName30 + "," + cNhso1.labResult30 + "," + cNhso1.labValue30 + "" +
                    ") " +
                    "Values ('" + p.checknhsoId + "','" + p.patientName + "','" + p.hn + "','" +
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
                    p.statusActive + "','"+p.branchID+"','" + p.dia1Ori+"','"+
                    p.dia2Ori + "','"+p.dia3Or1 + "','" + p.dia4Ori+"','"+
                    p.dia5Ori + "','" + p.dia6Ori + "','" + p.dia7Ori + "','" +
                    p.dia8Ori + "','" + p.dia9Ori + "','" + p.dia10Ori + "','" +
                    p.labName11 + "','" + p.labResult11 + "','" + p.labValue11 + "','" +
                    p.labName12 + "','" + p.labResult12 + "','" + p.labValue12 + "','" +
                    p.labName13 + "','" + p.labResult13 + "','" + p.labValue13 + "','" +
                    p.labName14 + "','" + p.labResult14 + "','" + p.labValue14 + "','" +
                    p.labName15 + "','" + p.labResult15 + "','" + p.labValue15 + "','" +
                    p.labName16 + "','" + p.labResult16 + "','" + p.labValue16 + "','" +
                    p.labName17 + "','" + p.labResult17 + "','" + p.labValue17 + "','" +
                    p.labName18 + "','" + p.labResult18 + "','" + p.labValue18 + "','" +
                    p.labName19 + "','" + p.labResult19 + "','" + p.labValue19 + "','" +
                    p.labName20 + "','" + p.labResult20 + "','" + p.labValue20 + "','" +
                    p.labName21 + "','" + p.labResult21 + "','" + p.labValue21 + "','" +
                    p.labName22 + "','" + p.labResult22 + "','" + p.labValue22 + "','" +
                    p.labName23 + "','" + p.labResult23 + "','" + p.labValue23 + "','" +
                    p.labName24 + "','" + p.labResult24 + "','" + p.labValue24 + "','" +
                    p.labName25 + "','" + p.labResult25 + "','" + p.labValue25 + "','" +
                    p.labName26 + "','" + p.labResult26 + "','" + p.labValue26 + "','" +
                    p.labName27 + "','" + p.labResult27 + "','" + p.labValue27 + "','" +
                    p.labName28 + "','" + p.labResult28 + "','" + p.labValue28 + "','" +
                    p.labName29 + "','" + p.labResult29 + "','" + p.labValue29 + "','" +
                    p.labName30 + "','" + p.labResult30 + "','" + p.labValue30 + "" +
                    "') ";
                chk = c.ExecuteNonQuery(sql);
                chk = p.checknhsoId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "insert CheckNhso1 hn="+p.hn+" vn="+p.vn);
                lw.WriteLog("CheckNhso1DB Insert Error->"+ ex.ToString());
                lw.WriteLog("CheckNhso1DB Insert SQL->" + sql);
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
        //Public String insertCheckNhsoClient(CheckNhso1 P)
        //{

        //}
        public String insertCHeckNhso(CheckNhso1 p, Boolean isBranch)
        {
            CheckNhso1 item = new CheckNhso1();
            String chk = "";
            item = selectByPk(p.checknhsoId);
            if (item.checknhsoId == "")
            {
                //cNhso1.statusDecNhso1osit = "0";
                //cNhso1.statusReccNhso1 = "1";
                if (isBranch)
                {
                    chk = insert(p, connClient,"_client");
                }
                else
                {
                    chk = insert(p, connBua,"");
                }
                //chk = insert(cNhso1);
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
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName2 + " like '" + labId + "%') and " + cNhso1.labValue2 + " like '%" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName3 + " like '" + labId + "%') and " + cNhso1.labValue3 + " like '%" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName4 + " like '" + labId + "%') and " + cNhso1.labValue4 + " like '%" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName5 + " like '" + labId + "%') and " + cNhso1.labValue5 + " like '%" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName6 + " like '" + labId + "%') and " + cNhso1.labValue6 + " like '%" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName7 + " like '" + labId + "%') and " + cNhso1.labValue7 + " like '%" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName8 + " like '" + labId + "%') and " + cNhso1.labValue8 + " like '%" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName9 + " like '" + labId + "%') and " + cNhso1.labValue9 + " like '%" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName10 + " like '" + labId + "%') and " + cNhso1.labValue10 + " like '%" + labSearch1 + "%')  ";
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

                        labWhere = " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName1 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue1 + ")=1 Then Convert(float," + cNhso1.labValue1 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName2 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue2 + ")=1 Then Convert(float," + cNhso1.labValue2 + ") else NULL end)  between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName3 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue3 + ")=1 Then Convert(float," + cNhso1.labValue3 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName4 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue4 + ")=1 Then Convert(float," + cNhso1.labValue4 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName5 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue5 + ")=1 Then Convert(float," + cNhso1.labValue5 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName6 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue6 + ")=1 Then Convert(float," + cNhso1.labValue6 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName7 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue7 + ")=1 Then Convert(float," + cNhso1.labValue7 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName8 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue8 + ")=1 Then Convert(float," + cNhso1.labValue8 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName9 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue9 + ")=1 Then Convert(float," + cNhso1.labValue9 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName10 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue10 + ")=1 Then Convert(float," + cNhso1.labValue10 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName11 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue11 + ")=1 Then Convert(float," + cNhso1.labValue11 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName12 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue12 + ")=1 Then Convert(float," + cNhso1.labValue12 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName13 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue13 + ")=1 Then Convert(float," + cNhso1.labValue13 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName14 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue14 + ")=1 Then Convert(float," + cNhso1.labValue14 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName15 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue15 + ")=1 Then Convert(float," + cNhso1.labValue15 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName16 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue16 + ")=1 Then Convert(float," + cNhso1.labValue16 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName17 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue17 + ")=1 Then Convert(float," + cNhso1.labValue17 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName18 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue18 + ")=1 Then Convert(float," + cNhso1.labValue18 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName19 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue19 + ")=1 Then Convert(float," + cNhso1.labValue19 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName20 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue20 + ")=1 Then Convert(float," + cNhso1.labValue20 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName21 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue21 + ")=1 Then Convert(float," + cNhso1.labValue21 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName22 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue22 + ")=1 Then Convert(float," + cNhso1.labValue22 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName23 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue23 + ")=1 Then Convert(float," + cNhso1.labValue23 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName24 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue24 + ")=1 Then Convert(float," + cNhso1.labValue24 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName25 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue25 + ")=1 Then Convert(float," + cNhso1.labValue25 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName26 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue26 + ")=1 Then Convert(float," + cNhso1.labValue26 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName27 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue27 + ")=1 Then Convert(float," + cNhso1.labValue27 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName28 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue28 + ")=1 Then Convert(float," + cNhso1.labValue28 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName29 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue29 + ")=1 Then Convert(float," + cNhso1.labValue29 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName30 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue30 + ")=1 Then Convert(float," + cNhso1.labValue30 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float))  ";
                    }
                    else
                    {
                        labWhere = " ((" + visitDateWhere + " and " + cNhso1.labName1 + " like '" + labId + "%') and " + cNhso1.labValue1 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName2 + " like '" + labId + "%') and " + cNhso1.labValue2 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName3 + " like '" + labId + "%') and " + cNhso1.labValue3 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName4 + " like '" + labId + "%') and " + cNhso1.labValue4 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName5 + " like '" + labId + "%') and " + cNhso1.labValue5 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName6 + " like '" + labId + "%') and " + cNhso1.labValue6 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName7 + " like '" + labId + "%') and " + cNhso1.labValue7 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName8 + " like '" + labId + "%') and " + cNhso1.labValue8 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName9 + " like '" + labId + "%') and " + cNhso1.labValue9 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName10 + " like '" + labId + "%') and " + cNhso1.labValue10 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName11 + " like '" + labId + "%') and " + cNhso1.labValue11 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName12 + " like '" + labId + "%') and " + cNhso1.labValue12 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName13 + " like '" + labId + "%') and " + cNhso1.labValue13 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName14 + " like '" + labId + "%') and " + cNhso1.labValue14 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName15 + " like '" + labId + "%') and " + cNhso1.labValue15 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName16 + " like '" + labId + "%') and " + cNhso1.labValue16 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName17 + " like '" + labId + "%') and " + cNhso1.labValue17 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName18 + " like '" + labId + "%') and " + cNhso1.labValue18 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName19 + " like '" + labId + "%') and " + cNhso1.labValue19 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName20 + " like '" + labId + "%') and " + cNhso1.labValue20 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName21 + " like '" + labId + "%') and " + cNhso1.labValue21 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName22 + " like '" + labId + "%') and " + cNhso1.labValue22 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName23 + " like '" + labId + "%') and " + cNhso1.labValue23 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName24 + " like '" + labId + "%') and " + cNhso1.labValue24 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName25 + " like '" + labId + "%') and " + cNhso1.labValue25 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName26 + " like '" + labId + "%') and " + cNhso1.labValue26 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName27 + " like '" + labId + "%') and " + cNhso1.labValue27 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName28 + " like '" + labId + "%') and " + cNhso1.labValue28 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName29 + " like '" + labId + "%') and " + cNhso1.labValue29 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName30 + " like '" + labId + "%') and " + cNhso1.labValue30 + " like '" + labSearch1 + "%')  ";
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
        public DataTable selectByDate(String dateStart, String dateEnd, String chkDrug,
            String drugSearch, String labSearch1, String labSearch2, String labId, Boolean StatusLabError, Boolean doctorEdit, String branchId, Boolean statusdiasearch, String diasearch)
        {
            String sql = "";
            DataTable dt = new DataTable();
            String[] lab1;
            String labWhere = "", labFrom = "", drugWhere = "", drugFrom = "", statusActiceWhere = "", visitDateWhere = "", branchIdWhere = "";
            String doctorWhere = "", diaWhere="";
            Double aa = 0.0;

            statusActiceWhere = " " + cNhso1.statusActive + "='1' ";
            visitDateWhere = cNhso1.visitDate + " >='" + dateStart + "' and " + cNhso1.visitDate + "<='" + dateEnd + "' ";
            branchIdWhere = cNhso1.branchID + " = '" + branchId + "' ";
            if (!labSearch1.Equals(""))
            {

            }
            if (!labId.Equals(""))
            {
                if (StatusLabError)
                {
                    labWhere = " ((" + visitDateWhere + " and " + cNhso1.labName1 + " like '" + labId + "%') and " + cNhso1.labValue1 + " like '%" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName2 + " like '" + labId + "%') and " + cNhso1.labValue2 + " like '%" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName3 + " like '" + labId + "%') and " + cNhso1.labValue3 + " like '%" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName4 + " like '" + labId + "%') and " + cNhso1.labValue4 + " like '%" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName5 + " like '" + labId + "%') and " + cNhso1.labValue5 + " like '%" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName6 + " like '" + labId + "%') and " + cNhso1.labValue6 + " like '%" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName7 + " like '" + labId + "%') and " + cNhso1.labValue7 + " like '%" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName8 + " like '" + labId + "%') and " + cNhso1.labValue8 + " like '%" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName9 + " like '" + labId + "%') and " + cNhso1.labValue9 + " like '%" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName10 + " like '" + labId + "%') and " + cNhso1.labValue10 + " like '%" + labSearch1 + "%')  ";
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

                        labWhere = " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName1 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue1 + ")=1 Then Convert(float," + cNhso1.labValue1 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName2 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue2 + ")=1 Then Convert(float," + cNhso1.labValue2 + ") else NULL end)  between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName3 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue3 + ")=1 Then Convert(float," + cNhso1.labValue3 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName4 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue4 + ")=1 Then Convert(float," + cNhso1.labValue4 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName5 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue5 + ")=1 Then Convert(float," + cNhso1.labValue5 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName6 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue6 + ")=1 Then Convert(float," + cNhso1.labValue6 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName7 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue7 + ")=1 Then Convert(float," + cNhso1.labValue7 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName8 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue8 + ")=1 Then Convert(float," + cNhso1.labValue8 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName9 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue9 + ")=1 Then Convert(float," + cNhso1.labValue9 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName10 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue10 + ")=1 Then Convert(float," + cNhso1.labValue10 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName11 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue11 + ")=1 Then Convert(float," + cNhso1.labValue11 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName12 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue12 + ")=1 Then Convert(float," + cNhso1.labValue12 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName13 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue13 + ")=1 Then Convert(float," + cNhso1.labValue13 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName14 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue14 + ")=1 Then Convert(float," + cNhso1.labValue14 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName15 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue15 + ")=1 Then Convert(float," + cNhso1.labValue15 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName16 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue16 + ")=1 Then Convert(float," + cNhso1.labValue16 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName17 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue17 + ")=1 Then Convert(float," + cNhso1.labValue17 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName18 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue18 + ")=1 Then Convert(float," + cNhso1.labValue18 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName19 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue19 + ")=1 Then Convert(float," + cNhso1.labValue19 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName20 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue20 + ")=1 Then Convert(float," + cNhso1.labValue20 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName21 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue21 + ")=1 Then Convert(float," + cNhso1.labValue21 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName22 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue22 + ")=1 Then Convert(float," + cNhso1.labValue22 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName23 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue23 + ")=1 Then Convert(float," + cNhso1.labValue23 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName24 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue24 + ")=1 Then Convert(float," + cNhso1.labValue24 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName25 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue25 + ")=1 Then Convert(float," + cNhso1.labValue25 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName26 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue26 + ")=1 Then Convert(float," + cNhso1.labValue26 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName27 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue27 + ")=1 Then Convert(float," + cNhso1.labValue27 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName28 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue28 + ")=1 Then Convert(float," + cNhso1.labValue28 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName29 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue29 + ")=1 Then Convert(float," + cNhso1.labValue29 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float)) or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName30 + " like '" + labId + "%') and (Case When Isnumeric(" + cNhso1.labValue30 + ")=1 Then Convert(float," + cNhso1.labValue30 + ") else NULL end) between cast(" + labSearch1 + " as float) and cast(" + labSearch2 + " as float))  ";
                    }
                    else
                    {
                        labWhere = " ((" + visitDateWhere + " and " + cNhso1.labName1 + " like '" + labId + "%') and " + cNhso1.labValue1 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName2 + " like '" + labId + "%') and " + cNhso1.labValue2 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName3 + " like '" + labId + "%') and " + cNhso1.labValue3 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName4 + " like '" + labId + "%') and " + cNhso1.labValue4 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName5 + " like '" + labId + "%') and " + cNhso1.labValue5 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName6 + " like '" + labId + "%') and " + cNhso1.labValue6 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName7 + " like '" + labId + "%') and " + cNhso1.labValue7 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName8 + " like '" + labId + "%') and " + cNhso1.labValue8 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName9 + " like '" + labId + "%') and " + cNhso1.labValue9 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName10 + " like '" + labId + "%') and " + cNhso1.labValue10 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName11 + " like '" + labId + "%') and " + cNhso1.labValue11 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName12 + " like '" + labId + "%') and " + cNhso1.labValue12 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName13 + " like '" + labId + "%') and " + cNhso1.labValue13 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName14 + " like '" + labId + "%') and " + cNhso1.labValue14 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName15 + " like '" + labId + "%') and " + cNhso1.labValue15 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName16 + " like '" + labId + "%') and " + cNhso1.labValue16 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName17 + " like '" + labId + "%') and " + cNhso1.labValue17 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName18 + " like '" + labId + "%') and " + cNhso1.labValue18 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName19 + " like '" + labId + "%') and " + cNhso1.labValue19 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName20 + " like '" + labId + "%') and " + cNhso1.labValue20 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName21 + " like '" + labId + "%') and " + cNhso1.labValue21 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName22 + " like '" + labId + "%') and " + cNhso1.labValue22 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName23 + " like '" + labId + "%') and " + cNhso1.labValue23 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName24 + " like '" + labId + "%') and " + cNhso1.labValue24 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName25 + " like '" + labId + "%') and " + cNhso1.labValue25 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName26 + " like '" + labId + "%') and " + cNhso1.labValue26 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName27 + " like '" + labId + "%') and " + cNhso1.labValue27 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName28 + " like '" + labId + "%') and " + cNhso1.labValue28 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName29 + " like '" + labId + "%') and " + cNhso1.labValue29 + " like '" + labSearch1 + "%') or "
                        + " ((" + visitDateWhere + " and " + branchIdWhere + " and " + cNhso1.labName30 + " like '" + labId + "%') and " + cNhso1.labValue30 + " like '" + labSearch1 + "%')  ";
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
                doctorWhere = " and " + cNhso1.editDia + "<>''";
            }
            if (!diasearch.Equals(""))
            {
                if (statusdiasearch)
                {
                    diaWhere = " and LOWER(" + cNhso1.dia1 + ") <> '" + diasearch.Trim().ToLower() + "' ";
                    diaWhere += " and LOWER(" + cNhso1.dia2 + ") <> '" + diasearch.Trim().ToLower() + "' ";
                    diaWhere += " and LOWER(" + cNhso1.dia3 + ") <> '" + diasearch.Trim().ToLower() + "' ";
                    diaWhere += " and LOWER(" + cNhso1.dia4 + ") <> '" + diasearch.Trim().ToLower() + "' ";
                    diaWhere += " and LOWER(" + cNhso1.dia5 + ") <> '" + diasearch.Trim().ToLower() + "' ";
                    diaWhere += " and LOWER(" + cNhso1.dia6 + ") <> '" + diasearch.Trim().ToLower() + "' ";
                    diaWhere += " and LOWER(" + cNhso1.dia7 + ") <> '" + diasearch.Trim().ToLower() + "' ";
                    diaWhere += " and LOWER(" + cNhso1.dia8 + ") <> '" + diasearch.Trim().ToLower() + "' ";
                    diaWhere += " and LOWER(" + cNhso1.dia9 + ") <> '" + diasearch.Trim().ToLower() + "' ";
                    diaWhere += " and LOWER(" + cNhso1.dia10 + ") <> '" + diasearch.Trim().ToLower() + "' ";
                }
                else
                {
                    diaWhere = " and LOWER(" + cNhso1.dia1 + ") = '" + diasearch.Trim().ToLower() + "' ";
                    diaWhere += " and LOWER(" + cNhso1.dia2 + ") = '" + diasearch.Trim().ToLower() + "' ";
                    diaWhere += " and LOWER(" + cNhso1.dia3 + ") = '" + diasearch.Trim().ToLower() + "' ";
                    diaWhere += " and LOWER(" + cNhso1.dia4 + ") = '" + diasearch.Trim().ToLower() + "' ";
                    diaWhere += " and LOWER(" + cNhso1.dia5 + ") = '" + diasearch.Trim().ToLower() + "' ";
                    diaWhere += " and LOWER(" + cNhso1.dia6 + ") = '" + diasearch.Trim().ToLower() + "' ";
                    diaWhere += " and LOWER(" + cNhso1.dia7 + ") = '" + diasearch.Trim().ToLower() + "' ";
                    diaWhere += " and LOWER(" + cNhso1.dia8 + ") = '" + diasearch.Trim().ToLower() + "' ";
                    diaWhere += " and LOWER(" + cNhso1.dia9 + ") = '" + diasearch.Trim().ToLower() + "' ";
                    diaWhere += " and LOWER(" + cNhso1.dia10 + ") = '" + diasearch.Trim().ToLower() + "' ";
                }
            }
            sql = "Select * From " + cNhso1.table
                //+ " Where " + drugWhere+" and "+labWhere+doctorWhere+" and "+cNhso1.statusActive+"='1' "+" and "+cNhso1.branchID+" = '"+branchId+"' "
                + " Where " + drugWhere + " and " + labWhere + doctorWhere + diaWhere //+ " and " + cNhso1.branchID + " = '" + branchId + "' "
                + "Order By " + cNhso1.visitDate + "," + cNhso1.rowID;
            dt = connBua.selectData(sql);
            return dt;
        }
        public DataTable selectPatientByDate(String dateStart, String dateEnd, String chkDrug,
            String drugSearch, String labSearch1, String labSearch2, String labId)
        {
            //select PATIENT_T01.MNC_HN_NO,PATIENT_T01.MNC_PRE_NO,
            //PATIENT_T01.MNC_DATE,PATIENT_T01.MNC_TIME,
            //Patient_t09.MNC_DIA_CD,
            //PATIENT_T09_1.CHRONICCODE,
            //PHARMACY_T06.MNC_PH_CD,
            //Pharmacy_m01.MNC_PH_TN

            //from PATIENT_T01

            //left join PATIENT_T09_1 on Patient_t01.MNC_ID_NAM = PATIENT_T09_1.MNC_IDNUM
            //left join PATIENT_T09 on Patient_t01.MNC_PRE_NO =Patient_t09.MNC_PRE_NO and
            //Patient_t01.MNC_date =Patient_t09.MNC_date
            //left join Patient_m18 on Patient_t09.MNC_DIA_CD = Patient_m18 .MNC_DIA_CD
            //left join PHARMACY_T05 on Patient_t01.MNC_PRE_NO = PHARMACY_T05.MNC_PRE_NO and
            //Patient_t01.MNC_date = PHARMACY_T05.mnc_date
            //left join PHARMACY_T06 on Pharmacy_t05.MNC_CFR_NO = Pharmacy_t06.MNC_CFR_NO and
            //Pharmacy_t05.MNC_CFG_DAT = Pharmacy_t06.MNC_CFR_dat
            //left join PHARMACY_M01 on Pharmacy_t06.MNC_PH_CD = Pharmacy_m01.MNC_PH_CD

            //where PATIENT_T01.MNC_DATE BETWEEN '01/01/2014' AND '01/01/2014'

            //and Patient_t01.MNC_FN_TYP_CD in ('44','45','46','47','48','49')
 
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
                        //lab1 = labSearch1.SPlit(new char[] { ',' });
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
                        drugFrom = "inner join PHARMACY_T05 Phart05 on t01.MNC_PRE_NO = Phart05.MNC_PRE_NO and t01.mnc_hn_no = Phart05.mnc_hn_no " +
                "and t01.mnc_hn_yr = Phart05.mnc_hn_yr " +
                            "inner join PHARMACY_T06 Phart06 on Phart05.MNC_CFR_NO = Phart06.MNC_CFR_NO and Phart05.MNC_CFG_DAT = Phart06.MNC_CFR_dat " +
                "inner join PHARMACY_M01 on Phart06.MNC_PH_CD = Pharmacy_m01.MNC_PH_CD ";
                        drugWhere = "and Pharmacy_m01.mnc_Ph_tn like '" + drugSearch + "%' ";
                    }
                sql = "Select distinct t01.MNC_HN_NO,t01.MNC_PRE_NO, t01.MNC_DATE,t01.MNC_TIME, " +
                            //"t09.MNC_DIA_CD,t091.CHRONICCODE, " +
                "m01.mnc_fname_t, mnc_lname_t, m02.mnc_Pfix_dsc, t01.mnc_vn_no, t01.mnc_vn_seq, t01.mnc_vn_sum " +
                " from PATIENT_T01 t01 " +
                "Left Join Patient_m01 m01 on m01.mnc_hn_no = t01.mnc_hn_no " +
                "Left Join Patient_m02 m02 on m01.mnc_Pfix_cdt = m02.mnc_Pfix_cd " +
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
                "m01.mnc_fname_t, mnc_lname_t, m02.mnc_Pfix_dsc, t01.mnc_vn_no, t01.mnc_vn_seq, t01.mnc_vn_sum " +
                " from PATIENT_T01 t01 " +
                "Left Join Patient_m01 m01 on m01.mnc_hn_no = t01.mnc_hn_no " +
                "Left Join Patient_m02 m02 on m01.mnc_Pfix_cdt = m02.mnc_Pfix_cd " +
                    //"left join PATIENT_T09_1 t091 on t01.MNC_ID_NAM = t091.MNC_IDNUM " +
                    //"left join PATIENT_T09 t09 on t01.MNC_PRE_NO = t09.MNC_PRE_NO and t01.MNC_date = t09.MNC_date " +
                "where t01.MNC_DATE BETWEEN '" + dateStart + "' AND '" + dateEnd + "' " +
                "and t01.MNC_FN_TYP_CD in ('44','45','46','47','48','49') " +
                //"and t01.mnc_hn_no = '2179721 ' "+
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
                "and t01.mnc_Pre_no = '" + preNo + "'";
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
                "and t01.mnc_Pre_no = '" + preNo + "'";
            dt = conn.selectData(sql);
            return dt;
        }
        public DataTable selectDrugbyVN(String dateStart, String dateEnd, String hn, String vn, String preNo)
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select Phart06.MNC_PH_CD, Pharmacy_m01.MNC_PH_TN " +
                "From PATIENT_T01 t01 " +
                "left join PHARMACY_T05 Phart05 on t01.MNC_PRE_NO = Phart05.MNC_PRE_NO and t01.MNC_date = Phart05.mnc_date " +
                "left join PHARMACY_T06 Phart06 on Phart05.MNC_CFR_NO = Phart06.MNC_CFR_NO and Phart05.MNC_CFG_DAT = Phart06.MNC_CFR_dat " +
                "left join PHARMACY_M01 on Phart06.MNC_PH_CD = Pharmacy_m01.MNC_PH_CD " +
                "where t01.MNC_DATE BETWEEN '" + dateStart + "' AND '" + dateEnd + "' " +
                "and t01.MNC_FN_TYP_CD in ('44','45','46','47','48','49') " + " and t01.mnc_hn_no = '" + hn + "' " +
                "and t01.mnc_vn_no = '" + vn + "' and PHARMACY_M01.mnc_Ph_tyP_flg = 'P' "+
                "and t01.mnc_Pre_no = '" + preNo + "'";
            dt = conn.selectData(sql);
            return dt;
        }
        public DataTable selectbyVN(String dateStart, String hn, String vn)
        {           

            String sql = "";
            DataTable dt = new DataTable();            

            sql = "SELECT * " +
                "FROM     PATIENT_T01 t01 " +
                //"left join LAB_T01 ON t01.MNC_PRE_NO = LAB_T01.MNC_PRE_NO AND t01.MNC_DATE = LAB_T01.MNC_DATE " +
                //"left join LAB_T05 ON LAB_T01.MNC_REQ_NO = LAB_T05.MNC_REQ_NO AND LAB_T01.MNC_REQ_DAT = LAB_T05.MNC_REQ_DAT " +
                //"left join LAB_M01 ON LAB_T05.MNC_LB_CD = LAB_M01.MNC_LB_CD " +
                "where t01.MNC_DATE = '" + dateStart + "' " +
                "and t01.MNC_FN_TYP_CD in ('44','45','46','47','48','49') " + " and t01.mnc_hn_no = '" + hn + "' " +
                "and t01.mnc_vn_no = '" + vn + "'  ";

            dt = conn.selectData(sql);
            return dt;
        }
        public DataTable selectLabbyVN(String dateStart, String dateEnd, String hn, String vn, String preNo)
        {
            //select PATIENT_T01.MNC_HN_NO,PATIENT_T01.MNC_PRE_NO,
            //PATIENT_T01.MNC_DATE,PATIENT_T01.MNC_TIME,
            //Patient_t09.MNC_DIA_CD,
            //PATIENT_T09_1.CHRONICCODE,
            //PHARMACY_T06.MNC_PH_CD,
            //Pharmacy_m01.MNC_PH_TN,
            //lab_t05.MNC_LB_CD,lab_m01.MNC_LB_DSC,
            //lab_t05.MNC_RES_VALUE,
            //lab_t05.MNC_STS
            //from PATIENT_T01
            //left join PATIENT_T09_1 on Patient_t01.MNC_ID_NAM = PATIENT_T09_1.MNC_IDNUM
            //left join PATIENT_T09 on Patient_t01.MNC_PRE_NO =Patient_t09.MNC_PRE_NO and
            //Patient_t01.MNC_date =Patient_t09.MNC_date
            //left join Patient_m18 on Patient_t09.MNC_DIA_CD = Patient_m18 .MNC_DIA_CD
            //left join PHARMACY_T05 on Patient_t01.MNC_PRE_NO = PHARMACY_T05.MNC_PRE_NO and
            //Patient_t01.MNC_date = PHARMACY_T05.mnc_date
            //left join PHARMACY_T06 on Pharmacy_t05.MNC_CFR_NO = Pharmacy_t06.MNC_CFR_NO and
            //Pharmacy_t05.MNC_CFG_DAT = Pharmacy_t06.MNC_CFR_dat
            //left join PHARMACY_M01 on Pharmacy_t06.MNC_PH_CD = Pharmacy_m01.MNC_PH_CD
            //left join LAB_T01 on  Patient_t01.MNC_PRE_NO = lab_t01.MNC_PRE_NO and
            //Patient_t01.MNC_date = LAB_T01.mnc_date
            //left join LAB_T05 on lab_t01.MNC_REQ_NO = lab_t05.MNC_REQ_NO and
            //lab_t01.MNC_REQ_DAT = lab_t05.MNC_REQ_DAT
            //left join LAB_M01 on lab_t05.MNC_LB_CD = lab_m01.MNC_LB_CD
            //where PATIENT_T01.MNC_DATE BETWEEN '03/02/2014' AND '03/02/2014'
            //and Patient_t01.MNC_FN_TYP_CD in ('44','45','46','47','48','49')
            //and lab_t05.MNC_LB_CD in ('ch002','ch250','ch003','ch004','ch040','ch037','ch039','ch036','ch038',
            //'se005','se038','se047','ch006','ch007','ch008','ch009','se165') 
            //order by PATIENT_T01.MNC_HN_NO


//            SELECT LAB_T05.MNC_LB_CD, LAB_M01.MNC_LB_DSC, LAB_T05.MNC_RES_VALUE, LAB_T05.MNC_STS, LAB_T05.MNC_REQ_YR, LAB_T05.MNC_REQ_NO, LAB_T05.MNC_REQ_DAT, LAB_T05.MNC_LB_CD AS ExPr1, 
//                  LAB_T05.MNC_LB_RES_CD, LAB_T05.MNC_RES, LAB_T05.MNC_RES_VALUE AS ExPr2, LAB_T05.MNC_LB_USR, LAB_T05.MNC_STS AS ExPr3, LAB_T05.MNC_RES_MIN, LAB_T05.MNC_RES_MAX, 
//                  LAB_T05.MNC_LB_RES, LAB_T05.MNC_RES_UNT, LAB_T05.MNC_LB_ACT, LAB_T05.MNC_STAMP_DAT, LAB_T05.MNC_STAMP_TIM, LAB_T05.MNC_LAB_PRN
//FROM     PATIENT_T01 AS t01 LEFT OUTER JOIN
//                  LAB_T01 ON t01.MNC_PRE_NO = LAB_T01.MNC_PRE_NO AND t01.MNC_DATE = LAB_T01.MNC_DATE LEFT OUTER JOIN
//                  LAB_T05 ON LAB_T01.MNC_REQ_NO = LAB_T05.MNC_REQ_NO AND LAB_T01.MNC_REQ_DAT = LAB_T05.MNC_REQ_DAT LEFT OUTER JOIN
//                  LAB_M01 ON LAB_T05.MNC_LB_CD = LAB_M01.MNC_LB_CD
//WHERE  (t01.MNC_DATE BETWEEN '2014-03-31' AND '2014-03-31') AND (t01.MNC_FN_TYP_CD IN ('44', '45', '46', '47', '48', '49')) AND (t01.MNC_HN_NO = '5077727') AND (LAB_T05.MNC_LB_CD IN ('ch002', 'ch250', 'ch003', 'ch004', 
//                  'ch040', 'ch037', 'ch039', 'ch036', 'ch038', 'se005', 'se038', 'se047', 'ch006', 'ch007', 'ch008', 'ch009', 'se165'))


            String sql = "";
            DataTable dt = new DataTable();
            //sql = "SELECT distinct LAB_T05.MNC_LB_CD, LAB_M01.MNC_LB_DSC, LAB_T05.MNC_RES_VALUE, LAB_T05.MNC_STS " +
            //    "FROM     PATIENT_T01 t01 " +
            //    "left join LAB_T01 ON t01.MNC_PRE_NO = LAB_T01.MNC_PRE_NO AND t01.MNC_DATE = LAB_T01.MNC_DATE " +
            //    "left join LAB_T05 ON LAB_T01.MNC_REQ_NO = LAB_T05.MNC_REQ_NO AND LAB_T01.MNC_REQ_DAT = LAB_T05.MNC_REQ_DAT " +
            //    "left join LAB_M01 ON LAB_T05.MNC_LB_CD = LAB_M01.MNC_LB_CD " +
            //    "where t01.MNC_DATE BETWEEN '" + dateStart + "' AND '" + dateEnd + "' " +
            //    "and t01.MNC_FN_TYP_CD in ('44','45','46','47','48','49') " + " and t01.mnc_hn_no = '" + hn + "' " +
            //    "and t01.mnc_vn_no = '" + vn + "'  "+
            //    "and t01.mnc_Pre_no = '" + preNo + "'  " +
            //    "and  (LAB_T05.MNC_LB_CD IN ('ch002', 'ch250', 'ch003', 'ch004', 'ch040', 'ch037', "+
            //    "'ch039', 'ch036', 'ch038', 'se005', 'se038', 'se047', 'ch006', 'ch007', 'ch008', 'ch009', 'se165')) "+
            //    "and lab_t05.mnc_res <> '' and LAB_T05.MNC_LAB_PRN = '1' ";

            sql = "SELECT distinct LAB_T05.MNC_LB_CD, LAB_M01.MNC_LB_DSC, LAB_T05.MNC_RES_VALUE, LAB_T05.MNC_STS " +
                "FROM     PATIENT_T01 t01 " +
                "left join LAB_T01 ON t01.MNC_PRE_NO = LAB_T01.MNC_PRE_NO AND t01.MNC_DATE = LAB_T01.MNC_DATE " +
                "left join LAB_T05 ON LAB_T01.MNC_REQ_NO = LAB_T05.MNC_REQ_NO AND LAB_T01.MNC_REQ_DAT = LAB_T05.MNC_REQ_DAT " +
                "left join LAB_M01 ON LAB_T05.MNC_LB_CD = LAB_M01.MNC_LB_CD " +
                "where t01.MNC_DATE BETWEEN '" + dateStart + "' AND '" + dateEnd + "' " +
                "and t01.MNC_FN_TYP_CD in ('44','45','46','47','48','49') " + " and t01.mnc_hn_no = '" + hn + "' " +
                "and t01.mnc_vn_no = '" + vn + "'  " +
                "and t01.mnc_Pre_no = '" + preNo + "'  " +
                //"and  (LAB_T05.MNC_LB_CD IN ('ch002', 'ch250', 'ch003', 'ch004', 'ch040', 'ch037', " +
                //"'ch039', 'ch036', 'ch038', 'se005', 'se038', 'se047', 'ch006', 'ch007', 'ch008', 'ch009', 'se165')) " +
                "and lab_t05.mnc_res <> '' and LAB_T05.MNC_LAB_PRN = '1' ";

            dt = conn.selectData(sql);
            return dt;
        }
    }
}
