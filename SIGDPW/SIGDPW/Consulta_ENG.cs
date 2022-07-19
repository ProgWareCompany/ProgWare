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
    public partial class Consulta_ENG : Form
    {
        public Consulta_ENG()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Seleccion_ENG Ventana = new Seleccion_ENG();

            Ventana.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
                MessageBox.Show("Invalid DNI");
            }


            if (usuario == true)
            {

                Jugador_ENG Ventana = new Jugador_ENG();

                Ventana.Show();
                this.Hide();
            }




            
        }
    }
}
