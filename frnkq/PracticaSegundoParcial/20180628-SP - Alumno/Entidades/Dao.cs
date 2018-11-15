using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class Dao : IArchivos<Votacion>
    {
        private static SqlConnection connection;
        private static SqlCommand commando;

        static Dao()
        {
            string connectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=votacion-sp-2018; Integrated Security=True;";
            connection = new SqlConnection(connectionString);
            
        }

        public bool Guardar(string rutaArchivo, Votacion objeto)
        {
            
                connection.Open();
                string alumno = "Franco Canevali";

                string comando = String.Format("INSERT INTO Votaciones (nombreLey,afirmativos,negativos,abstenciones,nombreAlumno) VALUES('{0}','{1}','{2}','{3}','{4}')",
                    objeto.NombreLey, objeto.ContadorAfirmativo, objeto.ContadorNegativo, 
                    objeto.ContadorAbstencion, alumno
                    );
                commando = new SqlCommand(comando, connection);

                try
                {
                    commando.ExecuteNonQuery();
                    return true;
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    connection.Close();
                }

        }


        public Votacion Leer(string rutaArchivo)
        {
            throw new NotImplementedException();
        }

    }
}
