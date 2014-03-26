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
    public partial class FrmCertificatesView : Form
    {
        CertificatesChildDB cCdb;
        CertificatesChild cC;
        Config1 config1;
        private void initConfig()
        {
            cCdb = new CertificatesChildDB();
            config1 = new Config1();
            cC = new CertificatesChild();
        }
        public FrmCertificatesView()
        {
            InitializeComponent();
            initConfig();
            config1.setCboMonth(cboMonth);
            config1.setCboYear(cboYear);
            setData(cboYear.Text, cboMonth.Text);
        }
        public void setData(String year, String monthName)
        {
            DataTable dt = new DataTable();
            dt = cCdb.selectByYearMonth(year, monthName);
            dgvView.ColumnCount = 8;
           
            dgvView.RowCount = dt.Rows.Count+1;
            dgvView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dt.Rows.Count > 0)
            {
                dgvView.Columns[0].Width  = 40;
                dgvView.Columns[1].Width = 15;
                dgvView.Columns[2].Width = 200;
                dgvView.Columns[3].Width = 200;
                dgvView.Columns[4].Width = 200;
                dgvView.Columns[5].Width = 120;
                dgvView.Columns[6].Width = 80;
                dgvView.Columns[7].Width = 80;
                dgvView.Columns[0].HeaderText = "ลำดับ";
                dgvView.Columns[1].HeaderText = "id";
                dgvView.Columns[2].HeaderText = "ชื่อ-นามสกุล";
                dgvView.Columns[3].HeaderText = "บิดา";
                dgvView.Columns[4].HeaderText = "มารดา";
                dgvView.Columns[5].HeaderText = "วัน-เดือน-ปี เกิด";
                dgvView.Columns[6].HeaderText = "เวลา เกิด";
                dgvView.Columns[7].HeaderText = "น้ำหนัก";
                dgvView.Columns[1].Visible = false;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvView[0, i].Value = (i + 1);
                    dgvView[1, i].Value = dt.Rows[i][cCdb.cC.certifiId].ToString();
                    dgvView[2, i].Value = dt.Rows[i][cCdb.cC.childName].ToString() + " " + dt.Rows[i][cCdb.cC.childSurname].ToString();
                    dgvView[3, i].Value = dt.Rows[i][cCdb.cC.fatherName].ToString() + " " + dt.Rows[i][cCdb.cC.fatherSurname].ToString();
                    dgvView[4, i].Value = dt.Rows[i][cCdb.cC.motherName].ToString()+" " +dt.Rows[i][cCdb.cC.motherSurname].ToString();
                    dgvView[5, i].Value = dt.Rows[i][cCdb.cC.birthDayDate].ToString();
                    dgvView[6, i].Value = dt.Rows[i][cCdb.cC.birthDayTime].ToString();
                    dgvView[7, i].Value = dt.Rows[i][cCdb.cC.childWeigth].ToString();
                    if ((i % 2) != 0)
                    {
                        dgvView.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
        }
        private void setResize()
        {
            dgvView.Width = this.Width - 50;
            dgvView.Height = this.Height - 150;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmCertificatesAdd frm = new FrmCertificatesAdd();
            frm.setCertifiChild("");
            frm.ShowDialog(this);
            setData(cboYear.Text, cboMonth.Text);
        }

        private void dgvView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmCertificatesAdd frm = new FrmCertificatesAdd();
            frm.setCertifiChild(dgvView[1,e.RowIndex].Value.ToString());
            this.Hide();
            frm.ShowDialog(this);
            setData(cboYear.Text, cboMonth.Text);
            this.Show();
            //this.Hide();
            //dgvView.Columns[0].v
        }

        private void FrmCertificatesView_Load(object sender, EventArgs e)
        {

        }

        private void FrmCertificatesView_Resize(object sender, EventArgs e)
        {
            setResize();
        }

        private void dgvView_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void FrmCertificatesView_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

    }
}
