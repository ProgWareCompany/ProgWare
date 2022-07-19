namespace SIGDPW
{
    partial class MenuDT_ES
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAtras = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lbxJugadoresD = new System.Windows.Forms.ListBox();
            this.btnVerResultados = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lbxPartidosR = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnResultados = new System.Windows.Forms.Button();
            this.btnCargarPerfil = new System.Windows.Forms.Button();
            this.btnAnadirJugador = new System.Windows.Forms.Button();
            this.lbxPartidosF = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Location = new System.Drawing.Point(12, 604);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(53, 23);
            this.btnAtras.TabIndex = 3;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(726, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(233, 394);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(984, 89);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(83, 23);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar ";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // lbxJugadoresD
            // 
            this.lbxJugadoresD.FormattingEnabled = true;
            this.lbxJugadoresD.Location = new System.Drawing.Point(726, 441);
            this.lbxJugadoresD.Name = "lbxJugadoresD";
            this.lbxJugadoresD.Size = new System.Drawing.Size(233, 186);
            this.lbxJugadoresD.TabIndex = 6;
            this.lbxJugadoresD.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // btnVerResultados
            // 
            this.btnVerResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerResultados.Location = new System.Drawing.Point(984, 127);
            this.btnVerResultados.Name = "btnVerResultados";
            this.btnVerResultados.Size = new System.Drawing.Size(83, 23);
            this.btnVerResultados.TabIndex = 7;
            this.btnVerResultados.Text = "Desabilitar";
            this.btnVerResultados.UseVisualStyleBackColor = true;
            this.btnVerResultados.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(984, 490);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 26);
            this.button3.TabIndex = 8;
            this.button3.Text = "Habilitar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(984, 536);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 26);
            this.button4.TabIndex = 9;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbxPartidosR
            // 
            this.lbxPartidosR.FormattingEnabled = true;
            this.lbxPartidosR.Location = new System.Drawing.Point(40, 31);
            this.lbxPartidosR.Name = "lbxPartidosR";
            this.lbxPartidosR.Size = new System.Drawing.Size(354, 225);
            this.lbxPartidosR.TabIndex = 10;
            this.lbxPartidosR.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ultimos Partidos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(781, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Jugadores Desabilitados";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(830, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Jugadores";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnResultados
            // 
            this.btnResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResultados.Location = new System.Drawing.Point(415, 74);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(75, 23);
            this.btnResultados.TabIndex = 14;
            this.btnResultados.Text = "Resultados";
            this.btnResultados.UseVisualStyleBackColor = true;
            // 
            // btnCargarPerfil
            // 
            this.btnCargarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarPerfil.Location = new System.Drawing.Point(626, 172);
            this.btnCargarPerfil.Name = "btnCargarPerfil";
            this.btnCargarPerfil.Size = new System.Drawing.Size(94, 23);
            this.btnCargarPerfil.TabIndex = 15;
            this.btnCargarPerfil.Text = "Cargar Perfil";
            this.btnCargarPerfil.UseVisualStyleBackColor = true;
            this.btnCargarPerfil.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnAnadirJugador
            // 
            this.btnAnadirJugador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnadirJugador.Location = new System.Drawing.Point(626, 201);
            this.btnAnadirJugador.Name = "btnAnadirJugador";
            this.btnAnadirJugador.Size = new System.Drawing.Size(94, 23);
            this.btnAnadirJugador.TabIndex = 16;
            this.btnAnadirJugador.Text = "Añadir Jugador";
            this.btnAnadirJugador.UseVisualStyleBackColor = true;
            this.btnAnadirJugador.Click += new System.EventHandler(this.button7_Click);
            // 
            // lbxPartidosF
            // 
            this.lbxPartidosF.FormattingEnabled = true;
            this.lbxPartidosF.Location = new System.Drawing.Point(40, 402);
            this.lbxPartidosF.Name = "lbxPartidosF";
            this.lbxPartidosF.Size = new System.Drawing.Size(473, 160);
            this.lbxPartidosF.TabIndex = 17;
            this.lbxPartidosF.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Partidos Futuros";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // MenuDT_ES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 636);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbxPartidosF);
            this.Controls.Add(this.btnAnadirJugador);
            this.Controls.Add(this.btnCargarPerfil);
            this.Controls.Add(this.btnResultados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxPartidosR);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnVerResultados);
            this.Controls.Add(this.lbxJugadoresD);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MenuDT_ES";
            this.Text = "Menu DT";
            this.Load += new System.EventHandler(this.MenuDT_ES_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ListBox lbxJugadoresD;
        private System.Windows.Forms.Button btnVerResultados;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox lbxPartidosR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnResultados;
        private System.Windows.Forms.Button btnCargarPerfil;
        private System.Windows.Forms.Button btnAnadirJugador;
        private System.Windows.Forms.ListBox lbxPartidosF;
        private System.Windows.Forms.Label label4;
    }
}