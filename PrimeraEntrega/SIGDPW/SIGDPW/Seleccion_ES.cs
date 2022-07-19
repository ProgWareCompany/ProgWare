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
    public partial class Seleccion_ES : Form
    {
        public Seleccion_ES()
        {
            InitializeComponent();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Consulta_ES Ventana = new Consulta_ES();

            Ventana.Show();
            this.Hide();
        }

        private void Seleccion_ES_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login_ES Ventana = new Login_ES();

            Ventana.Show();
            this.Hide();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            Resultados_ES Ventana = new Resultados_ES();

            Ventana.Show();
            this.Hide();
        }

        private void btnFixture_Click(object sender, EventArgs e)
        {
            SeleccionFixture_ES Ventana = new SeleccionFixture_ES();

            Ventana.Show();
            this.Hide();
        }

        private void Seleccion_ES_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();


        }
    }
}
