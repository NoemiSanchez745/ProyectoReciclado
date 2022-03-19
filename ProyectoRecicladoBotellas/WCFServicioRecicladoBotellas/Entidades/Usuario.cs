using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFServicioRecicladoBotellas.Entidades
{
    [DataContract]
    public class Usuario
    {
        #region Propiedades
        [DataMember]
        public string Codigo { get; set; }
        [DataMember]
        public string Nombres { get; set; }
        [DataMember]
        public string Apellidos { get; set; }
        #endregion

        #region Constructores
        /// <summary>
        /// Get
        /// </summary>
        /// <param name="UsuarioID"></param>
        /// <param name="Codigo"></param>
        /// <param name="Nombres"></param>
        /// <param name="Apellidos"></param>
        public Usuario(string Codigo, string Nombres, string Apellidos)
        {
            this.Codigo = Codigo;
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
        }
        #endregion
    }
}