using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFServicioRecicladoBotellas.Entidades
{
    public class Usuario
    {
        #region Propiedades
        public string Codigo { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }
        #endregion

        #region Constructores
        /// <summary>
        /// Get
        /// </summary>
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