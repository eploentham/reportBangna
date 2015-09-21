using reportBangna.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace reportBangna.objdb
{
    public class StVendorDB
    {
        private ConnectDB connBua;
        public StVendor ven;
        public ConnectDB connMainHIS;
        private LogWriter lw;
        public StVendorDB(ConnectDB c)
        {
            connBua = c;
            initConfig();
        }
        private void initConfig()
        {
            lw = new LogWriter();
            connMainHIS = new ConnectDB("mainhis");
            ven = new StVendor();
            ven.Active = "ven_active";
            ven.AddrE = "addr_e";
            ven.AddrT = "addr_t";
            ven.AddressE = "address_e";
            ven.AddressT = "address_t";
            ven.amphurId = "amphur_id";
            ven.Code = "ven_code";
            ven.CodeBng = "ven_code_bng";
            ven.ContactEmail = "contact_email";
            ven.ContactName = "contact_name";
            ven.ContactTel = "contact_tel";
            ven.districtId = "distinct_id";
            ven.Fax = "fax";
            ven.Id = "ven_id";
            ven.NameE = "ven_name_e";
            ven.NameT = "ven_name_t";
            ven.provinceId = "province_id";
            ven.Remark = "remark";
            ven.TaxId = "taxid";
            ven.Tele = "telephone";
            ven.WebSite = "website";
            ven.Zipcode = "zipcode";

            ven.table = "stock_b_vendor";
            ven.pkField = "ven_id";
        }
        private StVendor setData(StVendor p, DataTable dt)
        {
            p.Active = dt.Rows[0][ven.Active].ToString();
            p.AddrE = dt.Rows[0][ven.AddrE].ToString();
            p.AddrT = dt.Rows[0][ven.AddrT].ToString();
            p.AddressE = dt.Rows[0][ven.AddressE].ToString();
            p.AddressT = dt.Rows[0][ven.AddressT].ToString();
            p.amphurId = dt.Rows[0][ven.amphurId].ToString();
            p.Code = dt.Rows[0][ven.Code].ToString();
            p.CodeBng = dt.Rows[0][ven.CodeBng].ToString();
            p.ContactEmail = dt.Rows[0][ven.ContactEmail].ToString();
            p.ContactName = dt.Rows[0][ven.ContactName].ToString();
            p.ContactTel = dt.Rows[0][ven.ContactTel].ToString();
            p.districtId = dt.Rows[0][ven.districtId].ToString();
            p.Fax = dt.Rows[0][ven.Fax].ToString();
            p.Id = dt.Rows[0][ven.Id].ToString();
            p.NameE = dt.Rows[0][ven.NameE].ToString();
            p.NameT = dt.Rows[0][ven.NameT].ToString();
            p.provinceId = dt.Rows[0][ven.provinceId].ToString();
            p.Remark = dt.Rows[0][ven.Remark].ToString();
            p.TaxId = dt.Rows[0][ven.TaxId].ToString();
            p.Tele = dt.Rows[0][ven.Tele].ToString();
            p.WebSite = dt.Rows[0][ven.WebSite].ToString();
            p.Zipcode = dt.Rows[0][ven.Zipcode].ToString();

            return p;
        }
        public StVendor selectByPk(String id)
        {
            StVendor item = new StVendor();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + ven.table + " Where " + ven.pkField + "='" + id + "'";
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
            sql = "Select * From " + ven.table + " Where " + ven.Active + "='1'";
            dt = connBua.selectData(sql);
            
            return dt;
        }
        private String insert(StVendor p)
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
                sql = "Insert Into " + ven.table + "(" + ven.pkField + "," + ven.Active + "," + ven.AddrE + "," +
                    ven.AddrT + "," + ven.AddressE + "," + ven.AddressT + "," +
                    ven.amphurId + "," + ven.Code + "," + ven.CodeBng + "," +
                    ven.ContactEmail + "," + ven.ContactName + "," + ven.ContactTel + "," +
                    ven.districtId + "," + ven.Fax + "," + ven.NameE + "," +
                    ven.NameT + "," + ven.provinceId + "," + ven.Remark + "," +
                    ven.TaxId + "," + ven.Tele + "," + ven.WebSite + "," +
                    ven.Zipcode + ") " +
                    "Values('" + p.Id + "','" + p.Active + "','" + p.AddrE + "','" +
                    p.AddrT + "','" + p.AddressE + "','" + p.AddressT + "','" +
                    p.amphurId + "','" + p.Code + "','" + p.CodeBng + "','" +
                    p.ContactEmail + "','" + p.ContactName + "','" + p.ContactTel + "','" +
                    p.districtId + "','" + p.Fax + "','" + p.NameE + "','" +
                    p.NameT + "','" + p.provinceId + "','" + p.Remark + "','" +
                    p.TaxId + "','" + p.Tele + "','" + p.WebSite + "','" +
                    p.Zipcode + "') ";
                chk = connBua.ExecuteNonQuery(sql);
                //chk = p.RowNumber;
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "insert StVendor");
            }

            return chk;
        }
        public String update(StVendor p)
        {
            String sql = "", chk = "";
            try
            {
                //p.dateModi = " CAST(year(GETDATE()) AS NVARCHAR)+'-'+ RIGHT('00' + CAST(month(GETDATE()) AS NVARCHAR), 2)+'-'+ RIGHT('00' + CAST(day(GETDATE()) AS NVARCHAR), 2)";
                sql = "Update " + ven.table + " Set " + ven.AddrE + "='" + p.AddrE + "'," +
                    ven.AddrT + "='" + p.AddrT + "'," +
                    ven.AddressE + "='" + p.AddressE + "'," +
                    ven.AddressT + "='" + p.AddressT + "'," +
                    ven.amphurId + "='" + p.amphurId + "'," +
                    ven.Code + "='" + p.Code + "'," +
                    ven.CodeBng + "='" + p.CodeBng + "'," +
                    ven.ContactEmail + "='" + p.ContactEmail + "'," +
                    ven.ContactName + "='" + p.ContactName + "'," +
                    ven.ContactTel + "='" + p.ContactTel + "'," +
                    ven.districtId + "='" + p.districtId + "', " +
                    ven.Fax + "='" + p.Fax + "', " +
                    ven.NameE + "='" + p.NameE + "', " +
                    ven.NameT + "='" + p.NameT + "', " +
                    ven.provinceId + "='" + p.provinceId + "', " +
                    ven.Remark + "='" + p.Remark + "', " +
                    ven.TaxId + "='" + p.TaxId + "', " +
                    ven.Tele + "='" + p.Tele + "', " +
                    ven.WebSite + "='" + p.WebSite + "', " +
                    ven.Zipcode + "='" + p.Zipcode + "' " +

                    "Where " + ven.pkField + "='" + p.Id + "'";
                chk = connBua.ExecuteNonQuery(sql);
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update StVendor");
            }
            return chk;
        }
        public String insertVendor(StVendor p)
        {
            StVendor item = new StVendor();
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
        public String VoidStVendor(String Id)
        {
            String sql = "", chk = "";
            sql = "Update " + ven.table + " Set " + ven.Active + " = '3' " +
                "Where " + ven.pkField + "='" + Id + "'";
            try
            {
                chk = connBua.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
            }

            return chk;
        }
        public ComboBox getCboVendor(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectAll();
            //String aaa = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][ven.Id].ToString();
                item.Text = dt.Rows[i][ven.NameT].ToString();
                c.Items.Add(item);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return c;
        }
    }
}
