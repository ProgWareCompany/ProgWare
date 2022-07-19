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
    public partial class Temporal_ENG : Form
    {
        public Temporal_ENG()
        {
            InitializeComponent();
        }

        private void Temporal_ENG_Load(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            MenuAdministrativo_ENG Ventana = new MenuAdministrativo_ENG();
            Ventana.Show();
            this.Hide();
        }

        private void Temporal_ENG_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnDT_Click(object sender, EventArgs e)
        {
            MenuDT_ENG Ventana = new MenuDT_ENG();
            Ventana.Show();
            this.Hide();
        }
    }
}
