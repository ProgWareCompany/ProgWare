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
    public partial class MenuAdministrativo_ES : Form
    {
        public MenuAdministrativo_ES()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login_ES Ventana = new Login_ES();

            Ventana.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearUsuario_ES Ventana = new CrearUsuario_ES();

            Ventana.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CrearEquipo_ES Ventana = new CrearEquipo_ES();
            Ventana.Show();
            
        }

        private void MenuAdministrativo_ES_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           ModJugador_ES Ventana = new ModJugador_ES();
            Ventana.Show();

        }
    }
}
