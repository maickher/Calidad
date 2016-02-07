using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService.Services;

namespace WcfService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "AsocService" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione AsocService.svc o AsocService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class AsocService : IAsocService
    {
        #region Seguridad
        #region Usuario
        public void CreateUser(WCFUsuario user)
        {
            throw new NotImplementedException();
        }
        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }
        public List<WCFUsuario> ReadAllUser()
        {
            throw new NotImplementedException();
        }
        public WCFUsuario RedUser(int id)
        {
            throw new NotImplementedException();
        }
        public void UpdateUser(WCFUsuario user)
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion

    }
}
