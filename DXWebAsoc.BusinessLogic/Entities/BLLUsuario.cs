using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DXWebAsoc.Model.Entities;
// Para implementar RoleProvider: System.Web.Security + System.Web.ApplicationServices
using System.Web.Security;
using System.Security.Cryptography;
using System.IO;
using System.Text.RegularExpressions;
using System.Configuration;
using WcfService.Services;

namespace DXWebAsoc.BLL
{
    public class BLLUsuario: MembershipProvider
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
        #endregion

        #region UnusedMethods
        // Get User       
        public override MembershipUser GetUser(string username, bool userIsOnline)
        {
            throw new NotImplementedException();
        }
        public override bool EnablePasswordRetrieval
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override bool EnablePasswordReset
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override bool RequiresQuestionAndAnswer
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override int MaxInvalidPasswordAttempts
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override int PasswordAttemptWindow
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override bool RequiresUniqueEmail
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override MembershipPasswordFormat PasswordFormat
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override int MinRequiredPasswordLength
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override int MinRequiredNonAlphanumericCharacters
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string PasswordStrengthRegularExpression
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public override MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey, out MembershipCreateStatus status)
        {
            throw new NotImplementedException();
        }

        public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer)
        {
            throw new NotImplementedException();
        }

        public override string GetPassword(string username, string answer)
        {
            throw new NotImplementedException();
        }

        public override bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public override string ResetPassword(string username, string answer)
        {
            throw new NotImplementedException();
        }

        public override void UpdateUser(MembershipUser user)
        {
            throw new NotImplementedException();
        }



        public override bool UnlockUser(string userName)
        {
            throw new NotImplementedException();
        }

        public override MembershipUser GetUser(object providerUserKey, bool userIsOnline)
        {
            throw new NotImplementedException();
        }

        public override string GetUserNameByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteUser(string username, bool deleteAllRelatedData)
        {
            throw new NotImplementedException();
        }

        public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
        }

        public override int GetNumberOfUsersOnline()
        {
            throw new NotImplementedException();
        }

        public override MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
        }

        public override MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
        }
        #endregion


        #region USED        
        //public MembershipUser ReadUser(CObject entity)/
        public bool ReadUser(CObject entity)
        {
            WCFUsuario WCFuser = this.servicio.ReadUser(entity);
            if (WCFuser!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public override bool ValidateUser(string username, string password)
        {
            bool existe = this.servicio.ValidateUser(username, password);
            if (existe)
                return true;
            else
                return false;
        }

        #endregion

        /*
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
        /// Read:
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
        */
    }

}
