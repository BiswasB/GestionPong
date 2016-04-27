namespace GestionPong
{
    partial class FormEquipe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonInviter = new System.Windows.Forms.Button();
            this.labelPointage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewJoueurs = new System.Windows.Forms.DataGridView();
            this.labelNomEquipe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonQuitterEquipe = new System.Windows.Forms.Button();
            this.buttonCreer = new System.Windows.Forms.Button();
            this.buttonVoirInvitations = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJoueurs)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelDescription);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonInviter);
            this.groupBox1.Controls.Add(this.labelPointage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataGridViewJoueurs);
            this.groupBox1.Controls.Add(this.labelNomEquipe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 341);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Équipe Actuelle";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(79, 51);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 6;
            this.labelDescription.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Description :";
            // 
            // buttonInviter
            // 
            this.buttonInviter.Location = new System.Drawing.Point(10, 309);
            this.buttonInviter.Name = "buttonInviter";
            this.buttonInviter.Size = new System.Drawing.Size(240, 23);
            this.buttonInviter.TabIndex = 4;
            this.buttonInviter.Text = "Inviter un joueur";
            this.buttonInviter.UseVisualStyleBackColor = true;
            this.buttonInviter.Click += new System.EventHandler(this.buttonInviter_Click);
            // 
            // labelPointage
            // 
            this.labelPointage.AutoSize = true;
            this.labelPointage.Location = new System.Drawing.Point(68, 284);
            this.labelPointage.Name = "labelPointage";
            this.labelPointage.Size = new System.Drawing.Size(13, 13);
            this.labelPointage.TabIndex = 4;
            this.labelPointage.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pointage :";
            // 
            // dataGridViewJoueurs
            // 
            this.dataGridViewJoueurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJoueurs.Location = new System.Drawing.Point(10, 106);
            this.dataGridViewJoueurs.Name = "dataGridViewJoueurs";
            this.dataGridViewJoueurs.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewJoueurs.TabIndex = 2;
            // 
            // labelNomEquipe
            // 
            this.labelNomEquipe.AutoSize = true;
            this.labelNomEquipe.Location = new System.Drawing.Point(49, 20);
            this.labelNomEquipe.Name = "labelNomEquipe";
            this.labelNomEquipe.Size = new System.Drawing.Size(121, 13);
            this.labelNomEquipe.TabIndex = 1;
            this.labelNomEquipe.Text = "Les champions du Pong";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // buttonQuitterEquipe
            // 
            this.buttonQuitterEquipe.Location = new System.Drawing.Point(13, 360);
            this.buttonQuitterEquipe.Name = "buttonQuitterEquipe";
            this.buttonQuitterEquipe.Size = new System.Drawing.Size(259, 23);
            this.buttonQuitterEquipe.TabIndex = 1;
            this.buttonQuitterEquipe.Text = "Quitter l\'équipe";
            this.buttonQuitterEquipe.UseVisualStyleBackColor = true;
            // 
            // buttonCreer
            // 
            this.buttonCreer.Location = new System.Drawing.Point(13, 390);
            this.buttonCreer.Name = "buttonCreer";
            this.buttonCreer.Size = new System.Drawing.Size(124, 23);
            this.buttonCreer.TabIndex = 2;
            this.buttonCreer.Text = "Créer une équipe";
            this.buttonCreer.UseVisualStyleBackColor = true;
            this.buttonCreer.Click += new System.EventHandler(this.buttonCreer_Click);
            // 
            // buttonVoirInvitations
            // 
            this.buttonVoirInvitations.Location = new System.Drawing.Point(143, 389);
            this.buttonVoirInvitations.Name = "buttonVoirInvitations";
            this.buttonVoirInvitations.Size = new System.Drawing.Size(128, 23);
            this.buttonVoirInvitations.TabIndex = 3;
            this.buttonVoirInvitations.Text = "Voir mes invitations";
            this.buttonVoirInvitations.UseVisualStyleBackColor = true;
            this.buttonVoirInvitations.Click += new System.EventHandler(this.buttonVoirInvitations_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(12, 419);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(259, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 449);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonVoirInvitations);
            this.Controls.Add(this.buttonCreer);
            this.Controls.Add(this.buttonQuitterEquipe);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormEquipe";
            this.Text = "Équipe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJoueurs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonInviter;
        private System.Windows.Forms.Label labelPointage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewJoueurs;
        private System.Windows.Forms.Label labelNomEquipe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonQuitterEquipe;
        private System.Windows.Forms.Button buttonCreer;
        private System.Windows.Forms.Button buttonVoirInvitations;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonOK;
    }
}