using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIGDPW
{
    public partial class Login_ES : Form
    {
        public Login_ES()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_ES_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Seleccion_ES Ventana = new Seleccion_ES();

            Ventana.Show();
            this.Hide();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Boolean usuario = false;
            Boolean contra = false;
            int ci=0 ;
            int.TryParse(txtUsuario.Text, out ci);
            if (ci != 0 && txtUsuario.Text.Length >= 8)
            {
                usuario = true;
            }
            else {
                MessageBox.Show("Cedula Invalida");
                    }
            if(txtContra.Text.Length >= 4)
            {
                contra = true;
            }
            else
            {
                MessageBox.Show("Contra Invalida");
            }

     
        if(usuario == true && contra ==true)
            {
                IdiomaLanguage.Login(txtUsuario.Text, txtContra.Text);
            }
            
            String Rol = IdiomaLanguage.Global.Tipo;

            if (Rol == "Administrador")
            {
                MenuAdministrador Ventana = new MenuAdministrador();
                Ventana.Show();
                this.Hide();
            }
            if (Rol == "DT")
            {
                MenuDT_ES Ventana = new MenuDT_ES();
                Ventana.Show();
                this.Hide();
            }
            if (Rol == "Administrativo")
            {
                MenuAdministrativo_ES Ventana = new MenuAdministrativo_ES();

                Ventana.Show();
                this.Hide();
            }
            if (Rol == "Juez")
            {
                MenuJuez Ventana = new MenuJuez();

                Ventana.Show();
                this.Hide();
            }
            if (Rol == "Analista")
            {
                MenuAnalista Ventana = new MenuAnalista();
                Ventana.Show();
                this.Hide();
            }
            

        }

        private void Login_ES_Load(object sender, EventArgs e)
        {

        }
        Boolean click = false;
        private void txtContra_Click(object sender, EventArgs e)
        {
            
            if(click == false)
            {
                MessageBox.Show("La Contraseña tiene que ser mas larga que 4 digitos");
                click = true;
            }
        }
    }
}
