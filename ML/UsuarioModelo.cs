using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class UsuarioModelo
    {
        //modelo de la informacion 
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno {  get; set; }
        public int Edad {get; set;  }
        public DateTime Fecha { get; set; }


    }
}
