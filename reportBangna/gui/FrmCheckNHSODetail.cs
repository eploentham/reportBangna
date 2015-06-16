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
    public partial class FrmCheckNHSODetail : Form
    {
        CheckNhso1DB cNhso1db;
        String ID = "";
        public FrmCheckNHSODetail(String id)
        {
            InitializeComponent();
            ID = id;
            initConfig();
        }
        private void initConfig()
        {
            CheckNhso1 cNhso1 = new CheckNhso1();
            DataTable dt = new DataTable();
            cNhso1db = new CheckNhso1DB();
            cNhso1 = cNhso1db.selectByPk(ID);
            txtHN.Text = cNhso1.hn;
            txtName.Text = cNhso1.patientName;
            txtDrug1.Text = cNhso1.drug1;
            txtDrug2.Text = cNhso1.drug2;
            txtDrug3.Text = cNhso1.drug3;
            txtDrug4.Text = cNhso1.drug4;
            txtDrug5.Text = cNhso1.drug5;

            txtLabName1.Text = cNhso1.labName1;
            txtLabName2.Text = cNhso1.labName2;
            txtLabName3.Text = cNhso1.labName3;
            txtLabName4.Text = cNhso1.labName4;
            txtLabName5.Text = cNhso1.labName5;

            txtLabResult1.Text = cNhso1.labResult1;
            txtLabResult2.Text = cNhso1.labResult2;
            txtLabResult3.Text = cNhso1.labResult3;
            txtLabResult4.Text = cNhso1.labResult4;
            txtLabResult5.Text = cNhso1.labResult5;
        }

        private void FrmCheckNHSODetail_Load(object sender, EventArgs e)
        {

        }
    }
}
