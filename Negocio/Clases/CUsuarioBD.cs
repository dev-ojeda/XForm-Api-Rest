using log4net;
using Negocio.Entidad;
using System;
using System.Linq;

namespace Negocio.Clases
{
    public class CUsuarioBD
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        protected CUsuarioBD() { }

       

        public static CUsuario ObtenerUsuario(string usuario, string password)
        {
            using (BDProductoraEntidad db = new BDProductoraEntidad())
            {
                CUsuario cUsuario = new CUsuario();
                try
                {
                    var objResultUsuario = db.sp_ObtenerUsuario(usuario, password).SingleOrDefault();

                    if (objResultUsuario != null)
                    {
                        cUsuario.Nombre = objResultUsuario.Nombre;
                    }
                    else
                    {
                        cUsuario.Nombre = "";
                    }

                }
                catch (Exception ex)
                {
                    log.Error("Excepcion: ", ex);
                }

                return cUsuario;
            }
        }

        public static CUsuario ObtenerUsuario(CUsuario objUsuario)
        {
            using (BDProductoraEntidad db = new BDProductoraEntidad())
            {
                CUsuario cUsuario = new CUsuario();
                try
                {
                    var objResultUsuario = db.sp_ObtenerUsuario(objUsuario.Usuario, objUsuario.Password).SingleOrDefault();

                    if (objResultUsuario != null)
                    {
                        cUsuario.Nombre = objResultUsuario.Nombre;
                    }
                    else
                    {
                        cUsuario.Nombre = "";
                    }

                }
                catch (Exception ex)
                {
                    log.Error("Excepcion: ", ex);
                }

                return cUsuario;
            }
        }
    }
}
