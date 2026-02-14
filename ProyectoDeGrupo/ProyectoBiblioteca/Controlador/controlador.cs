using System;
using System.Data;
using System.Linq;
using ProyectoBiblioteca.Modelo;
using ProyectoBiblioteca.Modelo.Libro;
using ProyectoBiblioteca.Modelo.Prestamos;


namespace ProyectoBiblioteca.Controlador
{
    public class controlador
    {
        private ListaUsuarios listaUsuarios = new ListaUsuarios();
        private ListaLibros listaLibros = new ListaLibros();
        private ListaPrestamo listaPrestamos = new ListaPrestamo();

        public void InsertarUsuario(string nombre, string Apellido1, string Apellido2, int telefono)
        {
            string telefonoTexto = telefono.ToString();

            if (nombre.Trim().Length == 0)
                throw new Exception(" el nombre no puede estar vacio");

            if (Apellido1.Trim().Length == 0)
                throw new Exception("Falta el primer Apellido");

            if (telefonoTexto.Length < 9)
                throw new Exception("formato de telefono no valido");

            listaUsuarios.Agregar(nombre, Apellido1, Apellido2, telefono);
        }

        public bool eleminarUsuario(int id)
        {
            listaUsuarios.eliminarUsuario(id);

            return true;
        }


        public DataTable CargarDatosLibrosDisponibles()
        {
            return listaPrestamos.librosDisponibles();
        }

        public DataTable CargarDatosUsuario()
        {
            return listaUsuarios.CargarTodo();
        }

        public DataTable CargarDatosUsuarioNomYApes()
        {
            return listaUsuarios.CargarNombreYApellidos();
        }
        public DataTable MuestraUsu(int id)
        {
            DataTable datos = new DataTable();
            datos = listaUsuarios.SacarUsuarioConID(id);


            return datos;
        }


        public void EditarUsuario(int id, string nombre, string Apellido1, string Apellido2, int telefono)
        {


            string telefonoTexto = telefono.ToString();

            if (nombre.Trim().Length == 0)
                throw new Exception(" el nombre no puede estar vacio");

            if (Apellido1.Trim().Length == 0)
                throw new Exception("Falta el primer Apellido");
         

            if (telefonoTexto.Length == 9 && telefonoTexto.All(char.IsDigit))
            {
                int telefonoNumero = int.Parse(telefonoTexto);
                throw new Exception("Teléfono válido");
            }
            else
            {
                throw new Exception("Teléfono no válido");
            }

            if (telefonoTexto.Length < 9)
                throw new Exception("formato de telefono no valido");




            listaUsuarios.EditUsuario(id, nombre, Apellido1, Apellido2, telefono);

        }


        //filtrar usuario
        public DataTable FiltrarUsuarios(string texto)

        {
            int id;
            bool esId = int.TryParse(texto, out id);


            if (esId)
                return listaUsuarios.filtrarUsuarios("", id);
            else
                return listaUsuarios.filtrarUsuarios(texto, 0);

        }


        // filtrar libros
        public DataTable FiltrarLibros(string texto)

        {
            int id;
            bool esId = int.TryParse(texto, out id);


            if (esId)
                return listaLibros.filtrarLibroPorID("", id);
            else
                return listaLibros.filtrarLibroPorID(texto, 0);

        }



        // Muestra el Libro

        public Libro MuestraLib(int id)

        {
            var libros = listaLibros.SacarLibroConID(id).FirstOrDefault();

            if (libros == null)
                throw new Exception("No se encontraron usuarios con esos criterios");


            return libros;

        }


        public bool eliminarLibro(int id)
        {
            listaLibros.EliminarLibro(id);

            return true;
        }
        public DataTable CargarDatosLibro()
        {
            return listaLibros.CargarTodo();
        }

        public void InsertarLibro(string titulo, string escritor, int ano_edicion, string sinopsis, int disponible)
        {
            string anoTexto = ano_edicion.ToString();
            if (titulo.Trim().Length == 0)
                throw new Exception("Falta el titulo" + Environment.NewLine);
            if (escritor.Trim().Length == 0)
                throw new Exception("Falta el escritor" + Environment.NewLine);
            if (anoTexto.Length < 4)
                throw new Exception(" ERROR Año debe ser: 0000 , Formato introducido no valido " + Environment.NewLine);
            if (anoTexto.Trim().Length == 0)
                throw new Exception("Falta el año de edicion " + Environment.NewLine);

            listaLibros.AgregarLibros(titulo, escritor, ano_edicion, sinopsis, disponible);
        }


        public void EditLibro(int id, string titulo, string escritor, int ano_edicion, string sinopsis, int disponible)
        {
            string anoTexto = ano_edicion.ToString();

            if (titulo.Trim().Length == 0)
                throw new Exception("Falta el titulo" + Environment.NewLine);
            if (escritor.Trim().Length == 0)
                throw new Exception("Falta el escritor" + Environment.NewLine);
            if (anoTexto.Length < 4)
                throw new Exception(" ERROR Año debe ser: 0000 , Formato introducido no valido " + Environment.NewLine);
            if (anoTexto.Trim().Length == 0)
                throw new Exception("Falta el año de edicion " + Environment.NewLine);

            listaLibros.EditarLibro(id, titulo, escritor, ano_edicion, sinopsis, disponible);
        }




        // CONTROLADOR PRESTAMO 

        public void EliminarPrestamo(int idPrestamo, int idLibro)
        {
            if (idPrestamo <= 0)
                throw new Exception("Falta seleccionar un prestamo " + Environment.NewLine);
            if (idLibro <= 0)
                throw new Exception("Falta seleccionar un libro " + Environment.NewLine);

            listaPrestamos.EliminarPrestamo(idPrestamo, idLibro);
        }

        public void InsertarPrestamos(int idLibro, int idUsuario, string fecha_Inicio, string fecha_Fin)
        {
            DateTime dtInicio, dtFin;

            if (!DateTime.TryParse(fecha_Inicio, out dtInicio))
                throw new Exception("la fecha de inicio no es valido");

            if (!DateTime.TryParse(fecha_Fin, out dtFin))
                throw new Exception("la fecha del final no es valido");

            if (dtFin < dtInicio)
                throw new Exception("La fecha final no puede ser anterior a la inicial");

            if (idLibro < 0)
                throw new Exception("Falta seleccionar un libro " + Environment.NewLine);
            if (idUsuario < 0)
                throw new Exception("Falta seleccionar un usuario " + Environment.NewLine);

            listaPrestamos.AgregarPrestamos(idLibro, idUsuario, fecha_Inicio, fecha_Fin);
        }

        public DataTable CargarDatosPrestamos()
        {
            return listaPrestamos.tablaPrestamos();
        }
    }
}
