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
        public int Id { set; get; }
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
        [DataMember]
        public string UsuarioCreacion { set; get; }
        [DataMember]
        public DateTime FechaCreacion { set; get; }
        [DataMember]
        public string UsuarioModificacion { set; get; }
        [DataMember]
        public DateTime FechaModificacion { set; get; }

        #endregion
        #region ToString        
        #endregion
    }
}