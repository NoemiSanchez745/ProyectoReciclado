using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFServicioRecicladoBotellas.Entidades
{
    public class Contenedor
    {
        #region Propiedades
        public string Codigo { get; set; }
        public double Gramos { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        #endregion

        #region Constructores
        /// <summary>
        /// Get/Insert
        /// </summary>
        /// <param name="Codigo"></param>
        /// <param name="Gramos"></param>
        /// <param name="Fecha"></param>
        /// <param name="Hora"></param>
        public Contenedor(string Codigo, double Gramos, DateTime Fecha, DateTime Hora)
        {
            this.Codigo = Codigo;
            this.Gramos = Gramos;
            this.Fecha = Fecha;
            this.Hora = Hora;
        }
        #endregion
    }
}