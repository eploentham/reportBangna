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
    public partial class FrmLabCheckText : Form
    {
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        public FrmLabCheckText()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String file = openFileDialog1.FileName;
                System.Diagnostics.Process.Start(file);
            }
        }
    }
}
