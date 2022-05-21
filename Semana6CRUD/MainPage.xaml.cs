using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Semana6CRUD
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnInsertar_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient cliente = new WebClient();
                var parametros = new System.Collections.Specialized.NameValueCollection();
                parametros.Add("codigo", txtCodigo.Text);
                parametros.Add("nombre", txtNombre.Text);
                parametros.Add("apellido", txtApellido.Text);
                parametros.Add("edad", txtEdad.Text);

                cliente.UploadValues("http://192.168.1.7/moviles1/post.php", "POST",parametros);

                DisplayAlert("Mensaje de alerta", "Ingreso Existoso", "OK");

            }
            catch (Exception)
            {
                DisplayAlert("Mensaje de alerta", "Existe un error", "OK");
            }
        }

        private void btnInsertar_Clicked_1(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Clicked_2(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Clicked(object sender, EventArgs e)
        {

        }
    }
}
