using System;
using System.Windows.Forms;
using ProyectoBiblioteca.Controlador;

namespace ProyectoBiblioteca.Vista
{
    public partial class FormularioAgregarUsuario : Form
    {
        public controlador controladroAgregarUsuario { get; set; }

        public FormularioAgregarUsuario()
        {
            InitializeComponent();
        }


        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                controladroAgregarUsuario.InsertarUsuario(tbNombre.Text, tbApe1.Text, tbApe2.Text, int.Parse(tbTelefono.Text));
                MessageBox.Show($"Se ha agreado el usuario {tbNombre.Text}");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el usuario: {ex.Message}");
            }

        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            tbNombre.Text = "";
            tbApe1.Text = "";
            tbApe2.Text = "";
            tbTelefono.Text = "";
        }

    }
}
