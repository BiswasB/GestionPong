namespace GestionPong
{
    partial class FormEtatCompte
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
            this.labelPartiesRestantes = new System.Windows.Forms.Label();
            this.labelJoursPremiumRestants = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de parties restantes :";
            // 
            // labelPartiesRestantes
            // 
            this.labelPartiesRestantes.AutoSize = true;
            this.labelPartiesRestantes.Location = new System.Drawing.Point(163, 9);
            this.labelPartiesRestantes.Name = "labelPartiesRestantes";
            this.labelPartiesRestantes.Size = new System.Drawing.Size(13, 13);
            this.labelPartiesRestantes.TabIndex = 1;
            this.labelPartiesRestantes.Text = "0";
            // 
            // labelJoursPremiumRestants
            // 
            this.labelJoursPremiumRestants.AutoSize = true;
            this.labelJoursPremiumRestants.Location = new System.Drawing.Point(225, 46);
            this.labelJoursPremiumRestants.Name = "labelJoursPremiumRestants";
            this.labelJoursPremiumRestants.Size = new System.Drawing.Size(13, 13);
            this.labelJoursPremiumRestants.TabIndex = 3;
            this.labelJoursPremiumRestants.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Durée restante de l\'abonnement Premium :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jours";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(17, 127);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(272, 23);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Changer la couleur de la palette :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(183, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // FormEtatCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 167);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelJoursPremiumRestants);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPartiesRestantes);
            this.Controls.Add(this.label1);
            this.Name = "FormEtatCompte";
            this.Text = "État du compte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPartiesRestantes;
        private System.Windows.Forms.Label labelJoursPremiumRestants;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}