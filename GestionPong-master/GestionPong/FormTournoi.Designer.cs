namespace GestionPong
{
    partial class FormTournoi
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
            this.buttonInscrire = new System.Windows.Forms.Button();
            this.labelNombreDeTournoisJouesCP = new System.Windows.Forms.Label();
            this.labelNombreDeTournoisJoues = new System.Windows.Forms.Label();
            this.buttonTournoiActif = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInscrire
            // 
            this.buttonInscrire.Location = new System.Drawing.Point(12, 40);
            this.buttonInscrire.Name = "buttonInscrire";
            this.buttonInscrire.Size = new System.Drawing.Size(172, 30);
            this.buttonInscrire.TabIndex = 0;
            this.buttonInscrire.Text = "S\'inscrire à un nouveau tournoi";
            this.buttonInscrire.UseVisualStyleBackColor = true;
            // 
            // labelNombreDeTournoisJouesCP
            // 
            this.labelNombreDeTournoisJouesCP.AutoSize = true;
            this.labelNombreDeTournoisJouesCP.Location = new System.Drawing.Point(13, 13);
            this.labelNombreDeTournoisJouesCP.Name = "labelNombreDeTournoisJouesCP";
            this.labelNombreDeTournoisJouesCP.Size = new System.Drawing.Size(128, 13);
            this.labelNombreDeTournoisJouesCP.TabIndex = 1;
            this.labelNombreDeTournoisJouesCP.Text = "Nombre de tournoi joués :";
            // 
            // labelNombreDeTournoisJoues
            // 
            this.labelNombreDeTournoisJoues.AutoSize = true;
            this.labelNombreDeTournoisJoues.Location = new System.Drawing.Point(171, 13);
            this.labelNombreDeTournoisJoues.Name = "labelNombreDeTournoisJoues";
            this.labelNombreDeTournoisJoues.Size = new System.Drawing.Size(13, 13);
            this.labelNombreDeTournoisJoues.TabIndex = 2;
            this.labelNombreDeTournoisJoues.Text = "0";
            // 
            // buttonTournoiActif
            // 
            this.buttonTournoiActif.Location = new System.Drawing.Point(12, 84);
            this.buttonTournoiActif.Name = "buttonTournoiActif";
            this.buttonTournoiActif.Size = new System.Drawing.Size(172, 30);
            this.buttonTournoiActif.TabIndex = 3;
            this.buttonTournoiActif.Text = "Voir le tournoi actif";
            this.buttonTournoiActif.UseVisualStyleBackColor = true;
            this.buttonTournoiActif.Click += new System.EventHandler(this.buttonTournoiActif_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(12, 120);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(172, 30);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormTournoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 164);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonTournoiActif);
            this.Controls.Add(this.labelNombreDeTournoisJoues);
            this.Controls.Add(this.labelNombreDeTournoisJouesCP);
            this.Controls.Add(this.buttonInscrire);
            this.Name = "FormTournoi";
            this.Text = "Tournoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInscrire;
        private System.Windows.Forms.Label labelNombreDeTournoisJouesCP;
        private System.Windows.Forms.Label labelNombreDeTournoisJoues;
        private System.Windows.Forms.Button buttonTournoiActif;
        private System.Windows.Forms.Button buttonOK;
    }
}