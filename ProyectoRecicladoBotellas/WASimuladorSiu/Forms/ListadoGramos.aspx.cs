using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFServicioRecicladoBotellas;
using WCFServicioRecicladoBotellas.Entidades;

namespace WASimuladorSiu.Forms
{
    public partial class ListadoGramos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServicioRecicladoBotellas servicioRecicladoBotellas = new ServicioRecicladoBotellas();
            double totalGramos = 0;

            if (!this.IsPostBack)
            {
                Usuario usuario = servicioRecicladoBotellas.SelectUsuario(2);
                lbNombre.Text = usuario.Nombres + " " + usuario.Apellidos;
                lbCodigo.Text = usuario.Codigo;

                gvListaGramos.DataSource = null;
                gvListaGramos.DataSource = servicioRecicladoBotellas.SelectContenedor(2);
                gvListaGramos.DataBind();
                gvListaGramos.HeaderRow.TableSection = TableRowSection.TableHeader;

                gvListaGramos.Columns[0].Visible = false;
                gvListaGramos.Columns[4].Visible = false;

                foreach (GridViewRow item in gvListaGramos.Rows)
                {
                    totalGramos = totalGramos + double.Parse(item.Cells[1].Text);
                }

                lbGramos.Text = totalGramos + " gramos";
            }
        }
    }
}