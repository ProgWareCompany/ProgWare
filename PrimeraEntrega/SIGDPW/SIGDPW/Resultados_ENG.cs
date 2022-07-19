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
    public partial class Resultados_ENG : Form
    {
        public Resultados_ENG()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Seleccion_ENG Ventana = new Seleccion_ENG();

            Ventana.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Equipo_ENG Ventana = new Equipo_ENG();

            Ventana.Show();
            this.Hide();
        }
    }
}
