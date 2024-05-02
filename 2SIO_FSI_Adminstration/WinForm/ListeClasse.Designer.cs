namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class ListeClasses
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
            this.bQuitter = new System.Windows.Forms.Button();
            this.bFermer = new System.Windows.Forms.Button();
            this.PanelQuitter = new System.Windows.Forms.Panel();
            this.dgvClasse = new System.Windows.Forms.DataGridView();
            this.Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasse)).BeginInit();
            this.SuspendLayout();
            // 
            // bQuitter
            // 
            this.bQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bQuitter.BackColor = System.Drawing.Color.Green;
            this.bQuitter.ForeColor = System.Drawing.Color.White;
            this.bQuitter.Location = new System.Drawing.Point(1024, 202);
            this.bQuitter.Margin = new System.Windows.Forms.Padding(6);
            this.bQuitter.Name = "bQuitter";
            this.bQuitter.Size = new System.Drawing.Size(241, 77);
            this.bQuitter.TabIndex = 17;
            this.bQuitter.Text = "QUITTER";
            this.bQuitter.UseVisualStyleBackColor = false;
            this.bQuitter.Click += new System.EventHandler(this.bQuitter_Click);
            // 
            // bFermer
            // 
            this.bFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bFermer.AutoSize = true;
            this.bFermer.BackColor = System.Drawing.Color.Green;
            this.bFermer.ForeColor = System.Drawing.Color.White;
            this.bFermer.Location = new System.Drawing.Point(1024, 116);
            this.bFermer.Margin = new System.Windows.Forms.Padding(6);
            this.bFermer.Name = "bFermer";
            this.bFermer.Size = new System.Drawing.Size(241, 77);
            this.bFermer.TabIndex = 19;
            this.bFermer.Text = "FERMER";
            this.bFermer.UseVisualStyleBackColor = false;
            this.bFermer.Click += new System.EventHandler(this.bFermer_Click);
            // 
            // PanelQuitter
            // 
            this.PanelQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelQuitter.Location = new System.Drawing.Point(1031, 18);
            this.PanelQuitter.Margin = new System.Windows.Forms.Padding(6);
            this.PanelQuitter.Name = "PanelQuitter";
            this.PanelQuitter.Size = new System.Drawing.Size(232, 87);
            this.PanelQuitter.TabIndex = 18;
            // 
            // dgvClasse
            // 
            this.dgvClasse.AllowUserToAddRows = false;
            this.dgvClasse.AllowUserToDeleteRows = false;
            this.dgvClasse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClasse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClasse.BackgroundColor = System.Drawing.Color.Green;
            this.dgvClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Libelle});
            this.dgvClasse.GridColor = System.Drawing.Color.White;
            this.dgvClasse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvClasse.Location = new System.Drawing.Point(159, 59);
            this.dgvClasse.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClasse.MultiSelect = false;
            this.dgvClasse.Name = "dgvClasse";
            this.dgvClasse.ReadOnly = true;
            this.dgvClasse.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvClasse.Size = new System.Drawing.Size(855, 633);
            this.dgvClasse.TabIndex = 22;
            // 
            // Libelle
            // 
            this.Libelle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Libelle.DataPropertyName = "Libelle";
            this.Libelle.HeaderText = "Nom";
            this.Libelle.MinimumWidth = 6;
            this.Libelle.Name = "Libelle";
            this.Libelle.ReadOnly = true;
            // 
            // ListeClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 736);
            this.Controls.Add(this.dgvClasse);
            this.Controls.Add(this.bQuitter);
            this.Controls.Add(this.bFermer);
            this.Controls.Add(this.PanelQuitter);
            this.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListeClasses";
            this.Text = "ListeClasses";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bQuitter;
        private System.Windows.Forms.Button bFermer;
        private System.Windows.Forms.Panel PanelQuitter;
        private System.Windows.Forms.DataGridView dgvClasse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libelle;
    }
}