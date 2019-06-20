using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
    public class Sql : IArchivo<Queue<Patente>>
    {
        SqlCommand comando;
        SqlConnection conexion;

        public Sql()
        {
            comando = new SqlCommand();
            conexion = new SqlConnection("Data Source=LAB3PC19\\SQLEXPRESS; Initial catalog=patentes-sp-2018; Integrated Security=True");
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public void Guardar(string tabla, Queue<Patente> datos)
        {
            String agregar;
            foreach(Patente p in datos)
            {
                agregar = String.Format("INSERT INTO {0} (patente, tipo) VALUE({1},{2})", tabla, p.CodigoPatente, p.TipoCodigo);

                comando.CommandText = agregar;
                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void Leer(string tabla, out Queue<Patente> datos)
        {
            datos = null;
            string auxCodigoPatente;
            string auxTipo;
            SqlDataReader oDr = comando.ExecuteReader();
            Patente nuevaPatente;

            comando.CommandText = "SELECT patente, tipo FROM patentes-sp-2018";
            conexion.Open();

            while (oDr.Read())
            {
                auxCodigoPatente = oDr["patente"].ToString();
                auxTipo = oDr["tipo"].ToString();
                if(auxTipo == "Vieja")
                {
                    nuevaPatente = new Patente(auxCodigoPatente, Patente.Tipo.Vieja);
                    datos.Enqueue(nuevaPatente);                   
                }
                else
                {
                    nuevaPatente = new Patente(auxCodigoPatente, Patente.Tipo.Mercosur);
                    datos.Enqueue(nuevaPatente);
                }
                
            }

        }
    }
}
