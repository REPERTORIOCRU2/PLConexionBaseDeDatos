using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class Conexion
    {
        public static string GetConexion()
        {
            string conexion = "User Id=SYSTEM;Password=SYSTEM;Data Source=localhost:1521/XEPDB1;";
            return conexion;
        }
    }
}
