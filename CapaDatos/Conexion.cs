using CapaDatos;
using CapaDatos.DSConexionTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class Conexion
    {
        UsuarioTableAdapter oAutenticar = new UsuarioTableAdapter();
        public int ValidarUsuario(string usuario, string clave)
        {
            try
            {
               return (int)oAutenticar.ValidarUsuario(usuario, clave);
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public string insertarUsuario(string tipoDocumento,string id, )
        {
            try
            {
               return oAutenticar.InsertarUsuario()
            }
            catch (Exception)
            {

                return 0;
            }
        }

    }
}
