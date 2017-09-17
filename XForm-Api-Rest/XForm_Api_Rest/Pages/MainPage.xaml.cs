namespace XForm_Api_Rest.Pages
{
    using System;
    using Xamarin.Forms;
    using XForm_Api_Rest.Model;
    public partial class MainPage : ContentPage
    {
        private UsuarioModel usuarioModel;
        public UsuarioModel UsuarioModel { get => usuarioModel; set => usuarioModel = value; }
        public MainPage()
        {
            InitializeComponent();

            Navigation.InsertPageBefore(new XForm_Api_Rest.Pages.EquiposPage(), this);
            Navigation.PopAsync();
        }

        public MainPage(UsuarioModel usuarioModel)
        {
            this.UsuarioModel = usuarioModel;
        }

        async void OnLogoutButtonClicked(object sender, EventArgs e)
        {
            App.IsUserLoggedIn = false;
            Navigation.InsertPageBefore(new XForm_Api_Rest.Pages.LoginPage(), this);
            await Navigation.PopAsync();
        }
    }
}
