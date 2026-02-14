using System;
using System.Windows.Forms;
using ProyectoBiblioteca.Controlador;

namespace ProyectoBiblioteca.Vista
{
    public partial class formularioEditarLibro : Form
    {
        public controlador controladorEditarLibro { get; set; }
        public formularioEditarLibro()
        {
            InitializeComponent();
            controladorEditarLibro = new controlador();
        }

        private void btCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            int libroId = int.Parse(lEidLibro.Text);
            int valorDisponible = 1;

            if (chbDisponible.Checked)
            {
                valorDisponible = 1;
            }
            else
            {
                valorDisponible = 0;
            }

            try
            {
                controladorEditarLibro.EditLibro(libroId,
                   tbTitulo.Text,
                   tbEscritor.Text,
                   int.Parse(tbAno_edicion.Text),
                   tbSinopsis.Text,
                   valorDisponible);

                MessageBox.Show("Se ha editado el libro correctametne");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();

        }
    }
}
