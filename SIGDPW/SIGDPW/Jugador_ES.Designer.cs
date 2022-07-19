namespace SIGDPW
{
    partial class Jugador_ES
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
            this.lblJugador = new System.Windows.Forms.Label();
            this.lbxJugador = new System.Windows.Forms.ListBox();
            this.pbxJugador = new System.Windows.Forms.PictureBox();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJugador)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJugador
            // 
            this.lblJugador.AutoSize = true;
            this.lblJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugador.Location = new System.Drawing.Point(114, 35);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(153, 29);
            this.lblJugador.TabIndex = 0;
            this.lblJugador.Text = "Jugador: -----";
            // 
            // lbxJugador
            // 
            this.lbxJugador.FormattingEnabled = true;
            this.lbxJugador.Location = new System.Drawing.Point(119, 80);
            this.lbxJugador.Name = "lbxJugador";
            this.lbxJugador.Size = new System.Drawing.Size(229, 238);
            this.lbxJugador.TabIndex = 1;
            // 
            // pbxJugador
            // 
            this.pbxJugador.Location = new System.Drawing.Point(381, 12);
            this.pbxJugador.Name = "pbxJugador";
            this.pbxJugador.Size = new System.Drawing.Size(101, 70);
            this.pbxJugador.TabIndex = 2;
            this.pbxJugador.TabStop = false;
            // 
            // btnAtras
            // 
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Location = new System.Drawing.Point(1, 305);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 3;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // Jugador_ES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 330);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.pbxJugador);
            this.Controls.Add(this.lbxJugador);
            this.Controls.Add(this.lblJugador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Jugador_ES";
            this.Text = "Jugador";
            ((System.ComponentModel.ISupportInitialize)(this.pbxJugador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJugador;
        private System.Windows.Forms.ListBox lbxJugador;
        private System.Windows.Forms.PictureBox pbxJugador;
        private System.Windows.Forms.Button btnAtras;
    }
}