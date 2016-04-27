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
            this.label1 = new System.Windows.Forms.Label();
            this.labelTournoisJoues = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de tournoi joués :";
            // 
            // labelTournoisJoues
            // 
            this.labelTournoisJoues.AutoSize = true;
            this.labelTournoisJoues.Location = new System.Drawing.Point(171, 13);
            this.labelTournoisJoues.Name = "labelTournoisJoues";
            this.labelTournoisJoues.Size = new System.Drawing.Size(13, 13);
            this.labelTournoisJoues.TabIndex = 2;
            this.labelTournoisJoues.Text = "0";
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
            this.Controls.Add(this.labelTournoisJoues);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInscrire);
            this.Name = "FormTournoi";
            this.Text = "Tournoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInscrire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTournoisJoues;
        private System.Windows.Forms.Button buttonTournoiActif;
        private System.Windows.Forms.Button buttonOK;
    }
}