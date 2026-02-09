using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Modelo.Prestamos
{
    internal class Prestamo
    {

        public int Id { get; set; }
        public int Id_Usu { get; set; }
        public int Id_Libro { get; set; }
        public string fecha_Inicio { get; set; }
        public string fecha_Fin { get; set; }
        public Prestamo(int id, int id_usu, int id_libro, string fecha_inicio,string fecha_fin) 
        {
            Id = id;
            Id_Usu = id_usu;
            Id_Libro = id_libro;
            fecha_Inicio = fecha_inicio;
            fecha_Fin = fecha_fin;
        }

    }
}
