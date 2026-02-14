using System;
using System.Data;
using System.Windows.Forms;
using controlUsuarioPrestamos;
using ProyectoBiblioteca.Controlador;

namespace ProyectoBiblioteca.Vista
{
    public partial class FormularioPrestamo : Form
    {

        public controlador controladorPrestamo { get; set; }

        public FormularioPrestamo()
        {
            InitializeComponent();
        }





        public void Cargar(DataTable datos)
        {
            tlpPrestamo.Controls.Clear();
            tlpPrestamo.RowStyles.Clear();
            tlpPrestamo.RowCount = 0;

            tlpPrestamo.AutoScroll = true;

            int nuevaFila = 0;

            foreach (DataRow row in datos.Rows)
            {
                UserControl1 control = new UserControl1();

                control.Id = (int)row.Field<long>("id");
          
                control.Nombre = row.Field<string>("Nombre");
                control.libro = row.Field<string>("Titulo");


                control.devolucion += Control_devolucion;


                control.Dock = DockStyle.Top;

                tlpPrestamo.RowCount++;
                tlpPrestamo.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                tlpPrestamo.Controls.Add(control, 0, nuevaFila);


                nuevaFila++;
            }
            tlpPrestamo.Padding = new Padding(6);
        }

        private void Control_devolucion(object sender, UserControl1.ClickarBotonSeleccionarEventArgs e)

        {
            controladorPrestamo.EliminarPrestamo(e.Id);
         MessageBox.Show($"Prestamo eliminado correctamente{e.Id}");
            Cargar(controladorPrestamo.CargarDatosPrestamos());
        }

        


        private void FormularioPrestamo_Load_1(object sender, EventArgs e)
        {
            DataTable dtLibrosDisponibles = controladorPrestamo.CargarDatosLibrosDisponibles();
            DataTable dtUsuarios = controladorPrestamo.CargarDatosUsuarioNomYApes();
            Cargar(controladorPrestamo.CargarDatosPrestamos());


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

            cbLibro.DataSource = dtLibrosDisponibles;
        
            cbLibro.DisplayMember = "Titulo";
      
            cbLibro.ValueMember = "ID";
            cbLibro.SelectedIndex = -1;

            cbbUsuario.DataSource = dtUsuarios;
           
            cbbUsuario.DisplayMember = "Nombre_completo";   // lo que se ve
            cbbUsuario.ValueMember = "ID";  // lo que se guarda
            cbbUsuario.SelectedIndex = -1;


        }


        private void btAgregarPrestamo_Click(object sender, EventArgs e)
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

            MessageBox.Show("Libro seleccionado: " + cbLibro.SelectedValue);
      
            int idLibro = Convert.ToInt32(cbLibro.SelectedValue);
           

   
            int idUsuario = Convert.ToInt32(cbbUsuario.SelectedValue);

            /*// Obtener valores visibles
            string tituloLibro = libroSeleccionado["Titulo"].ToString();
            string nombreUsuario = usuarioSeleccionado["Nombre_completo"].ToString();*/
        
            

            try
            { if (cbbUsuario.SelectedValue != null && cbLibro.SelectedValue !=null) {
                    controladorPrestamo.InsertarPrestamos(idLibro, idUsuario, fechaInicio, fechaFin);
                    throw new Exception($" {cbbUsuario.DisplayMember.ToString()} Se ha creado un prestamos correctamente" );
                  
                }
                else
                {
                    throw new Exception(" ERROR ,Debes seleccionar tanto libro como usuario");
                }

            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

  
    }
}
