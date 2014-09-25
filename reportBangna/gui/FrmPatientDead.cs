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
    public partial class FrmPatientDead : Form
    {
        //Config1 cf;
        BangnaControl bc;
        int colRow = 0, colVisitDate = 1, colDSDate = 2, colHN = 3, colName = 4, colAdmitNo = 5, colDia = 6, colDG1 = 7, colCause1=8, colDG2 = 9, colCause2=10, colDG3 = 11;
        int colCause3 = 12, colDG4 = 13, colCause4 = 14, colFlag=15, colSort=16;
        int colCnt = 17;
        public FrmPatientDead()
        {
            InitializeComponent();
            initConfig();
        }
        private void initConfig()
        {
            //cf = new Config1();
            bc = new BangnaControl();
            setHGrd();
        }
        private void setHGrd()
        {
            dgvView.ColumnCount = colCnt;
            dgvView.Rows.Clear();
            //dgvView.RowCount = cnt + 1;
            dgvView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvView.Columns[colRow].Width = 50;
            dgvView.Columns[colVisitDate].Width = 100;
            dgvView.Columns[colDSDate].Width = 100;
            dgvView.Columns[colHN].Width = 85;
            dgvView.Columns[colName].Width = 300;
            dgvView.Columns[colAdmitNo].Width = 125;
            dgvView.Columns[colDia].Width = 120;
            dgvView.Columns[colDG1].Width = 120;
            dgvView.Columns[colCause1].Width = 300;
            dgvView.Columns[colDG2].Width = 50;
            dgvView.Columns[colCause2].Width = 50;
            dgvView.Columns[colDG3].Width = 50;
            dgvView.Columns[colCause3].Width = 50;
            dgvView.Columns[colDG4].Width = 50;
            dgvView.Columns[colCause4].Width = 50;
            dgvView.Columns[colFlag].Width = 50;

            //dgvAdd.Columns[colAmount].Width = 120;

            dgvView.Columns[colRow].HeaderText = "ลำดับ";
            dgvView.Columns[colVisitDate].HeaderText = "วันที่เข้า";
            dgvView.Columns[colDSDate].HeaderText = "วันที่ออก";
            dgvView.Columns[colHN].HeaderText = "HN";
            dgvView.Columns[colName].HeaderText = "ชื่อ-นามสกุล";
            dgvView.Columns[colAdmitNo].HeaderText = "AN";
            dgvView.Columns[colDia].HeaderText = "DIA Dead";
            dgvView.Columns[colDG1].HeaderText = "DG1";
            dgvView.Columns[colCause1].HeaderText = "Cause1";
            dgvView.Columns[colDG2].HeaderText = "DG2";
            dgvView.Columns[colCause2].HeaderText = "Cause2";
            dgvView.Columns[colDG3].HeaderText = "DG2";
            dgvView.Columns[colCause3].HeaderText = "Cause3";
            dgvView.Columns[colDG4].HeaderText = "DIA1";
            dgvView.Columns[colCause4].HeaderText = "Cause4";
            dgvView.Columns[colFlag].HeaderText = " ";

            dgvView.Columns[colSort].Visible = false;
            Font font = new Font("Microsoft Sans Serif", 10);
            dgvView.Font = font;

        }
        private void setGrd()
        {
            
            String dateStart = dtpStart.Value.Year.ToString() + "-" + dtpStart.Value.ToString("MM-dd");
            String dateEnd = dtpEnd.Value.Year.ToString() + "-" + dtpEnd.Value.ToString("MM-dd");
            DataTable dt = bc.selectPatientDead(dateStart, dateEnd);
            if (dt.Rows.Count > 0)
            {
                dgvView.RowCount = dt.Rows.Count;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvView[colRow, i].Value = (i + 1);
                    dgvView[colVisitDate, i].Value = bc.cf.dateDBtoShow((DateTime)dt.Rows[i]["MNC_AD_DATE"]);
                    dgvView[colDSDate, i].Value = bc.cf.dateDBtoShow((DateTime)dt.Rows[i]["MNC_DS_DATE"]);
                    dgvView[colHN, i].Value = dt.Rows[i]["mnc_hn_no"].ToString();
                    dgvView[colName, i].Value = dt.Rows[i]["MNC_PFIX_DSC"].ToString() + "  " + dt.Rows[i]["MNC_FNAME_T"].ToString() + " " + dt.Rows[i]["MNC_LNAME_T"].ToString();
                    dgvView[colAdmitNo, i].Value = dt.Rows[i]["MNC_AN_NO"].ToString();
                    dgvView[colDia, i].Value = dt.Rows[i]["MNC_DIA_DEAD"].ToString();
                    dgvView[colCause1, i].Value = dt.Rows[i]["MNC_DIA_DSC_E"].ToString();
                    dgvView[colFlag, i].Value = dt.Rows[i]["flag"].ToString();
                    dgvView[colSort, i].Value = bc.cf.dateShowtoDB(bc.cf.dateDBtoShow((DateTime)dt.Rows[i]["MNC_AD_DATE"])).Replace("-","");
                    if ((i % 2) != 0)
                    {
                        dgvView.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                }
                dgvView.Sort(dgvView.Columns[colSort], ListSortDirection.Ascending);
            }
        }
        private void setResize()
        {
            dgvView.Width = this.Width - 50;
            dgvView.Height = this.Height - 200;
        }

        private void FrmPatientDead_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            setGrd();
        }

        private void FrmPatientDead_Resize(object sender, EventArgs e)
        {
            setResize();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            //pB1.Show();
            Microsoft.Office.Interop.Excel.Application excelapp = new Microsoft.Office.Interop.Excel.Application();
            excelapp.Visible = false;
            String visitDate = "", visitTime = "", err = "", err1 = "", pharName = "";

            Microsoft.Office.Interop.Excel._Workbook workbook = (Microsoft.Office.Interop.Excel._Workbook)(excelapp.Workbooks.Add(Type.Missing));
            Microsoft.Office.Interop.Excel._Worksheet worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.ActiveSheet;
            //pB1.Minimum = 0;
            //pB1.Maximum = dgvAdd.Rows.Count;
            //worksheet.Cells[0, 0] = "patient name";
            for (int i = 0; i < dgvView.Rows.Count; i++)
            {
                try
                {
                    worksheet.Cells[i+1, colVisitDate] = dgvView[colVisitDate, i].Value.ToString();
                    worksheet.Cells[i + 1, colDSDate] = dgvView[colDSDate, i].Value.ToString();
                    //err = "001 " + dgvView[colPatientHnno, i].Value.ToString();
                    //worksheet.Cells[i, colDate] = dgvAdd[colDate, i].Value.ToString();
                    //worksheet.Cells[i, colTime] = dgvAdd[colTime, i].Value.ToString();
                    worksheet.Cells[i + 1, colHN] = bc.cf.stringNull(dgvView[colHN, i].Value.ToString());


                    err = "003 Chronic ";
                    worksheet.Cells[i + 1, colName] = bc.cf.stringNull1(dgvView[colName, i].Value);
                    worksheet.Cells[i + 1, colAdmitNo] = bc.cf.stringNull1(dgvView[colAdmitNo, i].Value);
                    worksheet.Cells[i + 1, colDia] = bc.cf.stringNull1(dgvView[colDia, i].Value);

                    worksheet.Cells[i + 1, colDG1] = bc.cf.stringNull1(dgvView[colDG1, i].Value);
                    worksheet.Cells[i + 1, colCause1] = bc.cf.stringNull1(dgvView[colCause1, i].Value);
                    worksheet.Cells[i + 1, colDG2] = bc.cf.stringNull1(dgvView[colDG2, i].Value);
                    worksheet.Cells[i + 1, colCause2] = bc.cf.stringNull1(dgvView[colCause2, i].Value);
                    worksheet.Cells[i + 1, colDG3] = bc.cf.stringNull1(dgvView[colDG3, i].Value);

                    worksheet.Cells[i + 1, colCause3] = bc.cf.stringNull1(dgvView[colCause3, i].Value);
                    worksheet.Cells[i + 1, colDG4] = bc.cf.stringNull1(dgvView[colDG4, i].Value);
                    worksheet.Cells[i + 1, colCause4] = bc.cf.stringNull1(dgvView[colCause4, i].Value);
                    worksheet.Cells[i + 1, colFlag] = bc.cf.stringNull1(dgvView[colFlag, i].Value);
                    
                    //pB1.Value = i;
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error " + ex.Message + "\n row " + i, "error " + err);
                }
                if (dgvView[colHN, i].Value == null)
                {
                    continue;
                }

            }


            //worksheet.Cells[1, 1] = "Name";
            //worksheet.Cells[1, 2] = "Bid";

            //worksheet.Cells[2, 1] = txbName.Text;
            //worksheet.Cells[2, 2] = txbResult.Text;
            //pB1.Hide();
            excelapp.UserControl = true;
            excelapp.Visible = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            String sql = "";
            //OleDbDataAdapter da = new OleDbDataAdapter();
            String dateStart = dtpStart.Value.Year.ToString() + "-" + dtpStart.Value.ToString("MM-dd");
            String dateEnd = dtpEnd.Value.Year.ToString() + "-" + dtpEnd.Value.ToString("MM-dd");
            DataTable dt = bc.selectPatientDead(dateStart, dateEnd);
            //MOU mo = cc.modb.selectByPk(txtMOUId.Text);
            //mo.ContactName = "เรียน :  " + mo.ContactName;
            //mo.CustAddress = "ที่อยู่ :   " + mo.CustAddress;
            //mo.CustTel = "เบอร์โทร : " + mo.CustTel + " Mobile : " + mo.CustMobile;
            //mo.CustEmail = " Email : " + mo.CustEmail;
            //mo.Line1 = cc.cp.mouLine1;
            //mo.QuoNumber = "เลขที่ : " + mo.MOUNumber + "-" + mo.MOUNumberCnt;
            //mo.DatePeriod = "วันที่ :  " + mo.DatePeriod;
            //mo.StaffQuoName = "ผู้เสนอราคา :  " + mo.StaffQuoName;
            //mo.StaffMOUTel = "เบอร์โทร : " + mo.StaffMOUTel + " Mobile : " + mo.StaffMOUMobile;
            //mo.StaffMOUEmail = "Email : " + mo.StaffMOUEmail;
            //mo.MOUNumber = "เลขที่ : " + mo.MOUNumber + "-" + mo.MOUNumberCnt;
            
            FrmReport1 frm = new FrmReport1(bc);
            frm.setReportPatientDead(dt);
            frm.ShowDialog(this);
        }
    }
}
