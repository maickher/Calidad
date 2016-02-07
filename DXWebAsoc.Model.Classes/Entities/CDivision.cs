using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DXWebAsoc.Model.Entities
{
    public class CDivision: CObject
    {
        //Test de prueba en github 
        #region Properties
        public int IdDivision { set; get; }
        public string Division { set; get;}
        public string Descripcion { set; get; }
        #endregion
        #region ToString
        override
        public string ToString()
        {
            return this.IdDivision.ToString() + "-" + this.Division;
        }
        #endregion
    }
}
