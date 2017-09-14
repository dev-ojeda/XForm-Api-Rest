using Negocio.Interfaces;
using System;
using System.Text;
using System.Web.Http;

namespace Api.Controllers
{
    public class UsuarioController : ApiController
    {
        // GET: api/usuario/get?user=admin&pass=admin
        [HttpGet]
        public IHttpActionResult Get(string user, string pass)
        {

            Servicio servicio = new Servicio();
            var result = servicio.GetCUsuario(user, pass);
            if (!string.IsNullOrWhiteSpace(result.Nombre))
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }

        // GET: api/usuario/get?id=5
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            return Ok("value");
        }

    }
}
