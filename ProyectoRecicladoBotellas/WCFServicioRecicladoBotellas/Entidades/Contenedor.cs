using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFServicioRecicladoBotellas.Entidades
{
    public class Contenedor
    {
        #region Propiedades
        public short ContenedorID { get; set; }
        public double Gramos { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public int UsuarioID { get; set; }
        #endregion

        #region Constructores
        /// <summary>
        /// Get
        /// </summary>
        /// <param name="ContenedorID"></param>
        /// <param name="Gramos"></param>
        /// <param name="Fecha"></param>
        /// <param name="Hora"></param>
        /// <param name="UsuarioID"></param>
        public Contenedor(short ContenedorID, double Gramos, DateTime Fecha, DateTime Hora, int UsuarioID)
        {
            this.ContenedorID = ContenedorID;
            this.Gramos = Gramos;
            this.Fecha = Fecha;
            this.Hora = Hora;
            this.UsuarioID = UsuarioID;
        }

        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="Gramos"></param>
        /// <param name="Fecha"></param>
        /// <param name="Hora"></param>
        /// <param name="UsuarioID"></param>
        public Contenedor(double Gramos, DateTime Fecha, DateTime Hora, int UsuarioID)
        {
            this.Gramos = Gramos;
            this.Fecha = Fecha;
            this.Hora = Hora;
            this.UsuarioID = UsuarioID;
        }
        #endregion
    }
}