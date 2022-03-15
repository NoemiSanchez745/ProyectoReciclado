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
        ServicioRecicladoBotellas servicioRecicladoBotellas;
        string codigo = string.Empty;
        double totalGramos = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            servicioRecicladoBotellas = new ServicioRecicladoBotellas();

            if (!IsPostBack)
            {
                if (Session["Usuario"] != null)
                {
                    codigo = Session["Usuario"].ToString();
                    Usuario usuario = servicioRecicladoBotellas.SelectUsuario(codigo);
                    if(usuario != null)
                    {
                        lbNombre.Text = usuario.Nombres + " " + usuario.Apellidos;
                        lbCodigo.Text = usuario.Codigo;

                        gvListaGramos.DataSource = null;
                        gvListaGramos.DataSource = servicioRecicladoBotellas.SelectContenedor(codigo);
                        gvListaGramos.DataBind();
                        gvListaGramos.HeaderRow.TableSection = TableRowSection.TableHeader;

                        gvListaGramos.Columns[0].Visible = false;

                        foreach (GridViewRow item in gvListaGramos.Rows)
                        {
                            totalGramos = totalGramos + double.Parse(item.Cells[1].Text);
                        }

                        lbGramos.Text = totalGramos + " gramos";
                    }
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }
    }
}