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
        private string ruta = Properties.Settings.Default.conexion;

        public DataTable librosDisponibles()
        {

            DataTable dataTable = new DataTable();
            SQLiteCommand cmd;
            {
                string sql = "SELECT * FROM Libros WHERE Disponible = 1)";
                cmd = new SQLiteCommand(sql);
                dataTable = Conexion.GetDataTable(Properties.Settings.Default.conexion, cmd);

            }
            return dataTable;
        }

        public void  agregarPrestamos (int idLibro , int idUsuario , string fecha_Inicio ,string fecha_Fin)
        {

        }
    }
}