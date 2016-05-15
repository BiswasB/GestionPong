namespace GestionPong
{
    partial class FormConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.labelPseudonymeCP = new System.Windows.Forms.Label();
            this.textBoxPseudonyme = new System.Windows.Forms.TextBox();
            this.textBoxMotdePasse = new System.Windows.Forms.TextBox();
            this.labelMotDePasseCP = new System.Windows.Forms.Label();
            this.buttonNouveauCompte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Location = new System.Drawing.Point(16, 93);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(180, 23);
            this.buttonConnexion.TabIndex = 0;
            this.buttonConnexion.Text = "Connexion";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // labelPseudonymeCP
            // 
            this.labelPseudonymeCP.AutoSize = true;
            this.labelPseudonymeCP.Location = new System.Drawing.Point(12, 9);
            this.labelPseudonymeCP.Name = "labelPseudonymeCP";
            this.labelPseudonymeCP.Size = new System.Drawing.Size(74, 13);
            this.labelPseudonymeCP.TabIndex = 1;
            this.labelPseudonymeCP.Text = "Pseudonyme :";
            // 
            // textBoxPseudonyme
            // 
            this.textBoxPseudonyme.Location = new System.Drawing.Point(96, 6);
            this.textBoxPseudonyme.Name = "textBoxPseudonyme";
            this.textBoxPseudonyme.Size = new System.Drawing.Size(100, 20);
            this.textBoxPseudonyme.TabIndex = 2;
            this.textBoxPseudonyme.Text = "Basia";
            // 
            // textBoxMotdePasse
            // 
            this.textBoxMotdePasse.Location = new System.Drawing.Point(95, 57);
            this.textBoxMotdePasse.Name = "textBoxMotdePasse";
            this.textBoxMotdePasse.Size = new System.Drawing.Size(100, 20);
            this.textBoxMotdePasse.TabIndex = 4;
            this.textBoxMotdePasse.Text = "Brynn";
            // 
            // labelMotDePasseCP
            // 
            this.labelMotDePasseCP.AutoSize = true;
            this.labelMotDePasseCP.Location = new System.Drawing.Point(12, 60);
            this.labelMotDePasseCP.Name = "labelMotDePasseCP";
            this.labelMotDePasseCP.Size = new System.Drawing.Size(77, 13);
            this.labelMotDePasseCP.TabIndex = 3;
            this.labelMotDePasseCP.Text = "Mot de passe :";
            // 
            // buttonNouveauCompte
            // 
            this.buttonNouveauCompte.Location = new System.Drawing.Point(15, 122);
            this.buttonNouveauCompte.Name = "buttonNouveauCompte";
            this.buttonNouveauCompte.Size = new System.Drawing.Size(180, 23);
            this.buttonNouveauCompte.TabIndex = 5;
            this.buttonNouveauCompte.Text = "Créer un nouveau compte";
            this.buttonNouveauCompte.UseVisualStyleBackColor = true;
            this.buttonNouveauCompte.Click += new System.EventHandler(this.buttonNouveauCompte_Click);
            // 
            // FormConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 158);
            this.Controls.Add(this.buttonNouveauCompte);
            this.Controls.Add(this.textBoxMotdePasse);
            this.Controls.Add(this.labelMotDePasseCP);
            this.Controls.Add(this.textBoxPseudonyme);
            this.Controls.Add(this.labelPseudonymeCP);
            this.Controls.Add(this.buttonConnexion);
            this.Name = "FormConnexion";
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.Label labelPseudonymeCP;
        private System.Windows.Forms.TextBox textBoxPseudonyme;
        private System.Windows.Forms.TextBox textBoxMotdePasse;
        private System.Windows.Forms.Label labelMotDePasseCP;
        private System.Windows.Forms.Button buttonNouveauCompte;
    }
}

