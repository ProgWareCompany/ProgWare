namespace SIGDPW
{
    partial class Seleccion_ENG
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFixture = new System.Windows.Forms.Button();
            this.btnMatch = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(75, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search Player";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFixture
            // 
            this.btnFixture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFixture.Location = new System.Drawing.Point(75, 69);
            this.btnFixture.Name = "btnFixture";
            this.btnFixture.Size = new System.Drawing.Size(110, 23);
            this.btnFixture.TabIndex = 1;
            this.btnFixture.Text = "Fixture";
            this.btnFixture.UseVisualStyleBackColor = true;
            this.btnFixture.Click += new System.EventHandler(this.btnFixture_Click);
            // 
            // btnMatch
            // 
            this.btnMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatch.Location = new System.Drawing.Point(75, 108);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(110, 23);
            this.btnMatch.TabIndex = 2;
            this.btnMatch.Text = "Matchs";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(75, 147);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(110, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Seleccion_ENG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 193);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnMatch);
            this.Controls.Add(this.btnFixture);
            this.Controls.Add(this.btnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Seleccion_ENG";
            this.Text = "Select";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Seleccion_ENG_FormClosed);
            this.Load += new System.EventHandler(this.Seleccion_ENG_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnFixture;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Button btnLogin;
    }
}