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
    public partial class FrmLabExView : Form
    {
        int colRow = 0, colHN = 1, colVn = 2, colName = 3, colVisitDate = 4, colDescription = 5, colRemark = 6, colId=7;
        int colCnt = 8;
        LabExDB labexdb;
        BangnaControl bc;
        VisitDB vsdb;
        Visit vs;
        private void initConfig()
        {
            bc = new BangnaControl();
            labexdb = new LabExDB();
            vsdb = new VisitDB();
            vs = new Visit();
            setGrd("");
        }
        private void setGrd(String hn)
        {
            Font font = new Font("Microsoft Sans Serif", 12);
            DataTable dt = new DataTable();
            dt = labexdb.selectByHn(hn);

            dgv1.ColumnCount = colCnt;
            dgv1.Rows.Clear();
            dgv1.RowCount = 1;
            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv1.Columns[colRow].Width = 40;
            dgv1.Columns[colHN].Width = 80;
            dgv1.Columns[colVn].Width = 80;
            dgv1.Columns[colName].Width = 200;
            dgv1.Columns[colVisitDate].Width = 80;
            dgv1.Columns[colDescription].Width = 120;
            dgv1.Columns[colRemark].Width = 120;

            dgv1.Columns[colRow].HeaderText = "no";
            dgv1.Columns[colHN].HeaderText = "HN";
            dgv1.Columns[colVn].HeaderText = "VN";
            dgv1.Columns[colName].HeaderText = "ชื่อ นามสกุล";
            dgv1.Columns[colVisitDate].HeaderText = "วันที่visit";
            dgv1.Columns[colDescription].HeaderText = "รายละเอียด";
            dgv1.Columns[colRemark].HeaderText = "หมายเหตุ";
            //dgv1.Columns[colPEWeight].HeaderText = "น้ำหนัก";
            
            //dgvPE.Columns[colPEId].HeaderText = "id";
            if (dt.Rows.Count > 0)
            {
                dgv1.RowCount = dt.Rows.Count;
                for (int i = 0; i < dgv1.RowCount; i++)
                {
                    dgv1[colRow, i].Value = (i+1);
                    dgv1[colHN, i].Value = dt.Rows[i][labexdb.labex.Hn].ToString();
                    dgv1[colVn, i].Value = dt.Rows[i][labexdb.labex.Vn].ToString();
                    dgv1[colName, i].Value = dt.Rows[i][labexdb.labex.PatientName].ToString();
                    dgv1[colVisitDate, i].Value = bc.cf.dateLabExShow(dt.Rows[i][labexdb.labex.VisitDate].ToString());
                    dgv1[colId, i].Value = dt.Rows[i][labexdb.labex.Id].ToString();
                    dgv1[colDescription, i].Value = dt.Rows[i][labexdb.labex.Description].ToString();
                    dgv1[colRemark, i].Value = dt.Rows[i][labexdb.labex.Remark].ToString();
                    if ((i % 2) != 0)
                    {
                        dgv1.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
            
            dgv1.Font = font;
            dgv1.Columns[colId].Visible = false;
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
        public FrmLabExView()
        {
            InitializeComponent();
            initConfig();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLabExAdd frm = new FrmLabExAdd(bc,"");
            frm.ShowDialog();
            
            setGrd(txtHN.Text);
            this.Show();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            FrmLabExDoctor frm = new FrmLabExDoctor(bc);
            frm.ShowDialog();
        }

        private void FrmLabExView_Load(object sender, EventArgs e)
        {
            this.Text = "ReAdmit Last Update " + System.IO.File.GetLastWriteTime(System.Environment.CurrentDirectory + "\\" + Process.GetCurrentProcess().ProcessName + ".exe");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            setGrd(txtHN.Text);
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
            bc.lw.WriteLog("FrmLabExView.dgv1_CellDoubleClick ");
            //bc.vnSearch = dgv1[colVn, e.RowIndex].Value.ToString();
            //bc.hnSearch = dgv1[colHN, e.RowIndex].Value.ToString();
            //bc.vs.HN = dgv1[colHN, e.RowIndex].Value.ToString();
            //bc.vs.VN = dgv1[colVn, e.RowIndex].Value.ToString();
            //bc.vs.PatientName = dgv1[colName, e.RowIndex].Value.ToString();
            
            FrmLabExAdd frm = new FrmLabExAdd(bc, dgv1[colId, e.RowIndex].Value.ToString());
            this.Hide();
            frm.ShowDialog();
            this.Show();
            //this.Dispose();
        }

        private void txtHN_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                setGrd(txtHN.Text);
            }
        }

        private void txtHN_Enter(object sender, EventArgs e)
        {
            txtHN.SelectAll();
        }

        private void FrmLabExView_Resize(object sender, EventArgs e)
        {
            setResize();
        }
    }
}
