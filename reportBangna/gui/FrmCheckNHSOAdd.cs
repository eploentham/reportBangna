using reportBangna.objdb;
using reportBangna.object1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace reportBangna.gui
{
    public partial class FrmCheckNHSOAdd : Form
    {
        Config1 config1;
        CheckNhso1DB cNhso1db;
        WriteText wt;
        String edit = "";
        int colCnt = 153, colRow = 0, colPatientName = 1, colPatientHnno = 2, colDate = 3, colTime = 4;
        int colDiaCD1 = 5, colDiaCD2 = 6, colDiaCD3 = 7, colDiaCD4 = 8, colDiaCD5 = 9;
        int colDiaCD6 = 10, colDiaCD7 = 11, colDiaCD8 = 12, colDiaCD9 = 13, colDiaCD10 = 14;
        int colCHRONICCODE1 = 15, colCHRONICCODE2 = 16, colCHRONICCODE3 = 17, colCHRONICCODE4 = 18, colCHRONICCODE5 = 19;
        int colCHRONICCODE6 = 20, colCHRONICCODE7 = 21, colCHRONICCODE8 = 22, colCHRONICCODE9 = 23, colCHRONICCODE10 = 24;
        int colExport = 93;
        int colDrug1 = 25, colDrug2 = 26, colDrug3 = 27, colDrug4 = 28, colDrug5 = 29;
        int colDrug6 = 30, colDrug7 = 31, colDrug8 = 32, colDrug9 = 33, colDrug10 = 34;

        int colDrug11 = 35, colDrug12 = 36, colDrug13 = 37, colDrug14 = 38, colDrug15 = 39;
        int colDrug16 = 40, colDrug17 = 41, colDrug18 = 42, colDrug19 = 43, colDrug20 = 44;
        int colDrug21 = 45, colDrug22 = 46, colDrug23 = 47, colDrug24 = 48, colDrug25 = 49;
        int colDrug26 = 50, colDrug27 = 51, colDrug28 = 52, colDrug29 = 53, colDrug30 = 54;
        int colLabName1 = 55, colLabResult1 = 56, colLabValue1 = 57, colLabName2 = 58, colLabResult2 = 59;
        int colLabValue2 = 60, colLabName3 = 61, colLabResult3 = 62, colLabValue3 = 63, colLabName4 = 64;
        int colLabResult4 = 65, colLabValue4 = 66, colLabName5 = 67, colLabResult5 = 68, colLabValue5 = 69;
        int colLabName6 = 70, colLabResult6 = 71, colLabValue6 = 72, colLabName7 = 73, colLabResult7 = 74;
        int colLabValue7 = 75, colLabName8 = 76, colLabResult8 = 77, colLabValue8 = 78, colLabName9 = 79;
        int colLabResult9 = 80, colLabValue9 = 81, colLabName10 = 82, colLabResult10 = 83, colLabValue10 = 84;
        int colLabName11 = 85, colLabResult11 = 86, colLabValue11 = 87, colLabName12 = 88, colLabResult12 = 89, colLabValue12 = 90, colLabName13 = 91, colLabResult13 = 92, colLabValue13 = 93;
        int colLabName14 = 94, colLabResult14 = 95, colLabValue14 = 96, colLabName15 = 97, colLabResult15 = 98, colLabValue15 = 99, colLabName16 = 100, colLabResult16 = 101, colLabValue16 = 102;
        int colLabName17 = 103, colLabResult17 = 104, colLabValue17 = 105, colLabName18 = 106, colLabResult18 = 107, colLabValue18 = 108, colLabName19 = 109, colLabResult19 = 110, colLabValue19 = 111;
        int colLabName20 = 112, colLabResult20 = 113, colLabValue20 = 114, colLabName21 = 115, colLabResult21 = 116, colLabValue21 = 117, colLabName22 = 118, colLabResult22 = 119, colLabValue22 = 120;
        int colLabName23 = 121, colLabResult23 = 122, colLabValue23 = 123, colLabName24 = 124, colLabResult24 = 125, colLabValue24 = 126, colLabName25 = 127, colLabResult25 = 128, colLabValue25 = 129;
        int colLabName26 = 130, colLabResult26 = 131, colLabValue26 = 132, colLabName27 = 133, colLabResult27 = 134, colLabValue27 = 135, colLabName28 = 136, colLabResult28 = 137, colLabValue28 = 138;
        int colLabName29 = 139, colLabResult29 = 140, colLabValue29 = 141, colLabName30 = 142, colLabResult30 = 143, colLabValue30 = 144;

        //int colvnSum = 85, colvnSeq = 86, colVn = 87, colRowEdit = 88, colId = 89, colEditDia = 90, colEditDrug = 91, colBranch=145;
        int colvnSum = 146, colvnSeq = 147, colVn = 18, colRowEdit = 149, colId = 150, colEditDia = 151, colEditDrug = 152, colBranch = 145;

        public FrmCheckNHSOAdd()
        {
            InitializeComponent();
            initConfig();
        }
        private void initConfig()
        {            
            config1 = new Config1();
            cNhso1db = new CheckNhso1DB();
            dgvAdd.Hide();
            pB1.Hide();
            wt = new WriteText();
            if (cNhso1db.conn.isBranch.Equals("yes"))
            {
                btnImport.Enabled = false;
            }
            
            //config1.setCboLab(cboLab);
            //sip = new SedanInjuryPerson();
        }
        public void setData1(String dateStart, String dateEnd)
        {
            String visitDate = "", preNo="", vn="", hn="";
            lB1.Items.Add("เตรียมดึงข้อมูล");
            lB1.Refresh();
            pB1.Show();
            DataTable dt = new DataTable();
            //dateStart1 = (int.Parse(dateStart.Substring(0, 4)) + 543) + dateStart.Substring(4);
            //dateEnd1 = (int.Parse(dateEnd.Substring(0, 4)) + 543) + dateEnd.Substring(4);
            dt = cNhso1db.selectPatientByDate(dateStart, dateEnd, "", "", "", "", "");
            lB1.Items.Add("กำลังดึงข้อมูล "+dt.Rows.Count);
            lB1.Refresh();
            pB1.Minimum = 0;
            pB1.Maximum = dt.Rows.Count;
            dgvAdd.Rows.Clear();
            dgvAdd.ColumnCount = colCnt;
            //setGrid(dt.Rows.Count);
            if (dt.Rows.Count > 0)
            {
                dgvAdd.RowCount = dt.Rows.Count;
                String pharName = "", labName = "", labResult = "", labValue = "", visitTime = "", chronic="", dia="";
                DateTime dt1 = new DateTime();
                pB1.Show();
                //DataTable dt = new DataTable();
                DataTable dtDia = new DataTable();
                DataTable dtChr = new DataTable();
                DataTable dtDrug = new DataTable();
                DataTable dtLab = new DataTable();

                dt = cNhso1db.selectPatientByDate(dateStart, dateEnd, "", "", "", "", "");
                pB1.Minimum = 0;
                pB1.Maximum = dt.Rows.Count;
                //setGrid(dt.Rows.Count);

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        //lB1.Items.Add("กำลังดึงข้อมูล " + i);
                        //lB1.Refresh();
                        label1.Text = "ข้อมูล "+i;
                        this.Refresh();
                        dgvAdd[colRow, i].Value = (i + 1);
                        dgvAdd[colvnSeq, i].Value = dt.Rows[i]["mnc_vn_seq"].ToString();
                        dgvAdd[colvnSum, i].Value = dt.Rows[i]["mnc_vn_sum"].ToString();
                        dgvAdd[colVn, i].Value = dt.Rows[i]["mnc_vn_no"].ToString();
                        dgvAdd[colPatientName, i].Value = dt.Rows[i]["mnc_pfix_dsc"].ToString() + " " + dt.Rows[i]["mnc_fname_t"].ToString() + " " + dt.Rows[i]["mnc_lname_t"].ToString();
                        preNo = dt.Rows[i]["MNC_PRE_NO"].ToString();
                        vn = dt.Rows[i]["MNC_VN_NO"].ToString();
                        hn = dt.Rows[i]["MNC_HN_NO"].ToString();
                        dgvAdd[colPatientHnno, i].Value = dt.Rows[i]["MNC_HN_NO"].ToString();
                        //visitDate = string.Format( dt.Rows[i]["MNC_DATE"].ToString(),"dd-mm-yyyy");

                        if (dt.Rows[i]["MNC_DATE"] != null)
                        {
                            dt1 = DateTime.Parse(dt.Rows[i]["MNC_DATE"].ToString());
                            visitDate = dt1.ToString("dd-MM-yyyy");
                            dgvAdd[colDate, i].Value = visitDate;
                            visitTime = "0000" + dt.Rows[i]["MNC_TIME"].ToString();
                            visitTime = visitTime.Substring(visitTime.Length - 4);
                            dgvAdd[colTime, i].Value = visitTime.Substring(0, 2) + ":" + visitTime.Substring(2);
                        }
                        else
                        {
                            dgvAdd[colDate, i].Value = "";
                        }

                        //dgvAdd[colTime, i].Value = dt.Rows[i]["MNC_TIME"].ToString();
                        Debug.WriteLine("setData1 i"+i);
                        dtDia = cNhso1db.selectDiaCDbyVN(dateStart, dateEnd, hn, vn, preNo);
                        //lB1.Items.Add("กำลังดึงข้อมูล dtDia " + dtDia.Rows.Count);
                        //lB1.Refresh();
                        for (int j = 0; j < dtDia.Rows.Count; j++)
                        {
                            dia = "";
                            dia = config1.stringNull1(dtDia.Rows[j]["MNC_DIA_CD"]);
                            if (j == 0)
                            {
                                dgvAdd[colDiaCD1, i].Value = dia;
                            }
                            else if (j == 1)
                            {
                                dgvAdd[colDiaCD2, i].Value = dia;
                            }
                            else if (j == 2)
                            {
                                dgvAdd[colDiaCD3, i].Value = dia;
                            }
                            else if (j == 3)
                            {
                                dgvAdd[colDiaCD4, i].Value = dia;
                            }
                            else if (j == 4)
                            {
                                dgvAdd[colDiaCD5, i].Value = dia;
                            }
                            else if (j == 5)
                            {
                                dgvAdd[colDiaCD6, i].Value = dia;
                            }
                            else if (j == 6)
                            {
                                dgvAdd[colDiaCD7, i].Value = dia;
                            }
                            else if (j ==7)
                            {
                                dgvAdd[colDiaCD8, i].Value = dia;
                            }
                            else if (j == 8)
                            {
                                dgvAdd[colDiaCD9, i].Value = dia;
                            }
                            else if (j == 9)
                            {
                                dgvAdd[colDiaCD10, i].Value = dia;
                            }
                            //else if (j == 10)
                            //{
                            //    dgvAdd[colDiaCD6, i].Value = dt.Rows[i]["MNC_DIA_CD"].ToString();
                            //}
                        }
                        dtChr = cNhso1db.selectChronicbyVN(dateStart, dateEnd, hn, vn, preNo);
                        //lB1.Items.Add("กำลังดึงข้อมูล dtChr " + dtChr.Rows.Count);
                        //lB1.Refresh();
                        for (int k = 0; k < dtChr.Rows.Count; k++)
                        {
                            //if (nudChronic.Value <= k)
                            //{
                            //    continue;
                            //}
                            chronic = "";
                            chronic = config1.stringNull1(dtChr.Rows[k]["chroniccode"]);
                            if (k == 0)
                            {
                                dgvAdd[colCHRONICCODE1, i].Value = chronic;
                            }
                            else if (k == 1)
                            {
                                dgvAdd[colCHRONICCODE2, i].Value = chronic;
                            }
                            else if (k == 2)
                            {
                                dgvAdd[colCHRONICCODE3, i].Value = chronic;
                            }
                            else if (k == 3)
                            {
                                dgvAdd[colCHRONICCODE4, i].Value = chronic;
                            }
                            else if (k == 4)
                            {
                                dgvAdd[colCHRONICCODE5, i].Value = chronic;
                            }
                            else if (k == 5)
                            {
                                dgvAdd[colCHRONICCODE6, i].Value = chronic;
                            }
                            else if (k == 6)
                            {
                                dgvAdd[colCHRONICCODE7, i].Value = chronic;
                            }
                            else if (k == 7)
                            {
                                dgvAdd[colCHRONICCODE8, i].Value = chronic;
                            }
                            else if (k == 8)
                            {
                                dgvAdd[colCHRONICCODE9, i].Value = chronic;
                            }
                            else if (k == 9)
                            {
                                dgvAdd[colCHRONICCODE10, i].Value = chronic;
                            }
                            else if (k == 10)
                            {
                                //dgvAdd[colCHRONICCODE5, i].Value = dtChr.Rows[k]["chroniccode"].ToString();
                            }
                        }
                        dtDrug = cNhso1db.selectDrugbyVN(dateStart, dateEnd, hn, vn, preNo);
                        //lB1.Items.Add("กำลังดึงข้อมูล dtDrug " + dtDrug.Rows.Count);
                        //lB1.Refresh();
                        for (int l = 0; l < dtDrug.Rows.Count; l++)
                        {
                            //if (nudDrug.Value <= l)
                            //{
                            //    continue;
                            //}
                            pharName = dtDrug.Rows[l]["MNC_PH_TN"].ToString();
                            if (l == 0)
                            {
                                dgvAdd[colDrug1, i].Value = pharName;
                            }
                            else if (l == 1)
                            {
                                dgvAdd[colDrug2, i].Value = pharName;
                            }
                            else if (l == 2)
                            {
                                dgvAdd[colDrug3, i].Value = pharName;
                            }
                            else if (l == 3)
                            {
                                dgvAdd[colDrug4, i].Value = pharName;
                            }
                            else if (l == 4)
                            {
                                dgvAdd[colDrug5, i].Value = pharName;
                            }
                            else if (l == 5)
                            {
                                dgvAdd[colDrug6, i].Value = pharName;
                            }
                            else if (l == 6)
                            {
                                dgvAdd[colDrug7, i].Value = pharName;
                            }
                            else if (l == 7)
                            {
                                dgvAdd[colDrug8, i].Value = pharName;
                            }
                            else if (l == 8)
                            {
                                dgvAdd[colDrug9, i].Value = pharName;
                            }
                            else if (l == 9)
                            {
                                dgvAdd[colDrug10, i].Value = pharName;
                            }
                            else if (l == 10)
                            {
                                dgvAdd[colDrug11, i].Value = pharName;
                            }
                            else if (l == 11)
                            {
                                dgvAdd[colDrug12, i].Value = pharName;
                            }
                            else if (l == 12)
                            {
                                dgvAdd[colDrug13, i].Value = pharName;
                            }
                            else if (l == 13)
                            {
                                dgvAdd[colDrug14, i].Value = pharName;
                            }
                            else if (l == 14)
                            {
                                dgvAdd[colDrug15, i].Value = pharName;
                            }
                            else if (l == 15)
                            {
                                dgvAdd[colDrug16, i].Value = pharName;
                            }
                            else if (l == 16)
                            {
                                dgvAdd[colDrug17, i].Value = pharName;
                            }
                            else if (l == 17)
                            {
                                dgvAdd[colDrug18, i].Value = pharName;
                            }
                            else if (l == 18)
                            {
                                dgvAdd[colDrug19, i].Value = pharName;
                            }
                            else if (l == 19)
                            {
                                dgvAdd[colDrug20, i].Value = pharName;
                            }
                            else if (l == 20)
                            {
                                dgvAdd[colDrug21, i].Value = pharName;
                            }
                            else if (l == 21)
                            {
                                dgvAdd[colDrug22, i].Value = pharName;
                            }
                            else if (l == 22)
                            {
                                dgvAdd[colDrug23, i].Value = pharName;
                            }
                            else if (l == 23)
                            {
                                dgvAdd[colDrug24, i].Value = pharName;
                            }
                            else if (l == 24)
                            {
                                dgvAdd[colDrug25, i].Value = pharName;
                            }
                            else if (l == 25)
                            {
                                dgvAdd[colDrug26, i].Value = pharName;
                            }
                            else if (l == 26)
                            {
                                dgvAdd[colDrug27, i].Value = pharName;
                            }
                            else if (l == 27)
                            {
                                dgvAdd[colDrug28, i].Value = pharName;
                            }
                            else if (l == 28)
                            {
                                dgvAdd[colDrug29, i].Value = pharName;
                            }
                            else if (l == 29)
                            {
                                dgvAdd[colDrug30, i].Value = pharName;
                            }
                            //else if (l == 30)
                            //{
                            //    dgvAdd[colDrug21, i].Value = pharName;
                            //}
                        }
                        if (hn.Equals("5068244"))
                        {
                            labName = "";
                        }
                        dtLab = cNhso1db.selectLabbyVN(dateStart, dateEnd, hn, vn, preNo);
                        //lB1.Items.Add("กำลังดึงข้อมูล dtLab " + dtLab.Rows.Count);
                        //lB1.Refresh();
                        for (int m = 0; m < dtLab.Rows.Count; m++)
                        {
                            labName = dtLab.Rows[m]["MNC_LB_DSC"].ToString();
                            labResult = dtLab.Rows[m]["MNC_STS"].ToString();
                            labValue = dtLab.Rows[m]["MNC_RES_VALUE"].ToString();
                            if (m == 0)
                            {
                                dgvAdd[colLabName1, i].Value = labName;
                                dgvAdd[colLabResult1, i].Value = labResult;
                                dgvAdd[colLabValue1, i].Value = labValue;
                            }
                            else if (m == 1)
                            {
                                dgvAdd[colLabName2, i].Value = labName;
                                dgvAdd[colLabResult2, i].Value = labResult;
                                dgvAdd[colLabValue2, i].Value = labValue;
                            }
                            else if (m == 2)
                            {
                                dgvAdd[colLabName3, i].Value = labName;
                                dgvAdd[colLabResult3, i].Value = labResult;
                                dgvAdd[colLabValue3, i].Value = labValue;
                            }
                            else if (m == 3)
                            {
                                dgvAdd[colLabName4, i].Value = labName;
                                dgvAdd[colLabResult4, i].Value = labResult;
                                dgvAdd[colLabValue4, i].Value = labValue;
                            }
                            else if (m == 4)
                            {
                                dgvAdd[colLabName5, i].Value = labName;
                                dgvAdd[colLabResult5, i].Value = labResult;
                                dgvAdd[colLabValue5, i].Value = labValue;
                            }
                            else if (m == 5)
                            {
                                dgvAdd[colLabName6, i].Value = labName;
                                dgvAdd[colLabResult6, i].Value = labResult;
                                dgvAdd[colLabValue6, i].Value = labValue;
                            }
                            else if (m == 6)
                            {
                                dgvAdd[colLabName7, i].Value = labName;
                                dgvAdd[colLabResult7, i].Value = labResult;
                                dgvAdd[colLabValue7, i].Value = labValue;
                            }
                            else if (m == 7)
                            {
                                dgvAdd[colLabName8, i].Value = labName;
                                dgvAdd[colLabResult8, i].Value = labResult;
                                dgvAdd[colLabValue8, i].Value = labValue;
                            }
                            else if (m == 8)
                            {
                                dgvAdd[colLabName9, i].Value = labName;
                                dgvAdd[colLabResult9, i].Value = labResult;
                                dgvAdd[colLabValue9, i].Value = labValue;
                            }
                            else if (m == 9)
                            {
                                dgvAdd[colLabName10, i].Value = labName;
                                dgvAdd[colLabResult10, i].Value = labResult;
                                dgvAdd[colLabValue10, i].Value = labValue;
                            }
                            else if (m == 10)
                            {
                                dgvAdd[colLabName11, i].Value = labName;
                                dgvAdd[colLabResult11, i].Value = labResult;
                                dgvAdd[colLabValue11, i].Value = labValue;
                            }
                            else if (m == 11)
                            {
                                dgvAdd[colLabName12, i].Value = labName;
                                dgvAdd[colLabResult12, i].Value = labResult;
                                dgvAdd[colLabValue12, i].Value = labValue;
                            }
                            else if (m == 12)
                            {
                                dgvAdd[colLabName13, i].Value = labName;
                                dgvAdd[colLabResult13, i].Value = labResult;
                                dgvAdd[colLabValue13, i].Value = labValue;
                            }
                            else if (m == 13)
                            {
                                dgvAdd[colLabName14, i].Value = labName;
                                dgvAdd[colLabResult14, i].Value = labResult;
                                dgvAdd[colLabValue14, i].Value = labValue;
                            }
                            else if (m == 14)
                            {
                                dgvAdd[colLabName15, i].Value = labName;
                                dgvAdd[colLabResult15, i].Value = labResult;
                                dgvAdd[colLabValue15, i].Value = labValue;
                            }
                            else if (m == 15)
                            {
                                dgvAdd[colLabName16, i].Value = labName;
                                dgvAdd[colLabResult16, i].Value = labResult;
                                dgvAdd[colLabValue16, i].Value = labValue;
                            }
                            else if (m == 16)
                            {
                                dgvAdd[colLabName17, i].Value = labName;
                                dgvAdd[colLabResult17, i].Value = labResult;
                                dgvAdd[colLabValue17, i].Value = labValue;
                            }
                            else if (m == 17)
                            {
                                dgvAdd[colLabName18, i].Value = labName;
                                dgvAdd[colLabResult18, i].Value = labResult;
                                dgvAdd[colLabValue18, i].Value = labValue;
                            }
                            else if (m == 18)
                            {
                                dgvAdd[colLabName19, i].Value = labName;
                                dgvAdd[colLabResult19, i].Value = labResult;
                                dgvAdd[colLabValue19, i].Value = labValue;
                            }
                            else if (m == 19)
                            {
                                dgvAdd[colLabName20, i].Value = labName;
                                dgvAdd[colLabResult20, i].Value = labResult;
                                dgvAdd[colLabValue20, i].Value = labValue;
                            }
                            else if (m == 20)
                            {
                                dgvAdd[colLabName21, i].Value = labName;
                                dgvAdd[colLabResult21, i].Value = labResult;
                                dgvAdd[colLabValue21, i].Value = labValue;
                            }
                            else if (m == 21)
                            {
                                dgvAdd[colLabName22, i].Value = labName;
                                dgvAdd[colLabResult22, i].Value = labResult;
                                dgvAdd[colLabValue22, i].Value = labValue;
                            }
                            else if (m == 22)
                            {
                                dgvAdd[colLabName23, i].Value = labName;
                                dgvAdd[colLabResult23, i].Value = labResult;
                                dgvAdd[colLabValue23, i].Value = labValue;
                            }
                            else if (m == 23)
                            {
                                dgvAdd[colLabName24, i].Value = labName;
                                dgvAdd[colLabResult24, i].Value = labResult;
                                dgvAdd[colLabValue24, i].Value = labValue;
                            }
                            else if (m == 24)
                            {
                                dgvAdd[colLabName25, i].Value = labName;
                                dgvAdd[colLabResult25, i].Value = labResult;
                                dgvAdd[colLabValue25, i].Value = labValue;
                            }
                            else if (m == 25)
                            {
                                dgvAdd[colLabName26, i].Value = labName;
                                dgvAdd[colLabResult26, i].Value = labResult;
                                dgvAdd[colLabValue26, i].Value = labValue;
                            }
                            else if (m == 26)
                            {
                                dgvAdd[colLabName27, i].Value = labName;
                                dgvAdd[colLabResult27, i].Value = labResult;
                                dgvAdd[colLabValue27, i].Value = labValue;
                            }
                            else if (m == 27)
                            {
                                dgvAdd[colLabName28, i].Value = labName;
                                dgvAdd[colLabResult28, i].Value = labResult;
                                dgvAdd[colLabValue28, i].Value = labValue;
                            }
                            else if (m == 28)
                            {
                                dgvAdd[colLabName29, i].Value = labName;
                                dgvAdd[colLabResult29, i].Value = labResult;
                                dgvAdd[colLabValue29, i].Value = labValue;
                            }
                            else if (m == 29)
                            {
                                dgvAdd[colLabName30, i].Value = labName;
                                dgvAdd[colLabResult30, i].Value = labResult;
                                dgvAdd[colLabValue30, i].Value = labValue;
                            }
                        }

                        dgvAdd[colBranch, i].Value = cNhso1db.conn.server;
                        //dgvAdd[colCHRONICCODE1, i].Value = dt.Rows[i]["CHRONICCODE"].ToString();
                        //dgvAdd[colExport, i].Value = "ยกเลิก";
                        //if ((i % 2) != 0)
                        //{
                        //    dgvAdd.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
                        //}
                        pB1.Value = i;
                    }
                }
            }
            pB1.Hide();
            lB1.Items.Add("ดึงข้อมูลเรียบร้อย");
            lB1.Refresh();
        }

        private void saveCHeckNhso(Boolean isConvert)
        {
            Boolean isBranch = false;
            if (cNhso1db.conn.isBranch.Equals("yes"))
            {
                isBranch = true;
                if (!chkUnDel.Checked)
                {
                    cNhso1db.deleteAllClient();
                    lB1.Items.Add("Clear Temp");
                    lB1.Refresh();
                }
            }
            else
            {
                isBranch = false;
            }
            lB1.Items.Add("เตรียมบันทึกข้อมูล");
            lB1.Refresh();
            pB1.Show();
            pB1.Minimum = 0;
            pB1.Maximum = dgvAdd.Rows.Count;
            String vn = "", chk = "", visitDate = "";
            for (int i = 0; i < dgvAdd.Rows.Count; i++)
            {
                vn = "";
                if (dgvAdd[colDate, i].Value == null)
                {
                    continue;
                }
                CheckNhso1 p = new CheckNhso1();
                Debug.WriteLine("saveCHeckNhso i" + i);
                if (i == 3325)
                {
                    Debug.WriteLine("saveCHeckNhso i" + i);
                }
                if (dgvAdd[colDate, i].Value.ToString().Length >= 10)
                {
                    visitDate = dgvAdd[colDate, i].Value.ToString();
                    visitDate = visitDate.Substring(visitDate.Length - 4) + "-" + visitDate.Substring(3, 2) + "-" + visitDate.Substring(0, 2);
                }

                p.hn = dgvAdd[colPatientHnno, i].Value.ToString();
                p.patientName = dgvAdd[colPatientName, i].Value.ToString();
                //if (isBranch)
                if (isConvert)
                {
                    //lB1.Items.Add("111123");
                    vn = dgvAdd[colVn, i].Value.ToString() + dgvAdd[colvnSeq, i].Value.ToString() + dgvAdd[colvnSum, i].Value.ToString();
                    p.visitDate = visitDate;
                    visitDate = visitDate.Replace("-", "");
                    //p.checknhsoId = dgvAdd[colc, i].Value.ToString();
                    p.checknhsoId = cNhso1db.conn.server + visitDate + vn;

                    p.rowID = i.ToString();
                }
                else
                {
                    p.checknhsoId = dgvAdd[colId, i].Value.ToString();
                    p.visitDate = dgvAdd[colDate, i].Value.ToString();
                    p.rowID = dgvAdd[colRow, i].Value.ToString();
                }
                //lB1.Items.Add("111111");
                p.visitTime = dgvAdd[colTime, i].Value.ToString();

                p.vn = dgvAdd[colVn, i].Value.ToString();
                
                p.dia1 = dgvAdd[colDiaCD1, i].Value.ToString();
                p.dia2 = config1.stringNull1(dgvAdd[colDiaCD2, i].Value);
                p.dia3 = config1.stringNull1(dgvAdd[colDiaCD3, i].Value);
                p.dia4 = config1.stringNull1(dgvAdd[colDiaCD4, i].Value);
                p.dia5 = config1.stringNull1(dgvAdd[colDiaCD5, i].Value);
                p.dia6 = config1.stringNull1(dgvAdd[colDiaCD6, i].Value);
                p.dia7 = config1.stringNull1(dgvAdd[colDiaCD7, i].Value);
                p.dia8 = config1.stringNull1(dgvAdd[colDiaCD8, i].Value);
                p.dia9 = config1.stringNull1(dgvAdd[colDiaCD9, i].Value);
                p.dia10 = config1.stringNull1(dgvAdd[colDiaCD10, i].Value);

                p.chronic1 = config1.stringNull1(dgvAdd[colCHRONICCODE1, i].Value);
                p.chronic2 = config1.stringNull1(dgvAdd[colCHRONICCODE2, i].Value);
                p.chronic3 = config1.stringNull1(dgvAdd[colCHRONICCODE3, i].Value);
                p.chronic4 = config1.stringNull1(dgvAdd[colCHRONICCODE4, i].Value);
                p.chronic5 = config1.stringNull1(dgvAdd[colCHRONICCODE5, i].Value);
                p.chronic6 = config1.stringNull1(dgvAdd[colCHRONICCODE6, i].Value);
                p.chronic7 = config1.stringNull1(dgvAdd[colCHRONICCODE7, i].Value);
                p.chronic8 = config1.stringNull1(dgvAdd[colCHRONICCODE8, i].Value);
                p.chronic9 = config1.stringNull1(dgvAdd[colCHRONICCODE9, i].Value);
                p.chronic10 = config1.stringNull1(dgvAdd[colCHRONICCODE10, i].Value);

                p.drug1 = config1.stringNull1(dgvAdd[colDrug1, i].Value);
                p.drug2 = config1.stringNull1(dgvAdd[colDrug2, i].Value);
                p.drug3 = config1.stringNull1(dgvAdd[colDrug3, i].Value);
                p.drug4 = config1.stringNull1(dgvAdd[colDrug4, i].Value);
                p.drug5 = config1.stringNull1(dgvAdd[colDrug5, i].Value);
                p.drug6 = config1.stringNull1(dgvAdd[colDrug6, i].Value);
                p.drug7 = config1.stringNull1(dgvAdd[colDrug7, i].Value);
                p.drug8 = config1.stringNull1(dgvAdd[colDrug8, i].Value);
                p.drug9 = config1.stringNull1(dgvAdd[colDrug9, i].Value);
                p.drug10 = config1.stringNull1(dgvAdd[colDrug10, i].Value);
                p.drug11 = config1.stringNull1(dgvAdd[colDrug11, i].Value);
                p.drug12 = config1.stringNull1(dgvAdd[colDrug12, i].Value);
                p.drug13 = config1.stringNull1(dgvAdd[colDrug13, i].Value);
                p.drug14 = config1.stringNull1(dgvAdd[colDrug14, i].Value);
                p.drug15 = config1.stringNull1(dgvAdd[colDrug15, i].Value);
                p.drug16 = config1.stringNull1(dgvAdd[colDrug16, i].Value);
                p.drug17 = config1.stringNull1(dgvAdd[colDrug17, i].Value);
                p.drug18 = config1.stringNull1(dgvAdd[colDrug18, i].Value);
                p.drug19 = config1.stringNull1(dgvAdd[colDrug19, i].Value);
                p.drug20 = config1.stringNull1(dgvAdd[colDrug20, i].Value);
                p.drug21 = config1.stringNull1(dgvAdd[colDrug21, i].Value);
                p.drug22 = config1.stringNull1(dgvAdd[colDrug22, i].Value);
                p.drug23 = config1.stringNull1(dgvAdd[colDrug23, i].Value);
                p.drug24 = config1.stringNull1(dgvAdd[colDrug24, i].Value);
                p.drug25 = config1.stringNull1(dgvAdd[colDrug25, i].Value);
                p.drug26 = config1.stringNull1(dgvAdd[colDrug26, i].Value);
                p.drug27 = config1.stringNull1(dgvAdd[colDrug27, i].Value);
                p.drug28 = config1.stringNull1(dgvAdd[colDrug28, i].Value);
                p.drug29 = config1.stringNull1(dgvAdd[colDrug29, i].Value);
                p.drug30 = config1.stringNull1(dgvAdd[colDrug30, i].Value);

                //MessageBox.Show("222222", "22222");
                p.labName1 = config1.stringNull1(dgvAdd[colLabName1, i].Value);
                p.labResult1 = config1.stringNull1(dgvAdd[colLabResult1, i].Value);
                p.labValue1 = config1.stringNull1(dgvAdd[colLabValue1, i].Value);
                p.labName2 = config1.stringNull1(dgvAdd[colLabName2, i].Value);
                p.labResult2 = config1.stringNull1(dgvAdd[colLabResult2, i].Value);
                p.labValue2 = config1.stringNull1(dgvAdd[colLabValue2, i].Value);
                p.labName3 = config1.stringNull1(dgvAdd[colLabName3, i].Value);
                p.labResult3 = config1.stringNull1(dgvAdd[colLabResult3, i].Value);
                p.labValue3 = config1.stringNull1(dgvAdd[colLabValue3, i].Value);
                p.labName4 = config1.stringNull1(dgvAdd[colLabName4, i].Value);
                p.labResult4 = config1.stringNull1(dgvAdd[colLabResult4, i].Value);
                p.labValue4 = config1.stringNull1(dgvAdd[colLabValue4, i].Value);
                p.labName5 = config1.stringNull1(dgvAdd[colLabName5, i].Value);
                p.labResult5 = config1.stringNull1(dgvAdd[colLabResult5, i].Value);
                p.labValue5 = config1.stringNull1(dgvAdd[colLabValue5, i].Value);
                p.labName6 = config1.stringNull1(dgvAdd[colLabName6, i].Value);
                p.labResult6 = config1.stringNull1(dgvAdd[colLabResult6, i].Value);
                p.labValue6 = config1.stringNull1(dgvAdd[colLabValue6, i].Value);
                p.labName7 = config1.stringNull1(dgvAdd[colLabName7, i].Value);
                p.labResult7 = config1.stringNull1(dgvAdd[colLabResult7, i].Value);
                p.labValue7 = config1.stringNull1(dgvAdd[colLabValue7, i].Value);
                p.labName8 = config1.stringNull1(dgvAdd[colLabName8, i].Value);
                p.labResult8 = config1.stringNull1(dgvAdd[colLabResult8, i].Value);
                p.labValue8 = config1.stringNull1(dgvAdd[colLabValue8, i].Value);
                p.labName9 = config1.stringNull1(dgvAdd[colLabName9, i].Value);
                p.labResult9 = config1.stringNull1(dgvAdd[colLabResult9, i].Value);
                p.labValue9 = config1.stringNull1(dgvAdd[colLabValue9, i].Value);
                p.labName10 = config1.stringNull1(dgvAdd[colLabName10, i].Value);
                p.labResult10 = config1.stringNull1(dgvAdd[colLabResult10, i].Value);
                p.labValue10 = config1.stringNull1(dgvAdd[colLabValue10, i].Value);
                p.labName11 = config1.stringNull1(dgvAdd[colLabName11, i].Value);
                p.labResult11 = config1.stringNull1(dgvAdd[colLabResult11, i].Value);
                p.labValue11 = config1.stringNull1(dgvAdd[colLabValue11, i].Value);
                p.labName12 = config1.stringNull1(dgvAdd[colLabName12, i].Value);
                p.labResult12 = config1.stringNull1(dgvAdd[colLabResult12, i].Value);
                p.labValue12 = config1.stringNull1(dgvAdd[colLabValue12, i].Value);
                p.labName13 = config1.stringNull1(dgvAdd[colLabName13, i].Value);
                p.labResult13 = config1.stringNull1(dgvAdd[colLabResult13, i].Value);
                p.labValue13 = config1.stringNull1(dgvAdd[colLabValue13, i].Value);
                p.labName14 = config1.stringNull1(dgvAdd[colLabName14, i].Value);
                p.labResult14 = config1.stringNull1(dgvAdd[colLabResult14, i].Value);
                p.labValue14 = config1.stringNull1(dgvAdd[colLabValue14, i].Value);
                p.labName15 = config1.stringNull1(dgvAdd[colLabName15, i].Value);
                p.labResult15 = config1.stringNull1(dgvAdd[colLabResult15, i].Value);
                p.labValue15 = config1.stringNull1(dgvAdd[colLabValue15, i].Value);
                p.labName16 = config1.stringNull1(dgvAdd[colLabName16, i].Value);
                p.labResult16 = config1.stringNull1(dgvAdd[colLabResult16, i].Value);
                p.labValue16 = config1.stringNull1(dgvAdd[colLabValue16, i].Value);
                p.labName17 = config1.stringNull1(dgvAdd[colLabName17, i].Value);
                p.labResult17 = config1.stringNull1(dgvAdd[colLabResult17, i].Value);
                p.labValue17 = config1.stringNull1(dgvAdd[colLabValue17, i].Value);
                p.labName18 = config1.stringNull1(dgvAdd[colLabName18, i].Value);
                p.labResult18 = config1.stringNull1(dgvAdd[colLabResult18, i].Value);
                p.labValue18 = config1.stringNull1(dgvAdd[colLabValue18, i].Value);
                p.labName19 = config1.stringNull1(dgvAdd[colLabName19, i].Value);
                p.labResult19 = config1.stringNull1(dgvAdd[colLabResult19, i].Value);
                p.labValue19 = config1.stringNull1(dgvAdd[colLabValue19, i].Value);
                p.labName20 = config1.stringNull1(dgvAdd[colLabName20, i].Value);
                p.labResult20 = config1.stringNull1(dgvAdd[colLabResult20, i].Value);
                p.labValue20 = config1.stringNull1(dgvAdd[colLabValue20, i].Value);
                p.labName21 = config1.stringNull1(dgvAdd[colLabName21, i].Value);
                p.labResult21 = config1.stringNull1(dgvAdd[colLabResult21, i].Value);
                p.labValue21 = config1.stringNull1(dgvAdd[colLabValue21, i].Value);
                p.labName22 = config1.stringNull1(dgvAdd[colLabName22, i].Value);
                p.labResult22 = config1.stringNull1(dgvAdd[colLabResult22, i].Value);
                p.labValue22 = config1.stringNull1(dgvAdd[colLabValue22, i].Value);
                p.labName23 = config1.stringNull1(dgvAdd[colLabName23, i].Value);
                p.labResult23 = config1.stringNull1(dgvAdd[colLabResult23, i].Value);
                p.labValue23 = config1.stringNull1(dgvAdd[colLabValue23, i].Value);
                p.labName24 = config1.stringNull1(dgvAdd[colLabName24, i].Value);
                p.labResult24 = config1.stringNull1(dgvAdd[colLabResult24, i].Value);
                p.labValue24 = config1.stringNull1(dgvAdd[colLabValue24, i].Value);
                p.labName25 = config1.stringNull1(dgvAdd[colLabName25, i].Value);
                p.labResult25 = config1.stringNull1(dgvAdd[colLabResult25, i].Value);
                p.labValue25 = config1.stringNull1(dgvAdd[colLabValue25, i].Value);
                p.labName26 = config1.stringNull1(dgvAdd[colLabName26, i].Value);
                p.labResult26 = config1.stringNull1(dgvAdd[colLabResult26, i].Value);
                p.labValue26 = config1.stringNull1(dgvAdd[colLabValue26, i].Value);
                p.labName27 = config1.stringNull1(dgvAdd[colLabName27, i].Value);
                p.labResult27 = config1.stringNull1(dgvAdd[colLabResult27, i].Value);
                p.labValue27 = config1.stringNull1(dgvAdd[colLabValue27, i].Value);
                p.labName28 = config1.stringNull1(dgvAdd[colLabName28, i].Value);
                p.labResult28 = config1.stringNull1(dgvAdd[colLabResult28, i].Value);
                p.labValue28 = config1.stringNull1(dgvAdd[colLabValue28, i].Value);
                p.labName29 = config1.stringNull1(dgvAdd[colLabName29, i].Value);
                p.labResult29 = config1.stringNull1(dgvAdd[colLabResult29, i].Value);
                p.labValue29 = config1.stringNull1(dgvAdd[colLabValue29, i].Value);
                p.labName30 = config1.stringNull1(dgvAdd[colLabName30, i].Value);
                p.labResult30 = config1.stringNull1(dgvAdd[colLabResult30, i].Value);
                p.labValue30 = config1.stringNull1(dgvAdd[colLabValue30, i].Value);

                p.rowEdit = config1.stringNull1(dgvAdd[colLabValue10, i].Value);
                //lB1.Items.Add("22222");
                p.statusActive = "1";
                //if (isBranch)
                //{
                p.branchID = dgvAdd[colBranch, i].Value.ToString();
                //}
                //else
                //{
                //p.branchID = cNhso1db.conn.server;
                //}
                //MessageBox.Show("11", "11");
                //if (isBranch)
                //{
                //wt.writeTxt();
                chk = cNhso1db.insertCHeckNhso(p, isBranch);
                //}
                //else
                //{
                //    chk = cNhso1db.insertCHeckNhso(p);
                //}

                //if (chk.Equals(p.checknhsoId))
                //{
                //    dgvAdd.Rows[i].DefaultCellStyle.BackColor = Color.Cornsilk;
                //}

                pB1.Value = i;
            }
            pB1.Hide();
            lB1.Items.Add("บันทึกข้อมูลเรียบร้อย");
            lB1.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String dateStart = "", dateEnd = "";
            DataTable dt = new DataTable();
            lB1.Items.Clear();
            lB1.Items.Add("ตรวจสอบข้อมูล");
            lB1.Refresh();
            dateStart = dtpStart.Value.Year.ToString() + "-" + dtpStart.Value.ToString("MM-dd");
            dateEnd = dtpEnd.Value.Year.ToString() + "-" + dtpEnd.Value.ToString("MM-dd");
            lB1.Items.Add("ประจำวันที่ " + dateStart + " ถึงวันที่ " + dateEnd);
            dt = cNhso1db.selectByDate(dateStart, dateEnd, "", "", "", "", "",false, false, cNhso1db.conn.server);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("พบข้อมูล \n" + "วันที่ " + dateStart+" ถึงวันที่ "+dateEnd, "มีข้อมูล");
                lB1.Items.Add("พบข้อมูล");
                lB1.Refresh();
                return;
            }

            setData1(dateStart, dateEnd);
            saveCHeckNhso(true);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String visitDate = "", dateStart1 = "", dateEnd1 = "", hn = "", vn = "", id="";
            DataTable dt = new DataTable();
            int vn1 = 0;
            dateStart1 = dtpStart.Value.Year.ToString() + "-" + dtpStart.Value.ToString("MM-dd");
            dateEnd1 = dtpEnd.Value.Year.ToString() + "-" + dtpEnd.Value.ToString("MM-dd");
            dateStart1 = (int.Parse(dateStart1.Substring(0, 4)) + 543) + dateStart1.Substring(4);
            dateEnd1 = (int.Parse(dateEnd1.Substring(0, 4)) + 543) + dateEnd1.Substring(4);
            dt = cNhso1db.selectByDate(dateStart1, dateEnd1, "", "", "", "", "", false, false, "005");
            pB1.Visible = true;
            pB1.Minimum = 0;
            pB1.Maximum = dt.Rows.Count;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                id = dt.Rows[i][cNhso1db.cNhso1.checknhsoId].ToString();
                hn = dt.Rows[i][cNhso1db.cNhso1.hn].ToString();
                vn = dt.Rows[i][cNhso1db.cNhso1.vn].ToString();
                //if (vn.Length > 1)
                //{
                //    continue;
                //}
                if (int.TryParse(vn,out vn1))
                {
                    visitDate = dt.Rows[i][cNhso1db.cNhso1.visitDate].ToString();
                    visitDate = (int.Parse(visitDate.Substring(0, 4)) - 543) + visitDate.Substring(4);
                    DataTable dt1 = cNhso1db.selectbyVN(visitDate, hn, vn1.ToString());
                    if (dt1.Rows.Count == 1)
                    {
                        String preno = "", vnsum = "", vnseq = "";
                        preno = dt1.Rows[0]["mnc_pre_no"].ToString();
                        vnsum = dt1.Rows[0]["mnc_vn_sum"].ToString();
                        vnseq = dt1.Rows[0]["mnc_vn_seq"].ToString();
                        cNhso1db.updatePreno(id, preno, vnseq, vnsum);
                    }
                }
                
                pB1.Value = i;
            }
            pB1.Visible = false;
        }
        public String writeText(String dateStart, String dateEnd)
        {
            String data = "", chk = "";
            DataTable dt;
            dt = cNhso1db.selectByDate(dateStart, dateEnd);
            //dt = .selectAll();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                data += dt.Rows[i][cNhso1db.cNhso1.checknhsoId].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.chronic1].ToString().Trim() + "\t" 
                    + dt.Rows[i][cNhso1db.cNhso1.chronic2].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.chronic3].ToString().Trim() +"\t"
                    + dt.Rows[i][cNhso1db.cNhso1.chronic4].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.chronic5].ToString().Trim() + "\t"
                    + dt.Rows[i][cNhso1db.cNhso1.chronic6].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.chronic7].ToString().Trim() + "\t"
                    + dt.Rows[i][cNhso1db.cNhso1.chronic8].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.chronic9].ToString().Trim() + "\t"
                    + dt.Rows[i][cNhso1db.cNhso1.chronic10].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.dia1].ToString().Trim() + "\t"
                    + dt.Rows[i][cNhso1db.cNhso1.dia2].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.dia3].ToString().Trim() + "\t"
                    + dt.Rows[i][cNhso1db.cNhso1.dia4].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.dia5].ToString().Trim() + "\t"
                    + dt.Rows[i][cNhso1db.cNhso1.dia1Ori].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.dia2Ori].ToString().Trim() + "\t"
                    + dt.Rows[i][cNhso1db.cNhso1.dia3Or1].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.dia4Ori].ToString().Trim() + "\t"
                    + dt.Rows[i][cNhso1db.cNhso1.dia5Ori].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.drug1].ToString().Trim() + "\t"
                    + dt.Rows[i][cNhso1db.cNhso1.drug2].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.drug3].ToString().Trim() + "\t"
                    + dt.Rows[i][cNhso1db.cNhso1.drug4].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.drug5].ToString().Trim() + "\t"
                    + dt.Rows[i][cNhso1db.cNhso1.drug6].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.drug7].ToString().Trim() + "\t"
                    + dt.Rows[i][cNhso1db.cNhso1.drug8].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.drug9].ToString().Trim() + "\t"
                    + dt.Rows[i][cNhso1db.cNhso1.drug10].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.drug11].ToString().Trim() + "\t"
                    + dt.Rows[i][cNhso1db.cNhso1.drug12].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.drug13].ToString().Trim() + "\t"
                    + dt.Rows[i][cNhso1db.cNhso1.drug14].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.drug15].ToString().Trim() + "\t"
                    + dt.Rows[i][cNhso1db.cNhso1.drug16].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.drug17].ToString().Trim() + "\t"
                    + dt.Rows[i][cNhso1db.cNhso1.drug18].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.drug19].ToString().Trim() + "\t"
                    + dt.Rows[i][cNhso1db.cNhso1.drug20].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.labName1].ToString().Trim() + "\t"
                    + dt.Rows[i][cNhso1db.cNhso1.labName2].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.labName3].ToString().Trim() + "\t"
                    + dt.Rows[i][cNhso1db.cNhso1.labName4].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.labName5].ToString().Trim() + "\t"
                    + dt.Rows[i][cNhso1db.cNhso1.labName6].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.labName7].ToString().Trim() + "\t"
                    + dt.Rows[i][cNhso1db.cNhso1.labName8].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.labName9].ToString().Trim() + "\t"
                    + dt.Rows[i][cNhso1db.cNhso1.labName10].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.labResult1].ToString().Trim() + "\t"
                    + dt.Rows[i][cNhso1db.cNhso1.labResult2].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.labResult3].ToString().Trim() + "\t"
                    + dt.Rows[i][cNhso1db.cNhso1.labResult4].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.labResult5].ToString().Trim() + "\t"
                    + dt.Rows[i][cNhso1db.cNhso1.labResult6].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.labResult7].ToString().Trim() + "\t"
                    + dt.Rows[i][cNhso1db.cNhso1.labResult8].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.labResult9].ToString().Trim() + "\t"
                    + dt.Rows[i][cNhso1db.cNhso1.labResult10].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.labValue1].ToString().Trim() + "\t"
                    + dt.Rows[i][cNhso1db.cNhso1.labValue2].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.labValue3].ToString().Trim() + "\t"
                    + dt.Rows[i][cNhso1db.cNhso1.labValue4].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.labValue5].ToString().Trim() + "\t"
                    + dt.Rows[i][cNhso1db.cNhso1.labValue6].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.labValue7].ToString().Trim() + "\t"
                    + dt.Rows[i][cNhso1db.cNhso1.labValue8].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.labValue9].ToString().Trim() + "\t"
                    + dt.Rows[i][cNhso1db.cNhso1.labValue10].ToString().Trim() + "\t" + dt.Rows[i][cNhso1db.cNhso1.patientName].ToString().Trim() + "\t"
                    + Environment.NewLine;
            }
            //pathFileSedan = setPathFile(pathFileSedan);
            if (wt.writeTxt("", "CarAge.txt", data))
            {
                chk = "จำนวนข้อมูล อายุรถเก๋งทั้งหมด " + dt.Rows.Count + " รายการ ";
                //MessageBox.Show("", "เขียน Text File  เรียบร้อย");
            }
            return chk;
        }

        private void FrmCheckNHSOAdd_Load(object sender, EventArgs e)
        {
            this.Text = "Host="+cNhso1db.conn.hostNameMainHIS+" database="+cNhso1db.conn.databaseNameMainHIS+" user="+cNhso1db.conn.userNameMainHIS+" pass="+cNhso1db.conn.passwordMainHIS+" Path "+ Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); ;

        }

        private void btnChk_Click(object sender, EventArgs e)
        {
            pB1.Show();
            DataTable dt = new DataTable();
            lB1.Items.Clear();
            lB1.Items.Add("ตรวจสอบข้อมูล");
            lB1.Items.Add(cNhso1db.selectImportDataByDate());
            dt = cNhso1db.selectImport();
            if (dt.Rows.Count > 0)
            {
                pB1.Minimum = 0;
                pB1.Maximum = dt.Rows.Count;
                dgvAdd.RowCount = dt.Rows.Count;
                dgvAdd.ColumnCount = colCnt;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //if (dt.Rows[i][cNhso1db.cNhso1.editDia] != null)
                    //{
                    //    edit = dt.Rows[i][cNhso1db.cNhso1.editDia].ToString().Split(new char[] { ',' });
                    //    if (edit.Length > 0)
                    //    {
                    //        for (int j = 0; j < edit.Length; j++)
                    //        {
                    //            if (!edit[j].Equals(""))
                    //            {
                    //                dgvAdd.Rows[i].Cells[int.Parse(edit[j])].Style.BackColor = Color.Red;
                    //            }
                    //        }
                    //    }
                    //}

                    dgvAdd[colRow, i].Value = (i + 1);
                    //dgvAdd[colvnSeq, i].Value = dt.Rows[i][cNhso1db.cNhso1.v].ToString();
                    dgvAdd[colId, i].Value = dt.Rows[i][cNhso1db.cNhso1.checknhsoId].ToString();
                    dgvAdd[colVn, i].Value = dt.Rows[i][cNhso1db.cNhso1.vn].ToString();
                    dgvAdd[colPatientName, i].Value = dt.Rows[i][cNhso1db.cNhso1.patientName].ToString();
                    dgvAdd[colPatientHnno, i].Value = dt.Rows[i][cNhso1db.cNhso1.hn].ToString();
                    //visitDate = dt.Rows[i][cNhso1db.cNhso1.visitDate].ToString();
                    //dgvAdd[colDate, i].Value = config1.dateDBtoShow25(visitDate);
                    dgvAdd[colDate, i].Value = dt.Rows[i][cNhso1db.cNhso1.visitDate].ToString();
                    dgvAdd[colTime, i].Value = dt.Rows[i][cNhso1db.cNhso1.visitTime].ToString();

                    dgvAdd[colDiaCD1, i].Value = dt.Rows[i][cNhso1db.cNhso1.dia1].ToString();
                    dgvAdd[colDiaCD2, i].Value = dt.Rows[i][cNhso1db.cNhso1.dia2].ToString();
                    dgvAdd[colDiaCD3, i].Value = dt.Rows[i][cNhso1db.cNhso1.dia3].ToString();
                    dgvAdd[colDiaCD4, i].Value = dt.Rows[i][cNhso1db.cNhso1.dia4].ToString();
                    dgvAdd[colDiaCD5, i].Value = dt.Rows[i][cNhso1db.cNhso1.dia5].ToString();
                    dgvAdd[colDiaCD6, i].Value = dt.Rows[i][cNhso1db.cNhso1.dia6].ToString();
                    dgvAdd[colDiaCD7, i].Value = dt.Rows[i][cNhso1db.cNhso1.dia7].ToString();
                    dgvAdd[colDiaCD8, i].Value = dt.Rows[i][cNhso1db.cNhso1.dia8].ToString();
                    dgvAdd[colDiaCD9, i].Value = dt.Rows[i][cNhso1db.cNhso1.dia9].ToString();
                    dgvAdd[colDiaCD10, i].Value = dt.Rows[i][cNhso1db.cNhso1.dia10].ToString();

                    dgvAdd[colCHRONICCODE1, i].Value = dt.Rows[i][cNhso1db.cNhso1.chronic1].ToString();
                    dgvAdd[colCHRONICCODE2, i].Value = dt.Rows[i][cNhso1db.cNhso1.chronic2].ToString();
                    dgvAdd[colCHRONICCODE3, i].Value = dt.Rows[i][cNhso1db.cNhso1.chronic3].ToString();
                    dgvAdd[colCHRONICCODE4, i].Value = dt.Rows[i][cNhso1db.cNhso1.chronic4].ToString();
                    dgvAdd[colCHRONICCODE5, i].Value = dt.Rows[i][cNhso1db.cNhso1.chronic5].ToString();
                    dgvAdd[colCHRONICCODE6, i].Value = dt.Rows[i][cNhso1db.cNhso1.chronic6].ToString();
                    dgvAdd[colCHRONICCODE7, i].Value = dt.Rows[i][cNhso1db.cNhso1.chronic7].ToString();
                    dgvAdd[colCHRONICCODE8, i].Value = dt.Rows[i][cNhso1db.cNhso1.chronic8].ToString();
                    dgvAdd[colCHRONICCODE9, i].Value = dt.Rows[i][cNhso1db.cNhso1.chronic9].ToString();
                    dgvAdd[colCHRONICCODE10, i].Value = dt.Rows[i][cNhso1db.cNhso1.chronic10].ToString();

                    dgvAdd[colDrug1, i].Value = dt.Rows[i][cNhso1db.cNhso1.drug1].ToString();
                    dgvAdd[colDrug2, i].Value = dt.Rows[i][cNhso1db.cNhso1.drug2].ToString();
                    dgvAdd[colDrug3, i].Value = dt.Rows[i][cNhso1db.cNhso1.drug3].ToString();
                    dgvAdd[colDrug4, i].Value = dt.Rows[i][cNhso1db.cNhso1.drug4].ToString();
                    dgvAdd[colDrug5, i].Value = dt.Rows[i][cNhso1db.cNhso1.drug5].ToString();
                    dgvAdd[colDrug6, i].Value = dt.Rows[i][cNhso1db.cNhso1.drug6].ToString();
                    dgvAdd[colDrug7, i].Value = dt.Rows[i][cNhso1db.cNhso1.drug7].ToString();
                    dgvAdd[colDrug8, i].Value = dt.Rows[i][cNhso1db.cNhso1.drug8].ToString();
                    dgvAdd[colDrug9, i].Value = dt.Rows[i][cNhso1db.cNhso1.drug9].ToString();
                    dgvAdd[colDrug10, i].Value = dt.Rows[i][cNhso1db.cNhso1.drug10].ToString();
                    dgvAdd[colDrug11, i].Value = dt.Rows[i][cNhso1db.cNhso1.drug11].ToString();
                    dgvAdd[colDrug12, i].Value = dt.Rows[i][cNhso1db.cNhso1.drug12].ToString();
                    dgvAdd[colDrug13, i].Value = dt.Rows[i][cNhso1db.cNhso1.drug13].ToString();
                    dgvAdd[colDrug14, i].Value = dt.Rows[i][cNhso1db.cNhso1.drug14].ToString();
                    dgvAdd[colDrug15, i].Value = dt.Rows[i][cNhso1db.cNhso1.drug15].ToString();
                    dgvAdd[colDrug16, i].Value = dt.Rows[i][cNhso1db.cNhso1.drug16].ToString();
                    dgvAdd[colDrug17, i].Value = dt.Rows[i][cNhso1db.cNhso1.drug17].ToString();
                    dgvAdd[colDrug18, i].Value = dt.Rows[i][cNhso1db.cNhso1.drug18].ToString();
                    dgvAdd[colDrug19, i].Value = dt.Rows[i][cNhso1db.cNhso1.drug19].ToString();
                    dgvAdd[colDrug20, i].Value = dt.Rows[i][cNhso1db.cNhso1.drug20].ToString();
                    dgvAdd[colDrug21, i].Value = dt.Rows[i][cNhso1db.cNhso1.drug21].ToString();
                    dgvAdd[colDrug22, i].Value = dt.Rows[i][cNhso1db.cNhso1.drug22].ToString();
                    dgvAdd[colDrug23, i].Value = dt.Rows[i][cNhso1db.cNhso1.drug23].ToString();
                    dgvAdd[colDrug24, i].Value = dt.Rows[i][cNhso1db.cNhso1.drug24].ToString();
                    dgvAdd[colDrug25, i].Value = dt.Rows[i][cNhso1db.cNhso1.drug25].ToString();
                    dgvAdd[colDrug26, i].Value = dt.Rows[i][cNhso1db.cNhso1.drug26].ToString();
                    dgvAdd[colDrug27, i].Value = dt.Rows[i][cNhso1db.cNhso1.drug27].ToString();
                    dgvAdd[colDrug28, i].Value = dt.Rows[i][cNhso1db.cNhso1.drug28].ToString();
                    dgvAdd[colDrug29, i].Value = dt.Rows[i][cNhso1db.cNhso1.drug29].ToString();
                    dgvAdd[colDrug30, i].Value = dt.Rows[i][cNhso1db.cNhso1.drug30].ToString();

                    dgvAdd[colLabName1, i].Value = dt.Rows[i][cNhso1db.cNhso1.labName1].ToString();
                    dgvAdd[colLabResult1, i].Value = dt.Rows[i][cNhso1db.cNhso1.labResult1].ToString();
                    dgvAdd[colLabValue1, i].Value = dt.Rows[i][cNhso1db.cNhso1.labValue1].ToString();

                    dgvAdd[colLabName2, i].Value = dt.Rows[i][cNhso1db.cNhso1.labName2].ToString();
                    dgvAdd[colLabResult2, i].Value = dt.Rows[i][cNhso1db.cNhso1.labResult2].ToString();
                    dgvAdd[colLabValue2, i].Value = dt.Rows[i][cNhso1db.cNhso1.labValue2].ToString();

                    dgvAdd[colLabName3, i].Value = dt.Rows[i][cNhso1db.cNhso1.labName3].ToString();
                    dgvAdd[colLabResult3, i].Value = dt.Rows[i][cNhso1db.cNhso1.labResult3].ToString();
                    dgvAdd[colLabValue3, i].Value = dt.Rows[i][cNhso1db.cNhso1.labValue3].ToString();

                    dgvAdd[colLabName4, i].Value = dt.Rows[i][cNhso1db.cNhso1.labName4].ToString();
                    dgvAdd[colLabResult4, i].Value = dt.Rows[i][cNhso1db.cNhso1.labResult4].ToString();
                    dgvAdd[colLabValue4, i].Value = dt.Rows[i][cNhso1db.cNhso1.labValue4].ToString();

                    dgvAdd[colLabName5, i].Value = dt.Rows[i][cNhso1db.cNhso1.labName5].ToString();
                    dgvAdd[colLabResult5, i].Value = dt.Rows[i][cNhso1db.cNhso1.labResult5].ToString();
                    dgvAdd[colLabValue5, i].Value = dt.Rows[i][cNhso1db.cNhso1.labValue5].ToString();

                    dgvAdd[colLabName6, i].Value = dt.Rows[i][cNhso1db.cNhso1.labName6].ToString();
                    dgvAdd[colLabResult6, i].Value = dt.Rows[i][cNhso1db.cNhso1.labResult6].ToString();
                    dgvAdd[colLabValue6, i].Value = dt.Rows[i][cNhso1db.cNhso1.labValue6].ToString();

                    dgvAdd[colLabName7, i].Value = dt.Rows[i][cNhso1db.cNhso1.labName7].ToString();
                    dgvAdd[colLabResult7, i].Value = dt.Rows[i][cNhso1db.cNhso1.labResult7].ToString();
                    dgvAdd[colLabValue7, i].Value = dt.Rows[i][cNhso1db.cNhso1.labValue7].ToString();

                    dgvAdd[colLabName8, i].Value = dt.Rows[i][cNhso1db.cNhso1.labName8].ToString();
                    dgvAdd[colLabResult8, i].Value = dt.Rows[i][cNhso1db.cNhso1.labResult8].ToString();
                    dgvAdd[colLabValue8, i].Value = dt.Rows[i][cNhso1db.cNhso1.labValue8].ToString();

                    dgvAdd[colLabName9, i].Value = dt.Rows[i][cNhso1db.cNhso1.labName9].ToString();
                    dgvAdd[colLabResult9, i].Value = dt.Rows[i][cNhso1db.cNhso1.labResult9].ToString();
                    dgvAdd[colLabValue9, i].Value = dt.Rows[i][cNhso1db.cNhso1.labValue9].ToString();

                    dgvAdd[colLabName10, i].Value = dt.Rows[i][cNhso1db.cNhso1.labName10].ToString();
                    dgvAdd[colLabResult10, i].Value = dt.Rows[i][cNhso1db.cNhso1.labResult10].ToString();
                    dgvAdd[colLabValue10, i].Value = dt.Rows[i][cNhso1db.cNhso1.labValue10].ToString();

                    dgvAdd[colEditDia, i].Value = dt.Rows[i][cNhso1db.cNhso1.editDia].ToString();
                    dgvAdd[colEditDrug, i].Value = dt.Rows[i][cNhso1db.cNhso1.editDrug].ToString();
                    dgvAdd[colBranch, i].Value = dt.Rows[i][cNhso1db.cNhso1.branchID].ToString();

                    dgvAdd[colLabName11, i].Value = dt.Rows[i][cNhso1db.cNhso1.labName11].ToString();
                    dgvAdd[colLabResult11, i].Value = dt.Rows[i][cNhso1db.cNhso1.labResult11].ToString();
                    dgvAdd[colLabValue11, i].Value = dt.Rows[i][cNhso1db.cNhso1.labValue11].ToString();

                    dgvAdd[colLabName12, i].Value = dt.Rows[i][cNhso1db.cNhso1.labName12].ToString();
                    dgvAdd[colLabResult12, i].Value = dt.Rows[i][cNhso1db.cNhso1.labResult12].ToString();
                    dgvAdd[colLabValue12, i].Value = dt.Rows[i][cNhso1db.cNhso1.labValue12].ToString();

                    dgvAdd[colLabName13, i].Value = dt.Rows[i][cNhso1db.cNhso1.labName13].ToString();
                    dgvAdd[colLabResult13, i].Value = dt.Rows[i][cNhso1db.cNhso1.labResult13].ToString();
                    dgvAdd[colLabValue13, i].Value = dt.Rows[i][cNhso1db.cNhso1.labValue13].ToString();

                    dgvAdd[colLabName14, i].Value = dt.Rows[i][cNhso1db.cNhso1.labName14].ToString();
                    dgvAdd[colLabResult14, i].Value = dt.Rows[i][cNhso1db.cNhso1.labResult14].ToString();
                    dgvAdd[colLabValue14, i].Value = dt.Rows[i][cNhso1db.cNhso1.labValue14].ToString();

                    dgvAdd[colLabName15, i].Value = dt.Rows[i][cNhso1db.cNhso1.labName15].ToString();
                    dgvAdd[colLabResult15, i].Value = dt.Rows[i][cNhso1db.cNhso1.labResult15].ToString();
                    dgvAdd[colLabValue15, i].Value = dt.Rows[i][cNhso1db.cNhso1.labValue15].ToString();

                    dgvAdd[colLabName16, i].Value = dt.Rows[i][cNhso1db.cNhso1.labName16].ToString();
                    dgvAdd[colLabResult16, i].Value = dt.Rows[i][cNhso1db.cNhso1.labResult16].ToString();
                    dgvAdd[colLabValue16, i].Value = dt.Rows[i][cNhso1db.cNhso1.labValue16].ToString();

                    dgvAdd[colLabName17, i].Value = dt.Rows[i][cNhso1db.cNhso1.labName17].ToString();
                    dgvAdd[colLabResult17, i].Value = dt.Rows[i][cNhso1db.cNhso1.labResult17].ToString();
                    dgvAdd[colLabValue17, i].Value = dt.Rows[i][cNhso1db.cNhso1.labValue17].ToString();

                    dgvAdd[colLabName18, i].Value = dt.Rows[i][cNhso1db.cNhso1.labName18].ToString();
                    dgvAdd[colLabResult18, i].Value = dt.Rows[i][cNhso1db.cNhso1.labResult18].ToString();
                    dgvAdd[colLabValue18, i].Value = dt.Rows[i][cNhso1db.cNhso1.labValue18].ToString();

                    dgvAdd[colLabName19, i].Value = dt.Rows[i][cNhso1db.cNhso1.labName19].ToString();
                    dgvAdd[colLabResult19, i].Value = dt.Rows[i][cNhso1db.cNhso1.labResult19].ToString();
                    dgvAdd[colLabValue19, i].Value = dt.Rows[i][cNhso1db.cNhso1.labValue19].ToString();

                    dgvAdd[colLabName20, i].Value = dt.Rows[i][cNhso1db.cNhso1.labName20].ToString();
                    dgvAdd[colLabResult20, i].Value = dt.Rows[i][cNhso1db.cNhso1.labResult20].ToString();
                    dgvAdd[colLabValue20, i].Value = dt.Rows[i][cNhso1db.cNhso1.labValue20].ToString();

                    dgvAdd[colLabName21, i].Value = dt.Rows[i][cNhso1db.cNhso1.labName21].ToString();
                    dgvAdd[colLabResult21, i].Value = dt.Rows[i][cNhso1db.cNhso1.labResult21].ToString();
                    dgvAdd[colLabValue21, i].Value = dt.Rows[i][cNhso1db.cNhso1.labValue21].ToString();

                    dgvAdd[colLabName22, i].Value = dt.Rows[i][cNhso1db.cNhso1.labName22].ToString();
                    dgvAdd[colLabResult22, i].Value = dt.Rows[i][cNhso1db.cNhso1.labResult22].ToString();
                    dgvAdd[colLabValue22, i].Value = dt.Rows[i][cNhso1db.cNhso1.labValue22].ToString();

                    dgvAdd[colLabName23, i].Value = dt.Rows[i][cNhso1db.cNhso1.labName23].ToString();
                    dgvAdd[colLabResult23, i].Value = dt.Rows[i][cNhso1db.cNhso1.labResult23].ToString();
                    dgvAdd[colLabValue23, i].Value = dt.Rows[i][cNhso1db.cNhso1.labValue23].ToString();

                    dgvAdd[colLabName24, i].Value = dt.Rows[i][cNhso1db.cNhso1.labName24].ToString();
                    dgvAdd[colLabResult24, i].Value = dt.Rows[i][cNhso1db.cNhso1.labResult24].ToString();
                    dgvAdd[colLabValue24, i].Value = dt.Rows[i][cNhso1db.cNhso1.labValue24].ToString();

                    dgvAdd[colLabName25, i].Value = dt.Rows[i][cNhso1db.cNhso1.labName25].ToString();
                    dgvAdd[colLabResult25, i].Value = dt.Rows[i][cNhso1db.cNhso1.labResult25].ToString();
                    dgvAdd[colLabValue25, i].Value = dt.Rows[i][cNhso1db.cNhso1.labValue25].ToString();

                    dgvAdd[colLabName26, i].Value = dt.Rows[i][cNhso1db.cNhso1.labName26].ToString();
                    dgvAdd[colLabResult26, i].Value = dt.Rows[i][cNhso1db.cNhso1.labResult26].ToString();
                    dgvAdd[colLabValue26, i].Value = dt.Rows[i][cNhso1db.cNhso1.labValue26].ToString();

                    dgvAdd[colLabName27, i].Value = dt.Rows[i][cNhso1db.cNhso1.labName27].ToString();
                    dgvAdd[colLabResult27, i].Value = dt.Rows[i][cNhso1db.cNhso1.labResult27].ToString();
                    dgvAdd[colLabValue27, i].Value = dt.Rows[i][cNhso1db.cNhso1.labValue27].ToString();

                    dgvAdd[colLabName28, i].Value = dt.Rows[i][cNhso1db.cNhso1.labName28].ToString();
                    dgvAdd[colLabResult28, i].Value = dt.Rows[i][cNhso1db.cNhso1.labResult28].ToString();
                    dgvAdd[colLabValue28, i].Value = dt.Rows[i][cNhso1db.cNhso1.labValue28].ToString();

                    dgvAdd[colLabName29, i].Value = dt.Rows[i][cNhso1db.cNhso1.labName29].ToString();
                    dgvAdd[colLabResult29, i].Value = dt.Rows[i][cNhso1db.cNhso1.labResult29].ToString();
                    dgvAdd[colLabValue29, i].Value = dt.Rows[i][cNhso1db.cNhso1.labValue29].ToString();

                    dgvAdd[colLabName30, i].Value = dt.Rows[i][cNhso1db.cNhso1.labName30].ToString();
                    dgvAdd[colLabResult30, i].Value = dt.Rows[i][cNhso1db.cNhso1.labResult30].ToString();
                    dgvAdd[colLabValue30, i].Value = dt.Rows[i][cNhso1db.cNhso1.labValue30].ToString();
                    //if ((i % 2) != 0)
                    //{
                    //    dgvAdd.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                    //}
                    pB1.Value = i;
                }
                Debug.WriteLine("btnChk_Click Finish FOR  for (int i = 0; i < dt.Rows.Count; i++)");
                saveCHeckNhso(false);
            }
            pB1.Hide();
        }

        private void FrmCheckNHSOAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cNhso1db.conn.isBranch.Equals("yes"))
            {
                Application.Exit();
            }
        }

    }
}
