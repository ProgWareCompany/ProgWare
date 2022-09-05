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
    public partial class MenuAnalista : Form
    {
        public MenuAnalista()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
                    }

        private void button3_Click(object sender, EventArgs e)
        {
            Login_ES Ventana = new Login_ES();
            Ventana.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro Ventana = new Registro();
            Ventana.Show();
            
        }

        private void MenuAnalista_Load(object sender, EventArgs e)
        {

        }
    }
}
