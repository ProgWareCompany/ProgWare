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
    public partial class Login_ENG : Form
    {
        public Login_ENG()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
           Seleccion_ENG Ventana = new Seleccion_ENG();

            Ventana.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Boolean usuario = false;
            Boolean contra = false;
            String contrasena;
            int ci = 0;
            int.TryParse(txtDni.Text, out ci);
            if (ci != 0 && txtDni.Text.Length >= 8)
            {
                usuario = true;
            }
            else
            {
                MessageBox.Show("Invalid DNI");
            }
            if (txtPass.Text.Length > 4)
            {
                contra = true;
            }
            else
            {
                MessageBox.Show("Contra Invalida");
            }


            if (usuario == true && contra == true)
            {
                Temporal_ENG Ventana = new Temporal_ENG();
                Ventana.Show();
                this.Hide();
            }
            
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_ENG_Load(object sender, EventArgs e)
        {

        }
    }
}
