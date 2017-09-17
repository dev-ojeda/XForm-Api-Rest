namespace XForm_Api_Rest.Pages
{
    using System;
    using Xamarin.Forms;
    using XForm_Api_Rest.Model;
    using XForm_Api_Rest.ViewModel;

    public partial class EquiposPage : ContentPage
    {
        private EquipoViewModel equipoViewModel;
        private UsuarioModel usuarioModel;
        public UsuarioModel UsuarioModel { get => usuarioModel; set => usuarioModel = value; }
        public EquiposPage()
        {
            InitializeComponent();
            equipoViewModel = new EquipoViewModel();
            listarEquipos.ItemsSource = equipoViewModel.ListarEquipo;
        }

        public EquiposPage(UsuarioModel usuarioModel)
        {
            InitializeComponent();
            this.UsuarioModel = usuarioModel;
            equipoViewModel = new EquipoViewModel();
            listarEquipos.ItemsSource = equipoViewModel.ListarEquipo;
        }

        async void OnLogoutButtonClicked(object sender, EventArgs e)
        {
            App.IsUserLoggedIn = false;
            Navigation.InsertPageBefore(new XForm_Api_Rest.Pages.LoginPage(), this);
            await Navigation.PopAsync();
        }
    }
}
