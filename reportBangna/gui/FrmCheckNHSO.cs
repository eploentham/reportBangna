//using Microsoft.Office.Interop.Excel;
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
    public partial class FrmCheckNHSO : Form
    {
        Config1 config1 ;
        String edit = "";
        int colCnt =95, colRow=0, colPatientName = 1, colPatientHnno = 2, colDate = 3, colTime = 4;
        int colDiaCD1 = 5, colDiaCD2 = 6, colDiaCD3 = 7, colDiaCD4 = 8, colDiaCD5 = 9;
        int colDiaCD6 = 10, colDiaCD7 = 11, colDiaCD8 = 12, colDiaCD9 = 13, colDiaCD10 = 14;
        
        int colCHRONICCODE1 = 15, colCHRONICCODE2 = 16, colCHRONICCODE3 = 17, colCHRONICCODE4 = 18, colCHRONICCODE5 = 19;
        int colCHRONICCODE6 = 20, colCHRONICCODE7 = 21, colCHRONICCODE8 = 22, colCHRONICCODE9 = 23, colCHRONICCODE10 = 24;
        
        int colExport = 93;
        int colDrug1 = 25, colDrug2 =26, colDrug3 = 27, colDrug4 = 28, colDrug5 = 29;
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

        int colvnSum = 85, colvnSeq = 86, colVn=87, colRowEdit=88, colId=89, colEditDia=90, colEditDrug=91, colBranch=92, colpreno=94;
        //int colExport = 40;
        CheckNhso1DB cNhso1db;
        BangnaControl bc;
        DataTable dtView;
        Boolean pageLoad = false;
        public FrmCheckNHSO()
        {
            InitializeComponent();
            initConfig();
        }
        private void initConfig()
        {
            pageLoad = true;
            dtView = new DataTable();
            config1 = new Config1();
            cNhso1db = new CheckNhso1DB();
            bc = new BangnaControl();
            config1.setCboLab(cboLab);
            config1.setCboBranch(cboBranch);
            
            if (cNhso1db.conn.isBranch.Equals("yes"))
            {
                showCheckNhsoAdd();
            }
            //sip = new SedanInjuryPerson();
            pageLoad = false;
        }
        private void setResize()
        {
            dgvAdd.Width = this.Width - 50;
            dgvAdd.Height = this.Height - 150;
            groupBox1.Width = this.Width - 50;
            pB1.Width = this.Width -900;
        }
        private void setGrid(int cnt)
        {
            dgvAdd.ColumnCount = colCnt;
            dgvAdd.Rows.Clear();
            dgvAdd.RowCount = cnt + 1;
            dgvAdd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdd.Columns[colRow].Width = 50;
            dgvAdd.Columns[colPatientName].Width = 300;
            dgvAdd.Columns[colPatientHnno].Width = 80;
            dgvAdd.Columns[colDate].Width = 85;
            dgvAdd.Columns[colTime].Width = 85;
            dgvAdd.Columns[colDiaCD1].Width = 125;
            dgvAdd.Columns[colCHRONICCODE1].Width = 120;
            dgvAdd.Columns[colExport].Width = 50;

            //dgvAdd.Columns[colAmount].Width = 120;

            dgvAdd.Columns[colRow].HeaderText = "ลำดับ";
            dgvAdd.Columns[colPatientName].HeaderText = "ชื่อ-นามสกุล";
            dgvAdd.Columns[colPatientHnno].HeaderText = "HN";
            dgvAdd.Columns[colDate].HeaderText = "Date";
            dgvAdd.Columns[colTime].HeaderText = "TIME";
            dgvAdd.Columns[colDiaCD1].HeaderText = "DIA1";
            dgvAdd.Columns[colDiaCD2].HeaderText = "DIA2";
            dgvAdd.Columns[colDiaCD3].HeaderText = "DIA3";
            dgvAdd.Columns[colDiaCD4].HeaderText = "DIA4";
            dgvAdd.Columns[colDiaCD5].HeaderText = "DIA5";
            dgvAdd.Columns[colDiaCD6].HeaderText = "DIA6";
            dgvAdd.Columns[colDiaCD7].HeaderText = "DIA7";
            dgvAdd.Columns[colDiaCD8].HeaderText = "DIA8";
            dgvAdd.Columns[colDiaCD9].HeaderText = "DIA9";
            dgvAdd.Columns[colDiaCD10].HeaderText = "DIA10";

            dgvAdd.Columns[colCHRONICCODE1].HeaderText = "Chornic1";
            dgvAdd.Columns[colCHRONICCODE2].HeaderText = "Chronic2";
            dgvAdd.Columns[colCHRONICCODE3].HeaderText = "Chronic3";
            dgvAdd.Columns[colCHRONICCODE4].HeaderText = "Chronic4";
            dgvAdd.Columns[colCHRONICCODE5].HeaderText = "Chronic5";
            dgvAdd.Columns[colCHRONICCODE6].HeaderText = "Chronic6";
            dgvAdd.Columns[colCHRONICCODE7].HeaderText = "Chronic7";
            dgvAdd.Columns[colCHRONICCODE8].HeaderText = "Chronic8";
            dgvAdd.Columns[colCHRONICCODE9].HeaderText = "Chronic9";
            dgvAdd.Columns[colCHRONICCODE10].HeaderText = "Chronic10";
            dgvAdd.Columns[colDrug1].HeaderText = "drug1";
            dgvAdd.Columns[colDrug2].HeaderText = "drug2";
            dgvAdd.Columns[colDrug3].HeaderText = "drug3";
            dgvAdd.Columns[colDrug4].HeaderText = "drug4";
            dgvAdd.Columns[colDrug5].HeaderText = "drug5";
            dgvAdd.Columns[colDrug6].HeaderText = "drug6";
            dgvAdd.Columns[colDrug7].HeaderText = "drug7";
            dgvAdd.Columns[colDrug8].HeaderText = "drug8";
            dgvAdd.Columns[colDrug9].HeaderText = "drug9";
            dgvAdd.Columns[colDrug10].HeaderText = "drug10";
            dgvAdd.Columns[colDrug11].HeaderText = "drug11";
            dgvAdd.Columns[colDrug12].HeaderText = "drug12";
            dgvAdd.Columns[colDrug13].HeaderText = "drug13";
            dgvAdd.Columns[colDrug14].HeaderText = "drug14";
            dgvAdd.Columns[colDrug15].HeaderText = "drug15";
            dgvAdd.Columns[colDrug16].HeaderText = "drug16";
            dgvAdd.Columns[colDrug17].HeaderText = "drug17";
            dgvAdd.Columns[colDrug18].HeaderText = "drug18";
            dgvAdd.Columns[colDrug19].HeaderText = "drug19";
            dgvAdd.Columns[colDrug20].HeaderText = "drug20";
            dgvAdd.Columns[colDrug21].HeaderText = "drug21";
            dgvAdd.Columns[colDrug22].HeaderText = "drug22";
            dgvAdd.Columns[colDrug23].HeaderText = "drug23";
            dgvAdd.Columns[colDrug24].HeaderText = "drug24";
            dgvAdd.Columns[colDrug25].HeaderText = "drug25";
            dgvAdd.Columns[colDrug26].HeaderText = "drug26";
            dgvAdd.Columns[colDrug27].HeaderText = "drug27";
            dgvAdd.Columns[colDrug28].HeaderText = "drug28";
            dgvAdd.Columns[colDrug29].HeaderText = "drug29";
            dgvAdd.Columns[colDrug30].HeaderText = "drug30";

            dgvAdd.Columns[colLabName1].HeaderText = "labname1";
            dgvAdd.Columns[colLabResult1].HeaderText = "labresult1";
            dgvAdd.Columns[colLabValue1].HeaderText = "labvalue1";

            dgvAdd.Columns[colLabName2].HeaderText = "labname2";
            dgvAdd.Columns[colLabResult2].HeaderText = "labresult2";
            dgvAdd.Columns[colLabValue2].HeaderText = "labvalue2";

            dgvAdd.Columns[colLabName3].HeaderText = "labname3";
            dgvAdd.Columns[colLabResult3].HeaderText = "labresult3";
            dgvAdd.Columns[colLabValue3].HeaderText = "labvalue3";

            dgvAdd.Columns[colLabName4].HeaderText = "labname4";
            dgvAdd.Columns[colLabResult4].HeaderText = "labresult4";
            dgvAdd.Columns[colLabValue4].HeaderText = "labvalue4";

            dgvAdd.Columns[colLabName5].HeaderText = "labname5";
            dgvAdd.Columns[colLabResult5].HeaderText = "labresult5";
            dgvAdd.Columns[colLabValue5].HeaderText = "labvalue5";

            dgvAdd.Columns[colLabName6].HeaderText = "labname6";
            dgvAdd.Columns[colLabResult6].HeaderText = "labresult6";
            dgvAdd.Columns[colLabValue6].HeaderText = "labvalue6";

            dgvAdd.Columns[colLabName7].HeaderText = "labname7";
            dgvAdd.Columns[colLabResult7].HeaderText = "labresult7";
            dgvAdd.Columns[colLabValue7].HeaderText = "labvalue7";

            dgvAdd.Columns[colLabName8].HeaderText = "labname8";
            dgvAdd.Columns[colLabResult8].HeaderText = "labresult8";
            dgvAdd.Columns[colLabValue8].HeaderText = "labvalue8";

            dgvAdd.Columns[colLabName9].HeaderText = "labname9";
            dgvAdd.Columns[colLabResult9].HeaderText = "labresult9";
            dgvAdd.Columns[colLabValue9].HeaderText = "labvalue9";

            dgvAdd.Columns[colLabName10].HeaderText = "labname10";
            dgvAdd.Columns[colLabResult10].HeaderText = "labresult10";
            dgvAdd.Columns[colLabValue10].HeaderText = "labvalue10";
            dgvAdd.Columns[colEditDia].HeaderText = "editdia";
            dgvAdd.Columns[colEditDrug].HeaderText = "editdrug";
            dgvAdd.Columns[colBranch].HeaderText = "branch";

            dgvAdd.Columns[colExport].HeaderText = " ";
            if (nudChronic.Value <= 5)
            {
                dgvAdd.Columns[colCHRONICCODE6].Visible = false;
                dgvAdd.Columns[colCHRONICCODE7].Visible = false;
                dgvAdd.Columns[colCHRONICCODE8].Visible = false;
                dgvAdd.Columns[colCHRONICCODE9].Visible = false;
                dgvAdd.Columns[colCHRONICCODE10].Visible = false;
            }
            else
            {
                dgvAdd.Columns[colCHRONICCODE6].Visible = true;
                dgvAdd.Columns[colCHRONICCODE7].Visible = true;
                dgvAdd.Columns[colCHRONICCODE8].Visible = true;
                dgvAdd.Columns[colCHRONICCODE9].Visible = true;
                dgvAdd.Columns[colCHRONICCODE10].Visible = true;
            }
            if (nudDrug.Value <= 10)
            {
                dgvAdd.Columns[colDrug11].Visible = false;
                dgvAdd.Columns[colDrug12].Visible = false;
                dgvAdd.Columns[colDrug13].Visible = false;
                dgvAdd.Columns[colDrug14].Visible = false;
                dgvAdd.Columns[colDrug15].Visible = false;
                dgvAdd.Columns[colDrug16].Visible = false;
                dgvAdd.Columns[colDrug17].Visible = false;
                dgvAdd.Columns[colDrug18].Visible = false;
                dgvAdd.Columns[colDrug19].Visible = false;
                dgvAdd.Columns[colDrug20].Visible = false;
                dgvAdd.Columns[colDrug21].Visible = false;
                dgvAdd.Columns[colDrug22].Visible = false;
                dgvAdd.Columns[colDrug23].Visible = false;
                dgvAdd.Columns[colDrug24].Visible = false;
                dgvAdd.Columns[colDrug25].Visible = false;
                dgvAdd.Columns[colDrug26].Visible = false;
                dgvAdd.Columns[colDrug27].Visible = false;
                dgvAdd.Columns[colDrug28].Visible = false;
                dgvAdd.Columns[colDrug29].Visible = false;
                dgvAdd.Columns[colDrug30].Visible = false;
            }
            else
            {
                dgvAdd.Columns[colDrug11].Visible = true;
                dgvAdd.Columns[colDrug12].Visible = true;
                dgvAdd.Columns[colDrug13].Visible = true;
                dgvAdd.Columns[colDrug14].Visible = true;
                dgvAdd.Columns[colDrug15].Visible = true;
                dgvAdd.Columns[colDrug16].Visible = true;
                dgvAdd.Columns[colDrug17].Visible = true;
                dgvAdd.Columns[colDrug18].Visible = true;
                dgvAdd.Columns[colDrug19].Visible = true;
                dgvAdd.Columns[colDrug20].Visible = true;
                dgvAdd.Columns[colDrug21].Visible = true;
                dgvAdd.Columns[colDrug22].Visible = true;
                dgvAdd.Columns[colDrug23].Visible = true;
                dgvAdd.Columns[colDrug24].Visible = true;
                dgvAdd.Columns[colDrug25].Visible = true;
                dgvAdd.Columns[colDrug26].Visible = true;
                dgvAdd.Columns[colDrug27].Visible = true;
                dgvAdd.Columns[colDrug28].Visible = true;
                dgvAdd.Columns[colDrug29].Visible = true;
                dgvAdd.Columns[colDrug30].Visible = true;
            }
            //dgvAdd.Columns[colAmount].HeaderText = "จำนวนเงิน";
            Font font = new Font("Microsoft Sans Serif", 10);
            dgvAdd.Columns[colvnSeq].Visible = false;
            dgvAdd.Columns[colvnSum].Visible = false;
            dgvAdd.Columns[colVn].Visible = false;
            dgvAdd.Columns[colId].Visible = false;
            dgvAdd.Columns[colpreno].Visible = false;
            dgvAdd.Columns[colRow].ReadOnly = true;

            dgvAdd.Font = font;
        }
        public void setData1(String dateStart, String dateEnd, String chkDrug, Boolean StatusLabError, Boolean StatusDoctorEdit, String branchId)
        {
            String visitDate = "", dateStart1="", dateEnd1="";
            String[] edit, drug1;
            pB1.Show();
            DataTable dt = new DataTable();
            dateStart1 = (int.Parse(dateStart.Substring(0, 4))+543) + dateStart.Substring(4);
            dateEnd1 = (int.Parse(dateEnd.Substring(0, 4)) + 543) + dateEnd.Substring(4);
            drug1 = txtSearch.Text.Split(',');
            dt = cNhso1db.selectByDate(dateStart1, dateEnd1, chkDrug, "*****", txtLabSearch1.Text, txtLabSearch2.Text, cboLab.Text, StatusLabError, StatusDoctorEdit, branchId);
            if (drug1.Length == 1)
            {
                dt = cNhso1db.selectByDate(dateStart1, dateEnd1, chkDrug, txtSearch.Text, txtLabSearch1.Text.Trim(), txtLabSearch2.Text.Trim(), cboLab.Text.Trim(), StatusLabError, StatusDoctorEdit, branchId);
            }
            else
            {
                DataTable dt1 = new DataTable();
                foreach (String aa in drug1)
                {
                    dt1 = cNhso1db.selectByDate(dateStart1, dateEnd1, chkDrug, aa.Trim(), txtLabSearch1.Text.Trim(), txtLabSearch2.Text, cboLab.Text.Trim(), StatusLabError, StatusDoctorEdit, branchId);
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        DataRow r = dt.NewRow();
                        r = cNhso1db.setDataRow(dt1, r, i);
                        dt.Rows.Add(r);
                    }
                }
                dt.AcceptChanges();
                String col = cNhso1db.cNhso1.drug1;
                String col1 = "";
                col = col.Substring(0,col.Length - 1);
                foreach (String aa in drug1)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        //String drugname = dr[cNhso1db.cNhso1.drug1].ToString();
                        Boolean del = false;
                        for (int i = 1; i <= 30; i++)
                        {
                            col1 = col + i;
                            if (aa.IndexOf(dr[col1].ToString()) == -1)
                            {
                                del = true;
                            }
                            else
                            {
                                del = false;
                                break;
                            }
                        }
                        if (del)
                        {
                            dr.Delete();
                        }
                    }
                    dt.AcceptChanges();
                }
                
            }
            
            pB1.Minimum = 0;
            pB1.Maximum = dt.Rows.Count;
            setGrid(dt.Rows.Count);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][cNhso1db.cNhso1.editDia] != null)
                    {
                        edit = dt.Rows[i][cNhso1db.cNhso1.editDia].ToString().Split(new char[] { ',' });
                        if (edit.Length > 0)
                        {
                            for(int j=0;j<edit.Length;j++)
                            {
                                if (!edit[j].Equals(""))
                                {
                                    //if (!dt.Rows[i][cNhso1db.cNhso1.dia1].ToString().Equals(dt.Rows[i][cNhso1db.cNhso1.dia1Ori].ToString()))
                                    //{
                                    dgvAdd.Rows[i].Cells[int.Parse(edit[j])].Style.BackColor = Color.Red;
                                    var cell1 = dgvAdd.Rows[i].Cells[int.Parse(edit[j])];
                                    if (int.Parse(edit[j]) == colDiaCD1)
                                    {
                                        cell1.ToolTipText = dt.Rows[i][cNhso1db.cNhso1.dia1Ori].ToString() + "\r\n";
                                    }
                                    else if (int.Parse(edit[j]) == colDiaCD2)
                                    {
                                        cell1.ToolTipText = dt.Rows[i][cNhso1db.cNhso1.dia2Ori].ToString() + "\r\n";
                                    }
                                    else if (int.Parse(edit[j]) == colDiaCD3)
                                    {
                                        cell1.ToolTipText = dt.Rows[i][cNhso1db.cNhso1.dia3Or1].ToString() + "\r\n";
                                    }
                                    else if (int.Parse(edit[j]) == colDiaCD4)
                                    {
                                        cell1.ToolTipText = dt.Rows[i][cNhso1db.cNhso1.dia4Ori].ToString() + "\r\n";
                                    }
                                    else if (int.Parse(edit[j]) == colDiaCD5)
                                    {
                                        cell1.ToolTipText = dt.Rows[i][cNhso1db.cNhso1.dia5Ori].ToString() + "\r\n";
                                    }
                                    //}
                                }
                            }
                        }
                    }
                    var cell = dgvAdd.Rows[i].Cells[colPatientHnno];
                    cell.ToolTipText = dt.Rows[i][cNhso1db.cNhso1.patientName].ToString() + "\r\n";
                    dgvAdd[colRow, i].Value = (i + 1);
                    //dgvAdd[colvnSeq, i].Value = dt.Rows[i][cNhso1db.cNhso1.v].ToString();
                    dgvAdd[colId, i].Value = dt.Rows[i][cNhso1db.cNhso1.checknhsoId].ToString();
                    dgvAdd[colVn, i].Value = dt.Rows[i][cNhso1db.cNhso1.vn].ToString();
                    dgvAdd[colPatientName, i].Value = dt.Rows[i][cNhso1db.cNhso1.patientName].ToString();
                    dgvAdd[colPatientHnno, i].Value = dt.Rows[i][cNhso1db.cNhso1.hn].ToString();
                    visitDate = dt.Rows[i][cNhso1db.cNhso1.visitDate].ToString();
                    dgvAdd[colDate, i].Value = config1.dateDBtoShow25(visitDate);
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
                    dgvAdd[colBranch, i].Value = config1.stringNull1(dt.Rows[i][cNhso1db.cNhso1.branchID]);
                    dgvAdd[colpreno, i].Value = config1.stringNull1(dt.Rows[i][cNhso1db.cNhso1.preno]);
                    dgvAdd[colvnSeq, i].Value = config1.stringNull1(dt.Rows[i][cNhso1db.cNhso1.vnseq]);
                    dgvAdd[colvnSum, i].Value = config1.stringNull1(dt.Rows[i][cNhso1db.cNhso1.vnsum]);
                    if ((i % 2) != 0)
                    {
                        //dgvAdd.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                        if (branchId.Equals("001"))
                        {
                            dgvAdd.Rows[i].DefaultCellStyle.BackColor = Color.Cornsilk;
                        }
                        else if (branchId.Equals("002"))
                        {
                            dgvAdd.Rows[i].DefaultCellStyle.BackColor = Color.DarkKhaki;
                        }
                        else if (branchId.Equals("005"))
                        {
                            dgvAdd.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                        }
                    }
                    pB1.Value = i;
                }
            }
            else
            {
                //setData(dateStart, dateEnd, chkDrug);
            }
            pB1.Hide();
        }
        public void setData(String dateStart,String dateEnd, String chkDrug)
        {
            //String pharName="", labName="", labResult="", labValue="", visitDate="", visitTime="";
            //String[] edit;
            //DateTime dt1 = new DateTime();
            //pB1.Show();
            //DataTable dt = new DataTable();
            //DataTable dtDia = new DataTable();
            //DataTable dtChr = new DataTable();
            //DataTable dtDrug = new DataTable();
            //DataTable dtLab = new DataTable();
            
            //dt = cNhso1db.selectPatientByDate(dateStart, dateEnd, chkDrug,txtSearch.Text, txtLabSearch1.Text, txtLabSearch2.Text, cboLab.SelectedValue.ToString());
            //pB1.Minimum = 0;
            //pB1.Maximum = dt.Rows.Count;
            //setGrid(dt.Rows.Count);
            
            //if (dt.Rows.Count > 0)
            //{
            //    for (int i = 0; i < dt.Rows.Count; i++)
            //    {
            //        dgvAdd[colRow, i].Value = (i + 1);
            //        dgvAdd[colvnSeq, i].Value = dt.Rows[i]["mnc_vn_seq"].ToString();
            //        dgvAdd[colvnSum, i].Value = dt.Rows[i]["mnc_vn_sum"].ToString();
            //        dgvAdd[colVn, i].Value = dt.Rows[i]["mnc_vn_no"].ToString();
            //        dgvAdd[colPatientName, i].Value = dt.Rows[i]["mnc_pfix_dsc"].ToString() + " " + dt.Rows[i]["mnc_fname_t"].ToString() + " " + dt.Rows[i]["mnc_lname_t"].ToString();

            //        dgvAdd[colPatientHnno, i].Value = dt.Rows[i]["MNC_HN_NO"].ToString();
            //        //visitDate = string.Format( dt.Rows[i]["MNC_DATE"].ToString(),"dd-mm-yyyy");
                    
            //        if (dt.Rows[i]["MNC_DATE"] != null)
            //        {
            //            dt1 = DateTime.Parse(dt.Rows[i]["MNC_DATE"].ToString());
            //            visitDate = dt1.ToString("dd-MM-yyyy");                       
            //            dgvAdd[colDate, i].Value = visitDate;
            //            visitTime = "0000"+dt.Rows[i]["MNC_TIME"].ToString();
            //            visitTime = visitTime.Substring(visitTime.Length - 4);
            //            dgvAdd[colTime, i].Value = visitTime.Substring(0, 2) + ":" + visitTime.Substring(2);
            //        }
            //        else
            //        {
            //            dgvAdd[colDate, i].Value = "";
            //        }
                    
            //        //dgvAdd[colTime, i].Value = dt.Rows[i]["MNC_TIME"].ToString();

            //        dtDia = cNhso1db.selectDiaCDbyVN(dateStart, dateEnd, dt.Rows[i]["MNC_HN_NO"].ToString(), dt.Rows[i]["MNC_VN_NO"].ToString());
            //        for (int j = 0; j < dtDia.Rows.Count; j++)
            //        {
            //            if (j == 0)
            //            {
            //                dgvAdd[colDiaCD1, i].Value = dtDia.Rows[j]["MNC_DIA_CD"].ToString();
            //            }
            //            else if (j == 1)
            //            {
            //                dgvAdd[colDiaCD2, i].Value = dtDia.Rows[j]["MNC_DIA_CD"].ToString();
            //            }
            //            else if (j == 2)
            //            {
            //                dgvAdd[colDiaCD3, i].Value = dtDia.Rows[j]["MNC_DIA_CD"].ToString();
            //            }
            //            else if (j == 3)
            //            {
            //                dgvAdd[colDiaCD4, i].Value = dtDia.Rows[j]["MNC_DIA_CD"].ToString();
            //            }
            //            else if (j == 4)
            //            {
            //                dgvAdd[colDiaCD5, i].Value = dtDia.Rows[j]["MNC_DIA_CD"].ToString();
            //            }
            //            else if (j == 5)
            //            {
            //                //dgvAdd[colDiaCD1, i].Value = dt.Rows[i]["MNC_DIA_CD"].ToString();
            //            }
            //        }
            //        dtChr = cNhso1db.selectChronicbyVN(dateStart, dateEnd, dt.Rows[i]["MNC_HN_NO"].ToString(), dt.Rows[i]["MNC_VN_NO"].ToString());
            //        for (int k = 0; k < dtChr.Rows.Count; k++)
            //        {
            //            if (nudChronic.Value <= k)
            //            {
            //                continue;
            //            }
            //            if (k == 0)
            //            {
            //                dgvAdd[colCHRONICCODE1, i].Value = dtChr.Rows[k]["chroniccode"].ToString();
            //            }
            //            else if (k == 1)
            //            {
            //                dgvAdd[colCHRONICCODE2, i].Value = dtChr.Rows[k]["chroniccode"].ToString();
            //            }
            //            else if (k == 2)
            //            {
            //                dgvAdd[colCHRONICCODE3, i].Value = dtChr.Rows[k]["chroniccode"].ToString();
            //            }
            //            else if (k == 3)
            //            {
            //                dgvAdd[colCHRONICCODE4, i].Value = dtChr.Rows[k]["chroniccode"].ToString();
            //            }
            //            else if (k == 4)
            //            {
            //                dgvAdd[colCHRONICCODE5, i].Value = dtChr.Rows[k]["chroniccode"].ToString();
            //            }
            //            else if (k == 5)
            //            {
            //                dgvAdd[colCHRONICCODE6, i].Value = dtChr.Rows[k]["chroniccode"].ToString();
            //            }
            //            else if (k == 6)
            //            {
            //                dgvAdd[colCHRONICCODE7, i].Value = dtChr.Rows[k]["chroniccode"].ToString();
            //            }
            //            else if (k == 7)
            //            {
            //                dgvAdd[colCHRONICCODE8, i].Value = dtChr.Rows[k]["chroniccode"].ToString();
            //            }
            //            else if (k == 8)
            //            {
            //                dgvAdd[colCHRONICCODE9, i].Value = dtChr.Rows[k]["chroniccode"].ToString();
            //            }
            //            else if (k == 9)
            //            {
            //                dgvAdd[colCHRONICCODE10, i].Value = dtChr.Rows[k]["chroniccode"].ToString();
            //            }
            //            else if (k == 10)
            //            {
            //                //dgvAdd[colCHRONICCODE5, i].Value = dtChr.Rows[k]["chroniccode"].ToString();
            //            }
            //        }
            //        dtDrug = cNhso1db.selectDrugbyVN(dateStart, dateEnd, dt.Rows[i]["MNC_HN_NO"].ToString(), dt.Rows[i]["MNC_VN_NO"].ToString());
            //        for (int l = 0; l < dtDrug.Rows.Count; l++)
            //        {
            //            if (nudDrug.Value <= l)
            //            {
            //                continue;
            //            }
            //            pharName = dtDrug.Rows[l]["MNC_PH_TN"].ToString();
            //            if (l == 0)
            //            {
            //                dgvAdd[colDrug1, i].Value = pharName;
            //            }
            //            else if (l == 1)
            //            {
            //                dgvAdd[colDrug2, i].Value = pharName;
            //            }
            //            else if (l == 2)
            //            {
            //                dgvAdd[colDrug3, i].Value = pharName;
            //            }
            //            else if (l == 3)
            //            {
            //                dgvAdd[colDrug4, i].Value = pharName;
            //            }
            //            else if (l == 4)
            //            {
            //                dgvAdd[colDrug5, i].Value = pharName;
            //            }
            //            else if (l == 5)
            //            {
            //                dgvAdd[colDrug6, i].Value = pharName;
            //            }
            //            else if (l == 6)
            //            {
            //                dgvAdd[colDrug7, i].Value = pharName;
            //            }
            //            else if (l == 7)
            //            {
            //                dgvAdd[colDrug8, i].Value = pharName;
            //            }
            //            else if (l == 8)
            //            {
            //                dgvAdd[colDrug9, i].Value = pharName;
            //            }
            //            else if (l == 9)
            //            {
            //                dgvAdd[colDrug10, i].Value = pharName;
            //            }
            //            else if (l == 10)
            //            {
            //                dgvAdd[colDrug11, i].Value = pharName;
            //            }
            //            else if (l == 11)
            //            {
            //                dgvAdd[colDrug12, i].Value = pharName;
            //            }
            //            else if (l == 12)
            //            {
            //                dgvAdd[colDrug13, i].Value = pharName;
            //            }
            //            else if (l == 13)
            //            {
            //                dgvAdd[colDrug14, i].Value = pharName;
            //            }
            //            else if (l == 14)
            //            {
            //                dgvAdd[colDrug15, i].Value = pharName;
            //            }
            //            else if (l == 15)
            //            {
            //                dgvAdd[colDrug16, i].Value = pharName;
            //            }
            //            else if (l == 16)
            //            {
            //                dgvAdd[colDrug17, i].Value = pharName;
            //            }
            //            else if (l == 17)
            //            {
            //                dgvAdd[colDrug18, i].Value = pharName;
            //            }
            //            else if (l == 18)
            //            {
            //                dgvAdd[colDrug19, i].Value = pharName;
            //            }
            //            else if (l == 19)
            //            {
            //                dgvAdd[colDrug20, i].Value = pharName;
            //            }
            //            else if (l == 20)
            //            {
            //                //dgvAdd[colDrug1, i].Value = pharName;
            //            }
            //        }
            //        dtLab = cNhso1db.selectLabbyVN(dateStart, dateEnd, dt.Rows[i]["MNC_HN_NO"].ToString(), dt.Rows[i]["MNC_VN_NO"].ToString());
            //        for (int m = 0; m < dtLab.Rows.Count; m++)
            //        {
            //            labName = dtLab.Rows[m]["MNC_LB_DSC"].ToString();
            //            labResult = dtLab.Rows[m]["MNC_STS"].ToString();
            //            labValue = dtLab.Rows[m]["MNC_RES_VALUE"].ToString();
            //            if (m == 0)
            //            {
            //                dgvAdd[colLabName1, i].Value = labName;
            //                dgvAdd[colLabResult1, i].Value = labResult;
            //                dgvAdd[colLabValue1, i].Value = labValue;
            //            }
            //            else if (m == 1)
            //            {
            //                dgvAdd[colLabName2, i].Value = labName;
            //                dgvAdd[colLabResult2, i].Value = labResult;
            //                dgvAdd[colLabValue2, i].Value = labValue;
            //            }
            //            else if (m == 2)
            //            {
            //                dgvAdd[colLabName3, i].Value = labName;
            //                dgvAdd[colLabResult3, i].Value = labResult;
            //                dgvAdd[colLabValue3, i].Value = labValue;
            //            }
            //            else if (m == 3)
            //            {
            //                dgvAdd[colLabName4, i].Value = labName;
            //                dgvAdd[colLabResult4, i].Value = labResult;
            //                dgvAdd[colLabValue4, i].Value = labValue;
            //            }
            //            else if (m == 4)
            //            {
            //                dgvAdd[colLabName5, i].Value = labName;
            //                dgvAdd[colLabResult5, i].Value = labResult;
            //                dgvAdd[colLabValue5, i].Value = labValue;
            //            }
            //            else if (m == 5)
            //            {
            //                dgvAdd[colLabName6, i].Value = labName;
            //                dgvAdd[colLabResult6, i].Value = labResult;
            //                dgvAdd[colLabValue6, i].Value = labValue;
            //            }
            //            else if (m == 6)
            //            {
            //                dgvAdd[colLabName7, i].Value = labName;
            //                dgvAdd[colLabResult7, i].Value = labResult;
            //                dgvAdd[colLabValue7, i].Value = labValue;
            //            }
            //            else if (m == 7)
            //            {
            //                dgvAdd[colLabName8, i].Value = labName;
            //                dgvAdd[colLabResult8, i].Value = labResult;
            //                dgvAdd[colLabValue8, i].Value = labValue;
            //            }
            //            else if (m == 8)
            //            {
            //                dgvAdd[colLabName9, i].Value = labName;
            //                dgvAdd[colLabResult9, i].Value = labResult;
            //                dgvAdd[colLabValue9, i].Value = labValue;
            //            }
            //            else if (m == 9)
            //            {
            //                dgvAdd[colLabName10, i].Value = labName;
            //                dgvAdd[colLabResult10, i].Value = labResult;
            //                dgvAdd[colLabValue10, i].Value = labValue;
            //            }
            //        }

            //        //dgvAdd[colDiaCD1, i].Value = dt.Rows[i]["MNC_DIA_CD"].ToString();
            //        //dgvAdd[colCHRONICCODE1, i].Value = dt.Rows[i]["CHRONICCODE"].ToString();
            //        //dgvAdd[colExport, i].Value = "ยกเลิก";
            //        if ((i % 2) != 0)
            //        {
            //            dgvAdd.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
            //        }
            //        pB1.Value = i;
            //    }
            //}
            //pB1.Hide();
            //btnExport.Enabled = true;
        }

        private void FrmCheckNHSO_Load(object sender, EventArgs e)
        {
            pB1.Hide();
            btnExport.Enabled = false;
            setResize();
            this.Text = "Last Update " + System.IO.File.GetLastWriteTime(System.Environment.CurrentDirectory + "\\" + Process.GetCurrentProcess().ProcessName + ".exe");
            this.Text +=" hostNameMainHIS="+cNhso1db.conn.hostNameMainHIS5+" databaseMainHIS="+cNhso1db.conn.databaseNameMainHIS5;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            pB1.Show();
            pB1.Minimum = 0;
            pB1.Maximum = dgvAdd.RowCount;
            String id = "", hn = "", vn = "", date="", preno="";

            for (int i = 0; i < dgvAdd.RowCount; i++)
            {
                id = dgvAdd[colId, i].Value.ToString();
                hn = dgvAdd[colPatientHnno, i].Value.ToString();
                vn = dgvAdd[colVn, i].Value.ToString();
                date = config1.dateShowtoDB(dgvAdd[colDate, i].Value.ToString());
                date = (int.Parse(date.Substring(0, 4)) - 543) + date.Substring(4);
                preno = dgvAdd[colpreno, i].Value.ToString();
                if (hn.Equals("5068244"))
                {
                    preno = "";
                }
                DataTable dt = cNhso1db.selectLabbyVN(date, date, hn, vn, preno);
                if (dt.Rows.Count > 0)
                {
                    for(int j = 0; j < dt.Rows.Count; j++)
                    {

                    }
                }
                pB1.Value = i;
            }
            pB1.Hide();
        }
        private void FrmCheckNHSO_Resize(object sender, EventArgs e)
        {
            setResize();
        }
        private void cboBranch_Click(object sender, EventArgs e)
        {
            //bc.getCboFnType(cboBranch, bc.getValueCboItem(cboBranch));
            //bc.getCboFnType(cboBranch, cboBranch.SelectedValue.ToString());
        }
        private void cboBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!pageLoad)
            {
                bc.getCboFnType(cboFnType, cboBranch.SelectedValue.ToString());
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (chkDrug.Checked)
            {
                setData1(dtpStart.Value.Year.ToString() + "-" + dtpStart.Value.ToString("MM-dd"),
                dtpEnd.Value.Year.ToString() + "-" + dtpEnd.Value.ToString("MM-dd"), "1", chkLabError.Checked, chkDoctorEdit.Checked, cboBranch.SelectedValue.ToString());
            }
            else
            {
                setData1(dtpStart.Value.Year.ToString() + "-" + dtpStart.Value.ToString("MM-dd"),
                dtpEnd.Value.Year.ToString() + "-" + dtpEnd.Value.ToString("MM-dd"), "", chkLabError.Checked, chkDoctorEdit.Checked, cboBranch.SelectedValue.ToString());
            }
            btnExport.Enabled = true;
            //dtView = 
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            pB1.Show();
            Microsoft.Office.Interop.Excel.Application excelapp = new Microsoft.Office.Interop.Excel.Application();
            excelapp.Visible = false;
            String visitDate = "", visitTime="", err="", err1="", pharName="";

            Microsoft.Office.Interop.Excel._Workbook workbook = (Microsoft.Office.Interop.Excel._Workbook)(excelapp.Workbooks.Add(Type.Missing));
            Microsoft.Office.Interop.Excel._Worksheet worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.ActiveSheet;
            pB1.Minimum = 0;
            pB1.Maximum = dgvAdd.Rows.Count;
            //worksheet.Cells[0, 0] = "patient name";
            for (int i = 1; i < dgvAdd.Rows.Count; i++)
            {
                try
                {
                    worksheet.Cells[i, colPatientHnno] = dgvAdd[colPatientHnno, i].Value.ToString();
                    worksheet.Cells[i, colPatientName] = dgvAdd[colPatientName, i].Value.ToString();
                    err = "001 " + dgvAdd[colPatientHnno, i].Value.ToString();
                    //worksheet.Cells[i, colDate] = dgvAdd[colDate, i].Value.ToString();
                    //worksheet.Cells[i, colTime] = dgvAdd[colTime, i].Value.ToString();
                    worksheet.Cells[i, colDiaCD1] = config1.stringNull(dgvAdd[colDiaCD1, i].Value.ToString());
                    if (dgvAdd[colDate, i].Value == null)
                    {
                        worksheet.Cells[i, colDate].Value = "";
                    }
                    else
                    {
                        visitDate = dgvAdd[colDate, i].Value.ToString();
                        worksheet.Cells[i, colDate] = visitDate;
                        visitTime = dgvAdd[colTime, i].Value.ToString();
                        worksheet.Cells[i, colTime] = visitTime;
                    }
                    err = "002 Dia";
                    if (dgvAdd[colDiaCD2, i].Value == null)
                    {
                        worksheet.Cells[i, colDiaCD2] = "";
                    }
                    else
                    {
                        worksheet.Cells[i, colDiaCD2] = config1.stringNull1(dgvAdd[colDiaCD2, i].Value.ToString());
                    }
                    err = "003 Chronic ";
                    worksheet.Cells[i, colDiaCD3] = config1.stringNull1(dgvAdd[colDiaCD3, i].Value);
                    worksheet.Cells[i, colDiaCD4] = config1.stringNull1(dgvAdd[colDiaCD4, i].Value);
                    worksheet.Cells[i, colDiaCD5] = config1.stringNull1(dgvAdd[colDiaCD5, i].Value);

                    worksheet.Cells[i, colCHRONICCODE1] = config1.stringNull1(dgvAdd[colCHRONICCODE1, i].Value);
                    worksheet.Cells[i, colCHRONICCODE2] = config1.stringNull1(dgvAdd[colCHRONICCODE2, i].Value);
                    worksheet.Cells[i, colCHRONICCODE3] = config1.stringNull1(dgvAdd[colCHRONICCODE3, i].Value);
                    worksheet.Cells[i, colCHRONICCODE4] = config1.stringNull1(dgvAdd[colCHRONICCODE4, i].Value);
                    worksheet.Cells[i, colCHRONICCODE5] = config1.stringNull1(dgvAdd[colCHRONICCODE5, i].Value);
                    if (nudChronic.Value <= 5)
                    {
                        continue;
                    }

                    worksheet.Cells[i, colCHRONICCODE6] = config1.stringNull1(dgvAdd[colCHRONICCODE6, i].Value);
                    worksheet.Cells[i, colCHRONICCODE7] = config1.stringNull1(dgvAdd[colCHRONICCODE7, i].Value);
                    worksheet.Cells[i, colCHRONICCODE8] = config1.stringNull1(dgvAdd[colCHRONICCODE8, i].Value);
                    worksheet.Cells[i, colCHRONICCODE9] = config1.stringNull1(dgvAdd[colCHRONICCODE9, i].Value);
                    worksheet.Cells[i, colCHRONICCODE10] = config1.stringNull1(dgvAdd[colCHRONICCODE10, i].Value);
                    err = "004 Drug ";

                    worksheet.Cells[i, colDrug1] = config1.stringNull1(dgvAdd[colDrug1, i].Value);
                    worksheet.Cells[i, colDrug2] = config1.stringNull1(dgvAdd[colDrug2, i].Value);
                    worksheet.Cells[i, colDrug3] = config1.stringNull1(dgvAdd[colDrug3, i].Value);
                    worksheet.Cells[i, colDrug4] = config1.stringNull1(dgvAdd[colDrug4, i].Value);
                    worksheet.Cells[i, colDrug5] = config1.stringNull1(dgvAdd[colDrug5, i].Value);

                    worksheet.Cells[i, colDrug6] = config1.stringNull1(dgvAdd[colDrug6, i].Value);
                    worksheet.Cells[i, colDrug7] = config1.stringNull1(dgvAdd[colDrug7, i].Value);
                    worksheet.Cells[i, colDrug8] = config1.stringNull1(dgvAdd[colDrug8, i].Value);
                    worksheet.Cells[i, colDrug9] = config1.stringNull1(dgvAdd[colDrug9, i].Value);
                    worksheet.Cells[i, colDrug10] = config1.stringNull1(dgvAdd[colDrug10, i].Value);
                    if (nudDrug.Value <= 10)
                    {
                        continue;
                    }

                    worksheet.Cells[i, colDrug11] = config1.stringNull1(dgvAdd[colDrug11, i].Value);
                    worksheet.Cells[i, colDrug12] = config1.stringNull1(dgvAdd[colDrug12, i].Value);
                    worksheet.Cells[i, colDrug13] = config1.stringNull1(dgvAdd[colDrug13, i].Value);
                    worksheet.Cells[i, colDrug14] = config1.stringNull1(dgvAdd[colDrug14, i].Value);
                    worksheet.Cells[i, colDrug15] = config1.stringNull1(dgvAdd[colDrug15, i].Value);

                    worksheet.Cells[i, colDrug16] = config1.stringNull1(dgvAdd[colDrug16, i].Value);
                    worksheet.Cells[i, colDrug17] = config1.stringNull1(dgvAdd[colDrug17, i].Value);
                    worksheet.Cells[i, colDrug18] = config1.stringNull1(dgvAdd[colDrug18, i].Value);
                    worksheet.Cells[i, colDrug19] = config1.stringNull1(dgvAdd[colDrug19, i].Value);
                    worksheet.Cells[i, colDrug20] = config1.stringNull1(dgvAdd[colDrug20, i].Value);
                    pB1.Value = i;
                }
                catch(Exception ex)
                {
                    //MessageBox.Show("Error " + ex.Message + "\n row " + i, "error " + err);
                }
                if (dgvAdd[colPatientHnno, i].Value == null)
                {
                    continue;
                }
                
            }


            //worksheet.Cells[1, 1] = "Name";
            //worksheet.Cells[1, 2] = "Bid";

            //worksheet.Cells[2, 1] = txbName.Text;
            //worksheet.Cells[2, 2] = txbResult.Text;
            pB1.Hide();
            excelapp.UserControl = true;
            excelapp.Visible = true;
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(null, null);
            }
            else
            {
                if (txtSearch.Text.Length >= 2)
                {
                    dgvAdd.ClearSelection();
                    dgvAdd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    int rowIndex = -1;
                    try
                    {
                        foreach (DataGridViewRow row in dgvAdd.Rows)
                        {
                            if (row.Cells[colDrug1].Value == null)
                            {
                                continue;
                            }
                            if (row.Cells[colDrug1].Value.ToString().ToUpper().IndexOf(txtSearch.Text.ToUpper(), 0,
                                txtSearch.Text.Length) >= 0)
                            {
                                rowIndex = row.Index;
                                dgvAdd.Rows[row.Index].Selected = true;
                                dgvAdd.CurrentCell = dgvAdd.Rows[row.Index].Cells[colDrug1];
                                //dgvAdd.Rows[row.Index].Cells[colDrug1].Selected = true;
                                break;
                            }
                        }
                    }
                    catch (Exception exc)
                    {
                        //MessageBox.Show(exc.Message);
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            try
            {
                //String rowFilter = string.Format("[{0}] = '{1}'", columnName, txtSearch.Text);
                //(dgvAdd.DataSource as DataTable).DefaultView.RowFilter = rowFilter;

                //(dgvAdd.DataSource as DataTable).DefaultView.RowFilter = string.Format("Field = '{"+colDrug1+"}'", txtSearch.Text);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(""+ex.Message, "error");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvAdd_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAdd[e.ColumnIndex, e.RowIndex].Value == null)
            {
                if (!edit.Equals(""))
                {
                    dgvAdd[colRowEdit, e.RowIndex].Value = "*";
                }
                return;
            }
            if (!dgvAdd[e.ColumnIndex, e.RowIndex].Value.ToString().Equals(edit))
            {
                dgvAdd[colRowEdit, e.RowIndex].Value = "*";
                dgvAdd[colEditDia, e.RowIndex].Value += e.ColumnIndex+",";
                //dgvAdd.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
                dgvAdd.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                //dgvAdd[e.ColumnIndex, e.RowIndex].de
            }
        }

        private void dgvAdd_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            edit = "";
            if (dgvAdd[e.ColumnIndex, e.RowIndex].Value == null)
            {
                return;
            }
            edit = dgvAdd[e.ColumnIndex, e.RowIndex].Value.ToString();
            //dgvAdd[colEdit, e.RowIndex].Value = edit;
        }

        private void txtLabSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(null, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            pB1.Show();
            pB1.Minimum = 0;
            pB1.Maximum = dgvAdd.Rows.Count;
            String vn = "", chk = "", visitDate = "";
            for (int i = 0; i < dgvAdd.Rows.Count; i++)
            {
                vn = "";
                if (dgvAdd[colRowEdit, i].Value==null)
                {
                    continue;
                }
                if (!dgvAdd[colRowEdit, i].Value.Equals("*"))
                {
                    continue;
                }
                if (dgvAdd[colDate, i].Value == null)
                {
                    continue;
                }
                CheckNhso1 p = new CheckNhso1();
                if (dgvAdd[colDate, i].Value.ToString().Length >= 10)
                {
                    visitDate = dgvAdd[colDate, i].Value.ToString();
                    visitDate = visitDate.Substring(visitDate.Length - 4) + "-" + visitDate.Substring(3, 2) + "-" + visitDate.Substring(0, 2);
                }

                //vn = dgvAdd[colVn, i].Value.ToString() + dgvAdd[colvnSeq, i].Value.ToString() + dgvAdd[colvnSum, i].Value.ToString();
                p.visitDate = visitDate;
                visitDate = visitDate.Replace("-", "");
                //p.checknhsoId = visitDate + vn;
                p.checknhsoId = dgvAdd[colId, i].Value.ToString();
                p.hn = dgvAdd[colPatientHnno, i].Value.ToString();
                p.patientName = dgvAdd[colPatientName, i].Value.ToString();

                p.visitTime = dgvAdd[colTime, i].Value.ToString();

                p.vn = dgvAdd[colVn, i].Value.ToString();
                p.rowID = i.ToString();
                p.dia1 = config1.stringNull1(dgvAdd[colDiaCD1, i].Value);
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

                p.rowEdit = config1.stringNull1(dgvAdd[colLabValue10, i].Value);
                p.editDia = config1.stringNull1(dgvAdd[colEditDia, i].Value);
                p.editDrug = config1.stringNull1(dgvAdd[colEditDrug, i].Value);

                chk = cNhso1db.insertCHeckNhso(p,false);
                if (chk.Equals(p.checknhsoId))
                {
                    dgvAdd.Rows[i].DefaultCellStyle.BackColor = Color.Cornsilk;
                }

                pB1.Value = i;
            }
            pB1.Hide();
        }

        private void txtLabSearch2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(null, null);
            }
        }
        private void showCheckNhsoAdd()
        {
            FrmCheckNHSOAdd frm = new FrmCheckNHSOAdd();
            frm.ShowDialog(this);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //FrmCheckNHSOAdd frm = new FrmCheckNHSOAdd();
            //frm.ShowDialog(this);
            showCheckNhsoAdd();
            //if (cNhso1db.conn.isBranch.Equals("yes"))
            //{
            //    this.Dispose();
            //}
        }

        private void dgvAdd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (dgvAdd[colId, e.RowIndex].Value == null)
            {
                return;
            }
            FrmCheckNHSODetail frm = new FrmCheckNHSODetail(dgvAdd[colId, e.RowIndex].Value.ToString());
            frm.ShowDialog();
        }
    }
}
