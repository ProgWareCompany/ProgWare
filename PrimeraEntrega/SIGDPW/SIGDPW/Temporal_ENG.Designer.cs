namespace SIGDPW
{
    partial class Temporal_ENG
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
            this.btnAnalista = new System.Windows.Forms.Button();
            this.btnJuez = new System.Windows.Forms.Button();
            this.btnDT = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnalista
            // 
            this.btnAnalista.Location = new System.Drawing.Point(69, 184);
            this.btnAnalista.Name = "btnAnalista";
            this.btnAnalista.Size = new System.Drawing.Size(75, 23);
            this.btnAnalista.TabIndex = 7;
            this.btnAnalista.Text = "Analist";
            this.btnAnalista.UseVisualStyleBackColor = true;
            // 
            // btnJuez
            // 
            this.btnJuez.Location = new System.Drawing.Point(69, 143);
            this.btnJuez.Name = "btnJuez";
            this.btnJuez.Size = new System.Drawing.Size(75, 23);
            this.btnJuez.TabIndex = 6;
            this.btnJuez.Text = "Judge ";
            this.btnJuez.UseVisualStyleBackColor = true;
            // 
            // btnDT
            // 
            this.btnDT.Location = new System.Drawing.Point(69, 95);
            this.btnDT.Name = "btnDT";
            this.btnDT.Size = new System.Drawing.Size(75, 23);
            this.btnDT.TabIndex = 5;
            this.btnDT.Text = "DT";
            this.btnDT.UseVisualStyleBackColor = true;
            this.btnDT.Click += new System.EventHandler(this.btnDT_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(69, 48);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(100, 23);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "Administrative";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // Temporal_ENG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 264);
            this.Controls.Add(this.btnAnalista);
            this.Controls.Add(this.btnJuez);
            this.Controls.Add(this.btnDT);
            this.Controls.Add(this.btnAdmin);
            this.Name = "Temporal_ENG";
            this.Text = "Roles Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Temporal_ENG_FormClosing);
            this.Load += new System.EventHandler(this.Temporal_ENG_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnalista;
        private System.Windows.Forms.Button btnJuez;
        private System.Windows.Forms.Button btnDT;
        private System.Windows.Forms.Button btnAdmin;
    }
}