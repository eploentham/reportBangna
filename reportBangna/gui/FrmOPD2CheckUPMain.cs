using C1.C1Excel;
using C1.Win.C1FlexGrid;
using reportBangna.object1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace reportBangna.gui
{
    public partial class FrmOPD2CheckUPMain : Form
    {
        BangnaControl bc;
        C1FlexGrid grf;

        int colvsdate = 1, colhn = 2, colpcom = 3, colpcash = 4, colc1 = 5, colc2 = 6, colc3 = 7, colc4 = 8, collab = 9, colva = 10, colcxr = 11, colekg = 12, colcom = 13, colcash = 14, colpaidname = 15, colpaidcode = 16, coldsc = 17, colstatus = 18;
        public FrmOPD2CheckUPMain()
        {
            InitializeComponent();
            initConfig();
        }
        private void initConfig()
        {
            bc = new BangnaControl();
            btnPrintOPD21TrueStar.Click += BtnPrintOPD21TrueStar_Click;
            btnPrintLicenseDriver.Click += BtnPrintLicenseDriver_Click;
            btnRpt.Click += BtnRpt_Click;
            btnGrf.Click += BtnGrf_Click;
        }

        private void BtnGrf_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Font fEdit;
            
            Form frm = new Form();
            DataTable dt = new DataTable();
            String vsdate = "";
            DateTime dtDate = new DateTime();
            DateTime.TryParse(dtpDate.Text, out dtDate);
            if (dtDate.Year > 2500)
            {
                dtDate = dtDate.AddYears(-543);
            }
            else if (dtDate.Year < 2000)
            {
                dtDate = dtDate.AddYears(543);
            }
            vsdate = dtDate.ToString("yyyy-MM-dd", new CultureInfo("en-US"));
            dt = bc.vsdb.selectVisitByDate(vsdate, cboDept.Text);
            fEdit = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);

            frm.Size = new Size(600, 800);
            frm.StartPosition = FormStartPosition.CenterScreen;

            grf = new C1FlexGrid();
            grf.Font = fEdit;
            grf.Dock = System.Windows.Forms.DockStyle.Fill;
            grf.Location = new System.Drawing.Point(0, 0);
            grf.DoubleClick += Grf_DoubleClick;
            ContextMenu menuGw = new ContextMenu();
            menuGw.MenuItems.Add("case ฝากครรภ์", new EventHandler(ContextMenu_case_preg));
            menuGw.MenuItems.Add("case ตรวจสุขภาพ", new EventHandler(ContextMenu_casepackage));
            menuGw.MenuItems.Add("ไม่สนใจ", new EventHandler(ContextMenu_nocase));
            grf.ContextMenu = menuGw;

            
            grf.Rows.Count = 1;
            //grfQue.Rows.Count = 1;
            grf.Cols.Count = 19;
            grf.Cols[colvsdate].Caption = "Date";
            grf.Cols[colhn].Caption = "HN";
            grf.Cols[colpcom].Caption = "pcom";
            grf.Cols[colpcash].Caption = "pcash";
            grf.Cols[colc1].Caption = "C1";
            grf.Cols[colc2].Caption = "C2";
            grf.Cols[colc3].Caption = "C3";
            grf.Cols[colc4].Caption = "C4";
            grf.Cols[collab].Caption = "LAB";
            grf.Cols[colva].Caption = "VA";
            grf.Cols[colcxr].Caption = "CXR";
            grf.Cols[colekg].Caption = "EKG";
            grf.Cols[colcom].Caption = "com";
            grf.Cols[colcash].Caption = "cash";
            grf.Cols[colpaidname].Caption = "สิทธิ";
            grf.Cols[colpaidcode].Caption = "code";
            grf.Cols[coldsc].Caption = "dsc";

            grf.Cols[colvsdate].Width = 100;
            grf.Cols[colhn].Width = 80;
            grf.Cols[colpcom].Width = 40;
            grf.Cols[colpcash].Width = 40;
            grf.Cols[colc1].Width = 40;
            grf.Cols[colc2].Width = 40;
            grf.Cols[colc3].Width = 40;
            grf.Cols[colc4].Width = 40;
            grf.Cols[collab].Width = 40;
            grf.Cols[colva].Width = 40;
            grf.Cols[colcxr].Width = 40;
            grf.Cols[colekg].Width = 40;
            grf.Cols[coldsc].Width = 300;
            grf.Cols[colpaidcode].Width = 40;
            grf.Cols[colcom].Width = 60;
            grf.Cols[colcash].Width = 60;
            grf.Rows.Count = dt.Rows.Count + 1;
            int i = 1;
            foreach (DataRow row in dt.Rows)
            {
                grf[i, 0] = (i);
                grf[i, colhn] = row["mnc_hn_no"].ToString();
                grf[i, colvsdate] = row["mnc_date"].ToString();
                grf[i, colpaidname] = row["MNC_FN_TYP_DSC"].ToString();
                grf[i, colpaidcode] = row["MNC_FN_TYP_cd"].ToString();
                grf[i, colcash] = row["mnc_sum_pri"].ToString();
                grf[i, coldsc] = row["MNC_SHIF_MEMO"].ToString();
                if (row["MNC_FN_TYP_cd"].ToString().Equals("18"))
                {
                    grf.Rows[i].StyleNew.BackColor = ColorTranslator.FromHtml("#EADBC4");
                    grf[i, colstatus] = "package";
                }
                else if (row["MNC_SHIF_MEMO"].ToString().IndexOf("ครร")>0)
                {
                    grf.Rows[i].StyleNew.BackColor = ColorTranslator.FromHtml("#b7e1cd");
                    grf[i, colstatus] = "preg";
                }
                else
                {
                    grf[i, colstatus] = "";
                }
                i++;
            }
            grf.Cols[colstatus].Visible = false;
            grf.Cols[colvsdate].AllowEditing = false;
            grf.Cols[colhn].AllowEditing = false;
            grf.Cols[colpcom].AllowEditing = false;
            grf.Cols[colpcash].AllowEditing = false;
            grf.Cols[colc1].AllowEditing = false;
            grf.Cols[colc2].AllowEditing = false;
            grf.Cols[colc3].AllowEditing = false;
            grf.Cols[colc4].AllowEditing = false;
            grf.Cols[collab].AllowEditing = false;
            grf.Cols[colva].AllowEditing = false;
            grf.Cols[colcxr].AllowEditing = false;
            grf.Cols[colekg].AllowEditing = false;
            grf.Cols[coldsc].AllowEditing = false;
            frm.Controls.Add(grf);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog(this);
        }
        private void ContextMenu_case_preg(object sender, System.EventArgs e)
        {
            grf.Rows[grf.Row].StyleNew.BackColor = ColorTranslator.FromHtml("#EADBC4");
            grf[grf.Row, colstatus] = "package";
        }
        private void ContextMenu_casepackage(object sender, System.EventArgs e)
        {
            grf.Rows[grf.Row].StyleNew.BackColor = ColorTranslator.FromHtml("#b7e1cd");
            grf[grf.Row, colstatus] = "preg";
        }
        private void ContextMenu_nocase(object sender, System.EventArgs e)
        {
            grf.Rows[grf.Row].StyleNew.BackColor = Color.White;
            grf[grf.Row, colstatus] = "";
        }
        private void Grf_DoubleClick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if (grf.Row <= 0) return;
            if (grf.Col <= 0) return;
            grf[grf.Row, grf.Col] = "1";
        }

        private void BtnRpt_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            //C1FlexGrid grf;
            LogWriter lw = new LogWriter();
            //Form frm;
            DataTable dt = new DataTable();
            String vsdate = "";
            DateTime dtDate = new DateTime();
            DateTime.TryParse(dtpDate.Text, out dtDate);
            if (dtDate.Year > 2500)
            {
                dtDate = dtDate.AddYears(-543);
            }
            else if (dtDate.Year < 2000)
            {
                dtDate = dtDate.AddYears(543);
            }
            lw.WriteLog("FrmOPD2CheckUPMain BtnRpt_Click dtpDate.Text " + dtpDate.Text);
            vsdate = dtDate.ToString("yyyy-MM-dd", new CultureInfo("en-US"));
            lw.WriteLog("FrmOPD2CheckUPMain BtnRpt_Click vsdate " + vsdate);

            dt = bc.vsdb.selectVisitByDate(vsdate, cboDept.Text);
            if (dt.Rows.Count>0)
            {
                CreateExcelFile(dt, vsdate);
            }
        }
        private string CreateExcelFile(DataTable dt, String vsdate)
        {
            //clear Excel book, remove the single blank sheet
            C1.C1Excel.C1XLBook _c1xl = new C1.C1Excel.C1XLBook();
            XLStyle _styTitle;
            XLStyle _styHeader;
            XLStyle _styMoney;
            XLStyle _styOrder;
            _c1xl.Clear();
            _c1xl.Sheets.Clear();
            _c1xl.DefaultFont = new Font("Tahoma", 8);

            //create Excel styles
            _styTitle = new XLStyle(_c1xl);
            _styHeader = new XLStyle(_c1xl);
            _styMoney = new XLStyle(_c1xl);
            _styOrder = new XLStyle(_c1xl);

            //set up styles
            _styTitle.Font = new Font(_c1xl.DefaultFont.Name, 15, FontStyle.Bold);
            _styTitle.ForeColor = Color.Blue;
            _styHeader.Font = new Font(_c1xl.DefaultFont, FontStyle.Bold);
            _styHeader.ForeColor = Color.White;
            _styHeader.BackColor = Color.DarkGray;
            _styMoney.Format = XLStyle.FormatDotNetToXL("c");
            _styOrder.Font = _styHeader.Font;
            _styOrder.ForeColor = Color.Red;

            //create report with one sheet per category
            //DataTable dt = GetCategories();
            //foreach (DataRow dr in dt.Rows)
            //{
            //    CreateSheet(_c1xl,dr);
            //}
            CreateSheet(_c1xl, _styTitle, _styHeader, _styOrder, _styMoney, dt, vsdate);
            //save xls file
            String datetick = "", pathfile="";
            pathfile = Application.StartupPath;
            datetick = DateTime.Now.Ticks.ToString();
            pathfile = pathfile + "\\excel\\";
            if (!Directory.Exists(pathfile))
            {
                Directory.CreateDirectory(pathfile);
                Application.DoEvents();
            }

            string filename = pathfile + "\\daily.xls";
            _c1xl.Save(filename);
            Process.Start("explorer.exe", pathfile);
            return filename;
        }
        private void CreateSheet(C1XLBook _c1xl, XLStyle _styTitle, XLStyle _styHeader, XLStyle _styOrder, XLStyle _styMoney, DataTable dt, String vsdate)
        {
            //get current category name
            string catName = "ucep";

            //add a new worksheet to the workbook 
            //('/' is invalid in sheet names, so replace it with '+')
            string sheetName = catName.Replace("/", " + ");
            XLSheet sheet = _c1xl.Sheets.Add(sheetName);

            //add title to worksheet
            sheet[0, 0].Value = catName;
            sheet.Rows[0].Style = _styTitle;

            // set column widths (in twips)
            sheet.Columns[0].Width = 1000;
            sheet.Columns[1].Width = 500;
            sheet.Columns[2].Width = 1000;
            sheet.Columns[3].Width = 500;
            sheet.Columns[4].Width = 500;
            sheet.Columns[5].Width = 500;
            sheet.Columns[6].Width = 500;
            sheet.Columns[7].Width = 500;
            sheet.Columns[8].Width = 500;
            sheet.Columns[9].Width = 500;
            sheet.Columns[10].Width = 500;
            sheet.Columns[11].Width = 500;
            sheet.Columns[12].Width = 500;
            sheet.Columns[13].Width = 500;
            sheet.Columns[14].Width = 500;
            sheet.Columns[15].Width = 500;
            sheet.Columns[16].Width = 2000;
            sheet.Columns[17].Width = 500;
            //add column headers
            int row = 0;
            sheet.Rows[row].Style = _styHeader;

            sheet[row, 0].Value = "Date";
            sheet[row, 1].Value = "no";
            sheet[row, 2].Value = "HN";
            sheet[row, 3].Value = "com";
            sheet[row, 4].Value = "cash";
            sheet[row, 5].Value = "C1";
            sheet[row, 6].Value = "C2";
            sheet[row, 7].Value = "C3";
            sheet[row, 8].Value = "C4";
            sheet[row, 9].Value = "LAB";
            sheet[row, 10].Value = "VA";
            sheet[row, 11].Value = "eye";
            sheet[row, 12].Value = "CXR";
            sheet[row, 13].Value = "EKG";
            sheet[row, 14].Value = "com";
            sheet[row, 15].Value = "cash";
            sheet[row, 16].Value = "paid type";
            sheet[row, 17].Value = "paid code";
            //loop through products in this category
            //DataRow[] products = dr.GetChildRows("Categories_Products");
            foreach (DataRow drow in dt.Rows)
            {
                row++;
                sheet[row, 0].Value = vsdate;
                sheet[row, 1].Value = row;
                sheet[row, 2].Value = drow["mnc_hn_no"].ToString();
                sheet[row, 15].Value = drow["mnc_sum_pri"].ToString();
                sheet[row, 16].Value = drow["MNC_FN_TYP_DSC"].ToString();
                sheet[row, 17].Value = drow["MNC_FN_TYP_cd"].ToString();
                //sheet[row, 6].Value = drow["price_total"].ToString();
            }
            //if (products.Length == 0)
            //{
            //    row++;
            //    sheet[row, 1].Value = "No products in this category";
            //}
        }
        private void BtnPrintLicenseDriver_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            FrmOPDLicenseDriver frm = new FrmOPDLicenseDriver(bc);
            frm.ShowDialog();
        }

        private void BtnPrintOPD21TrueStar_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            FrmOPD21CheckUP frm = new FrmOPD21CheckUP(bc, "truestar");
            frm.ShowDialog();
        }

        private void btnPrintOPD2_Click(object sender, EventArgs e)
        {
            FrmOPD2CheckUP frm = new FrmOPD2CheckUP(bc,"");
            frm.ShowDialog();
        }

        private void btnPrintOPD21_Click(object sender, EventArgs e)
        {
            FrmOPD21CheckUP frm = new FrmOPD21CheckUP(bc,"");
            frm.ShowDialog();
        }

        private void FrmOPD2CheckUPMain_Load(object sender, EventArgs e)
        {

        }
    }
}
