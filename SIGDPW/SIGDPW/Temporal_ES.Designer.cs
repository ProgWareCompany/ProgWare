namespace SIGDPW
{
    partial class Temporal_ES
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
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnDT = new System.Windows.Forms.Button();
            this.btnJuez = new System.Windows.Forms.Button();
            this.btnAnalista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(69, 53);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(100, 23);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Administrativo";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnDT
            // 
            this.btnDT.Location = new System.Drawing.Point(69, 100);
            this.btnDT.Name = "btnDT";
            this.btnDT.Size = new System.Drawing.Size(75, 23);
            this.btnDT.TabIndex = 1;
            this.btnDT.Text = "DT";
            this.btnDT.UseVisualStyleBackColor = true;
            this.btnDT.Click += new System.EventHandler(this.btnDT_Click);
            // 
            // btnJuez
            // 
            this.btnJuez.Location = new System.Drawing.Point(69, 148);
            this.btnJuez.Name = "btnJuez";
            this.btnJuez.Size = new System.Drawing.Size(75, 23);
            this.btnJuez.TabIndex = 2;
            this.btnJuez.Text = "Juez";
            this.btnJuez.UseVisualStyleBackColor = true;
            // 
            // btnAnalista
            // 
            this.btnAnalista.Location = new System.Drawing.Point(69, 189);
            this.btnAnalista.Name = "btnAnalista";
            this.btnAnalista.Size = new System.Drawing.Size(75, 23);
            this.btnAnalista.TabIndex = 3;
            this.btnAnalista.Text = "Analista";
            this.btnAnalista.UseVisualStyleBackColor = true;
            // 
            // Temporal_ES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 275);
            this.Controls.Add(this.btnAnalista);
            this.Controls.Add(this.btnJuez);
            this.Controls.Add(this.btnDT);
            this.Controls.Add(this.btnAdmin);
            this.Name = "Temporal_ES";
            this.Text = "Ventana Temporal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Temporal_ES_FormClosing);
            this.Load += new System.EventHandler(this.Temporal_ES_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnDT;
        private System.Windows.Forms.Button btnJuez;
        private System.Windows.Forms.Button btnAnalista;
    }
}