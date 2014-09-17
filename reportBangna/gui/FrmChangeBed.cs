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
    public partial class FrmChangeBed : Form
    {
        Boolean pageLoad = false;
        BangnaControl bc;
        int colCnt = 7;
        int colRow = 0, colHn = 1, colName = 2, colRoom = 3, colBed = 4, colPreNo = 5, colDate = 6;
        public FrmChangeBed()
        {
            pageLoad = true;
            InitializeComponent();
            bc = new BangnaControl();
            bc.getCboWard(cboWardForm);
            bc.getCboWard(cboWardTo);
            pageLoad = false;
        }
        private void setGrdFrom(String wardNo)
        {
            DataTable dt = new DataTable();
            dt = bc.selectPatientInWard(wardNo);
            dgvFrom.ColumnCount = colCnt;

            dgvFrom.RowCount = dt.Rows.Count + 1;
            dgvFrom.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFrom.Columns[colRow].Width = 50;
            dgvFrom.Columns[colName].Width = 150;
            dgvFrom.Columns[colRoom].Width = 120;
            dgvFrom.Columns[colBed].Width = 80;
            dgvFrom.Columns[colHn].Width = 80;
            dgvFrom.Columns[colDate].Width = 100;

            dgvFrom.Columns[colRow].HeaderText = "ลำดับ";
            dgvFrom.Columns[colHn].HeaderText = "HN";
            dgvFrom.Columns[colName].HeaderText = "ชื่อ";
            dgvFrom.Columns[colRoom].HeaderText = "ห้อง";
            dgvFrom.Columns[colBed].HeaderText = "เตียง";
            dgvFrom.Columns[colPreNo].HeaderText = "preno";
            dgvFrom.Columns[colDate].HeaderText = "วันที่";

            //dgvFrom.Columns[colBed].HeaderText = "id";
            Font font = new Font("Microsoft Sans Serif", 12);

            dgvFrom.Font = font;
            dgvFrom.Columns[colPreNo].Visible = false;
            dgvFrom.ReadOnly = true;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvFrom[colRow, i].Value = (i + 1);
                    dgvFrom[colHn, i].Value = dt.Rows[i]["mnc_hn_no"].ToString();
                    dgvFrom[colName, i].Value = dt.Rows[i]["MNC_PFIX_DSC"].ToString() + " " + dt.Rows[i]["MNC_FNAME_T"].ToString() + " " + dt.Rows[i]["MNC_LNAME_T"].ToString();
                    dgvFrom[colRoom, i].Value = dt.Rows[i]["mnc_rm_nam"].ToString();
                    dgvFrom[colBed, i].Value = dt.Rows[i]["mnc_bd_no"].ToString();
                    dgvFrom[colDate, i].Value = bc.cf.dateDBtoShow(DateTime.Parse(dt.Rows[i]["mnc_date"].ToString()));

                    if ((i % 2) != 0)
                    {
                        dgvFrom.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
        }

        private void FrmChangeBed_Load(object sender, EventArgs e)
        {
            
        }

        private void cboWardForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!pageLoad)
            {
                setGrdFrom(bc.getValueCboItem(cboWardForm));
            }
            
        }

        private void dgvFrom_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
