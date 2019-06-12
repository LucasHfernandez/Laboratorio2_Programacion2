using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Entidades
{
    public class PersonaDao
    {
        public static String connectionStr = "Data Source=LAB3PC19\\SQLEXPRESS; Initial catalog=Persona; Integrated Security=True";
        public static SqlConnection connection;
        public static SqlCommand command;
        
        public PersonaDao()
        {
            command = new SqlCommand();
            connection = new SqlConnection(connectionStr);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public void Guardar(Persona persona)
        {
            String agregar;

            agregar = String.Format("INSERT INTO dbo.Person(Nombre, Apellido) VALUES({0},{1})", persona.Nombre, persona.Apellido);
            
            command.CommandText = agregar;
            connection.Open();
            command.ExecuteNonQuery();
        }

        public List<Persona>Leer()
        {
            List<Persona> listPersona = new List<Persona>();
            string auxNombre;
            string auxApellido;
            int auxId;
            SqlDataReader oDr = command.ExecuteReader();

            command.CommandText = "SELECT ID,Nombre,Apellido FROM dbo.Person";
            connection.Open();

            while(oDr.Read())
            {
                auxNombre = oDr["Nombre"].ToString();
                auxApellido = oDr["Apellido"].ToString();
                int.TryParse(oDr["ID"].ToString(), out auxId);
                Persona nuevaPersona = new Persona(auxId, auxNombre, auxApellido);
                listPersona.Add(nuevaPersona);
            }

            return listPersona;
        }

        public Persona LeerPorId(int id)
        {
            SqlDataReader oDr = command.ExecuteReader();
            string auxNombre;
            string auxApellido;
            int auxId;
            Persona datoPersona;

            command.CommandText = String.Format("SELECT ID,Nombre,Apellido FROM dbo.Person WHERE ID = {0}", id);
            connection.Open();

            if(oDr.Read())
            {
                auxNombre = oDr["Nombre"].ToString();
                auxApellido = oDr["Apellido"].ToString();
                int.TryParse(oDr["ID"].ToString(), out auxId);
                datoPersona = new Persona(auxId, auxNombre, auxApellido);
            }
            else
            {
                datoPersona = null;
            }

            return datoPersona;
        }

        public void Modificar(int id, string nombre, string apellido)
        {
            String modificar;

            modificar = String.Format("UPDATE ID,Nombre,Apellido SET {0} {1} {2} WHERE ID = {3}", id, nombre, apellido, id);

            command.CommandText = modificar;
            connection.Open();
            command.ExecuteNonQuery();
        }

        public void Borrar(int id)
        {
            String borrar;

            borrar = String.Format("DELETE ID,Nombre,Apellido FROM dbo.Person WHERE ID = {0}", id);

            command.CommandText = borrar;
            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}
