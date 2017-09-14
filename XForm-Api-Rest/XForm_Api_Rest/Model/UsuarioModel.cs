using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XForm_Api_Rest.Model
{
    public class UsuarioModel
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Usuario { get; set; }

        public string Password { get; set; }
    }
}
