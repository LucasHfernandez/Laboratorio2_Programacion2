using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    public interface IArchivo<T>
    {
        void Guardar(string Archivos, T datos);
        void Leer(string Archivos, out T datos);
    }
}
