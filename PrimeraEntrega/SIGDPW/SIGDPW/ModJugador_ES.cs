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
    public partial class ModJugador_ES : Form
    {
        public ModJugador_ES()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAdministrativo_ES Ventana = new MenuAdministrativo_ES();

            Ventana.Show();
            this.Hide();
        }

        private void ModJugador_ES_Load(object sender, EventArgs e)
        {

        }
    }
}
