using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
    public class Sql : IArchivo<Queue<Patente>>
    {
        private SqlCommand comando;
        private SqlConnection conexion;
        public Sql()
        {
            conexion = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = patentes-sp-2018; Integrated Security = True;");
            comando = new SqlCommand();
            this.comando.CommandType = CommandType.Text;
        }

        public void Guardar(string tabla, Queue<Patente> datos)
        {

            foreach(Patente pat in datos)
            {
                this.comando.CommandText = String.Format("INSERT INTO {0} (patente,tipo) VALUES('{1}','{2}')",
                    tabla, pat.CodigoPatente, pat.TipoCodigo);
                this.comando.Connection = this.conexion;
                try
                {
                    this.conexion.Open();
                    this.comando.ExecuteNonQuery();
                }catch(Exception e)
                {

                }
                finally
                {
                    if (this.conexion != null)
                        this.conexion.Close();
                }

            }
            
        }

        public void Leer(string tabla, out Queue<Patente> datos)
        {
            this.conexion.Open();
            Queue<Patente> patentes = new Queue<Patente>();
            this.comando.CommandText = String.Format("SELECT * FROM {0}",tabla);
            this.comando.Connection = this.conexion;
            SqlDataReader dataReader = comando.ExecuteReader();
            try
            {
                while (dataReader.Read())
                {
                    Entidades.Patente.Tipo tipo = Patente.Tipo.Mercosur;

                    if (dataReader["tipo"].ToString().Equals("Vieja"))
                        tipo = Patente.Tipo.Vieja;
                    Patente patente = new Patente(dataReader["patente"].ToString(), tipo);
                    patentes.Enqueue(patente);
                }
            }
            catch(Exception e)
            {

            }
            dataReader.Close();
            datos = patentes;
        }
    }
}
