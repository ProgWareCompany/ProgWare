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
    public partial class Login_ENG : Form
    {
        public Login_ENG()
        {
            InitializeComponent();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassw_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void Guest_Click(object sender, EventArgs e)
        {
            Invitado_ENG Ventana = new Invitado_ENG();
            ActiveForm.Hide();

            Ventana.Show();

            this.Hide();
        }

        private void Login_ENG_Load(object sender, EventArgs e)
        {

        }
    }
}
