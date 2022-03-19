using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//using WPFSimuladorMaquina.WCFServicioRecicladoBotellas;
using WPFSimuladorMaquina.ServicioRecicladoBotellas;

namespace WPFSimuladorMaquina
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ServicioRecicladoBotellasClient client;
        string codigo, mensaje;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLeer_Click(object sender, RoutedEventArgs e)
        {
            if (txtCodigo.Text.Trim() != "")
            {
                client = new ServicioRecicladoBotellasClient();
                mensaje = client.GetUserMessage(txtCodigo.Text.Trim().ToLower());
                if (mensaje == "OK")
                {
                    btnStop.IsEnabled = true;
                    btnLeer.IsEnabled = false;
                    codigo = txtCodigo.Text.Trim().ToLower();
                    lblCodigo.Content = "Codigo: " + codigo;
                }
                lblMensajeLector.Content = "mensaje: " + mensaje;
            }
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            if (txtGramos.Text.Trim() != "")
            {
                client = new ServicioRecicladoBotellasClient();
                int res = client.InsertContenedor(double.Parse(txtGramos.Text.Trim()), DateTime.Now, TimeSpan.Parse(DateTime.Now.ToString("hh:mm")), codigo);
                if (res > 0)
                {
                    lblMensajeRegistro.Content = "mensaje: Se ha registrado " + txtGramos.Text.Trim() + "gr.";
                }
            }
            else
                lblMensajeRegistro.Content = "mensaje:";
            btnStop.IsEnabled = false;
            btnLeer.IsEnabled = true;
            lblCodigo.Content = "Codigo: ";
            codigo = "";
        }        
    }
}
