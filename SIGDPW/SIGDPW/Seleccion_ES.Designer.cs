namespace SIGDPW
{
    partial class Seleccion_ES
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
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnFixture = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsulta
            // 
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Location = new System.Drawing.Point(72, 30);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(111, 23);
            this.btnConsulta.TabIndex = 0;
            this.btnConsulta.Text = "Consultar Jugador";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnFixture
            // 
            this.btnFixture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFixture.Location = new System.Drawing.Point(72, 70);
            this.btnFixture.Name = "btnFixture";
            this.btnFixture.Size = new System.Drawing.Size(111, 23);
            this.btnFixture.TabIndex = 1;
            this.btnFixture.Text = "Fixture";
            this.btnFixture.UseVisualStyleBackColor = true;
            this.btnFixture.Click += new System.EventHandler(this.btnFixture_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResultado.Location = new System.Drawing.Point(72, 109);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(111, 23);
            this.btnResultado.TabIndex = 2;
            this.btnResultado.Text = "Resultados";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(72, 152);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(111, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Seleccion_ES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 213);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnFixture);
            this.Controls.Add(this.btnConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Seleccion_ES";
            this.Text = "Seleccion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Seleccion_ES_FormClosing);
            this.Load += new System.EventHandler(this.Seleccion_ES_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnFixture;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button btnLogin;
    }
}