using C1.C1Pdf;
using C1.Win.C1Document;
using reportBangna.objdb;
using reportBangna.object1;
using reportBangna.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace reportBangna.gui
{
    public partial class FrmBillLabCheckExcel : Form
    {
        Config1 config1;
        IniFile iniFile = new IniFile("reportbangna.ini");
        Label lbLoading;
        public FrmBillLabCheckExcel()
        {
            InitializeComponent();
            lbLoading = new Label();
            lbLoading.Font = new Font("AngsanaUPC", 20, FontStyle.Bold);
            lbLoading.BackColor = Color.WhiteSmoke;
            lbLoading.ForeColor = Color.Black;
            lbLoading.AutoSize = false;
            lbLoading.Size = new Size(300, 60);
            this.Controls.Add(lbLoading);

            config1 = new Config1();
            pB1.Hide();
            config1.setCboMonth(cboMonth);
            config1.setCboYear(cboYear);
            config1.setCboPeriod(cboPeriod);
            btnCheck.Enabled = false;

            chkBn1.Click += ChkBn1_Click;
            chkBn2.Click += ChkBn2_Click;
            chkBn5.Click += ChkBn5_Click;
            cboYear.SelectedIndexChanged += CboYear_SelectedIndexChanged;
            cboMonth.SelectedIndexChanged += CboMonth_SelectedIndexChanged;
            cboPeriod.SelectedIndexChanged += CboPeriod_SelectedIndexChanged;

            btnPrnDetailItem.Click += BtnPrnDetailItem_Click;
        }

        private void BtnPrnDetailItem_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            showLbLoading();
            btnPrnDetail.Enabled = false;

            btnPrnDetail.Enabled = true;
            //hideLbLoading();
            MemoryStream mem = printBillDetail("item");
            if (mem != null)
            {
                FrmShowPdf frm = new FrmShowPdf(mem);
                frm.ShowDialog(this);
            }
            hideLbLoading();
        }

        private void CboPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            setTxtEmailTo();
        }

        private void CboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            setTxtEmailTo();
        }

        private void CboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            setTxtEmailTo();
        }
        private void setTxtEmailTo()
        {
            if (chkBn1.Checked)
            {
                String email_to = iniFile.Read("email_to_bangna1");
                txtEmailTo.Text = email_to;
                setTxtEmailSubject();
            }
            else if (chkBn2.Checked)
            {
                String email_to = iniFile.Read("email_to_bangna2");
                txtEmailTo.Text = email_to;
                setTxtEmailSubject();
            }
            else if (chkBn5.Checked)
            {
                String email_to = iniFile.Read("email_to_bangna5");
                txtEmailTo.Text = email_to;
                setTxtEmailSubject();
            }
        }
        private void setTxtEmailSubject()
        {
            String flagBr = "";
            int year = 0;
            if (!int.TryParse(cboYear.Text, out year))
            {
                MessageBox.Show("Error กรุณาเลือก ปี", "Error");
                label2.Text = "Error กรุณาเลือก ปี";
                return;
            }
            int month = 0;
            if (!int.TryParse(cboMonth.SelectedValue.ToString(), out month))
            {
                MessageBox.Show("Error กรุณาเลือก เดือน", "Error");
                label2.Text = "Error กรุณาเลือก เดือน";
                return;
            }
            int period = 0;
            if (!int.TryParse(cboPeriod.Text, out period))
            {
                MessageBox.Show("Error กรุณาเลือก งวด", "Error");
                label2.Text = "Error กรุณาเลือก งวด";
                return;
            }
            flagBr = chkBn1.Checked ? "บางนา 1" : chkBn2.Checked ? "บางนา 2" : chkBn5.Checked ? "บางนา 5" : "";
            
            txtEmailSubject.Text = "ATTA LAB แจ้งยอดวางบิล " + flagBr + " ปี " + year + " เดือน " + month.ToString("00") + " งวด " + period;
        }
        private void ChkBn5_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            String email_to= iniFile.Read("email_to_bangna5");
            txtEmailTo.Text = email_to;
            setTxtEmailSubject();
        }

        private void ChkBn2_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            String email_to = iniFile.Read("email_to_bangna2");
            txtEmailTo.Text = email_to;
            setTxtEmailSubject();
        }

        private void ChkBn1_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            String email_to = iniFile.Read("email_to_bangna1");
            txtEmailTo.Text = email_to;
            setTxtEmailSubject();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            showLbLoading();
            btnEmail.Enabled = false;
            SmtpClient SmtpServer;
            String flagBr = "";
            int year = 0;
            flagBr = chkBn1.Checked ? "1" : chkBn2.Checked ? "2" : chkBn5.Checked ? "5" : "";
            if (!int.TryParse(cboYear.Text, out year))
            {
                MessageBox.Show("Error กรุณาเลือก ปี", "Error");
                label2.Text = "Error กรุณาเลือก ปี";
                return;
            }
            int month = 0;
            if (!int.TryParse(cboMonth.SelectedValue.ToString(), out month))
            {
                MessageBox.Show("Error กรุณาเลือก เดือน", "Error");
                label2.Text = "Error กรุณาเลือก เดือน";
                return;
            }
            int period = 0;
            if (!int.TryParse(cboPeriod.Text, out period))
            {
                MessageBox.Show("Error กรุณาเลือก งวด", "Error");
                label2.Text = "Error กรุณาเลือก งวด";
                return;
            }
            year -= 543;

            String email_form = iniFile.Read("email_form");
            String email_auth_user = iniFile.Read("email_auth_user");
            String email_auth_pass = iniFile.Read("email_auth_pass");
            String email_port = iniFile.Read("email_port");
            String email_ssl = iniFile.Read("email_ssl");
            String email_to_bangna1 = iniFile.Read("email_to_bangna1");
            String email_to_bangna2 = iniFile.Read("email_to_bangna2");
            String email_to_bangna5 = iniFile.Read("email_to_bangna5");

            label2.Text = "เตรียม Email";
            //FrmWaiting frmW = new FrmWaiting();
            //frmW.Show();
            String filename = "", datetick = "";
            if (!Directory.Exists("report"))
            {
                Directory.CreateDirectory("report");
            }
            datetick = DateTime.Now.Ticks.ToString();
            String pathFolder = Application.StartupPath + "\\billtext\\";
            if (!Directory.Exists(pathFolder))
            {
                Directory.CreateDirectory(pathFolder);
            }
            
            filename = pathFolder + "\\" + flagBr + "-" + year + "-" + month.ToString("00") + "-" + period + "_" + datetick + ".txt";

            label2.Text = "เตรียม Report";
            if (!genTextLabBill(filename))
            {
                return;
            }
            //frmW.Dispose();
            if (!File.Exists(filename))
            {
                label2.Text = "ไม่พบ Attach File";
                return;
            }
            label2.Text = "เริ่มส่ง Email";
            MailMessage mail = new MailMessage();
            
            //txtEmailSubject.Value = "Routine LAB Result HN " + txtHn.Text.ToUpper() + " Name " + txtPttNameE.Text + " [VN " + txtVnShow.Text + "] Hormone Report Date " + System.DateTime.Now.ToString("dd/MM/") + System.DateTime.Now.Year;

            //mail.From = new MailAddress(txtEmailTo.Text); ic.iniC.email_form_lab_opu
            mail.From = new MailAddress(email_form);
            mail.To.Add(txtEmailTo.Text);
            mail.Subject = txtEmailSubject.Text;
            mail.Body = txtEmailTo.Text.Trim();

            mail.IsBodyHtml = true;
            if (File.Exists(filename))
            {
                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(filename);
                mail.Attachments.Add(attachment);
            }

            //AlternateView htmlView = AlternateView.CreateAlternateViewFromString(body, null, "text/html");
            //mail.AlternateViews.Add(htmlView);
            
            SmtpServer = new SmtpClient("smtp.gmail.com");
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential(email_auth_user, email_auth_pass);
            SmtpServer.EnableSsl = true;
            SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
            SmtpServer.Credentials = new NetworkCredential(email_auth_user, email_auth_pass);

            SmtpServer.Send(mail);
            label2.Text = "ส่ง Email เรียบร้อย";
            btnEmail.Enabled = true;
            hideLbLoading();
        }
        private Boolean genTextLabBill(String filename)
        {
            Boolean re = false;
            DataTable dt = new DataTable();
            int gapLine = 20, gapLine1 = 15, gapX = 40, gapY = 20, xCol2 = 100, xCol1 = 20, xCol11 = 45, xCol3 = 200, xCol4 = 300, xCol41 = 400, xCol5 = 400, xCol6 = 500;
            String sql = "", flagBr = "", data = "", paidnameold = "";
            int year = 0;
            flagBr = chkBn1.Checked ? "1" : chkBn2.Checked ? "2" : chkBn5.Checked ? "5" : "";
            if (!int.TryParse(cboYear.Text, out year))
            {
                MessageBox.Show("Error กรุณาเลือก ปี", "Error");
                label2.Text = "Error กรุณาเลือก ปี";
                return re;
            }
            int month = 0;
            if (!int.TryParse(cboMonth.SelectedValue.ToString(), out month))
            {
                MessageBox.Show("Error กรุณาเลือก เดือน", "Error");
                label2.Text = "Error กรุณาเลือก เดือน";
                return re;
            }
            int period = 0;
            if (!int.TryParse(cboPeriod.Text, out period))
            {
                MessageBox.Show("Error กรุณาเลือก งวด", "Error");
                label2.Text = "Error กรุณาเลือก งวด";
                return re;
            }
            year -= 543;
            sql = "Select  paid_type_name,  price3,  discount,  netprice,full_name,lab_code,lab_name, lab_date,doc_code, hn,netprice  " +
                "From lab_t_data " +
                "Where branch_id = '" + flagBr + "' and year_id = '" + year + "' and month_id = '" + month.ToString("00") + "' and period_id = '" + period + "'  " +
                //"Group By paid_type_name" +
                "Order By paid_type_name, full_name,lab_code; ";
            ConnectDB conn = new ConnectDB("mainhis", flagBr);
            dt = conn.selectDataMySQL(conn.connMySQL, sql);
            if (dt.Rows.Count > 0)
            {
                foreach(DataRow drow in dt.Rows)
                {
                    data += drow["doc_code"].ToString()+"|"+ drow["lab_date"].ToString()+"|"+ drow["hn"].ToString()+"|"+ drow["full_name"].ToString()+"|"+ drow["paid_type_name"].ToString()+"|"+ drow["price3"].ToString()+"|"+ drow["netprice"].ToString()+"|"+ drow["lab_code"].ToString()+"|"+ drow["lab_name"].ToString()+Environment.NewLine;
                }
            }
            
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(data);
            }
            re = true;
            return re;
        }
        private MemoryStream printBillDetail(String flagDetail)
        {
            DataTable dt = new DataTable();
            int gapLine = 20, gapLine1 = 15, gapX = 40, gapY = 20, xCol2 = 100, xCol1 = 20, xCol11 = 45, xCol3 = 200, xCol4 = 300, xCol41 = 400, xCol5 = 400, xCol6 = 500;
            String sql = "", flagBr = "", paidname = "", paidnameold = "";
            int year = 0;
            flagBr = chkBn1.Checked ? "1" : chkBn2.Checked ? "2" : chkBn5.Checked ? "5" : "";
            if (!int.TryParse(cboYear.Text, out year))
            {
                MessageBox.Show("Error กรุณาเลือก ปี", "Error");
                label2.Text = "Error กรุณาเลือก ปี";
                return null;
            }
            int month = 0;
            if (!int.TryParse(cboMonth.SelectedValue.ToString(), out month))
            {
                MessageBox.Show("Error กรุณาเลือก เดือน", "Error");
                label2.Text = "Error กรุณาเลือก เดือน";
                return null;
            }
            int period = 0;
            if (!int.TryParse(cboPeriod.Text, out period))
            {
                MessageBox.Show("Error กรุณาเลือก งวด", "Error");
                label2.Text = "Error กรุณาเลือก งวด";
                return null;
            }
            year -= 543;
            

            Size size = new Size();
            C1PdfDocument pdf = new C1PdfDocument();
            C1PdfDocumentSource pds = new C1PdfDocumentSource();
            StringFormat _sfRight, _sfRightCenter;
            //Font _fontTitle = new Font("Tahoma", 15, FontStyle.Bold);
            _sfRight = new StringFormat();
            _sfRight.Alignment = StringAlignment.Far;
            _sfRightCenter = new StringFormat();
            _sfRightCenter.Alignment = StringAlignment.Far;
            _sfRightCenter.LineAlignment = StringAlignment.Center;

            Font titleFont = new Font("TH Sarabun New", 14, FontStyle.Bold);
            Font hdrFont = new Font("TH Sarabun New", 18, FontStyle.Regular);
            Font hdrFontB = new Font("TH Sarabun New", 14, FontStyle.Bold);
            Font ftrFont = new Font("TH Sarabun New", 14);
            Font txtFont = new Font("TH Sarabun New", 14, FontStyle.Regular);
            Font txtFonts = new Font("TH Sarabun New", 12, FontStyle.Regular);
            //Font txtFontB = new Font(bc.iniC.pdfFontName, bc.pdfFontSizetxtFontB, FontStyle.Bold);//
            Font txtFontB = new Font("TH Sarabun New", 14, FontStyle.Regular);
            pdf.FontType = FontTypeEnum.Embedded;
            pdf.PaperKind = PaperKind.A4;
            pdf.Landscape = false;

            RectangleF rcPage = pdf.PageRectangle;
            rcPage = RectangleF.Empty;
            rcPage.Inflate(-72, -92);
            rcPage.Location = new PointF(rcPage.X, rcPage.Y + titleFont.SizeInPoints + 10);
            rcPage.Size = new SizeF(0, titleFont.SizeInPoints + 3);
            rcPage.Width = 110;

            //logo
            Image loadedImage;
            loadedImage = Resources.atta60_48;
            float newWidth = loadedImage.Width * 100 / loadedImage.HorizontalResolution;
            float newHeight = loadedImage.Height * 100 / loadedImage.VerticalResolution;

            float widthFactor = 1F;
            float heightFactor = 1F;
            if (widthFactor > 1 | heightFactor > 1)
            {
                if (widthFactor > heightFactor)
                {
                    widthFactor = 1;
                    newWidth = newWidth / widthFactor;
                    newHeight = newHeight / widthFactor;
                    //newWidth = newWidth / 1.2;
                    //newHeight = newHeight / 1.2;
                }
                else
                {
                    newWidth = newWidth / heightFactor;
                    newHeight = newHeight / heightFactor;
                }
            }

            RectangleF recf = new RectangleF(15, 15, (int)newWidth, (int)newHeight);
            pdf.DrawImage(loadedImage, recf);//logo

            String txt = " บริษัท เอทีทีเอ2016 จำกัด  56/49 หมู่บ้านโครงการทาวร์พลัส เทพารักษ์ หมู่4 ถ.เทพารักษ์ ต.บางพลีใหญ่ อ.บางพลี จ.สมุทรปราการ 10540 ";
            rcPage.Y = gapY;
            rcPage.X = xCol1 + loadedImage.Width + 10;
            size = MeasureString(txt, txtFonts);
            rcPage.Width = size.Width;
            pdf.DrawString(txt, txtFonts, Brushes.Black, rcPage);

            gapY += gapLine;
            rcPage.Y = gapY;
            rcPage.X = xCol1 + loadedImage.Width + 10;
            txt = "โทร.0813518454 โทรสาร 02-1381165  เลขประจำตัวผู้เสียภาษี 0115559018740";
            size = MeasureString(txt, txtFonts);
            rcPage.Width = size.Width;
            pdf.DrawString(txt, txtFonts, Brushes.Black, rcPage);

            String aaa = "";
            //gapY += gapLine;
            gapY += gapLine;
            rcPage.Y = gapY;
            rcPage.X = xCol2;
            aaa = cboPeriod.Text.Equals("1") ? "ต้นเดือน " : "สิ้นเดือน ของเดือน ";
            if (flagDetail.Equals("item"))
            {
                txt = "รายละเอียด lab item ประจำ งวด " + aaa + cboMonth.Text + " ปี " + cboYear.Text;
                sql = "Select paid_type_name, sum(price3) as price3, sum(discount) as discount, sum(netprice) as netprice, lab_code, lab_name  " +
                "From lab_t_data " +
                "Where branch_id = '" + flagBr + "' and year_id = '" + year + "' and month_id = '" + month.ToString("00") + "' and period_id = '" + period + "'  " +
                "Group By paid_type_name, lab_code, lab_name " +
                "Order By paid_type_name, lab_code, lab_name; ";
                ConnectDB conn = new ConnectDB("mainhis", flagBr);
                dt = conn.selectDataMySQL(conn.connMySQL, sql);
            }
            else
            {
                txt = "รายละเอียด lab patient ประจำ งวด " + aaa + cboMonth.Text + " ปี " + cboYear.Text;
                sql = "Select paid_type_name, price3, discount, netprice, full_name, lab_code, lab_name, lab_date  " +
                "From lab_t_data " +
                "Where branch_id = '" + flagBr + "' and year_id = '" + year + "' and month_id = '" + month.ToString("00") + "' and period_id = '" + period + "'  " +
                //"Group By paid_type_name" +
                "Order By paid_type_name, full_name,lab_code; ";
                ConnectDB conn = new ConnectDB("mainhis", flagBr);
                dt = conn.selectDataMySQL(conn.connMySQL, sql);
            }
            size = MeasureString(txt, hdrFont);
            rcPage.Width = size.Width;
            pdf.DrawString(txt, hdrFont, Brushes.Black, rcPage);

            //gapY += gapLine;
            Boolean flagNewPage = false;
            if (dt.Rows.Count > 0)
            {
                int page = 0, rowinpage = 0, i = 0, rowingroup = 0;
                decimal sumnetpricepergroup = 0, netprice = 0, price3 = 0, discount = 0, sumnetprice = 0, sumdiscount = 0;
                page = (dt.Rows.Count % 43) + 1;
                gapLine = 17;
                foreach (DataRow drow in dt.Rows)
                {
                    rowinpage++;
                    i++;
                    rowingroup++;
                    paidname = drow["paid_type_name"].ToString();
                    decimal.TryParse(drow["netprice"].ToString(), out netprice);
                    decimal.TryParse(drow["price3"].ToString(), out price3);
                    decimal.TryParse(drow["discount"].ToString(), out discount);

                    if (i == 1)
                    {
                        paidnameold = paidname;
                    }
                    if (!paidname.Equals(paidnameold))
                    {
                        rowingroup = 1;
                        paidnameold = paidname;
                        flagNewPage = true;

                        //if (rowinpage == 35)
                        //{
                        gapY += gapLine;
                        rcPage.Y = gapY;
                        rcPage.X = xCol6;
                        txt = sumnetpricepergroup.ToString("#,###.00");
                        size = MeasureString(txt, txtFont);
                        rcPage.Width = size.Width;
                        pdf.DrawString(txt, txtFont, Brushes.Black, rcPage);
                        //}
                        sumnetpricepergroup = 0;
                    }
                    if (rowinpage == 43)
                    {
                        flagNewPage = true;
                    }
                    if (flagNewPage)
                    {
                        rowinpage = 0;
                        gapY = 20;
                        pdf.NewPage();
                        pdf.DrawImage(loadedImage, recf);//logo

                        txt = " บริษัท เอทีทีเอ2016 จำกัด  56/49 หมู่บ้านโครงการทาวร์พลัส เทพารักษ์ หมู่4 ถ.เทพารักษ์ ต.บางพลีใหญ่ อ.บางพลี จ.สมุทรปราการ 10540 ";
                        rcPage.Y = gapY;
                        rcPage.X = xCol1 + loadedImage.Width + 10;
                        size = MeasureString(txt, txtFonts);
                        rcPage.Width = size.Width;
                        pdf.DrawString(txt, txtFonts, Brushes.Black, rcPage);

                        gapY += gapLine;
                        rcPage.Y = gapY;
                        rcPage.X = xCol1 + loadedImage.Width + 10;
                        txt = "โทร.0813518454 โทรสาร 02-1381165  เลขประจำตัวผู้เสียภาษี 0115559018740";
                        size = MeasureString(txt, txtFonts);
                        rcPage.Width = size.Width;
                        pdf.DrawString(txt, txtFonts, Brushes.Black, rcPage);

                        //gapY += gapLine;
                        gapY += gapLine;
                        rcPage.Y = gapY;
                        rcPage.X = xCol2;
                        aaa = cboPeriod.Text.Equals("1") ? "ต้นเดือน " : "สิ้นเดือน ของเดือน ";
                        if (flagDetail.Equals("item"))
                        {
                            txt = "รายละเอียด lab item ประจำ งวด " + aaa + cboMonth.Text + " ปี " + cboYear.Text;
                        }
                        else
                        {
                            txt = "รายละเอียด lab patient ประจำ งวด " + aaa + cboMonth.Text + " ปี " + cboYear.Text;
                        }
                        size = MeasureString(txt, hdrFont);
                        rcPage.Width = size.Width;
                        pdf.DrawString(txt, hdrFont, Brushes.Black, rcPage);

                        rcPage.X = xCol5 + 50;
                        txt = paidname;
                        size = MeasureString(txt, hdrFont);
                        rcPage.Width = size.Width;
                        pdf.DrawString(txt, hdrFont, Brushes.Black, rcPage);
                        flagNewPage = false;
                    }

                    sumnetpricepergroup += netprice;
                    sumnetprice += netprice;
                    sumdiscount += discount;
                    gapY += gapLine;
                    rcPage.Y = gapY;
                    rcPage.X = xCol1;
                    txt = rowingroup.ToString();
                    size = MeasureString(txt, txtFont);
                    rcPage.Width = size.Width;
                    pdf.DrawString(txt, txtFont, Brushes.Black, rcPage);

                    if (flagDetail.Equals("item"))
                    {
                        rcPage.X = xCol11;
                        txt = drow["lab_code"].ToString() + " " + drow["lab_name"].ToString();
                        size = MeasureString(txt, txtFonts);
                        rcPage.Width = size.Width;
                        pdf.DrawString(txt, txtFonts, Brushes.Black, rcPage);
                    }
                    else
                    {
                        rcPage.X = xCol11;
                        txt = drow["full_name"].ToString();
                        size = MeasureString(txt, txtFont);
                        rcPage.Width = size.Width;
                        pdf.DrawString(txt, txtFont, Brushes.Black, rcPage);

                        rcPage.X = xCol3;
                        txt = drow["lab_code"].ToString() + " " + drow["lab_name"].ToString() + " " + drow["lab_date"].ToString();
                        size = MeasureString(txt, txtFonts);
                        rcPage.Width = size.Width;
                        pdf.DrawString(txt, txtFonts, Brushes.Black, rcPage);
                    }

                    rcPage.X = xCol5 + 50;
                    txt = price3.ToString("#,###.00");
                    size = MeasureString(txt, txtFont);
                    rcPage.Width = size.Width;
                    pdf.DrawString(txt, txtFont, Brushes.Black, rcPage);

                    rcPage.X = xCol6;
                    txt = discount.ToString("#,###.00");
                    size = MeasureString(txt, txtFont);
                    rcPage.Width = size.Width;
                    pdf.DrawString(txt, txtFont, Brushes.Black, rcPage);

                    rcPage.X = xCol6 + 50;
                    txt = netprice.ToString("#,###.00");
                    size = MeasureString(txt, txtFont);
                    rcPage.Width = size.Width;
                    pdf.DrawString(txt, txtFont, Brushes.Black, rcPage);

                    if (i == dt.Rows.Count)
                    {
                        gapY += gapLine;
                        rcPage.Y = gapY;
                        rcPage.X = xCol6;
                        txt = sumnetpricepergroup.ToString("#,###.00");
                        size = MeasureString(txt, txtFont);
                        rcPage.Width = size.Width;
                        pdf.DrawString(txt, txtFont, Brushes.Black, rcPage);
                    }
                }

                //พิมพ์ สุดท้าย 
                gapY += gapLine;
                gapY += gapLine;
                gapY += gapLine;
                rcPage.Y = gapY;
                rcPage.X = xCol4;
                txt = "ส่วนลดสุทธิ " + sumdiscount.ToString("#,###.00");
                size = MeasureString(txt, txtFont);
                rcPage.Width = size.Width;
                pdf.DrawString(txt, txtFont, Brushes.Black, rcPage);

                gapY += gapLine;
                rcPage.Y = gapY;
                rcPage.X = xCol4;
                txt = "รวมสุทธิ " + sumnetprice.ToString("#,###.00");
                size = MeasureString(txt, txtFont);
                rcPage.Width = size.Width;
                pdf.DrawString(txt, txtFont, Brushes.Black, rcPage);

            }

            MemoryStream mem = new MemoryStream();
            pdf.Save(mem);
            return mem;
        }
        private void btnPrnDetail_Click(object sender, EventArgs e)
        {
            showLbLoading();
            btnPrnDetail.Enabled = false;
            
            btnPrnDetail.Enabled = true;
            //hideLbLoading();
            MemoryStream mem = printBillDetail("");
            if (mem != null)
            {
                FrmShowPdf frm = new FrmShowPdf(mem);
                frm.ShowDialog(this);
            }
            hideLbLoading();
        }
        private void btnPrnSum_Click(object sender, EventArgs e)
        {
            showLbLoading();
            btnPrnSum.Enabled = false;
            DataTable dt = new DataTable();
            int gapLine = 20, gapLine1 = 15, gapX = 40, gapY = 20, xCol2 = 100, xCol1 = 20, xCol3 = 200, xCol4 = 300, xCol41 = 400, xCol5 = 400 ,xCol6=500;
            String sql = "", flagBr="";
            int year = 0;
            flagBr = chkBn1.Checked ? "1" : chkBn2.Checked ? "2" : chkBn5.Checked ? "5" : "";
            if (!int.TryParse(cboYear.Text, out year))
            {
                MessageBox.Show("Error กรุณาเลือก ปี", "Error");
                label2.Text = "Error กรุณาเลือก ปี";
                return;
            }
            int month = 0;
            if (!int.TryParse(cboMonth.SelectedValue.ToString(), out month))
            {
                MessageBox.Show("Error กรุณาเลือก เดือน", "Error");
                label2.Text = "Error กรุณาเลือก เดือน";
                return;
            }
            int period = 0;
            if (!int.TryParse(cboPeriod.Text, out period))
            {
                MessageBox.Show("Error กรุณาเลือก งวด", "Error");
                label2.Text = "Error กรุณาเลือก งวด";
                return;
            }
            year -= 543;
            sql = "Select  paid_type_name, count(1) as cnt, sum(price3) as price3, sum(discount) as discount, sum(netprice) as netprice  " +
                "From lab_t_data " +
                "Where branch_id = '"+ flagBr + "' and year_id = '"+ year + "' and month_id = '"+ month.ToString("00")+ "' and period_id = '"+ period + "'  " +
                "Group By paid_type_name " +
                "Order By paid_type_name; ";
            ConnectDB conn = new ConnectDB("mainhis", flagBr);
            dt = conn.selectDataMySQL(conn.connMySQL, sql);

            Size size = new Size();
            C1PdfDocument pdf = new C1PdfDocument();
            C1PdfDocumentSource pds = new C1PdfDocumentSource();
            StringFormat _sfRight, _sfRightCenter;
            //Font _fontTitle = new Font("Tahoma", 15, FontStyle.Bold);
            _sfRight = new StringFormat();
            _sfRight.Alignment = StringAlignment.Far;
            _sfRightCenter = new StringFormat();
            _sfRightCenter.Alignment = StringAlignment.Far;
            _sfRightCenter.LineAlignment = StringAlignment.Center;

            Font titleFont = new Font("TH Sarabun New", 14, FontStyle.Bold);
            Font hdrFont = new Font("TH Sarabun New", 18, FontStyle.Regular);
            Font hdrFontB = new Font("TH Sarabun New", 14, FontStyle.Bold);
            Font ftrFont = new Font("TH Sarabun New", 14);
            Font txtFont = new Font("TH Sarabun New", 14, FontStyle.Regular);
            Font txtFonts = new Font("TH Sarabun New", 12, FontStyle.Regular);
            //Font txtFontB = new Font(bc.iniC.pdfFontName, bc.pdfFontSizetxtFontB, FontStyle.Bold);//
            Font txtFontB = new Font("TH Sarabun New", 14, FontStyle.Regular);
            pdf.FontType = FontTypeEnum.Embedded;
            pdf.PaperKind = PaperKind.A4;
            pdf.Landscape = false;

            RectangleF rcPage = pdf.PageRectangle;
            rcPage = RectangleF.Empty;
            rcPage.Inflate(-72, -92);
            rcPage.Location = new PointF(rcPage.X, rcPage.Y + titleFont.SizeInPoints + 10);
            rcPage.Size = new SizeF(0, titleFont.SizeInPoints + 3);
            rcPage.Width = 110;
            //logo
            Image loadedImage;
            loadedImage = Resources.atta60_48;
            float newWidth = loadedImage.Width * 100 / loadedImage.HorizontalResolution;
            float newHeight = loadedImage.Height * 100 / loadedImage.VerticalResolution;

            float widthFactor = 1F;
            float heightFactor = 1F;
            if (widthFactor > 1 | heightFactor > 1)
            {
                if (widthFactor > heightFactor)
                {
                    widthFactor = 1;
                    newWidth = newWidth / widthFactor;
                    newHeight = newHeight / widthFactor;
                    //newWidth = newWidth / 1.2;
                    //newHeight = newHeight / 1.2;
                }
                else
                {
                    newWidth = newWidth / heightFactor;
                    newHeight = newHeight / heightFactor;
                }
            }

            RectangleF recf = new RectangleF(15, 15, (int)newWidth, (int)newHeight);
            pdf.DrawImage(loadedImage, recf);//logo

            String txt = " บริษัท เอทีทีเอ2016 จำกัด  56/49 หมู่บ้านโครงการทาวร์พลัส เทพารักษ์ หมู่4 ถ.เทพารักษ์ ต.บางพลีใหญ่ อ.บางพลี จ.สมุทรปราการ 10540 ";
            rcPage.Y = gapY;
            rcPage.X = xCol1 + loadedImage.Width + 10;
            size = MeasureString(txt, txtFonts);
            rcPage.Width = size.Width;
            pdf.DrawString(txt, txtFonts, Brushes.Black, rcPage);

            gapY += gapLine;
            rcPage.Y = gapY;
            rcPage.X = xCol1 + loadedImage.Width+10;
            txt = "โทร.0813518454 โทรสาร 02-1381165  เลขประจำตัวผู้เสียภาษี 0115559018740";
            size = MeasureString(txt, txtFonts);
            rcPage.Width = size.Width;
            pdf.DrawString(txt, txtFonts, Brushes.Black, rcPage);

            //gapY += gapLine;
            //rcPage.Y = gapY;
            //rcPage.X = xCol1 + loadedImage.Width + 10;
            //txt = "เลขประจำตัวผู้เสียภาษี 0115559018740";
            //size = MeasureString(txt, txtFonts);
            //rcPage.Width = size.Width;
            //pdf.DrawString(txt, txtFonts, Brushes.Black, rcPage);
            gapY += gapLine;
            gapY += gapLine;
            rcPage.Y = gapY;
            rcPage.X = xCol2;
            txt = "ใบวางบิล lab";
            size = MeasureString(txt, hdrFont);
            rcPage.Width = size.Width;
            pdf.DrawString(txt, hdrFont, Brushes.Black, rcPage);

            gapY += gapLine;
            rcPage.Y = gapY;
            rcPage.X = xCol2;
            String aaa = "";
            aaa = cboPeriod.Text.Equals("1") ? "ต้นเดือน " : "สิ้นเดือน ของเดือน ";
            txt = "ประจำ งวด " + aaa + cboMonth.Text + " ปี " + cboYear.Text;
            size = MeasureString(txt, hdrFont);
            rcPage.Width = size.Width;
            pdf.DrawString(txt, hdrFont, Brushes.Black, rcPage);

            gapY += gapLine;
            gapY += gapLine;
            rcPage.Y = gapY;
            rcPage.X = xCol1;
            txt = "ลำดับ";
            size = MeasureString(txt, hdrFont);
            rcPage.Width = size.Width;
            pdf.DrawString(txt, hdrFont, Brushes.Black, rcPage);
            rcPage.X = xCol2-50;
            txt = "ประเภทการรับชำระ";
            size = MeasureString(txt, hdrFont);
            rcPage.Width = size.Width;
            pdf.DrawString(txt, hdrFont, Brushes.Black, rcPage);
            rcPage.X = xCol3+30;
            txt = "จำนวน";
            size = MeasureString(txt, hdrFont);
            rcPage.Width = size.Width;
            pdf.DrawString(txt, hdrFont, Brushes.Black, rcPage);
            rcPage.X = xCol4;
            txt = "รวมราคา";
            size = MeasureString(txt, hdrFont);
            rcPage.Width = size.Width;
            pdf.DrawString(txt, hdrFont, Brushes.Black, rcPage);
            rcPage.X = xCol5;
            txt = "ส่วนลด";
            size = MeasureString(txt, hdrFont);
            rcPage.Width = size.Width;
            pdf.DrawString(txt, hdrFont, Brushes.Black, rcPage);
            rcPage.X = xCol6;
            txt = "ยอดสุทธิ";
            size = MeasureString(txt, hdrFont);
            rcPage.Width = size.Width;
            pdf.DrawString(txt, hdrFont, Brushes.Black, rcPage);

            double sumprice = 0, sumnettotal = 0, sumqty = 0, sumdis=0;
            double aa1a = 0;
            gapY += gapLine;
            gapY += gapLine;
            int i = 0;
            foreach(DataRow drow in dt.Rows)
            {
                i++;
                rcPage.Y = gapY;
                rcPage.X = xCol1;
                txt = i.ToString();
                double price = 0, nettotal = 0, qty = 0, dis = 0;
                double.TryParse(drow["cnt"].ToString(), out qty);
                double.TryParse(drow["netprice"].ToString(), out nettotal);
                double.TryParse(drow["price3"].ToString(), out price);
                double.TryParse(drow["discount"].ToString(), out dis);

                size = MeasureString(txt, hdrFont);
                rcPage.Width = size.Width;
                pdf.DrawString(txt, hdrFont, Brushes.Black, rcPage);
                rcPage.X = xCol2-50;
                txt = drow["paid_type_name"].ToString();
                size = MeasureString(txt, hdrFont);
                rcPage.Width = size.Width;
                pdf.DrawString(txt, hdrFont, Brushes.Black, rcPage);
                rcPage.X = xCol3+30;
                txt = qty.ToString("#,###.##");
                size = MeasureString(txt, hdrFont);
                rcPage.Width = size.Width;
                pdf.DrawString(txt, hdrFont, Brushes.Black, rcPage);
                rcPage.X = xCol4;
                //txt = price.ToString("#,###.##");
                txt = String.Format("{0:0,0.00}", price);
                size = MeasureString(txt, hdrFont);
                rcPage.Width = size.Width;
                pdf.DrawString(txt, hdrFont, Brushes.Black, rcPage);
                rcPage.X = xCol5;
                //txt = dis.ToString("#,###.##");
                txt = String.Format("{0:0,0.00}", dis);
                size = MeasureString(txt, hdrFont);
                rcPage.Width = size.Width;
                pdf.DrawString(txt, hdrFont, Brushes.Black, rcPage);
                rcPage.X = xCol6;
                //txt = nettotal.ToString("#,###.##");
                txt = String.Format("{0:0,0.00}", nettotal);
                size = MeasureString(txt, hdrFont);
                rcPage.Width = size.Width;
                pdf.DrawString(txt, hdrFont, Brushes.Black, rcPage);
                gapY += gapLine;
                
                sumqty += qty;
                sumnettotal += nettotal;
                sumprice += price;
                sumdis += dis;
            }
            gapY += gapLine;
            rcPage.Y = gapY;
            rcPage.X = xCol3;
            txt = sumqty.ToString("#,###.##");
            size = MeasureString(txt, hdrFont);
            rcPage.Width = size.Width;
            pdf.DrawString(txt, hdrFont, Brushes.Black, rcPage);
            rcPage.X = xCol4;
            //txt = sumprice.ToString("#,###.##");
            txt = String.Format("{0:0,0.00}", sumprice);
            size = MeasureString(txt, hdrFont);
            rcPage.Width = size.Width;
            pdf.DrawString(txt, hdrFont, Brushes.Black, rcPage);
            rcPage.X = xCol5;
            //txt = sumdis.ToString("#,###.##");
            txt = String.Format("{0:0,0.00}", sumdis);
            size = MeasureString(txt, hdrFont);
            rcPage.Width = size.Width;
            pdf.DrawString(txt, hdrFont, Brushes.Black, rcPage);
            rcPage.X = xCol6;
            //txt = sumnettotal.ToString("#,###.##");
            txt = String.Format("{0:0,0.00}", sumnettotal);
            size = MeasureString(txt, hdrFont);
            rcPage.Width = size.Width;
            pdf.DrawString(txt, hdrFont, Brushes.Black, rcPage);

            gapY += gapLine;
            gapY += gapLine;
            rcPage.X = xCol1;
            rcPage.Y = gapY;
            txt = "ผู้วางบิล ";
            size = MeasureString(txt, hdrFont);
            rcPage.Width = size.Width;
            pdf.DrawString(txt, hdrFont, Brushes.Black, rcPage);
            rcPage.X = xCol2;
            txt = "___________________________________________";
            size = MeasureString(txt, hdrFont);
            rcPage.Width = size.Width;
            pdf.DrawString(txt, hdrFont, Brushes.Black, rcPage);

            gapY += gapLine;
            rcPage.Y = gapY;
            rcPage.X = xCol1;
            txt = "วันที่ ";
            size = MeasureString(txt, hdrFont);
            rcPage.Width = size.Width;
            pdf.DrawString(txt, hdrFont, Brushes.Black, rcPage);
            rcPage.X = xCol2;
            txt = "___________________________________________";
            size = MeasureString(txt, hdrFont);
            rcPage.Width = size.Width;
            pdf.DrawString(txt, hdrFont, Brushes.Black, rcPage);

            gapY += gapLine;
            rcPage.Y = gapY;
            rcPage.X = xCol1;
            txt = "ผู้รับวางบิล ";
            size = MeasureString(txt, hdrFont);
            rcPage.Width = size.Width;
            pdf.DrawString(txt, hdrFont, Brushes.Black, rcPage);
            rcPage.X = xCol2;
            txt = "___________________________________________";
            size = MeasureString(txt, hdrFont);
            rcPage.Width = size.Width;
            pdf.DrawString(txt, hdrFont, Brushes.Black, rcPage);

            gapY += gapLine;
            rcPage.Y = gapY;
            rcPage.X = xCol1;
            txt = "วันที่รับวางบิล ";
            size = MeasureString(txt, hdrFont);
            rcPage.Width = size.Width;
            pdf.DrawString(txt, hdrFont, Brushes.Black, rcPage);
            rcPage.X = xCol2;
            txt = "___________________________________________";
            size = MeasureString(txt, hdrFont);
            rcPage.Width = size.Width;
            pdf.DrawString(txt, hdrFont, Brushes.Black, rcPage);


            MemoryStream mem = new MemoryStream();
            pdf.Save(mem);
            btnPrnSum.Enabled = true;
            hideLbLoading();

            FrmShowPdf frm = new FrmShowPdf(mem);
            frm.ShowDialog(this);
        }
        public Size MeasureString(String txt, Font font)
        {
            return TextRenderer.MeasureText(txt, font, new Size(int.MaxValue, int.MaxValue), TextFormatFlags.SingleLine | TextFormatFlags.NoClipping | TextFormatFlags.PreserveGraphicsClipping);
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            pB1.Show();
            Microsoft.Office.Interop.Excel.Application excelapp = new Microsoft.Office.Interop.Excel.Application();
            excelapp.Visible = false;
            //String visitDate = "", visitTime = "", err = "", err1 = "", pharName = "";

            Microsoft.Office.Interop.Excel._Workbook workbook = excelapp.Workbooks.Open(txtPath.Text);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.ActiveSheet;
            Microsoft.Office.Interop.Excel.Range xlRange = worksheet.UsedRange;
            int rowCount = xlRange.Rows.Count;
            int rowWork = 0, rowErr = 0, cntOK = 0, row1 = 9;
            pB1.Minimum = 0;
            pB1.Maximum = rowCount;
            ////worksheet.Cells[0, 0] = "patient name";
            String hnOld = "", hn1 = "", flagBr = "", labdateOld = "", err = "", labcodeOld = "", price31 = "", name="", price11="", price21="", doc="", date="", typepaid="", labname="", nameold="", typepaidold="", docold="", dateold = "";
            String sql = "", statusOutLab = "", statusDiscount = "", remark = "", netPrice1 = "", discPer="";
            flagBr = chkBn1.Checked ? "1" : chkBn2.Checked ? "2" : chkBn5.Checked ? "5" : "";
            int year = 0;
            if (!int.TryParse(cboYear.Text, out year))
            {
                MessageBox.Show("Error กรุณาเลือก ปี", "Error");
                label2.Text = "Error กรุณาเลือก ปี";
                return;
            }
            int month = 0;
            if (!int.TryParse(cboMonth.SelectedValue.ToString(), out month))
            {
                MessageBox.Show("Error กรุณาเลือก เดือน", "Error");
                label2.Text = "Error กรุณาเลือก เดือน";
                return;
            }
            int period = 0;
            if (!int.TryParse(cboPeriod.Text, out period))
            {
                MessageBox.Show("Error กรุณาเลือก งวด", "Error");
                label2.Text = "Error กรุณาเลือก งวด";
                return;
            }
            ConnectDB conn = new ConnectDB("mainhis", flagBr);
            conn.connMySQL.Open();
            ConnectDB conn1 = new ConnectDB("mainhis", flagBr);
            conn1.connMySQL.Open();
            Config1 cf = new Config1();
            Decimal noFind = 0, price3 = 0, netPrice=0, discount=0, discount1=0, discPer1=0, price2=0, price1=0;
            year -= 543;

            try
            {
                DataTable dt = new DataTable();
                sql = "Delete from lab_t_data where branch_id = '" + flagBr + "' and year_id = '" + year + "' and month_id = '" + month.ToString("00") + "' and period_id = '" + period + "'" ;
                String re = conn.ExecuteNonQueryNoClose(conn.connMySQL, sql);
                sql = "Select * From lab_b_discount Where active = '1' ";
                DataTable dtDis = new DataTable();
                dtDis = conn1.selectDataMySQLNoClose(conn1.connMySQL, sql);
                for (int i = 1; i <= rowCount; i++)
                {
                    try
                    {
                        err = "00";
                        if (i == 1) continue;
                        price3 = 0;
                        price2 = 0;
                        String hn = worksheet.Cells[i, 3].Value != null ? worksheet.Cells[i, 3].Value.ToString() : "";
                        String labdate = worksheet.Cells[i, 2].Value != null ? worksheet.Cells[i, 2].Value.ToString() : "";
                        String labcode = worksheet.Cells[i, 6].Value != null ? worksheet.Cells[i, 6].Value.ToString() : "";

                        discPer = "";
                        doc = worksheet.Cells[i, 1].Value != null ? worksheet.Cells[i, 1].Value.ToString() : "";
                        date = worksheet.Cells[i, 2].Value != null ? worksheet.Cells[i, 2].Value.ToString() : "";
                        name = worksheet.Cells[i, 4].Value != null ? worksheet.Cells[i, 4].Value.ToString() : "";
                        typepaid = worksheet.Cells[i, 5].Value != null ? worksheet.Cells[i, 5].Value.ToString() : "";
                        labname = worksheet.Cells[i, 7].Value != null ? worksheet.Cells[i, 7].Value.ToString() : "";
                        price11 = worksheet.Cells[i, 8].Value != null ? worksheet.Cells[i, 8].Value.ToString() : "";
                        price21 = worksheet.Cells[i, 9].Value != null ? worksheet.Cells[i, 9].Value.ToString() : "";
                        price31 = worksheet.Cells[i, 10].Value != null ? worksheet.Cells[i, 10].Value.ToString() : "";
                        decimal.TryParse(price31, out price3);
                        decimal.TryParse(price21, out price2);
                        decimal.TryParse(price11, out price1);
                        if (hn.Equals(""))
                        {
                            hn = hnOld;
                        }
                        else
                        {
                            hnOld = hn;
                        }
                        if (name.Equals(""))
                        {
                            name = nameold;
                        }
                        else
                        {
                            nameold = name;
                        }
                        if (labdate.Equals(""))
                        {
                            labdate = labdateOld;
                        }
                        else
                        {
                            labdateOld = labdate;
                        }
                        err = "01";
                        String labdate1 = "";
                        if (labdate.Length < 10) continue;
                        if (labcode.Equals(""))
                        {
                            labcode = labcodeOld;
                        }
                        else
                        {
                            labcodeOld = labcode;
                        }
                        if (typepaid.Equals(""))
                        {
                            typepaid = typepaidold;
                        }
                        else
                        {
                            typepaidold = typepaid;
                        }
                        if (doc.Equals(""))
                        {
                            doc = docold;
                        }
                        else
                        {
                            docold = doc;
                        }
                        if (date.Equals(""))
                        {
                            date = dateold;
                        }
                        else
                        {
                            dateold = date;
                        }
                        err = "02";
                        statusDiscount = "0";
                        if (labcode.Equals("PA042"))
                        {
                            statusOutLab = "0";
                        }
                        if (labcode.Equals("PA001"))
                        {
                            statusOutLab = "0";
                        }
                        if (labcode.Equals("PA041"))
                        {
                            statusOutLab = "0";
                        }
                        if (price3 <= 0)        //price3==0
                        {
                            price3 = price3 <= 0 ? price2 : price3;
                            price31 = price21;
                        }
                        if (price3 <= 0)        //คือ ถ้า price3 ยัง = 0  อีก ก็ให้เอา price1
                        {
                            price3 = price3 <= 0 ? price1 : price3;
                            price31 = price11;
                        }
                        //if ((strpos(strtoupper($result[7]), "OUTLAB") > 0) || (strpos(strtoupper($result[7]), "OUT LAB") > 0))PA042                        PA001                        PA041
                        if ((labname.ToUpper().IndexOf("OUTLAB") > 0) || (labname.ToUpper().IndexOf("OUT LAB") > 0))
                        {
                            statusOutLab = "1";
                            //remark = "เป็น out lab ไม่มีส่วนลด ใช้ราคา price2";
                            remark = "เป็น out lab ไม่มีส่วนลด ใช้ราคา price3";
                            //netPrice = ltb_i.getPriceSale2();//ไม่ให้ส่วนลด
                            //netPrice = price31;//ไม่ให้ส่วนลด
                            discount = 0;
                            discount1 = 0;
                            netPrice = price3;
                        }
                        else
                        {
                            statusOutLab = "0";
                            remark = "เป็น lab ทำเอง ----";
                            
                            
                            if (typepaid.Equals("ประกันสังคม"))
                            {
                                statusOutLab = "0";
                            }
                            foreach (DataRow rowDis in dtDis.Rows) 
                            {
                                if (rowDis["paid_discount"].ToString().IndexOf(typepaid) >= 0)
                                {
                                    statusDiscount = "1";
                                    discPer = rowDis["discount"].ToString();
                                }
                                //$strpos = strpos($type, $value[1]);
                            }
                            decimal.TryParse(discPer, out discPer1);
                            if (statusDiscount == "1")
                            {// discount per
                                remark += " ส่วนลดเป็น percent "+price3+" - ("+discPer+" * "+price3+"/100)";
                                //netPrice = (ltb_i.getPriceSale2() - (lbp.getDiscount()*ltb_i.getPriceSale2()/100));
                                discount1 = (discPer1 *price3 / 100);
                                netPrice = (price3 - discount1);
                            }
                            else
                            {
                                discount1 = 0;
                                netPrice = price3;// bug 
                            }
                        }
                        err = "03";
                        //labdate1 = cf.datetoDB(labdate);
                        labdate1 = (int.Parse(labdate.Substring(6)) - 543) + "-" + labdate.Substring(3, 2) + "-" + labdate.Substring(0, 2);

                        sql = "insert into lab_t_data set " +
                            "branch_id = '"+ flagBr + "'" +
                            ", month_id = '" + month.ToString("00") + "'" +
                            ", year_id = '" + year + "'" +
                            ", period_id = '" + period + "'" +
                            ", row1 = '" + flagBr + "'" +
                            ", doc_code = '" + doc + "'" +
                            ", lab_date = '" + date + "'" +
                            ", hn = '" + hn + "'" +
                            ", full_name = '" + name.Replace("'", "''") + "'" +
                            ", paid_type_name = '" + typepaid + "'" +
                            ", lab_code = '" + labcode + "'" +
                            ", lab_name = '" + labname.Replace("'","''") + "'" +
                            ", price1 = '" + price11 + "'" +
                            ", price2 = '" + price21 + "'" +
                            ", price3 = '" + price31 + "'" +
                            //", price4" +
                            //", price5" +
                            ", discount = '" + discount1 + "'" +
                            ", netprice = '" + netPrice + "'" +
                            ", remark = '" + remark.Replace("'", "''") + "'" +
                            ", status_discount = '" + statusDiscount + "'" +
                            ", status_outlab = '" + statusOutLab + "'" +
                            ", active = '1'" +
                            ", date_create = now()" +
                            //", data_header_id" +
                            ", row_no= '" + i + "'" +
                            "";
                        err = "04";
                        re = conn.ExecuteNonQueryNoClose(conn.connMySQL, sql);
                        long chk = 0;
                        
                        if (long.TryParse(re, out chk))
                        {
                            err = "05";
                            cntOK++;
                            worksheet.Cells[i, 16] = "ok";
                            worksheet.Cells[i, 17] = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                            //worksheet.Cells[i, 18] = "MNC_req_no " + dt.Rows[0]["MNC_req_no"].ToString() + "; MNC_PRE_NO " + dt.Rows[0]["MNC_PRE_NO"].ToString();
                        }
                        else
                        {
                            err = "06";
                            //sql = "";
                            row1++;
                            worksheet.Cells[row1, 15] = "row " + i + "; hn " + hn + "; labdate1 " + labdate1 + "; labcode " + labcode + " price3 " + price31;
                            worksheet.Cells[i, 16] = sql;
                            //price31 = worksheet.Cells[i, 10].Value != null ? worksheet.Cells[i, 10].Value.toString() : 0;
                            noFind += Decimal.Parse(price31);
                        }
                        err = "07";
                        pB1.Value = i;
                        rowWork++;
                    }
                    catch (Exception ex)
                    {
                        rowErr++;
                        MessageBox.Show("Error " + ex.Message + "\n row " + i+ "\n InnerException " + ex.InnerException, "error " + err);
                    }
                    //if (dgvAdd[colPatientHnno, i].Value == null)
                    //{
                    //    continue;
                    //}
                }
                worksheet.Cells[2, 15] = "year month period " + cboYear.Text + " " + cboMonth.Text + " " + cboPeriod.Text;
                worksheet.Cells[3, 15] = "row work " + rowWork;
                worksheet.Cells[4, 15] = "row error " + rowErr;
                worksheet.Cells[5, 15] = "row Excel " + rowCount;
                worksheet.Cells[6, 15] = "search find " + cntOK;
                worksheet.Cells[7, 15] = "search no find " + (rowCount - cntOK);
                worksheet.Cells[8, 15] = "amount no find " + noFind;

                GC.Collect();
                GC.WaitForPendingFinalizers();
                workbook.Save();
                workbook.Close();
                excelapp.Quit();
                conn.connMySQL.Close();
                conn1.connMySQL.Close();
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }

            MessageBox.Show("Insert Data เรียบร้อย ", "");
        }
        private void bthPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog res = new OpenFileDialog();
            res.Filter = "Excel Files|*.xls;";
            res.Filter = "All Files|*.*;";
            if (res.ShowDialog() == DialogResult.OK)
            {
                //Get the file's path
                txtPath.Text = res.FileName;
                //Do something
            }
            btnCheck.Enabled = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            if (!chkBn1.Checked && !chkBn2.Checked && !chkBn5.Checked)
            {
                MessageBox.Show("Error กรุณาเลือก สาขา บางนา", "Error");
                label2.Text = "Error กรุณาเลือก สาขา บางนา";
                return;
            }
            int year = 0;
            if (!int.TryParse(cboYear.Text, out year))
            {
                MessageBox.Show("Error กรุณาเลือก ปี", "Error");
                label2.Text = "Error กรุณาเลือก ปี";
                return;
            }
            int month = 0;
            if (!int.TryParse(cboMonth.SelectedValue.ToString(), out month))
            {
                MessageBox.Show("Error กรุณาเลือก เดือน", "Error");
                label2.Text = "Error กรุณาเลือก เดือน";
                return;
            }
            int period = 0;
            if (!int.TryParse(cboPeriod.Text, out period))
            {
                MessageBox.Show("Error กรุณาเลือก งวด", "Error");
                label2.Text = "Error กรุณาเลือก งวด";
                return;
            }

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(txtPath.Text);
            //Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.ActiveSheet;
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            var hn = xlWorksheet.Cells[2, 3].Value.ToString();
            String labdate = xlRange.Cells[2, 2].Value.ToString();

            if (hn.Length > 1)
            {
                if (hn.Substring(0, 1).Equals("1") && !chkBn1.Checked)
                {
                    MessageBox.Show("", "");
                    label2.Text = "Error สาขา บางนา ไม่ถูกต้อง กับ Excel";
                    return;
                }
                if (hn.Substring(0, 1).Equals("2") && !chkBn2.Checked)
                {
                    MessageBox.Show("", "");
                    label2.Text = "Error สาขา บางนา ไม่ถูกต้อง กับ Excel";
                    return;
                }
                if (hn.Substring(0, 1).Equals("5") && !chkBn5.Checked)
                {
                    MessageBox.Show("", "");
                    label2.Text = "Error สาขา บางนา ไม่ถูกต้อง กับ Excel";
                    return;
                }
            }
            else
            {
                MessageBox.Show("", "");
                label2.Text = "Error HN Excel";
                return;
            }
            String day = "";
            int day1 = 0;
            if (labdate.Length >= 10)
            {
                day = labdate.Substring(0, 2);
                int.TryParse(day, out day1);
                if((day1>16) && !(cboPeriod.SelectedIndex==1))
                {
                    MessageBox.Show("", "");
                    label2.Text = "Error Period Excel";
                    return;
                }
                else if (((day1 >= 1)) && (day1 < 16) && (cboPeriod.SelectedIndex == 1))
                {
                    MessageBox.Show("", "");
                    label2.Text = "Error Period Excel";
                    return;
                }
            }
            else
            {
                MessageBox.Show("", "");
                label2.Text = "Error Lab Date Excel";
                return;
            }
            
            int month1 = 0;
            if (labdate.Length >= 10)
            {
                //day = labdate.Substring(3, 2);
                int.TryParse(labdate.Substring(3, 2), out month1);
                if (!(cboMonth.SelectedIndex == (month1-1)))
                {
                    MessageBox.Show("", "");
                    label2.Text = "Error Month Excel";
                    return;
                }
            }
            else
            {
                MessageBox.Show("", "");
                label2.Text = "Error Lab Month Excel";
                return;
            }
            //String hn = xlRange.Cells[2, 3];

            GC.Collect();
            GC.WaitForPendingFinalizers();

            xlWorkbook.Close();
            xlApp.Quit();

            btnCheck.Enabled = true;
            label2.Text = "จำนวนข้อมูล "+rowCount.ToString()+" รายการ";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            pB1.Show();
            Microsoft.Office.Interop.Excel.Application excelapp = new Microsoft.Office.Interop.Excel.Application();
            excelapp.Visible = false;
            //String visitDate = "", visitTime = "", err = "", err1 = "", pharName = "";

            Microsoft.Office.Interop.Excel._Workbook workbook = excelapp.Workbooks.Open(txtPath.Text);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.ActiveSheet;
            Microsoft.Office.Interop.Excel.Range xlRange = worksheet.UsedRange;
            int rowCount = xlRange.Rows.Count;
            int rowWork = 0, rowErr = 0, cntOK=0, row1=9;
            pB1.Minimum = 0;
            pB1.Maximum = rowCount;
            ////worksheet.Cells[0, 0] = "patient name";
            String hnOld = "", hn1="", flagBr="", labdateOld="", err= "", labcodeOld="", price31="";
            flagBr = chkBn1.Checked ? "1" : chkBn2.Checked ? "2" : chkBn5.Checked ? "5" : "" ;
            ConnectDB conn = new ConnectDB("mainhis", flagBr);
            conn.connMainHIS5.Open();
            Config1 cf = new Config1();
            Decimal noFind = 0, price3=0;
            try
            {
                DataTable dt = new DataTable();
                for (int i = 1; i < rowCount; i++)
                {
                    try
                    {
                        if (i == 1) continue;
                        String hn = worksheet.Cells[i, 3].Value != null ? worksheet.Cells[i, 3].Value.ToString() : "";
                        String labdate = worksheet.Cells[i, 2].Value != null ? worksheet.Cells[i, 2].Value.ToString() : "";
                        String labcode = worksheet.Cells[i, 6].Value != null ? worksheet.Cells[i, 6].Value.ToString() : "";
                        price31 = worksheet.Cells[i, 10].Value != null ? worksheet.Cells[i, 10].Value.ToString() : "";
                        if (hn.Equals(""))
                        {
                            hn = hnOld;
                        }
                        else
                        {
                            hnOld = hn;
                        }
                        if (labdate.Equals(""))
                        {
                            labdate = labdateOld;
                        }
                        else
                        {
                            labdateOld = labdate;
                        }
                        String labdate1 = "";
                        if (labdate.Length < 10) continue;
                        if (labcode.Equals(""))
                        {
                            labcode = labcodeOld;
                        }
                        else
                        {
                            labcodeOld = labcode;
                        }
                        //labdate1 = cf.datetoDB(labdate);
                        labdate1 = (int.Parse(labdate.Substring(6)) - 543) + "-" + labdate.Substring(3, 2) + "-" + labdate.Substring(0, 2);

                        String sql = "";
                        sql = "select lab_t05.MNC_req_no,LAB_T01.MNC_PRE_NO " +
                            "from PATIENT_T01 " +
                            "inner join LAB_T01 on LAB_T01.mnc_hn_no = PATIENT_T01.mnc_hn_no " +
                            "and LAB_T01.mnc_pre_no = PATIENT_T01.mnc_pre_no " +
                            "and LAB_T01.mnc_date = PATIENT_T01.MNC_DATE " +
                            "inner join LAB_T05 on lab_t05.MNC_REQ_YR = lab_t01.MNC_REQ_YR " +
                            "and lab_t05.MNC_REQ_no = lab_t01.MNC_REQ_no " +
                            "and lab_t05.MNC_REQ_dat = lab_t01.MNC_REQ_dat " +
                            "where lab_t05.MNC_REQ_DAT >= '" + labdate1 + "' " +
                            "and lab_t05.MNC_REQ_DAT <= '" + labdate1 + "' " +
                            //"and patient_t01.MNC_STS = 'f' " +
                            //"and LAB_T01.MNC_REQ_STS = 'Q' " +
                            "and LAB_T01.mnc_hn_no ='" + hn + "' " +
                            "and lab_t05.mnc_lb_cd ='" + labcode + "'";
                        dt.Clear();
                        dt = conn.selectDataNoClose(sql);
                        if (dt.Rows.Count > 0)
                        {
                            cntOK++;
                            worksheet.Cells[i, 16] = "ok";
                            worksheet.Cells[i, 17] = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                            worksheet.Cells[i, 18] = "MNC_req_no " + dt.Rows[0]["MNC_req_no"].ToString() + "; MNC_PRE_NO " + dt.Rows[0]["MNC_PRE_NO"].ToString();
                        }
                        else
                        {
                            //sql = "";
                            row1++;
                            worksheet.Cells[row1, 15] = "row "+i+"; hn "+hn+ "; labdate1 "+ labdate1+ "; labcode " + labcode+" price3 "+price31;
                            worksheet.Cells[i, 16] = sql;
                            //price31 = worksheet.Cells[i, 10].Value != null ? worksheet.Cells[i, 10].Value.toString() : 0;
                            noFind += Decimal.Parse(price31);
                        }
                        
                        pB1.Value = i;
                        rowWork++;
                    }
                    catch (Exception ex)
                    {
                        rowErr++;
                        //MessageBox.Show("Error " + ex.Message + "\n row " + i, "error " + err);
                    }
                    //if (dgvAdd[colPatientHnno, i].Value == null)
                    //{
                    //    continue;
                    //}

                }
                worksheet.Cells[2, 15] = "year month period "+cboYear.Text+" "+cboMonth.Text+" "+cboPeriod.Text;
                worksheet.Cells[3, 15] = "row work "+ rowWork;
                worksheet.Cells[4, 15] = "row error " + rowErr;
                worksheet.Cells[5, 15] = "row Excel " + rowCount;
                worksheet.Cells[6, 15] = "search find " + cntOK;
                worksheet.Cells[7, 15] = "search no find " + (rowCount - cntOK);
                worksheet.Cells[8, 15] = "amount no find " + noFind;

                GC.Collect();
                GC.WaitForPendingFinalizers();
                workbook.Save();
                workbook.Close();
                excelapp.Quit();
                conn.connMainHIS5.Close();
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }

            MessageBox.Show("Check Data เรียบร้อย ", "");
            ////worksheet.Cells[1, 1] = "Name";
            ////worksheet.Cells[1, 2] = "Bid";

            ////worksheet.Cells[2, 1] = txbName.Text;
            ////worksheet.Cells[2, 2] = txbResult.Text;
            //pB1.Hide();
            //excelapp.UserControl = true;
            //excelapp.Visible = true;
        }
        private void setLbLoading(String txt)
        {
            lbLoading.Text = txt;
            Application.DoEvents();
        }
        private void showLbLoading()
        {
            lbLoading.Show();
            lbLoading.BringToFront();
            Application.DoEvents();
        }
        private void hideLbLoading()
        {
            lbLoading.Hide();
            Application.DoEvents();
        }
        private void FrmBillLabCheckExcel_Load(object sender, EventArgs e)
        {
            this.Text = "Update 2021-09-07";

            Rectangle screenRect = Screen.GetBounds(Bounds);
            //lbLoading.Location = new Point((screenRect.Width / 2) - 100, (screenRect.Height / 2) - 300);
            lbLoading.Location = new Point(100, 100);
            lbLoading.Text = "กรุณารอซักครู่ ...";
            lbLoading.Hide();
        }
    }
}
