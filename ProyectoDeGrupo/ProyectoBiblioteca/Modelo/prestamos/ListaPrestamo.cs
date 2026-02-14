using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

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

        public DataTable tablaPrestamos()
        {

            DataTable dataTable = new DataTable();
            SQLiteCommand cmd;
            {
                string sql = "select p.ID, l.Titulo, u.Nombre from  Prestamos p,Libros l, Usuarios u where p.ID_Libro = l.ID and p.ID_Usuario=u.ID";
                cmd = new SQLiteCommand(sql);
                dataTable = Conexion.GetDataTable(Properties.Settings.Default.Conexion, cmd);

            }
            return dataTable;
        }


        public void AgregarPrestamos(int idLibro, int idUsuario, string fecha_Inicio, string fecha_Fin)
        {
            string sql = "INSERT INTO Prestamos (ID_Libro,ID_Usuario,Fecha_Inicio,Fecha_fin) VALUES ( @idLibro, @idUsuario,@fecha_Inicio,@fecha_Fin)";
            SQLiteCommand cmd = new SQLiteCommand(sql);


            cmd.Parameters.AddWithValue("@idLibro", idLibro);
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
            cmd.Parameters.AddWithValue("@fecha_Inicio", fecha_Inicio);
            cmd.Parameters.AddWithValue("@fecha_Fin", fecha_Fin);


            Conexion.Ejecuta(ruta, cmd);


            sql = "UPDATE Libros SET Disponible = 0 WHERE ID = @idLibro";
            cmd = new SQLiteCommand(sql);
            cmd.Parameters.AddWithValue("@idLibro", idLibro);
            Conexion.Ejecuta(ruta, cmd);


        }


        public void EliminarPrestamo(int idPrestamo)
        {
            int idLibro = 0;

            string sql = "SELECT ID_Libro FROM Prestamos WHERE ID = @idPrestamo";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            cmd.Parameters.AddWithValue("@idPrestamo", idPrestamo);

            using (SQLiteDataReader reader = Conexion.GetDataReader(ruta, cmd))
            {
                if (reader.Read())
                {
                    idLibro = Convert.ToInt32(reader["ID_Libro"]);
                }
                else
                {
                    MessageBox.Show("No existe ese préstamo");
                    return;
                }
            }

            sql = "DELETE FROM Prestamos WHERE ID = @idPrestamo";
            cmd = new SQLiteCommand(sql);
            cmd.Parameters.AddWithValue("@idPrestamo", idPrestamo);
            Conexion.Ejecuta(ruta, cmd);

            sql = "UPDATE Libros SET Disponible = 1 WHERE ID = @idLibro";
            cmd = new SQLiteCommand(sql);
            cmd.Parameters.AddWithValue("@idLibro", idLibro);
            Conexion.Ejecuta(ruta, cmd);

        }




    }
}