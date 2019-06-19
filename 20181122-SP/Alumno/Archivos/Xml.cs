using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public void Guardar(string archivo, T datos)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(T));
            XmlTextWriter archivoEscribir = null;

            try
            {
                archivoEscribir = new XmlTextWriter(archivo, null);
                serializador.Serialize(archivoEscribir, datos);
            }
            catch
            {
                
            }
            finally
            {
                archivoEscribir.Close();
            }
        }

        public void Leer(string archivo, out T datos)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(T));
            XmlTextReader archivoLeer = null;

            try
            {
                archivoLeer = new XmlTextReader(archivo);
                datos = (T)serializador.Deserialize(archivoLeer, archivo);
            }
            catch
            {
                datos = default(T);
            }
            finally
            {
                archivoLeer.Close();
            }
        }
    }
}
