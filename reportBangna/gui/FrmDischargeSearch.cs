﻿using reportBangna.object1;
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
    public partial class FrmDischargeSearch : Form
    {
        int colRow = 0, colHN = 1, colVn = 2, colName = 3, colAge = 4, colFnCd = 5, colsymptom = 6, colVisitDate = 7, colVisitTime = 8, colLabDate = 9, colLabTime = 10, colDoctorId = 11, colDoctorName = 12, colLabReqNo = 13, colPreno=14;
        int colCnt = 15;

        BangnaControl bc;
        Visit vs;
        public FrmDischargeSearch()
        {
            InitializeComponent();
            //bc = b;
            initConfig();
        }
        private void initConfig()
        {
            //labexdb = new LabExDB();
            //vsdb = new VisitDB();
            bc = new BangnaControl();
            vs = new Visit();
            setGrd();
        }
        private void setGrd()
        {
            Font font = new Font("Microsoft Sans Serif", 12);
            DataTable dt = new DataTable();
            DateTime dt1 = new DateTime();
            String visitDate = "", visitTime = "", hn = "";
            hn = txtHN.Text;
            if (hn.Equals(""))
            {
                hn = "@";
            }
            dt = bc.vsdb.selectVisitByHn1(hn);

            dgv1.ColumnCount = colCnt;
            dgv1.Rows.Clear();
            dgv1.RowCount = 1;
            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv1.Columns[colRow].Width = 50;
            dgv1.Columns[colHN].Width = 80;
            dgv1.Columns[colVn].Width = 80;
            dgv1.Columns[colName].Width = 220;
            dgv1.Columns[colAge].Width = 80;
            dgv1.Columns[colFnCd].Width = 120;
            dgv1.Columns[colsymptom].Width = 80;

            dgv1.Columns[colRow].HeaderText = "ลำดับ";
            dgv1.Columns[colHN].HeaderText = "HN";
            dgv1.Columns[colVn].HeaderText = "VN";
            dgv1.Columns[colName].HeaderText = "ชื่อ นามสกุล";
            dgv1.Columns[colAge].HeaderText = "อายุ";
            dgv1.Columns[colFnCd].HeaderText = "สิทธิ";
            dgv1.Columns[colsymptom].HeaderText = "อาการ";

            //dgvPE.Columns[colPEId].HeaderText = "id";
            if (dt.Rows.Count > 0)
            {
                dgv1.RowCount = dt.Rows.Count;
                for (int i = 0; i < dgv1.RowCount; i++)
                {
                    dgv1[colRow, i].Value = (i+1);
                    dgv1[colHN, i].Value = dt.Rows[i]["MNC_HN_NO"].ToString();
                    dgv1[colVn, i].Value = dt.Rows[i]["MNC_VN_NO"].ToString() + "." + dt.Rows[i]["MNC_VN_SEQ"].ToString() + "." + dt.Rows[i]["MNC_VN_SUM"].ToString();
                    dgv1[colName, i].Value = dt.Rows[i]["prefix"].ToString() + " " + dt.Rows[i]["MNC_FNAME_T"].ToString() + " " + dt.Rows[i]["MNC_LNAME_T"].ToString();
                    dgv1[colAge, i].Value = dt.Rows[i]["AGE"].ToString();
                    dgv1[colFnCd, i].Value = dt.Rows[i]["MNC_FN_TYP_DSC"].ToString();
                    dgv1[colsymptom, i].Value = dt.Rows[i]["MNC_SHIF_MEMO"].ToString();
                    dgv1[colDoctorId, i].Value = dt.Rows[i]["MNC_DOT_CD"].ToString();
                    dgv1[colDoctorName, i].Value = dt.Rows[i]["prefixdoc"].ToString() + " " + dt.Rows[i]["MNC_DOT_FNAME"].ToString() + " " + dt.Rows[i]["MNC_DOT_LNAME"].ToString();
                    dgv1[colLabReqNo, i].Value = dt.Rows[i]["MNC_REQ_NO"].ToString();
                    dgv1[colPreno, i].Value = dt.Rows[i]["MNC_PRE_NO"].ToString();
                    if (dt.Rows[i]["MNC_DATE"] != null)
                    {
                        dt1 = DateTime.Parse(dt.Rows[i]["MNC_DATE"].ToString());
                        visitDate = dt1.ToString("dd-MM-yyyy");
                        dgv1[colVisitDate, i].Value = visitDate;
                        visitTime = "0000" + dt.Rows[i]["MNC_TIME"].ToString();
                        visitTime = visitTime.Substring(visitTime.Length - 4);
                        dgv1[colVisitTime, i].Value = visitTime.Substring(0, 2) + ":" + visitTime.Substring(2);
                    }
                    else
                    {
                        dgv1[colVisitDate, i].Value = "";
                    }
                    if (dt.Rows[i]["MNC_REQ_DAT"] != null)
                    {
                        dt1 = DateTime.Parse(dt.Rows[i]["MNC_REQ_DAT"].ToString());
                        visitDate = dt1.ToString("dd-MM-yyyy");
                        dgv1[colLabDate, i].Value = visitDate;
                        visitTime = "0000" + dt.Rows[i]["MNC_REQ_TIM"].ToString();
                        visitTime = visitTime.Substring(visitTime.Length - 4);
                        dgv1[colLabTime, i].Value = visitTime.Substring(0, 2) + ":" + visitTime.Substring(2);
                    }
                    else
                    {
                        dgv1[colVisitDate, i].Value = "";
                    }
                    if ((i % 2) != 0)
                    {
                        dgv1.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
                dgv1.Font = font;
            }
            dgv1.Columns[colPreno].Visible = false;
        }

        private void txtHN_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtHN.Text.Length >= 5)
            {
                setGrd();
            }
        }

        private void FrmDischargeSearch_Load(object sender, EventArgs e)
        {

        }

        private void dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (dgv1[colRow, e.RowIndex].Value == null)
            {
                return;
            }
            String vn = dgv1[colVn, e.RowIndex].Value.ToString();
            vs.HN = dgv1[colHN, e.RowIndex].Value.ToString();
            vs.VN = dgv1[colVn, e.RowIndex].Value.ToString();
            String[] vn1 = vn.Split('.');
            if (vn1.Length > 2)
            {
                vs.vn = vn1[0];
                vs.vnseq = vn1[1];
                vs.vnsum = vn1[2];
            }
            vs.PatientName = dgv1[colName, e.RowIndex].Value.ToString();
            vs.symptom = dgv1[colsymptom, e.RowIndex].Value.ToString();
            vs.Age = dgv1[colAge, e.RowIndex].Value.ToString();
            vs.preno = dgv1[colPreno, e.RowIndex].Value.ToString();
            vs.VisitDate = dgv1[colVisitDate, e.RowIndex].Value.ToString() + " " + dgv1[colLabTime, e.RowIndex].Value;
            FrmDischargeVnView frm = new FrmDischargeVnView(bc, vs);
            frm.ShowDialog(this);
        }
    }
}
