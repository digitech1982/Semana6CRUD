using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana6CRUD
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Put : ContentPage
    {
        const string uri = "http://192.168.1.7/moviles/post.php";
        public Put()
        {
            InitializeComponent();
        }

        private void btnActualizar_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient cliente = new WebClient();
                var parametros = "";
                Datos data = new Datos();
                data.codigo = int.Parse(txtCodigo.Text);
                data.nombre = txtNombre.Text;
                data.apellido = txtApellido.Text;
                data.edad = int.Parse(txtEdad.Text);

                var content = JsonConvert.SerializeObject(data);

                parametros += "?codigo=" + txtCodigo.Text;
                parametros += "&nombre=" + txtNombre.Text;
                parametros += "&apellido=" + txtApellido.Text;
                parametros += "&edad=" + txtEdad.Text;
                var urlCompleta = new Uri(uri + parametros);

                cliente.UploadString(urlCompleta, "PUT", content);

                DisplayAlert("Alerta", "Se modifico correctamente el registro ", "Ok");

            }
            catch (Exception)
            {

                DisplayAlert("Mensaje de alerta", "Existe un error", "OK");
            }
        }
    }
}