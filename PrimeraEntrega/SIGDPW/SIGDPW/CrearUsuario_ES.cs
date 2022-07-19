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
    public partial class CrearUsuario_ES : Form
    {
        public CrearUsuario_ES()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuAdministrativo_ES Ventana = new MenuAdministrativo_ES();

            Ventana.Show();
            this.Hide();
        }

        private void CrearUsuario_ES_Load(object sender, EventArgs e)
        {

        }
    }
}
