using ProyectoBiblioteca.Controlador;
using ProyectoBiblioteca.Modelo;
using ProyectoBiblioteca.Vista;
using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProyectoBiblioteca
{
    public partial class FormularioUsuario : Form
    {
        public controlador controladorUsuario { get; set; }

        public FormularioUsuario()
        {

            InitializeComponent();
           
        }


        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = txbBuscarUsuario.Text;

                if (string.IsNullOrEmpty(texto))
                {
                    if (controladorUsuario.CargarDatosUsuario().Rows.Count > 0)
                    {
                        Cargar(controladorUsuario.CargarDatosUsuario());
                    }
                    else
                    {
                        MessageBox.Show("No hay usuarios registrados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    var resultado = controladorUsuario.FiltrarUsuarios(texto);

                    if (resultado.Rows.Count > 0)
                    {
                        Cargar(controladorUsuario.FiltrarUsuarios(texto));
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron usuarios con el criterio de busqueda", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void Cargar(DataTable datos)
        {
            panelUsuarios.Controls.Clear();
            panelUsuarios.RowStyles.Clear();
            panelUsuarios.RowCount = 0;

            panelUsuarios.AutoScroll = true;

            int nuevaFila = 0;

            foreach (DataRow row in datos.Rows)
            {
                ControlUsuarioProyecto.ControlUsuario control =
                    new ControlUsuarioProyecto.ControlUsuario();

                control.Id = (int)row.Field<long>("id");
                control.Nombre = row.Field<string>("Nombre");
                control.Apellido = row.Field<string>("Apellido_1");

                control.Editar += Control_Editar;
                control.Eliminar += Control_Eliminar;

                control.Dock = DockStyle.Top;

                panelUsuarios.RowCount++;
                panelUsuarios.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                panelUsuarios.Controls.Add(control, 0, nuevaFila);
                

                nuevaFila++;
            }
            panelUsuarios.Padding = new Padding(6);
        }


        private void Control_Editar(object sender, ControlUsuarioProyecto.ControlUsuario.ClickarBotonSeleccionarEventArgs e)
        {

            int sacarID = e.Id;
            var filtrado = controladorUsuario.MuestraUsu(sacarID);

            formularioEditarUsuario form = new formularioEditarUsuario();

            form.lEid.Text = filtrado.Rows[0]["ID"].ToString();
            form.tbNombre.Text = filtrado.Rows[0]["Nombre"].ToString();
            form.tbApe1.Text = filtrado.Rows[0]["Apellido_1"].ToString();
            form.tbApe2.Text = filtrado.Rows[0]["Apellido_2"].ToString();
            form.tbTelefono.Text = filtrado.Rows[0]["Telefono"].ToString();


            this.Hide();
            form.ShowDialog();
            this.Show();
            Cargar(controladorUsuario.CargarDatosUsuario());
        }

        private void Control_Eliminar(object sender, ControlUsuarioProyecto.ControlUsuario.ClickarBotonSeleccionarEventArgs e)
        {

     
            controladorUsuario.eleminarUsuario(e.Id);

            MessageBox.Show($"Usuario eliminado correctamente");
            Cargar(controladorUsuario.CargarDatosUsuario());
        }

        private void btAgregar_Click_1(object sender, EventArgs e)
        {

            FormularioAgregarUsuario form = new FormularioAgregarUsuario();
            form.controladroAgregarUsuario = this.controladorUsuario;
            this.Hide();
            form.ShowDialog();
            this.Show();
            Cargar(controladorUsuario.CargarDatosUsuario());
        }
    }
}
