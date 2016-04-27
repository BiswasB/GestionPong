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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNumeroTournoi = new System.Windows.Forms.Label();
            this.labelRonde = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAbandonner = new System.Windows.Forms.Button();
            this.buttonPret = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ronde actuelle : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "# Tournoi :";
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
            // labelRonde
            // 
            this.labelRonde.AutoSize = true;
            this.labelRonde.Location = new System.Drawing.Point(99, 44);
            this.labelRonde.Name = "labelRonde";
            this.labelRonde.Size = new System.Drawing.Size(13, 13);
            this.labelRonde.TabIndex = 3;
            this.labelRonde.Text = "1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(502, 260);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Compteur :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "00:00";
            // 
            // FormTournoiActif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 404);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonPret);
            this.Controls.Add(this.buttonAbandonner);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelRonde);
            this.Controls.Add(this.labelNumeroTournoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTournoiActif";
            this.Text = "Tournoi actif";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNumeroTournoi;
        private System.Windows.Forms.Label labelRonde;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAbandonner;
        private System.Windows.Forms.Button buttonPret;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}