using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace reportBangna.gui
{
    public partial class FrmNHSOPrint : Form
    {
        BangnaControl bc;
        int colhn = 1, colNameT = 2, colvn = 3, colRow = 0, colpreno=4, colFnCD=5, colDate=6, colDoctor=7, colPdf=8,colChk=9, colbirthday=10, colID=11, colDisc=12, colWeight=13, colAn=14, colPdf1=15;
        int colCnt = 16;
        public FrmNHSOPrint()
        {
            InitializeComponent();
            initConfig();
        }
        private void genPDF(int row, String chk)
        {
            pB1.Visible = true;
            //float gutter = 15f;
            System.Drawing.Font font = new System.Drawing.Font("Microsoft Sans Serif", 12);
            iTextSharp.text.pdf.BaseFont bfR, bfR1;
            iTextSharp.text.BaseColor clrBlack = new iTextSharp.text.BaseColor(0, 0, 0);
            //MemoryStream ms = new MemoryStream();
            string myFont = Environment.CurrentDirectory + "\\THSarabun.ttf";
            String hn = "", name = "", doctor="", fncd="", birthday="", dsDate="", dsTime="", an="";
            
            decimal total = 0;

            bfR = BaseFont.CreateFont(myFont, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            bfR1 = BaseFont.CreateFont(myFont, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font fntHead = new iTextSharp.text.Font(bfR, 12, iTextSharp.text.Font.NORMAL, clrBlack);
            if(dgvView[colhn, row].Value == null)
            {
                return;
            }
            hn = dgvView[colhn, row].Value.ToString();
            name = dgvView[colNameT, row].Value.ToString();
            doctor = dgvView[colDoctor, row].Value.ToString();
            fncd = dgvView[colFnCD, row].Value.ToString();
            birthday = dgvView[colbirthday, row].Value.ToString();
            dsDate = bc.selectDSDateAN(dgvView[colhn, row].Value.ToString(), dgvView[colvn, row].Value.ToString(), dgvView[colpreno, row].Value.ToString());
            String[] aa = dsDate.Split(',');
            if (aa.Length > 1)
            {
                dsDate = aa[0];
                an = aa[1];
            }
            String[] bb = dsDate.Split('*');
            if (bb.Length > 1)
            {
                dsDate = bb[0];
                dsTime = bb[1];
            }

            ////name = "aaaaaaaa";
            //Document doc = new Document(PageSize.A4);
            //float colwidth = (doc.Right - doc.Left - gutter) / 2;
            //var output = new FileStream(Environment.CurrentDirectory + "\\" + hn + ".pdf", FileMode.Create);
            //var writer = PdfWriter.GetInstance(doc, output);
            //float[] left = { doc.Left + 90f , doc.Top - 80f, doc.Left + 90f, doc.Top - 170f, doc.Left, doc.Top - 170f, doc.Left , doc.Bottom };

            //float[] right = { doc.Left + colwidth, doc.Top - 80f, doc.Left + colwidth, doc.Bottom };

            //doc.Open();
            
            var logo = iTextSharp.text.Image.GetInstance(Environment.CurrentDirectory + "\\LOGO-BW-tran.jpg");
            logo.SetAbsolutePosition(10, PageSize.A4.Height - 90);
            logo.ScaleAbsoluteHeight(70);
            logo.ScaleAbsoluteWidth(70);
            //doc.Add(logo);

            //PdfContentByte cb = writer.DirectContent;
            //ColumnText ct = new ColumnText(cb);
            //ct.Alignment = Element.ALIGN_JUSTIFIED;
            //ct.AddText(new Phrase("โรงพยาบาล บางนา5"));
            //ct.SetColumns(left, right);

            ////doc.Add(logo);
            ////doc.Add(table);
            //doc.Close();
            //output.Close();

            //string pdfpath = Server.MapPath("PDFs");
            //string imagepath = Server.MapPath("Images");
            FontFactory.RegisterDirectory("C:\\WINDOWS\\Fonts");

            Document doc = new Document(PageSize.A4,36,36,36,36);
            //iTextSharp.text.Font font1 = new iTextSharp.text.Font(FontFactory.GetFont("adobe garamond pro", 36f, Color.GRAY));
            //iTextSharp.text.Font font2 = new iTextSharp.text.Font(Font.TIMES_ROMAN, 9f);
            //doc.SetMargins(45f, 45f, 60f, 60f);
            try
            {
                DataTable dt;
                if (chk.Equals(""))
                {
                    dt = bc.selectNHSOPrintHN(dgvView[colDate, row].Value.ToString(), dgvView[colhn, row].Value.ToString(), dgvView[colpreno, row].Value.ToString(), dgvView[colvn, row].Value.ToString());
                }
                else
                {
                    dt = bc.selectNHSOPrintHNAll(dgvView[colDate, row].Value.ToString(), dgvView[colhn, row].Value.ToString(), dgvView[colpreno, row].Value.ToString(), dgvView[colvn, row].Value.ToString());
                }
                
                FileStream output = new FileStream(Environment.CurrentDirectory + "\\"+hn+".pdf", FileMode.Create);
                PdfWriter writer = PdfWriter.GetInstance(doc, output);
                doc.Open();
                //PdfContentByte cb = writer.DirectContent;
                //ColumnText ct = new ColumnText(cb);
                //ct.Alignment = Element.ALIGN_JUSTIFIED;

                //Paragraph heading = new Paragraph("Chapter 1", fntHead);
                //heading.Leading = 30f;
                //doc.Add(heading);
                //Image L = Image.GetInstance(imagepath + "/l.gif");
                //logo.SetAbsolutePosition(doc.Left, doc.Top - 180);
                doc.Add(logo);

                //doc.Add(new Paragraph("Hello World", fntHead));

                Chunk c;
                String foobar = "Foobar Film Festival";
                //float width_helv = bfR.GetWidthPoint(foobar, 12);
                //c = new Chunk(foobar + ": " + width_helv, fntHead);
                //doc.Add(new Paragraph(c));

                //if (dt.Rows.Count > 24)
                //{
                //    doc.NewPage();
                //    doc.Add(new Paragraph(string.Format("This is a page {0}", 2)));
                //}
                int i = 0, r = 0, row2=0, rowEnd=24;
                r = dt.Rows.Count;
                int next = r / 24;
                for (int p = 0; p <= next; p++)
                {
                    PdfContentByte canvas = writer.DirectContent;
                    //canvas.SaveState();
                    //canvas.SetLineWidth(0.05f);
                    //canvas.MoveTo(400, 806);
                    //canvas.LineTo(400, 626);
                    //canvas.MoveTo(508.7f, 806);
                    //canvas.LineTo(508.7f, 626);
                    //canvas.MoveTo(280, 788);
                    //canvas.LineTo(520, 788);
                    //canvas.MoveTo(280, 752);
                    //canvas.LineTo(520, 752);
                    //canvas.MoveTo(280, 716);
                    //canvas.LineTo(520, 716);
                    //canvas.MoveTo(280, 680);
                    //canvas.LineTo(520, 680);
                    //canvas.MoveTo(280, 644);
                    //canvas.LineTo(520, 644);
                    //canvas.Stroke();
                    //canvas.RestoreState();
                    // Adding text with PdfContentByte.showTextAligned()
                    canvas.BeginText();
                    canvas.SetFontAndSize(bfR, 12);
                    canvas.ShowTextAligned(Element.ALIGN_LEFT, "โรงพยาบาล บางนา5", 100, 800, 0);
                    canvas.ShowTextAligned(Element.ALIGN_LEFT, "55 หมู่4 ถนนเทพารักษ์ ตำบลบางพลีใหญ่ อำเภอบางพลี จังหวัด สมุทรปราการ 10540", 100, 780, 0);
                    canvas.EndText();

                    canvas.BeginText();
                    canvas.SetFontAndSize(bfR, 18);
                    canvas.ShowTextAligned(Element.ALIGN_CENTER, "ใบแจ้งเรียกเก็บเงิน", PageSize.A4.Width / 2, 740, 0);
                    canvas.EndText();

                    canvas.BeginText();
                    canvas.SetFontAndSize(bfR, 16);
                    canvas.ShowTextAligned(Element.ALIGN_LEFT, "นามผู้ป่วย " + name, 60, 720, 0);
                    canvas.ShowTextAligned(Element.ALIGN_LEFT, "ชื่อแพทย์ผู้รักษา " + doctor, 60, 700, 0);
                    canvas.ShowTextAligned(Element.ALIGN_LEFT, "สิทธิการรักษา " + fncd, 60, 680, 0);
                    canvas.ShowTextAligned(Element.ALIGN_LEFT, "HN " + dgvView[colhn, row].Value.ToString() + "     AN " + an, 360, 720, 0);
                    canvas.ShowTextAligned(Element.ALIGN_LEFT, "วัน/เวลา เข้ารับการรักษา " + dgvView[colDate, row].Value.ToString(), 360, 700, 0);
                    canvas.ShowTextAligned(Element.ALIGN_LEFT, "วัน/เวลา จำหน่าย " + bc.cf.dateDBtoShowShort(bc.cf.datetoDB(dsDate)) + " " + dsTime, 360, 680, 0);
                    canvas.ShowTextAligned(Element.ALIGN_LEFT, "วันเกิด " + birthday + "     น้ำหนัก " + dgvView[colWeight, row].Value.ToString(), 360, 660, 0);
                    canvas.EndText();

                    canvas.BeginText();
                    canvas.SetFontAndSize(bfR, 16);
                    canvas.ShowTextAligned(Element.ALIGN_LEFT, "วัน/เวลา", 50, 620, 0);
                    canvas.ShowTextAligned(Element.ALIGN_LEFT, "รายการ", 250, 620, 0);
                    canvas.ShowTextAligned(Element.ALIGN_LEFT, "จำนวน", 405, 620, 0);
                    canvas.ShowTextAligned(Element.ALIGN_LEFT, "ราคา", 460, 620, 0);
                    canvas.ShowTextAligned(Element.ALIGN_LEFT, "รวมราคา", 510, 620, 0);
                    //canvas.ShowTextAlignedKerned(Element.ALIGN_LEFT, "ชื่อแพทย์ผู้รักษา "+ 60, 660, 644, 0);
                    //canvas.ShowTextAlignedKerned(Element.ALIGN_LEFT, "ชื่อแพทย์ผู้รักษา " + 60, 640, 644, 0);
                    canvas.EndText();
                    // More lines to see where the text is added
                    canvas.SaveState();
                    canvas.SetLineWidth(0.05f);
                    canvas.MoveTo(40, 640);//vertical
                    canvas.LineTo(40, 110);

                    canvas.MoveTo(40, 640);//Hericental
                    canvas.LineTo(560, 640);

                    canvas.MoveTo(560, 640);//vertical
                    canvas.LineTo(560, 110);

                    canvas.MoveTo(40, 610);//Hericental
                    canvas.LineTo(560, 610);

                    canvas.MoveTo(40, 110);//Hericental
                    canvas.LineTo(560, 110);

                    canvas.MoveTo(100, 640);//vertical
                    canvas.LineTo(100, 110);

                    canvas.MoveTo(400, 640);//vertical
                    canvas.LineTo(400, 110);

                    canvas.MoveTo(440, 640);//vertical QTY
                    canvas.LineTo(440, 110);

                    canvas.MoveTo(500, 640);//vertical Price
                    canvas.LineTo(500, 110);

                    //canvas.MoveTo(520, 640);//vertical Amount
                    //canvas.LineTo(520, 110);
                    canvas.Stroke();
                    canvas.RestoreState();
                    pB1.Maximum = dt.Rows.Count;
                    if (dt.Rows.Count > 0)
                    {
                        //PdfContentByte canvas1 = writer.DirectContent;
                        float row1 = 620f;
                        int cnt = 20;
                        total = 0;
                        //String amt = "";
                        canvas.BeginText();
                        canvas.SetFontAndSize(bfR, 10);
                        //int page = 0;
                        //page = dt.Rows.Count / 30;

                        for (i = row2; i < r && i <= rowEnd; i++)
                        {
                            row1 -= cnt;
                            //amt = String.Format("{0:#,###,###.00}", dt.Rows[i]["amt"]);
                            total += decimal.Parse(dt.Rows[i]["amt"].ToString());
                            //canvas.ShowTextAligned(Element.ALIGN_LEFT, bc.cf.dateLabExShow(dt.Rows[i]["MNC_CFG_DAT"].ToString()), 45, row1, 0);
                            canvas.ShowTextAligned(Element.ALIGN_LEFT, bc.cf.dateDBtoShowShort(bc.cf.datetoDB(dt.Rows[i]["MNC_CFG_DAT"].ToString())), 45, row1, 0);
                            
                            canvas.ShowTextAligned(Element.ALIGN_LEFT, dt.Rows[i]["MNC_PH_TN"].ToString() + " [" + dt.Rows[i]["MNC_PH_cd"].ToString() + "]", 105, row1, 0);
                            canvas.ShowTextAligned(Element.ALIGN_LEFT, dt.Rows[i]["qty"].ToString(), 415, row1, 0);
                            canvas.ShowTextAligned(Element.ALIGN_RIGHT, String.Format("{0:#,###,###.00}", dt.Rows[i]["MNC_PH_PRI01"]), 495, row1, 0);
                            canvas.ShowTextAligned(Element.ALIGN_RIGHT, String.Format("{0:#,###,###.00}", dt.Rows[i]["amt"]), 555, row1, 0);
                            pB1.Value = i;
                            //if (i >= 24)
                            //{
                            //    writer.NewPage();
                            //}
                        }
                        canvas.EndText();
                    }
                    canvas.BeginText();
                    canvas.SetFontAndSize(bfR, 16);
                    canvas.ShowTextAligned(Element.ALIGN_LEFT, "รวม ", 445, 100, 0);
                    canvas.ShowTextAligned(Element.ALIGN_RIGHT, String.Format("{0:#,###,###.00}", total), 555, 100, 0);
                    canvas.EndText();

                    String icd10 = "", icd9 = "";
                    icd10 = bc.selectDiaCDbyVN(dgvView[colhn, row].Value.ToString(), dgvView[colvn, row].Value.ToString(), dgvView[colpreno, row].Value.ToString());
                    icd9 = bc.selectICD9byVN(dgvView[colhn, row].Value.ToString(), dgvView[colvn, row].Value.ToString(), dgvView[colpreno, row].Value.ToString());
                    canvas.BeginText();
                    canvas.SetFontAndSize(bfR, 16);

                    canvas.ShowTextAligned(Element.ALIGN_LEFT, "ICD10 " + icd10, 60, 80, 0);

                    canvas.ShowTextAligned(Element.ALIGN_LEFT, "ICD9   " + icd9, 60, 60, 0);
                    //canvas.ShowTextAligned(Element.ALIGN_LEFT, String.Format("{0:#,###,###.00}", total), 505, 80, 0);
                    //canvas.ShowTextAligned(Element.ALIGN_LEFT, "ICD9 ", 60, 60, 0);
                    //canvas.ShowTextAligned(Element.ALIGN_LEFT, String.Format("{0:#,###,###.00}", total), 505, 60, 0);
                    canvas.EndText();
                    if(p < next)
                    {
                        doc.NewPage();
                        doc.Add(logo);
                        row2 += 25;
                        rowEnd += 24;
                    }

                }


                
                //Phrase phrase = new Phrase(foobar, fntHead);
                //ColumnText.ShowTextAligned(canvas, Element.ALIGN_LEFT, phrase, 200, 572, 0);
                //ColumnText.ShowTextAligned(canvas, Element.ALIGN_RIGHT, phrase, 200, 536, 0);
                //ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, phrase, 200, 500, 0);
                //ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, phrase, 200, 464, 30);
                //ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, phrase, 200, 428, -30);
                //// Chunk attributes
                //c = new Chunk(foobar, fntHead);
                //c.SetHorizontalScaling(0.5f);
                //phrase = new Phrase(c);
            }
            catch (Exception ex)
            {
                //Log(ex.Message);
            }
            finally
            {
                doc.Close();
                Process p = new Process();
                ProcessStartInfo s = new ProcessStartInfo(Environment.CurrentDirectory+"\\"+hn+".pdf");
                //s.Arguments = "/c dir *.cs";
                p.StartInfo=s;
                //p.StartInfo.Arguments = "/c dir *.cs";
                //p.StartInfo.UseShellExecute = false;
                //p.StartInfo.RedirectStandardOutput = true;
                p.Start();

                //string output = p.StandardOutput.ReadToEnd();
                //p.WaitForExit();
                //Application.Exit();
            }
            pB1.Visible = false;
        }

        private void dgvView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (dgvView[colvn, e.RowIndex].Value == null)
            {
                return;
            }
            if (dgvView[colpreno, e.RowIndex].Value == null)
            {
                return;
            }
            
            if (e.ColumnIndex == colPdf)
            {
                genPDF(e.RowIndex,"1");
            }
            else
            {
                genPDF(e.RowIndex,"");
            }
            
        }

        private void FrmNHSOPrint_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            pB1.Visible = true;
            pB1.Maximum = dgvView.RowCount;
            for (int i = 0; i < dgvView.RowCount; i++)
            {
                //xlNewSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlSheets.Add(xlSheets[1], Type.Missing, Type.Missing, Type.Missing);
                //xlNewSheet.Name = dgvView[colhn, i].Value.ToString();
                //xlNewSheet.Cells[6, 1] = dgvView[colNameT, i].Value.ToString();
                //xlNewSheet.Cells[8, 1] = dgvView[colFnCD, i].Value.ToString();
                //xlNewSheet.Cells[7, 1] = dgvView[colDoctor, i].Value.ToString();

                //xlNewSheet.Cells[6, 5] = dgvView[colhn, i].Value.ToString();
                //xlNewSheet.Cells[9, 5] = dgvView[colDate, i].Value.ToString();
                pB1.Value = i;
                genPDF(i,"");
            }
            pB1.Visible = false;
        }

        private void initConfig()
        {
            bc = new BangnaControl();
            pB1.Visible = false;

            txtAn.KeyUp += TxtAn_KeyUp;
        }

        private void TxtAn_KeyUp(object sender, KeyEventArgs e)
        {
            //throw new NotImplementedException();
            if(e.KeyCode == Keys.Enter)
            {
                int rowIndex = -1;
                dgvView.ClearSelection();
                foreach (DataGridViewRow row in dgvView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value == DBNull.Value || cell.Value == null)
                            continue;
                        if (cell.Value.ToString().Contains(txtAn.Text))
                        {
                            rowIndex = row.Index;
                            cell.Selected = true;
                            break;
                        }
                    }
                }

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            setGrd();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            pB1.Visible = true;
            pB1.Maximum = dgvView.RowCount;
            for (int i = 0; i < dgvView.RowCount; i++)
            {
                //xlNewSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlSheets.Add(xlSheets[1], Type.Missing, Type.Missing, Type.Missing);
                //xlNewSheet.Name = dgvView[colhn, i].Value.ToString();
                //xlNewSheet.Cells[6, 1] = dgvView[colNameT, i].Value.ToString();
                //xlNewSheet.Cells[8, 1] = dgvView[colFnCD, i].Value.ToString();
                //xlNewSheet.Cells[7, 1] = dgvView[colDoctor, i].Value.ToString();

                //xlNewSheet.Cells[6, 5] = dgvView[colhn, i].Value.ToString();
                //xlNewSheet.Cells[9, 5] = dgvView[colDate, i].Value.ToString();
                pB1.Value = i;
                genPDF(i,"");
            }
            pB1.Visible = false;
        }
        private void setResize()
        {
            dgvView.Width = this.Width - 80;
            dgvView.Height = this.Height - 150;
            //btnOK.Left = dgvView.Width - 50;
            //btnPrint.Left = dgvView.Width + 20;
            //groupBox1.Width = this.Width - 50;
            //groupBox1.Height = this.Height = 150;
        }
        private void FrmNHSOPrint_Load(object sender, EventArgs e)
        {

        }
        private void setGrd()
        {
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            pB1.Visible = true;
            String sql = "", datestart = "", dateend = "";
            datestart = dtpStart.Value.Year.ToString() + "-" + dtpStart.Value.ToString("MM-dd");
            dateend = dtpEnd.Value.Year.ToString() + "-" + dtpEnd.Value.ToString("MM-dd");
            System.Drawing.Font font = new System.Drawing.Font("Microsoft Sans Serif", 12);
            DataTable dt = new DataTable();

            dgvView.ColumnCount = colCnt;
            dgvView.Rows.Clear();
            dgvView.RowCount = 1;
            dgvView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvView.EditMode = DataGridViewEditMode.EditOnF2;
            dgvView.Columns[colhn].Width = 80;
            dgvView.Columns[colNameT].Width = 300;
            dgvView.Columns[colvn].Width = 80;
            dgvView.Columns[colRow].Width = 40;
            dgvView.Columns[colDoctor].Width = 150;
            dgvView.Columns[colDate].Width = 110;
            dgvView.Columns[colFnCD].Width = 80;
            dgvView.Columns[colPdf].Width = 50;

            dgvView.Columns[colRow].HeaderText = "no";
            dgvView.Columns[colhn].HeaderText = "HN";
            dgvView.Columns[colNameT].HeaderText = "Name";

            dgvView.Columns[colvn].HeaderText = "vn";
            dgvView.Columns[colDate].HeaderText = "วันเข้ารักษา";
            dgvView.Columns[colDoctor].HeaderText = "แพทย์ผู้ตรวจ";
            dgvView.Columns[colPdf].HeaderText = " ";
            dgvView.Columns[colDisc].HeaderText = "ds date";
            dgvView.Columns[colFnCD].HeaderText = "สิทธิ";
            dgvView.Columns[colAn].HeaderText = "an no";
            dt = bc.selectNHSOPrint(datestart, dateend,"");
            pB1.Maximum = dt.Rows.Count;
            //dgvPE.Columns[colPEId].HeaderText = "id";
            if (dt.Rows.Count > 0)
            {
                dgvView.RowCount = dt.Rows.Count+1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvView[colRow, i].Value = (i + 1);
                    dgvView[colhn, i].Value = dt.Rows[i]["mnc_hn_no"].ToString();
                    dgvView[colNameT, i].Value = dt.Rows[i]["MNC_PFIX_DSC"].ToString()+" "+ dt.Rows[i]["MNC_FNAME_T"].ToString()+" "+ dt.Rows[i]["MNC_LNAME_T"].ToString() + " [" + dt.Rows[i]["MNC_id_no"].ToString()+"]";
                    dgvView[colvn, i].Value = dt.Rows[i]["mnc_vn_no"].ToString() + "." + dt.Rows[i]["MNC_VN_SEQ"].ToString() + "." + dt.Rows[i]["MNC_VN_SUM"].ToString();
                    dgvView[colpreno, i].Value = dt.Rows[i]["MNC_PRE_NO"].ToString();
                    dgvView[colFnCD, i].Value = bc.cf.shortPaidName(dt.Rows[i]["MNC_FN_TYP_DSC"].ToString());
                    dgvView[colDate, i].Value = bc.cf.dateDBtoShowShort(bc.cf.datetoDB(dt.Rows[i]["MNC_DATE"].ToString()))+" "+ bc.FormatTime(dt.Rows[i]["MNC_time"].ToString());
                    dgvView[colDoctor, i].Value = dt.Rows[i]["prefix"].ToString() + " " + dt.Rows[i]["Fname"].ToString() + " " + dt.Rows[i]["Lname"].ToString()+ " [" + dt.Rows[i]["mnc_dot_cd"].ToString() + "] ";
                    dgvView[colPdf, i].Value = "PDF";
                    dgvView[colbirthday, i].Value = bc.cf.dateDBtoShowShort(bc.cf.datetoDB(dt.Rows[i]["MNC_BDAY"].ToString()));
                    dgvView[colDisc, i].Value = bc.cf.dateDBtoShowShort(bc.cf.datetoDB(dt.Rows[i]["mnc_ds_date"].ToString()));
                    dgvView[colID, i].Value = dt.Rows[i]["mnc_id_no"].ToString();
                    dgvView[colWeight, i].Value = dt.Rows[i]["mnc_weight"].ToString();
                    dgvView[colAn, i].Value = dt.Rows[i]["mnc_an_no"].ToString();
                    int cnt = bc.selectNHSOPrintHN1(dgvView[colDate, i].Value.ToString(), dgvView[colhn, i].Value.ToString(), dgvView[colpreno, i].Value.ToString(), dgvView[colvn, i].Value.ToString());
                    //if ((i % 2) != 0)
                    dgvView[colChk, i].Value = cnt > 0 ? "1" : "0";
                    dgvView.Rows[i].DefaultCellStyle.BackColor = cnt > 0 ? Color.LightSalmon : Color.White;

                    pB1.Value = i;
                }
            }
            for(int i = 0; i < dgvView.Rows.Count; i++)
            {
                if(dgvView[colChk, i].Value == null)
                {
                    continue;
                }
                if (dgvView[colChk, i].Value.ToString().Equals("0"))
                {
                    dgvView.Rows.RemoveAt(i);
                    i--;
                }                
            }
            for (int i = 0; i < dgvView.Rows.Count; i++)
            {
                dgvView[colRow, i].Value = (i + 1);
            }

                dgvView.Font = font;
            dgvView.Columns[colpreno].Visible = false;
            dgvView.Columns[colChk].Visible = false;
            dgvView.Columns[colWeight].Visible = false;
            //dgvView.Columns[colAn].Visible = false;
            dgvView.Columns[colID].Visible = false;
            dgvView.Columns[colbirthday].Visible = false;
            //dgvView.Columns[colPdf].Visible = false;
            pB1.Visible = false;
            Cursor.Current = cursor;
        }
        private void FrmNHSOPrint_Resize(object sender, EventArgs e)
        {
            setResize();
        }
    }
}
