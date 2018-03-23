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

namespace reportBangna
{
    public partial class FrmSSOAdd : Form
    {
        Config1 config1;
        BangnaControl bc;
        SSODB ssoDB;
        public FrmSSOAdd()
        {
            InitializeComponent();
            initConfig();
        }
        private void initConfig()
        {
            config1 = new Config1();
            bc = new BangnaControl();
            pB1.Hide();
            this.Text = "Last Update 2018-02-07";
        }

        private void btnSSOPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog res = new OpenFileDialog();
            res.Filter = "Access Files|*.mdb;";
            res.Filter = "All Files|*.*;";
            if (res.ShowDialog() == DialogResult.OK)
            {
                //Get the file's path
                txtSSOPathAccess.Text = res.FileName;
                //Do something
            }
        }

        private void btnSSOPathSave_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtSSOSavePath.Text = folderDialog.SelectedPath;
                    // folderDialog.SelectedPath -- your result
                }
            }
        }

        private void btnSSOOk_Click(object sender, EventArgs e)
        {
            //ssoDB = new SSODB(txtSSOPathAccess.Text);
            if (chk32.Checked)
            {
                ssoDB = new SSODB(txtSSOPathAccess.Text,"32");
            }
            else
            {
                ssoDB = new SSODB(txtSSOPathAccess.Text,"64");
            }
            if (ssoDB.isConnectOpen)
            {
                label3.Text = "connect OK";
                txtSSCnt.Text = ssoDB.cntOutPatient.ToString();
            }
        }

        private void btnSSOGenData_Click(object sender, EventArgs e)
        {
            if (ssoDB == null) return;
            pB1.Show();
            ssoDB.HCODE = txtHCODE.Text;
            ssoDB.fileOPService = txtOPService.Text;
            ssoDB.fileBillTran = txtSSOBillTran.Text;
            ssoDB.HNAME = txtHNAME.Text;
            ssoDB.SESSNO = txtSESSNO.Text;

            ssoDB.genXML(txtSSOSavePath.Text, pB1);
            pB1.Hide();
        }

        private void FrmSSOAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
