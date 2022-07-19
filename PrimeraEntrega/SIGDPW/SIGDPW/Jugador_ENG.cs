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
    public partial class Jugador_ENG : Form
    {
        public Jugador_ENG()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seleccion_ENG Ventana = new Seleccion_ENG();

            Ventana.Show();
            this.Hide();
        }
    }
}
