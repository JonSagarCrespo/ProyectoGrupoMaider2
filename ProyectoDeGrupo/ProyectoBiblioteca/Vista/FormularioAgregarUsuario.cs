using ProyectoBiblioteca.Controlador;
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
