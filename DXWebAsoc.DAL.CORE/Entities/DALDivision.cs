using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DXWebAsoc.Model.Entities;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using DXWebAsoc.DAL.DS;

namespace DXWebAsoc.DAL.CORE
{
    public class DALDivision : DALObject
    {
        #region CRUD
        #region CRUD:Create
        /// <summary>
        /// Create:
        /// </summary>
        /// <param name="pObject"></param>        
        public void Create(CObject pObject)
        {
            // Execute Instruction
            using (DataBase db = DataBaseFactory.OpenDatabase(base.ConnectionStringName))
            {
                // Create Command
                OleDbCommand command = new OleDbCommand();
                //SqlCommand command = new SqlCommand();
                //MySqlCommand command = new MySqlCommand();

                // Define Type of command            
                //command.CommandType = CommandType.StoredProcedure;            
                command.CommandType = CommandType.Text;
                // SQL Instruction
                string sql = @"INSERT INTO DIVISION 
                        (idDivision, division, descripcion) 
                        VALUES (@idDivision, @division, @despcripcion)";
                // Set Parameters: @ for inner parameters into SQL statement 
                command.Parameters.AddWithValue("@idDivision", ((pObject) as CDivision).IdDivision);
                command.Parameters.AddWithValue("@division", ((pObject) as CDivision).Division);
                command.Parameters.AddWithValue("@descripcion", ((pObject) as CDivision).Descripcion);
                // Set sql instruction
                command.CommandText = sql;
                // Execute
                db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
            }
        }
        #endregion
        #region CRUD:Read
        /// <summary>
        /// Read By Id:
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>        
        public CObject ReadById(CObject pObject) 
        {
            // Object
            CObject oCObject = null;
            // Execute Instruction
            using (DataBase db = DataBaseFactory.OpenDatabase(base.ConnectionStringName))
            {                
                // DataSet: Disconnected data. 
                DataSet ds = null;
                // Create Command
                OleDbCommand command = new OleDbCommand();
                //SqlCommand command = new SqlCommand();
                //MySqlCommand command = new MySqlCommand();

                // Define Type of command            
                //command.CommandType = CommandType.StoredProcedure;            
                command.CommandType = CommandType.Text;
                // SQL Instruction
                string sql = @"SELECT * FROM DIVISION WHERE idDivision = @idDivision";
                // Set Parameters
                command.Parameters.AddWithValue("@idDivision",((pObject) as CDivision).IdDivision);
                // Set sql instruction
                command.CommandText = sql;
                // Execute
                ds = db.ExecuteReader(command, "query");
                // Extract table 0
                DataTable dt = ds.Tables[0];
                if (dt.Rows.Count>0)
                {
                    DataRow dr = dt.Rows[0];
                    oCObject = this.PopulateObject(dr);
                }
                else
                {
                    oCObject = null;
                }
                return oCObject;
            }
        }
        /// <summary>
        /// Read All:
        /// </summary>
        /// <returns></returns>        
        public List<CObject> ReadAll() 
        {
            // List
            List<CObject> objCollection = new List<CObject>();
            // Execute Instruction
            using (DataBase db = DataBaseFactory.OpenDatabase(base.ConnectionStringName))
            {
                // DataSet: Disconnected data. 
                DataSet ds = null;
                // Create Command
                OleDbCommand command = new OleDbCommand();
                //SqlCommand command = new SqlCommand();
                //MySqlCommand command = new MySqlCommand();

                // Define Type of command            
                //command.CommandType = CommandType.StoredProcedure;            
                command.CommandType = CommandType.Text;
                // SQL Instruction
                string sql = @"SELECT * FROM DIVISION";
                // Set Parameters
                
                // Set sql instruction
                command.CommandText = sql;
                // Execute
                ds = db.ExecuteReader(command, "query");
                // Extract table 0
                DataTable dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        CObject oCObject = new CDivision();
                        oCObject = this.PopulateObject(dr);
                        objCollection.Add(oCObject);
                    }
                }
                return objCollection;
            }
        }
        #endregion
        #region CRUD:Update
        /// <summary>
        /// Update:
        /// </summary>
        /// <param name="pObject"></param>        
        public void Update(CObject pObject) 
        {
            // Execute Instruction
            using (DataBase db = DataBaseFactory.OpenDatabase(base.ConnectionStringName))
            {
                // Create Command
                OleDbCommand command = new OleDbCommand();
                //SqlCommand command = new SqlCommand();
                //MySqlCommand command = new MySqlCommand();

                // Define Type of command            
                //command.CommandType = CommandType.StoredProcedure;            
                command.CommandType = CommandType.Text;
                // SQL Instruction
                string sql = @"UPDATE DIVISION SET
                                    idDivision = @idDivision,
                                    division= @division,
                                    descripcion = @descripcion
                                WHERE
                                    idDivsion = @idDivision;";
                // Set Parameters: @ for inner parameters into SQL statement 
                command.Parameters.AddWithValue("@idDivision", ((pObject) as CDivision).IdDivision);                
                // Set sql instruction
                command.CommandText = sql;
                // Execute
                db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
            }
        }
        #endregion
        #region CRUD:Delete
        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="pObject"></param>        
        public void Delete(CObject pObject) 
        {
            // Execute Instruction
            using (DataBase db = DataBaseFactory.OpenDatabase(base.ConnectionStringName))
            {
                // Create Command
                OleDbCommand command = new OleDbCommand();
                //SqlCommand command = new SqlCommand();
                //MySqlCommand command = new MySqlCommand();

                // Define Type of command            
                //command.CommandType = CommandType.StoredProcedure;            
                command.CommandType = CommandType.Text;
                // SQL Instruction
                string sql = @"DELETE FROM DIVISION 
                                WHERE
                                    idDivsion = @idDivision;";
                // Set Parameters: @ for inner parameters into SQL statement 
                command.Parameters.AddWithValue("@idDivision", ((pObject) as CDivision).IdDivision);
                // Set sql instruction
                command.CommandText = sql;
                // Execute
                db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
            }
        }
        #endregion
        #region CRUD:Exists
        /// <summary>
        /// Exists:
        /// </summary>
        /// <param name="pObject"></param>
        /// <returns></returns>        
        public bool Exists(CObject pObject)
        {
            // Object
            CObject oCObject = this.ReadById(pObject);
            // If not is null then true
            if (oCObject!=null)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }
        #endregion
        #region Populate Object
        /// <summary>
        /// PopulateObject:
        /// Notese que en vez de utilizar un SqlDataReader para nuestra función de asignación, 
        /// se utiliza un IDataRecord, que es la interfaz que implementan todos los DataReaders. 
        /// El uso de IDataRecord hace que el proceso de asignación sea independiente del proveedor.         
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>        
        public CObject PopulateObject(DataRow dr)
        {
            CDivision oCObject = new CDivision();
            oCObject.IdDivision = Convert.ToInt32(dr["idDivision"]);
            // Checking for NULL
            if (dr["division"] != DBNull.Value)
                oCObject.Division = Convert.ToString(dr["division"]);
            if (dr["description"] != DBNull.Value)
                oCObject.Descripcion = Convert.ToString(dr["description"]);

            // Return
            return oCObject;
        }
        #endregion
        #endregion
    }
}
