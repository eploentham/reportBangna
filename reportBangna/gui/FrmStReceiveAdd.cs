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
    public partial class FrmStReceiveAdd : Form
    {
        BangnaControl bc;
        int colRow = 0, colName = 1, colExpDate = 2, colQty = 3, colPrice = 4, colTotal = 5, colRemark = 6, colId = 7;
        int colCnt = 8;
        Boolean pageLoad = false;

        private void cboVen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!pageLoad)
            {
                //Customer cu = new Customer();
                //cu = cc.cudb.selectByPk(cc.getValueCboItem(cboCust));
                //txtCustId.Text = cu.Id;
                //txtCustAddress.Text = cu.AddressT;
                //txtCustEmail.Text = cu.Email;
                //txtCustFax.Text = cu.Fax;
                //txtCustTel.Text = cu.Tele + " , " + cu.Mobile;
                //cboContact.Text = cu.ContactName1;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public FrmStReceiveAdd(BangnaControl c)
        {
            InitializeComponent();
            bc = c;
            initConfig();
        }
        private void initConfig()
        {
            cboVen = bc.vendb.getCboVendor(cboVen);
            setGrdH();
        }
        private void setControl()
        {

        }
        
        private void setResize()
        {
            //dgvView.Width = this.Width - 80;
            //dgvView.Height = this.Height - 150;
            //btnAdd.Left = dgvView.Width - 50;
            //btnPrint.Left = dgvView.Width + 20;
            //groupBox1.Width = this.Width - 50;
            //groupBox1.Height = this.Height = 150;
        }
        private void setGrdH()
        {
            Font font = new Font("Microsoft Sans Serif", 12);
            DataTable dt = new DataTable();

            dgvAdd.ColumnCount = colCnt;
            dgvAdd.Rows.Clear();
            dgvAdd.RowCount = 1;
            dgvAdd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdd.Columns[colQty].Width = 60;
            dgvAdd.Columns[colName].Width = 300;
            dgvAdd.Columns[colPrice].Width = 80;
            dgvAdd.Columns[colRow].Width = 40;
            dgvAdd.Columns[colTotal].Width = 100;
            dgvAdd.Columns[colRemark].Width = 120;
            dgvAdd.Columns[colExpDate].Width = 95;

            dgvAdd.Columns[colRow].HeaderText = "no";
            dgvAdd.Columns[colQty].HeaderText = "Qty";
            dgvAdd.Columns[colName].HeaderText = "Name";
            dgvAdd.Columns[colPrice].HeaderText = "Price";
            dgvAdd.Columns[colTotal].HeaderText = "Total";
            dgvAdd.Columns[colRemark].HeaderText = "Remark";
            dgvAdd.Columns[colExpDate].HeaderText = "exp date";

            //dgvAdd.Columns[colQty].a

            dgvAdd.Font = font;
            dgvAdd.Columns[colId].Visible = false;
        }
        private void FrmStReceiveAdd_Load(object sender, EventArgs e)
        {

        }

        private void FrmStReceiveAdd_Resize(object sender, EventArgs e)
        {
            setResize();
        }
    }
}
