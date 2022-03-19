using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using WASimuladorSiu.WCFRecicladoBotellas;
using WASimuladorSiu.ServicioRecicladoBotellas;

namespace WASimuladorSiu.Forms
{
    public partial class ListadoGramos : System.Web.UI.Page
    {
        string message, codigo;
        protected void Page_Load(object sender, EventArgs e)
        {
            ServicioRecicladoBotellasClient client = new ServicioRecicladoBotellasClient();
            double totalGramos = 0;

            if (!this.IsPostBack)
            {
                codigo = Session["codigo"].ToString().Trim();
                message = Session["message"].ToString();
                if (message == "OK")
                {
                    var usuario = client.SelectUsuario(codigo);
                    lbNombre.Text = usuario.Nombres + " " + usuario.Apellidos;
                    lbCodigo.Text = usuario.Codigo;

                    gvListaGramos.DataSource = null;
                    gvListaGramos.DataSource = client.SelectContenedor(codigo);
                    gvListaGramos.DataBind();
                    gvListaGramos.HeaderRow.TableSection = TableRowSection.TableHeader;

                    gvListaGramos.Columns[3].Visible = false;

                    foreach (GridViewRow item in gvListaGramos.Rows)
                    {
                        totalGramos = totalGramos + double.Parse(item.Cells[0].Text);
                    }

                    lbGramos.Text = totalGramos + " gramos";
                }                
            }
        }
    }
}