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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        
        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void español_Click(object sender, EventArgs e)
        {
            Login_ES Ventana = new Login_ES();
            ActiveForm.Hide();
            Ventana.Show();
            
            this.Hide();
            
        }

        private void ingles_Click(object sender, EventArgs e)
        {
            Login_ENG Ventana = new Login_ENG();
            
            ActiveForm.Hide();
           
            Ventana.Show();

          
        }
    }
}
