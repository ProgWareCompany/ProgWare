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
    public partial class Equipo_ENG : Form
    {
        public Equipo_ENG()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {

            Seleccion_ENG Ventana = new Seleccion_ENG();

            Ventana.Show();
            this.Hide();


        }
    }
}
