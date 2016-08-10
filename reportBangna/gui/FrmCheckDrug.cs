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
    public partial class FrmCheckDrug : Form
    {
        int colRow = 0, colCode = 1, colOldCode=2, colNameDrug = 3, colPrice = 4;
        
        int colCnt = 5;
        BangnaControl bc;
        public FrmCheckDrug()
        {
            InitializeComponent();
            initConfig();
        }

        private void FrmCheckDrug_Resize(object sender, EventArgs e)
        {
            setResize();
        }

        private void initConfig()
        {
            //labexdb = new LabExDB();
            //vsdb = new VisitDB();
            //vs = new Visit();
            bc = new BangnaControl();
            setGrd();
        }

        private void FrmCheckDrug_Load(object sender, EventArgs e)
        {

        }

        private void setGrd()
        {
            Font font = new Font("Microsoft Sans Serif", 12);
            DataTable dt = new DataTable();
            DateTime dt1 = new DateTime();
            String visitDate = "", visitTime = "", hn = "";
            //hn = txtSearch.Text;
            //if (hn.Equals(""))
            //{
            //    hn = "@";
            //}
            dt = bc.selectCHeckDrug(txtSearch.Text);

            dgv1.ColumnCount = colCnt;
            dgv1.Rows.Clear();
            dgv1.RowCount = 1;
            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv1.Columns[colRow].Width = 50;
            dgv1.Columns[colCode].Width = 100;
            dgv1.Columns[colOldCode].Width = 100;
            dgv1.Columns[colNameDrug].Width = 400;
            dgv1.Columns[colPrice].Width = 120;


            dgv1.Columns[colRow].HeaderText = "ลำดับ";
            dgv1.Columns[colCode].HeaderText = "รหัส";
            dgv1.Columns[colNameDrug].HeaderText = "ชื่อ";
            dgv1.Columns[colPrice].HeaderText = "ราคา";
            dgv1.Columns[colOldCode].HeaderText = "รหัสเก่า";

            //dgvPE.Columns[colPEId].HeaderText = "id";
            if (dt.Rows.Count > 0)
            {
                dgv1.RowCount = dt.Rows.Count;
                for (int i = 0; i < dgv1.RowCount; i++)
                {
                    dgv1[colRow, i].Value = (i + 1);
                    dgv1[colCode, i].Value = dt.Rows[i]["MNC_ph_cd"].ToString();
                    dgv1[colNameDrug, i].Value = dt.Rows[i]["MNC_ph_tn"].ToString();
                    dgv1[colOldCode, i].Value = dt.Rows[i]["MNC_old_cd"].ToString();
                    dgv1[colPrice, i].Value = String.Format("{0:#,###,###.00}", dt.Rows[i]["mnc_ph_pri01"]); //dt.Rows[i]["mnc_ph_pri01"].ToString() ;
                    
                    
                    if ((i % 2) != 0)
                    {
                        dgv1.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
                dgv1.Font = font;
            }
            //dgv1.Columns[colLabReqNo].Visible = false;
            //dgv1.Columns[colDoctorId].Visible = false;
            //dgv1.Columns[colLabReqNo].Visible = false;
            //dgv1.Columns[colLabReqNo].Visible = false;
            dgv1.ScrollBars = ScrollBars.Both;
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length >= 3)
            {
                setGrd();
            }
            else if (txtSearch.Text.Equals(""))
            {
                setGrd();
            }
        }
        private void setResize()
        {
            dgv1.Width = this.Width - 50;
            dgv1.Height = this.Height - 150;
            groupBox1.Width = this.Width - 50;
            //pB1.Width = this.Width - 900;
        }
    }
}
