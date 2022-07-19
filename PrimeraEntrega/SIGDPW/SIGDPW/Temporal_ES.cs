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
    public partial class Temporal_ES : Form
    {
        public Temporal_ES()
        {
            InitializeComponent();
        }

        private void btnDT_Click(object sender, EventArgs e)
        {
            MenuDT_ES Ventana = new MenuDT_ES();

            Ventana.Show();
            this.Hide();
        }

        private void Temporal_ES_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            MenuAdministrativo_ES Ventana = new MenuAdministrativo_ES();

            Ventana.Show();
            this.Hide();
        }

        private void Temporal_ES_Load(object sender, EventArgs e)
        {

        }
    }
}
