using ProyectoBiblioteca.Controlador;
using ProyectoBiblioteca.Modelo.Libro;
using ProyectoBiblioteca.Vista;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoBiblioteca
{
    public partial class FormularioLibros : Form
    {
        public controlador controladorLibro { get; set; } //creamos los metos get y set para poder acceder a sus propiedades desde el formularioPricipal(Inicio)
                                                          //permite que el formulario Pricipal(Inicio) le pase el controlador , no creamos otro controlador trabajamos con uno solo
        public FormularioLibros()
        {
            InitializeComponent();
        }

        private void FormularioLibros_Load(object sender, EventArgs e)
        {
     
        }

        private void smiInsertar_Click(object sender, EventArgs e)
        {
            this.Close();//Cerramos el formulario y al ser secundario se mostrara el principal ( formularioInicio)

        }


        public void Cargar(DataTable datos)
        {
            tableLayoutPanelLibros.Controls.Clear();
            tableLayoutPanelLibros.RowStyles.Clear();
            tableLayoutPanelLibros.RowCount = 0;

          tableLayoutPanelLibros.AutoScroll = true;


            int nuevaFila = 0;

            foreach (DataRow row in datos.Rows)
            {
                ControlUsuarioProyecto.ControlUsuario control = new ControlUsuarioProyecto.ControlUsuario();
                control.tipo = ControlUsuarioProyecto.ControlUsuario.TipoEntidad.Libro; //importante hay que elegir el tipo de entidad.
                control.Id = (int)row.Field<long>("id");
                control.Nombre = row.Field<string>("Titulo");
                control.Apellido = row.Field<string>("Escritor");
                control.Eliminar += Control_Eliminar;
                control.Editar += Control_Editar; 
                control.Dock = DockStyle.Top;
                control.Dock = DockStyle.Top;

                tableLayoutPanelLibros.RowCount++;
                tableLayoutPanelLibros.RowStyles.Add(new RowStyle(SizeType.AutoSize));

              tableLayoutPanelLibros.Controls.Add(control, 0, nuevaFila);

                nuevaFila++;
            }
            tableLayoutPanelLibros.Padding = new Padding(6);
        }

        private void Control_Editar(object sender, ControlUsuarioProyecto.ControlUsuario.ClickarBotonSeleccionarEventArgs e)
        {
            int sacarID = e.Id;
            MessageBox.Show($"{sacarID}");

            

            formularioEditarLibro form = new formularioEditarLibro();
            form.controladorEditarLibro = this.controladorLibro;

            form.lEidLibro.Text = controladorLibro.MuestraLib(sacarID).Id.ToString();
            form.tbTitulo.Text = controladorLibro.MuestraLib(sacarID).Titulo.ToString();
            form.tbEscritor.Text = controladorLibro.MuestraLib(sacarID).Escritor.ToString();
            form.tbAno_edicion.Text = controladorLibro.MuestraLib(sacarID).Ano_Edicion.ToString();
            form.tbSinop.Text = controladorLibro.MuestraLib(sacarID).Sinopsis.ToString();
            form.chbDisponible.Checked = Convert.ToBoolean(controladorLibro.MuestraLib(sacarID).Disponible);

            this.Hide();
            form.ShowDialog();
            this.Show();

            Cargar(controladorLibro.CargarDatosLibro());
        }

        private void Control_Eliminar(object sender, ControlUsuarioProyecto.ControlUsuario.ClickarBotonSeleccionarEventArgs e)
        {
            controladorLibro.eliminarLibro(e.Id);
            Cargar(controladorLibro.CargarDatosLibro());
            MessageBox.Show("libro eliminado correctamente");

        }

    


   

        private void btAgregar_Click(object sender, EventArgs e)
        {

            formularioAgregarLibro form = new formularioAgregarLibro();
            form.controladorAgregarLib = this.controladorLibro;
            this.Hide();
            form.ShowDialog();
            this.Show();
            Cargar(controladorLibro.CargarDatosLibro());
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = txbBuscarLibro.Text;

                if (string.IsNullOrEmpty(texto))
                {
                    Cargar(controladorLibro.CargarDatosLibro());
                }
                else
                {
                    var resultado = controladorLibro.FiltrarLibros(texto);

                    if (resultado.Rows.Count > 0)
                    {
                        Cargar(controladorLibro.FiltrarLibros(texto));

                    }
                    else
                    {
                        MessageBox.Show("No se encontraron libros con el criterio de busqueda", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
