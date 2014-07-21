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
    public partial class FrmHosRiskView : Form
    {
        HosRiskDB hrdb;
        int colRow = 0, colId = 1, colInformDeptRisk = 2, colDeptRisk = 3, colDateRisk = 4, colName = 5, colImportanceLevel = 6;
        int colCnt = 7;
        Config1 cf;
        public FrmHosRiskView()
        {
            InitializeComponent();
            initConfig();
            
        }
        private void initConfig()
        {
            String monthId = "";
            hrdb = new HosRiskDB();
            cf = new Config1();
            monthId = System.DateTime.Now.Month.ToString("00");
            cboMonth = cf.setCboMonth(cboMonth);
            cboYear = cf.setCboYear(cboYear);
            cboMonth.SelectedValue = monthId;
            setGrd();
        }
        private void setResize()
        {
            dgvView.Width = this.Width - 50;
            dgvView.Height = this.Height - 150;

            groupBox1.Width = this.Width - 50;
            //groupBox1.Height = this.Height = 150;
        }
        private void setGrd()
        {
            DataTable dt = new DataTable();
            dt = hrdb.selectByMonthYear(cboYear.Text, cboMonth.SelectedValue.ToString());

            dgvView.Rows.Clear();
            Font font = new Font("Microsoft Sans Serif", 12);
            dgvView.Font = font;
            dgvView.ColumnCount = colCnt;
            dgvView.RowCount = 1;
            //row = 0;
            dgvView.Columns[colRow].Width = 80;
            dgvView.Columns[colId].Width = 80;
            dgvView.Columns[colName].Width = 200;
            dgvView.Columns[colInformDeptRisk].Width = 200;
            dgvView.Columns[colDeptRisk].Width = 200;
            dgvView.Columns[colDateRisk].Width = 150;
            dgvView.Columns[colImportanceLevel].Width = 140;
            dgvView.Columns[colName].HeaderText = "ผู้ได้รับอุบัติการณ์ ";
            dgvView.Columns[colImportanceLevel].HeaderText = "ระดับความสำคัญ";
            dgvView.Columns[colInformDeptRisk].HeaderText = "หน่วยงานรายงานความเสี่ยง";
            dgvView.Columns[colDeptRisk].HeaderText = "หน่วยงานที่เกิดความเสี่ยง";
            dgvView.Columns[colDateRisk].HeaderText = "วันที่เกิดเหตุการณ์";
            
            dgvView.Columns[colId].Visible = false;
            //dgvView.Columns[colLottoId1].Visible = false;
            //dgvView.Columns[colRemark].Visible = false;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvView[colRow, i].Value = (i + 1);
                    dgvView[colId, i].Value = dt.Rows[i][hrdb.hr.Id].ToString();
                    dgvView[colName, i].Value = dt.Rows[i][hrdb.hr.firstName].ToString();
                    dgvView[colImportanceLevel, i].Value = dt.Rows[i][hrdb.hr.ImportanceLevel].ToString();
                    dgvView[colInformDeptRisk, i].Value = dt.Rows[i][hrdb.hr.informDeptRisk].ToString();
                    dgvView[colDeptRisk, i].Value = dt.Rows[i][hrdb.hr.deptRisk].ToString();
                    dgvView[colDateRisk, i].Value = cf.dateDBtoShow(dt.Rows[i][hrdb.hr.dateRisk].ToString());
                    //if (dt.Rows[i][lc.sfdb.sf.Priority].ToString().Equals("1"))
                    //{
                    //    dgvView[colPriority, i].Value = "ป้อนรางวัลอย่างเดียว";
                    //}
                    //else if (dt.Rows[i][lc.sfdb.sf.Priority].ToString().Equals("2"))
                    //{
                    //    dgvView[colPriority, i].Value = "ตรวจสอบข้อมูลอย่างเดียว";
                    //}
                    //else if (dt.Rows[i][lc.sfdb.sf.Priority].ToString().Equals("3"))
                    //{
                    //    dgvView[colPriority, i].Value = "ทุกหน้าจอ";
                    //}
                    //dgvView[colPassword, i].Value = "รหัสผ่าน";
                    if ((i % 2) != 0)
                    {
                        dgvView.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
        }
        private void FrmHosRiskView_Load(object sender, EventArgs e)
        {

        }
        private void FrmHosRiskView_Resize(object sender, EventArgs e)
        {
            setResize();
        }
    }
}
