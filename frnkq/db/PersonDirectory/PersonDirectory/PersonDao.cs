using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace PersonDirectory
{
    public static class PersonDao
    {
        private static SqlCommand loadPersonsCommand;
        private static List<Persona> persons;

        public static Persona loadPersona(string id)
        {
            Persona persona = new Persona();
            loadPersonsCommand = new SqlCommand();
            loadPersonsCommand.CommandType = System.Data.CommandType.Text;
            loadPersonsCommand.CommandText = "SELECT * FROM Person.Person WHERE BusinessEntityID = " + id;

            loadPersonsCommand.Connection = DbConnection.GetConnection();
            SqlDataReader dataReader = loadPersonsCommand.ExecuteReader();

            while (dataReader.Read())
            {
                persona = new Persona(dataReader["id"].ToString(),
                    dataReader["FirstName"].ToString(),
                    dataReader["MiddleName"].ToString(),
                    dataReader["LastName"].ToString());
            }
            return persona; 

        }

        public static bool updatePersona(Persona p)
        {
            loadPersonsCommand = new SqlCommand();
            loadPersonsCommand.CommandType = System.Data.CommandType.Text;
            loadPersonsCommand.Connection = DbConnection.GetConnection();

            loadPersonsCommand.CommandText = "UPDATE Person.Person set FirstName='"+p.FirstName+"',"+
                                            "MiddleName='"+p.MiddleName+"',"+
                                            "LastName='"+p.LastName+"' "+
                                            "WHERE BusinessEntityID = " + p.ID;
            try
            {
                loadPersonsCommand.ExecuteNonQuery();
                return true;
            }catch(Exception e)
            {
                throw e;
            }
        }
        public static List<Persona> loadPersons()
        {
            persons = new List<Persona>();
            loadPersonsCommand = new SqlCommand();
            loadPersonsCommand.CommandType = System.Data.CommandType.Text;
            loadPersonsCommand.Connection = DbConnection.GetConnection();
            loadPersonsCommand.CommandText = "SELECT * FROM Person.Person";

            SqlDataReader dataReader = loadPersonsCommand.ExecuteReader();

            while (dataReader.Read())
            {
                    Persona persona = new Persona(dataReader["BusinessEntityID"].ToString(),
                        dataReader["FirstName"].ToString(),
                        dataReader["MiddleName"].ToString(),
                        dataReader["LastName"].ToString());

                    persons.Add(persona);
            }
            dataReader.Close();
            return persons;
        }

        public static List<Persona> SearchPersons(string searchText)
        {
            persons = new List<Persona>();
            loadPersonsCommand = new SqlCommand();
            loadPersonsCommand.CommandType = System.Data.CommandType.Text;
            loadPersonsCommand.Connection = DbConnection.GetConnection();
            loadPersonsCommand.CommandText = "SELECT * FROM Person.Person " +
                                              "WHERE FirstName LIKE '"+searchText+"' "+
                                              "OR MiddleName LIKE'"+searchText+"' "+
                                              "OR LastName LIKE'"+searchText+"'";

            SqlDataReader dataReader = loadPersonsCommand.ExecuteReader();

            while (dataReader.Read())
            {
                Persona persona = new Persona(dataReader["BusinessEntityID"].ToString(),
                    dataReader["FirstName"].ToString(),
                    dataReader["MiddleName"].ToString(),
                    dataReader["LastName"].ToString());

                persons.Add(persona);
            }
            dataReader.Close();
            return persons;
        }
    }
}
