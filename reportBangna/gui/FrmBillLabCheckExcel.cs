using reportBangna.objdb;
using reportBangna.object1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace reportBangna.gui
{
    public partial class FrmBillLabCheckExcel : Form
    {
        Config1 config1;
        public FrmBillLabCheckExcel()
        {
            InitializeComponent();
            config1 = new Config1();
            pB1.Hide();
            config1.setCboMonth(cboMonth);
            config1.setCboYear(cboYear);
            config1.setCboPeriod(cboPeriod);
            btnCheck.Enabled = false;
        }

        private void bthPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog res = new OpenFileDialog();
            res.Filter = "Excel Files|*.xls;";
            res.Filter = "All Files|*.*;";
            if (res.ShowDialog() == DialogResult.OK)
            {
                //Get the file's path
                txtPath.Text = res.FileName;
                //Do something
            }
            btnCheck.Enabled = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if(!chkBn1.Checked && !chkBn2.Checked && !chkBn5.Checked)
            {
                MessageBox.Show("Error กรุณาเลือก สาขา บางนา", "Error");
                label2.Text = "Error กรุณาเลือก สาขา บางนา";
                return;
            }
            int year = 0;
            if (!int.TryParse(cboYear.Text, out year))
            {
                MessageBox.Show("Error กรุณาเลือก ปี", "Error");
                label2.Text = "Error กรุณาเลือก ปี";
                return;
            }
            int month = 0;
            if (!int.TryParse(cboMonth.SelectedValue.ToString(), out month))
            {
                MessageBox.Show("Error กรุณาเลือก เดือน", "Error");
                label2.Text = "Error กรุณาเลือก เดือน";
                return;
            }
            int period = 0;
            if (!int.TryParse(cboPeriod.Text, out period))
            {
                MessageBox.Show("Error กรุณาเลือก งวด", "Error");
                label2.Text = "Error กรุณาเลือก งวด";
                return;
            }

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(txtPath.Text);
            //Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.ActiveSheet;
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            var hn = xlWorksheet.Cells[2, 3].Value.ToString();
            String labdate = xlRange.Cells[2, 2].Value.ToString();

            if (hn.Length > 1)
            {
                if (hn.Substring(0, 1).Equals("1") && !chkBn1.Checked)
                {
                    MessageBox.Show("", "");
                    label2.Text = "Error สาขา บางนา ไม่ถูกต้อง กับ Excel";
                    return;
                }
                if (hn.Substring(0, 1).Equals("2") && !chkBn2.Checked)
                {
                    MessageBox.Show("", "");
                    label2.Text = "Error สาขา บางนา ไม่ถูกต้อง กับ Excel";
                    return;
                }
                if (hn.Substring(0, 1).Equals("5") && !chkBn5.Checked)
                {
                    MessageBox.Show("", "");
                    label2.Text = "Error สาขา บางนา ไม่ถูกต้อง กับ Excel";
                    return;
                }
            }
            else
            {
                MessageBox.Show("", "");
                label2.Text = "Error HN Excel";
                return;
            }
            String day = "";
            int day1 = 0;
            if (labdate.Length >= 10)
            {
                day = labdate.Substring(0, 2);
                int.TryParse(day, out day1);
                if((day1>16) && !(cboPeriod.SelectedIndex==1))
                {
                    MessageBox.Show("", "");
                    label2.Text = "Error Period Excel";
                    return;
                }
                else if (((day1 >= 1)) && (day1 < 16) && (cboPeriod.SelectedIndex == 1))
                {
                    MessageBox.Show("", "");
                    label2.Text = "Error Period Excel";
                    return;
                }
            }
            else
            {
                MessageBox.Show("", "");
                label2.Text = "Error Lab Date Excel";
                return;
            }
            
            int month1 = 0;
            if (labdate.Length >= 10)
            {
                //day = labdate.Substring(3, 2);
                int.TryParse(labdate.Substring(3, 2), out month1);
                if (!(cboMonth.SelectedIndex == (month1-1)))
                {
                    MessageBox.Show("", "");
                    label2.Text = "Error Month Excel";
                    return;
                }
            }
            else
            {
                MessageBox.Show("", "");
                label2.Text = "Error Lab Month Excel";
                return;
            }
            //String hn = xlRange.Cells[2, 3];

            GC.Collect();
            GC.WaitForPendingFinalizers();

            xlWorkbook.Close();
            xlApp.Quit();

            btnCheck.Enabled = true;
            label2.Text = "จำนวนข้อมูล "+rowCount.ToString()+" รายการ";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            pB1.Show();
            Microsoft.Office.Interop.Excel.Application excelapp = new Microsoft.Office.Interop.Excel.Application();
            excelapp.Visible = false;
            //String visitDate = "", visitTime = "", err = "", err1 = "", pharName = "";

            Microsoft.Office.Interop.Excel._Workbook workbook = excelapp.Workbooks.Open(txtPath.Text);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.ActiveSheet;
            Microsoft.Office.Interop.Excel.Range xlRange = worksheet.UsedRange;
            int rowCount = xlRange.Rows.Count;
            int rowWork = 0, rowErr = 0, cntOK=0, row1=9;
            pB1.Minimum = 0;
            pB1.Maximum = rowCount;
            ////worksheet.Cells[0, 0] = "patient name";
            String hnOld = "", hn1="", flagBr="", labdateOld="", err= "", labcodeOld="", price31="";
            flagBr = chkBn1.Checked ? "1" : chkBn2.Checked ? "2" : chkBn5.Checked ? "5" : "" ;
            ConnectDB conn = new ConnectDB("mainhis", flagBr);
            conn.connMainHIS5.Open();
            Config1 cf = new Config1();
            Decimal noFind = 0, price3=0;
            try
            {
                DataTable dt = new DataTable();
                for (int i = 1; i < rowCount; i++)
                {
                    try
                    {
                        if (i == 1) continue;
                        String hn = worksheet.Cells[i, 3].Value != null ? worksheet.Cells[i, 3].Value.ToString() : "";
                        String labdate = worksheet.Cells[i, 2].Value != null ? worksheet.Cells[i, 2].Value.ToString() : "";
                        String labcode = worksheet.Cells[i, 6].Value != null ? worksheet.Cells[i, 6].Value.ToString() : "";
                        price31 = worksheet.Cells[i, 10].Value != null ? worksheet.Cells[i, 10].Value.ToString() : "";
                        if (hn.Equals(""))
                        {
                            hn = hnOld;
                        }
                        else
                        {
                            hnOld = hn;
                        }
                        if (labdate.Equals(""))
                        {
                            labdate = labdateOld;
                        }
                        else
                        {
                            labdateOld = labdate;
                        }
                        String labdate1 = "";
                        if (labdate.Length < 10) continue;
                        if (labcode.Equals(""))
                        {
                            labcode = labcodeOld;
                        }
                        else
                        {
                            labcodeOld = labcode;
                        }
                        //labdate1 = cf.datetoDB(labdate);
                        labdate1 = (int.Parse(labdate.Substring(6)) - 543) + "-" + labdate.Substring(3, 2) + "-" + labdate.Substring(0, 2);

                        String sql = "";
                        sql = "select lab_t05.MNC_req_no,LAB_T01.MNC_PRE_NO " +
                            "from PATIENT_T01 " +
                            "inner join LAB_T01 on LAB_T01.mnc_hn_no = PATIENT_T01.mnc_hn_no " +
                            "and LAB_T01.mnc_pre_no = PATIENT_T01.mnc_pre_no " +
                            "and LAB_T01.mnc_date = PATIENT_T01.MNC_DATE " +
                            "inner join LAB_T05 on lab_t05.MNC_REQ_YR = lab_t01.MNC_REQ_YR " +
                            "and lab_t05.MNC_REQ_no = lab_t01.MNC_REQ_no " +
                            "and lab_t05.MNC_REQ_dat = lab_t01.MNC_REQ_dat " +
                            "where lab_t05.MNC_REQ_DAT >= '" + labdate1 + "' " +
                            "and lab_t05.MNC_REQ_DAT <= '" + labdate1 + "' " +
                            //"and patient_t01.MNC_STS = 'f' " +
                            //"and LAB_T01.MNC_REQ_STS = 'Q' " +
                            "and LAB_T01.mnc_hn_no ='" + hn + "' " +
                            "and lab_t05.mnc_lb_cd ='" + labcode + "'";
                        dt.Clear();
                        dt = conn.selectDataNoClose(sql);
                        if (dt.Rows.Count > 0)
                        {
                            cntOK++;
                            worksheet.Cells[i, 16] = "ok";
                            worksheet.Cells[i, 17] = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                            worksheet.Cells[i, 18] = "MNC_req_no " + dt.Rows[0]["MNC_req_no"].ToString() + "; MNC_PRE_NO " + dt.Rows[0]["MNC_PRE_NO"].ToString();
                        }
                        else
                        {
                            //sql = "";
                            row1++;
                            worksheet.Cells[row1, 15] = "row "+i+"; hn "+hn+ "; labdate1 "+ labdate1+ "; labcode " + labcode+" price3 "+price31;
                            worksheet.Cells[i, 16] = sql;
                            //price31 = worksheet.Cells[i, 10].Value != null ? worksheet.Cells[i, 10].Value.toString() : 0;
                            noFind += Decimal.Parse(price31);
                        }
                        
                        pB1.Value = i;
                        rowWork++;
                    }
                    catch (Exception ex)
                    {
                        rowErr++;
                        //MessageBox.Show("Error " + ex.Message + "\n row " + i, "error " + err);
                    }
                    //if (dgvAdd[colPatientHnno, i].Value == null)
                    //{
                    //    continue;
                    //}

                }
                worksheet.Cells[2, 15] = "year month period "+cboYear.Text+" "+cboMonth.Text+" "+cboPeriod.Text;
                worksheet.Cells[3, 15] = "row work "+ rowWork;
                worksheet.Cells[4, 15] = "row error " + rowErr;
                worksheet.Cells[5, 15] = "row Excel " + rowCount;
                worksheet.Cells[6, 15] = "search find " + cntOK;
                worksheet.Cells[7, 15] = "search no find " + (rowCount - cntOK);
                worksheet.Cells[8, 15] = "amount no find " + noFind;

                GC.Collect();
                GC.WaitForPendingFinalizers();
                workbook.Save();
                workbook.Close();
                excelapp.Quit();
                conn.connMainHIS5.Close();
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }

            MessageBox.Show("Check Data เรียบร้อย ", "");
            ////worksheet.Cells[1, 1] = "Name";
            ////worksheet.Cells[1, 2] = "Bid";

            ////worksheet.Cells[2, 1] = txbName.Text;
            ////worksheet.Cells[2, 2] = txbResult.Text;
            //pB1.Hide();
            //excelapp.UserControl = true;
            //excelapp.Visible = true;
        }
    }
}
