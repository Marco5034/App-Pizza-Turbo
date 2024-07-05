using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo7
{
    public class Conexion
    {
        //Parametros para la cadena conexion
        public string servidor, usuario, clave, db;
        public string cadena;

        //Funcion que tendra la cadena de conexion
        public void conec()
        {
            servidor = "DESKTOP-BNC8SKO\\SQLEXPRESS";
            db = "BD_PIZZERIA_TURBO";
            usuario = "sa";
            clave = "12345";
            cadena = "server=" + servidor + ";uid=" + usuario + ";pwd=" + clave + ";database=" + db;

        }
    }
}
