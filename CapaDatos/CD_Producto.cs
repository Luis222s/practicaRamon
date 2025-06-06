using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections;

namespace CapaDatos
{
    public class CD_Producto
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader Leer;
        DataTable Tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            Leer = comando.ExecuteReader();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }
        public void Insertar(string Nombre, int Precio, string TipoProducto, double Peso, int Stock, string Licencia, double TamanoMB)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarProductos";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Precio", Precio);
            comando.Parameters.AddWithValue("@TipoProducto", TipoProducto);
            comando.Parameters.AddWithValue("@Peso", Peso);
            comando.Parameters.AddWithValue("@Stock", Stock);
            comando.Parameters.AddWithValue("@Licencia", Licencia);
            comando.Parameters.AddWithValue("@TamanoMB", TamanoMB);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Editar(string Nombre, int Precio, string TipoProducto, string Licencia, double Peso, int Stock, double TamanoMB, string Id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarProductos";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Precio", Precio);
            comando.Parameters.AddWithValue("@TipoProducto", TipoProducto);
            comando.Parameters.AddWithValue("@Licencia", Licencia);
            comando.Parameters.AddWithValue("@Peso", Peso);
            comando.Parameters.AddWithValue("@Stock", Stock);
            comando.Parameters.AddWithValue("@TamanoMB", TamanoMB);
            comando.Parameters.AddWithValue("@Id", Id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Eliminar(string Id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarProducto";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdF", Id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

    }
}
