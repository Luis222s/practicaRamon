using System;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CapaNegocio
{
    public class CN_Producto
    {
        private CD_Producto objetoCD = new CD_Producto();

        public DataTable MostrarProducto()
        {
            DataTable Tabla = new DataTable();
            Tabla = objetoCD.Mostrar();
            return Tabla;
        }
        /*public void InsertarProd(string Nombre, int Precio, string TipoProducto, double Peso, int Stock, string Licencia, double TamanoMB)
        {
            objetoCD.Insertar(Nombre, Precio, TipoProducto, Peso, Stock, Licencia, TamanoMB);
        }*/
        public void InsertarProd(string Nombre, string Precio, string TipoProducto, string Peso, string Stock, string Licencia, string TamanoMB)
        {
            // Conversión segura por si los valores quedan vacio
            int precio = 0;
            double peso = 0;
            int stock = 0;
            double tamanoMB = 0;

            int.TryParse(Precio, out precio);
            double.TryParse(Peso, out peso);
            int.TryParse(Stock, out stock);
            double.TryParse(TamanoMB, out tamanoMB);

            objetoCD.Insertar(Nombre, precio, TipoProducto, peso, stock, Licencia, tamanoMB);
        }
        public void EditarProd(string Nombre, string Precio, string TipoProducto, string Licencia, string Peso, string Stock, string TamanoMB, string Id)
        {
            objetoCD.Editar(Nombre, Convert.ToInt32(Precio), TipoProducto, Licencia, Convert.ToDouble(Peso), Convert.ToInt32(Stock), Convert.ToDouble(TamanoMB), Id);
        }
        public void EliminarProd(string Id)
        {
            objetoCD.Eliminar(Id);
        }
    }
}
