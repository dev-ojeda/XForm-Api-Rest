namespace XForm_Api_Rest.Pages
{
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    using XForm_Api_Rest.Model;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SchedulePage : ContentPage
    {

        private UsuarioModel _usuarioModel;

        public UsuarioModel UsuarioModel { get => _usuarioModel; set => _usuarioModel = value; }

        public SchedulePage()
        {
            InitializeComponent();
        }

        public SchedulePage(UsuarioModel usuarioModel)
        {
            this.UsuarioModel = usuarioModel;
        }

        async void OnUpcomingAppointmentsButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new XForm_Api_Rest.Pages.UpcomingAppointmentsPage());
        }

        async void OnLogoutButtonClicked(object sender, EventArgs e)
        {
            App.IsUserLoggedIn = false;
            Navigation.InsertPageBefore(new XForm_Api_Rest.Pages.LoginPage(), this);
            await Navigation.PopAsync();
        }
    }
}