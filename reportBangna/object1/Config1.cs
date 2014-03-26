using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace reportBangna.object1
{
    class Config1
    {
        public ComboBox setCboYear(ComboBox c)
        {
            c.Items.Clear();
            c.Items.Add(System.DateTime.Now.Year+543);
            c.Items.Add(System.DateTime.Now.Year+543 - 1);
            c.Items.Add(System.DateTime.Now.Year+543 - 2);
            c.SelectedIndex = c.FindStringExact( String.Concat(System.DateTime.Now.Year+543));
            return c;
        }
        public ComboBox setCboMonth(ComboBox c)
        {
            c.Items.Clear();
            c.Items.Add("มกราคม");
            c.Items.Add("กุมภาพันธ์");
            c.Items.Add("มีนาคม");
            c.Items.Add("เมษายน");
            c.Items.Add("พฤษาคม");
            c.Items.Add("มิถุนายน");
            c.Items.Add("กรกฎาคม");
            c.Items.Add("สิงหาคม");
            c.Items.Add("กันยายน");
            c.Items.Add("ตุลาคม");
            c.Items.Add("พฤศจิกายน");
            c.Items.Add("ธันวาคม");
            c.SelectedIndex = c.FindStringExact(getMonth(System.DateTime.Now.Month.ToString("00")));
            return c;
        }
        public ComboBox setCboDoctor(ComboBox c)
        {
            c.Items.Clear();
            c.Items.Add("แพทย์หญิง กรกนก  ดีสุคนธ์");
            c.Items.Add("แพทย์หญิง อรวรรณ  แซ่เฉิน");
            c.Items.Add("นายแพทย์ ชุตินันท์ พรหมมินทร์");
            
            //c.Items.Add("พ.ญ. อรวรรณ  แซ่เฉิน");
            return c;
        }
        public String getMonth(String monthId)
        {
            if (monthId == "01")
            {
                return "มกราคม";
            }
            else if (monthId == "02")
            {
                return "กุมภาพันธ์";
            }
            else if (monthId == "03")
            {
                return "มีนาคม";
            }
            else if (monthId == "04")
            {
                return "เมษายน";
            }
            else if (monthId == "05")
            {
                return "พฤษาคม";
            }
            else if (monthId == "06")
            {
                return "มิถุนายน";
            }
            else if (monthId == "07")
            {
                return "กรกฎาคม";
            }
            else if (monthId == "08")
            {
                return "สิงหาคม";
            }
            else if (monthId == "09")
            {
                return "กันยายน";
            }
            else if (monthId == "10")
            {
                return "ตุลาคม";
            }
            else if (monthId == "11")
            {
                return "พฤศจิกายน";
            }
            else if (monthId == "12")
            {
                return "ธันวาคม";
            }
            else
            {
                return "";
            }
        }
        public String stringNull(String txt)
        {
            if (txt == null)
            {
                return "";
            }
            else
            {
                return txt;
            }
        }
        public String datetoDB(object dt)
        {
            DateTime dt1 = new DateTime();
            try
            {
                if (dt == null)
                {
                    return "";
                }
                else if (dt == "")
                {
                    return "";
                }
                else
                {
                    dt1 = DateTime.Parse(dt.ToString());
                    if (dt1.Year <= 1500)
                    {
                        return String.Concat((dt1.Year+543), "-") + dt1.Month.ToString("00") + "-" + dt1.Day.ToString("00");
                    }
                    else
                    {
                        return dt1.Year.ToString() + "-" + dt1.Month.ToString("00") + "-" + dt1.Day.ToString("00");
                    }
                    
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
        }
        public String dateDBtoShow(String dt)
        {
            if (dt != "")
            {
                return dt.Substring(8,2)+"-"+dt.Substring(5,2) + "-" + String.Concat(Int16.Parse(dt.Substring(0, 4))+543);
            }
            else
            {
                return dt;
            }
        }
        public String ObjectNull(object o)
        {
            if (o == null)
            {
                return "";
            }
            else
            {
                return o.ToString();
            }
        }
        public String NumberNull(object o)
        {
            float a = new float();
            try
            {
                a = float.Parse(o.ToString());
            }
            catch (Exception ex)
            {
                a = 0;
            }
            return a.ToString();
            //if (o == null)
            //{
            //    return "0";
            //}
            //else if (o.ToString() == "")
            //{
            //    return "0";
            //}
            //else
            //{
            //    return o.ToString();
            //}
        }
        public String shortPaidName(String name)
        {
            if (name == "ประกันสังคม (บ.1)")
            {
                return "ปกส(บ.1)";
            }
            else if (name == "ประกันสังคม (บ.2)")
            {
                return "ปกส(บ.2)";
            }
            else if (name == "ประกันสังคม (บ.5)")
            {
                return "ปกส(บ.5)";
            }
            else if (name == "ประกันสังคมอิสระ (บ.1)")
            {
                return "ปกต(บ.1)";
            }
            else if (name == "ประกันสังคมอิสระ (บ.5)")
            {
                return "ปกต(บ.5)";
            }
            else if (name == "ตรวจสุขภาพ (เงินสด)")
            {
                return "ตส(เงินสด)";
            }
            else if (name == "ตรวจสุขภาพ (บริษัท)")
            {
                return "ตส(บริษัท)";
            }
            else if (name == "ตรวจสุขภาพ (PACKAGE)")
            {
                return "ตส(PACKAGE)";
            }
            else if (name == "ลูกหนี้ประกันสังคม รพ.เมืองสมุทรปากน้ำ")
            {
                return "ลูกหนี้(ปากน้ำ)";
            }
            else if (name == "ลูกหนี้บางนา 1")
            {
                return "ลูกหนี้(บ.1)";
            }
            else if (name == "บริษัทประกัน")
            {
                return "บ.ประกัน";
            }
            else if (name == "ลูกหนี้ประกันสังคม รพ.เมืองสมุทรปู่เจ้า")
            {
                return "ลูกหนี้(ปู่เจ้า)";
            }
            else
            {
                return name;
            }
        }
    }
}
