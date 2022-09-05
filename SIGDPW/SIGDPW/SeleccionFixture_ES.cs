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
    public partial class SeleccionFixture_ES : Form
    {
        public SeleccionFixture_ES()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fixture_ES Ventana = new Fixture_ES();

            Ventana.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Seleccion_ES Ventana = new Seleccion_ES();

            Ventana.Show();
            this.Hide();
        }

        private void SeleccionFixture_ES_Load(object sender, EventArgs e)
        {

        }
    }
}
