using ProyectoBiblioteca.Controlador;
using ProyectoBiblioteca.Modelo;
using ProyectoBiblioteca.Modelo.Libro;
using ProyectoBiblioteca.Modelo.Prestamos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBiblioteca.Vista
{
    public partial class FormularioPrestamo : Form
    {

        public controlador controladorPrestamo { get; set; }

        public FormularioPrestamo()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string fechaInicio = dtpInicio.Value.ToString("dd/MM/yyyy");
            string fechaFin = dtpFin.Value.ToString("dd/MM/yyyy");

            /*DataRowView libroSeleccionado = cbbInicio.SelectedItem as DataRowView;
            DataRowView usuarioSeleccionado = cbbUsuario.SelectedItem as DataRowView;

            if (libroSeleccionado == null || usuarioSeleccionado == null)
            {
                MessageBox.Show("Selecciona un usuario y un libro antes de continuar.");
                return;
            }*/

            // IDs convertidos correctamente
            int idLibro = Convert.ToInt32(cbbInicio.SelectedValue);
            int idUsuario = Convert.ToInt32(cbbUsuario.SelectedValue);

            /*// Obtener valores visibles
            string tituloLibro = libroSeleccionado["Titulo"].ToString();
            string nombreUsuario = usuarioSeleccionado["Nombre_completo"].ToString();*/

            try
            {
                controladorPrestamo.InsertarPrestamos(idLibro, idUsuario, fechaInicio, fechaFin);
                MessageBox.Show("Se ha creado un prestamos correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void label2_Click(object sender, EventArgs e)
        {
            
        }

       

        private void FormularioPrestamo_Load_1(object sender, EventArgs e)
        {
            DataTable dt = controladorPrestamo.CargarDatosLibrosDisponibles();
            DataTable dUsu = controladorPrestamo.CargarDatosUsuarioNomYApes();


            //COMPLETAMENTE VALIDO PERO MEJOR DEL OTRO MODO HABLADO EN CLASE
            /*cbbInicio.Items.Clear();
            cbbUsuario.Items.Clear();

            foreach (DataRow fila in dt.Rows)
            {
                cbbInicio.Items.Add(fila["Titulo"].ToString());
            }*/

            /*foreach (DataRow fila in dUsu.Rows)
            {
                cbbUsuario.Items.Add(
                    fila["Nombre"].ToString() +
                    " " +
                    fila["Apellido_1"].ToString() + 
                    " " +
                    fila["Apellido_2"].ToString() 
                    );
                
            }*/

            cbbInicio.DataSource = dt;
            cbbInicio.DisplayMember = "Titulo";
            cbbInicio.ValueMember = "ID";
            cbbInicio.SelectedIndex = -1;

            cbbUsuario.DataSource = dUsu;

            cbbUsuario.DisplayMember = "Nombre_completo";   // lo que se ve
            cbbUsuario.ValueMember = "ID";  // lo que se guarda
            cbbUsuario.SelectedIndex = -1;


        }
    }
}
