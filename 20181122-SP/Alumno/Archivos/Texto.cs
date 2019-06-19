using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;

namespace Archivos
{
    public class Texto : IArchivo<Queue<Patente>>
    {
       public void Guardar(string archivo, Queue<Patente> datos)
        {
            StreamWriter archivoEscribir;
            archivoEscribir = new StreamWriter(archivo, false);

            try
            {
                foreach(Patente p in datos)
                {
                     archivoEscribir.Write(p);
                }
            }
            catch
            {

            }
            finally
            {
                archivoEscribir.Close();
            }



        }

        public void Leer(string archivo, out Queue<Patente> datos)
        {
            StreamReader archivoLeer;
            archivoLeer = new StreamReader(archivo);
            datos = new Queue<Patente>();
            Patente patente;
            string auxPatente;

            try
            {
                while(!archivoLeer.EndOfStream)
                {
                    auxPatente = archivoLeer.ReadLine();
                    if(auxPatente.Length == 6)
                    {
                        patente = new Patente(auxPatente, Patente.Tipo.Vieja);
                        datos.Enqueue(patente);
                    }
                    else if(auxPatente.Length == 7)
                    {
                        patente = new Patente(auxPatente, Patente.Tipo.Mercosur);
                        datos.Enqueue(patente);
                    }

                }
            }
            catch
            {
                datos = null;
            }
            finally
            {
                archivoLeer.Close();
            }

        }
   
    }
}
