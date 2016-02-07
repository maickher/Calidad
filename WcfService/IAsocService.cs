﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService.Services;

namespace WcfService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IAsocService
    {
        #region SEGURIDAD
        #region Usuario
        [OperationContract]
        void CreateUser(WCFUsuario user);

        [OperationContract]
        void UpdateUser(WCFUsuario user);

        [OperationContract]
        WCFUsuario RedUser(int id);

        [OperationContract]
        List<WCFUsuario> ReadAllUser();

        [OperationContract]
        void DeleteUser(int id);
        #endregion
        #endregion

    }
}