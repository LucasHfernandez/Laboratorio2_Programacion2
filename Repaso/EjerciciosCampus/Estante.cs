using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCampus
{
    class Estante
    {
        private int ubicacionEstante;
        private Producto[] productos;

        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
            
        }

        public Producto[] GetProductos()
        {
            return productos;
        }

        public static string MostrarEstante(Estante e)
        {
            string cadena = "";
            string mensaje = "";
            int i;

            mensaje = "\n\nUbicacion: " + e.ubicacionEstante;

            for(i = 0; i < e.productos.Length; i++)
            {
                if (!Object.ReferenceEquals(e.productos,null))
                {
                    cadena += Producto.MostrarProducto(e.productos[i]);
                }
                    
            }

            if(!Object.ReferenceEquals(cadena, ""))
            {
                cadena = cadena + mensaje;
            }
            
            return cadena;
        }


        public static bool operator ==(Estante e, Producto p)
        {
            bool valor = false;
            int i;
            string marcaProducto;
            string marcaEstante;

            marcaProducto = p.GetMarca();

            for(i = 0; i < e.productos.Length; i++)
            {
                if(!Object.ReferenceEquals(e.productos[i], null))
                {
                    marcaEstante = e.productos[i].GetMarca();

                    if (marcaProducto == marcaEstante)
                    {
                        valor = true;
                        break;
                    }
                }

            }

            return valor;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            bool valor = false;
            int i;
            string marcaProducto;
            string marcaEstante;

            marcaProducto = p.GetMarca();

            for (i = 0; i < e.productos.Length; i++)
            {
                if (Object.ReferenceEquals(e.productos[i], null))
                {
                    marcaEstante = e.productos[i].GetMarca();

                    if (marcaProducto != marcaEstante)
                    {
                        valor = true;
                        break;
                    }
                }
            }

            return valor;
        }


        public static bool operator +(Estante e, Producto p)
        {
            bool valor = false;
            int i;

            if(!(e == p))
            {
                for(i = 0; i < e.productos.Length; i++)
                {

                    if(Object.ReferenceEquals(e.productos[i], null))
                    {
                        valor = true;
                        e.productos[i] = p;
                        break;
                    }
                  
                }
            }

            return valor;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            
            int i;

            if (e == p)
            {
                for (i = 0; i < e.productos.Length; i++)
                {

                    if (Object.ReferenceEquals(e.productos[i], p))
                    {
                        e.productos[i] = null;

                        break;
                    }

                }
            }

            return e;
        }
    }
}
