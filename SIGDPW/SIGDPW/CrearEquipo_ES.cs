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
    public partial class CrearEquipo_ES : Form
    {
        public CrearEquipo_ES()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAdministrativo_ES Ventana = new MenuAdministrativo_ES();

            
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           IdiomaLanguage.CrearEquipo(textBox1.Text, comboBox2.Text);
            textBox1.Text = "";
            comboBox2.Text="";
            
        }

        private void CrearEquipo_ES_Load(object sender, EventArgs e)
        {

        }
    }
}
