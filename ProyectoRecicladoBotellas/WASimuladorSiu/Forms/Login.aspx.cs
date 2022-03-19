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
    public partial class Login : System.Web.UI.Page
    {
        ServicioRecicladoBotellasClient client;
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
                client = new ServicioRecicladoBotellasClient();
                                
                Session["message"] = client.GetUserMessage(txtCuenta.Text.Trim().ToLower());
                Session["codigo"] = txtCuenta.Text.Trim().ToLower();
                Response.Redirect("../Forms/MenuEstudiante.aspx");
            }
        }
    }
}