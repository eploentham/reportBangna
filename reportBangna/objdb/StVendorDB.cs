using reportBangna.object1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace reportBangna.objdb
{
    public class StVendorDB
    {
        public StVendor ven;
        public ConnectDB connBua;
        private LogWriter lw;
        public StVendorDB()
        {
            initConfig();
        }
        private void initConfig()
        {
            lw = new LogWriter();
            connBua = new ConnectDB("bangna");
            ven = new StVendor();
            ven.Active = "";
            ven.Addr = "";
            ven.AddressE = "";
            ven.AddressT = "";
            ven.amphurId = "";
            ven.Code = "";
            ven.CodeBng = "";
            ven.ContactEmail = "";
            ven.ContactName = "";
            ven.ContactTel = "";
            ven.districtId = "";
            ven.Fax = "";
            ven.Id = "";
            ven.NameE = "";
            ven.NameT = "";
            ven.provinceId = "";
            ven.Remark = "";
            ven.TaxId = "";
            ven.Tele = "";
            ven.WebSite = "";
            ven.Zipcode = "";
            
        }
    }
}
