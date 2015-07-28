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
    public partial class FrmDischargeVnView : Form
    {
        BangnaControl bc;
        //VisitDB vsdb;
        Visit vs;

        int tabDrug = 0, tabSupp = 1, tabLab = 2, tabOther = 3;
        private void initConfig()
        {
            //bc = new BangnaControl();
            //vsdb = new VisitDB();
            //vs = new Visit();

            tC.TabPages[tabDrug].Text = "ยา";
            tC.TabPages[tabSupp].Text = "เวชภัณฑ์";
            tC.TabPages[tabLab].Text = "LAB";
            tC.TabPages[tabOther].Text = "อื่นๆ";

            setControl(vs);
        }
        private void setControl(Visit v)
        {
            txtHN.Text = v.HN;
            txtPatientName.Text = v.PatientName;
            txtPatientAge.Text = v.Age;
            txtSymptom.Text = v.symptom;
            txtVisitDate.Text = v.VisitDate;
            setGrdDrug();
        }
        private void setGrdDrug()
        {
            Font font = new Font("Microsoft Sans Serif", 12);
            int colRow=0,colCode = 1, colName = 2, colPrice = 3,colQty=4, colAmt = 5, colCnt=6;
            DataTable dt = new DataTable();
            dt = bc.vsdb.selectDrug(vs.HN, vs.vn, vs.preno);
            dgvDrug.ColumnCount = colCnt;
            dgvDrug.Rows.Clear();
            dgvDrug.RowCount = 1;
            dgvDrug.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDrug.Columns[colCode].Width = 50;
            dgvDrug.Columns[colName].Width = 80;
            dgvDrug.Columns[colPrice].Width = 80;
            dgvDrug.Columns[colAmt].Width = 220;

            dgvDrug.Columns[colCode].HeaderText = "รหัส";
            dgvDrug.Columns[colName].HeaderText = "ชื่อยา";
            dgvDrug.Columns[colPrice].HeaderText = "ราคา";
            dgvDrug.Columns[colQty].HeaderText = "จำนวน";
            dgvDrug.Columns[colAmt].HeaderText = "รวมราคา";

            //dgvPE.Columns[colPEId].HeaderText = "id";
            if (dt.Rows.Count > 0)
            {
                dgvDrug.RowCount = dt.Rows.Count;
                for (int i = 0; i < dgvDrug.RowCount; i++)
                {
                    dgvDrug[colRow, i].Value = (i + 1);
                    dgvDrug[colCode, i].Value = dt.Rows[i]["MNC_PH_CD"].ToString();
                    dgvDrug[colName, i].Value = dt.Rows[i]["MNC_PH_TN"].ToString();
                    dgvDrug[colPrice, i].Value = dt.Rows[i]["MNC_PH_PRI01"].ToString();
                    dgvDrug[colQty, i].Value = dt.Rows[i]["qty"].ToString();
                    dgvDrug[colAmt, i].Value = dt.Rows[i]["MNC_PH_PRI01"].ToString();
                    
                    if ((i % 2) != 0)
                    {
                        dgvDrug.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }

            dgvDrug.Font = font;
            //dgvDrug.Columns[colId].Visible = false;
        }
        public FrmDischargeVnView(BangnaControl b, Visit v)
        {
            InitializeComponent();
            bc = b;
            vs = v;
            initConfig();
        }

        private void FrmDischargeVnView_Load(object sender, EventArgs e)
        {

        }
    }
}
