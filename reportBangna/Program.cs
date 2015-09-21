using reportBangna.gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reportBangna
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (System.Diagnostics.Process.GetCurrentProcess().ProcessName.ToLower().Equals("labex"))
            {
                //MessageBox.Show("labex", "labex");
                Application.Run(new FrmLabExView());
            }
            else if (System.Diagnostics.Process.GetCurrentProcess().ProcessName.ToLower().Equals("certificates"))
            {
                Application.Run(new FrmCertificatesView());
            }
            else if (System.Diagnostics.Process.GetCurrentProcess().ProcessName.ToLower().Equals("checknhso"))
            {
                Application.Run(new FrmCheckNHSO());
            }
            else if (System.Diagnostics.Process.GetCurrentProcess().ProcessName.ToLower().Equals("ctscan"))
            {
                Application.Run(new FrmCtScan());
            }
            else if (System.Diagnostics.Process.GetCurrentProcess().ProcessName.ToLower().Equals("labexdoctor"))
            {
                //MessageBox.Show("labexdoctor", "labexdoctor");
                Application.Run(new FrmLabExDoctor());
            }
            else
            {
                //MessageBox.Show("else", "else");
                //Application.Run(new FrmMain());
                //Application.Run(new FrmCtScan());
                //Application.Run(new FrmLabExView());
                //Application.Run(new FrmCheckNHSO());
                //Application.Run(new FrmDischargeSearch());
                //Application.Run(new FrmLabExDoctor());
                //Application.Run(new FrmCertificatesView());
                //Application.Run(new FrmStMain());
                Application.Run(new FrmStMain());
            }
            //Application.Run(new FrmMain());
            //Application.Run(new FrmPatientDead());
            //Application.Run(new FrmReAdmit());
            
            //Application.Run(new FrmHosRiskAdd());
            //Application.Run(new FrmCertificatesView());
            //Application.Run(new FrmChangeBed());
            //Application.Run(new FrmReVisit());
            //Application.Run(new FrmLabExView());
        }
    }
}
