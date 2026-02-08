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

            // Necesario inicializarlo para que tenga algun valor que coger y no salte
            //NullReferenceException
            formularioEditarUsu = new controlador();
        }

        private void formularioEditarUsuario_Load(object sender, EventArgs e)
        {

          // tbApe1.Text = 

        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            int eId = int.Parse(lEid.Text);
            string nom = tbNombre.Text;
            string ape1 = tbApe1.Text;
            string ape2 = tbApe2.Text;
            int tel = int.Parse(tbTelefono.Text);

            formularioEditarUsu.EditarUsuario(eId,nom, ape1, ape2, tel);
            MessageBox.Show($"Se ha editado el usuario {tbNombre.Text}");
            this.Close();

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
