using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XForm_Api_Rest.ViewModel;

namespace XForm_Api_Rest.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EquiposPage : ContentPage
    {
        EquipoViewModel equipoViewModel;
        public EquiposPage()
        {
            InitializeComponent();
            equipoViewModel = new EquipoViewModel();
            listarEquipos.ItemsSource = equipoViewModel.ListarEquipo;
            //BindingContext = equipoViewModel;
        }
    }
}