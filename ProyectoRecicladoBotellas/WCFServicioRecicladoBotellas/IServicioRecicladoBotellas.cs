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
        [OperationContract]

        #region Contenedor
        List<Contenedor> SelectContenedor(string codigo);
        #endregion

        #region Usuario
        Usuario SelectUsuario(string codigo);
        #endregion

    }
}
