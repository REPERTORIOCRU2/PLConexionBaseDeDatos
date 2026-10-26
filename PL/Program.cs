using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Ingresa la accion a realizar");
                Console.WriteLine("1. Mostrar");
                Console.WriteLine("2. Guardar");
                Console.WriteLine("3. Actualizar");
                Console.WriteLine("4. Buscar");
                Console.WriteLine("5. Eliminar");

                int operador = Convert.ToInt32(Console.ReadLine());

                switch (operador)
                {
                    case 1:
                        Console.WriteLine("opcion 1");
                        BL.BussinesLayout.MostarDatos();
                        break;
                    case 2:
                        //se crea el metodo constructor que inicializa  para estar en una box o caja
                        //donde de estar vacia pasara a null para guardar los parametros 
                        ML.UsuarioModelo usuario =new  ML.UsuarioModelo();

                        usuario.Nombre = Convert.ToString(Console.ReadLine());
                        usuario.Paterno = Convert.ToString(Console.ReadLine());
                        usuario.Materno = Convert.ToString(Console.ReadLine());
                        usuario.Edad = Convert.ToInt32(Console.ReadLine());
                        usuario.Fecha = Convert.ToDateTime(Console.ReadLine());

                        BL.BussinesLayout.InsertDatos();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Ingressa una opcion valida");
                        break;
                }

            } while (true);
        }
    }
}
