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
            this.components = new System.ComponentModel.Container();
            this.labelPartiesRestantesCP = new System.Windows.Forms.Label();
            this.labelPartiesRestantes = new System.Windows.Forms.Label();
            this.labelJoursPremiumRestants = new System.Windows.Forms.Label();
            this.labelPremiumCP = new System.Windows.Forms.Label();
            this.labelJoursCP = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelCouleurPaletteCP = new System.Windows.Forms.Label();
            this.joueursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPong = new GestionPong.DataSetPong();
            this.couleurplaquetteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.couleurplaquetteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.couleurplaquetteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.couleurplaquetteTableAdapter = new GestionPong.DataSetPongTableAdapters.couleurplaquetteTableAdapter();
            this.joueursTableAdapter = new GestionPong.DataSetPongTableAdapters.joueursTableAdapter();
            this.fKIDCouleurPlaquetteJoueursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.joueursBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.labelCouleurPalette = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.joueursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.couleurplaquetteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.couleurplaquetteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.couleurplaquetteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKIDCouleurPlaquetteJoueursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joueursBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPartiesRestantesCP
            // 
            this.labelPartiesRestantesCP.AutoSize = true;
            this.labelPartiesRestantesCP.Location = new System.Drawing.Point(12, 9);
            this.labelPartiesRestantesCP.Name = "labelPartiesRestantesCP";
            this.labelPartiesRestantesCP.Size = new System.Drawing.Size(145, 13);
            this.labelPartiesRestantesCP.TabIndex = 0;
            this.labelPartiesRestantesCP.Text = "Nombre de parties restantes :";
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
            // labelPremiumCP
            // 
            this.labelPremiumCP.AutoSize = true;
            this.labelPremiumCP.Location = new System.Drawing.Point(12, 46);
            this.labelPremiumCP.Name = "labelPremiumCP";
            this.labelPremiumCP.Size = new System.Drawing.Size(207, 13);
            this.labelPremiumCP.TabIndex = 2;
            this.labelPremiumCP.Text = "Durée restante de l\'abonnement Premium :";
            // 
            // labelJoursCP
            // 
            this.labelJoursCP.AutoSize = true;
            this.labelJoursCP.Location = new System.Drawing.Point(255, 46);
            this.labelJoursCP.Name = "labelJoursCP";
            this.labelJoursCP.Size = new System.Drawing.Size(32, 13);
            this.labelJoursCP.TabIndex = 4;
            this.labelJoursCP.Text = "Jours";
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
            // labelCouleurPaletteCP
            // 
            this.labelCouleurPaletteCP.AutoSize = true;
            this.labelCouleurPaletteCP.Location = new System.Drawing.Point(14, 88);
            this.labelCouleurPaletteCP.Name = "labelCouleurPaletteCP";
            this.labelCouleurPaletteCP.Size = new System.Drawing.Size(163, 13);
            this.labelCouleurPaletteCP.TabIndex = 6;
            this.labelCouleurPaletteCP.Text = "Changer la couleur de la palette :";
            // 
            // joueursBindingSource
            // 
            this.joueursBindingSource.DataMember = "joueurs";
            this.joueursBindingSource.DataSource = this.dataSetPong;
            // 
            // dataSetPong
            // 
            this.dataSetPong.DataSetName = "DataSetPong";
            this.dataSetPong.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // couleurplaquetteBindingSource2
            // 
            this.couleurplaquetteBindingSource2.DataMember = "couleurplaquette";
            this.couleurplaquetteBindingSource2.DataSource = this.dataSetPong;
            // 
            // couleurplaquetteBindingSource1
            // 
            this.couleurplaquetteBindingSource1.DataMember = "couleurplaquette";
            this.couleurplaquetteBindingSource1.DataSource = this.dataSetPongBindingSource;
            // 
            // dataSetPongBindingSource
            // 
            this.dataSetPongBindingSource.DataSource = this.dataSetPong;
            this.dataSetPongBindingSource.Position = 0;
            // 
            // couleurplaquetteBindingSource
            // 
            this.couleurplaquetteBindingSource.DataMember = "couleurplaquette";
            this.couleurplaquetteBindingSource.DataSource = this.dataSetPongBindingSource;
            // 
            // couleurplaquetteTableAdapter
            // 
            this.couleurplaquetteTableAdapter.ClearBeforeFill = true;
            // 
            // joueursTableAdapter
            // 
            this.joueursTableAdapter.ClearBeforeFill = true;
            // 
            // fKIDCouleurPlaquetteJoueursBindingSource
            // 
            this.fKIDCouleurPlaquetteJoueursBindingSource.DataMember = "FK_ID_CouleurPlaquette_Joueurs";
            this.fKIDCouleurPlaquetteJoueursBindingSource.DataSource = this.couleurplaquetteBindingSource1;
            // 
            // joueursBindingSource1
            // 
            this.joueursBindingSource1.DataMember = "joueurs";
            this.joueursBindingSource1.DataSource = this.dataSetPong;
            // 
            // labelCouleurPalette
            // 
            this.labelCouleurPalette.AutoSize = true;
            this.labelCouleurPalette.Location = new System.Drawing.Point(183, 88);
            this.labelCouleurPalette.Name = "labelCouleurPalette";
            this.labelCouleurPalette.Size = new System.Drawing.Size(0, 13);
            this.labelCouleurPalette.TabIndex = 7;
            // 
            // FormEtatCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 167);
            this.Controls.Add(this.labelCouleurPalette);
            this.Controls.Add(this.labelCouleurPaletteCP);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelJoursCP);
            this.Controls.Add(this.labelJoursPremiumRestants);
            this.Controls.Add(this.labelPremiumCP);
            this.Controls.Add(this.labelPartiesRestantes);
            this.Controls.Add(this.labelPartiesRestantesCP);
            this.Name = "FormEtatCompte";
            this.Text = "État du compte";
            this.Load += new System.EventHandler(this.FormEtatCompte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.joueursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.couleurplaquetteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.couleurplaquetteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.couleurplaquetteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKIDCouleurPlaquetteJoueursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joueursBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPartiesRestantesCP;
        private System.Windows.Forms.Label labelPartiesRestantes;
        private System.Windows.Forms.Label labelJoursPremiumRestants;
        private System.Windows.Forms.Label labelPremiumCP;
        private System.Windows.Forms.Label labelJoursCP;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelCouleurPaletteCP;
        private System.Windows.Forms.BindingSource dataSetPongBindingSource;
        private DataSetPong dataSetPong;
        private System.Windows.Forms.BindingSource couleurplaquetteBindingSource;
        private DataSetPongTableAdapters.couleurplaquetteTableAdapter couleurplaquetteTableAdapter;
        private System.Windows.Forms.BindingSource joueursBindingSource;
        private DataSetPongTableAdapters.joueursTableAdapter joueursTableAdapter;
        private System.Windows.Forms.BindingSource couleurplaquetteBindingSource1;
        private System.Windows.Forms.BindingSource couleurplaquetteBindingSource2;
        private System.Windows.Forms.BindingSource fKIDCouleurPlaquetteJoueursBindingSource;
        private System.Windows.Forms.BindingSource joueursBindingSource1;
        private System.Windows.Forms.Label labelCouleurPalette;
    }
}