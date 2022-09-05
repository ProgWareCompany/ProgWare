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
    public partial class Equipo_ES : Form
    {
        public Equipo_ES()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Seleccion_ES Ventana = new Seleccion_ES();

            
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Equipo_ES_Load(object sender, EventArgs e)
        {
            lblEquipo.Text = "Equipo: " + IdiomaLanguage.Global.Equipo;
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
                comando.CommandText = "Select ELocal , ResultadoL, ResultadoL, Visitante, Fecha from Partido join Equipo WHERE Equipo.IDE = ELocal";
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
