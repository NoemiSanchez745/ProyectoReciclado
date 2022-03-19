using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFServicioRecicladoBotellas.Entidades
{
    [DataContract]
    public class Contenedor
    {
        #region Propiedades
        [DataMember]
        public double Gramos { get; set; }
        [DataMember]
        public DateTime Fecha { get; set; }
        [DataMember]
        public DateTime Hora { get; set; }
        [DataMember]
        public string Codigo{ get; set; }
        #endregion

        #region Constructores
        /// <summary>
        /// Get
        /// </summary>
        /// <param name="Gramos"></param>
        /// <param name="Fecha"></param>
        /// <param name="Hora"></param>
        /// <param name="Codigo"></param>
        public Contenedor(double Gramos, DateTime Fecha, DateTime Hora, string Codigo)
        {
            this.Gramos = Gramos;
            this.Fecha = Fecha;
            this.Hora = Hora;
            this.Codigo = Codigo;
        }
        #endregion
    }
}