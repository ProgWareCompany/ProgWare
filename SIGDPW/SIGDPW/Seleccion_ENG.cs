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
    public partial class Seleccion_ENG : Form
    {
        public Seleccion_ENG()
        {
            InitializeComponent();
        }

        private void Seleccion_ENG_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consulta_ENG Ventana = new Consulta_ENG();

            Ventana.Show();
            this.Hide();
        }

        private void btnFixture_Click(object sender, EventArgs e)
        {
            SeleccionFixture_ENG Ventana = new SeleccionFixture_ENG();

            Ventana.Show();
            this.Hide();
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            Resultados_ENG Ventana = new Resultados_ENG();

            Ventana.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           Login_ENG Ventana = new Login_ENG();

            Ventana.Show();
            this.Hide();
        }

        private void Seleccion_ENG_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            
        }
    }
}
