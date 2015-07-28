﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace reportBangna.object1
{
    public class Config1
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
            var items = new[]{
                new{Text = "มกราคม", Value="01"},
                new{Text = "กุมภาพันธ์", Value="02"},
                new{Text = "มีนาคม", Value="03"},
                new{Text = "เมษายน", Value="04"},
                new{Text = "พฤษภาคม", Value="05"},
                new{Text = "มิถุนายน", Value="06"},
                new{Text = "กรกฎาคม", Value="07"},
                new{Text = "สิงหาคม", Value="08"},
                new{Text = "กันยายน", Value="09"},
                new{Text = "ตุลาคม", Value="10"},
                new{Text = "พฤศจิกายน", Value="11"},
                new{Text = "ธันวาคม", Value="12"}
            };
            c.DataSource = items;
            c.DisplayMember = "Text";

            c.ValueMember = "Value";
            //c.SelectedIndex = c.FindStringExact(getMonth(System.DateTime.Now.Month.ToString("00")));
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
        public ComboBox setCboBranch(ComboBox c)
        {
            var items = new[]{
                new{Text = "bangna1", Value="001"},
                new{Text = "bangna2", Value="002"},
                new{Text = "bangna5", Value="005"}
            };
            c.Items.Clear();
            c.DataSource = items;
            c.DisplayMember = "Text";

            c.ValueMember = "Value";
            return c;
        }
        public ComboBox setCboLab(ComboBox c)
        {
            var items = new[] { 
                new { Text = "", Value = "" }, 
                new { Text = "SUGAR (FBS)", Value = "ch002" }, 
                new { Text = "Sugar <BS> : NaF tube 2.5 ml", Value = "ch250" }, 
                new { Text = "BUN", Value = "ch003" },
                new { Text = "CREATININE", Value = "ch004" },
                new { Text = "Free T3(FT3) (Outlab/Medica lab)", Value = "ch040" },
                new { Text = "Free T4(FT4) (Out lab/Medica LAB)", Value = "ch037" },
                new { Text = "TSH (Out lab/ MEDICA LAB)", Value = "ch039" },
                new { Text = "T4 (Outlab/Medica)", Value = "ch036" },
                new { Text = "T3 (Outlab/Medica)", Value = "ch038" },
                new { Text = "ANTI HIV  (Screening  Method)", Value = "se005" },
                new { Text = "HBsAg", Value = "se038" },
                new { Text = "ANTI HCV", Value = "se047" },
                new { Text = "CHOLESTEROL", Value = "ch006" },
                new { Text = "TRIGLYCERIDE", Value = "ch007" },
                new { Text = "HDL-C", Value = "ch008" },
                new { Text = "LDL-C", Value = "ch009" },
                new { Text = "CD4 ", Value = "se165" },
                new { Text = "CBC", Value = "he001" },
                new { Text = "HbA1C", Value = "ch035" },
                new { Text = "Vival Load se161", Value = "se161" },
                new { Text = "Vival Load se244", Value = "se244" }
            };
            c.Items.Clear();
            c.DataSource = items;
            c.DisplayMember = "Text";
            c.ValueMember = "Value";
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
                return "พฤษภาคม";
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
        public String stringNull1(Object txt)
        {
            if (txt == null)
            {
                return "";
            }
            else
            {
                return txt.ToString();
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
        public String dateShowtoDB(String dt)
        {
            if (dt != "")
            {
                return dt.Substring(6, 4) + "-" + dt.Substring(3, 2) + "-" + dt.Substring(0, 2);
            }
            else
            {
                return dt;
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
        public String dateDBtoShow1(String dt)
        {
            if (dt != "")
            {
                return dt.Substring(8, 2) + "-" + dt.Substring(5, 2) + "-" +dt.Substring(0, 4);
            }
            else
            {
                return dt;
            }
        }
        public String dateDBtoShow(DateTime dt)
        {
            if (dt != null)
            {
                return dt.Day.ToString("00") + "-" + dt.Month.ToString("00") + "-" + String.Concat(dt.Year+543);
            }
            else
            {
                return "";
            }
        }
        public String dateDBtoShow25(String dt)
        {
            if (dt != "")
            {
                return dt.Substring(8, 2) + "-" + dt.Substring(5, 2) + "-" + dt.Substring(0, 4);
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
