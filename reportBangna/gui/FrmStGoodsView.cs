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
    public partial class FrmStGoodsView : Form
    {
        BangnaControl bc;
        int colCode = 1, colNameT = 2, colId = 3, colRow = 0;
        int colCnt = 4;
        public FrmStGoodsView(BangnaControl c)
        {
            InitializeComponent();
            bc = c;
            initConfig();
        }
        private void initConfig()
        {
            setGrd();
        }
        private void setGrd()
        {
            Font font = new Font("Microsoft Sans Serif", 12);
            DataTable dt = new DataTable();

            dgvView.ColumnCount = colCnt;
            dgvView.Rows.Clear();
            dgvView.RowCount = 1;
            dgvView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvView.Columns[colCode].Width = 80;
            dgvView.Columns[colNameT].Width = 300;
            dgvView.Columns[colId].Width = 80;
            dgvView.Columns[colRow].Width = 40;

            dgvView.Columns[colRow].HeaderText = "no";
            dgvView.Columns[colCode].HeaderText = "Code";
            dgvView.Columns[colNameT].HeaderText = "Name";
            //dgvView.Columns[colNameT].HeaderText = "Name";
            dgvView.Columns[colId].HeaderText = "";

            //dgv1.Columns[colPEWeight].HeaderText = "น้ำหนัก";
            dt = bc.gooddb.selectAll();

            //dgvPE.Columns[colPEId].HeaderText = "id";
            if (dt.Rows.Count > 0)
            {
                dgvView.RowCount = dt.Rows.Count;
                for (int i = 0; i < dgvView.RowCount; i++)
                {
                    dgvView[colRow, i].Value = (i + 1);
                    dgvView[colCode, i].Value = dt.Rows[i][bc.gooddb.good.Code].ToString();
                    dgvView[colNameT, i].Value = dt.Rows[i][bc.gooddb.good.NameT].ToString();
                    dgvView[colId, i].Value = dt.Rows[i][bc.gooddb.good.Id].ToString();

                    if ((i % 2) != 0)
                    {
                        dgvView.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }

            dgvView.Font = font;
            dgvView.Columns[colId].Visible = false;
        }
        private void setResize()
        {
            dgvView.Width = this.Width - 80;
            dgvView.Height = this.Height - 150;
            btnAdd.Left = dgvView.Width - 50;
            //btnPrint.Left = dgvView.Width + 20;
            //groupBox1.Width = this.Width - 50;
            //groupBox1.Height = this.Height = 150;
        }

        private void dgvView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (dgvView[colId, e.RowIndex].Value == null)
            {
                return;
            }
            bc.lw.WriteLog("FrmStGoodsView.dgvView_CellDoubleClick ");
            //bc.vnSearch = dgv1[colVn, e.RowIndex].Value.ToString();
            //bc.hnSearch = dgv1[colHN, e.RowIndex].Value.ToString();
            //bc.vs.HN = dgv1[colHN, e.RowIndex].Value.ToString();
            //bc.vs.VN = dgv1[colVn, e.RowIndex].Value.ToString();
            //bc.vs.PatientName = dgv1[colName, e.RowIndex].Value.ToString();

            FrmStGoodsAdd frm = new FrmStGoodsAdd(bc, dgvView[colId, e.RowIndex].Value.ToString());
            this.Hide();
            frm.ShowDialog();
            this.Show();
            //this.Dispose();
        }

        private void FrmStGoodsView_Load(object sender, EventArgs e)
        {

        }

        private void FrmStGoodsView_Resize(object sender, EventArgs e)
        {
            setResize();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmStGoodsAdd f = new FrmStGoodsAdd(bc, "");
            f.ShowDialog(this);
        }
    }
}
