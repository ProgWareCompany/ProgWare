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
    public partial class Login_ES : Form
    {
        public Login_ES()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontra_TextChanged(object sender, EventArgs e)
        {

        }


        private void ingresar_Click(object sender, EventArgs e)
        {



           
        }

        

        private void invitado_Click(object sender, EventArgs e)
        {
            invitado_ES Ventana = new invitado_ES();
            ActiveForm.Hide();
            Ventana.Show();

            this.Hide();
        }

        private void Login_ES_Load(object sender, EventArgs e)
        {

        }
    }
}
