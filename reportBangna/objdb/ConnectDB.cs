﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
        public SqlConnection connMainHIS;
        private String hostname = "";

        public ConnectDB()
        {
            _mainConnection = new OleDbConnection();
            //_mainConnection.ConnectionString = GetConfig("Main.ConnectionString");
            _mainConnection.ConnectionString="Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\source\\reportBangna\\reportBangna\\DataBase\\reportBangna.mdb;Persist Security Info=False";
            _isDisposed = false;
        }
        public ConnectDB(String hostName)
        {
            if (hostName == "mainhis")
            {
                hostname = "mainhis";
                connMainHIS = new SqlConnection();
                //connMainHIS.ConnectionString = GetConfig(hostName);
                connMainHIS.ConnectionString = "Server=172.25.10.5;Database=bng5_dbms_front;Uid=sa;Pwd=;";
            }
            else if (hostName == "bangna")
            {
                hostname = "bangna";
                connMainHIS = new SqlConnection();
                //connMainHIS.ConnectionString = GetConfig(hostName);
                connMainHIS.ConnectionString = "Server=172.25.10.5;Database=bua;Uid=pop;Pwd=pop;";
            }
            else
            {
                _mainConnection = new OleDbConnection();
                //_mainConnection.ConnectionString = GetConfig("Main.ConnectionString");
                _mainConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\source\\reportBangna\\reportBangna\\DataBase\\reportBangna.mdb;Persist Security Info=False";
                _isDisposed = false;
            }
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
                comMainhis.Connection = connMainHIS;
                SqlDataAdapter adapMainhis = new SqlDataAdapter(comMainhis);
                try
                {
                    connMainHIS.Open();
                    adapMainhis.Fill(toReturn);
                    //return toReturn;
                }
                catch (Exception ex)
                {
                    throw new Exception("", ex);
                }
                finally
                {
                    connMainHIS.Close();
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
        public String ExecuteNonQuery(String sql)
        {
            String toReturn = "";
            if ((hostname == "mainhis")|| (hostname=="bangna"))
            {
                SqlCommand comMainhis = new SqlCommand();
                comMainhis.CommandText = sql;
                comMainhis.CommandType = CommandType.Text;
                comMainhis.Connection = connMainHIS;
                try
                {
                    connMainHIS.Open();
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
                    connMainHIS.Close();
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
                comMainhis.Connection = connMainHIS;
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
                comMainhis.Connection = connMainHIS;
                try
                {
                    connMainHIS.Open();
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
            connMainHIS.Close();
        }
    }
}
