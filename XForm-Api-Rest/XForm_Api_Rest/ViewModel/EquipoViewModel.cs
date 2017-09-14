using System;

namespace XForm_Api_Rest.ViewModel
{
    using System.Collections.Generic;
    using XForm_Api_Rest.Model;

    public class EquipoViewModel
    {
        public List<EquipoModel> ListarEquipo { get; set; }

        public EquipoViewModel() => ListarEquipo = new EquipoModel().ListarEquipo();
    }
}
