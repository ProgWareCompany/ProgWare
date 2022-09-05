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
    public partial class Deporte : Form
    {
        public Deporte()
        {
            InitializeComponent();
        }

        private void Deporte_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IdiomaLanguage.Global.Deporte = "Football";
            
            Seleccion_ES Ventana = new Seleccion_ES();
            Ventana.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IdiomaLanguage.Global.Deporte = "BasketBall";
            Seleccion_ES Ventana = new Seleccion_ES();
            Ventana.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IdiomaLanguage.Global.Deporte = "HandBall";
            Seleccion_ES Ventana = new Seleccion_ES();
            Ventana.Show();
            this.Hide();
        }
    }
}
