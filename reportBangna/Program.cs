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
            //Application.Run(new FrmMain());
            //Application.Run(new FrmPatientDead());
            //Application.Run(new FrmReAdmit());
            //Application.Run(new FrmCheckNHSO());
            //Application.Run(new FrmHosRiskAdd());
            //Application.Run(new FrmCertificatesView());
            //Application.Run(new FrmChangeBed());
            Application.Run(new FrmReVisit());
        }
    }
}
