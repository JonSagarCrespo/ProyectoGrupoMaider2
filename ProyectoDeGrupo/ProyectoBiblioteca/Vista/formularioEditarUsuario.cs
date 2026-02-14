using System;
using System.Windows.Forms;
using ProyectoBiblioteca.Controlador;

namespace ProyectoBiblioteca.Vista
{
    public partial class formularioEditarUsuario : Form
    {



        public controlador controladorEditarUsuario { get; set; }
        public formularioEditarUsuario()
        {
            InitializeComponent();

            // Necesario inicializarlo para que tenga algun valor que coger y no salte
            //NullReferenceException
            controladorEditarUsuario = new controlador();
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

            try
            {
                controladorEditarUsuario.EditarUsuario(eId, nom, ape1, ape2, tel);
                MessageBox.Show($"Se ha editado el usuario {tbNombre.Text}");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void btCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

   
    }
}
