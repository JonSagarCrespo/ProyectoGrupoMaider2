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
            controladorEditarLibro.EditLibro(libroId,
                    tbTitulo.Text,
                    tbEscritor.Text,
                    int.Parse(tbAno_edicion.Text),
                    tbSinopsis.Text,
                    valorDisponible);

            MessageBox.Show("Se ha editado el libro correctametne");
            this.Close();

        }
    }
}
