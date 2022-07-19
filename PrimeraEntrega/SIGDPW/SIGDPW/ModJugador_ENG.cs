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
    public partial class ModJugador_ENG : Form
    {
        public ModJugador_ENG()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAdministrativo_ENG Ventana = new MenuAdministrativo_ENG();

            Ventana.Show();
            this.Hide();
        }
    }
}
