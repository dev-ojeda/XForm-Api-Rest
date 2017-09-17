
namespace XForm_Api_Rest.Pages
{
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    using XForm_Api_Rest.Model;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        private UsuarioModel _usuarioModel;
        public UsuarioModel UsuarioModel { get => _usuarioModel; set => _usuarioModel = value; }
        public SettingsPage()
        {
            InitializeComponent();
        }

        public SettingsPage(UsuarioModel usuarioModel)
        {
            InitializeComponent();
            this.UsuarioModel = usuarioModel;
        }
    }
}