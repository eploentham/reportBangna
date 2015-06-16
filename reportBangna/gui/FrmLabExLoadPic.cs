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
    public partial class FrmLabExLoadPic : Form
    {
        BangnaControl bc;
        public FrmLabExLoadPic(BangnaControl b)
        {
            InitializeComponent();
            bc = b;
            initConfig();
        }
        private void initConfig()
        {
            //bc = new BangnaControl();
        }
        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.InitialDirectory = pahtFile;
            ofd.ShowDialog();
            bc.FileName = ofd.FileName;
            //ofd.Dispose();
            //DirectoryInfo dir = new DirectoryInfo(fbd.);
            //Image im = Image.FromFile(fbd.FileName);
            LoadPic1(bc.FileName);
        }
        private void LoadPic1(String filename)
        {
            pic1.Image = Image.FromFile(filename);
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            //fileName = filename;
            //btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
