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
        int colRow = 0, colHN = 1, colVn = 2, colName = 3, colVisitDate = 4, colDescription = 5, colRemark = 6, colId = 7, colRowNumber = 8, colYearId = 9, col1pdf1 = 10, col1pdf2 = 11, col1pdf3 = 12, col1pdf4 = 13, col1pdf5 = 14;
        int colCnt = 15;
        //LabExDB labexdb;
        //BangnaControl bc;
        public FrmLabExDoctor(BangnaControl b)
        {
            InitializeComponent();
            bc = b;
            initConfig();
        }
        public FrmLabExDoctor()
        {
            InitializeComponent();
            //bc = b;
            initConfig();
        }
        private void initConfig()
        {
            bc = new BangnaControl();
            //labexdb = new LabExDB();
            //vsdb = new VisitDB();
            //vs = new Visit();
            //tC.TabPages[0].Text = "image";
            //tC.TabPages[1].Text = "ประวัติ";
            setGrd("1");
        }
        private void ShowBtn1PDF(int row, String num)
        {
            String fileEx = bc.pathLabEx + dgv1[colYearId, row].Value + "\\" + dgv1[colId, row].Value + "_"+num+".pdf";
            bool isExists = System.IO.File.Exists(fileEx);
            if (isExists)
            {
                if (num.Equals("1"))
                {
                    dgv1[col1pdf1, row].Value = "PDF";
                }
                else if (num.Equals("2"))
                {
                    dgv1[col1pdf2, row].Value = "PDF";
                }
                else if (num.Equals("3"))
                {
                    dgv1[col1pdf3, row].Value = "PDF";
                }
                else if (num.Equals("4"))
                {
                    dgv1[col1pdf4, row].Value = "PDF";
                }
                else if (num.Equals("5"))
                {
                    dgv1[col1pdf5, row].Value = "PDF";
                }
            }
            else
            {
                if (num.Equals("1"))
                {
                    dgv1[col1pdf1, row].Value = "";
                }
                else if (num.Equals("2"))
                {
                    dgv1[col1pdf2, row].Value = "";
                }
                else if (num.Equals("3"))
                {
                    dgv1[col1pdf3, row].Value = "";
                }
                else if (num.Equals("4"))
                {
                    dgv1[col1pdf4, row].Value = "";
                }
                else if (num.Equals("5"))
                {
                    dgv1[col1pdf5, row].Value = "";
                };
            }
        }

        private void setGrd(String hn)
        {
            Font font = new Font("Microsoft Sans Serif", 12);
            DataTable dt = new DataTable();
            if (hn.Equals(""))
            {
                return;
            }
            else
            {
                dt = bc.labexdb.selectByHn1(hn);
            }            

            dgv1.ColumnCount = colCnt;
            dgv1.Rows.Clear();
            dgv1.RowCount = 1;
            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv1.Columns[colRow].Width = 40;
            dgv1.Columns[colHN].Width = 80;
            dgv1.Columns[colVn].Width = 65;
            dgv1.Columns[colName].Width = 200;
            dgv1.Columns[colVisitDate].Width = 90;
            dgv1.Columns[colDescription].Width = 120;
            dgv1.Columns[colRemark].Width = 100;
            dgv1.Columns[col1pdf1].Width = 50;
            dgv1.Columns[col1pdf2].Width = 50;
            dgv1.Columns[col1pdf3].Width = 50;
            dgv1.Columns[col1pdf4].Width = 50;
            dgv1.Columns[col1pdf5].Width = 50;

            dgv1.Columns[colRow].HeaderText = "no";
            dgv1.Columns[colHN].HeaderText = "HN";
            dgv1.Columns[colVn].HeaderText = "VN";
            dgv1.Columns[colName].HeaderText = "ชื่อ นามสกุล";
            dgv1.Columns[colVisitDate].HeaderText = "วันที่visit";
            dgv1.Columns[colDescription].HeaderText = "รายละเอียด";
            dgv1.Columns[colRemark].HeaderText = "หมายเหตุ";
            dgv1.Columns[col1pdf1].HeaderText = "1";
            dgv1.Columns[col1pdf2].HeaderText = "2";
            dgv1.Columns[col1pdf3].HeaderText = "3";
            dgv1.Columns[col1pdf4].HeaderText = "4";
            dgv1.Columns[col1pdf5].HeaderText = "5";


            //dgvPE.Columns[colPEId].HeaderText = "id";
            if (dt.Rows.Count > 0)
            {
                dgv1.RowCount = dt.Rows.Count;
                label1.Text = "";
                for (int i = 0; i < dgv1.RowCount; i++)
                {
                    dgv1[colRow, i].Value = (i + 1);
                    dgv1[colHN, i].Value = dt.Rows[i][bc.labexdb.labex.Hn].ToString();
                    dgv1[colVn, i].Value = dt.Rows[i][bc.labexdb.labex.Vn].ToString();
                    dgv1[colName, i].Value = dt.Rows[i][bc.labexdb.labex.PatientName].ToString();
                    dgv1[colVisitDate, i].Value = bc.cf.dateLabExShow(dt.Rows[i][bc.labexdb.labex.VisitDate].ToString());
                    dgv1[colId, i].Value = dt.Rows[i][bc.labexdb.labex.Id].ToString();
                    dgv1[colDescription, i].Value = dt.Rows[i][bc.labexdb.labex.Description].ToString();
                    dgv1[colRemark, i].Value = dt.Rows[i][bc.labexdb.labex.Remark].ToString();
                    dgv1[colRowNumber, i].Value = dt.Rows[i][bc.labexdb.labex.RowNumber].ToString();
                    dgv1[colYearId, i].Value = dt.Rows[i][bc.labexdb.labex.YearId].ToString();
                    if ((i % 2) != 0)
                    {
                        dgv1.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                    ShowBtn1PDF(i, "1");
                    ShowBtn1PDF(i, "2");
                    ShowBtn1PDF(i, "3");
                    ShowBtn1PDF(i, "4");
                    ShowBtn1PDF(i, "5");
                }
            }
            else
            {
                label1.Text = "ไม่พบข้อมูล หรือผลLabนอก ยังไม่มา";
            }

            dgv1.Font = font;
            dgv1.Columns[colId].Visible = false;
            dgv1.Columns[colRowNumber].Visible = false;
            dgv1.Columns[colYearId].Visible = false;
        }
        //private void LoadPic1(String filename)
        //{
        //    if (System.IO.File.Exists(filename))
        //    {
        //        pic1.Image = Image.FromFile(filename);
        //        pic1.SizeMode = PictureBoxSizeMode.StretchImage;
        //    }
        //    else
        //    {
        //        pic1.Image = null;
        //    }            
        //    //fileName = ofd.FileName;
        //    //btnSave.Enabled = true;
        //}
        private void OpenPDF(int row,String num)
        {
            String fileEx = bc.pathLabEx + dgv1[colYearId, row].Value + "\\" + dgv1[colId, row].Value + "_" + num + ".pdf";
            //String fileEx = @"d:\157073293_1.pdf";
            //String fileEx = @"d:\ScandAllPRO.exe";
            //Process p = new Process();
            //p.StartInfo.FileName = fileEx;
            ////p.StartInfo.Arguments = "/c dir *.cs";
            //p.StartInfo.UseShellExecute = false;
            //p.StartInfo.RedirectStandardOutput = true;
            //p.Start();
            bool isExists = System.IO.File.Exists(fileEx);
            if(isExists)
                System.Diagnostics.Process.Start(fileEx);
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
            else
            {
                if (txtHN.Text.Length >= 5)
                {
                    setGrd(txtHN.Text);
                }
            }
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex == -1)
            //{
            //    return;
            //}
            //if (dgv1[colRowNumber, e.RowIndex].Value == null)
            //{
            //    return;
            //}
            //String fileEx = bc.pathLabEx + dgv1[colYearId, e.RowIndex].Value.ToString() + "\\";
            //LoadPic1(fileEx+dgv1[colRowNumber, e.RowIndex].Value.ToString()+".jpg");
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
            if(e.ColumnIndex==col1pdf1)
            {
                OpenPDF( e.RowIndex, "1");
            }
            else if (e.ColumnIndex == col1pdf2)
            {
                OpenPDF(e.RowIndex, "2");
            }
            else if (e.ColumnIndex == col1pdf3)
            {
                OpenPDF(e.RowIndex, "3");
            }
            else if (e.ColumnIndex == col1pdf4)
            {
                OpenPDF(e.RowIndex, "4");
            }
            else if (e.ColumnIndex == col1pdf5)
            {
                OpenPDF(e.RowIndex, "5");
            }
        }
    }
}
