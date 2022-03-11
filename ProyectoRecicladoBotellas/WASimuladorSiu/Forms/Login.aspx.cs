using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFServicioRecicladoBotellas;

namespace WASimuladorSiu.Forms
{
    public partial class Login : System.Web.UI.Page
    {
        ServicioRecicladoBotellas servicioRecicladoBotellas;
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
                servicioRecicladoBotellas = new ServicioRecicladoBotellas();
                                
                Session["UsuarioID"] = servicioRecicladoBotellas.GetUserID(txtCuenta.Text.Trim().ToLower());
                Response.Redirect("../Forms/MenuEstudiante.aspx");
            }
        }
    }
}