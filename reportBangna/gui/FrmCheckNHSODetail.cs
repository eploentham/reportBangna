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
            DataTable dt = new DataTable();
            cNhso1db = new CheckNhso1DB();
            SetControl();
        }
        private void SetControl()
        {
            CheckNhso1 cNhso1 = new CheckNhso1();

            cNhso1 = cNhso1db.selectByPk(ID);
            txtHN.Text = cNhso1.hn;
            txtName.Text = cNhso1.patientName;
            txtDrug1.Text = cNhso1.drug1;
            txtDrug2.Text = cNhso1.drug2;
            txtDrug3.Text = cNhso1.drug3;
            txtDrug4.Text = cNhso1.drug4;
            txtDrug5.Text = cNhso1.drug5;
            txtDrug6.Text = cNhso1.drug6;
            txtDrug7.Text = cNhso1.drug7;
            txtDrug8.Text = cNhso1.drug8;
            txtDrug9.Text = cNhso1.drug9;
            txtDrug10.Text = cNhso1.drug10;
            txtDrug11.Text = cNhso1.drug11;
            txtDrug12.Text = cNhso1.drug12;
            txtDrug13.Text = cNhso1.drug13;
            txtDrug14.Text = cNhso1.drug14;
            txtDrug15.Text = cNhso1.drug15;
            txtDrug16.Text = cNhso1.drug16;
            txtDrug17.Text = cNhso1.drug17;
            txtDrug18.Text = cNhso1.drug18;
            txtDrug19.Text = cNhso1.drug19;
            txtDrug20.Text = cNhso1.drug20;


            txtLabName1.Text = cNhso1.labName1;
            txtLabName2.Text = cNhso1.labName2;
            txtLabName3.Text = cNhso1.labName3;
            txtLabName4.Text = cNhso1.labName4;
            txtLabName5.Text = cNhso1.labName5;
            txtLabName6.Text = cNhso1.labName6;
            txtLabName7.Text = cNhso1.labName7;
            txtLabName8.Text = cNhso1.labName8;
            txtLabName9.Text = cNhso1.labName9;
            txtLabName10.Text = cNhso1.labName10;


            txtLabResult1.Text = cNhso1.labResult1;
            txtLabResult2.Text = cNhso1.labResult2;
            txtLabResult3.Text = cNhso1.labResult3;
            txtLabResult4.Text = cNhso1.labResult4;
            txtLabResult5.Text = cNhso1.labResult5;
            txtLabResult6.Text = cNhso1.labResult6;
            txtLabResult7.Text = cNhso1.labResult7;
            txtLabResult8.Text = cNhso1.labResult8;
            txtLabResult9.Text = cNhso1.labResult9;
            txtLabResult10.Text = cNhso1.labResult10;
        }
        private CheckNhso1 getCheckNhso1()
        {
            CheckNhso1 cNhso1 = new CheckNhso1();
            cNhso1.hn = txtHN.Text;
            cNhso1.patientName = txtName.Text;
            cNhso1.drug1 = txtDrug1.Text;
            cNhso1.drug2 = txtDrug2.Text;
            cNhso1.drug3 = txtDrug3.Text;
            cNhso1.drug4 = txtDrug4.Text;
            cNhso1.drug5 = txtDrug5.Text;
            cNhso1.drug6 = txtDrug6.Text;
            cNhso1.drug7 = txtDrug7.Text;
            cNhso1.drug8 = txtDrug8.Text;
            cNhso1.drug9 = txtDrug9.Text;
            cNhso1.drug10 = txtDrug10.Text;
            cNhso1.drug11 = txtDrug11.Text;
            cNhso1.drug12 = txtDrug12.Text;
            cNhso1.drug13 = txtDrug13.Text;
            cNhso1.drug14 = txtDrug14.Text;
            cNhso1.drug15 = txtDrug15.Text;
            cNhso1.drug16 = txtDrug16.Text;
            cNhso1.drug17 = txtDrug17.Text;
            cNhso1.drug18 = txtDrug18.Text;
            cNhso1.drug19 = txtDrug19.Text;
            cNhso1.drug20 = txtDrug20.Text;


            txtLabName1.Text = cNhso1.labName1;
            txtLabName2.Text = cNhso1.labName2;
            txtLabName3.Text = cNhso1.labName3;
            txtLabName4.Text = cNhso1.labName4;
            txtLabName5.Text = cNhso1.labName5;
            txtLabName6.Text = cNhso1.labName6;
            txtLabName7.Text = cNhso1.labName7;
            txtLabName8.Text = cNhso1.labName8;
            txtLabName9.Text = cNhso1.labName9;
            txtLabName10.Text = cNhso1.labName10;


            txtLabResult1.Text = cNhso1.labResult1;
            txtLabResult2.Text = cNhso1.labResult2;
            txtLabResult3.Text = cNhso1.labResult3;
            txtLabResult4.Text = cNhso1.labResult4;
            txtLabResult5.Text = cNhso1.labResult5;
            txtLabResult6.Text = cNhso1.labResult6;
            txtLabResult7.Text = cNhso1.labResult7;
            txtLabResult8.Text = cNhso1.labResult8;
            txtLabResult9.Text = cNhso1.labResult9;
            txtLabResult10.Text = cNhso1.labResult10;
            return cNhso1;
        }

        private void FrmCheckNHSODetail_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
