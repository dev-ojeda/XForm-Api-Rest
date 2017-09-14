using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Clases;
namespace Negocio.Interfaces
{
    public interface IServicio
    {
        CUsuario GetCUsuario(string user, string pass);
        CUsuario GetCUsuario(CUsuario usuarioBD);
    }

    public interface IServicioProducto
    {
        List<CProducto> GetList();
    }
}
