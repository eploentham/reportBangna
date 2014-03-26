using reportBangna.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace reportBangna.objdb
{
    class ChkStaffNoteDB
    {
        private ConnectDB connMainHis, connBangna;
        public ChkStaffNote sn;
        private Config1 config1;
        public ChkStaffNoteDB()
        {
            connMainHis = new ConnectDB("mainhis");
            connBangna = new ConnectDB("bangna");
            initConfig();
        }
        private void initConfig()
        {
            sn = new ChkStaffNote();
            config1 = new Config1();
            sn.MNC_DATE = "MNC_DATE";
            sn.MNC_DOT_CD = "MNC_DOT_CD";
            sn.MNC_DOT_FNAME = "MNC_DOT_FNAME";
            sn.MNC_DOT_LNAME = "MNC_DOT_LNAME";
            sn.MNC_FN_TYP_DSC = "MNC_FN_TYP_DSC";
            sn.MNC_FNAME_T = "MNC_FNAME_T";
            sn.MNC_HN_NO = "MNC_HN_NO";
            sn.MNC_LNAME_T = "MNC_LNAME_T";
            sn.MNC_MD_DEP_DSC = "MNC_MD_DEP_DSC";
            sn.MNC_PFIX_DSC = "MNC_PFIX_DSC";
            sn.MNC_PFIX_DSC_D = "MNC_PFIX_DSC_D";
            sn.MNC_TIME = "MNC_TIME";
            sn.vn = "vn";
            sn.staffNoteId = "staffnote_id";
            sn.statusActive = "status_active";
            sn.statusReceive = "status_receive";
            sn.MNC_VN = "mnc_vn";
            sn.MNC_VN_SEQ = "mnc_vn_seq";
            sn.remark = "remark";
            sn.pkField = "staffnote_id";
            sn.table = "staffnote";
        }
        public DataTable selectStaffNoteMainHisDate(String dateStart, String dateEnd)
        {
            DataTable dt = new DataTable();
            String sql = "";
            sql = "select PATIENT_T01.MNC_DATE,PATIENT_T01.MNC_TIME " +
                ",convert (varchar,PATIENT_T01.MNC_VN_NO)+'/'+convert (varchar,PATIENT_T01.MNC_VN_SEQ)+'(' " +
                "+convert (varchar,PATIENT_T01.MNC_VN_SUM)+')' as vn " +
                ",PATIENT_T01.MNC_HN_NO, " +
                "PATIENT_M02.MNC_PFIX_DSC,  " +
                "PATIENT_M01.MNC_FNAME_T,patient_m01.MNC_LNAME_T, " +
                "FINANCE_M02.MNC_FN_TYP_DSC,PATIENT_M26.MNC_DOT_CD, " +
                "doctor.MNC_PFIX_DSC as MNC_PFIX_DSC_D, " +
                "patient_m26.MNC_DOT_FNAME,patient_m26.MNC_DOT_LNAME " +
                ",PATIENT_M32.MNC_MD_DEP_DSC " +
                "from PATIENT_T01 " +
                "inner join PATIENT_M01 on patient_t01.MNC_HN_NO = PATIENT_M01.mnc_hn_no " +
                "inner join FINANCE_M02 on patient_t01.MNC_FN_TYP_CD = FINANCE_M02.MNC_FN_TYP_CD " +
                "inner join PATIENT_M32 on patient_t01.MNC_SEC_NO = patient_M32.MNC_SEC_NO " +
                "inner join PATIENT_M26 on patient_t01.MNC_DOT_CD  = PATIENT_M26.mnc_dot_cd " +
                "inner join PATIENT_M02 ON PATIENT_M02.MNC_PFIX_CD = PATIENT_M01.MNC_PFIX_CDT " +
                "inner join PATIENT_M02 as doctor ON doctor.MNC_PFIX_CD = PATIENT_M26.MNC_DOT_PFIX " +
                "where MNC_DATE >= '" + dateStart + "' and MNC_DATE <= '" +dateEnd+"' " +
                "and patient_t01.MNC_DOC_STS <> 'v' " +
                "Order By mnc_pre_no,MNC_VN_SEQ ";
            dt = connMainHis.selectData(sql);
            return dt;
        }
        public ChkStaffNote selectStaffNoteMainHisHnVn(String hn, String vn1, String visitDate)
        {
            DataTable dt = new DataTable();
            ChkStaffNote sn1 = new ChkStaffNote();
            String sql = "", vn="", vnSeq="", vnSum="", searchVnSum="";
            int len = 0, len2=0;

            len = vn1.IndexOf(".");
            if (len >= 1)
            {
                len2 = vn1.IndexOf(".", len+1);
                vn = vn1.Substring(0, len);
                vnSeq = vn1.Substring(len + 1, 1);
                
                if (len2 > 0)
                {
                    vnSum = vn1.Substring(len2, 1);
                    searchVnSum = " and PATIENT_T01.MNC_VN_SUM = '" + vnSum + "' ";
                }
            }
            else
            {
                len = vn1.IndexOf("/");
                len2 = vn1.IndexOf("(", len + 1);
                if (len > 0)
                {
                    vn = vn1.Substring(0, len);
                    vnSeq = vn1.Substring(len + 1, 1);
                    
                    if (len2 > 0)
                    {
                        vnSum = vn1.Substring(len2 - 2, 1);
                        searchVnSum = " and PATIENT_T01.MNC_VN_SUM = '" + vnSum + "' ";
                    }
                }
            }
            
            sql = "select PATIENT_T01.MNC_DATE,PATIENT_T01.MNC_TIME " +
                ",convert (varchar,PATIENT_T01.MNC_VN_NO)+'/'+convert (varchar,PATIENT_T01.MNC_VN_SEQ)+'(' " +
                "+convert (varchar,PATIENT_T01.MNC_VN_SUM)+')' as vn " +
                ",PATIENT_T01.MNC_HN_NO, " +
                "PATIENT_M02.MNC_PFIX_DSC,  " +
                "PATIENT_M01.MNC_FNAME_T,patient_m01.MNC_LNAME_T, " +
                "FINANCE_M02.MNC_FN_TYP_DSC,PATIENT_M26.MNC_DOT_CD, " +
                "doctor.MNC_PFIX_DSC as MNC_PFIX_DSC_D, " +
                "patient_m26.MNC_DOT_FNAME,patient_m26.MNC_DOT_LNAME " +
                ",PATIENT_M32.MNC_MD_DEP_DSC " +
                "from PATIENT_T01 " +
                "inner join PATIENT_M01 on patient_t01.MNC_HN_NO = PATIENT_M01.mnc_hn_no " +
                "inner join FINANCE_M02 on patient_t01.MNC_FN_TYP_CD = FINANCE_M02.MNC_FN_TYP_CD " +
                "inner join PATIENT_M32 on patient_t01.MNC_SEC_NO = patient_M32.MNC_SEC_NO " +
                "inner join PATIENT_M26 on patient_t01.MNC_DOT_CD  = PATIENT_M26.mnc_dot_cd " +
                "inner join PATIENT_M02 ON PATIENT_M02.MNC_PFIX_CD = PATIENT_M01.MNC_PFIX_CDT " +
                "inner join PATIENT_M02 as doctor ON doctor.MNC_PFIX_CD = PATIENT_M26.MNC_DOT_PFIX " +
                "where PATIENT_T01.MNC_vn_NO = '" + vn + "' and PATIENT_T01.MNC_VN_SEQ = '" + vnSeq +
                "' " + searchVnSum + 
                "and patient_t01.MNC_DOC_STS <> 'v' and PATIENT_T01.MNC_HN_NO ='" + hn + 
                "' and PATIENT_T01.MNC_DATE = '" + visitDate +"' "+
                "Order By mnc_pre_no ";
            dt = connMainHis.selectData(sql);
            if (dt.Rows.Count > 0)
            {                
                sn1.MNC_DATE = config1.datetoDB(dt.Rows[0][sn.MNC_DATE].ToString());
                sn1.MNC_DOT_CD = dt.Rows[0][sn.MNC_DOT_CD].ToString();
                sn1.MNC_DOT_FNAME = dt.Rows[0][sn.MNC_DOT_FNAME].ToString();
                sn1.MNC_DOT_LNAME = dt.Rows[0][sn.MNC_DOT_LNAME].ToString();
                sn1.MNC_FN_TYP_DSC = dt.Rows[0][sn.MNC_FN_TYP_DSC].ToString();
                sn1.MNC_FNAME_T = dt.Rows[0][sn.MNC_FNAME_T].ToString();
                sn1.MNC_HN_NO = dt.Rows[0][sn.MNC_HN_NO].ToString();
                sn1.MNC_LNAME_T = dt.Rows[0][sn.MNC_LNAME_T].ToString();
                sn1.MNC_MD_DEP_DSC = dt.Rows[0][sn.MNC_MD_DEP_DSC].ToString();
                sn1.MNC_PFIX_DSC = dt.Rows[0][sn.MNC_PFIX_DSC].ToString();
                sn1.MNC_PFIX_DSC_D = dt.Rows[0][sn.MNC_PFIX_DSC_D].ToString();
                sn1.MNC_TIME = dt.Rows[0][sn.MNC_TIME].ToString();
                sn1.vn = dt.Rows[0][sn.vn].ToString();
                //sn1.staffNoteId = dt.Rows[0][sn.staffNoteId].ToString();
                //sn1.statusActive = dt.Rows[0][sn.statusActive].ToString();
                //sn1.statusReceive = dt.Rows[0][sn.statusReceive].ToString();
            }
            return sn1;
        }
        public DataTable selectMainHisByDateHn(String visitDate, String visitHn)
        {
            DataTable dt = new DataTable();
            String sql = "", vn = "", vnSeq = "", vnSum = "";
            
            //ChkStaffNote sn = new ChkStaffNote();
            sql = "select PATIENT_T01.MNC_DATE,PATIENT_T01.MNC_TIME " +
                ",convert (varchar,PATIENT_T01.MNC_VN_NO)+'/'+convert (varchar,PATIENT_T01.MNC_VN_SEQ)+'(' " +
                "+convert (varchar,PATIENT_T01.MNC_VN_SUM)+')' as vn " +
                ",PATIENT_T01.MNC_HN_NO, " +
                "PATIENT_M02.MNC_PFIX_DSC,  " +
                "PATIENT_M01.MNC_FNAME_T,patient_m01.MNC_LNAME_T, " +
                "FINANCE_M02.MNC_FN_TYP_DSC,PATIENT_M26.MNC_DOT_CD, " +
                "doctor.MNC_PFIX_DSC as MNC_PFIX_DSC_D, " +
                "patient_m26.MNC_DOT_FNAME,patient_m26.MNC_DOT_LNAME " +
                ",PATIENT_M32.MNC_MD_DEP_DSC " +
                "from PATIENT_T01 " +
                "inner join PATIENT_M01 on patient_t01.MNC_HN_NO = PATIENT_M01.mnc_hn_no " +
                "inner join FINANCE_M02 on patient_t01.MNC_FN_TYP_CD = FINANCE_M02.MNC_FN_TYP_CD " +
                "inner join PATIENT_M32 on patient_t01.MNC_SEC_NO = patient_M32.MNC_SEC_NO " +
                "inner join PATIENT_M26 on patient_t01.MNC_DOT_CD  = PATIENT_M26.mnc_dot_cd " +
                "inner join PATIENT_M02 ON PATIENT_M02.MNC_PFIX_CD = PATIENT_M01.MNC_PFIX_CDT " +
                "inner join PATIENT_M02 as doctor ON doctor.MNC_PFIX_CD = PATIENT_M26.MNC_DOT_PFIX " +
                "where patient_t01.MNC_DOC_STS <> 'v' and PATIENT_T01.MNC_HN_NO ='" + visitHn +
                "' and PATIENT_T01.MNC_DATE = '" + visitDate + "' " +
                "Order By mnc_pre_no ";
            dt = connMainHis.selectData(sql);

            return dt;
        }
        public ChkStaffNote selectByHnVn(String hn, String vn1, String visitDate)
        {
            DataTable dt = new DataTable();
            String sql = "", vn = "", vnSeq = "", vnSum = "";
            ChkStaffNote sn1 = new ChkStaffNote();
            int len = 0;

            len = vn1.IndexOf(".");
            if (len >= 1)
            {
                vn = vn1.Substring(0, len);
                vnSeq = vn1.Substring(len + 1, 1);
                vnSum = vn1.Substring(vn1.Length - 1, 1);
                vn = vn + "/" + vnSeq + "(" + vnSum + ")";
            }
            else
            {
                len = vn1.IndexOf("/");
                if (len > 0)
                {
                    vn = vn1;
                }
                
            }
            //sql = "select * " +
            //    "From  " + sn.table+" "+
            //    "where " + sn.vn + " = '" + vn + "' and " + sn.MNC_HN_NO + "='" + hn + "' and "
            //    +sn.statusActive+"='1' and "+sn.MNC_DATE+"='"+visitDate+"'";
            sql = "select * " +
                "From  " + sn.table + " " +
                "where " + sn.vn + " = '" + vn + "' and " + sn.MNC_HN_NO + "='" + hn + "' and " 
                + sn.MNC_DATE + "='" + visitDate + "'";
            dt = connBangna.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                sn1.MNC_DATE = config1.datetoDB(dt.Rows[0][sn.MNC_DATE].ToString());
                sn1.MNC_DOT_CD = dt.Rows[0][sn.MNC_DOT_CD].ToString();
                sn1.MNC_DOT_FNAME = dt.Rows[0][sn.MNC_DOT_FNAME].ToString();
                sn1.MNC_DOT_LNAME = dt.Rows[0][sn.MNC_DOT_LNAME].ToString();
                sn1.MNC_FN_TYP_DSC = dt.Rows[0][sn.MNC_FN_TYP_DSC].ToString();
                sn1.MNC_FNAME_T = dt.Rows[0][sn.MNC_FNAME_T].ToString();
                sn1.MNC_HN_NO = dt.Rows[0][sn.MNC_HN_NO].ToString();
                sn1.MNC_LNAME_T = dt.Rows[0][sn.MNC_LNAME_T].ToString();
                sn1.MNC_MD_DEP_DSC = dt.Rows[0][sn.MNC_MD_DEP_DSC].ToString();
                sn1.MNC_PFIX_DSC = dt.Rows[0][sn.MNC_PFIX_DSC].ToString();
                sn1.MNC_PFIX_DSC_D = dt.Rows[0][sn.MNC_PFIX_DSC_D].ToString();
                sn1.MNC_TIME = dt.Rows[0][sn.MNC_TIME].ToString();
                sn1.vn = dt.Rows[0][sn.vn].ToString();
                sn1.staffNoteId = dt.Rows[0][sn.staffNoteId].ToString();
                sn1.statusActive = dt.Rows[0][sn.statusActive].ToString();
                sn1.statusReceive = dt.Rows[0][sn.statusReceive].ToString();
                sn1.remark = dt.Rows[0][sn.remark].ToString();
                sn1.MNC_VN = dt.Rows[0][sn.MNC_VN].ToString();
                sn1.MNC_VN_SEQ = dt.Rows[0][sn.MNC_VN_SEQ].ToString();

            }
            return sn1;
        }
        public DataTable selectByDate(String visitDate)
        {
            DataTable dt = new DataTable();
            String sql = "", vn = "", vnSeq = "", vnSum = "";
            //ChkStaffNote sn = new ChkStaffNote();
            sql = "select * " +
                "From  " + sn.table + " " +
                "where " + sn.MNC_DATE + " = '" + visitDate + "' and " + sn.statusActive + "='1' and "
                +sn.statusReceive+"='1' "
                +"Order By "+sn.MNC_VN+","+sn.MNC_VN_SEQ;
            dt = connBangna.selectData(sql);

            return dt;
        }
        
        private String insert(ChkStaffNote p)
        {
            String sql = "", chk = "";
            int len = 0;
            if (p.staffNoteId == "")
            {
                p.staffNoteId = p.getGenID();
            }
            len = p.vn.IndexOf("/");
            if (len >= 1)
            {
                p.MNC_VN = p.vn.Substring(0, len);
                p.MNC_VN_SEQ = p.vn.Substring(len + 1);
                len = p.MNC_VN_SEQ.IndexOf("(");
                p.MNC_VN_SEQ = p.MNC_VN_SEQ.Substring(len + 1);
                p.MNC_VN_SEQ = p.MNC_VN_SEQ.Replace(")", "");
                //vnSum = vn1.Substring(vn1.Length - 1, 1);
                //vn = vn + "/" + vnSeq + "(" + vnSum + ")";
            }
            
            p.MNC_DOT_FNAME = p.MNC_DOT_FNAME.Replace("'", "''");
            p.MNC_DOT_LNAME = p.MNC_DOT_LNAME.Replace("'", "''");
            p.MNC_FNAME_T = p.MNC_FNAME_T.Replace("'", "''");
            p.MNC_LNAME_T = p.MNC_LNAME_T.Replace("'", "''");
            p.MNC_MD_DEP_DSC = p.MNC_MD_DEP_DSC.Replace("'", "''");
            p.MNC_PFIX_DSC_D = p.MNC_PFIX_DSC_D.Replace("'", "''");
            p.MNC_PFIX_DSC = p.MNC_PFIX_DSC.Replace("'", "''");
            sql = "Insert Into "+sn.table+" ("+sn.pkField+","+sn.MNC_DATE+","+
                sn.MNC_DOT_CD+","+sn.MNC_DOT_FNAME+","+
                sn.MNC_DOT_LNAME+","+sn.MNC_FN_TYP_DSC+","+
                sn.MNC_FNAME_T+","+sn.MNC_HN_NO+","+
                sn.MNC_LNAME_T+","+sn.MNC_MD_DEP_DSC+","+
                sn.MNC_PFIX_DSC+","+sn.MNC_PFIX_DSC_D+","+
                sn.MNC_TIME+","+sn.vn+","+
                sn.statusActive+","+sn.statusReceive+","+
                sn.remark+","+sn.MNC_VN+","
                +sn.MNC_VN_SEQ+") "+
                "Values ('" + p.staffNoteId+"','"+p.MNC_DATE+"','"+
                p.MNC_DOT_CD+"','"+p.MNC_DOT_FNAME+"','"+
                p.MNC_DOT_LNAME+"','"+p.MNC_FN_TYP_DSC+"','"+
                p.MNC_FNAME_T+"','"+p.MNC_HN_NO+"','"+
                p.MNC_LNAME_T+"','"+p.MNC_MD_DEP_DSC+"','"+
                p.MNC_PFIX_DSC+"','"+p.MNC_PFIX_DSC_D+"','"+
                p.MNC_TIME+"','"+p.vn+"','"+
                p.statusActive+"','"+p.statusReceive+"','"+
                p.remark+"',"+p.MNC_VN+","+
                p.MNC_VN_SEQ+") ";
            chk = connBangna.ExecuteNonQuery(sql);
            return chk;
        }
        private String updateActiveReceice(String hn, String vn, String visitDate)
        {
            String sql = "", chk = "";
            sql = "Update " + sn.table + " Set " + sn.statusActive + "='1',"+sn.statusReceive+"='1'  Where " + sn.MNC_HN_NO + "='" + hn +
                "' and " + sn.vn + " ='" + vn + "' and "+sn.MNC_DATE+"='"+visitDate+"'";
            chk = connBangna.ExecuteNonQuery(sql);
            return chk;
        }
        private String updateActiveReceice(String staffNoteId)
        {
            String sql = "", chk = "";
            sql = "Update " + sn.table + " Set " + sn.statusActive + "='1' " +
                "Where " + sn.staffNoteId + "='" + staffNoteId +
                "' ";
            //sql = "Update " + sn.table + " Set " + sn.statusReceive + "='1' " +
            //    "Where " + sn.staffNoteId + "='" + staffNoteId +
            //    "' ";
            chk = connBangna.ExecuteNonQuery(sql);
            return chk;
        }
        public String updateRemark(String hn, String vn, String visitDate, String remark)
        {
            String sql = "", chk = "";
            remark = remark.Replace("',", "''");
            sql = "Update " + sn.table + " Set " + sn.remark + "='" + remark + "' "
            +"Where " + sn.MNC_HN_NO + "='" + hn +
                "' and " + sn.vn + " ='" + vn + "' and " + sn.MNC_DATE + "='" + visitDate + "'";
            chk = connBangna.ExecuteNonQuery(sql);
            return chk;
        }
        public String updateRemark(String staffNoteId, String remark)
        {
            String sql = "", chk = "";
            remark = remark.Replace("',", "''");
            sql = "Update " + sn.table + " Set " + sn.remark + "='" + remark + "' "
            + "Where " + sn.staffNoteId + "='" + staffNoteId +
                "' ";
            chk = connBangna.ExecuteNonQuery(sql);
            return chk;
        }
        public String insertStaffNote(ChkStaffNote p)
        {
            ChkStaffNote item = new ChkStaffNote();
            String chk = "";
            item = selectByHnVn(p.MNC_HN_NO, p.vn,p.MNC_DATE);
            if (item.staffNoteId == "")
            {
                chk = insert(p);
            }
            else
            {
                chk = updateActiveReceice(item.staffNoteId);
            }
            return chk;
        }
        public String insertRemark(ChkStaffNote p)
        {
            ChkStaffNote item = new ChkStaffNote();
            String chk = "";
            item = selectByHnVn(p.MNC_HN_NO, p.vn, p.MNC_DATE);
            if (item.staffNoteId == "")
            {
                chk = insert(p);
            }
            else
            {
                chk = updateRemark(item.staffNoteId,item.staffNoteId);
            }
            return chk;
        }
        public String setStaffNoteVoid(String visitHn, String visitVn)
        {
            String sql = "", chk="";
            sql = "Update "+sn.table+" Set "+sn.statusActive+"='3' Where "+sn.MNC_HN_NO +"='"+visitHn+
                "' and "+sn.vn+" ='"+visitVn+"'";
            chk = connBangna.ExecuteNonQuery(sql);
            return chk;
        }
        public String setStaffNoteVoid(String staffNoteId)
        {
            String sql = "", chk = "";
            sql = "Update " + sn.table + " Set " + sn.statusActive + "='3' Where " + sn.staffNoteId + "='" + staffNoteId +
                "'";
            chk = connBangna.ExecuteNonQuery(sql);
            return chk;
        }
    }
}