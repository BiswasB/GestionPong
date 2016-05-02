namespace GestionPong
{
    partial class FormTournoiActif
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
            this.labelRondeActuelleCP = new System.Windows.Forms.Label();
            this.labelNumeroTournoiCP = new System.Windows.Forms.Label();
            this.labelNumeroTournoi = new System.Windows.Forms.Label();
            this.labelRondeActuelle = new System.Windows.Forms.Label();
            this.pictureBoxTournoiActif = new System.Windows.Forms.PictureBox();
            this.buttonAbandonner = new System.Windows.Forms.Button();
            this.buttonPret = new System.Windows.Forms.Button();
            this.labelCompteurCP = new System.Windows.Forms.Label();
            this.labelCompteur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTournoiActif)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRondeActuelleCP
            // 
            this.labelRondeActuelleCP.AutoSize = true;
            this.labelRondeActuelleCP.Location = new System.Drawing.Point(12, 44);
            this.labelRondeActuelleCP.Name = "labelRondeActuelleCP";
            this.labelRondeActuelleCP.Size = new System.Drawing.Size(88, 13);
            this.labelRondeActuelleCP.TabIndex = 0;
            this.labelRondeActuelleCP.Text = "Ronde actuelle : ";
            // 
            // labelNumeroTournoiCP
            // 
            this.labelNumeroTournoiCP.AutoSize = true;
            this.labelNumeroTournoiCP.Location = new System.Drawing.Point(13, 13);
            this.labelNumeroTournoiCP.Name = "labelNumeroTournoiCP";
            this.labelNumeroTournoiCP.Size = new System.Drawing.Size(59, 13);
            this.labelNumeroTournoiCP.TabIndex = 1;
            this.labelNumeroTournoiCP.Text = "# Tournoi :";
            // 
            // labelNumeroTournoi
            // 
            this.labelNumeroTournoi.AutoSize = true;
            this.labelNumeroTournoi.Location = new System.Drawing.Point(99, 13);
            this.labelNumeroTournoi.Name = "labelNumeroTournoi";
            this.labelNumeroTournoi.Size = new System.Drawing.Size(13, 13);
            this.labelNumeroTournoi.TabIndex = 2;
            this.labelNumeroTournoi.Text = "1";
            // 
            // labelRondeActuelle
            // 
            this.labelRondeActuelle.AutoSize = true;
            this.labelRondeActuelle.Location = new System.Drawing.Point(99, 44);
            this.labelRondeActuelle.Name = "labelRondeActuelle";
            this.labelRondeActuelle.Size = new System.Drawing.Size(13, 13);
            this.labelRondeActuelle.TabIndex = 3;
            this.labelRondeActuelle.Text = "1";
            // 
            // pictureBoxTournoiActif
            // 
            this.pictureBoxTournoiActif.Location = new System.Drawing.Point(16, 89);
            this.pictureBoxTournoiActif.Name = "pictureBoxTournoiActif";
            this.pictureBoxTournoiActif.Size = new System.Drawing.Size(502, 260);
            this.pictureBoxTournoiActif.TabIndex = 4;
            this.pictureBoxTournoiActif.TabStop = false;
            // 
            // buttonAbandonner
            // 
            this.buttonAbandonner.Location = new System.Drawing.Point(16, 356);
            this.buttonAbandonner.Name = "buttonAbandonner";
            this.buttonAbandonner.Size = new System.Drawing.Size(123, 28);
            this.buttonAbandonner.TabIndex = 5;
            this.buttonAbandonner.Text = "Déclarer forfait";
            this.buttonAbandonner.UseVisualStyleBackColor = true;
            this.buttonAbandonner.Click += new System.EventHandler(this.buttonAbandonner_Click);
            // 
            // buttonPret
            // 
            this.buttonPret.Location = new System.Drawing.Point(395, 356);
            this.buttonPret.Name = "buttonPret";
            this.buttonPret.Size = new System.Drawing.Size(123, 28);
            this.buttonPret.TabIndex = 6;
            this.buttonPret.Text = "Prêt";
            this.buttonPret.UseVisualStyleBackColor = true;
            // 
            // labelCompteurCP
            // 
            this.labelCompteurCP.AutoSize = true;
            this.labelCompteurCP.Location = new System.Drawing.Point(274, 364);
            this.labelCompteurCP.Name = "labelCompteurCP";
            this.labelCompteurCP.Size = new System.Drawing.Size(58, 13);
            this.labelCompteurCP.TabIndex = 7;
            this.labelCompteurCP.Text = "Compteur :";
            // 
            // labelCompteur
            // 
            this.labelCompteur.AutoSize = true;
            this.labelCompteur.Location = new System.Drawing.Point(338, 364);
            this.labelCompteur.Name = "labelCompteur";
            this.labelCompteur.Size = new System.Drawing.Size(34, 13);
            this.labelCompteur.TabIndex = 8;
            this.labelCompteur.Text = "00:00";
            // 
            // FormTournoiActif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 404);
            this.Controls.Add(this.labelCompteur);
            this.Controls.Add(this.labelCompteurCP);
            this.Controls.Add(this.buttonPret);
            this.Controls.Add(this.buttonAbandonner);
            this.Controls.Add(this.pictureBoxTournoiActif);
            this.Controls.Add(this.labelRondeActuelle);
            this.Controls.Add(this.labelNumeroTournoi);
            this.Controls.Add(this.labelNumeroTournoiCP);
            this.Controls.Add(this.labelRondeActuelleCP);
            this.Name = "FormTournoiActif";
            this.Text = "Tournoi actif";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTournoiActif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRondeActuelleCP;
        private System.Windows.Forms.Label labelNumeroTournoiCP;
        private System.Windows.Forms.Label labelNumeroTournoi;
        private System.Windows.Forms.Label labelRondeActuelle;
        private System.Windows.Forms.PictureBox pictureBoxTournoiActif;
        private System.Windows.Forms.Button buttonAbandonner;
        private System.Windows.Forms.Button buttonPret;
        private System.Windows.Forms.Label labelCompteurCP;
        private System.Windows.Forms.Label labelCompteur;
    }
}