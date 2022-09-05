namespace SIGDPW
{
    partial class IdiomaLanguage
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEspanol = new System.Windows.Forms.Button();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEspanol
            // 
            this.btnEspanol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEspanol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEspanol.Location = new System.Drawing.Point(57, 12);
            this.btnEspanol.Name = "btnEspanol";
            this.btnEspanol.Size = new System.Drawing.Size(102, 23);
            this.btnEspanol.TabIndex = 0;
            this.btnEspanol.Text = "Español";
            this.btnEspanol.UseVisualStyleBackColor = true;
            this.btnEspanol.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEnglish
            // 
            this.btnEnglish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnglish.Location = new System.Drawing.Point(57, 86);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(102, 23);
            this.btnEnglish.TabIndex = 1;
            this.btnEnglish.Text = "English";
            this.btnEnglish.UseVisualStyleBackColor = true;
            this.btnEnglish.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Image = global::SIGDPW.Properties.Resources.Monte_Jon;
            this.pictureBox1.Location = new System.Drawing.Point(81, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // IdiomaLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(223, 125);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEnglish);
            this.Controls.Add(this.btnEspanol);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "IdiomaLanguage";
            this.Text = "Idioma/Language";
            this.Load += new System.EventHandler(this.IdiomaLanguage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEspanol;
        private System.Windows.Forms.Button btnEnglish;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

