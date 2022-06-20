namespace WindowsFormsApp5
{
    partial class Inicio
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
            this.btnespanol = new System.Windows.Forms.Button();
            this.btningles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnespanol
            // 
            this.btnespanol.Location = new System.Drawing.Point(116, 12);
            this.btnespanol.Name = "btnespanol";
            this.btnespanol.Size = new System.Drawing.Size(75, 23);
            this.btnespanol.TabIndex = 0;
            this.btnespanol.Text = "Español";
            this.btnespanol.UseVisualStyleBackColor = true;
            this.btnespanol.Click += new System.EventHandler(this.español_Click);
            // 
            // btningles
            // 
            this.btningles.Location = new System.Drawing.Point(116, 41);
            this.btningles.Name = "btningles";
            this.btningles.Size = new System.Drawing.Size(75, 23);
            this.btningles.TabIndex = 3;
            this.btningles.Text = "English";
            this.btningles.UseVisualStyleBackColor = true;
            this.btningles.Click += new System.EventHandler(this.ingles_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 77);
            this.Controls.Add(this.btningles);
            this.Controls.Add(this.btnespanol);
            this.Name = "Inicio";
            this.Text = "Idioma/Language";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnespanol;
        private System.Windows.Forms.Button btningles;
    }
}