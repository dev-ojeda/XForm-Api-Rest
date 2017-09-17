using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XForm_Api_Rest.Model;

namespace XForm_Api_Rest.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPrincipalPage : TabbedPage
    {
        private UsuarioModel usuarioModel;
        public UsuarioModel UsuarioModel { get => usuarioModel; set => usuarioModel = value; }
        public MenuPrincipalPage(UsuarioModel usuarioModel)
        {
            InitializeComponent();
            this.UsuarioModel = usuarioModel;

            Children.Add(new Pages.EquiposPage(UsuarioModel));
            Children.Add(new Pages.SchedulePage(UsuarioModel));
            Children.Add(new Pages.SettingsPage(UsuarioModel));

        }

        public MenuPrincipalPage()
        {
            InitializeComponent();
        }

        async void OnLogoutButtonClicked(object sender, EventArgs e)
        {
            App.IsUserLoggedIn = false;
            Navigation.InsertPageBefore(new LoginPage(), this);
            await Navigation.PopAsync();
        }
    }
}