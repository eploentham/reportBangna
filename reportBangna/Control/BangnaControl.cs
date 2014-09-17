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
