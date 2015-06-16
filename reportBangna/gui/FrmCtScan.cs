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
    public partial class FrmCtScan : Form
    {
        public FrmCtScan()
        {
            InitializeComponent();
            pB1.Hide();
        }
        private void ShowEFilm(String hn)
        {
            //string destFile1 = System.IO.Path.Combine("D:\\501xxxx" + txtHN.Text);
            string sourceFile = System.IO.Path.Combine("\\\\172.25.10.5\\image\\ctscan\\2015\\" + hn);

            string destFile = System.IO.Path.Combine("D:\\ctscan\\");
            bool isdir = System.IO.Directory.Exists(sourceFile);
            if (!isdir)
            {
                return;
            }


            System.IO.DirectoryInfo downloadedMessageInfo = new DirectoryInfo(destFile);
            if (downloadedMessageInfo.Exists)
            {
                foreach (string dirPath in Directory.GetDirectories(destFile, "*", SearchOption.AllDirectories))
                {
                    //Directory.CreateDirectory(dirPath.Replace(sourceFile, destFile + "501yyyy"));
                    foreach (string newPath in Directory.GetFiles(destFile, "*.*", SearchOption.AllDirectories))
                    {
                        if (newPath.Replace(destFile, "").ToLower().Equals("ctscan.exe"))
                        {
                            continue;
                        }
                        File.Delete(newPath);
                    }
                    //Directory.Delete(dirPath);
                }
                //Directory.Delete(sourceFile+"\\501xxxx");

                foreach (DirectoryInfo dir in downloadedMessageInfo.GetDirectories())
                {
                    dir.Delete(true);
                }
            }



            //System.IO.File.Copy(sourceFile, destFile, true);
            pB1.Show();
            //Now Create all of the directories
            
            bool isExists = System.IO.Directory.Exists(destFile);
            if (!isExists)
                System.IO.Directory.CreateDirectory(destFile);
            foreach (string dirPath in Directory.GetDirectories(sourceFile, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(sourceFile, destFile));

            }

            //Copy all the files & Replaces any files with the same name
            String[] aa = Directory.GetFiles(sourceFile, "*.*", SearchOption.AllDirectories);
            int i = 0;
            pB1.Maximum = aa.Length;
            foreach (string newPath in Directory.GetFiles(sourceFile, "*.*", SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(sourceFile, destFile), true);
                i++;
                pB1.Value = i;
            }
            pB1.Hide();








            Process p = new Process();
            p.StartInfo.FileName = destFile + "\\eFilmLt.exe";
            //p.StartInfo.Arguments = "/c dir *.cs";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.Start();

            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            Application.Exit();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowEFilm(txtHN.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    System.IO.Directory.Delete(@"\\172.25.10.5\image\ctscan\2015\501yyyy");
            //}
            //catch (System.IO.IOException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    return;
            //}
            string sourceFile = System.IO.Path.Combine("\\\\172.25.10.5\\image\\ctscan\\2015\\");
            foreach (string dirPath in Directory.GetDirectories(sourceFile, "*", SearchOption.AllDirectories))
            {
                //Directory.CreateDirectory(dirPath.Replace(sourceFile, destFile + "501yyyy"));
                foreach (string newPath in Directory.GetFiles(sourceFile, "*.*", SearchOption.AllDirectories))
                {
                    File.Delete(newPath);
                }
                //Directory.Delete(dirPath);
            }
            //Directory.Delete(sourceFile+"\\501xxxx");
            System.IO.DirectoryInfo downloadedMessageInfo = new DirectoryInfo(sourceFile);
            foreach (DirectoryInfo dir in downloadedMessageInfo.GetDirectories())
            {
                dir.Delete(true);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sourceFile = System.IO.Path.Combine("D:\\501xxxx");
            string destFile = System.IO.Path.Combine("\\\\172.25.10.5\\image\\ctscan\\2015\\");

            string sourceFile1 = System.IO.Path.Combine("D:\\ctscan\\");
            foreach (string dirPath in Directory.GetDirectories(sourceFile1, "*", SearchOption.AllDirectories))
            {
                //Directory.CreateDirectory(dirPath.Replace(sourceFile, destFile + "501yyyy"));
                foreach (string newPath in Directory.GetFiles(sourceFile1, "*.*", SearchOption.AllDirectories))
                {
                    File.Delete(newPath);
                }
                //Directory.Delete(dirPath);
            }
            //Directory.Delete(sourceFile+"\\501xxxx");
            System.IO.DirectoryInfo downloadedMessageInfo = new DirectoryInfo(sourceFile1);
            foreach (DirectoryInfo dir in downloadedMessageInfo.GetDirectories())
            {
                dir.Delete(true);
            }


            //System.IO.File.Copy(sourceFile, destFile, true);
            pB1.Show();
            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(sourceFile, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(sourceFile, destFile + "501yyyy"));
                
            }

            //Copy all the files & Replaces any files with the same name
            String[] aa = Directory.GetFiles(sourceFile, "*.*", SearchOption.AllDirectories);
            int i = 0;
            pB1.Maximum = aa.Length;
            foreach (string newPath in Directory.GetFiles(sourceFile, "*.*",SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(sourceFile, destFile + "501yyyy"), true);
                i++;
                pB1.Value = i;
            }
            pB1.Hide();
        }

        private void txtHN_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string destFile = System.IO.Path.Combine("\\\\172.25.10.5\\image\\ctscan\\2015\\");
                //string[] dirPath1 = Directory.GetDirectories(destFile, "*", SearchOption.AllDirectories);
                //dgv1.RowCount = dirPath1.Length;
                dgv1.ColumnCount = 1;
                //int i = 0;
                String aaa = "-";
                foreach (string dirPath in Directory.GetDirectories(destFile, "*", SearchOption.AllDirectories))
                {
                    String folder = dirPath.Replace(destFile, "");
                    if (folder.IndexOf(aaa) >= 0)
                    {
                        continue;
                    }
                    int i = dgv1.Rows.Add();
                    aaa = folder;
                    dgv1[0, i].Value = folder;
                    i++;
                }
            }
        }

        private void FrmCtScan_Load(object sender, EventArgs e)
        {

        }

        private void dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (dgv1[0, e.RowIndex].Value == null)
            {
                return;
            }
            ShowEFilm(dgv1[0, e.RowIndex].Value.ToString());
        }
    }
}
