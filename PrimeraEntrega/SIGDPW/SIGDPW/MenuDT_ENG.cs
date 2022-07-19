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
    public partial class MenuDT_ENG : Form
    {
        public MenuDT_ENG()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Temporal_ENG Ventana = new Temporal_ENG();

            Ventana.Show();
            this.Hide();
        }
    }
}
