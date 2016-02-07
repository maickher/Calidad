using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MITool.Model.DAL.CORE;
using MITool.Model.Entities;

namespace MITool.Model.BLL
{
    public class BLLDivision
    {
        #region Properties
        private DALDivision DALedger;
        #endregion
        #region Constructor
        public BLLDivision()
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
        public void Create(CObject pCObject)
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
        public CObject ReadById(CObject pCObject)
        {
            return this.DALedger.ReadById(pCObject);
        }
        /// <summary>
        /// ReadAll:
        /// </summary>
        /// <returns></returns>
        public List<CObject> ReadAll()
        {
            return this.DALedger.ReadAll();
        }
        #endregion
        #region CRUD:Update      
        /// <summary>
        /// Update:
        /// </summary>
        /// <param name="pCObject"></param>
        public void Update(CObject pCObject)
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
        public void Delete(CObject pCObject)
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
        public bool Exists(CObject pCObject)
        {
            return this.DALedger.Exists(pCObject);
        }
        #endregion
        #endregion
    }
}
