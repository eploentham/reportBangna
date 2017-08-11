using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace reportBangna.gui
{
    public partial class FrmCheckNHSOImportNamePatient : Form
    {
        public FrmCheckNHSOImportNamePatient()
        {
            InitializeComponent();
            txtdbName.Text = "bangna";
            txthostDB.Text = "localhost";
            txtPasswordDB.Text = "";
            txtUserDB.Text = "root";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Text (*.Txt)|*.Txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {                
                label2.Text = openFileDialog1.FileName;                
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            String txt = "", id="",id1="", pname="", fname="", lname="", hospcode="", birthday="", hn="";
            String connString = "", sql="";
            connString = "server="+txthostDB.Text+ ";database="+txtdbName.Text+ ";user id="+txtUserDB.Text+ ";password="+txtPasswordDB.Text+ ";port=3306;Character Set=utf8";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection();
            MySql.Data.MySqlClient.MySqlCommand com = new MySql.Data.MySqlClient.MySqlCommand();
            conn.ConnectionString = connString;
            conn.Open();
            com.Connection = conn;
            if (chkDelete.Checked)
            {
                com.CommandText = "Delete From hn_t_data";
                com.ExecuteNonQuery();
            }
            int row1 = 0;
            BangnaControl bc = new BangnaControl();
            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead(label2.Text))
            using (var streamReader = new StreamReader(fileStream, Encoding.GetEncoding("TIS-620"), true, BufferSize))
            {
                String line;
                
                while ((line = streamReader.ReadLine()) != null)
                {
                    row1++;
                    txt = line;
                    id = line.Substring(0, 13);
                    id1 = line.Substring(13, 13);
                    pname = line.Substring(26, 15).Trim();
                    fname = line.Substring(41, 30).Trim();
                    lname = line.Substring(71, 28).Trim();
                    hospcode = line.Substring(103, 7).Trim();
                    birthday = line.Substring(126, 4).Trim()+"-"+ line.Substring(130, 2).Trim() + "-" + line.Substring(132, 2).Trim();
                    //hn=bc.selectPatientHN(id);
                    sql = "Insert Into hn_t_data(data_id, branch_id, month_id, year_id, period_id"
                        +", row1, id, full_name, fname,lname, pname"
                        +", id1, hosp_code, date_birthday, hn, date_create) "
                        +"Values(UUID(), '','','','' "
                        +", '"+row1+"', '"+id+"', '"+ pname + " "+fname+" "+lname + "', '" + fname + "', '" + lname + "', '" + pname + "', '"
                        +id1+"', '"+hospcode + "', '" + birthday + "', '" + hn + "', now())";
                    com.CommandText = sql;
                    com.ExecuteNonQuery();
                }
                  // Process line
            }
        }
    }
}
