using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Invitado_ENG : Form
    {
        public Invitado_ENG()
        {
            InitializeComponent();
        }

        private void Invitado_ENG_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            Player Ventana = new Player();

            ActiveForm.Hide();

            Ventana.Show();

        }
    }
}
