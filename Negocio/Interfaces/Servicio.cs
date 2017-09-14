using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Clases;

namespace Negocio.Interfaces
{
    public class Servicio : IServicio, IServicioProducto
    {
        public CUsuario GetCUsuario(string user, string pass)
        {
            return CUsuario.ObtenerUsuario(user, pass);
        }

        public CUsuario GetCUsuario(CUsuario usuarioBD)
        {
            CUsuario cUsuario = new CUsuario(usuarioBD);
            return CUsuario.ObtenerUsuario(cUsuario);
        }

        public List<CProducto> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
