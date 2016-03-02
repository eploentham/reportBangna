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
        int tabSum =0,tab1 = 1, tab2 = 2, tab3 = 3, tab4=4,tab5=5,tab6=6,tab7=7, tab8=8,tab9=9,tab10=10;
        ComboBox cb;
        DataGridView[] dgv = new DataGridView[20];
        public FrmStGoodsView(BangnaControl c)
        {
            InitializeComponent();
            bc = c;
            initConfig();
        }
        private void initConfig()
        {
            cb = new ComboBox();
            cb = bc.ggdb.getCboStGoodsGroup(cb);
            setGrd();
            tC.TabPages[tabSum].Text = "Summary";
            //for (int i = 0; i < 10; i++)
            //{
            //    tC.TabPages[i + 1].Text = "";
            //}
            for (int i = 0; i < cb.Items.Count; i++)
            {
                TabPage tp = new TabPage();
                tp.Text = cb.GetItemText(cb.Items[i]);
                tC.TabPages.Add(tp);

                dgv[i] = new DataGridView();
                //tC.TabPages[i].(dgv);
                dgv[i].ResumeLayout();
                tp.Controls.Add(dgv[i]);
                dgv[i].Width = tC.TabPages[tabSum].Width - 10;
                dgv[i].Height = tC.TabPages[tabSum].Height - 30;
                dgv[i].Left = dgvSum.Left;
                dgv[i].Top = dgvSum.Left;
                dgv[i].BorderStyle = dgvSum.BorderStyle;
                dgv[i].CellBorderStyle = dgvSum.CellBorderStyle;
                dgv[i].DefaultCellStyle = dgvSum.DefaultCellStyle;
                dgv[i].RowHeadersDefaultCellStyle = dgvSum.RowHeadersDefaultCellStyle;
                dgv[i].RowHeadersWidth = dgvSum.RowHeadersWidth;
                //dgv[i].rowhe
                setGrd(i);
                //tC.Refresh();
                //tC.TabPages[i+1].Text = cb.GetItemText(cb.Items[i]);
                //tC.TabPages[i + 1].Show();
            }
            
            //TabPage tabpage
            //tC.TabPages.Remove( );
        }
        private void setGrd()
        {
            Font font = new Font("Microsoft Sans Serif", 12);
            DataTable dt = new DataTable();

            dgvSum.ColumnCount = colCnt;
            dgvSum.Rows.Clear();
            dgvSum.RowCount = 1;
            dgvSum.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSum.Columns[colCode].Width = 80;
            dgvSum.Columns[colNameT].Width = 300;
            dgvSum.Columns[colId].Width = 80;
            dgvSum.Columns[colRow].Width = 40;

            dgvSum.Columns[colRow].HeaderText = "no";
            dgvSum.Columns[colCode].HeaderText = "Code";
            dgvSum.Columns[colNameT].HeaderText = "Name";
            //dgvView.Columns[colNameT].HeaderText = "Name";
            dgvSum.Columns[colId].HeaderText = "";

            //dgv1.Columns[colPEWeight].HeaderText = "น้ำหนัก";
            //dt = bc.gooddb.selectAll();

            //dgvPE.Columns[colPEId].HeaderText = "id";
            if (dt.Rows.Count > 0)
            {
                dgvSum.RowCount = dt.Rows.Count;
                for (int i = 0; i < dgvSum.RowCount; i++)
                {
                    dgvSum[colRow, i].Value = (i + 1);
                    dgvSum[colCode, i].Value = dt.Rows[i][bc.gooddb.good.Code].ToString();
                    dgvSum[colNameT, i].Value = dt.Rows[i][bc.gooddb.good.NameT].ToString();
                    dgvSum[colId, i].Value = dt.Rows[i][bc.gooddb.good.Id].ToString();

                    if ((i % 2) != 0)
                    {
                        dgvSum.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }

            dgvSum.Font = font;
            dgvSum.Columns[colId].Visible = false;
        }
        private void setGrd(int tab)
        {
            Font font = new Font("Microsoft Sans Serif", 12);
            DataTable dt = new DataTable();

            dgv[tab].ColumnCount = colCnt;
            dgv[tab].Rows.Clear();
            dgv[tab].RowCount = 1;
            dgv[tab].SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv[tab].Columns[colCode].Width = 80;
            dgv[tab].Columns[colNameT].Width = 300;
            dgv[tab].Columns[colId].Width = 80;
            dgv[tab].Columns[colRow].Width = 40;

            dgv[tab].Columns[colRow].HeaderText = "no";
            dgv[tab].Columns[colCode].HeaderText = "Code";
            dgv[tab].Columns[colNameT].HeaderText = "Name";
            //dgvView.Columns[colNameT].HeaderText = "Name";
            dgv[tab].Columns[colId].HeaderText = "";

            //dgv1.Columns[colPEWeight].HeaderText = "น้ำหนัก";
            String aa = bc.getIdCboItemByText(cb, cb.Items[tab].ToString());
            dt = bc.gooddb.selectByGroup(aa);

            //dgvPE.Columns[colPEId].HeaderText = "id";
            if (dt.Rows.Count > 0)
            {
                dgv[tab].RowCount = dt.Rows.Count;
                for (int i = 0; i < dgv[tab].RowCount; i++)
                {
                    dgv[tab][colRow, i].Value = (i + 1);
                    dgv[tab][colCode, i].Value = dt.Rows[i][bc.gooddb.good.Code].ToString();
                    dgv[tab][colNameT, i].Value = dt.Rows[i][bc.gooddb.good.NameT].ToString();
                    dgv[tab][colId, i].Value = dt.Rows[i][bc.gooddb.good.Id].ToString();

                    if ((i % 2) != 0)
                    {
                        dgv[tab].Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }

            dgv[tab].Font = font;
            dgv[tab].Columns[colId].Visible = false;
        }
        private void setResize()
        {
            tC.Width = this.Width - 50;
            tC.Height = this.Height - 150;
            tC.TabPages[tabSum].Width = tC.Width - 10;
            tC.TabPages[tabSum].Height = tC.Height - 10;
            dgvSum.Width = tC.TabPages[tabSum].Width - 10;
            dgvSum.Height = tC.TabPages[tabSum].Height - 30;

            //tC.TabPages[tab1].Width = tC.Width - 10;
            //tC.TabPages[tab1].Height = tC.Height - 10;
            //tC.TabPages[tab2].Width = tC.Width - 10;
            //tC.TabPages[tab2].Height = tC.Height - 10;
            //tC.TabPages[tab3].Width = tC.Width - 10;
            //tC.TabPages[tab3].Height = tC.Height - 10;
            //tC.TabPages[tab4].Width = tC.Width - 10;
            //tC.TabPages[tab4].Height = tC.Height - 10;
            //tC.TabPages[tab5].Width = tC.Width - 10;
            //tC.TabPages[tab5].Height = tC.Height - 10;
            //tC.TabPages[tab6].Width = tC.Width - 10;
            //tC.TabPages[tab6].Height = tC.Height - 10;
            //tC.TabPages[tab7].Width = tC.Width - 10;
            //tC.TabPages[tab7].Height = tC.Height - 10;
            //tC.TabPages[tab8].Width = tC.Width - 10;
            //tC.TabPages[tab8].Height = tC.Height - 10;
            //tC.TabPages[tab9].Width = tC.Width - 10;
            //tC.TabPages[tab9].Height = tC.Height - 10;
            //tC.TabPages[tab10].Width = tC.Width - 10;
            //tC.TabPages[tab10].Height = tC.Height - 10;

            //dgv1.Width = tC.TabPages[tab1].Width - 10;
            //dgv1.Height = tC.TabPages[tab1].Height - 30;
            //dgv2.Width = tC.TabPages[tab2].Width - 10;
            //dgv2.Height = tC.TabPages[tab2].Height - 30;
            //dgv3.Width = tC.TabPages[tab3].Width - 10;
            //dgv3.Height = tC.TabPages[tab3].Height - 30;
            //dgv4.Width = tC.TabPages[tab4].Width - 10;
            //dgv4.Height = tC.TabPages[tab4].Height - 30;
            //dgv5.Width = tC.TabPages[tab5].Width - 10;
            //dgv5.Height = tC.TabPages[tab5].Height - 30;
            //dgv6.Width = tC.TabPages[tab6].Width - 10;
            //dgv6.Height = tC.TabPages[tab6].Height - 30;
            //dgv7.Width = tC.TabPages[tab7].Width - 10;
            //dgv7.Height = tC.TabPages[tab7].Height - 30;
            //dgv8.Width = tC.TabPages[tab8].Width - 10;
            //dgv8.Height = tC.TabPages[tab8].Height - 30;
            //dgv9.Width = tC.TabPages[tab9].Width - 10;
            //dgv9.Height = tC.TabPages[tab9].Height - 30;
            //dgv10.Width = tC.TabPages[tab10].Width - 10;
            //dgv10.Height = tC.TabPages[tab10].Height - 30;

            //dgv1.Left = dgvSum.Left;
            //dgv1.Top = dgvSum.Left;
            //dgv2.Left = dgvSum.Left;
            //dgv2.Top = dgvSum.Left;
            //dgv3.Left = dgvSum.Left;
            //dgv3.Top = dgvSum.Left;
            //dgv4.Left = dgvSum.Left;
            //dgv4.Top = dgvSum.Left;
            //dgv5.Left = dgvSum.Left;
            //dgv5.Top = dgvSum.Left;
            //dgv6.Left = dgvSum.Left;
            //dgv6.Top = dgvSum.Left;
            //dgv7.Left = dgvSum.Left;
            //dgv7.Top = dgvSum.Left;
            //dgv8.Left = dgvSum.Left;
            //dgv8.Top = dgvSum.Left;
            //dgv9.Left = dgvSum.Left;
            //dgv9.Top = dgvSum.Left;
            //dgv10.Left = dgvSum.Left;
            //dgv10.Top = dgvSum.Left;
            //dgvSum.Width = this.Width - 80;
            //dgvSum.Height = this.Height - 150;
            btnAdd.Left = dgvSum.Width - 50;
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
            if (dgvSum[colId, e.RowIndex].Value == null)
            {
                return;
            }
            bc.lw.WriteLog("FrmStGoodsView.dgvView_CellDoubleClick ");
            //bc.vnSearch = dgv1[colVn, e.RowIndex].Value.ToString();
            //bc.hnSearch = dgv1[colHN, e.RowIndex].Value.ToString();
            //bc.vs.HN = dgv1[colHN, e.RowIndex].Value.ToString();
            //bc.vs.VN = dgv1[colVn, e.RowIndex].Value.ToString();
            //bc.vs.PatientName = dgv1[colName, e.RowIndex].Value.ToString();

            FrmStGoodsAdd frm = new FrmStGoodsAdd(bc, dgvSum[colId, e.RowIndex].Value.ToString());
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
            setGrd();
        }
    }
}
