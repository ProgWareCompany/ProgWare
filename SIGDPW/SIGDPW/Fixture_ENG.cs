﻿using System;
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
    public partial class Fixture_ENG : Form
    {
        public Fixture_ENG()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeleccionFixture_ENG Ventana = new SeleccionFixture_ENG();

            Ventana.Show();
            this.Hide();
        }

        private void Fixture_ENG_Load(object sender, EventArgs e)
        {

        }
    }
}
