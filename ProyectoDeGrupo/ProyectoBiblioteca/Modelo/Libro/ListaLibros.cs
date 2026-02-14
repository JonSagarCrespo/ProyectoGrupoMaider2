using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace ProyectoBiblioteca.Modelo.Libro
{
    internal class ListaLibros
    {

        private string ruta = Properties.Settings.Default.Conexion;



        public void AgregarLibros(string Titulo, string Escritor, int Ano_edicion, string Sinopsis, int Disponible)
        {
            SQLiteCommand cmd = new SQLiteCommand(@"INSERT INTO Libros (Titulo, Escritor, Ano_edicion, Sinopsis, Disponible)
                                                    VALUES (@Titulo, @Escritor, @Ano_Edicion, @Sinopsis, @Disponible)");
            cmd.Parameters.AddWithValue("@Titulo", Titulo);
            cmd.Parameters.AddWithValue("@Escritor", Escritor);
            cmd.Parameters.AddWithValue("@Ano_Edicion", Ano_edicion);
            cmd.Parameters.AddWithValue("@Sinopsis", Sinopsis);
            cmd.Parameters.AddWithValue("@Disponible", Disponible);
            // Conexion.Ejecuta(ruta, cmd);

            Conexion.Ejecuta(ruta, cmd);

        }

        public List<Libro> SacarLibroConID(int id)
        {

            List<Libro> Resultadolibros = new List<Libro>();
            SQLiteCommand cmd;

            cmd = new SQLiteCommand("SELECT * FROM Libros WHERE ID = @id ");
            cmd.Parameters.AddWithValue("@id", id);

            using (SQLiteDataReader reader = Conexion.GetDataReader(ruta, cmd))
            {
                while (reader.Read())
                {
                    Resultadolibros.Add(new Libro(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetInt32(3),
                        reader.GetString(4),
                        reader.GetInt32(5)));
                }

            }
            return Resultadolibros;


        }

        // filtrar Libros
        public DataTable filtrarLibroPorID(string texto, int id)
        {
            DataTable datos = new DataTable();
            SQLiteCommand cmd;
            {
                if (id > 0)
                {
                    cmd = new SQLiteCommand("SELECT * FROM Libros WHERE ID = @id ");
                    cmd.Parameters.AddWithValue("@id", id);
                }
                else
                {
                    cmd = new SQLiteCommand("SELECT * FROM Libros WHERE Titulo LIKE @Titulo OR Escritor LIKE @Escritor");
                    cmd.Parameters.AddWithValue("@Titulo", texto);
                    cmd.Parameters.AddWithValue("@Escritor", texto);
                }
                datos = Conexion.GetDataTable(ruta, cmd);
            }


            return datos;

        }



        public List<Libro> obtenerLibros()
        {
            List<Libro> resultadoLibros = new List<Libro>();
            SQLiteCommand cmd;
            string sql = "SELECT * FROM Libros";
            cmd = new SQLiteCommand(sql);
            using (SQLiteDataReader dr = Conexion.GetDataReader(ruta, cmd))
            {
                while (dr.Read())
                {
                    resultadoLibros.Add(new Libro
                        (dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetInt32(3),
                        dr.GetString(4),
                        dr.GetInt32(5)
                        ));

                }

            }
            return resultadoLibros;

        }
        public void EliminarLibro(int id)
        {
            string sql = $"DELETE FROM Libros WHERE ID={id}";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            // Conexion.Ejecuta(Properties.Settings.Default.conexion, cmd);
            Conexion.Ejecuta(ruta, cmd);
        }
        public DataTable CargarTodo()
        {
            DataTable datos = new DataTable();
            string sql = "SELECT * FROM Libros";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            datos = Conexion.GetDataTable(ruta, cmd);
            return datos;
        }



        public void EditarLibro(int id, string titulo, string escritor, int ano_edicion, string sinopsis, int disponible)
        {
            string sql = "UPDATE Libros SET Titulo=@titulo, Escritor=@escritor, Ano_Edicion=@ano_edicion, Sinopsis=@sinopsis, Disponible=@disponible WHERE ID=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql);

            cmd.Parameters.Add("@id", DbType.Int32).Value = id;
            cmd.Parameters.Add("@titulo", DbType.String).Value = titulo;
            cmd.Parameters.Add("@escritor", DbType.String).Value = escritor;
            cmd.Parameters.Add("@ano_edicion", DbType.Int32).Value = ano_edicion;
            cmd.Parameters.Add("@ano_edicion", DbType.String).Value = ano_edicion;
            cmd.Parameters.Add("@sinopsis", DbType.String).Value = sinopsis;
            cmd.Parameters.Add("@disponible", DbType.Int32).Value = disponible;



            Conexion.Ejecuta(ruta, cmd);


        }

    }

}

