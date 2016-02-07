using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DXWebAsoc.DAL.DS
{
    /// <summary>
    /// IDisponsable provides a mechanism for realising unmanaged resources
    /// </summary>
    public class DataBase : IDisposable 
    {
        #region Properties
        //public SqlConnection conn { set; get; }
        //public MySqlConnection conexion { get; set; }
        public OleDbConnection conn { set; get; }
        #endregion

        #region Methods
        //public SqlDataReader ExecuteReader(SqlCommand pCommand)
        //public MySqlDataReader ExecuteReader(MySqlCommand pCommand)
        public OleDbDataReader ExecuteReader(OleDbCommand pCommand)
        {
            //SqlDataReader reader = null;
            //MySqlDataReader lector = null;
            OleDbDataReader reader = null;
            try
            {
                pCommand.Connection = conn;
                reader = pCommand.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;
            }
            catch (Exception ex)
            {
                ex.Source += " SQL: " + pCommand.CommandText.ToString();
                Log.WriteException(MethodBase.GetCurrentMethod().Name, ex);
                throw ex;                
            }
        }
        //public DataSet ExecuteReader(SqlCommand pCommand, String pTable)
        //public DataSet executeReader(MySqlCommand pCommand, String tabla)
        public DataSet ExecuteReader(OleDbCommand pCommand, String pTable)
        {
            DataSet dsTable = new DataSet();
            try
            {
                //using (SqlDataAdapter adapter = new SqlDataAdapter(pCommand))
                //using (MySqlDataAdapter adaptador = new MySqlDataAdapter(pCommand))
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(pCommand))
                {
                    pCommand.Connection = conn;
                    dsTable = new DataSet();
                    adapter.Fill(dsTable, pTable);
                }

                return dsTable;
            }
            catch (Exception ex)
            {
                ex.Source += " SQL: " + pCommand.CommandText.ToString();
                Log.WriteException(MethodBase.GetCurrentMethod().Name, ex);
                throw ex;
            }
            finally
            {
                if (dsTable != null)
                {
                    dsTable.Dispose();
                }
            }
        }

        //public int ExecuteNonQuery(SqlCommand pCommand, IsolationLevel pIsolationLevel)
        //public int executeNonQuery(MySqlCommand pCommand, IsolationLevel isolationLevel)
        public int ExecuteNonQuery(OleDbCommand pCommand, IsolationLevel pIsolationLevel)
        {
            //using (SqlTransaction trans = conn.BeginTransaction(pIsolationLevel))
            //using (MySqlTransaction trans = conn.BeginTransaction(isolationLevel))
            using (OleDbTransaction trans = conn.BeginTransaction(pIsolationLevel))
            {
                int rowsAffected = 0;
                try
                {
                    pCommand.Connection = conn;
                    pCommand.Transaction = trans;
                    rowsAffected = pCommand.ExecuteNonQuery();
                    // Transaction commit
                    trans.Commit();
                    return rowsAffected;
                }
                catch (Exception ex)
                {
                    ex.Source += " SQL: " + pCommand.CommandText.ToString();
                    Log.WriteException(MethodBase.GetCurrentMethod().Name, ex);
                    throw ex;
                }
            }
        }

        //public int ExecuteNonQuery(SqlCommand pCommand)
        //public int executeNonQuery(MySqlCommand pCommand) 
        public int ExecuteNonQuery(OleDbCommand pCommand)
        {
            int rowsAffected = 0;
            try
            {
                pCommand.Connection = conn;
                rowsAffected = pCommand.ExecuteNonQuery();
                return rowsAffected;
            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {
                ex.Source += " SQL: " + pCommand.CommandText.ToString();
                Log.WriteException(MethodBase.GetCurrentMethod().Name, ex);
                throw;
            }
        }

        //public void ExecuteNonQuery(ref SqlCommand pCommand, IsolationLevel pIsolationLevel)
        //public void executeNonQuery(ref MySqlCommand pCommand, IsolationLevel isolationLevel)
        public void ExecuteNonQuery(ref OleDbCommand pCommand, IsolationLevel pIsolationLevel)
        {
            //using (SqlTransaction trans = conn.BeginTransaction(pIsolationLevel))
            //using (MySqlTransaction trans = conn.BeginTransaction(isolationLevel))
            using (OleDbTransaction trans = conn.BeginTransaction(pIsolationLevel))
            {
                try
                {
                    pCommand.Connection = conn;
                    pCommand.Transaction = trans;
                    pCommand.ExecuteNonQuery();
                    // Transaction commit
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    ex.Source += " SQL: " + pCommand.CommandText.ToString();
                    Log.WriteException(MethodBase.GetCurrentMethod().Name, ex);
                    throw ex;
                }
            }
        }

        //public void ExecuteNonQuery(List<SqlCommand> pCommands, IsolationLevel pIsolationLevel)
        //public void ExecuteNonQuery(List<MySqlCommand> pCommands, IsolationLevel isolationLevel)
        public void ExecuteNonQuery(List<OleDbCommand> pCommands, IsolationLevel pIsolationLevel)
        {
            //using (SqlTransaction trans = conn.BeginTransaction(pIsolationLevel))
            //using (MySqlTransaction trans = conexion.BeginTransaction(isolationLevel))
            using (OleDbTransaction trans = conn.BeginTransaction(pIsolationLevel))
            {
                try
                {
                    //foreach (SqlCommand command in pCommands)
                    //foreach (MySqlCommand command in pCommands)
                    foreach (OleDbCommand command in pCommands)
                    {
                        command.Connection = conn;
                        command.Transaction = trans;
                        command.ExecuteNonQuery();
                    }
                    // Transaction commit
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    ex.Source += " SQL: " + pCommands.ToString();
                    Log.WriteException(MethodBase.GetCurrentMethod().Name, ex);
                    throw ex;
                }
            }
        }
        #endregion

        #region IDisponsable Member
        public void Dispose()
        {
            if (this.conn != null)
            {
                this.conn.Close();
            }
        }
        #endregion

    }
}
