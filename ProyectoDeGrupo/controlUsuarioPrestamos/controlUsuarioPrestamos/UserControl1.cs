using System;
using System.Windows.Forms;

namespace controlUsuarioPrestamos
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void tblpPricipal_Paint(object sender, PaintEventArgs e)
        {

        }

        public int Id
        {
            get
            {
                if (int.TryParse(lbId.Text, out int result))
                    return result;

                return 0; // o lanzar excepción personalizada si lo prefieres
            }
            set => lbId.Text = value.ToString();
        }

        public string Nombre
        {
            get => lbNombre.Text;
            set => lbNombre.Text = value;
        }
        public string libro
        {
            get => lbLibro.Text;
            set => lbLibro.Text = value;
        }

        private int ID;
        public class ClickarBotonSeleccionarEventArgs : EventArgs
        {
            public int Id { get; }
            public ClickarBotonSeleccionarEventArgs(int id)
            {
                Id = id;
            }

        }
        public event EventHandler<ClickarBotonSeleccionarEventArgs> devolucion;

        private void btDevolucion_Click(object sender, EventArgs e)
        {
            devolucion?.Invoke(this, new ClickarBotonSeleccionarEventArgs(ID));
        }
    }
}
