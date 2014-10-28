using reportBangna.objdb;
using reportBangna.object1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace reportBangna.gui
{
    public partial class FrmReAdmit : Form
    {
        int colRow = 0, colHN = 1, colAN = 2, colPName = 3, colDateAdmit = 4, colTimeAdmit = 5, colDateDS = 6, colTimeDS = 7, colFNTY = 8, colDia1 = 9;
        int colDia2 = 10, colDia3 = 11, colDia4 = 12, colDia5 = 13, colDia6 = 14, colDia7 = 15, colDia8 = 16, colDia9 = 17, colDia10 = 18, colDia24 = 19, colDia48 = 20, colDia28D = 21;
        int colDateAdmit1 = 22;
        int colCnt = 23;
        ReadmitDB radb;
        Config1 cf;
        public FrmReAdmit()
        {
            InitializeComponent();
            initConfig();
        }
        private void initConfig()
        {
            radb = new ReadmitDB();
            pB1.Visible = false;
            cf = new Config1();
            setGrd1(1);
        }
        private void setGrd1(int cnt)
        {
            dgv1.ColumnCount = colCnt;
            dgv1.Rows.Clear();
            dgv1.RowCount = cnt + 1;
            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv1.Columns[colRow].Width = 50;
            dgv1.Columns[colHN].Width = 80;
            dgv1.Columns[colAN].Width = 80;
            dgv1.Columns[colDateAdmit].Width = 100;
            dgv1.Columns[colTimeAdmit].Width = 70;
            dgv1.Columns[colDateDS].Width = 100;
            dgv1.Columns[colTimeDS].Width = 70;
            dgv1.Columns[colPName].Width = 200;
            dgv1.Columns[colFNTY].Width = 100;
            dgv1.Columns[colDia1].Width = 200;
            dgv1.Columns[colDia24].Width = 150;
            dgv1.Columns[colDia48].Width = 150;
            dgv1.Columns[colDia28D].Width = 150;

            dgv1.Columns[colDia2].Visible = false;
            dgv1.Columns[colDia3].Visible = false;
            dgv1.Columns[colDia4].Visible = false;
            dgv1.Columns[colDia5].Visible = false;
            dgv1.Columns[colDia6].Visible = false;
            dgv1.Columns[colDia7].Visible = false;
            dgv1.Columns[colDia8].Visible = false;
            dgv1.Columns[colDia9].Visible = false;
            dgv1.Columns[colDia10].Visible = false;

            dgv1.Columns[colDia24].Visible = false;
            dgv1.Columns[colDia48].Visible = false;
            dgv1.Columns[colDateAdmit1].Visible = false;

            dgv1.Columns[colRow].HeaderText = "ลำดับ";
            dgv1.Columns[colHN].HeaderText = "HN";
            dgv1.Columns[colAN].HeaderText = "AN";
            dgv1.Columns[colDateAdmit].HeaderText = "วันที่ admit";
            dgv1.Columns[colTimeAdmit].HeaderText = "เวลา ";
            dgv1.Columns[colDateDS].HeaderText = "วันที่ DS";
            dgv1.Columns[colTimeDS].HeaderText = "เวลา";
            dgv1.Columns[colPName].HeaderText = "ชื่อ-นามสกุล";
            dgv1.Columns[colFNTY].HeaderText = "สิทธิ";
            dgv1.Columns[colDia1].HeaderText = "DIA CD";
            dgv1.Columns[colDia2].HeaderText = "pre no8";
            dgv1.Columns[colDia3].HeaderText = "vn no8";
            dgv1.Columns[colDia4].HeaderText = "pre no9";
            dgv1.Columns[colDia5].HeaderText = "vn no9";
            dgv1.Columns[colDia6].HeaderText = "chk";
            dgv1.Columns[colDia24].HeaderText = "DIA CD เก่า24";
            dgv1.Columns[colDia48].HeaderText = "DIA CD เก่า48";
            dgv1.Columns[colDia28D].HeaderText = "DIA CD เก่า28Day";
            Font font = new Font("Microsoft Sans Serif", 10);
            dgv1.Font = font;
        }
        private void getReadmit()
        {
            label3.Text = System.DateTime.Now.ToString();
            pB1.Visible = true;
            pB1.Minimum = 0;
            DateTime dt1 = new DateTime();
            List<String> lHn = new List<String>();
            String visitDate = "", visitTime="", admitDate="", visitDate1="", dsDate="", sql="", hn="";
            radb.conn.OpenConnection();
            DataTable dt = radb.selectReadmit(dtpStart.Value.Year.ToString() + "-" + dtpStart.Value.ToString("MM-dd"),
                dtpEnd.Value.Year.ToString() + "-" + dtpEnd.Value.ToString("MM-dd"));
            if (dt.Rows.Count > 0)
            {
                dgv1.Rows.Clear();
                pB1.Maximum = dt.Rows.Count;
                dgv1.RowCount = dt.Rows.Count;
                setGrd1(dt.Rows.Count);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["MNC_DATE"] != null)
                    {
                        dt1 = DateTime.Parse(dt.Rows[i]["MNC_DATE"].ToString());
                        visitDate1 = dt1.Year.ToString() + "-" + dt1.Month.ToString("00") + "-" + dt1.Day.ToString("00");
                    }
                    if (dt.Rows[i]["MNC_AD_DATE"] != null)
                    {
                        dt1 = DateTime.Parse(dt.Rows[i]["MNC_AD_DATE"].ToString());
                        visitDate = dt1.ToString("dd-MM-yyyy");
                        admitDate = dt1.Year.ToString() + "-" + dt1.Month.ToString("00") + "-" + dt1.Day.ToString("00");
                        dgv1[colDateAdmit, i].Value = visitDate;
                        dgv1[colDateAdmit1, i].Value = dt1.Year.ToString() + dt1.Month.ToString("00")+ dt1.Day.ToString("00");
                        visitTime = "0000" + dt.Rows[i]["MNC_AD_TIME"].ToString();
                        visitTime = visitTime.Substring(visitTime.Length - 4);
                        dgv1[colTimeAdmit, i].Value = visitTime.Substring(0, 2) + ":" + visitTime.Substring(2);
                    }
                    if (dt.Rows[i]["MNC_DS_DATE"] != null)
                    {
                        try
                        {
                            dt1 = DateTime.Parse(dt.Rows[i]["MNC_DS_DATE"].ToString());
                            visitDate = dt1.ToString("dd-MM-yyyy");
                            dsDate = dt1.Year.ToString() + "-" + dt1.Month.ToString("00") + "-" + dt1.Day.ToString("00");
                            dgv1[colDateDS, i].Value = visitDate;
                            visitTime = "0000" + dt.Rows[i]["MNC_DS_TIME"].ToString();
                            visitTime = visitTime.Substring(visitTime.Length - 4);
                            dgv1[colTimeDS, i].Value = visitTime.Substring(0, 2) + ":" + visitTime.Substring(2);
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                    dgv1[colDia4, i].Value = "";
                    dgv1[colDia24, i].Value="";
                    dgv1[colDia48, i].Value="";
                    dgv1[colDia28D, i].Value = "";
                    dgv1[colDia5, i].Value = "1";
                    DataTable dt28 = radb.SelectReadmit28D(dt.Rows[i]["MNC_HN_NO"].ToString(), admitDate, dt.Rows[i]["MNC_AN_no"].ToString());
                    if ((dt28 != null) && (dt28.Rows.Count > 0))
                    {
                        //lHn.Add(dt.Rows[i]["MNC_HN_NO"].ToString());
                        dgv1[colDia4, i].Value = "1";
                        dgv1[colDia5, i].Value = "2";
                        for (int j = 0; j < dt28.Rows.Count; j++)
                        {
                            dgv1[colDia28D, i].Value += dt28.Rows[j]["MNC_DIA_CD"].ToString() + ",";
                        }
                        for (int j = (i - 1); j >= 0; j--)
                        {
                            if (dgv1[colHN, j].Value == null)
                            {
                                continue;
                            }
                            if (dgv1[colHN, j].Value.ToString().Equals(dt.Rows[i]["MNC_HN_NO"].ToString()))
                            {
                                dgv1[colDia4, j].Value = "1";
                                j = 0;
                            }
                        }
                        //dgv1[colDia48, i].Value = dt48.Rows[0]["MNC_DIA_CD"].ToString();
                        dgv1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    dgv1[colRow, i].Value = (i+1);
                    dgv1[colHN, i].Value = dt.Rows[i]["MNC_HN_NO"].ToString();
                    dgv1[colAN, i].Value = dt.Rows[i]["MNC_AN_no"].ToString();
                    dgv1[colDia2, i].Value = dt.Rows[i]["mnc_pre_no"].ToString();
                    dgv1[colDia3, i].Value = dt.Rows[i]["mnc_vn_no"].ToString();
                    //dgv1[colDateDS, i].Value = dt.Rows[i]["MNC_DS_DATE"].ToString();
                    //dgv1[colTimeDS, i].Value = dt.Rows[i]["MNC_DS_TIME"].ToString();
                    dgv1[colPName, i].Value = dt.Rows[i]["MNC_PFIX_DSC"].ToString() + " " + dt.Rows[i]["MNC_FNAME_T"].ToString() + " " + dt.Rows[i]["MNC_LNAME_T"].ToString();
                    dgv1[colFNTY, i].Value = dt.Rows[i]["MNC_FN_TYP_dsc"].ToString();
                    dgv1[colDia1, i].Value = radb.SelectReadmitDia(dt.Rows[i]["MNC_HN_NO"].ToString(), visitDate1, dt.Rows[i]["mnc_pre_no"].ToString());
                    //dgv1[colDia4, i].Value = "";
                    //dgv1[colDia24, i].Value = radb.SelectReadmit24(dt.Rows[i]["MNC_HN_NO"].ToString(), dt.Rows[i]["mnc_an_no"].ToString());
                    pB1.Value = i;
                }
            }
            radb.conn.CloseConnection();
            pB1.Visible = false;
            //dgv1.
            //for (int i = 0; i < dgv1.RowCount; i++)
            //{
            //    if ((dgv1[colDia24, i].Value == null) || (dgv1[colDia48, i].Value == null))
            //    {
            //        continue;
            //    }
            //    for (int j = 0; j < lHn.Count; j++)
            //    {
            //        if (dgv1[colHN, i].Value.ToString().Equals(lHn[j]))
            //        {
            //            dgv1[colDia4, i].Value = "1";
            //        }
            //    }
            //}

            //เอา รายการที่ไม่ใช่ ออกจาก grd
            for (int i = 0; i < dgv1.RowCount; i++)
            {
                if (dgv1[colDia4, i].Value == null)
                {
                    continue;
                }
                if (!dgv1[colDia4, i].Value.ToString().Equals("1"))
                {
                    dgv1.Rows.RemoveAt(i);
                    i--;
                }
            }
            //string[] dia1 = new string[] { };

            //label1 comment ไปก่อน มันทำให้ ข้อมูลเก่าๆ ถูกremove ไปด้วย
            for (int i = 0; i < dgv1.RowCount; i++)
            {
                if (dgv1[colDia1, i].Value == null)
                {
                    continue;
                }
                if (dgv1[colDia28D, i].Value == null)
                {
                    continue;
                }
                dgv1[colDia6, i].Value = "";
                string[] dia1 = dgv1[colDia1, i].Value.ToString().Split(',');
                string[] dia48 = dgv1[colDia28D, i].Value.ToString().Split(',');
                sql = "";
                for (int j = 0; j < dia48.Length; j++)
                {
                    sql = dia48[j];
                    int chk = Array.IndexOf(dia1, sql);
                    if (chk >= 0)
                    {
                        dgv1[colDia6, i].Value = "1";
                    }
                }
            }
            for (int i = 0; i < dgv1.RowCount; i++)
            {
                if (dgv1[colDia6, i].Value == null)
                {
                    continue;
                }
                if (dgv1[colDia6, i].Value.ToString().Equals("1"))
                {
                    hn = dgv1[colHN, i].Value.ToString();
                    for (int j = i; j >= 0; j--)
                    {
                        if (j != 0)
                        {
                            sql = dgv1[colHN, j - 1].Value.ToString();
                            if (sql.Equals(hn))
                            {
                                dgv1[colDia6, (j - 1)].Value = "1";
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < dgv1.RowCount; i++)
            {
                if (dgv1[colDia6, i].Value == null)
                {
                    continue;
                }
                if (!dgv1[colDia6, i].Value.ToString().Equals("1"))
                {
                    dgv1.Rows.RemoveAt(i);
                    i--;
                }
            }
            //label1
            //String sql = "";
            pB1.Minimum = 0;
            pB1.Maximum=(dgv1.RowCount*2);
            sql = "Delete From r_readmit";
            ConnectDB cbua = new ConnectDB("bangna");
            cbua.ExecuteNonQuery(sql);
            String dateds = "", name="",timeds="", statusfirst="";
            for (int i = 0; i < dgv1.RowCount; i++)
            {
                if (dgv1[colHN, i].Value == null)
                {
                    continue;
                }
                if (dgv1[colDateDS, i].Value == null)
                {
                    dateds = "";
                }
                else
                {
                    dateds = dgv1[colDateDS, i].Value.ToString();
                }
                if (dgv1[colTimeDS, i].Value == null)
                {
                    timeds = "";
                }
                else
                {
                    timeds = dgv1[colTimeDS, i].Value.ToString();
                }
                if (dgv1[colDia5, i].Value == null)
                {
                    statusfirst = "0";
                }
                else if (dgv1[colDia5, i].Value.ToString().Equals(""))
                {
                    statusfirst = "0";
                }
                else
                {
                    statusfirst = "1";
                }
                //if (statusfirst.Equals(""))
                //{
                //    statusfirst = "0";
                //}
                sql = "Insert Into r_readmit(" + radb.ra.pkField + ", " + radb.ra.Hn + ", " + radb.ra.DateAdmit + ", " +
                    radb.ra.TimeAdmit + ", " + radb.ra.DateDS + ", " + radb.ra .TimeDS+ ", " +
                    radb.ra.PName + ", " + radb.ra.FnType + ", " + radb.ra.Dia1 + ", " +
                    radb.ra.Dia28 + ", " + radb.ra.StatusFirst + ") " +
                    "Values('" + radb.ra.getGenID() + "','" + dgv1[colHN, i].Value.ToString() + "','" + cf.dateShowtoDB(dgv1[colDateAdmit, i].Value.ToString()) + "','" +
                    dgv1[colTimeAdmit, i].Value.ToString() + "','" + dateds + "','" + timeds + "','" +
                    dgv1[colPName, i].Value.ToString().Replace("'","''") + "','" + dgv1[colFNTY, i].Value.ToString() + "','" + dgv1[colDia1, i].Value.ToString() + "','" +
                    dgv1[colDia28D, i].Value.ToString() + "','" + statusfirst + "')";
                cbua.ExecuteNonQuery(sql);
                pB1.Value = i;
            }
            int k = dgv1.RowCount;
            sql = "Select Distinct "+radb.ra.Hn+" From "+radb.ra.table+" Order By "+radb.ra.Hn;
            dt = cbua.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                dgv1.Rows.Clear();
                //dgv1.RowCount = dt.Rows.Count;
                int row = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sql = "Select * From " + radb.ra.table + " Where " + radb.ra.Hn + "='" + dt.Rows[i][radb.ra.Hn].ToString()+"' Order By "+radb.ra.DateAdmit;
                    DataTable dt2 = cbua.selectData(sql);
                    if (dt2.Rows.Count > 0)
                    {
                        for (int j = 0; j < dt2.Rows.Count; j++)
                        {
                            row = dgv1.Rows.Add();
                            dgv1[colRow, row].Value = (row + 1);
                            dgv1[colHN, row].Value = dt2.Rows[j][radb.ra.Hn].ToString();
                            dgv1[colDateAdmit, row].Value = cf.dateDBtoShow1(dt2.Rows[j][radb.ra.DateAdmit].ToString());
                            dgv1[colTimeAdmit, row].Value = dt2.Rows[j][radb.ra.TimeAdmit].ToString();
                            dgv1[colDateDS, row].Value = dt2.Rows[j][radb.ra.DateDS].ToString();
                            dgv1[colTimeDS, row].Value = dt2.Rows[j][radb.ra.TimeDS].ToString();
                            dgv1[colPName, row].Value = dt2.Rows[j][radb.ra.PName].ToString();
                            dgv1[colFNTY, row].Value = dt2.Rows[j][radb.ra.FnType].ToString();
                            dgv1[colDia1, row].Value = dt2.Rows[j][radb.ra.Dia1].ToString();
                            dgv1[colDia28D, row].Value = dt2.Rows[j][radb.ra.Dia28].ToString();
                            if (!dt2.Rows[j][radb.ra.Dia28].ToString().Equals(""))
                            {
                                dgv1.Rows[row].DefaultCellStyle.BackColor = Color.LightGreen;
                            }
                            //row++;
                        }
                    }



                    
                    //if (!dt.Rows[i][radb.ra.StatusFirst].ToString().Equals("0"))
                    //{
                    //    dgv1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                    //}
                    //pB1.Value = (k+i);
                }
            }
            pB1.Visible = false;
            //String dateTmp = "", dateTmp1 = "";
            //for (int i = 0; i < dgv1.RowCount; i++)
            //{
            //    if (dgv1[colDateAdmit1, i].Value == null)
            //    {
            //        continue;
            //    }
            //    for (int j = 0; j < dgv1.RowCount - 1; j++)
            //    {
            //        if (dgv1[colDateAdmit1, (j + 1)].Value == null)
            //        {
            //            continue;
            //        }
            //        //String sRow = "", sHN = "", sAN = "", sPName = "", sDateAdmit = "", sTimeAdmit = "", SDateDS = "", sTimeDS = "", sFNTY = "", sDia1 = "";
            //        //String sDia2 = "", sDia3 = "", sDia4 = "", sDia5 = "", sDia6 = "", sDia7 = "", sDia8 = "", sDia9 = "", sDia10 = "", sDia24 = "", sDia48 = "", sDia28D = "";
            //        //String sDateAdmit1 = "";

            //        //String sRow1 = "", sHN1 = "", sAN1 = "", sPName1 = "", sDateAdmit1 = "", sTimeAdmit1 = "", SDateDS1 = "", sTimeDS1 = "", sFNTY1 = "", sDia11 = "";
            //        //String sDia21 = "", sDia31 = "", sDia41 = "", sDia5 = "", sDia6 = "", sDia7 = "", sDia8 = "", sDia9 = "", sDia10 = "", sDia24 = "", sDia48 = "", sDia28D = "";
            //        //String sDateAdmit1 = "";
            //        //List<String> s = new List<string>();
            //        List<String> s1 = new List<string>();
            //        dateTmp1 = dgv1[colDateAdmit1, (j + 1)].Value.ToString();
            //        if ((int.Parse(dgv1[colDateAdmit1, j].Value.ToString()) > int.Parse(dateTmp1)))
            //        {
            //            for (int k = 0; k < colCnt; k++)
            //            {
            //                s1.Add(dgv1[k,(j+1)].Value.ToString());
            //            }
            //            for (int k = 0; k < colCnt; k++)
            //            {
            //                dgv1[k, (j + 1)].Value = dgv1[k, j].Value;
            //            }
            //            for (int k = 0; k < colCnt; k++)
            //            {
            //                dgv1[k, j].Value = s1[k];
            //            }
            //        }
            //        //if (int.Parse(cc.cf.datetoDB(dgvAdd[colDatePlaceRecord, j].Value).Replace("-", "")) > int.Parse(datePlaceRecordTemp.Replace("-", "")))
            //        //datePlaceRecordTemp = cc.cf.NumberNull1(datePlaceRecordTemp);
            //    }
            //}
            //for (int i = 0; i < dgv1.RowCount; i++)
            //{
            //    if (dgv1[colHN, i].Value == null)
            //    {
            //        continue;
            //    }
            //    if (dgv1[colHN, (i+1)].Value == null)
            //    {
            //        continue;
            //    }
            //    String hn1 = "", hn2="";
            //    hn1 = dgv1[colHN, i].Value.ToString();
            //    hn2 = dgv1[colHN, (i+1)].Value.ToString();
            //    if (hn1.Equals(hn2))
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        for (int j = (i + 1); j < dgv1.RowCount - 1; j++)
            //        {
            //            if (dgv1[colHN, (j + 1)].Value == null)
            //            {
            //                continue;
            //            }
            //            if (hn1.Equals(dgv1[colHN, (j+1)].Value.ToString()))
            //            {
            //                List<String> s1 = new List<string>();
            //                for (int k = 0; k < colCnt; k++)
            //                {
            //                    if (dgv1[k, j].Value == null)
            //                    {
            //                        s1.Add("");
            //                    }
            //                    else
            //                    {
            //                        s1.Add(dgv1[k, j].Value.ToString());
            //                    }
            //                }
            //                for (int k = 0; k < colCnt; k++)
            //                {
            //                    dgv1[k, j].Value = dgv1[k, (j+1)].Value;
            //                }
            //                for (int k = 0; k < colCnt; k++)
            //                {
            //                    dgv1[k, (j+1)].Value = s1[k];
            //                }
            //            }
            //        }
            //    }
                
            //}
            //dgv1.Sort(dgv1.Columns[colHN], ListSortDirection.Ascending);
            //DateTime dtrow = new DateTime();
            //DateTime dtrow1 = new DateTime();
            //for (int i = 0; i < dgv1.RowCount; i++)
            //{
            //    DataGridViewRow row = new DataGridViewRow();
            //    DataGridViewRow row1 = new DataGridViewRow();
            //    DataGridViewRow rowTemp = new DataGridViewRow();
            //    row = dgv1.Rows[i];
            //    if ((i + 1) < dgv1.RowCount)
            //    {
            //        row1 = dgv1.Rows[(i + 1)];
            //        if (row.Cells[colHN].Value == null)
            //        {
            //            continue;
            //        }
            //        if (row.Cells[colHN].Value.ToString().Equals(row1.Cells[colHN].Value.ToString()))
            //        {
            //            dtrow = DateTime.Parse(row.Cells[colDateAdmit].Value.ToString());
            //            dtrow1 = DateTime.Parse(row1.Cells[colDateAdmit].Value.ToString());
            //            System.TimeSpan ts = dtrow1.Subtract(dtrow);
            //            if (!(ts.TotalMinutes > 0))
            //            {
            //                if (int.Parse(row.Cells[colDia2].Value.ToString()) < int.Parse(row1.Cells[colDia2].Value.ToString()))
            //                {
            //                    rowTemp = row1;
            //                    row = row1;
            //                    row1 = rowTemp;
            //                }
            //            }
            //        }
            //    }
                
            ////}
            //for (int i = 0; i < dgv1.RowCount; i++)
            //{
            //    if ((dgv1[colHN, i].Value != null))
            //    {
            //        dgv1[colRow, i].Value = (i + 1);
            //    }
            //}
            label4.Text = System.DateTime.Now.ToString();
        }
        private void getReadmitV2()
        {
            label3.Text = System.DateTime.Now.ToString();
            pB1.Visible = true;
            pB1.Minimum = 0;
            DateTime dt1 = new DateTime();
            List<String> lHn = new List<String>();
            String visitDate = "", visitTime = "", admitDate = "", visitDate1 = "", dsDate = "";
            radb.conn.OpenConnection();
            DataTable dt = radb.selectReadmit(dtpStart.Value.Year.ToString() + "-" + dtpStart.Value.ToString("MM-dd"),
                dtpEnd.Value.Year.ToString() + "-" + dtpEnd.Value.ToString("MM-dd"));
            if (dt.Rows.Count > 0)
            {
                pB1.Maximum = dt.Rows.Count;
                dgv1.RowCount = dt.Rows.Count;
                setGrd1(dt.Rows.Count);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["MNC_DATE"] != null)
                    {
                        dt1 = DateTime.Parse(dt.Rows[i]["MNC_DATE"].ToString());
                        visitDate1 = dt1.Year.ToString() + "-" + dt1.Month.ToString("00") + "-" + dt1.Day.ToString("00");
                    }
                    if (dt.Rows[i]["MNC_AD_DATE"] != null)
                    {
                        dt1 = DateTime.Parse(dt.Rows[i]["MNC_AD_DATE"].ToString());
                        visitDate = dt1.ToString("dd-MM-yyyy");
                        admitDate = dt1.Year.ToString() + "-" + dt1.Month.ToString("00") + "-" + dt1.Day.ToString("00");
                        dgv1[colDateAdmit, i].Value = visitDate;
                        visitTime = "0000" + dt.Rows[i]["MNC_AD_TIME"].ToString();
                        visitTime = visitTime.Substring(visitTime.Length - 4);
                        dgv1[colTimeAdmit, i].Value = visitTime.Substring(0, 2) + ":" + visitTime.Substring(2);
                    }
                    if (dt.Rows[i]["MNC_DS_DATE"] != null)
                    {
                        try
                        {
                            dt1 = DateTime.Parse(dt.Rows[i]["MNC_DS_DATE"].ToString());
                            visitDate = dt1.ToString("dd-MM-yyyy");
                            dsDate = dt1.Year.ToString() + "-" + dt1.Month.ToString("00") + "-" + dt1.Day.ToString("00");
                            dgv1[colDateDS, i].Value = visitDate;
                            visitTime = "0000" + dt.Rows[i]["MNC_DS_TIME"].ToString();
                            visitTime = visitTime.Substring(visitTime.Length - 4);
                            dgv1[colTimeDS, i].Value = visitTime.Substring(0, 2) + ":" + visitTime.Substring(2);
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                    dgv1[colDia4, i].Value = "";
                    dgv1[colDia24, i].Value = "";
                    dgv1[colDia48, i].Value = "";
                    dgv1[colDia28D, i].Value = "";
                    DataTable dt24 = radb.SelectReadmit24(dt.Rows[i]["MNC_HN_NO"].ToString(), admitDate, dt.Rows[i]["MNC_AN_no"].ToString());
                    if ((dt24 != null) && (dt24.Rows.Count > 0))
                    {
                        //lHn.Add(dt.Rows[i]["MNC_HN_NO"].ToString());
                        dgv1[colDia4, i].Value = "1";
                        for (int j = 0; j < dt24.Rows.Count; j++)
                        {
                            dgv1[colDia24, i].Value += dt24.Rows[j]["MNC_DIA_CD"].ToString() + ",";
                        }
                        for (int j = (i - 1); j >= 0; j--)
                        {
                            if (dgv1[colHN, j].Value == null)
                            {
                                continue;
                            }
                            if (dgv1[colHN, j].Value.ToString().Equals(dt.Rows[i]["MNC_HN_NO"].ToString()))
                            {
                                dgv1[colDia4, j].Value = "1";
                                j = 0;
                            }
                        }
                        dgv1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    DataTable dt48 = radb.SelectReadmit48(dt.Rows[i]["MNC_HN_NO"].ToString(), admitDate, dt.Rows[i]["MNC_AN_no"].ToString(), dt.Rows[i]["MNC_pre_no"].ToString());
                    if ((dt48 != null) && (dt48.Rows.Count > 0))
                    {
                        //lHn.Add(dt.Rows[i]["MNC_HN_NO"].ToString());
                        dgv1[colDia4, i].Value = "1";
                        for (int j = 0; j < dt48.Rows.Count; j++)
                        {
                            dgv1[colDia48, i].Value += dt48.Rows[j]["MNC_DIA_CD"].ToString() + ",";
                        }
                        for (int j = (i - 1); j >= 0; j--)
                        {
                            if (dgv1[colHN, j].Value == null)
                            {
                                continue;
                            }
                            if (dgv1[colHN, j].Value.ToString().Equals(dt.Rows[i]["MNC_HN_NO"].ToString()))
                            {
                                dgv1[colDia4, j].Value = "1";
                                j = 0;
                            }
                        }
                        //dgv1[colDia48, i].Value = dt48.Rows[0]["MNC_DIA_CD"].ToString();
                        dgv1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    DataTable dt28 = radb.SelectReadmit28D(dt.Rows[i]["MNC_HN_NO"].ToString(), admitDate, dt.Rows[i]["MNC_AN_no"].ToString());
                    if ((dt48 != null) && (dt48.Rows.Count > 0))
                    {
                        //lHn.Add(dt.Rows[i]["MNC_HN_NO"].ToString());
                        dgv1[colDia4, i].Value = "1";
                        for (int j = 0; j < dt48.Rows.Count; j++)
                        {
                            dgv1[colDia28D, i].Value += dt48.Rows[j]["MNC_DIA_CD"].ToString() + ",";
                        }
                        for (int j = (i - 1); j >= 0; j--)
                        {
                            if (dgv1[colHN, j].Value == null)
                            {
                                continue;
                            }
                            if (dgv1[colHN, j].Value.ToString().Equals(dt.Rows[i]["MNC_HN_NO"].ToString()))
                            {
                                dgv1[colDia4, j].Value = "1";
                                j = 0;
                            }
                        }
                        //dgv1[colDia48, i].Value = dt48.Rows[0]["MNC_DIA_CD"].ToString();
                        dgv1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    dgv1[colRow, i].Value = (i + 1);
                    dgv1[colHN, i].Value = dt.Rows[i]["MNC_HN_NO"].ToString();
                    dgv1[colAN, i].Value = dt.Rows[i]["MNC_AN_no"].ToString();
                    dgv1[colDia2, i].Value = dt.Rows[i]["mnc_pre_no"].ToString();
                    dgv1[colDia3, i].Value = dt.Rows[i]["mnc_vn_no"].ToString();
                    //dgv1[colDateDS, i].Value = dt.Rows[i]["MNC_DS_DATE"].ToString();
                    //dgv1[colTimeDS, i].Value = dt.Rows[i]["MNC_DS_TIME"].ToString();
                    dgv1[colPName, i].Value = dt.Rows[i]["MNC_PFIX_DSC"].ToString() + " " + dt.Rows[i]["MNC_FNAME_T"].ToString() + " " + dt.Rows[i]["MNC_LNAME_T"].ToString();
                    dgv1[colFNTY, i].Value = dt.Rows[i]["MNC_FN_TYP_dsc"].ToString();
                    dgv1[colDia1, i].Value = radb.SelectReadmitDia(dt.Rows[i]["MNC_HN_NO"].ToString(), visitDate1, dt.Rows[i]["mnc_pre_no"].ToString());
                    //dgv1[colDia4, i].Value = "";
                    //dgv1[colDia24, i].Value = radb.SelectReadmit24(dt.Rows[i]["MNC_HN_NO"].ToString(), dt.Rows[i]["mnc_an_no"].ToString());
                    pB1.Value = i;
                }
            }
            radb.conn.CloseConnection();
            pB1.Visible = false;
            //dgv1.
            //for (int i = 0; i < dgv1.RowCount; i++)
            //{
            //    if ((dgv1[colDia24, i].Value == null) || (dgv1[colDia48, i].Value == null))
            //    {
            //        continue;
            //    }
            //    for (int j = 0; j < lHn.Count; j++)
            //    {
            //        if (dgv1[colHN, i].Value.ToString().Equals(lHn[j]))
            //        {
            //            dgv1[colDia4, i].Value = "1";
            //        }
            //    }
            //}
            for (int i = 0; i < dgv1.RowCount; i++)
            {
                if (dgv1[colDia4, i].Value == null)
                {
                    continue;
                }
                if (!dgv1[colDia4, i].Value.ToString().Equals("1"))
                {
                    dgv1.Rows.RemoveAt(i);
                    i--;
                }
            }
            for (int i = 0; i < dgv1.RowCount; i++)
            {
                if ((dgv1[colHN, i].Value != null))
                {
                    dgv1[colRow, i].Value = (i + 1);
                }
            }
            label4.Text = System.DateTime.Now.ToString();
        }
        private void setResize()
        {
            dgv1.Width = this.Width - 50;
            dgv1.Height = this.Height - 150;
            //groupBox1.Width = this.Width - 50;
            //pB1.Width = this.Width - 900;
        }

        private void FrmReAdmit_Load(object sender, EventArgs e)
        {
            this.Text = "ReAdmit Last Update " + System.IO.File.GetLastWriteTime(System.Environment.CurrentDirectory + "\\" + Process.GetCurrentProcess().ProcessName + ".exe");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            getReadmit();
        }

        private void FrmReAdmit_Resize(object sender, EventArgs e)
        {
            setResize();
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            pB1.Show();
            Microsoft.Office.Interop.Excel.Application excelapp = new Microsoft.Office.Interop.Excel.Application();
            excelapp.Visible = false;
            String visitDate = "", visitTime = "", err = "", err1 = "", pharName = "";

            Microsoft.Office.Interop.Excel._Workbook workbook = (Microsoft.Office.Interop.Excel._Workbook)(excelapp.Workbooks.Add(Type.Missing));
            Microsoft.Office.Interop.Excel._Worksheet worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.ActiveSheet;
            pB1.Minimum = 0;
            pB1.Maximum = dgv1.Rows.Count;
            //worksheet.Cells[0, 0] = "patient name";
            for (int i = 0; i < dgv1.Rows.Count; i++)
            {
                try
                {
                    if (dgv1[colHN, i].Value == null)
                    {
                        continue;
                    }
                    worksheet.Cells[(i+1), colHN] = dgv1[colHN, i].Value.ToString();
                    worksheet.Cells[(i + 1), colAN] = cf.stringNull1(dgv1[colAN, i].Value);
                    err = "001 " + dgv1[colHN, i].Value.ToString();
                    //worksheet.Cells[i, colDate] = dgvAdd[colDate, i].Value.ToString();
                    //worksheet.Cells[i, colTime] = dgvAdd[colTime, i].Value.ToString();
                    worksheet.Cells[(i + 1), colPName] = cf.stringNull(dgv1[colPName, i].Value.ToString());
                    if (dgv1[colDateAdmit, i].Value == null)
                    {
                        worksheet.Cells[(i + 1), colDateAdmit].Value = "";
                    }
                    else
                    {
                        visitDate = dgv1[colDateAdmit, i].Value.ToString();
                        worksheet.Cells[(i + 1), colDateAdmit] = visitDate;
                        visitTime = dgv1[colTimeAdmit, i].Value.ToString();
                        worksheet.Cells[(i + 1), colTimeAdmit] = visitTime;
                    }
                    if (dgv1[colDateDS, i].Value == null)
                    {
                        worksheet.Cells[(i + 1), colDateDS].Value = "";
                    }
                    else
                    {
                        visitDate = dgv1[colDateDS, i].Value.ToString();
                        worksheet.Cells[(i + 1), colDateDS] = visitDate;
                        visitTime = dgv1[colTimeDS, i].Value.ToString();
                        worksheet.Cells[(i + 1), colTimeDS] = visitTime;
                    }
                    err = "002 Dia";
                    if (dgv1[colDia1, i].Value == null)
                    {
                        worksheet.Cells[(i + 1), colDia1] = "";
                    }
                    else
                    {
                        worksheet.Cells[(i + 1), colDia1] = cf.stringNull1(dgv1[colDia1, i].Value);
                    }
                    err = "003 Chronic ";
                    worksheet.Cells[(i + 1), colFNTY] = cf.stringNull1(dgv1[colFNTY, i].Value);
                    worksheet.Cells[(i + 1), colDia24] = cf.stringNull1(dgv1[colDia24, i].Value);
                    worksheet.Cells[(i + 1), colDia48] = cf.stringNull1(dgv1[colDia48, i].Value);
                    //worksheet.Cells[(i + 1), colDia28D] = cf.stringNull1(dgv1[colDia28D, i].Value);
                    worksheet.Cells[(i + 1), 9] = cf.stringNull1(dgv1[colDia28D, i].Value);
                    pB1.Value = i;
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error " + ex.Message + "\n row " + i, "error " + err);
                }
            }
            pB1.Hide();
            excelapp.UserControl = true;
            excelapp.Visible = true;
            //excelapp.Quit();
        }
    }
}
