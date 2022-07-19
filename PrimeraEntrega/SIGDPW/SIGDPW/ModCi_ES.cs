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
    public partial class ModCi_ES : Form
    {
        public ModCi_ES()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            MenuAdministrativo_ES Ventana = new MenuAdministrativo_ES();

            Ventana.Show();
            this.Hide();
        }

        private void btn_Click(object sender, EventArgs e)
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

                ModJugador_ES Ventana = new ModJugador_ES();

                Ventana.Show();
                this.Hide();
            }
        }
    }
}
