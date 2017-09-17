namespace XForm_Api_Rest.Pages
{
    using Newtonsoft.Json;
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    using XForm_Api_Rest.Model;
    using XForm_Api_Rest.Utilidad;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }

        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            var mensaje = AreCredentialsCorrect();
            if (mensaje.Equals("OK"))
            {
                string parametros = "api/usuario/get?user=" + usernameEntry.Text.ToString().Trim() + "&pass=" + passwordEntry.Text.ToString().Trim();
                var url = Convert.ToString("http://localhost:57732/" + parametros);

                RestClient client = new RestClient();
                var response = await client.GetAsync(url);

                UsuarioModel usuarioModel = JsonConvert.DeserializeObject<UsuarioModel>(response);
                App.IsUserLoggedIn = true;
                Navigation.InsertPageBefore(new XForm_Api_Rest.Pages.MenuPrincipal(usuarioModel), this);
                await Navigation.PopAsync();
            }
            else
            {
                passwordEntry.Text = string.Empty;
            }
        }
        string AreCredentialsCorrect()
        {
            var user = new UsuarioModel
            {
                Usuario = usernameEntry.Text,
                Password = passwordEntry.Text
            };

            string mensaje = "";
            if (string.IsNullOrWhiteSpace(user.Usuario) && string.IsNullOrWhiteSpace(user.Password))
            {

                DisplayAlert("Login", "Debe Ingresar Usuario y Contraseña", "OK");
            }
            else if (!string.IsNullOrWhiteSpace(user.Usuario) && string.IsNullOrWhiteSpace(user.Password))
            {
                DisplayAlert("Login", "Debe Ingresar Contraseña", "OK");
            }
            else if (string.IsNullOrWhiteSpace(user.Usuario) && !string.IsNullOrWhiteSpace(user.Password))
            {
                DisplayAlert("Login", "Debe Ingresar Usuario", "OK");
            }
            else if (!string.IsNullOrWhiteSpace(user.Usuario) && !string.IsNullOrWhiteSpace(user.Password))
            {
                mensaje = "OK";
            }

            return mensaje;
        }
    }
}