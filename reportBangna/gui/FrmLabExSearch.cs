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
    public partial class FrmLabExSearch : Form
    {
        int colRow = 0, colHN = 1, colVn = 2, colName = 3, colAge = 4, colFnCd = 5, colsymptom = 6, colVisitDate = 7, colVisitTime = 8, colLabDate = 9, colLabTime = 10, colDoctorId = 11;
        int colDoctorName=12, colLabReqNo=13, colLabName=14;
        int colCnt = 15;

        //VisitDB vsdb;
        Visit vs;
        //LabExDB labexdb;
        BangnaControl bc;
        public String vnSearch = "";

        public FrmLabExSearch(BangnaControl b)
        {
            InitializeComponent();
            bc = b;
            //vnSearch = vnsearch;
            initConfig();
        }
        private void initConfig()
        {
            //labexdb = new LabExDB();
            //vsdb = new VisitDB();
            vs = new Visit();
            setGrd();
        }
        private void setGrd()
        {
            Font font = new Font("Microsoft Sans Serif", 12);
            DataTable dt = new DataTable();
            DateTime dt1 = new DateTime();
            String visitDate = "", visitTime="",hn="";
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
            dgv1.Columns[colVn].Width = 70;
            dgv1.Columns[colName].Width = 220;
            dgv1.Columns[colAge].Width = 60;
            dgv1.Columns[colFnCd].Width = 120;
            dgv1.Columns[colsymptom].Width = 160;
            dgv1.Columns[colVisitTime].Width = 60;
            dgv1.Columns[colDoctorName].Width = 160;
            dgv1.Columns[colLabTime].Width = 60;
            dgv1.Columns[colLabName].Width = 160;

            dgv1.Columns[colRow].HeaderText = "ลำดับ";
            dgv1.Columns[colHN].HeaderText = "HN";
            dgv1.Columns[colVn].HeaderText = "VN";
            dgv1.Columns[colName].HeaderText = "ชื่อ นามสกุล";
            dgv1.Columns[colAge].HeaderText = "อายุ";
            dgv1.Columns[colFnCd].HeaderText = "สิทธิ";
            dgv1.Columns[colsymptom].HeaderText = "อาการ";
            dgv1.Columns[colLabName].HeaderText = "lab name";
            dgv1.Columns[colDoctorName].HeaderText = "doctor name";

            dgv1.Columns[colVisitDate].HeaderText = "visit date";
            dgv1.Columns[colVisitTime].HeaderText = "v.time";
            dgv1.Columns[colLabDate].HeaderText = "l.date";
            dgv1.Columns[colLabTime].HeaderText = "l.time";

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
                    dgv1[colLabName, i].Value = dt.Rows[i]["MNC_LB_DSC"].ToString();
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
            dgv1.Columns[colLabReqNo].Visible = false;
            dgv1.Columns[colDoctorId].Visible = false;
            dgv1.Columns[colLabReqNo].Visible = false;
            dgv1.Columns[colLabReqNo].Visible = false;
            dgv1.ScrollBars = ScrollBars.Both;
        }
        private void setResize()
        {
            dgv1.Width = this.Width - 80;
            dgv1.Height = this.Height - groupBox1.Height - 80;
            //groupBox3.Left = dgvAdd.Width - groupBox3.Width - 50;
            //btnSave.Left = dgvAdd.Width - 80;
            //btnDoc.Left = btnSave.Left;
            //btnPrint.Left = btnSave.Left;
            //btnPrintT.Left = btnSave.Left;
            //btnCalEx.Left = btnSave.Left;
            //groupBox2.Left = this.Width - groupBox2.Width - btnSave.Width - 150;
            //groupBox3.Left = groupBox2.Left;
            //groupBox1.Height = this.Height = 150;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            /**
             * ให้แสดงข้อมูล จากdatabase ของbee 
             * เพราะจะได้รู้ว่า scan ผลแล้วหรือยัง
             * */
        }

        private void FrmLabExSearch_Load(object sender, EventArgs e)
        {

        }

        private void txtHN_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtHN.Text.Length>=5)
            {
                setGrd();
            }
        }

        private void dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (dgv1[colVn, e.RowIndex].Value == null)
            {
                return;
            }
            //bc.vnSearch = dgv1[colVn, e.RowIndex].Value.ToString();
            //bc.hnSearch = dgv1[colHN, e.RowIndex].Value.ToString();
            bc.vs.HN = dgv1[colHN, e.RowIndex].Value.ToString();
            bc.vs.VN = dgv1[colVn, e.RowIndex].Value.ToString();
            bc.vs.PatientName = dgv1[colName, e.RowIndex].Value.ToString();
            bc.vs.VisitDate = dgv1[colVisitDate, e.RowIndex].Value.ToString();
            bc.vs.VisitTime = dgv1[colVisitTime, e.RowIndex].Value.ToString();
            bc.vs.LabDate = dgv1[colLabDate, e.RowIndex].Value.ToString();
            bc.vs.LabTime = dgv1[colLabTime, e.RowIndex].Value.ToString();
            bc.vs.DoctorId = dgv1[colDoctorId, e.RowIndex].Value.ToString();
            bc.vs.DoctorName = dgv1[colDoctorName, e.RowIndex].Value.ToString();
            bc.vs.LabReqNo = dgv1[colLabReqNo, e.RowIndex].Value.ToString();

            this.Dispose();
        }

        private void FrmLabExSearch_Resize(object sender, EventArgs e)
        {
            setResize();
        }
    }
}
