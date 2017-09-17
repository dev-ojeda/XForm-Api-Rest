namespace XForm_Api_Rest.ViewModel
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using XForm_Api_Rest.Model;

    public class EquipoViewModel
    {
        private ObservableCollection<EquipoModel> _listarEquipo;

        public ObservableCollection<EquipoModel> ListarEquipo { get => _listarEquipo; set => _listarEquipo = value; }

        public EquipoViewModel() => ListarEquipo = new EquipoModel().ListarEquipo();

        
    }
}
