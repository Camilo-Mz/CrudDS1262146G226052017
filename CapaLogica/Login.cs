using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaLogica
{
    public class Login
    {

        public int ValidarUsuario(string usuario, string clave)
        {
            Conexion oConexion = new Conexion();

            switch (oConexion.ValidarUsuario(usuario, clave))
            {
                case 1:
                    MessageBox.Show("UsuarioAdministrador");
                    break;
                case 2:
                    MessageBox.Show("UsuarioEmpleado");
                    break;
                case 3:
                    MessageBox.Show("UsuarioInvitado");
                    break;
                default:

                    MessageBox.Show("Usuario y contraseña son invalidos");
                    break;
            }

            return (int)oConexion.ValidarUsuario(usuario, clave);
        }


    }
}
