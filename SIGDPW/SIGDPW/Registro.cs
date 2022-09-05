using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIGDPW
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login_ES Ventana = new Login_ES();
            Ventana.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton4.Visible = true;
            radioButton3.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton4.Visible = false;
            radioButton3.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Falta")
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
            }
            else
            {
                radioButton1.Visible = false;
                radioButton2.Visible = false;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Registro_Load(object sender, EventArgs e)
        {
            try
            {
                //Conexion
                MySqlConnection conexion = new MySqlConnection();
                conexion.ConnectionString =
                "Server=LOCALHOST;Database=ProgWare;Uid=root;Pwd=";
                conexion.Open();
                //Sentencia
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "select Equipo.Nombre, Usuario.Nombre AS 'Director Tecnico'  from Equipo join Usuario WHERE DT = CI";
                comando.ExecuteNonQuery();
                //Adaptador
                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                adaptador.SelectCommand = comando;
                //Conjunto de resultados
                DataSet ds = new DataSet();
                adaptador.Fill(ds, "datos");
                //Cargar los resultados en el Data Grid View
                dataGridView1.DataSource = ds.Tables["datos"];
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                {
                    //MessageBox.Show("Error: " + ex.Message);
                    switch (ex.Number)
                    {
                        case 0:
                            MessageBox.Show("Imposible abrir una conexión el servidor de BD");
                            break;
                        case 1045:
                            MessageBox.Show("Usuario y/o contraseña incorrectas");
                            break;
                    }
                }
            }
        }
    }
}
