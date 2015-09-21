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
    public partial class FrmStMain : Form
    {
        BangnaControl bc;
        public FrmStMain()
        {
            InitializeComponent();
            initConfig();
        }
        private void initConfig()
        {
            bc = new BangnaControl();
        }

        private void btnVendor_Click(object sender, EventArgs e)
        {
            FrmStVendorView f = new FrmStVendorView(bc);
            f.Show(this);
        }

        private void FrmStMain_Load(object sender, EventArgs e)
        {

        }

        private void btnGoods_Click(object sender, EventArgs e)
        {
            FrmStGoodsView f = new FrmStGoodsView(bc);
            f.Show(this);
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            FrmStReceiveView f = new FrmStReceiveView(bc);
            f.Show(this);
        }
    }
}
