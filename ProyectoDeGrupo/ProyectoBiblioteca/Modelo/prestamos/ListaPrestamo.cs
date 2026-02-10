using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Modelo.Prestamos
{
    internal class ListaPrestamo
    {
        private string ruta = Properties.Settings.Default.Conexion;

        public DataTable librosDisponibles()
        {

            DataTable dataTable = new DataTable();
            SQLiteCommand cmd;
            {
                string sql = "SELECT Titulo, ID FROM Libros WHERE Disponible = 1";
                cmd = new SQLiteCommand(sql);
                dataTable = Conexion.GetDataTable(Properties.Settings.Default.Conexion, cmd);

            }
            return dataTable;
        }

        public void  AgregarPrestamos (int idLibro , int idUsuario , string fecha_Inicio ,string fecha_Fin)
        {
            string sql = "INSERT INTO Prestamos (ID_Libro,ID_Usuario,Fecha_Inicio,Fecha_fin) VALUES ( @idLibro, @idUsuario,@fecha_Inicio,@fecha_Fin)";
            SQLiteCommand cmd = new SQLiteCommand(sql);


            cmd.Parameters.AddWithValue("@idLibro", idLibro);
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
            cmd.Parameters.AddWithValue("@fecha_Inicio", fecha_Inicio);
            cmd.Parameters.AddWithValue("@fecha_Fin", fecha_Fin);


            Conexion.Ejecuta(ruta, cmd);
        }
    }
}