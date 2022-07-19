using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGDPW
{
    public partial class MenuAdministrativo_ENG : Form
    {
        public MenuAdministrativo_ENG()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearUsuario_ENG Ventana = new CrearUsuario_ENG();

            Ventana.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CrearEquipo_ENG Ventana = new CrearEquipo_ENG();
            Ventana.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Temporal_ENG Ventana = new Temporal_ENG();
            Ventana.Show();
            this.Hide();
        }
    }
}
