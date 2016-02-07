using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DXWebAsoc.DAL.CORE;
using DXWebAsoc.Model.Entities;
using 

namespace DXWebAsoc.BLL
{
    public class BLLUsuario
    {
        #region Properties
        // Web Service
        private BusinessLogic.WCFService.IAsocService servicio;
        #endregion
        #region Constructor
        public BLLUsuario()
        {
            // Web Service Instance
            this.servicio = new BusinessLogic.WCFService.AsocServiceClient();
        }

        public BLLUsuario()
        {
            this.DALedger = new DALDivision();
        }
        #endregion
        #region CRUD
        #region CRUD:Create
        /// <summary>
        /// Create:
        /// </summary>
        /// <param name="pCObject"></param>
        public void Create(Entity pCObject)
        {
            if (!this.Exists(pCObject))
            {
                this.DALedger.Create(pCObject);
            }
            else
            {
                throw new Exception("This record already exists!!!");
            }
        }
        #endregion
        #region CRUD:Read
        /// <summary>
        /// ReadById:
        /// </summary>
        /// <param name="pCObject"></param>
        /// <returns></returns>
        public Entity ReadById(Entity pCObject)
        {
            return this.DALedger.ReadById(pCObject);
        }
        /// <summary>
        /// ReadAll:
        /// </summary>
        /// <returns></returns>
        public List<Entity> ReadAll()
        {
            return this.DALedger.ReadAll();
        }
        #endregion
        #region CRUD:Update      
        /// <summary>
        /// Update:
        /// </summary>
        /// <param name="pCObject"></param>
        public void Update(Entity pCObject)
        {
            if (this.Exists(pCObject))
            {
                this.DALedger.Update(pCObject);
            }
            else
            {
                throw new Exception("Record does not exist!!!");
            }
        }
        #endregion
        #region CRUD:Delete
        /// <summary>
        /// Delete:
        /// </summary>
        /// <param name="pCObject"></param>
        public void Delete(Entity pCObject)
        {
            if (this.Exists(pCObject))
            {
                this.DALedger.Delete(pCObject);
            }
            else
            {
                throw new Exception("Record does not exist!!!");
            }
        }
        #endregion
        #region CRUD:Exists     
        /// <summary>
        /// Exists:
        /// </summary>
        /// <param name="pCObject"></param>
        /// <returns></returns>
        public bool Exists(Entity pCObject)
        {
            return this.DALedger.Exists(pCObject);
        }
        #endregion
        #endregion
    }
}
