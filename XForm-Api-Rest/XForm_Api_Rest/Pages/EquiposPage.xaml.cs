
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XForm_Api_Rest.Model;
using XForm_Api_Rest.ViewModel;

namespace XForm_Api_Rest.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
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

    }
}