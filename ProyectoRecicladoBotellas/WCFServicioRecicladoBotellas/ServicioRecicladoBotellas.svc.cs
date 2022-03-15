using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFServicioRecicladoBotellas.AccesoDatos;
using WCFServicioRecicladoBotellas.Entidades;

namespace WCFServicioRecicladoBotellas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioRecicladoBotellas" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioRecicladoBotellas.svc o ServicioRecicladoBotellas.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioRecicladoBotellas : IServicioRecicladoBotellas
    {
        #region Contenedor
        public List<Contenedor> SelectContenedor(string codigo)
        {
            DataTable dt = null;
            List<Contenedor> list = new List<Contenedor>();
            Contenedor contenedor;
            try
            {
                string query = @"SELECT Codigo, Gramos, Fecha, Hora
                                 FROM Contenedor WHERE Codigo = @Codigo";
                SqlCommand cmd = DataBase.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                dt = DataBase.ExecuteDataTableCommand(cmd);
                foreach (DataRow item in dt.Rows)
                {
                    contenedor = new Contenedor(item.ItemArray[0].ToString(), double.Parse(item.ItemArray[1].ToString()), DateTime.Parse(item.ItemArray[2].ToString()), DateTime.Parse(item.ItemArray[3].ToString()));
                    list.Add(contenedor);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
        #endregion

        #region Usuario
        public Usuario SelectUsuario(string codigo)
        {
            Usuario u = null;
            string query = @"SELECT Codigo,Nombres,Apellidos 
                             FROM Usuario WHERE Codigo=@Codigo";
            SqlDataReader dr = null;
            SqlCommand cmd = null;
            try
            {
                cmd = DataBase.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                dr = DataBase.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    u = new Usuario(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
                dr.Close();
            }
            return u;
        }
        #endregion
    }
}
