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
    public partial class CrearJugador : Form
    {
        public CrearJugador()
        {
            InitializeComponent();
        }
        String ficha = "nada";
        String sexo = "nada";
        Boolean a, b, c, d, g;
        private void button1_Click(object sender, EventArgs e)
        {

            int ci, nom, ape, alt, pe;
            int.TryParse(textBox4.Text, out ci);
            if (ci != 0 && textBox4.Text.Length >= 8)
            {
                a = true;
            }
            if(textBox1.TextLength !=0)
            {
                b = true;
            }
            if (textBox2.TextLength !=0)
            {
                c = true;
            }
            if (textBox3.TextLength !=0)
            {
                d = true;
            }
            if (textBox5.TextLength !=0)
            {
                g = true;
            }

            if (ficha == "nada")
            {
                MessageBox.Show("Falta Ficha");
            }
            if (sexo == "nada")
            {
                MessageBox.Show("Falta Seleccionar Sexo");
            }

            if ( a == true && b == true && c == true && d == true && g == true)
            {
                MessageBox.Show(textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text + textBox5.Text + ficha + sexo);
                IdiomaLanguage.CrearJugador(int.Parse(textBox4.Text), textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), textBox5.Text, sexo, ficha);
            }
            

        }

        private void Peso(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
                sexo = "Masculino";
        }

        private void CrearJugador_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
                sexo = "Femenino";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton3.Checked)
            ficha = "Si";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton4.Checked)
            ficha = "No";
        }

        private void textBox5_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Formato: 'Metro.Centimetro'");
        }
    }
}
