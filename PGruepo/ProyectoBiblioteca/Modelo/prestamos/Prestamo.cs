using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Modelo.Prestamos
{
    internal class Prestamo
    {
        public Prestamo(int id, int id_usu, int id_libro, string prestamo_inicio, string prestamo_fin) 
        {
            Id = id;
            Id_Usu = id_usu;
            Id_Libro = id_libro;
            Prestamo_Inicio = prestamo_inicio;
            Prestamo_Fin = prestamo_fin;
        }

        public int Id { get; set; }
        public int Id_Usu { get; set; }
        public int Id_Libro { get; set; }
        public string Prestamo_Inicio { get; set; }
        public string Prestamo_Fin { get; set; }
    }
}
