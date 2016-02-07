using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DXWebAsoc.Model.Entities
{
    public class CObject
    {
        public int Id { set; get; }
        public string UsuarioCreacion { set; get; }
        public DateTime FechaCreacion { set; get; }
        public string UsuarioModificacion { set; get; }
        public DateTime FechaModificacion { set; get; }
    }
}
