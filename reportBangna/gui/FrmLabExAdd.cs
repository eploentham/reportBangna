using reportBangna.objdb;
using reportBangna.object1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace reportBangna.gui
{
    public partial class FrmLabExAdd : Form
    {
        OpenFileDialog ofd;
        String VN = "", ID="", fileName="";
        LabExDB labexdb;
        LabEx le;
        PatientDB padb;
        Patient pa;
        VisitDB vsdb;
        Visit vs;
        BangnaControl bc;
        private void initConfig()
        {
            ofd = new OpenFileDialog();
            labexdb = new LabExDB();
            //le = labexdb.selectByPk(ID);
            padb = new PatientDB();
            pa = new Patient();
            le = new LabEx();
            vsdb = new VisitDB();
            btnSave.Enabled =false;

            chkActive.Checked = true;
            ChkUnActive.Checked = false;
            btnUnActive.Visible = false;
            bc.lw.WriteLog("FrmLabExAdd.initConfig ID=" + ID);
            setControl(ID);

        }
        private void setControl(String id)
        {
            bc.lw.WriteLog("FrmLabExAdd.initConfig setControl id"+id);
            le = labexdb.selectByPk(id);
            txtId.Text = le.Id;
            txtDescription.Text = le.Description;
            txtRemark.Text = le.Remark;
            txtHN.Text = le.Hn;
            txtVN.Text = le.Vn;
            txtVisitDate.Text = le.VisitDate;
            txtLabDate.Text = le.LabDate;
            bc.lw.WriteLog("FrmLabExAdd.initConfig setControl 1");
            //txtLabExDate.Text = le.LabExDate;
            if (le.LabExDate != "")
            {
                dtpLabEx.Value = DateTime.Parse(le.LabExDate);
            }
            txtYearId.Text = le.YearId;
            txtRowNumber.Text = le.RowNumber;
            txtName.Text = le.PatientName;
            String fileEx = "\\\\172.25.10.5\\image\\labex\\" + txtYearId.Text + "\\";
            if (!le.RowNumber.Equals(""))
            {
                LoadPic1(fileEx + le.RowNumber + ".jpg");
            }
            else
            {
                setVisit();
            }
            
            if (le.Active.Equals("1"))
            {
                chkActive.Checked = true;
                ChkUnActive.Checked = false;
                btnUnActive.Visible = false;
            }
            else
            {
                chkActive.Checked = false;
                ChkUnActive.Checked = true;
                btnUnActive.Visible = true;
            }
            if (le.Active.Equals(""))
            {
                chkActive.Checked = true;
                ChkUnActive.Checked = false;
                btnUnActive.Visible = false;
            }
            bc.lw.WriteLog("FrmLabExAdd.initConfig setControl End");
        }
        private void setControlBySearch()
        {
            //le = labexdb.selectByPk(id);
            txtDescription.Text = "";
            txtRemark.Text = "";
            txtHN.Text = bc.vs.HN;
            txtVN.Text = bc.vs.VN;
            txtVisitDate.Text = "";
            txtLabDate.Text = "";
            //txtLabExDate.Text = "";
            dtpLabEx.Value = System.DateTime.Now;
            txtName.Text = bc.vs.PatientName;
            txtVisitDate.Text = bc.vs.VisitDate;
            txtVisitTime.Text = bc.vs.VisitTime;
            //txtLabExDate.Text = System.DateTime.Now.Day.ToString("00") + "-" + System.DateTime.Now.Month.ToString("00") + "-" + String.Concat(System.DateTime.Now.Year+543);
        }
        private void setVisit()
        {
            txtHN.Text = "";
            txtVN.Text = "";
            txtVisitDate.Text = "";
            txtDescription.Text = "";
            txtRemark.Text = "";
            txtId.Text = "";
            txtYearId.Text = System.DateTime.Now.Year.ToString();
        }
        private void setLabEx()
        {
            le.Id = txtId.Text;
            le.Active = "1";
            le.Description = txtDescription.Text;
            le.Hn = txtHN.Text;
            le.LabDate = txtLabDate.Text;
            le.LabExDate = (dtpLabEx.Value.Year+543) + "-" + dtpLabEx.Value.ToString("MM-dd");
            le.PatientName = txtName.Text;
            le.Remark = txtRemark.Text;
            le.Vn = txtVN.Text;
            le.VisitDate = txtVisitDate.Text;
            le.RowNumber = txtRowNumber.Text;
            le.YearId = txtYearId.Text;
        }
        public FrmLabExAdd(BangnaControl b,String labexId)
        {
            ID = labexId;
            bc = b;
            InitializeComponent();
            initConfig();
        }

        private void FrmLabExAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            String pahtFile = "D:\\labex";
            bool isExists = System.IO.Directory.Exists(pahtFile);
            if (!isExists)
                System.IO.Directory.CreateDirectory(pahtFile);
            ofd.InitialDirectory = pahtFile;
            ofd.ShowDialog();

            //DirectoryInfo dir = new DirectoryInfo(fbd.);
            //Image im = Image.FromFile(fbd.FileName);
            LoadPic1(ofd.FileName);            
            //if (!System.IO.File.Exists(fileName))
            //{
            //    image.Save(fileName);
            //}
        }
        private void LoadPic1(String filename)
        {
            pic1.Image = Image.FromFile(filename);
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            fileName = filename;
            btnSave.Enabled = true;
        }
        public byte[] HashImage(Bitmap image)
        {
            var sha256 = SHA256.Create();

            var rect = new Rectangle(0, 0, image.Width, image.Height);
            var data = image.LockBits(rect, ImageLockMode.ReadOnly, image.PixelFormat);

            var dataPtr = data.Scan0;

            var totalBytes = (int)Math.Abs(data.Stride) * data.Height;
            var rawData = new byte[totalBytes];
            System.Runtime.InteropServices.Marshal.Copy(dataPtr, rawData, 0, totalBytes);

            image.UnlockBits(data);

            return sha256.ComputeHash(rawData);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            String fileEx = "\\\\172.25.10.5\\image\\labex\\"+txtYearId.Text+"\\";
            setLabEx();
            try
            {
                bool isExists = System.IO.Directory.Exists(fileEx);
                if (!isExists)
                    System.IO.Directory.CreateDirectory(fileEx);
                String rowNumber = labexdb.insertLabEx(le);
                if (rowNumber.Length == 6)
                {
                    Image im = Image.FromFile(fileName);

                    bool isExists1 = System.IO.File.Exists(fileEx+"\\" + le.RowNumber + ".jpg");
                    if (isExists1)
                    {
                        Image im2 = Image.FromFile(fileEx + "\\" + le.RowNumber + ".jpg");
                        if (Convert.ToBase64String(HashImage((Bitmap)pic1.Image)) != Convert.ToBase64String(HashImage((Bitmap)im2)))
                        {
                            le.RowNumber = labexdb.selectMaxRowNumber(le.YearId);
                            labexdb.UpdateRowNumber(le.Id, le.RowNumber);
                            fileEx += le.RowNumber + ".jpg";
                            im.Save(fileEx);
                        }
                        //System.IO.File.Delete(fileEx);                        
                    }
                    else
                    {
                        fileEx += rowNumber + ".jpg";
                        im.Save(fileEx);
                    }
                    
                    MessageBox.Show("บันทึกข้อมูล เรียบร้อย", "บันทึกข้อมูล");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            FrmLabExSearch frm = new FrmLabExSearch(bc);
            frm.ShowDialog();
            //bc.vnSearch = "";
            //setGrd(bc.hnSearch);
            setControlBySearch();
        }
        private void ChkUnActive_Click(object sender, EventArgs e)
        {
            if (ChkUnActive.Checked)
            {

            }
        }

        private void chkActive_Click(object sender, EventArgs e)
        {
            if (chkActive.Checked)
            {

            }
        }
    }
}
