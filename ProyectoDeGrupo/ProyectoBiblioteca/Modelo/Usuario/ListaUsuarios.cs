using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using ProyectoBiblioteca.Controlador; 

namespace ProyectoBiblioteca.Modelo
{
    internal class ListaUsuarios
    {
        private string ruta = Properties.Settings.Default.Conexion;

        public void Agregar(string nombre, string Apellido1, string Apellido2, int telefono)
        {
            string sql = "INSERT INTO Usuarios (Nombre,Apellido_1,Apellido_2,Telefono) VALUES (@nombre, @Apellido1,@Apellido2,@telefono)";
            SQLiteCommand cmd = new SQLiteCommand(sql);

            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@Apellido1", Apellido1);
            cmd.Parameters.AddWithValue("@Apellido2", Apellido2);
            cmd.Parameters.AddWithValue("@telefono", telefono);


            Conexion.Ejecuta(ruta, cmd);


        }


     


        // filtrar Usuarios
        public DataTable filtrarUsuarios(string texto, int id)
        {
            DataTable datos = new DataTable();
            SQLiteCommand cmd;
            {
                if (id > 0)
                {
                    string sql = @"SELECT ID, Nombre, Apellido_1, Apellido_2, Telefono FROM Usuarios WHERE ID = @id";
                    cmd = new SQLiteCommand(sql);
                    cmd.Parameters.AddWithValue("@id", id);
                }
                else
                {
                    string sql = @"SELECT ID, Nombre, Apellido_1, Apellido_2, Telefono FROM Usuarios WHERE Nombre LIKE @texto OR Apellido_1 LIKE @texto OR Apellido_2 LIKE @texto";
                    cmd = new SQLiteCommand(sql);
                    cmd.Parameters.AddWithValue("@texto", "%" + texto + "%"); // para que sirven los %% no lo veo
                }

                datos = Conexion.GetDataTable(ruta, cmd);
            }
            
            return datos;
           
        }


        public DataTable SacarUsuarioConID(int id)
        {
            DataTable resultado = new DataTable();
            SQLiteCommand cmd;
            {

                string sql = @"SELECT ID, Nombre, Apellido_1, Apellido_2, Telefono FROM Usuarios WHERE ID = @id";
                cmd = new SQLiteCommand(sql);
                cmd.Parameters.AddWithValue("@id", id);

                resultado = Conexion.GetDataTable(ruta, cmd);
            }
            return resultado;
        }

        public void eliminarUsuario(int id)
        {
            string sql = $"DELETE FROM Usuarios WHERE ID={id}";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            // Conexion.Ejecuta(Properties.Settings.Default.conexion, cmd);
            Conexion.Ejecuta(ruta, cmd);
        }

        public DataTable CargarTodo()
        {
            DataTable datos = new DataTable();
            string sql = "SELECT * FROM Usuarios";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            datos = Conexion.GetDataTable(Properties.Settings.Default.Conexion, cmd);
            return datos;
        }

        public DataTable CargarNombreYApellidos()
        {
            DataTable datos = new DataTable();
            string sql = "SELECT ID, Nombre || ' ' || Apellido_1 || ' ' || Apellido_2 as Nombre_completo FROM Usuarios";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            datos = Conexion.GetDataTable(Properties.Settings.Default.Conexion, cmd);
            return datos;
        }


        public void EditUsuario(int id, string nombre, string Apellido1, string Apellido2, int telefono)
        {
            string sql = "UPDATE Usuarios SET Nombre=@nom, Apellido_1=@ape1, Apellido_2=@ape2, Telefono=@tel WHERE Id=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql);

            cmd.Parameters.Add("@id", DbType.Int32).Value = id;
            cmd.Parameters.Add("@nom", DbType.String).Value = nombre;
            cmd.Parameters.Add("@ape1", DbType.String).Value = Apellido1;
            cmd.Parameters.Add("@ape2", DbType.String).Value = Apellido2;
            cmd.Parameters.Add("@tel", DbType.Int32).Value = telefono;

            Conexion.Ejecuta(ruta, cmd);
            

        }




    }
}
