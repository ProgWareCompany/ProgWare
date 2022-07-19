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
    public partial class IdiomaLanguage : Form
    {
        public IdiomaLanguage()
        {
            InitializeComponent();
        }

        private void IdiomaLanguage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seleccion_ES Ventana = new Seleccion_ES();

          
            
            Ventana.Show();
            this.Hide();





        }

        private void button2_Click(object sender, EventArgs e)
        {
            Seleccion_ENG Ventana = new Seleccion_ENG();
            
            Ventana.Show();
            this.Hide();
        }
    }
}
