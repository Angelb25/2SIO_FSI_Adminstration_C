namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class Connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lLogin = new System.Windows.Forms.Label();
            this.lMDP = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbMdp = new System.Windows.Forms.TextBox();
            this.bConnexion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(-9, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(165, 176);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lLogin
            // 
            this.lLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lLogin.AutoSize = true;
            this.lLogin.BackColor = System.Drawing.Color.White;
            this.lLogin.ForeColor = System.Drawing.Color.Green;
            this.lLogin.Location = new System.Drawing.Point(267, 27);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(76, 31);
            this.lLogin.TabIndex = 1;
            this.lLogin.Text = "Login";
            // 
            // lMDP
            // 
            this.lMDP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lMDP.AutoSize = true;
            this.lMDP.ForeColor = System.Drawing.Color.Green;
            this.lMDP.Location = new System.Drawing.Point(162, 69);
            this.lMDP.Name = "lMDP";
            this.lMDP.Size = new System.Drawing.Size(181, 31);
            this.lMDP.TabIndex = 2;
            this.lMDP.Text = "Mot de passe";
            // 
            // tbLogin
            // 
            this.tbLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbLogin.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLogin.Location = new System.Drawing.Point(349, 20);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(197, 38);
            this.tbLogin.TabIndex = 3;
            // 
            // tbMdp
            // 
            this.tbMdp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbMdp.Font = new System.Drawing.Font("Arial Narrow", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMdp.Location = new System.Drawing.Point(349, 64);
            this.tbMdp.Name = "tbMdp";
            this.tbMdp.PasswordChar = '*';
            this.tbMdp.Size = new System.Drawing.Size(197, 38);
            this.tbMdp.TabIndex = 4;
            // 
            // bConnexion
            // 
            this.bConnexion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bConnexion.BackColor = System.Drawing.Color.Green;
            this.bConnexion.Cursor = System.Windows.Forms.Cursors.Default;
            this.bConnexion.ForeColor = System.Drawing.Color.White;
            this.bConnexion.Location = new System.Drawing.Point(295, 108);
            this.bConnexion.Name = "bConnexion";
            this.bConnexion.Size = new System.Drawing.Size(158, 37);
            this.bConnexion.TabIndex = 5;
            this.bConnexion.Text = "Connexion";
            this.bConnexion.UseVisualStyleBackColor = false;
            this.bConnexion.Click += new System.EventHandler(this.bConnexion_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(558, 176);
            this.Controls.Add(this.bConnexion);
            this.Controls.Add(this.tbMdp);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lMDP);
            this.Controls.Add(this.lLogin);
            this.Controls.Add(this.pbLogo);
            this.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Connexion";
            this.Text = "CONNEXION";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lLogin;
        private System.Windows.Forms.Label lMDP;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbMdp;
        private System.Windows.Forms.Button bConnexion;

    }
}