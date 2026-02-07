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
    public partial class formularioEditarUsuario : Form
    {

        public controlador formularioEditarUsu { get; set; }
        public formularioEditarUsuario()
        {
            InitializeComponent();
        }
        private void btEditar_Click(object sender, EventArgs e)
        {
           
           //formularioEditarUsu.InsertarUsuario()
        }

        private void btCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btLimpiar_Click_1(object sender, EventArgs e)
        {
            tbNombre.Text = "";
            tbApe1.Text = "";
            tbApe2.Text = "";
            tbTelefono.Text = "";
        }
    }
}
