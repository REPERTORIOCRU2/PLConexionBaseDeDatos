using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace BL
{
    public class BussinesLayout
    {
        public static void MostarDatos()
        {
            //string connection = "User Id=SYSTEM;Password=SYSTEM;Data Source=localhost:1521/XEPDB1;";

            //string coneccion = "Data Source=DESKTOP-06CIC0F;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=\"SQL Server Management Studio\";";

            string coneccion = "Data Source=DESKTOP-06CIC0F;Initial Catalog=PRUEBA;Integrated Security=True;TrustServerCertificate=True;";

            //            using (OracleConnection conn = new OracleConnection(coneccion))
            using (SqlConnection conn = new SqlConnection(coneccion))
            {
                try
                {
                    conn.Open(); // Abrir la conexión

                    // SQL para seleccionar todos los registros de la tabla
                    string sql = "SELECT * FROM dbo.USUARIO";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine("Registros en la tabla:");
                        while (reader.Read())
                        {
                            // Imprime cada columna
                            Console.WriteLine($"ID: {reader["ID"]}, Nombre: {reader["NOMBRE"]}");
                        }
                    }
                }
                catch (OracleException ex)
                {
                    Console.WriteLine("Error al leer los registros: " + ex.Message);
                }
            }
        }

        public static void InsertDatos()
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(DL.Conexion.GetConexion()))
                {

                    conn.Open(); // Abrir la conexión

                    // SQL para insertar un registro
                    string sql = @"
                    INSERT INTO SYSTEM.T102_PADRON_TABLA (NOMBRE, APELLIDO) 
                    VALUES (:nombre, :apellido)";

                    OracleCommand cmd = new OracleCommand(sql, conn);

                    // Parámetros para evitar SQL Injection
                    cmd.Parameters.Add(new OracleParameter("nombre", "Jesus"));
                    cmd.Parameters.Add(new OracleParameter("apellido", "CAlderon"));

                    int filasAfectadas = cmd.ExecuteNonQuery(); // Ejecuta el INSERT
                    Console.WriteLine($"Registro insertado correctamente. Filas afectadas: {filasAfectadas}");

                }
            }catch (OracleException ex)
            {
                Console.WriteLine("Error al insertar el registro: " + ex.Message);
            }
        }
    

    }

}

