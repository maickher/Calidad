using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Reflection;

namespace DXWebAsoc.DAL.DS
{
    public class DataBaseFactory
    {
        /// <summary>
        /// OpenDatabase: Open connection to perform transactions. 
        /// </summary>
        /// <param name="pStringConnectionName">Name of the connection string stored at web.config</param>
        /// <returns></returns>
        public static DataBase OpenDatabase(String pStringConnectionName)
        {
            String stringConnection = "";
            try
            {
                DataBase db = new DataBase();
                stringConnection = ConfigurationManager.ConnectionStrings[pStringConnectionName].ToString();

                SqlConnection connection = new SqlConnection(stringConnection);
                //MySqlConnection connection = new MySqlConnection(stringConnection);
                //OleDbConnection connection = new OleDbConnection(stringConnection);
                connection.Open();
                db.conn = connection;
                if (connection.State != ConnectionState.Open)
                {
                    throw new Exception("There was an ex opening the database, review the connection parameters!");
                }
                return db;
            }
            catch (Exception ex)
            {
                ex.Source += " Connection " + stringConnection + "Parameter :" + pStringConnectionName;
                Log.WriteException(MethodBase.GetCurrentMethod().Name, ex);
                throw ex;
            }
        }
        public static DataBase OpenDatabase(string pStringConnectionName, String pUser, String pPassword)
        {
            String stringConnection = "";
            try
            {
                DataBase db = new DataBase();
                stringConnection = ConfigurationManager.ConnectionStrings[pStringConnectionName].ToString();
                stringConnection = stringConnection + String.Format("User Id={0};Password={1};", pUser, pPassword);

                SqlConnection connection = new SqlConnection(stringConnection);
                //MySqlConnection connection = new MySqlConnection(stringConnection);
                //OleDbConnection connection = new OleDbConnection(stringConnection);
                connection.Open();
                db.conn = connection;
                if (connection.State != ConnectionState.Open)
                {
                    throw new Exception("There was an ex opening the database, review the connection parameters!");
                }
                return db;
            }
            catch (Exception ex)
            {
                ex.Source += " Connection " + stringConnection + "Parameter :" + pStringConnectionName;
                Log.WriteException(MethodBase.GetCurrentMethod().Name, ex);
                throw ex;
            }
        }
    }
}
