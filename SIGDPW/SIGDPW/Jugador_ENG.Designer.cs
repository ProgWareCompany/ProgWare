namespace SIGDPW
{
    partial class Jugador_ENG
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
            this.btnBack = new System.Windows.Forms.Button();
            this.pbxJugador = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJugador)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJugador
            // 
            this.lblJugador.AutoSize = true;
            this.lblJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugador.Location = new System.Drawing.Point(50, 24);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(133, 29);
            this.lblJugador.TabIndex = 0;
            this.lblJugador.Text = "Player: -----";
            // 
            // lbxJugador
            // 
            this.lbxJugador.FormattingEnabled = true;
            this.lbxJugador.Location = new System.Drawing.Point(55, 66);
            this.lbxJugador.Name = "lbxJugador";
            this.lbxJugador.Size = new System.Drawing.Size(219, 238);
            this.lbxJugador.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnBack.Location = new System.Drawing.Point(2, 310);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbxJugador
            // 
            this.pbxJugador.Location = new System.Drawing.Point(303, 34);
            this.pbxJugador.Name = "pbxJugador";
            this.pbxJugador.Size = new System.Drawing.Size(100, 67);
            this.pbxJugador.TabIndex = 3;
            this.pbxJugador.TabStop = false;
            // 
            // Jugador_ENG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 342);
            this.Controls.Add(this.pbxJugador);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbxJugador);
            this.Controls.Add(this.lblJugador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Jugador_ENG";
            this.Text = "Player";
            ((System.ComponentModel.ISupportInitialize)(this.pbxJugador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJugador;
        private System.Windows.Forms.ListBox lbxJugador;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pbxJugador;
    }
}