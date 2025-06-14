using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos.EF;

namespace Controladores
{
    public static class Sesion
    {

        public static Usuario usuarioActual { get; set; }
   


        public static void iniciarSesion(Usuario usuario)
        {
            usuarioActual = usuario;
        }

        public static void cerrarSesion()
        {
            usuarioActual = null;
        }



    }
}
