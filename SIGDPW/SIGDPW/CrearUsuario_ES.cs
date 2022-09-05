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
    public partial class CrearUsuario_ES : Form
    {
        public CrearUsuario_ES()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuAdministrativo_ES Ventana = new MenuAdministrativo_ES();

            this.Hide();
        }

        private void CrearUsuario_ES_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(rol == "nada")
            {
                MessageBox.Show("Seleccione un Rol");
            }
            else
            {

                IdiomaLanguage.CrearUsuario(int.Parse(textBox4.Text), textBox5.Text, textBox1.Text, textBox2.Text, rol);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
            
        }
        String rol="nada";
       

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            rol = "Juez";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            rol = "DT";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            rol = "Analista";
        }
    }
}
