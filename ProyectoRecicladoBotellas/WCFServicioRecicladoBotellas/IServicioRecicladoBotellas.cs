using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFServicioRecicladoBotellas.Entidades;

namespace WCFServicioRecicladoBotellas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioRecicladoBotellas" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioRecicladoBotellas
    {
        #region Contenedor
        [OperationContract]
        List<Contenedor> SelectContenedor(string codigo);
        [OperationContract]
        int InsertContenedor(double gramos, DateTime fecha, TimeSpan hora, string codigo);
        #endregion

        #region Usuario
        [OperationContract]
        Usuario SelectUsuario(string codigo);
        [OperationContract]
        string GetUserMessage(string codigo);
        #endregion

    }
}
