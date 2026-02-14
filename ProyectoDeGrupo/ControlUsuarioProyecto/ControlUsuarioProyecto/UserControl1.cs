using System;
using System.Windows.Forms;

namespace ControlUsuarioProyecto
{
    public partial class ControlUsuario : UserControl
    {


        public ControlUsuario()
        {
            InitializeComponent();
        }

        public int Id
        {
            get => id;
            set => id = value;
        }
        public string Nombre
        {
            get => txtNombre.Text;
            set => txtNombre.Text = value;
        }
        public string Apellido
        {
            get => txtApellido.Text;
            set => txtApellido.Text = value;
        }


        private int id;
        public class ClickarBotonSeleccionarEventArgs : EventArgs
        {
            public int Id { get; }
            public ClickarBotonSeleccionarEventArgs(int id)
            {
                Id = id;
            }

        }
        public event EventHandler<ClickarBotonSeleccionarEventArgs> Editar;



        public event EventHandler<ClickarBotonSeleccionarEventArgs> Eliminar;




        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            Editar?.Invoke(this, new ClickarBotonSeleccionarEventArgs(id));
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (ckSeleccionar.Checked)
            {
                Eliminar?.Invoke(this, new ClickarBotonSeleccionarEventArgs(id));
            }

        }
    }
}