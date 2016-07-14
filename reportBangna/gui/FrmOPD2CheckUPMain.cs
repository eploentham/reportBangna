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
    public partial class FrmOPD2CheckUPMain : Form
    {
        BangnaControl bc;
        public FrmOPD2CheckUPMain()
        {
            InitializeComponent();
            initConfig();
        }
        private void initConfig()
        {
            bc = new BangnaControl();

        }
        private void btnPrintOPD2_Click(object sender, EventArgs e)
        {
            FrmOPD2CheckUP frm = new FrmOPD2CheckUP(bc,"");
            frm.ShowDialog();
        }

        private void btnPrintOPD21_Click(object sender, EventArgs e)
        {
            FrmOPD21CheckUP frm = new FrmOPD21CheckUP(bc);
            frm.ShowDialog();
        }
    }
}
