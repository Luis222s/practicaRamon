using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public abstract class Producto
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }

        public Producto(string nombre, int precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public abstract double CalcularPrecioFinal();
    }

    public class ProductoFisico : Producto
    {
        public double Peso { get; set; }
        public int Stock { get; set; }

        public ProductoFisico(string nombre, int precio, double peso, int stock)
            : base(nombre, precio)
        {
            Peso = peso;
            Stock = stock;
        }

        public override double CalcularPrecioFinal()
        {
            // Precio + costo de envío basado en peso (2 por kilo)
            return Precio + (Peso * 2);
        }
    }
    public class ProductoDigital : Producto
    {
        public string Licencia { get; set; }
        public double TamanoMB { get; set; }

        public ProductoDigital(string nombre, int precio, string licencia, double tamanoMB)
            : base(nombre, precio)
        {
            Licencia = licencia;
            TamanoMB = tamanoMB;
        }

        public override double CalcularPrecioFinal()
        {
            // Ejemplo: Precio + costo por almacenamiento digital (2 por MB)
            return Precio + (TamanoMB * 2);
        }
    }
}
