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
    public partial class IdiomaLanguage : Form
    {
       
    
        public IdiomaLanguage()
        {
            InitializeComponent();
        }
        public static void BuscarJugador(String a)
        {

            try
            {

                MySqlConnection conexion = new MySqlConnection();
                conexion.ConnectionString =
                "Server=LOCALHOST;Database=ProgWare;Uid=root;Pwd=";
                conexion.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "select * from Jugador where CI= '" + a + "'";

                MySqlDataReader lector = comando.ExecuteReader();
                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataSet ds = new DataSet();
                adaptador.Fill(ds, "Datos");
                


            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                {

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
        public static void Login(String a, String b)
        {
            
            try
            {
                
                MySqlConnection conexion = new MySqlConnection();
                conexion.ConnectionString =
                "Server=LOCALHOST;Database=ProgWare;Uid=root;Pwd=";
                conexion.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "select * from Usuario where CI= '" + a + "' AND contra = '" + b + "'";

                MySqlDataReader lector = comando.ExecuteReader();
                if (lector.HasRows)
                {
                    lector.Read();
                    IdiomaLanguage.Global.nombre = lector.GetString("Nombre");
                    IdiomaLanguage.Global.Tipo = lector.GetString("Tipo");
                }
                else
                {
                    MessageBox.Show(comando.CommandText);
                    MessageBox.Show("Error");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                {
                   
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

        private void IdiomaLanguage_Load(object sender, EventArgs e)
        {

        } 
        public static void CrearEquipo(String a, String b)
        {

            try
            {

                MySqlConnection conexion = new MySqlConnection();
                conexion.ConnectionString =
                "Server=LOCALHOST;Database=ProgWare;Uid=root;Pwd=";
                conexion.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "Insert Into Equipo(Nombre, Deporte, DT) values('" + a + "','"+ IdiomaLanguage.Global.Deporte  + "',"+ int.Parse(b)+")";
                MySqlDataReader lector = comando.ExecuteReader();
               
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                {

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
        public static void CrearUsuario(int a, String b,String c, String d, String e)
        {

            try
            {

                MySqlConnection conexion = new MySqlConnection();
                conexion.ConnectionString =
                "Server=LOCALHOST;Database=ProgWare;Uid=root;Pwd=";
                conexion.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "Insert into Usuario values('"+ a +"','"+ b +"','"+c+"','"+d+"','"+e+"')";
                MySqlDataReader lector = comando.ExecuteReader();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                {

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

        public static void CrearJugador(int ci, String nombre, String ape, int Peso,String altura, String Sexo,  String ficha)
        {

            try
            {

                MySqlConnection conexion = new MySqlConnection();
                conexion.ConnectionString =
                "Server=LOCALHOST;Database=ProgWare;Uid=root;Pwd=";
                conexion.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "Insert into Jugador(CI, Nombre, Apellido, Peso, Altura, Sexo, FichaMedica) Values("+ci+", '"+nombre+"', '"+ape+"',"+ Peso +" , "+altura+", '"+Sexo+"', '"+ficha+"')";
                MySqlDataReader lector = comando.ExecuteReader();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                {

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

        public static class Global
        {
            public static string Lenguaje;
            public static String nombre; 
            public static string Tipo;
            public static string Deporte;
            public static string Equipo;
            public static string Jugador;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            IdiomaLanguage.Global.Lenguaje = "Esp";
            Deporte Ventana = new Deporte();
            Ventana.Show();
            this.Hide();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            IdiomaLanguage.Global.Lenguaje = "Eng";
            Deporte Ventana = new Deporte();
            Ventana.Show();
            this.Hide();
        }
    }
}
