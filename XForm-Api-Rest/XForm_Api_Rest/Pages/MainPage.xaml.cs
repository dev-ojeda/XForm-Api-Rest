namespace XForm_Api_Rest.Pages
{
    using System;
    using Xamarin.Forms;
    using XForm_Api_Rest.Model;
    public partial class MainPage : ContentPage
    {
        public UsuarioModel model { get; set; }

        public MainPage()
        {
            InitializeComponent();
        }

        public MainPage(UsuarioModel usuarioModel)
        {
            //lblMensaje.Text = "Bienvenido: "+usuarioModel.Nombre;
        }

        async void OnLogoutButtonClicked(object sender, EventArgs e)
        {
            App.IsUserLoggedIn = false;
            Navigation.InsertPageBefore(new LoginPage(), this);
            await Navigation.PopAsync();
        }
    }
}
