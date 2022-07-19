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
    public partial class Resultados_ES : Form
    {
        public Resultados_ES()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Seleccion_ES Ventana = new Seleccion_ES();

            Ventana.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Equipo_ES Ventana = new Equipo_ES();

            Ventana.Show();
            this.Hide();
        }
    }
}
