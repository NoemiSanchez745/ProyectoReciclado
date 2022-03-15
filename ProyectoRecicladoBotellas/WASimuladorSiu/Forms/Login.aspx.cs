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
    public partial class Login : System.Web.UI.Page
    {
        ServicioRecicladoBotellas servicioRecicladoBotellas;
        string codigo = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session.RemoveAll();
            }
        }

        protected void btnIniciar_Click(object sender, ImageClickEventArgs e)
        {
            if (txtCuenta.Text.Trim() != "")
            {
                codigo = txtCuenta.Text.Trim();
                servicioRecicladoBotellas = new ServicioRecicladoBotellas();
                Usuario u = servicioRecicladoBotellas.SelectUsuario(codigo.ToLower());
                if (u != null)
                {
                    Session["Usuario"] = u.Codigo;
                    Response.Redirect("MenuEstudiante.aspx");
                }
                else
                {
                    Page_Load(sender,e);
                }
            }
        }
    }
}