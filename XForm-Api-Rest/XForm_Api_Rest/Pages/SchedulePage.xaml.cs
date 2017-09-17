

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
            InitializeComponent();
            this.UsuarioModel = usuarioModel;
        }

        async void OnUpcomingAppointmentsButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new XForm_Api_Rest.Pages.UpcomingAppointmentsPage());
        }
    }
}