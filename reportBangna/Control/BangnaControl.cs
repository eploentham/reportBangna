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
        public ConnectDB conn;
        public Config1 cf;
        public ComboBox cboWard, cboSale, cboThoo;
        public List<Font1> thoColor = new List<Font1>();
        public BangnaControl()
        {
            conn = new ConnectDB("mainhis");
            cf = new Config1();
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
    }
}
