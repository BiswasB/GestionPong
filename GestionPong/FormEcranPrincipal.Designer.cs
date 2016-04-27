namespace GestionPong
{
    partial class FormEcranPrincipal
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
            this.buttonDeconnexion = new System.Windows.Forms.Button();
            this.buttonModifierCompte = new System.Windows.Forms.Button();
            this.buttonCarteCredit = new System.Windows.Forms.Button();
            this.buttonForfaits = new System.Windows.Forms.Button();
            this.buttonEtatCompte = new System.Windows.Forms.Button();
            this.buttonPartieRapide = new System.Windows.Forms.Button();
            this.buttonTournois = new System.Windows.Forms.Button();
            this.buttonEquipe = new System.Windows.Forms.Button();
            this.buttonHistorique = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDeconnexion
            // 
            this.buttonDeconnexion.Location = new System.Drawing.Point(287, 221);
            this.buttonDeconnexion.Name = "buttonDeconnexion";
            this.buttonDeconnexion.Size = new System.Drawing.Size(87, 33);
            this.buttonDeconnexion.TabIndex = 0;
            this.buttonDeconnexion.Text = "Déconnexion";
            this.buttonDeconnexion.UseVisualStyleBackColor = true;
            this.buttonDeconnexion.Click += new System.EventHandler(this.buttonDeconnexion_Click);
            // 
            // buttonModifierCompte
            // 
            this.buttonModifierCompte.Location = new System.Drawing.Point(12, 12);
            this.buttonModifierCompte.Name = "buttonModifierCompte";
            this.buttonModifierCompte.Size = new System.Drawing.Size(143, 33);
            this.buttonModifierCompte.TabIndex = 1;
            this.buttonModifierCompte.Text = "Modifier le compte";
            this.buttonModifierCompte.UseVisualStyleBackColor = true;
            this.buttonModifierCompte.Click += new System.EventHandler(this.buttonModifierCompte_Click);
            // 
            // buttonCarteCredit
            // 
            this.buttonCarteCredit.Location = new System.Drawing.Point(12, 63);
            this.buttonCarteCredit.Name = "buttonCarteCredit";
            this.buttonCarteCredit.Size = new System.Drawing.Size(143, 33);
            this.buttonCarteCredit.TabIndex = 2;
            this.buttonCarteCredit.Text = "Gérer les cartes de crédit";
            this.buttonCarteCredit.UseVisualStyleBackColor = true;
            this.buttonCarteCredit.Click += new System.EventHandler(this.buttonCarteCredit_Click);
            // 
            // buttonForfaits
            // 
            this.buttonForfaits.Location = new System.Drawing.Point(12, 111);
            this.buttonForfaits.Name = "buttonForfaits";
            this.buttonForfaits.Size = new System.Drawing.Size(143, 33);
            this.buttonForfaits.TabIndex = 3;
            this.buttonForfaits.Text = "Acheter des forfaits";
            this.buttonForfaits.UseVisualStyleBackColor = true;
            this.buttonForfaits.Click += new System.EventHandler(this.buttonForfaits_Click);
            // 
            // buttonEtatCompte
            // 
            this.buttonEtatCompte.Location = new System.Drawing.Point(12, 162);
            this.buttonEtatCompte.Name = "buttonEtatCompte";
            this.buttonEtatCompte.Size = new System.Drawing.Size(143, 33);
            this.buttonEtatCompte.TabIndex = 4;
            this.buttonEtatCompte.Text = "État du compte";
            this.buttonEtatCompte.UseVisualStyleBackColor = true;
            this.buttonEtatCompte.Click += new System.EventHandler(this.buttonEtatCompte_Click);
            // 
            // buttonPartieRapide
            // 
            this.buttonPartieRapide.Location = new System.Drawing.Point(207, 12);
            this.buttonPartieRapide.Name = "buttonPartieRapide";
            this.buttonPartieRapide.Size = new System.Drawing.Size(143, 33);
            this.buttonPartieRapide.TabIndex = 5;
            this.buttonPartieRapide.Text = "Partie rapide";
            this.buttonPartieRapide.UseVisualStyleBackColor = true;
            // 
            // buttonTournois
            // 
            this.buttonTournois.Location = new System.Drawing.Point(207, 63);
            this.buttonTournois.Name = "buttonTournois";
            this.buttonTournois.Size = new System.Drawing.Size(143, 33);
            this.buttonTournois.TabIndex = 6;
            this.buttonTournois.Text = "Tournois";
            this.buttonTournois.UseVisualStyleBackColor = true;
            this.buttonTournois.Click += new System.EventHandler(this.buttonTournois_Click);
            // 
            // buttonEquipe
            // 
            this.buttonEquipe.Location = new System.Drawing.Point(207, 111);
            this.buttonEquipe.Name = "buttonEquipe";
            this.buttonEquipe.Size = new System.Drawing.Size(143, 33);
            this.buttonEquipe.TabIndex = 7;
            this.buttonEquipe.Text = "Équipe";
            this.buttonEquipe.UseVisualStyleBackColor = true;
            this.buttonEquipe.Click += new System.EventHandler(this.buttonEquipe_Click);
            // 
            // buttonHistorique
            // 
            this.buttonHistorique.Location = new System.Drawing.Point(207, 162);
            this.buttonHistorique.Name = "buttonHistorique";
            this.buttonHistorique.Size = new System.Drawing.Size(143, 33);
            this.buttonHistorique.TabIndex = 8;
            this.buttonHistorique.Text = "Historique des parties";
            this.buttonHistorique.UseVisualStyleBackColor = true;
            this.buttonHistorique.Click += new System.EventHandler(this.buttonHistorique_Click);
            // 
            // FormEcranPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 270);
            this.Controls.Add(this.buttonHistorique);
            this.Controls.Add(this.buttonEquipe);
            this.Controls.Add(this.buttonTournois);
            this.Controls.Add(this.buttonPartieRapide);
            this.Controls.Add(this.buttonEtatCompte);
            this.Controls.Add(this.buttonForfaits);
            this.Controls.Add(this.buttonCarteCredit);
            this.Controls.Add(this.buttonModifierCompte);
            this.Controls.Add(this.buttonDeconnexion);
            this.Name = "FormEcranPrincipal";
            this.Text = "Écran Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDeconnexion;
        private System.Windows.Forms.Button buttonModifierCompte;
        private System.Windows.Forms.Button buttonCarteCredit;
        private System.Windows.Forms.Button buttonForfaits;
        private System.Windows.Forms.Button buttonEtatCompte;
        private System.Windows.Forms.Button buttonPartieRapide;
        private System.Windows.Forms.Button buttonTournois;
        private System.Windows.Forms.Button buttonEquipe;
        private System.Windows.Forms.Button buttonHistorique;
    }
}