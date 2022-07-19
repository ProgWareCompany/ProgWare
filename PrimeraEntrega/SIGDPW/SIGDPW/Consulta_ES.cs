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
    public partial class Consulta_ES : Form
    {
        public Consulta_ES()
        {
            InitializeComponent();
        }

        private void Consulta_ES_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Seleccion_ES Ventana = new Seleccion_ES();

            Ventana.Show();
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            Boolean usuario = false;
           
            int ci = 0;
            int.TryParse(txtCi.Text, out ci);
            if (ci != 0 && txtCi.Text.Length >= 8)
            {
                usuario = true;
            }
            else
            {
                MessageBox.Show("Cedula Invalida");
            }
            

            if (usuario == true)
            {

                Jugador_ES Ventana = new Jugador_ES();

                Ventana.Show();
                this.Hide();
            }
        }
    }
}
