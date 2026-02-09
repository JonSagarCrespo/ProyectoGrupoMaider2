using ProyectoBiblioteca.Controlador;
using System;
using System.Windows.Forms;

namespace ProyectoBiblioteca.Vista
{
    public partial class formularioAgregarLibro : Form
    {
        public controlador controladorAgregarLib { get; set; }

        public formularioAgregarLibro()
        {
            InitializeComponent();
        }

        private void formularioAgregarLibro_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void limpiarCampos()
        {
            tbTitulo.Text = "";
            tbEscritor.Text = "";
            tbAno_edicion.Text = "";
            tbSinopsis.Text = "";

        }
     
        private void btGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = 0;

            if (ckDisponible.Checked)
            {
                numero = 1;
            }
            else
                numero = 0;
          

                controladorAgregarLib.InsertarLibro(tbTitulo.Text, tbEscritor.Text, int.Parse(tbAno_edicion.Text), tbSinopsis.Text, numero);
                limpiarCampos();
                throw new Exception("Libro agregado correctamente");
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
