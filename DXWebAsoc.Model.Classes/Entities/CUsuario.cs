using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DXWebAsoc.Model.Entities
{
    public class CUsuario: CObject
    {
        /*
        	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	        [Nombre] [nvarchar](250) NOT NULL,
	        [CUsuario] [nvarchar](50) NOT NULL,
	        [Contrasena] [nvarchar](50) NOT NULL,
	        [Rol] [nvarchar](50) NOT NULL,
	        [Estado] [nvarchar](20) NOT NULL,
	        [UsuarioCreacion] [int] NULL,
	        [FechaCreacion] [datetime] NULL,
	        [UsuarioModificacion] [int] NULL,
	        [FechaModificacion] [datetime] NULL,
        */
        #region Properties
        public string Nombre { set; get; }
        public string Usuario { set; get; }
        public string Contrasena { set; get; }
        public Role Role { set; get; }
        public UserState Estado { set; get; }
        #endregion
        #region ToString        
        #endregion
    }
}
