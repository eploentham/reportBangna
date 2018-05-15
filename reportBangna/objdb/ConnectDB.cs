using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using reportBangna.object1;

namespace reportBangna.objdb
{
    public class ConnectDB
    {
        public String Unamelogin = "";
        public OleDbConnection cntemp = new OleDbConnection();
        public int portnumber = 0;
        public String UName = "", User1 = "", SS = "";
        public OleDbConnection _mainConnection = new OleDbConnection();
        public int _rowsAffected = 0;
        public SqlInt32 _errorCode = 0;
        public Boolean _isDisposed = false;
        public SqlConnection connMainHIS5,connMainHIS1, connMainHIS2;
        private String hostname = "";
        private IniFile iniFile;
        public String databaseNameMainHIS5 = "",databaseNameMainHIS1 = "", databaseNameMainHIS2 = "";
        public String hostNameMainHIS5 = "", hostNameMainHIS1 = "", hostNameMainHIS2 = "";
        public String userNameMainHIS5 = "", userNameMainHIS1 = "", userNameMainHIS2 = "";
        public String passwordMainHIS5 = "", passwordMainHIS1 = "", passwordMainHIS2 = "";
        public String databaseNameBua = "";
        public String hostNameBua = "";
        public String userNameBua = "";
        public String passwordBua = "";
        public String server = "";
        public String isBranch = "";
        private LogWriter lw;
        public String pathLabEx = "";

