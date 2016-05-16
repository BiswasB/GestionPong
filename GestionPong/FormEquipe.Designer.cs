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
            this.components = new System.ComponentModel.Container();
            this.groupBoxEquipeActuelle = new System.Windows.Forms.GroupBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelDescriptionCP = new System.Windows.Forms.Label();
            this.buttonInviter = new System.Windows.Forms.Button();
            this.labelPointage = new System.Windows.Forms.Label();
            this.labelPointageCP = new System.Windows.Forms.Label();
            this.dataGridViewJoueurs = new System.Windows.Forms.DataGridView();
            this.labelNomEquipe = new System.Windows.Forms.Label();
            this.labelNomCP = new System.Windows.Forms.Label();
            this.buttonQuitterEquipe = new System.Windows.Forms.Button();
            this.buttonCreer = new System.Windows.Forms.Button();
            this.buttonVoirInvitations = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonRafraichir = new System.Windows.Forms.Button();
            this.fKIDEquipesJoueursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKIDEquipesJoueursBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.joueursBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPong = new GestionPong.DataSetPong();
            this.equipesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.joueursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.joueursTableAdapter = new GestionPong.DataSetPongTableAdapters.joueursTableAdapter();
            this.equipesTableAdapter = new GestionPong.DataSetPongTableAdapters.equipesTableAdapter();
            this.pseudonymeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxEquipeActuelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJoueurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKIDEquipesJoueursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKIDEquipesJoueursBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joueursBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joueursBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxEquipeActuelle
            // 
            this.groupBoxEquipeActuelle.Controls.Add(this.buttonRafraichir);
            this.groupBoxEquipeActuelle.Controls.Add(this.labelDescription);
            this.groupBoxEquipeActuelle.Controls.Add(this.labelDescriptionCP);
            this.groupBoxEquipeActuelle.Controls.Add(this.buttonInviter);
            this.groupBoxEquipeActuelle.Controls.Add(this.labelPointage);
            this.groupBoxEquipeActuelle.Controls.Add(this.labelPointageCP);
            this.groupBoxEquipeActuelle.Controls.Add(this.dataGridViewJoueurs);
            this.groupBoxEquipeActuelle.Controls.Add(this.labelNomEquipe);
            this.groupBoxEquipeActuelle.Controls.Add(this.labelNomCP);
            this.groupBoxEquipeActuelle.Location = new System.Drawing.Point(13, 13);
            this.groupBoxEquipeActuelle.Name = "groupBoxEquipeActuelle";
            this.groupBoxEquipeActuelle.Size = new System.Drawing.Size(259, 341);
            this.groupBoxEquipeActuelle.TabIndex = 0;
            this.groupBoxEquipeActuelle.TabStop = false;
            this.groupBoxEquipeActuelle.Text = "Équipe Actuelle";
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
            // labelDescriptionCP
            // 
            this.labelDescriptionCP.AutoSize = true;
            this.labelDescriptionCP.Location = new System.Drawing.Point(7, 51);
            this.labelDescriptionCP.Name = "labelDescriptionCP";
            this.labelDescriptionCP.Size = new System.Drawing.Size(66, 13);
            this.labelDescriptionCP.TabIndex = 5;
            this.labelDescriptionCP.Text = "Description :";
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
            // labelPointageCP
            // 
            this.labelPointageCP.AutoSize = true;
            this.labelPointageCP.Location = new System.Drawing.Point(7, 284);
            this.labelPointageCP.Name = "labelPointageCP";
            this.labelPointageCP.Size = new System.Drawing.Size(55, 13);
            this.labelPointageCP.TabIndex = 3;
            this.labelPointageCP.Text = "Pointage :";
            // 
            // dataGridViewJoueurs
            // 
            this.dataGridViewJoueurs.AllowUserToAddRows = false;
            this.dataGridViewJoueurs.AllowUserToDeleteRows = false;
            this.dataGridViewJoueurs.AutoGenerateColumns = false;
            this.dataGridViewJoueurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJoueurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pseudonymeDataGridViewTextBoxColumn});
            this.dataGridViewJoueurs.DataSource = this.joueursBindingSource1;
            this.dataGridViewJoueurs.Location = new System.Drawing.Point(10, 106);
            this.dataGridViewJoueurs.Name = "dataGridViewJoueurs";
            this.dataGridViewJoueurs.ReadOnly = true;
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
            // labelNomCP
            // 
            this.labelNomCP.AutoSize = true;
            this.labelNomCP.Location = new System.Drawing.Point(7, 20);
            this.labelNomCP.Name = "labelNomCP";
            this.labelNomCP.Size = new System.Drawing.Size(35, 13);
            this.labelNomCP.TabIndex = 0;
            this.labelNomCP.Text = "Nom :";
            // 
            // buttonQuitterEquipe
            // 
            this.buttonQuitterEquipe.Location = new System.Drawing.Point(13, 360);
            this.buttonQuitterEquipe.Name = "buttonQuitterEquipe";
            this.buttonQuitterEquipe.Size = new System.Drawing.Size(259, 23);
            this.buttonQuitterEquipe.TabIndex = 1;
            this.buttonQuitterEquipe.Text = "Quitter l\'équipe";
            this.buttonQuitterEquipe.UseVisualStyleBackColor = true;
            this.buttonQuitterEquipe.Click += new System.EventHandler(this.buttonQuitterEquipe_Click);
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
            // buttonRafraichir
            // 
            this.buttonRafraichir.Location = new System.Drawing.Point(10, 77);
            this.buttonRafraichir.Name = "buttonRafraichir";
            this.buttonRafraichir.Size = new System.Drawing.Size(74, 23);
            this.buttonRafraichir.TabIndex = 7;
            this.buttonRafraichir.Text = "Rafraîchir";
            this.buttonRafraichir.UseVisualStyleBackColor = true;
            this.buttonRafraichir.Click += new System.EventHandler(this.buttonRafraichir_Click);
            // 
            // fKIDEquipesJoueursBindingSource
            // 
            this.fKIDEquipesJoueursBindingSource.DataMember = "FK_ID_Equipes_Joueurs";
            this.fKIDEquipesJoueursBindingSource.DataSource = this.equipesBindingSource;
            // 
            // fKIDEquipesJoueursBindingSource1
            // 
            this.fKIDEquipesJoueursBindingSource1.DataMember = "FK_ID_Equipes_Joueurs";
            this.fKIDEquipesJoueursBindingSource1.DataSource = this.equipesBindingSource;
            // 
            // joueursBindingSource1
            // 
            this.joueursBindingSource1.DataMember = "joueurs";
            this.joueursBindingSource1.DataSource = this.dataSetPong;
            // 
            // dataSetPong
            // 
            this.dataSetPong.DataSetName = "DataSetPong";
            this.dataSetPong.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipesBindingSource
            // 
            this.equipesBindingSource.DataMember = "equipes";
            this.equipesBindingSource.DataSource = this.dataSetPong;
            // 
            // joueursBindingSource
            // 
            this.joueursBindingSource.DataMember = "joueurs";
            this.joueursBindingSource.DataSource = this.dataSetPong;
            // 
            // joueursTableAdapter
            // 
            this.joueursTableAdapter.ClearBeforeFill = true;
            // 
            // equipesTableAdapter
            // 
            this.equipesTableAdapter.ClearBeforeFill = true;
            // 
            // pseudonymeDataGridViewTextBoxColumn
            // 
            this.pseudonymeDataGridViewTextBoxColumn.DataPropertyName = "Pseudonyme";
            this.pseudonymeDataGridViewTextBoxColumn.HeaderText = "Joueurs";
            this.pseudonymeDataGridViewTextBoxColumn.Name = "pseudonymeDataGridViewTextBoxColumn";
            this.pseudonymeDataGridViewTextBoxColumn.ReadOnly = true;
            this.pseudonymeDataGridViewTextBoxColumn.Width = 180;
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
            this.Controls.Add(this.groupBoxEquipeActuelle);
            this.Name = "FormEquipe";
            this.Text = "Équipe";
            this.Load += new System.EventHandler(this.FormEquipe_Load);
            this.groupBoxEquipeActuelle.ResumeLayout(false);
            this.groupBoxEquipeActuelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJoueurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKIDEquipesJoueursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKIDEquipesJoueursBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joueursBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joueursBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEquipeActuelle;
        private System.Windows.Forms.Button buttonInviter;
        private System.Windows.Forms.Label labelPointage;
        private System.Windows.Forms.Label labelPointageCP;
        private System.Windows.Forms.DataGridView dataGridViewJoueurs;
        private System.Windows.Forms.Label labelNomEquipe;
        private System.Windows.Forms.Label labelNomCP;
        private System.Windows.Forms.Button buttonQuitterEquipe;
        private System.Windows.Forms.Button buttonCreer;
        private System.Windows.Forms.Button buttonVoirInvitations;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelDescriptionCP;
        private System.Windows.Forms.Button buttonOK;
        private DataSetPong dataSetPong;
        private System.Windows.Forms.BindingSource joueursBindingSource;
        private DataSetPongTableAdapters.joueursTableAdapter joueursTableAdapter;
        private System.Windows.Forms.Button buttonRafraichir;
        private System.Windows.Forms.BindingSource equipesBindingSource;
        private DataSetPongTableAdapters.equipesTableAdapter equipesTableAdapter;
        private System.Windows.Forms.BindingSource joueursBindingSource1;
        private System.Windows.Forms.BindingSource fKIDEquipesJoueursBindingSource;
        private System.Windows.Forms.BindingSource fKIDEquipesJoueursBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pseudonymeDataGridViewTextBoxColumn;
    }
}