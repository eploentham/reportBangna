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
    public partial class FrmChkStaffNote : Form
    {
        Config1 config1;
        ChkStaffNoteDB sndb;
        ChkStaffNote sn;
        int colRow=0,colHn = 1, colName=2, colVn = 3, colDep=4, colPaid=5, colStatus=8, colRemark=6, colVoid=7, colId=9;
        private void initConfig()
        {            
            config1 = new Config1();
            sndb = new ChkStaffNoteDB();
            sn = new ChkStaffNote();
            setControl();
        }
        private void clearControl()
        {
            labePatientName.Text = "";
            labelPaidName.Text = "";
            labelDep.Text = "";
            txtHn.Text = "";
            txtVn.Text = "";
            chkReeiveStaffNote.Checked = false;
        }
        private void setControl()
        {
            labePatientName.Text = "";
            labelPaidName.Text = "";
            labelDep.Text = "";
        }
        private void setSearch()
        {
            String dateSearch = "", vn = "", sql = "";
            DataTable dt = new DataTable();
            setControl();
            dateSearch = dtpDateSearch.Value.Year.ToString() + "-" + dtpDateSearch.Value.ToString("MM-dd");
            if ((txtHn.Text != "") && (txtVn.Text ==""))
            {
                dt = sndb.selectMainHisByDateHn(dateSearch, txtHn.Text.Trim());
                if (dt.Rows.Count == 1)
                {
                    labePatientName.Text = dt.Rows[0][sndb.sn.MNC_PFIX_DSC].ToString() + " " + dt.Rows[0][sndb.sn.MNC_FNAME_T].ToString() + " " + dt.Rows[0][sndb.sn.MNC_LNAME_T].ToString();
                    labelPaidName.Text = dt.Rows[0][sndb.sn.MNC_FN_TYP_DSC].ToString();
                    labelDep.Text = dt.Rows[0][sndb.sn.MNC_MD_DEP_DSC].ToString();
                    txtVn.Text = dt.Rows[0][sndb.sn.vn].ToString();
                    chkReeiveStaffNote.Focus();
                }
                else
                {
                    txtVn.Text = "";
                    dgvView.RowCount = dt.Rows.Count + 1;
                    setdgvHeader();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        vn = dt.Rows[i][sndb.sn.vn].ToString();
                        vn = vn.Replace("/", ".");
                        vn = vn.Replace("(", ".");
                        vn = vn.Replace(")", "");
                        if (dt.Rows[i][sndb.sn.vn].ToString() == "150/1(1)")
                        {
                            sql = "";
                        }
                        ChkStaffNote sn = sndb.selectByHnVn(dt.Rows[i][sndb.sn.MNC_HN_NO].ToString(), dt.Rows[i][sndb.sn.vn].ToString(), dateSearch);
                        dgvView[colRow, i].Value = (i + 1);
                        dgvView[colHn, i].Value = dt.Rows[i][sndb.sn.MNC_HN_NO].ToString();
                        dgvView[colName, i].Value = dt.Rows[i][sndb.sn.MNC_PFIX_DSC].ToString() + " " + dt.Rows[i][sndb.sn.MNC_FNAME_T].ToString() + " " + dt.Rows[i][sndb.sn.MNC_LNAME_T].ToString();
                        dgvView[colVn, i].Value = dt.Rows[i][sndb.sn.vn].ToString();
                        dgvView[colDep, i].Value = dt.Rows[i][sndb.sn.MNC_MD_DEP_DSC].ToString();
                        dgvView[colPaid, i].Value = config1.shortPaidName(dt.Rows[i][sndb.sn.MNC_FN_TYP_DSC].ToString());
                        dgvView[colRemark, i].Value = sn.remark;
                        dgvView[colId, i].Value = sn.staffNoteId;
                        if (sn.staffNoteId != "" && sn.statusActive == "1" && sn.statusReceive == "1")
                        {
                            dgvView.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            if ((i % 2) != 0)
                            {
                                dgvView.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                            }
                        }
                    }
                }
            }
            else if ((txtHn.Text != "") && (txtVn.Text != ""))
            {
                sn = sndb.selectStaffNoteMainHisHnVn(txtHn.Text.Trim(), txtVn.Text.Trim(), dateSearch);
                labePatientName.Text = sn.MNC_PFIX_DSC.ToString() + " " + sn.MNC_FNAME_T.ToString() + " " + sn.MNC_LNAME_T.ToString();
                labelPaidName.Text = sn.MNC_FN_TYP_DSC.ToString();
                labelDep.Text = sn.MNC_MD_DEP_DSC.ToString();
                txtVn.Text = sn.vn.ToString();
                chkReeiveStaffNote.Focus();
            }
        }
        private void setdgvHeader()
        {
            dgvView.ColumnCount = 10;
            dgvView.Columns[colRow].Width = 40;
            dgvView.Columns[colHn].Width = 80;
            dgvView.Columns[colName].Width = 200;
            dgvView.Columns[colVn].Width = 80;
            dgvView.Columns[colDep].Width = 80;
            dgvView.Columns[colPaid].Width = 100;
            dgvView.Columns[colStatus].Width = 220;
            dgvView.Columns[colRemark].Width = 220;
            dgvView.Columns[colVoid].Width = 70;
            dgvView.Columns[colId].Width = 50;

            dgvView.Columns[colRow].HeaderText = "ลำดับ";
            dgvView.Columns[colHn].HeaderText = "HN";
            dgvView.Columns[colName].HeaderText = "ชื่อ-นามสกุล";
            dgvView.Columns[colVn].HeaderText = "VN";
            dgvView.Columns[colDep].HeaderText = "แผนก";
            dgvView.Columns[colPaid].HeaderText = "สิทธิ";
            dgvView.Columns[colStatus].HeaderText = "สถานะ";
            dgvView.Columns[colRemark].HeaderText = "หมายเหตุ";
            dgvView.Columns[colVoid].HeaderText = "ยกเลิก";
            dgvView.Columns[colId].HeaderText = "id";
            dgvView.Columns[colId].Visible = false;
        }
        private void setData(String visitHn, String visitVn, String dateSearch)
        {
            //dateSearch = dtpDateSearch.Value.Year.ToString() + "-" + dtpDateSearch.Value.ToString("MM-dd");
            sn = sndb.selectByHnVn(visitHn, visitVn, dateSearch);
            dgvView.RowCount = 2;
            setdgvHeader();
            dgvView[colRow, 0].Value = 1;
            dgvView[colHn, 0].Value = sn.MNC_HN_NO;
            dgvView[colName, 0].Value = sn.MNC_PFIX_DSC + " " + sn.MNC_FNAME_T + " " + sn.MNC_LNAME_T;
            dgvView[colVn, 0].Value = sn.vn;
            dgvView[colDep, 0].Value = sn.MNC_MD_DEP_DSC;
            dgvView[colPaid, 0].Value = sn.MNC_FN_TYP_DSC;
        }
        public FrmChkStaffNote()
        {
            InitializeComponent();
            initConfig();
        }
        private void setResize()
        {
            dgvView.Width = this.Width - 50;
            dgvView.Height = this.Height - 200;
        }
        private void setSaveStaffNote()
        {
            //String hn = "";
            //if (txtHn.Text.Trim().Length == 5)
            //{
            //    hn = "50" + txtHn.Text.Trim();
            //}
            //else
            //{
            //    hn = txtHn.Text.Trim();
            //}
            if (chkReeiveStaffNote.Checked)
            {
                sn.statusReceive = "1";
            }
            else
            {
                sn.statusReceive = "3";
            }
            sn.statusActive = "1";
            if(sndb.insertStaffNote(sn)=="1")
            {
                String dateSearch = "";
                dateSearch = dtpDateSearch.Value.Year.ToString() + "-" + dtpDateSearch.Value.ToString("MM-dd");
                setData(txtHn.Text.Trim(), txtVn.Text.Trim(), dateSearch);
                clearControl();
                txtHn.Focus();
            }
        }
        private void setdgvView()
        {
            Cursor.Current = Cursors.WaitCursor; 
            String dateStart = "", vn = "";

            dateStart = dtpDate.Value.Year.ToString() + "-" + dtpDate.Value.ToString("MM-dd");
            if (chkAll.Checked)
            {
                setViewAll(dateStart);
            }
            else if (chkReceive.Checked)
            {
                setViewRceive(dateStart);
            }
            else if (chNoReceive.Checked)
            {
                setViewNoReceive(dateStart);
            }
            Cursor.Current = Cursors.Default;
        }

        private void setViewAll(String dateStart)
        {
            dgvView.Rows.Clear();
            String vn = "", sql="";
            DataTable dt = new DataTable();
            dt = sndb.selectStaffNoteMainHisDate(dateStart, dateStart);
            if (dt.Rows.Count > 0)
            {
                dgvView.RowCount = dt.Rows.Count + 1;
                setdgvHeader();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    vn = dt.Rows[i][sndb.sn.vn].ToString();
                    vn = vn.Replace("/", ".");
                    vn = vn.Replace("(", ".");
                    vn = vn.Replace(")", "");
                    if (dt.Rows[i][sndb.sn.vn].ToString() == "150/1(1)")
                    {
                        sql = "";
                    }
                    ChkStaffNote sn = sndb.selectByHnVn(dt.Rows[i][sndb.sn.MNC_HN_NO].ToString(), dt.Rows[i][sndb.sn.vn].ToString(), dateStart);
                    dgvView[colRow, i].Value = (i + 1);
                    dgvView[colHn, i].Value = dt.Rows[i][sndb.sn.MNC_HN_NO].ToString();
                    dgvView[colName, i].Value = dt.Rows[i][sndb.sn.MNC_PFIX_DSC].ToString() + " " + dt.Rows[i][sndb.sn.MNC_FNAME_T].ToString() + " " + dt.Rows[i][sndb.sn.MNC_LNAME_T].ToString();
                    dgvView[colVn, i].Value = dt.Rows[i][sndb.sn.vn].ToString();
                    dgvView[colDep, i].Value = dt.Rows[i][sndb.sn.MNC_MD_DEP_DSC].ToString();
                    dgvView[colPaid, i].Value = config1.shortPaidName(dt.Rows[i][sndb.sn.MNC_FN_TYP_DSC].ToString());
                    dgvView[colRemark, i].Value = sn.remark;
                    dgvView[colId, i].Value = sn.staffNoteId;
                    if (sn.staffNoteId != "" && sn.statusActive=="1" && sn.statusReceive=="1")
                    {                        
                        dgvView.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        if ((i % 2) != 0)
                        {
                            dgvView.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                        }
                    }
                }
            }
        }
        private void setViewRceive(String dateStart)
        {
            dgvView.Rows.Clear();
            String vn = "";
            DataTable dt = new DataTable();
            dt = sndb.selectByDate(dateStart);
            if (dt.Rows.Count > 0)
            {                
                dgvView.RowCount = dt.Rows.Count + 1;
                setdgvHeader();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //vn = dt.Rows[i][sndb.sn.vn].ToString();
                    //vn = vn.Replace("/", ".");
                    //vn = vn.Replace("(", ".");
                    //vn = vn.Replace(")", "");
                    //ChkStaffNote sn = sndb.selectByHnVn(dt.Rows[i][sndb.sn.MNC_HN_NO].ToString(), dt.Rows[i][sndb.sn.vn].ToString());
                    dgvView[colRow, i].Value = (i + 1);
                    dgvView[colHn, i].Value = dt.Rows[i][sndb.sn.MNC_HN_NO].ToString();
                    dgvView[colName, i].Value = dt.Rows[i][sndb.sn.MNC_PFIX_DSC].ToString() + " " + dt.Rows[i][sndb.sn.MNC_FNAME_T].ToString() + " " + dt.Rows[i][sndb.sn.MNC_LNAME_T].ToString();
                    dgvView[colVn, i].Value = dt.Rows[i][sndb.sn.vn].ToString();
                    dgvView[colDep, i].Value = dt.Rows[i][sndb.sn.MNC_MD_DEP_DSC].ToString();
                    dgvView[colPaid, i].Value = config1.shortPaidName(dt.Rows[i][sndb.sn.MNC_FN_TYP_DSC].ToString());
                    dgvView[colRemark, i].Value = dt.Rows[i][sndb.sn.remark].ToString();
                    dgvView[colId, i].Value = dt.Rows[i][sndb.sn.staffNoteId].ToString();
                    //if (sn.staffNoteId != "")
                    //{
                        dgvView.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                    //}
                    //else
                    //{
                    //    if ((i % 2) != 0)
                    //    {
                    //        dgvView.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    //    }
                    //}
                }
            }
        }
        private void setViewNoReceive(String dateStart)
        {
            dgvView.Rows.Clear();
            String vn = "";
            DataTable dt = new DataTable();
            int row = 0;
            dt = sndb.selectStaffNoteMainHisDate(dateStart, dateStart);
            if (dt.Rows.Count > 0)
            {
                
                dgvView.RowCount = dt.Rows.Count + 1;
                setdgvHeader();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    vn = dt.Rows[i][sndb.sn.vn].ToString();
                    vn = vn.Replace("/", ".");
                    vn = vn.Replace("(", ".");
                    vn = vn.Replace(")", "");
                    ChkStaffNote sn = sndb.selectByHnVn(dt.Rows[i][sndb.sn.MNC_HN_NO].ToString(), dt.Rows[i][sndb.sn.vn].ToString(), dateStart);

                    if (sn.staffNoteId != "" && sn.statusActive == "1" && sn.statusReceive == "1")
                    {
                        //dgvView.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        dgvView[colRow, row].Value = (row + 1);
                        dgvView[colHn, row].Value = dt.Rows[i][sndb.sn.MNC_HN_NO].ToString();
                        dgvView[colName, row].Value = dt.Rows[i][sndb.sn.MNC_PFIX_DSC].ToString() + " " + dt.Rows[i][sndb.sn.MNC_FNAME_T].ToString() + " " + dt.Rows[i][sndb.sn.MNC_LNAME_T].ToString();
                        dgvView[colVn, row].Value = dt.Rows[i][sndb.sn.vn].ToString();
                        dgvView[colDep, row].Value = dt.Rows[i][sndb.sn.MNC_MD_DEP_DSC].ToString();
                        dgvView[colPaid, row].Value = config1.shortPaidName(dt.Rows[i][sndb.sn.MNC_FN_TYP_DSC].ToString());
                        dgvView[colRemark, row].Value = sn.remark;
                        if ((row % 2) != 0)
                        {
                            dgvView.Rows[row].DefaultCellStyle.BackColor = Color.LightSalmon;
                        }
                        row++;
                    }
                }
                dgvView.RowCount = row+1;
            }
        }
        private void FrmChkStaffNote_Load(object sender, EventArgs e)
        {
            setResize();
            txtHn.Focus();
        }

        private void FrmChkStaffNote_Resize(object sender, EventArgs e)
        {
            setResize();
        }

        private void btnSearchVn_Click(object sender, EventArgs e)
        {
            setSearch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            setSaveStaffNote();
        }

        private void txtHn_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtHn.TextLength >= 7)
            {
                setSearch();
                txtVn.Focus();
            }
        }

        private void txtVn_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                setSearch();
            }
        }

        private void chkReeiveStaffNote_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                //MessageBox.Show("bbb", "aaa");
                setSaveStaffNote();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            setdgvView();
        }

        private void dgvView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            //dgvView.Enabled = false;
            String visitHn = "", visitVn = "", chk = "", dateStart="",staffNoteId="";
            visitHn = dgvView[colHn, e.RowIndex].Value.ToString();
            visitVn = dgvView[colVn, e.RowIndex].Value.ToString();
            staffNoteId = dgvView[colId, e.RowIndex].Value.ToString();
            if (e.ColumnIndex == colVoid)
            {
                chk = sndb.setStaffNoteVoid(staffNoteId);
                if (chk.Length>=1 && chk.Length<3)
                {
                    if ((e.RowIndex % 2) != 0)
                    {
                        dgvView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                    else
                    {
                        dgvView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    }
                    dgvView[colStatus, e.RowIndex].Value = "ยกเลิกการรับ staff note เรียบร้อย " + sn.MNC_HN_NO + " " + sn.vn;
                }
            }
            else
            {
                dateStart = dtpDate.Value.Year.ToString() + "-" + dtpDate.Value.ToString("MM-dd");
                sn = sndb.selectStaffNoteMainHisHnVn(visitHn, visitVn, dateStart);
                sn.statusActive = "1";
                sn.statusReceive = "1";
                if (dgvView[colRemark, e.RowIndex].Value == null)
                {
                    sn.remark = "";
                }
                else
                {
                    sn.remark = dgvView[colRemark, e.RowIndex].Value.ToString().Trim();
                }
                
                if (sndb.insertStaffNote(sn) == "1")
                {
                    dgvView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    dgvView[colStatus, e.RowIndex].Value = "บันทึกข้อมูลเรียบร้อย " + sn.MNC_HN_NO + " " + sn.vn;
                }
            }
            //dgvView.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void dgvView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            //dgvView.Enabled = false;
            String visitHn = "", visitVn = "", chk = "", dateStart="";
            visitHn = dgvView[colHn, e.RowIndex].Value.ToString();
            visitVn = dgvView[colVn, e.RowIndex].Value.ToString();
            if (e.ColumnIndex == colRemark)
            {
                dateStart = dtpDate.Value.Year.ToString() + "-" + dtpDate.Value.ToString("MM-dd");
                sn = sndb.selectStaffNoteMainHisHnVn(visitHn, visitVn, dateStart);
                sn.statusActive = "3";
                sn.statusReceive = "2";
                if (dgvView[colRemark, e.RowIndex].Value == null)
                {
                    sn.remark = "";
                }
                else
                {
                    sn.remark = dgvView[colRemark, e.RowIndex].Value.ToString().Trim();
                }

                if (sndb.insertRemark(sn) == "1")
                {
                    sndb.updateRemark(visitHn, visitVn, dateStart, sn.remark);
                    dgvView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                    //dgvView[6, e.RowIndex].Value = "บันทึกข้อมูลเรียบร้อย " + sn.MNC_HN_NO + " " + sn.vn;
                }
            }
            dgvView.Enabled = true;
            //Cursor.Current = Cursors.Default;
        }

        private void chkAll_Click(object sender, EventArgs e)
        {
            setdgvView();
        }

        private void chkReceive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkReceive_Click(object sender, EventArgs e)
        {
            setdgvView();
        }

        private void chNoReceive_Click(object sender, EventArgs e)
        {
            setdgvView();
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
