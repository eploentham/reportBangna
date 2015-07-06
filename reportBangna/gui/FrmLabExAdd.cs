using reportBangna.objdb;
using reportBangna.object1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        //OpenFileDialog ofd;
        String VN = "", ID="", fileName="";
        //LabExDB labexdb;
        LabEx le;
        PatientDB padb;
        Patient pa;
        VisitDB vsdb;
        Visit vs;
        BangnaControl bc;
        String pahtFile = "D:\\labex";
        private void initConfig()
        {            
            //labexdb = new LabExDB();
            //le = labexdb.selectByPk(ID);
            padb = new PatientDB();
            pa = new Patient();
            le = new LabEx();
            vsdb = new VisitDB();
            btnSave.Enabled =false;

            bool isExists = System.IO.Directory.Exists(pahtFile);
            if (!isExists)
                System.IO.Directory.CreateDirectory(pahtFile);
            
            chkActive.Checked = true;
            ChkUnActive.Checked = false;
            btnUnActive.Visible = false;
            //bc.lw.WriteLog("FrmLabExAdd.initConfig ID=" + ID);
            setControl(ID);

        }
        private void setControl(String id)
        {
            //bc.lw.WriteLog("FrmLabExAdd.initConfig setControl id"+id);
            le = bc.labexdb.selectByPk(id);
            txtId.Text = le.Id;
            txtDescription.Text = le.Description;
            txtRemark.Text = le.Remark;
            txtHN.Text = le.Hn;
            txtVN.Text = le.Vn;
            txtVisitDate.Text = le.VisitDate;
            txtVisitTime.Text = le.VisitTime;
            txtLabDate.Text = le.LabDate;
            txtLabTime.Text = le.LabTime;
            txtDoctorId.Text = le.DoctorId;
            txtDoctorName.Text = le.DoctorName;
            txtLabReqNo.Text = le.ReqNo;

            //bc.lw.WriteLog("FrmLabExAdd.initConfig setControl 1");
            //txtLabExDate.Text = le.LabExDate;
            if (le.LabExDate != "")
            {
                dtpLabEx.Value = DateTime.Parse(le.LabExDate);
            }
            txtYearId.Text = le.YearId;
            txtRowNumber.Text = le.RowNumber;
            txtName.Text = le.PatientName;
            String fileEx = bc.pathLabEx + txtYearId.Text + "\\";
            if (!le.RowNumber.Equals(""))
            {
                //LoadPic1(fileEx + le.RowNumber + ".jpg");
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
            ShowBtn1PDF();
            ShowBtn2PDF();
            ShowBtn3PDF();
            ShowBtn4PDF();
            ShowBtn5PDF();
            //bc.lw.WriteLog("FrmLabExAdd.initConfig setControl End");
        }
        private void ShowBtn1PDF()
        {
            String fileEx = bc.pathLabEx + txtYearId.Text + "\\" + txtId.Text + "_1.pdf";
            bool isExists = System.IO.File.Exists(fileEx);
            if (isExists)
            {
                btn1.Visible = true;
            }
            else
            {
                btn1.Visible = false;
            }
        }
        private void ShowBtn2PDF()
        {
            String fileEx = bc.pathLabEx + txtYearId.Text + "\\" + txtId.Text + "_2.pdf";
            bool isExists = System.IO.File.Exists(fileEx);
            if (isExists)
            {
                btn2.Visible = true;
            }
            else
            {
                btn2.Visible = false;
            }
        }
        private void ShowBtn3PDF()
        {
            String fileEx = bc.pathLabEx + txtYearId.Text + "\\" + txtId.Text + "_3.pdf";
            bool isExists = System.IO.File.Exists(fileEx);
            if (isExists)
            {
                btn3.Visible = true;
            }
            else
            {
                btn3.Visible = false;
            }
        }
        private void ShowBtn4PDF()
        {
            String fileEx = bc.pathLabEx + txtYearId.Text + "\\" + txtId.Text + "_4.pdf";
            bool isExists = System.IO.File.Exists(fileEx);
            if (isExists)
            {
                btn4.Visible = true;
            }
            else
            {
                btn4.Visible = false;
            }
        }
        private void ShowBtn5PDF()
        {
            String fileEx = bc.pathLabEx + txtYearId.Text + "\\" + txtId.Text + "_5.pdf";
            bool isExists = System.IO.File.Exists(fileEx);
            if (isExists)
            {
                btn5.Visible = true;
            }
            else
            {
                btn5.Visible = false;
            }
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
            txtLabDate.Text = bc.vs.LabDate;
            txtLabTime.Text = bc.vs.LabTime;
            txtDoctorId.Text = bc.vs.DoctorId;
            txtDoctorName.Text = bc.vs.DoctorName;
            txtLabReqNo.Text = bc.vs.LabReqNo;
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
            txtLabDate.Text = "";
            txtLabTime.Text = "";
            txtDoctorId.Text = "";
            txtDoctorName.Text = "";
            txtLabReqNo.Text = "";
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
            le.LabTime = txtLabTime.Text;
            le.DoctorId = txtDoctorId.Text;
            le.ReqNo = txtLabReqNo.Text;
            le.DoctorName = txtDoctorName.Text;

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
            //Error 
            //OpenFileDialog ofd = new OpenFileDialog();
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String file = openFileDialog1.FileName;
                //LoadPic1(file);
            }

        }
        //private void LoadPic1(String filename)
        //{
        //    pic1.Image = Image.FromFile(filename);
        //    pic1.SizeMode = PictureBoxSizeMode.StretchImage;
        //    fileName = filename;
        //    btnSave.Enabled = true;
        //}
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
            String fileEx = bc.pathLabEx+txtYearId.Text+"\\";
            setLabEx();
            try
            {
                bool isExists = System.IO.Directory.Exists(fileEx);
                if (!isExists)
                    System.IO.Directory.CreateDirectory(fileEx);
                String id = bc.labexdb.insertLabEx(le);
                txtId.Text = id;
                //if (rowNumber.Length == 6)
                //{
                    //Image im = Image.FromFile(fileName);

                    //bool isExists1 = System.IO.File.Exists(fileEx+"\\" + le.RowNumber + ".jpg");
                    //if (isExists1)
                    //{
                    //    Image im2 = Image.FromFile(fileEx + "\\" + le.RowNumber + ".jpg");
                    //    //if (Convert.ToBase64String(HashImage((Bitmap)pic1.Image)) != Convert.ToBase64String(HashImage((Bitmap)im2)))
                    //    //{
                    //    //    le.RowNumber = bc.labexdb.selectMaxRowNumber(le.YearId);
                    //    //    bc.labexdb.UpdateRowNumber(le.Id, le.RowNumber);
                    //    //    fileEx += le.RowNumber + ".jpg";
                    //    //    im.Save(fileEx);
                    //    //}
                    //    //System.IO.File.Delete(fileEx+le.RowNumber + ".jpg");
                    //}
                    //else
                    //{
                    //    fileEx += rowNumber + ".jpg";
                    //    im.Save(fileEx);
                        
                    //}
                    //im.Dispose();
                    //MessageBox.Show("บันทึกข้อมูล เรียบร้อย", "บันทึกข้อมูล");
                    //this.Dispose();
                //}
            }
            catch (Exception ex)
            {

            }
        }
        private void OpenPDF(String num)
        {
            String fileEx = bc.pathLabEx + txtYearId.Text + "\\" + txtId.Text + "_" + num + ".pdf";
            //String fileEx = @"d:\157073293_1.pdf";
            //String fileEx = @"d:\ScandAllPRO.exe";
            //Process p = new Process();
            //p.StartInfo.FileName = fileEx;
            ////p.StartInfo.Arguments = "/c dir *.cs";
            //p.StartInfo.UseShellExecute = false;
            //p.StartInfo.RedirectStandardOutput = true;
            //p.Start();
            System.Diagnostics.Process.Start(fileEx);
        }
        private void SavePDF(String num)
        {
            this.openFileDialog1.Filter = "PDF (*.PDF)|*.PDF";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (txtId.Text.Equals(""))
                {
                    btnSave_Click(null, null);
                }
                String fileEx = bc.pathLabEx + txtYearId.Text + "\\" + txtId.Text + "_"+num+".pdf";
                String file = openFileDialog1.FileName;
                bool isExists = System.IO.File.Exists(fileEx);
                if (isExists)
                {
                    File.Delete(fileEx);
                }
                File.Copy(file, fileEx, true);
                File.Delete(file);
                //System.Diagnostics.Process.Start(file);
                MessageBox.Show("นำเข้าข้อมูลเรียบร้อย", "นำเข้าข้อมูล");
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
                btnUnActive.Visible = true;
            }
        }

        private void chkActive_Click(object sender, EventArgs e)
        {
            if (chkActive.Checked)
            {
                btnUnActive.Visible = false;
            }
        }

        private void btnUnActive_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการยกเลิก", "ยกเลิก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                bc.labexdb.VoidLabEx(txtId.Text);
                this.Dispose();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            OpenPDF("1");
        }

        private void btnPDF1_Click(object sender, EventArgs e)
        {
            SavePDF("1");
        }

        private void btnPDF2_Click(object sender, EventArgs e)
        {
            SavePDF("2");
        }

        private void btnPDF3_Click(object sender, EventArgs e)
        {
            SavePDF("3");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SavePDF("4");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SavePDF("5");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start(@"d:\157073293_1.pdf");
            OpenPDF("3");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start(@"c:\HaxLogs.txt");
            OpenPDF("2");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            OpenPDF("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            OpenPDF("5");
        }
    }
}
