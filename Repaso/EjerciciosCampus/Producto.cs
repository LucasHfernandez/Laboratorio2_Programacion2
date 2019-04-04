using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCampus
{
    public class Producto
    {
        private string codigoDeBarras;
        private string marca;
        private float precio;

        public Producto(string marca, string codigoDeBarras, float precio)
        {
            this.marca = marca;
            this.codigoDeBarras = codigoDeBarras;
            this.precio = precio;
        }

        public string GetMarca()
        {
            string marcaProducto;

            marcaProducto = this.marca;

            return marcaProducto;
        }

        public float GetPrecio()
        {
            float precioProducto;

            precioProducto = this.precio;

            return precioProducto;
        }

        public static string MostrarProducto(Producto p)
        {
            string cadena = "";

            cadena = "El producto es: " + p.marca + "\nEl precio es: " + p.precio + "Codigo de barra: " + p.codigoDeBarras;

            return cadena;
        }

        public static explicit operator string (Producto p)
        {
            return p.codigoDeBarras;
        }

        public static bool operator == (Producto p1, Producto p2)
        {
            bool valor = false;
            if(p1.marca == p2.marca && p1.codigoDeBarras == p2.codigoDeBarras)
            {
                valor = true;
            }

            //return !(p1 == p2);
            return valor;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            bool valor = false;
            if (p1.marca != p2.marca || p1.codigoDeBarras != p2.codigoDeBarras)
            {
                valor = true;
            }

            return valor;
        }

        public static bool operator ==(Producto p1, string cadena)
        {
            bool valor = false;
            if (p1.marca == cadena)
            {
                valor = true;
            }

            return valor;
        }

        public static bool operator !=(Producto p1, string cadena)
        {
            bool valor = false;
            if (p1.marca != cadena)
            {
                valor = true;
            }

            return valor;
        }

    }
}
