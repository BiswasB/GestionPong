namespace GestionPong
{
    partial class FormInviterJoueur
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
            this.textBoxNomJoueur = new System.Windows.Forms.TextBox();
            this.buttonInviter = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du joueur :";
            // 
            // textBoxNomJoueur
            // 
            this.textBoxNomJoueur.Location = new System.Drawing.Point(101, 10);
            this.textBoxNomJoueur.Name = "textBoxNomJoueur";
            this.textBoxNomJoueur.Size = new System.Drawing.Size(151, 20);
            this.textBoxNomJoueur.TabIndex = 1;
            // 
            // buttonInviter
            // 
            this.buttonInviter.Location = new System.Drawing.Point(16, 52);
            this.buttonInviter.Name = "buttonInviter";
            this.buttonInviter.Size = new System.Drawing.Size(236, 23);
            this.buttonInviter.TabIndex = 2;
            this.buttonInviter.Text = "Inviter";
            this.buttonInviter.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(15, 81);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(236, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormInviterJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 116);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonInviter);
            this.Controls.Add(this.textBoxNomJoueur);
            this.Controls.Add(this.label1);
            this.Name = "FormInviterJoueur";
            this.Text = "FormInviterJoueur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNomJoueur;
        private System.Windows.Forms.Button buttonInviter;
        private System.Windows.Forms.Button buttonOK;
    }
}