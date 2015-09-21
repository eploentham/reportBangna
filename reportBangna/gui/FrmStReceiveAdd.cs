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
        public FrmStReceiveAdd(BangnaControl c)
        {
            InitializeComponent();
            bc = c;
            initConfig();
        }
        private void initConfig()
        {
            
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
        private void FrmStReceiveAdd_Load(object sender, EventArgs e)
        {

        }

        private void FrmStReceiveAdd_Resize(object sender, EventArgs e)
        {
            setResize();
        }
    }
}