        public String pathSSO = "";
        public ConnectDB()
        {
            iniFile = new IniFile("reportbangna.ini");
            
            databaseNameMainHIS5 = iniFile.Read("database_name");
            hostNameMainHIS5 = iniFile.Read("host_name");
            userNameMainHIS5 = iniFile.Read("user_password");
            passwordMainHIS5 = iniFile.Read("password");
            databaseNameBua = iniFile.Read("database_name_bua");
            hostNameBua = iniFile.Read("host_name_bua");
            userNameBua = iniFile.Read("user_password_bua");
            passwordBua = iniFile.Read("password_bua");

            _mainConnection = new OleDbConnection();
            //_mainConnection.ConnectionString = GetConfig("Main.ConnectionString");
            _mainConnection.ConnectionString="Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\source\\reportBangna\\reportBangna\\DataBase\\reportBangna.mdb;Persist Security Info=False";
            _isDisposed = false;
        }
        public ConnectDB(String hostName, String flag)
        {
            hostname = "mainhis";
            iniFile = new IniFile("reportbangna.ini");

            databaseNameMainHIS5 = iniFile.Read("database_name");
            hostNameMainHIS5 = iniFile.Read("host_name");
            userNameMainHIS5 = iniFile.Read("user_password");
            passwordMainHIS5 = iniFile.Read("password");

            hostNameMainHIS1 = iniFile.Read("host_name1");
            userNameMainHIS1 = iniFile.Read("user_name1");
            passwordMainHIS1 = iniFile.Read("password1");
            databaseNameMainHIS1 = iniFile.Read("database_name1");

            hostNameMainHIS2 = iniFile.Read("host_name2");
            userNameMainHIS2 = iniFile.Read("user_name2");
            passwordMainHIS2 = iniFile.Read("password2");
            databaseNameMainHIS2 = iniFile.Read("database_name2");

            databaseNameBua = iniFile.Read("database_name_bua");
            hostNameBua = iniFile.Read("host_name_bua");
            userNameBua = iniFile.Read("user_password_bua");
            passwordBua = iniFile.Read("password_bua");

            connMainHIS5 = new SqlConnection();
            connMainHIS2 = new SqlConnection();
            connMainHIS1 = new SqlConnection();
            connMainHIS5.ConnectionString = "Server=" + hostNameMainHIS5 + ";Database=" + databaseNameMainHIS5.ToString() + ";Uid=" + userNameMainHIS5 + ";Pwd=" + passwordMainHIS5 + ";";
            connMainHIS1.ConnectionString = "Server=" + hostNameMainHIS1 + ";Database=" + databaseNameMainHIS1.ToString() + ";Uid=" + userNameMainHIS1 + ";Pwd=" + passwordMainHIS1 + ";";
            connMainHIS2.ConnectionString = "Server=" + hostNameMainHIS2 + ";Database=" + databaseNameMainHIS2.ToString() + ";Uid=" + userNameMainHIS2 + ";Pwd=" + passwordMainHIS2 + ";";

            if (flag.Equals("1"))
            {
                connMainHIS5.ConnectionString = connMainHIS1.ConnectionString;
            }
            else if (flag.Equals("2"))
            {
                connMainHIS5.ConnectionString = connMainHIS2.ConnectionString;
            }
            else if (flag.Equals("5"))
            {
                connMainHIS5.ConnectionString = connMainHIS5.ConnectionString;
            }
            _mainConnection = new OleDbConnection();
            //_mainConnection.ConnectionString = GetConfig("Main.ConnectionString");
            _mainConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\source\\reportBangna\\reportBangna\\DataBase\\reportBangna.mdb;Persist Security Info=False";
            _isDisposed = false;
        }
        public ConnectDB(String hostName)
        {
            lw = new LogWriter();
            iniFile = new IniFile("reportbangna.ini");

            //iniFile.Write("aaaa", "bbbb");
            hostNameMainHIS5 = iniFile.Read("host_name");
            userNameMainHIS5 = iniFile.Read("user_name");
            passwordMainHIS5 = iniFile.Read("password");
            databaseNameMainHIS5 = iniFile.Read("database_name");

            

            databaseNameBua = iniFile.Read("database_name_bua");
            hostNameBua = iniFile.Read("host_name_bua");
            userNameBua = iniFile.Read("user_name_bua");
            passwordBua = iniFile.Read("password_bua");
            server = iniFile.Read("server");
            isBranch = iniFile.Read("clientisbranch");
            pathLabEx = "\\\\"+hostNameMainHIS5+"\\image\\labex\\";
            if (hostName == "mainhis")
            {
                hostname = "mainhis";
                connMainHIS5 = new SqlConnection();
                //connMainHIS.ConnectionString = GetConfig(hostName);
                connMainHIS5.ConnectionString = "Server="+hostNameMainHIS5+";Database="+databaseNameMainHIS5.ToString()+";Uid="+userNameMainHIS5+";Pwd="+passwordMainHIS5+";";
                connMainHIS1 = new SqlConnection();
                //connMainHIS.ConnectionString = GetConfig(hostName);
                connMainHIS1.ConnectionString = "Server=" + hostNameMainHIS1 + ";Database=" + databaseNameMainHIS1.ToString() + ";Uid=" + userNameMainHIS1 + ";Pwd=" + passwordMainHIS1 + ";";
                //if (server.Equals("bangna1"))
                //{
                //    connMainHIS.ConnectionString = "Server=172.1.1.1;Database=bng1_front_dbms;Uid=sa;Pwd=;";
                //}
                //else if (server.Equals("bangna2"))
                //{
                //    connMainHIS.ConnectionString = "Server=172.1.1.1;Database=bng2_front_dbms;Uid=sa;Pwd=;";
                //}
                //else
                //{
                //    //connMainHIS.ConnectionString = "Server=172.25.10.5;Database=bng5_front_dbms;Uid=sa;Pwd=;";
                //    connMainHIS.ConnectionString = "Server=172.25.10.5;Database=BNG5_DBMS_FRONT;Uid=sa;Pwd=;";
                //}
            }
            else if (hostName == "bangna")
            {
                hostname = "bangna";
                connMainHIS5 = new SqlConnection();
                //connMainHIS.ConnectionString = GetConfig(hostName);
                connMainHIS5.ConnectionString = "Server="+hostNameBua+";Database="+databaseNameBua+";Uid="+userNameBua+";Pwd="+passwordBua+";";
            }
            else if (hostName == "sso")
            {
                _mainConnection = new OleDbConnection();
                //_mainConnection.ConnectionString = GetConfig("Main.ConnectionString");
                if (Environment.Is64BitOperatingSystem)
                {
                    _mainConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source="+ pathSSO + ";Persist Security Info=False";
                }
                else
                {
                    _mainConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source="+ pathSSO + ";Persist Security Info=False";
                }
                //_mainConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\source\reportBangna\\reportBangna\\DataBase\\reportBangna.mdb;Persist Security Info=False";
                _isDisposed = false;
            }
            else
            {
                _mainConnection = new OleDbConnection();
                //_mainConnection.ConnectionString = GetConfig("Main.ConnectionString");
                if (Environment.Is64BitOperatingSystem)
                {
                    _mainConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:\\source\\reportBangna\\reportBangna\\DataBase\\reportBangna.mdb;Persist Security Info=False";
                }
                else
                {
                    _mainConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\source\\reportBangna\\reportBangna\\DataBase\\reportBangna.mdb;Persist Security Info=False";
                }
                //_mainConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\source\reportBangna\\reportBangna\\DataBase\\reportBangna.mdb;Persist Security Info=False";
                _isDisposed = false;
            }
        }
        public ConnectDB(String hostName, String pathSSO, String flag)
        {
            _mainConnection = new OleDbConnection();
            //_mainConnection.ConnectionString = GetConfig("Main.ConnectionString");
            if (flag.Equals("32"))
            {
                _mainConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + pathSSO + ";Persist Security Info=False";
            }
            else if (flag.Equals("64"))
            {
                _mainConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + pathSSO + ";Persist Security Info=False";
            }
            else
            {
                if (Environment.Is64BitOperatingSystem)
                {
                    _mainConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + pathSSO + ";Persist Security Info=False";
                }
                else
                {
                    _mainConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + pathSSO + ";Persist Security Info=False";
                }
            }
            
            //_mainConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\source\reportBangna\\reportBangna\\DataBase\\reportBangna.mdb;Persist Security Info=False";
            _isDisposed = false;
        }
        public String GetConfig(String key)
        {

            AppSettingsReader _configReader = new AppSettingsReader();
            // Set connection string of the sqlconnection object
            return _configReader.GetValue(key, "".GetType()).ToString();
        }
        public DataTable selectData(String sql)
        {
            DataTable toReturn = new DataTable();
            if ((hostname == "mainhis") || (hostname=="bangna"))
            {
                SqlCommand comMainhis = new SqlCommand();
                comMainhis.CommandText = sql;
                comMainhis.CommandType = CommandType.Text;
                comMainhis.Connection = connMainHIS5;
                SqlDataAdapter adapMainhis = new SqlDataAdapter(comMainhis);
                try
                {
                    connMainHIS5.Open();
                    adapMainhis.Fill(toReturn);
                    //return toReturn;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
                finally
                {
                    connMainHIS5.Close();
                    comMainhis.Dispose();
                    adapMainhis.Dispose();
                }
            }
            else
            {
                OleDbCommand cmdToExecute = new OleDbCommand();
                cmdToExecute.CommandText = sql;
                cmdToExecute.CommandType = CommandType.Text;
                
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmdToExecute);
                cmdToExecute.Connection = _mainConnection;
                try
                {
                    _mainConnection.Open();
                    adapter.Fill(toReturn);
                    //return toReturn;
                }
                catch (Exception ex)
                {
                    throw new Exception("", ex);
                }
                finally
                {
                    _mainConnection.Close();
                    cmdToExecute.Dispose();
                    adapter.Dispose();
                }
            }
            return toReturn;
        }
        public DataTable selectData(SqlConnection con, String sql)
        {
            DataTable toReturn = new DataTable();
            if ((hostname == "mainhis") || (hostname == "bangna"))
            {
                SqlCommand comMainhis = new SqlCommand();
                comMainhis.CommandText = sql;
                comMainhis.CommandType = CommandType.Text;
                comMainhis.Connection = connMainHIS5;
                SqlDataAdapter adapMainhis = new SqlDataAdapter(comMainhis);
                try
                {
                    con.Open();
                    adapMainhis.Fill(toReturn);
                    //return toReturn;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
                finally
                {
                    con.Close();
                    comMainhis.Dispose();
                    adapMainhis.Dispose();
                }
            }
            else
            {
                OleDbCommand cmdToExecute = new OleDbCommand();
                cmdToExecute.CommandText = sql;
                cmdToExecute.CommandType = CommandType.Text;

                OleDbDataAdapter adapter = new OleDbDataAdapter(cmdToExecute);
                cmdToExecute.Connection = _mainConnection;
                try
                {
                    _mainConnection.Open();
                    adapter.Fill(toReturn);
                    //return toReturn;
                }
                catch (Exception ex)
                {
                    throw new Exception("", ex);
                }
                finally
                {
                    _mainConnection.Close();
                    cmdToExecute.Dispose();
                    adapter.Dispose();
                }
            }
            return toReturn;
        }
        public DataTable selectDataNoClose(String sql)
        {
            DataTable toReturn = new DataTable();
            if ((hostname == "mainhis") || (hostname == "bangna"))
            {
                SqlCommand comMainhis = new SqlCommand();
                comMainhis.CommandText = sql;
                comMainhis.CommandType = CommandType.Text;
                comMainhis.Connection = connMainHIS5;
                SqlDataAdapter adapMainhis = new SqlDataAdapter(comMainhis);
                try
                {
                    //connMainHIS.Open();
                    adapMainhis.Fill(toReturn);
                    //return toReturn;
                }
                catch (Exception ex)
                {
                    throw new Exception("", ex);
                }
                finally
                {
                    //connMainHIS.Close();
                    //comMainhis.Dispose();
                    //adapMainhis.Dispose();
                }
            }
            else
            {
                OleDbCommand cmdToExecute = new OleDbCommand();
                cmdToExecute.CommandText = sql;
                cmdToExecute.CommandType = CommandType.Text;

                OleDbDataAdapter adapter = new OleDbDataAdapter(cmdToExecute);
                cmdToExecute.Connection = _mainConnection;
                try
                {
                    //_mainConnection.Open();
                    adapter.Fill(toReturn);
                    //return toReturn;
                }
                catch (Exception ex)
                {
                    throw new Exception("", ex);
                }
                finally
                {
                    //_mainConnection.Close();
                    //cmdToExecute.Dispose();
                    //adapter.Dispose();
                }
            }
            return toReturn;

        }
        public String ExecuteNonQuery(String sql)
        {
            String toReturn = "";
            if ((hostname == "mainhis")|| (hostname=="bangna"))
            {
                SqlCommand comMainhis = new SqlCommand();
                comMainhis.CommandText = sql;
                comMainhis.CommandType = CommandType.Text;
                comMainhis.Connection = connMainHIS5;
                try
                {
                    connMainHIS5.Open();
                    _rowsAffected = comMainhis.ExecuteNonQuery();
                    toReturn = _rowsAffected.ToString();
                }
                catch (Exception ex)
                {
                    throw new Exception("ExecuteNonQuery::Error occured.", ex);
                    toReturn = ex.Message;
                }
                finally
                {
                    //_mainConnection.Close();
                    connMainHIS5.Close();
                    comMainhis.Dispose();
                }
            }
            else
            {
                OleDbCommand cmdToExecute = new OleDbCommand();
                cmdToExecute.CommandText = sql;
                cmdToExecute.CommandType = CommandType.Text;
                cmdToExecute.Connection = _mainConnection;
                try
                {
                    _mainConnection.Open();
                    _rowsAffected = cmdToExecute.ExecuteNonQuery();
                    toReturn = _rowsAffected.ToString();
                }
                catch (Exception ex)
                {
                    throw new Exception("ExecuteNonQuery::Error occured.", ex);
                    toReturn = ex.Message;
                }
                finally
                {
                    _mainConnection.Close();
                    cmdToExecute.Dispose();
                }
            }
            return toReturn;
        }
        public String ExecuteNonQueryNoClose(String sql)
        {
            String toReturn = "";
            if ((hostname == "mainhis") || (hostname == "bangna"))
            {
                SqlCommand comMainhis = new SqlCommand();
                comMainhis.CommandText = sql;
                comMainhis.CommandType = CommandType.Text;
                comMainhis.Connection = connMainHIS5;
                try
                {
                    //connMainHIS.Open();
                    _rowsAffected = comMainhis.ExecuteNonQuery();
                    toReturn = _rowsAffected.ToString();
                }
                catch (Exception ex)
                {
                    throw new Exception("ExecuteNonQuery::Error occured.", ex);
                    toReturn = ex.Message;
                }
                finally
                {
                    //_mainConnection.Close();
                    //comMainhis.Dispose();
                }
            }
            else
            {
                OleDbCommand cmdToExecute = new OleDbCommand();
                cmdToExecute.CommandText = sql;
                cmdToExecute.CommandType = CommandType.Text;
                cmdToExecute.Connection = _mainConnection;
                try
                {
                    //_mainConnection.Open();
                    _rowsAffected = cmdToExecute.ExecuteNonQuery();
                    toReturn = _rowsAffected.ToString();
                }
                catch (Exception ex)
                {
                    throw new Exception("ExecuteNonQuery::Error occured.", ex);
                    toReturn = ex.Message;
                }
                finally
                {
                    //_mainConnection.Close();
                    //cmdToExecute.Dispose();
                }
            }
            return toReturn;
        }
        public String OpenConnection()
        {
            String toReturn = "";
            if ((hostname == "mainhis") || (hostname == "bangna"))
            {
                SqlCommand comMainhis = new SqlCommand();
                //comMainhis.CommandText = sql;
                comMainhis.CommandType = CommandType.Text;
                comMainhis.Connection = connMainHIS5;
                try
                {
                    connMainHIS5.Open();
                    //_rowsAffected = comMainhis.ExecuteNonQuery();
                    //toReturn = _rowsAffected.ToString();
                }
                catch (Exception ex)
                {
                    throw new Exception("ExecuteNonQuery::Error occured.", ex);
                    toReturn = ex.Message;
                }
                finally
                {
                    //_mainConnection.Close();
                    //comMainhis.Dispose();
                }
            }
            else
            {
                OleDbCommand cmdToExecute = new OleDbCommand();
                //cmdToExecute.CommandText = sql;
                cmdToExecute.CommandType = CommandType.Text;
                cmdToExecute.Connection = _mainConnection;
                try
                {
                    _mainConnection.Open();
                    //_rowsAffected = cmdToExecute.ExecuteNonQuery();
                    //toReturn = _rowsAffected.ToString();
                }
                catch (Exception ex)
                {
                    throw new Exception("ExecuteNonQuery::Error occured.", ex);
                    toReturn = ex.Message;
                }
                finally
                {
                    //_mainConnection.Close();
                    //cmdToExecute.Dispose();
                }
            }
            return toReturn;
        }
        public void CloseConnection()
        {
            connMainHIS5.Close();
        }
    }
}
