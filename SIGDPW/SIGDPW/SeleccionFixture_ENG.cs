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
    public partial class SeleccionFixture_ENG : Form
    {
        public SeleccionFixture_ENG()
        {
            InitializeComponent();
        }

        private void SeleccionFixture_ENG_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Seleccion_ENG Ventana = new Seleccion_ENG();

            Ventana.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fixture_ENG Ventana = new Fixture_ENG();

            Ventana.Show();
            this.Hide();
        }
    }
}
