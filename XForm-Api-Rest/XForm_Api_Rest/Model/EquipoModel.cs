

namespace XForm_Api_Rest.Model
{
    using System.Collections.ObjectModel;

    public class EquipoModel
    {

        public string NombreEquipo { get; set; }
        public string DescripcionEquipo { get; set; }
        public string ImageUrl { get; set; }
        public string Precio { get; set; }

        public ObservableCollection<EquipoModel> ListarEquipo()
        {

            ObservableCollection<EquipoModel> ListarEquipo = new ObservableCollection<EquipoModel>()
            {
               new EquipoModel
               {
                   ImageUrl = "Maquina_de_Humo",
                   NombreEquipo = "Maquina de Humo",
                   DescripcionEquipo = "Maquina de Humo de 700 Watts",
                   Precio = "$8.000"
               }
            };

            return ListarEquipo;
        }
    }
}
