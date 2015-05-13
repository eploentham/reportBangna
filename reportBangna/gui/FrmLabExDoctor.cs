using reportBangna.objdb;
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
    public partial class FrmLabExDoctor : Form
    {
        BangnaControl bc;
        int colRow = 0, colHN = 1, colVn = 2, colName = 3, colVisitDate = 4, colDescription = 5, colRemark = 6, colId = 7, colRowNumber=8, colYearId=9;
        int colCnt = 10;
        LabExDB labexdb;
        //BangnaControl bc;
        public FrmLabExDoctor(BangnaControl b)
        {
            InitializeComponent();
            initConfig();
        }
        private void initConfig()
        {
            bc = new BangnaControl();
            labexdb = new LabExDB();
            //vsdb = new VisitDB();
            //vs = new Visit();
            tC.TabPages[0].Text = "image";
            tC.TabPages[1].Text = "ประวัติ";
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
            dgv1.Columns[colRow].Width = 50;
            dgv1.Columns[colHN].Width = 80;
            dgv1.Columns[colVn].Width = 80;
            dgv1.Columns[colName].Width = 220;
            dgv1.Columns[colVisitDate].Width = 120;
            dgv1.Columns[colDescription].Width = 120;
            dgv1.Columns[colRemark].Width = 120;

            dgv1.Columns[colRow].HeaderText = "ลำดับ";
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
                    dgv1[colRow, i].Value = (i + 1);
                    dgv1[colHN, i].Value = dt.Rows[i][labexdb.labex.Hn].ToString();
                    dgv1[colVn, i].Value = dt.Rows[i][labexdb.labex.Vn].ToString();
                    dgv1[colName, i].Value = dt.Rows[i][labexdb.labex.PatientName].ToString();
                    dgv1[colVisitDate, i].Value = dt.Rows[i][labexdb.labex.VisitDate].ToString();
                    dgv1[colId, i].Value = dt.Rows[i][labexdb.labex.Id].ToString();
                    dgv1[colDescription, i].Value = dt.Rows[i][labexdb.labex.Description].ToString();
                    dgv1[colRemark, i].Value = dt.Rows[i][labexdb.labex.Remark].ToString();
                    dgv1[colRowNumber, i].Value = dt.Rows[i][labexdb.labex.RowNumber].ToString();
                    dgv1[colYearId, i].Value = dt.Rows[i][labexdb.labex.YearId].ToString();
                    if ((i % 2) != 0)
                    {
                        dgv1.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }

            dgv1.Font = font;
            dgv1.Columns[colId].Visible = false;
            dgv1.Columns[colRowNumber].Visible = false;
            dgv1.Columns[colYearId].Visible = false;
        }
        private void LoadPic1(String filename)
        {
            if (System.IO.File.Exists(filename))
            {
                pic1.Image = Image.FromFile(filename);
                pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pic1.Image = null;
            }
            
            //fileName = ofd.FileName;
            //btnSave.Enabled = true;
        }

        private void FrmLabExDoctor_Load(object sender, EventArgs e)
        {

        }

        private void txtHN_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                setGrd(txtHN.Text);
            }
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (dgv1[colRowNumber, e.RowIndex].Value == null)
            {
                return;
            }
            String fileEx = "\\\\172.25.10.5\\image\\labex\\" + dgv1[colYearId, e.RowIndex].Value.ToString() + "\\";
            LoadPic1(fileEx+dgv1[colRowNumber, e.RowIndex].Value.ToString()+".jpg");
            //bc.vnSearch = dgv1[colVn, e.RowIndex].Value.ToString();
            //bc.hnSearch = dgv1[colHN, e.RowIndex].Value.ToString();
            //bc.vs.HN = dgv1[colHN, e.RowIndex].Value.ToString();
            //bc.vs.VN = dgv1[colVn, e.RowIndex].Value.ToString();
            //bc.vs.PatientName = dgv1[colName, e.RowIndex].Value.ToString();

            //FrmLabExAdd frm = new FrmLabExAdd(bc, dgv1[colId, e.RowIndex].Value.ToString());
            //frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            setGrd(txtHN.Text);
        }
    }
}
