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
using Utilities;

namespace DXWebAsoc.DAL.CORE
{
    public class DALUsuario : DALObject
    {
        /*
        #region CRUD
        #region CRUD:Create
        /// <summary>
        /// Create:
        /// </summary>
        /// <param name="pObject"></param>        
        public void Create(Entity pObject)
        {
            // Execute Instruction
            using (DataBase db = DataBaseFactory.OpenDatabase(base.ConnectionStringName))
            {
                // Create Command
                //OleDbCommand command = new OleDbCommand();
                SqlCommand command = new SqlCommand();
                //MySqlCommand command = new MySqlCommand();

                // Define Type of command            
                //command.CommandType = CommandType.StoredProcedure;            
                command.CommandType = CommandType.Text;
                // SQL Instruction
                string sql = @"INSERT INTO DIVISION 
                        (idDivision, division, descripcion) 
                        VALUES (@idDivision, @division, @despcripcion)";
                // Set Parameters: @ for inner parameters into SQL statement 
                command.Parameters.AddWithValue("@idDivision", ((pObject) as CUsuario).IdDivision);
                command.Parameters.AddWithValue("@division", ((pObject) as CUsuario).Division);
                command.Parameters.AddWithValue("@descripcion", ((pObject) as CUsuario).Descripcion);
                // Set sql instruction
                command.CommandText = sql;
                // Execute
                db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
            }
        }
        #endregion        
        /// <summary>
        /// Read All:
        /// </summary>
        /// <returns></returns>        
        public List<Entity> ReadAll() 
        {
            // List
            List<Entity> objCollection = new List<Entity>();
            // Execute Instruction
            using (DataBase db = DataBaseFactory.OpenDatabase(base.ConnectionStringName))
            {
                // DataSet: Disconnected data. 
                DataSet ds = null;
                // Create Command
                //OleDbCommand command = new OleDbCommand();
                SqlCommand command = new SqlCommand();
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
                        Entity oCObject = new CUsuario();
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
        public void Update(Entity pObject) 
        {
            // Execute Instruction
            using (DataBase db = DataBaseFactory.OpenDatabase(base.ConnectionStringName))
            {
                // Create Command
                //OleDbCommand command = new OleDbCommand();
                SqlCommand command = new SqlCommand();
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
                command.Parameters.AddWithValue("@idDivision", ((pObject) as CUsuario).IdDivision);                
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
        public void Delete(Entity pObject) 
        {
            // Execute Instruction
            using (DataBase db = DataBaseFactory.OpenDatabase(base.ConnectionStringName))
            {
                // Create Command
                //OleDbCommand command = new OleDbCommand();
                SqlCommand command = new SqlCommand();
                //MySqlCommand command = new MySqlCommand();

                // Define Type of command            
                //command.CommandType = CommandType.StoredProcedure;            
                command.CommandType = CommandType.Text;
                // SQL Instruction
                string sql = @"DELETE FROM DIVISION 
                                WHERE
                                    idDivsion = @idDivision;";
                // Set Parameters: @ for inner parameters into SQL statement 
                command.Parameters.AddWithValue("@idDivision", ((pObject) as CUsuario).IdDivision);
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
        public bool Exists(Entity pObject)
        {
            // Object
            Entity oCObject = this.Read(pObject);
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
        */

        #region CRUD:Read
        /// <summary>
        /// Read By Id:
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>        
        public CObject Read(CObject pObject)
        {
            // Object
            CObject oCObject = null;
            // Execute Instruction
            using (DataBase db = DataBaseFactory.OpenDatabase(base.ConnectionStringName))
            {
                // DataSet: Disconnected data. 
                DataSet ds = null;
                // Create Command
                //OleDbCommand command = new OleDbCommand();
                SqlCommand command = new SqlCommand();
                //MySqlCommand command = new MySqlCommand();

                // Define Type of command            
                //command.CommandType = CommandType.StoredProcedure;            
                command.CommandType = CommandType.Text;
                // SQL Instruction
                string sql = @"SELECT * FROM USUARIOS WHERE USUARIO = @USUARIO AND CONTRASENA = @CONTRASENA";
                // Set Parameters
                command.Parameters.AddWithValue("@USUARIO", ((pObject) as CUsuario).Usuario);
                command.Parameters.AddWithValue("@CONTRASENA", ((pObject) as CUsuario).Contrasena);
                // Set sql instruction
                command.CommandText = sql;
                // Execute
                ds = db.ExecuteReader(command, "USUARIO");
                // Extract table 0
                DataTable dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
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
            CUsuario oCObject = new CUsuario();
            oCObject.Id = Convert.ToInt32(dr["IdUsuario"]);
            oCObject.Nombre = Convert.ToString(dr["Nombre"]);
            oCObject.Usuario = Convert.ToString(dr["Usuario"]);
            oCObject.Contrasena = Convert.ToString(dr["Contrasena"]);
            oCObject.Role = EnumUtil.ParseEnum<Role>(Convert.ToString(dr["Rol"]));
            oCObject.Estado = EnumUtil.ParseEnum<UserState>(Convert.ToString(dr["Estado"]));
            // Checking for NULL
            if (dr["FechaCreacion"] != DBNull.Value)
                oCObject.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]);
            if (dr["UsuarioCreacion"] != DBNull.Value)
                oCObject.UsuarioCreacion = Convert.ToString(dr["UsuarioCreacion"]);
            if (dr["FechaModificacion"] != DBNull.Value)
                oCObject.FechaModificacion = Convert.ToDateTime(dr["FechaModificacion"]);
            if (dr["UsuarioModificacion"] != DBNull.Value)
                oCObject.UsuarioModificacion = Convert.ToString(dr["UsuarioModificacion"]);

            // Return
            return oCObject;
        }
        #endregion
        #endregion
    }
}
