using reportBangna.objdb;
using reportBangna.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace reportBangna
{
    public class BangnaControl
    {
        public ConnectDB conn, connMainHIS5;
        public Config1 cf;
        public ComboBox cboWard, cboSale, cboThoo;
        public List<Font1> thoColor = new List<Font1>();
        public String vnSearch = "", hnSearch="";
        public Patient pa;
        public Visit vs;
        public LogWriter lw;
        public StGoodsGroup gg;
        public String pathLabEx = "", FileName="";
        public LabExDB labexdb;
        public VisitDB vsdb;
        public StVendorDB vendb;
        public StGoodsDB gooddb;
        public DistrictDB didb;
        public AmphurDB amdb;
        public ProvinceDB prdb;
        public OPDCheckUP opdc;
        public OPDCheckUPDB opdcdb;
        public StGoodsGroupDB ggdb;


        public BangnaControl()
        {
            conn = new ConnectDB("bangna");
            connMainHIS5 = new ConnectDB("mainhis");
            //connMainHIS1 = new ConnectDB("mainhis");
            labexdb = new LabExDB();
            vsdb = new VisitDB();
            vendb = new StVendorDB(conn);
            didb = new DistrictDB(conn);
            amdb = new AmphurDB(conn);
            prdb = new ProvinceDB(conn);
            gooddb = new StGoodsDB(conn);
            opdcdb = new OPDCheckUPDB(conn);
            ggdb = new StGoodsGroupDB(conn);

            cf = new Config1();
            pa = new Patient();
            vs = new Visit();
            lw = new LogWriter();
            gg = new StGoodsGroup();
            pathLabEx = "\\\\" + conn.hostNameMainHIS5 + "\\image\\labex\\";
        }
        public String getTextCboItem(ComboBox c, String valueId)
        {
            ComboBoxItem r = new ComboBoxItem();
            r.Text = "";
            r.Value = "";
            foreach (ComboBoxItem cc in c.Items)
            {
                if (cc.Value.Equals(valueId))
                {
                    r = cc;
                }
            }
            return r.Text;
        }
        public String getIdCboItemByText(ComboBox c, String valueId)
        {
            ComboBoxItem r = new ComboBoxItem();
            r.Text = "";
            r.Value = "";
            foreach (ComboBoxItem cc in c.Items)
            {
                if (cc.Text.Equals(valueId))
                {
                    r = cc;
                }
            }
            return r.Value;
        }
        //public ComboBox getCboItemByList(ComboBox c, List<Item> lit)
        //{
        //    ComboBoxItem item = new ComboBoxItem();
        //    //DataTable dt = selectAll();
        //    c.Items.Clear();
        //    //String aaa = "";
        //    foreach (Item i in lit)
        //    {
        //        item = new ComboBoxItem();
        //        item.Value = i.Id;
        //        item.Text = i.NameT;
        //        c.Items.Add(item);
        //        //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
        //        //c.Items.Add(new );
        //    }
        //    return c;
        //}
        public ComboBoxItem getCboItem(ComboBox c, String valueId)
        {
            ComboBoxItem r = new ComboBoxItem();
            r.Text = "";
            r.Value = "";
            foreach (ComboBoxItem cc in c.Items)
            {
                if (cc.Value.Equals(valueId))
                {
                    r = cc;
                }
            }
            return r;
        }
        public DataTable selectWard()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select MNC_MD_DEP_NO, MNC_MD_DEP_DSC From PATIENT_M32 Where MNC_TYP_PT = 'I' Order By MNC_MD_DEP_NO";
            dt = conn.selectData(sql);

            return dt;
        }
        public ComboBox getCboWard(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectWard();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i]["MNC_MD_DEP_NO"].ToString();
                item.Text = dt.Rows[i]["MNC_MD_DEP_DSC"].ToString();
                c.Items.Add(item);
                //c.Items.Add(new );
            }
            return c;
        }
        public DataTable selectPatientInWard(String wardNo)
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select t08.mnc_hn_no, m01.MNC_FNAME_T, m01.MNC_LNAME_T, m02.MNC_PFIX_DSC, t08.mnc_pre_no, "+
                    "t08.mnc_fn_typ_cd, t08.mnc_rm_nam, t08.mnc_bd_no, t08.mnc_date " +
                    "From PATIENT_T08 t08 " +
                    "Left Join patient_m01 m01 on t08.mnc_hn_no = m01.mnc_hn_no "+
                    "Left Join patient_m02 m02 on m01.MNC_PFIX_CDT = m02.MNC_PFIX_CD " +
                    "Where t08.MNC_WD_NO='" + wardNo + "'  " +
                    "and t08.MNC_AD_STS = 'A' " +
                    "--and MNC_HN_NO='5004969'";
            dt = conn.selectData(sql);

            return dt;
        }
        public DataTable selectPatientDead(String dateStart, String dateEnd)
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select patient_t08.MNC_AD_DATE,PATIENT_T08.MNC_DS_DATE,patient_t08.MNC_HN_NO, " +
                "m02.MNC_PFIX_DSC, m01.MNC_FNAME_T, m01.MNC_LNAME_T, " +
                "patient_t08.MNC_AN_NO,patient_t08.MNC_AN_yr, " +
                "PATIENT_T08.MNC_DIA_DEAD ,PATIENT_M18.MNC_DIA_DSC_E, 'IPD' AS flag " +

                "from PATIENT_T08 " +

                "left join PATIENT_M18 on PATIENT_T08.MNC_DIA_DEAD = PATIENT_M18.MNC_DIA_CD " +
                "left JOIN PATIENT_M01 AS m01 ON PATIENT_T08.MNC_HN_NO = m01.MNC_HN_NO " +
                "left JOIn  PATIENT_M02 AS m02 ON m02.MNC_PFIX_CD = m01.MNC_PFIX_CDT " +

                "where PATIENT_T08.MNC_DEAD_FLG = 'y' and patient_t08.MNC_AD_DATE >='" + dateStart + "' and patient_t08.MNC_AD_DATE <='" + dateEnd+"' " +
                //"order by PATIENT_T08.MNC_AD_DATE  " +
                "Union " +
                "Select patient_t01.MNC_DATE,patient_t01.MNC_STAMP_DAT,patient_t01.MNC_HN_NO, " +
                "m02.MNC_PFIX_DSC, m01.MNC_FNAME_T, m01.MNC_LNAME_T,  '' AS asMNC_AN_NO, '' AS MNC_AN_YR," +
                "patient_t01.MNC_DIA_DEAD ,PATIENT_M18.MNC_DIA_DSC_E, 'OPD' AS flag " +
                "from patient_t01 " +

                "left join PATIENT_M18 on patient_t01.MNC_DIA_DEAD = PATIENT_M18.MNC_DIA_CD " +
                "left JOIN PATIENT_M01 AS m01 ON PATIENT_T01.MNC_HN_NO = m01.MNC_HN_NO " +
                "left JOIn  PATIENT_M02 AS m02 ON m02.MNC_PFIX_CD = m01.MNC_PFIX_CDT " +

                "where patient_t01.MNC_DEAD_FLG = 'y' and patient_t01.MNC_DATE >='" + dateStart + "' and patient_t01.MNC_DATE <='" + dateEnd + "'";
                //"order by patient_t01.MNC_DATE";
            dt = conn.selectData(sql);

            return dt;
        }
        public DataTable selectNHSOPrintHN(String startDate,String hn, String preno, String vn)
        {
            DataTable dt = new DataTable();
            String sql = "";
            String[] vn1 = vn.Split('.');
            sql = "Select phart06.MNC_PH_CD, pharmacy_m01.MNC_PH_TN ,PHARMACY_M05.MNC_PH_PRI01,PHARMACY_M05.MNC_PH_PRI02,sum(phart06.MNC_PH_QTY) as qty, PHARMACY_M05.MNC_PH_PRI01 * sum(phart06.MNC_PH_QTY) as amt,phart05.MNC_CFG_DAT " +
                    " From PATIENT_T01 t01 " +
                    " left join PHARMACY_T05 phart05 on t01.MNC_PRE_NO = phart05.MNC_PRE_NO and t01.MNC_date = phart05.mnc_date " +
                    " left join PHARMACY_T06 phart06 on phart05.MNC_CFR_NO = phart06.MNC_CFR_NO and phart05.MNC_CFG_DAT = phart06.MNC_CFR_dat " +
                    " left join PHARMACY_M01 on phart06.MNC_PH_CD = pharmacy_m01.MNC_PH_CD " +
                    " left join PHARMACY_M05 on PHARMACY_M05.MNC_PH_CD = PHARMACY_M01.MNC_PH_CD " +
                    " where " +
                    //" --t01.MNC_DATE BETWEEN '' AND '' and " +
                    " t01.mnc_hn_no = '" + hn + "' " +
                    //" t01.mnc_hn_no = '"+hn+"' "+
                    " and t01.MNC_PRE_NO = '" + preno + "' " +
                    " and t01.mnc_vn_no = '" + vn1[0] + "' " +
                     " and t01.mnc_vn_seq = '" + vn1[1] + "' " +
                      " and t01.mnc_vn_sum = '" + vn1[2] + "' " +
                    " and pharmacy_m01.MNC_PH_TN like '(%' " +
                    //" and t01.mnc_vn_no = '58' and t01.MNC_PRE_NO = '61' " +
                    " and phart05.MNC_CFR_STS = 'a' " +
                    " Group By phart06.MNC_PH_CD, pharmacy_m01.MNC_PH_TN ,PHARMACY_M05.MNC_PH_PRI01,PHARMACY_M05.MNC_PH_PRI02,phart05.MNC_CFG_DAT " +
                    " Order By phart05.MNC_CFG_DAT,phart06.MNC_PH_CD ";
            dt = connMainHIS5.selectData(sql);
            return dt;
        }
        public DataTable selectNHSOPrintHNAll(String startDate, String hn, String preno, String vn)
        {
            DataTable dt = new DataTable();
            String sql = "";
            String[] vn1 = vn.Split('.');
            sql = "Select phart06.MNC_PH_CD, pharmacy_m01.MNC_PH_TN ,PHARMACY_M05.MNC_PH_PRI01,PHARMACY_M05.MNC_PH_PRI02,sum(phart06.MNC_PH_QTY) as qty, PHARMACY_M05.MNC_PH_PRI01 * sum(phart06.MNC_PH_QTY) as amt,phart05.MNC_CFG_DAT " +
                    " From PATIENT_T01 t01 " +
                    " left join PHARMACY_T05 phart05 on t01.MNC_PRE_NO = phart05.MNC_PRE_NO and t01.MNC_date = phart05.mnc_date " +
                    " left join PHARMACY_T06 phart06 on phart05.MNC_CFR_NO = phart06.MNC_CFR_NO and phart05.MNC_CFG_DAT = phart06.MNC_CFR_dat " +
                    " left join PHARMACY_M01 on phart06.MNC_PH_CD = pharmacy_m01.MNC_PH_CD " +
                    " left join PHARMACY_M05 on PHARMACY_M05.MNC_PH_CD = PHARMACY_M01.MNC_PH_CD " +
                    " where " +
                    //" --t01.MNC_DATE BETWEEN '' AND '' and " +
                    " t01.mnc_hn_no = '" + hn + "' " +
                    //" t01.mnc_hn_no = '"+hn+"' "+
                    " and t01.MNC_PRE_NO = '" + preno + "' " +
                    " and t01.mnc_vn_no = '" + vn1[0] + "' " +
                     " and t01.mnc_vn_seq = '" + vn1[1] + "' " +
                      " and t01.mnc_vn_sum = '" + vn1[2] + "' " +
                    //" and pharmacy_m01.MNC_PH_TN like '(%' " +
                    //" and t01.mnc_vn_no = '58' and t01.MNC_PRE_NO = '61' " +
                    " and phart05.MNC_CFR_STS = 'a' " +
                    " Group By phart06.MNC_PH_CD, pharmacy_m01.MNC_PH_TN ,PHARMACY_M05.MNC_PH_PRI01,PHARMACY_M05.MNC_PH_PRI02,phart05.MNC_CFG_DAT " +
                    " Order By phart05.MNC_CFG_DAT,phart06.MNC_PH_CD ";
            dt = connMainHIS5.selectData(sql);
            return dt;
        }
        /**

        */
        public int selectNHSOPrintHN1(String startDate, String hn, String preno, String vn)
        {
            DataTable dt = new DataTable();
            String sql = "";
            String[] vn1 = vn.Split('.');
            int chk = 0;
            sql = "Select count(1) as cnt " +
                    " From PATIENT_T01 t01 " +
                    " left join PHARMACY_T05 phart05 on t01.MNC_PRE_NO = phart05.MNC_PRE_NO and t01.MNC_date = phart05.mnc_date " +
                    " left join PHARMACY_T06 phart06 on phart05.MNC_CFR_NO = phart06.MNC_CFR_NO and phart05.MNC_CFG_DAT = phart06.MNC_CFR_dat " +
                    " left join PHARMACY_M01 on phart06.MNC_PH_CD = pharmacy_m01.MNC_PH_CD " +
                    " left join PHARMACY_M05 on PHARMACY_M05.MNC_PH_CD = PHARMACY_M01.MNC_PH_CD " +
                    " where " +
                    //" --t01.MNC_DATE BETWEEN '' AND '' and " +
                    " phart05.mnc_hn_no = '" + hn + "' " +
                    //" t01.mnc_hn_no = '"+hn+"' "+
                    " and phart05.MNC_PRE_NO = '" + preno + "' " +
                    //" and t01.mnc_vn_no = '" + vn1[0] + "' " +
                     //" and t01.mnc_vn_seq = '" + vn1[1] + "' " +
                      //" and t01.mnc_vn_sum = '" + vn1[2] + "' " +
                    //" --PHARMACY_M01.mnc_ph_typ_flg = 'P' " +
                    " and pharmacy_m01.MNC_PH_TN like '(%' " +
                    " and phart05.MNC_CFR_STS = 'a' ";
                    //" Group By phart06.MNC_PH_CD, pharmacy_m01.MNC_PH_TN ,PHARMACY_M05.MNC_PH_PRI01,PHARMACY_M05.MNC_PH_PRI02,phart05.MNC_CFG_DAT " +
                    //" Order By phart05.MNC_CFG_DAT,phart06.MNC_PH_CD ";
            dt = connMainHIS5.selectData(sql);
            return int.Parse(dt.Rows[0]["cnt"].ToString());
        }
        public String selectOPDViewOR(String hn)
        {
            DataTable dt = new DataTable();
            String sql = "", chk="-";
            sql = "Select Distinct t01.mnc_date " +
                "From PATIENT_T01 t01 "
                + "left JOIN PATIENT_M01 AS m01 ON t01.MNC_HN_NO = m01.MNC_HN_NO " +
                "left JOIN  PATIENT_M02 AS m02 ON m02.MNC_PFIX_CD = m01.MNC_PFIX_CDT  " +
                "inner JOIN  PATIENT_T12 AS t12 ON t12.MNC_HN_NO = m01.MNC_HN_NO and t01.mnc_date = t12.mnc_date and t12.mnc_pre_no = t01.mnc_pre_no " +
                " inner join FINANCE_M02 f02 ON t01.MNC_FN_TYP_CD = f02.MNC_FN_TYP_CD " +
                //"left join PATIENT_M18 on patient_t01.MNC_DIA_DEAD = PATIENT_M18.MNC_DIA_CD " +
                " inner join patient_m26 on t01.mnc_dot_cd = patient_m26.MNC_DOT_CD " +
                " inner join patient_m02 on patient_m26.MNC_DOT_PFIX =patient_m02.MNC_PFIX_CD " +
                "where t01.MNC_hn_no = '" + hn + "' ";
            dt = connMainHIS5.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    chk += cf.dateLabExShow(dt.Rows[0]["mnc_date"].ToString())+" ";
                }
            }
            return chk;
        }
        public String selectOPDViewHistory(String hn, String preno, String vn)
        {
            DataTable dt = new DataTable();
            String sql = "", chk = "-";
            sql = "Select Distinct t01.mnc_date " +
                "From PATIENT_T01 t01 "
                + "left JOIN PATIENT_M01 AS m01 ON t01.MNC_HN_NO = m01.MNC_HN_NO " 
                //+ " t01.MNC_DATE <>  t01.MNC_DATE " 
                +"where t01.MNC_hn_no = '" + hn + "' "+
                " and t01.MNC_PRE_NO <> '" + preno + "' " +
                " and t01.mnc_vn_no <> '" + vn + "' " ;
            dt = connMainHIS5.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    chk += cf.dateLabExShow(dt.Rows[0]["mnc_date"].ToString()) + " ";
                }
            }
            return chk;
        }
        public DataTable selectNHSOPrint(String startDate, String endDate, String fncd)
        {
            DataTable dt = new DataTable();
            String sql = "";
            sql = fncd.Equals("") ? "Select Distinct t01.mnc_hn_no, t01.MNC_PRE_NO ,t01.mnc_vn_no, m02.MNC_PFIX_DSC, m01.MNC_FNAME_T, m01.MNC_LNAME_T,t01.MNC_VN_SEQ,t01.MNC_VN_SUM,f02.MNC_FN_TYP_DSC, "+

                "t01.MNC_DATE,patient_m02.MNC_PFIX_DSC as prefix,patient_m26.MNC_DOT_FNAME as Fname,patient_m26.MNC_DOT_LNAME as Lname,t01.mnc_dot_cd, M01.MNC_BDAY, m01.mnc_id_no, t08.mnc_ds_date, t01.mnc_time, t01.mnc_weight " +
                "From PATIENT_T01 t01 "
                + "left JOIN PATIENT_M01 AS m01 ON t01.MNC_HN_NO = m01.MNC_HN_NO " +
                "left JOIN  PATIENT_M02 AS m02 ON m02.MNC_PFIX_CD = m01.MNC_PFIX_CDT  "+
                //"inner JOIN  PATIENT_T12 AS t12 ON t12.MNC_HN_NO = t01.MNC_HN_NO and t01.mnc_date = t12.mnc_date and t12.mnc_pre_no = t01.mnc_pre_no " +
                "inner JOIN  PATIENT_T12 AS t12 ON t12.MNC_HN_NO = t01.MNC_HN_NO  and t12.mnc_pre_no = t01.mnc_pre_no " +
                " inner join FINANCE_M02 f02 ON t01.MNC_FN_TYP_CD = f02.MNC_FN_TYP_CD " +
                //"left join PATIENT_M18 on patient_t01.MNC_DIA_DEAD = PATIENT_M18.MNC_DIA_CD " +
                " inner join patient_m26 on t01.mnc_dot_cd = patient_m26.MNC_DOT_CD " +
                " inner join patient_m02 on patient_m26.MNC_DOT_PFIX =patient_m02.MNC_PFIX_CD " +
                "inner join PATIENT_T08 t08 on t01.MNC_PRE_NO = t08.MNC_PRE_NO and t01.MNC_date = t08.MNC_date " +
                "where t08.MNC_ds_DATE >= '" + startDate + "'  and t08.MNC_ds_DATE <= '" + endDate + "'" 
                : "Select Distinct t01.mnc_hn_no, t01.MNC_PRE_NO ,t01.mnc_vn_no,m02.MNC_PFIX_DSC, m01.MNC_FNAME_T, m01.MNC_LNAME_T,t01.MNC_VN_SEQ,t01.MNC_VN_SUM,f02.MNC_FN_TYP_DSC "+
                "t01.MNC_DATE,patient_m02.MNC_PFIX_DSC as prefix,patient_m26.MNC_DOT_FNAME as Fname,patient_m26.MNC_DOT_LNAME as Lname,t01.mnc_dot_cd, M01.MNC_BDAY, m01.mnc_id_no, t08.mnc_ds_date, t01.mnc_time, t01.mnc_weight " +
                "From PATIENT_T01 t01 "
                + "left JOIN PATIENT_M01 AS m01 ON t01.MNC_HN_NO = m01.MNC_HN_NO " +
                "left JOIN  PATIENT_M02 AS m02 ON m02.MNC_PFIX_CD = m01.MNC_PFIX_CDT  "+
                //"inner JOIN  PATIENT_T12 AS t12 ON t12.MNC_HN_NO = t01.MNC_HN_NO and t01.mnc_date = t12.mnc_date and t12.mnc_pre_no = t01.mnc_pre_no " +
                "inner JOIN  PATIENT_T12 AS t12 ON t12.MNC_HN_NO = t01.MNC_HN_NO and t12.mnc_pre_no = t01.mnc_pre_no " +
                " inner join FINANCE_M02 f02 ON t01.MNC_FN_TYP_CD = f02.MNC_FN_TYP_CD " +
                " inner join patient_m26 on t01.mnc_dot_cd = patient_m26.MNC_DOT_CD " +
                " inner join patient_m02 on patient_m26.MNC_DOT_PFIX =patient_m02.MNC_PFIX_CD " +
                "inner join PATIENT_T08 t08 on t01.MNC_PRE_NO = t08.MNC_PRE_NO and t01.MNC_date = t08.MNC_date " +
                "where t01.MNC_FN_TYP_CD = '"
                + fncd + "' and t08.MNC_ds_DATE >= '" + startDate + "'  and t08.MNC_ds_DATE <= '" + endDate + "' ";
            dt = connMainHIS5.selectData(sql);
            return dt;
        }
        public String selectDiaCDbyVN(String hn, String vn, String preNo)
        {
            String sql = "";
            DataTable dt = new DataTable();
            String[] vn1 = vn.Split('.');
            sql = "Select t09.MNC_DIA_CD, mnc_cause_cd " +
                "From PATIENT_T01 t01 " +
                "left join PATIENT_T09 t09 on t01.MNC_PRE_NO = t09.MNC_PRE_NO and t01.MNC_date = t09.MNC_date " +
                "where  t01.mnc_hn_no = '" + hn + "' " +
                    " and t01.mnc_vn_no = '" + vn1[0] + "' " +
                     " and t01.mnc_vn_seq = '" + vn1[1] + "' " +
                      " and t01.mnc_vn_sum = '" + vn1[2] + "' " +
                "and t01.mnc_pre_no = '" + preNo + "' Order By mnc_dia_flg asc";
            //"Order By t01.mnc_date, t01.mnc_hn_no ";
            dt = connMainHIS5.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                sql = "";
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    sql += dt.Rows[i]["MNC_DIA_CD"].ToString()+" "+ dt.Rows[i]["mnc_cause_cd"].ToString().Trim() + ",";
                }
            }
            sql = sql.Substring(sql.Length-1).Equals(",") ? sql.Substring(0, sql.Length - 1) : sql;
            return sql;
        }
        public String selectICD9byVN(String hn, String vn, String preNo)
        {
            String sql = "";
            DataTable dt = new DataTable();
            String[] vn1 = vn.Split('.');
            sql = "Select t19.MNC_DIAor_CD " +
                "From PATIENT_T01 t01 " +
                "left join PATIENT_T19 t19 on t01.MNC_PRE_NO = t19.MNC_PRE_NO and t01.MNC_date = t19.MNC_date " +
                "where  t01.mnc_hn_no = '" + hn + "' " +
                    " and t01.mnc_vn_no = '" + vn1[0] + "' " +
                     " and t01.mnc_vn_seq = '" + vn1[1] + "' " +
                      " and t01.mnc_vn_sum = '" + vn1[2] + "' " +
                "and t01.mnc_pre_no = '" + preNo + "' Order By mnc_diaor_flg asc";
            //"Order By t01.mnc_date, t01.mnc_hn_no ";
            dt = connMainHIS5.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                sql = "";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sql += dt.Rows[i]["MNC_DIAor_CD"].ToString() + ",";
                }
            }
            
            sql = sql.Substring(sql.Length-1).Equals(",") ? sql.Substring(0, sql.Length - 1) : sql;
            return sql;
        }
        public String selectDSDate(String hn, String vn, String preNo)
        {
            String sql = "";
            DataTable dt = new DataTable();
            String[] vn1 = vn.Split('.');
            sql = "Select t08.MNC_ds_date, t08.mnc_ds_time " +
                "From PATIENT_T01 t01 " +
                "left join PATIENT_T08 t08 on t01.MNC_PRE_NO = t08.MNC_PRE_NO and t01.MNC_date = t08.MNC_date " +
                "where  t01.mnc_hn_no = '" + hn + "' " +
                    " and t01.mnc_vn_no = '" + vn1[0] + "' " +
                     " and t01.mnc_vn_seq = '" + vn1[1] + "' " +
                      " and t01.mnc_vn_sum = '" + vn1[2] + "' " +
                "and t01.mnc_pre_no = '" + preNo + "'";
            //"Order By t01.mnc_date, t01.mnc_hn_no ";
            dt = connMainHIS5.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                sql = dt.Rows[0]["MNC_ds_date"].ToString()+"*"+ FormatTime(dt.Rows[0]["mnc_ds_time"].ToString());
            }
            return sql;
        }
        public String selectDSDateAN(String hn, String vn, String preNo)
        {
            String sql = "", an="";
            DataTable dt = new DataTable();
            String[] vn1 = vn.Split('.');
            sql = "Select t08.MNC_ds_date, t08.mnc_ds_time, t08.mnc_an_no, t08.mnc_an_yr " +
                "From PATIENT_T01 t01 " +
                "left join PATIENT_T08 t08 on t01.MNC_PRE_NO = t08.MNC_PRE_NO and t01.MNC_date = t08.MNC_date " +
                "where  t01.mnc_hn_no = '" + hn + "' " +
                    " and t01.mnc_vn_no = '" + vn1[0] + "' " +
                     " and t01.mnc_vn_seq = '" + vn1[1] + "' " +
                      " and t01.mnc_vn_sum = '" + vn1[2] + "' " +
                "and t01.mnc_pre_no = '" + preNo + "'";
            //"Order By t01.mnc_date, t01.mnc_hn_no ";
            dt = connMainHIS5.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                sql = dt.Rows[0]["MNC_ds_date"].ToString() + "*" + FormatTime(dt.Rows[0]["MNC_ds_time"].ToString()) + "," + dt.Rows[0]["mnc_an_no"].ToString() + "/" + dt.Rows[0]["mnc_an_yr"].ToString();
            }
            return sql;
        }
        //public DataTable selectNHSOPrintHn(String hn, String vn, String preno)
        //{
        //    String sql = "";
        //    DataTable dt = new DataTable();
        //    sql = "Select phart06.MNC_PH_CD, pharmacy_m01.MNC_PH_TN ,PHARMACY_M05.MNC_PH_PRI01,PHARMACY_M05.MNC_PH_PRI02,sum(phart06.MNC_PH_QTY)--,phart06.* "+
        //            "From PATIENT_T01 t01 " +
        //            "left join PHARMACY_T05 phart05 on t01.MNC_PRE_NO = phart05.MNC_PRE_NO and t01.MNC_date = phart05.mnc_date " +
        //            "left join PHARMACY_T06 phart06 on phart05.MNC_CFR_NO = phart06.MNC_CFR_NO and phart05.MNC_CFG_DAT = phart06.MNC_CFR_dat " +
        //            "left join PHARMACY_M01 on phart06.MNC_PH_CD = pharmacy_m01.MNC_PH_CD " +
        //            "left join PHARMACY_M05 on PHARMACY_M05.MNC_PH_CD = PHARMACY_M01.MNC_PH_CD " +
        //            "where " +                                
        //             "t01.mnc_hn_no = '"+hn+"' " +                    
        //            "--PHARMACY_M01.mnc_ph_typ_flg = 'P' " +
        //            "and t01.mnc_vn_no = '"+vn+"' and t01.MNC_PRE_NO = '"+preno+"' " +
        //            "and phart05.MNC_CFR_STS = 'a' " +
        //            "Group By phart06.MNC_PH_CD, pharmacy_m01.MNC_PH_TN ,PHARMACY_M05.MNC_PH_PRI01,PHARMACY_M05.MNC_PH_PRI02 " +
        //            "Order By phart06.MNC_PH_CD";

        //    return dt;
        //}
        public String getValueCboItem(ComboBox c)
        {
            ComboBoxItem iSale;
            iSale = (ComboBoxItem)c.SelectedItem;
            if (iSale == null)
            {
                return "";
            }
            else
            {
                return iSale.Value;
            }
        }
        private void setThoColor()
        {
            Font1 f1 = new Font1();
            f1.id = "1";
            f1.BackColor = "#F37257";
            f1.foreColor = "";
            thoColor.Add(f1);
            Font1 f2 = new Font1();
            f2.id = "2";
            f2.BackColor = "#F68D5C";
            f2.foreColor = "";
            thoColor.Add(f2);
            Font1 f3 = new Font1();
            f3.id = "3";
            f3.BackColor = "#F4D27A";
            f3.foreColor = "";
            thoColor.Add(f3);
            Font1 f4 = new Font1();
            f4.id = "4";
            f4.BackColor = "#517281";
            f4.foreColor = "";
            thoColor.Add(f4);
            Font1 f5 = new Font1();
            f5.id = "5";
            f5.BackColor = "#7895A2";
            f5.foreColor = "#000000";
            thoColor.Add(f5);
            Font1 f6 = new Font1();
            f6.id = "6";
            f6.BackColor = "#AFC1CC";
            f6.foreColor = "#000000";
            thoColor.Add(f6);
            Font1 f7 = new Font1();
            f7.id = "7";
            f7.BackColor = "#E96D63";
            f7.foreColor = "#000000";
            thoColor.Add(f7);
            Font1 f8 = new Font1();
            f8.id = "8";
            f8.BackColor = "#7FCA9F";
            f8.foreColor = "#000000";
            thoColor.Add(f8);
            Font1 f9 = new Font1();
            f9.id = "9";
            f9.BackColor = "#F4BA70";
            f9.foreColor = "#000000";
            thoColor.Add(f9);
            Font1 f10 = new Font1();
            f10.id = "10";
            f10.BackColor = "#85C1F5";
            f10.foreColor = "#000000";
            thoColor.Add(f10);
            Font1 f11 = new Font1();
            f11.id = "11";
            f11.BackColor = "#4A789C";
            f11.foreColor = "#000000";
            thoColor.Add(f11);
        }
        public String getThooBackColor(String thoId)
        {
            String aa = "#FFFFFF";
            Font1 i = new Font1();
            foreach (Font1 t in thoColor)
            {
                if (t.id.Equals(thoId))
                {
                    aa = t.BackColor;
                }
            }
            return aa;
        }
        public void DeleteFileImage(String fileName)
        {
            //String file1 = fileName.Replace("_0", "_1");
            System.IO.File.Delete(fileName);
        }
        public String FormatTime(String t)
        {
            String aa = "";
            aa = "0000" + t;
            if (aa.Length >= 4)
            {
                aa = aa.Substring(aa.Length - 4, 2) + ":" + aa.Substring(aa.Length - 2);
            }
            return aa;
        }
        //public String getThooBackColorByThoId(String thoId)
        //{
        //    String aa = "#FFFFFF";
        //    //Font1 i = new Font1();
        //    foreach (Thoo t in lTho)
        //    {
        //        if (t.Id.Equals(thoId))
        //        {
        //            aa = getThooBackColor(t.Color);
        //        }
        //    }
        //    return aa;
        //}
        public String selectDoctorName(String doctorId)
        {
            DataTable dt = new DataTable();
            String sql = "", chk = "-";
            sql = "Select  patient_m02.MNC_PFIX_DSC as prefix,patient_m26.MNC_DOT_FNAME as Fname,patient_m26.MNC_DOT_LNAME as Lname " +
                "From  patient_m26  " +
                " inner join patient_m02 on patient_m26.MNC_DOT_PFIX =patient_m02.MNC_PFIX_CD " +
                "where patient_m26.MNC_DOT_CD = '" + doctorId + "' ";
            dt = connMainHIS5.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                chk = dt.Rows[0]["prefix"].ToString()+" "+dt.Rows[0]["Fname"].ToString()+" "+dt.Rows[0]["Lname"].ToString();
            }
            return chk;
        }
        public DataTable selectCHeckDrug(String txt)
        {
            DataTable dt = new DataTable();
            String sql = "", chk = "-";
            sql = "Select m01.*,m05.MNC_PH_PRI01 " +
                    "From PHARMACY_M01 m01 " +
                    "Left join PHARMACY_M05 m05 on m01.MNC_PH_CD = m05.MNC_PH_CD " +
                    "Where MNC_PH_TN like '%"+ txt + "%' ";
            dt = connMainHIS5.selectData(sql);
            //if (dt.Rows.Count > 0)
            //{
            //    chk = dt.Rows[0]["prefix"].ToString() + " " + dt.Rows[0]["Fname"].ToString() + " " + dt.Rows[0]["Lname"].ToString();
            //}
            return dt;
        }
        public DataTable selectFnType(String branchId)
        {
            DataTable dt = new DataTable();
            String sql = "", chk = "-";
            if (branchId.Equals("001"))
            {
                sql = "Select * From from FINANCE_M02 ";
                dt = connMainHIS5.selectData(connMainHIS5.connMainHIS1, sql);
            }
            else
            {
                sql = "Select * From FINANCE_M02 ";
                dt = connMainHIS5.selectData(connMainHIS5.connMainHIS5, sql);
            }
            
            //if (dt.Rows.Count > 0)
            //{
            //    chk = dt.Rows[0]["prefix"].ToString() + " " + dt.Rows[0]["Fname"].ToString() + " " + dt.Rows[0]["Lname"].ToString();
            //}
            return dt;
        }
        public ComboBox getCboFnType(ComboBox c, String branchId)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectFnType(branchId);
            //String aaa = "";
            ComboBoxItem item1 = new ComboBoxItem();
            item1.Text = "";
            item1.Value = "000";
            c.Items.Add(item1);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Text = dt.Rows[i]["MNC_FN_TYP_DSC"].ToString();
                item.Value = dt.Rows[i]["MNC_FN_TYP_CD"].ToString();
                //item.Text = dt.Rows[i][cu.NameT].ToString();
                c.Items.Add(item);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return c;
        }
    }
}
