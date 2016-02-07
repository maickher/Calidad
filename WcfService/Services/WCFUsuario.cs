using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Security;

namespace WcfService.Services
{
    [DataContract]
    public class WCFUsuario: MembershipUser
    {
        #region Properties
        [DataMember]
        public string Nombre { set; get; }
        [DataMember]
        public string Usuario { set; get; }
        [DataMember]
        public string Contrasena { set; get; }
        [DataMember]
        public Role Role { set; get; }
        [DataMember]
        public UserState Estado { set; get; }
        #endregion
        #region ToString        
        #endregion
    }
}