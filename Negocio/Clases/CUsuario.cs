
using Negocio.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   

namespace Negocio.Clases
{
    public class CUsuario : CUsuarioBD
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public CUsuario()
        {

        }

        public CUsuario(string usuario, string password)
        {
            this.Usuario = usuario;
            this.Password = password;
        }

        public CUsuario(string nombre, string usuario, string password)
        {
            this.Nombre = nombre;
            this.Usuario = usuario;
            this.Password = password;
        }

        public CUsuario(CUsuario cUsuario)
        {
            this.Nombre = cUsuario.Nombre;
            this.Usuario = cUsuario.Usuario;
            this.Password = cUsuario.Password;
        }

    }
}
