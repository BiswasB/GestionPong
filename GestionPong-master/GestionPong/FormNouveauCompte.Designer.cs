namespace GestionPong
{
    partial class FormNouveauCompte
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
            this.textBoxMotdePasse = new System.Windows.Forms.TextBox();
            this.labelMotDePasseCP = new System.Windows.Forms.Label();
            this.textBoxPseudonyme = new System.Windows.Forms.TextBox();
            this.labelPseudonymeCP = new System.Windows.Forms.Label();
            this.textBoxConfirmationMotDePasse = new System.Windows.Forms.TextBox();
            this.labelConfirmationMotDePasseCP = new System.Windows.Forms.Label();
            this.textBoxCourriel = new System.Windows.Forms.TextBox();
            this.labelCourrielCP = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelNomCP = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.labelPrenomCP = new System.Windows.Forms.Label();
            this.labelDateDeNaissanceCP = new System.Windows.Forms.Label();
            this.dateTimePickerDateDeNaissance = new System.Windows.Forms.DateTimePicker();
            this.labelPhotoDeProfilCP = new System.Windows.Forms.Label();
            this.pictureBoxPhotoDeProfil = new System.Windows.Forms.PictureBox();
            this.buttonImporterPhoto = new System.Windows.Forms.Button();
            this.buttonCreer = new System.Windows.Forms.Button();
            this.groupBoxAdresse = new System.Windows.Forms.GroupBox();
            this.labelNumeroCiviqueCP = new System.Windows.Forms.Label();
            this.comboBoxPays = new System.Windows.Forms.ComboBox();
            this.textBoxNumeroCivique = new System.Windows.Forms.TextBox();
            this.comboBoxProvince = new System.Windows.Forms.ComboBox();
            this.labelRueCP = new System.Windows.Forms.Label();
            this.labelProvinceCP = new System.Windows.Forms.Label();
            this.textBoxRue = new System.Windows.Forms.TextBox();
            this.labelPaysCP = new System.Windows.Forms.Label();
            this.labelVilleCP = new System.Windows.Forms.Label();
            this.textBoxCodePostal = new System.Windows.Forms.TextBox();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.labelCodePostalCP = new System.Windows.Forms.Label();
            this.dataSetPong = new GestionPong.DataSetPong();
            this.dataSetPongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paysTableAdapter = new GestionPong.DataSetPongTableAdapters.paysTableAdapter();
            this.provinceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provinceTableAdapter = new GestionPong.DataSetPongTableAdapters.provinceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotoDeProfil)).BeginInit();
            this.groupBoxAdresse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMotdePasse
            // 
            this.textBoxMotdePasse.Location = new System.Drawing.Point(161, 44);
            this.textBoxMotdePasse.Name = "textBoxMotdePasse";
            this.textBoxMotdePasse.Size = new System.Drawing.Size(144, 20);
            this.textBoxMotdePasse.TabIndex = 8;
            // 
            // labelMotDePasseCP
            // 
            this.labelMotDePasseCP.AutoSize = true;
            this.labelMotDePasseCP.Location = new System.Drawing.Point(17, 47);
            this.labelMotDePasseCP.Name = "labelMotDePasseCP";
            this.labelMotDePasseCP.Size = new System.Drawing.Size(77, 13);
            this.labelMotDePasseCP.TabIndex = 7;
            this.labelMotDePasseCP.Text = "Mot de passe :";
            // 
            // textBoxPseudonyme
            // 
            this.textBoxPseudonyme.Location = new System.Drawing.Point(161, 6);
            this.textBoxPseudonyme.Name = "textBoxPseudonyme";
            this.textBoxPseudonyme.Size = new System.Drawing.Size(144, 20);
            this.textBoxPseudonyme.TabIndex = 6;
            // 
            // labelPseudonymeCP
            // 
            this.labelPseudonymeCP.AutoSize = true;
            this.labelPseudonymeCP.Location = new System.Drawing.Point(17, 9);
            this.labelPseudonymeCP.Name = "labelPseudonymeCP";
            this.labelPseudonymeCP.Size = new System.Drawing.Size(74, 13);
            this.labelPseudonymeCP.TabIndex = 5;
            this.labelPseudonymeCP.Text = "Pseudonyme :";
            // 
            // textBoxConfirmationMotDePasse
            // 
            this.textBoxConfirmationMotDePasse.Location = new System.Drawing.Point(161, 84);
            this.textBoxConfirmationMotDePasse.Name = "textBoxConfirmationMotDePasse";
            this.textBoxConfirmationMotDePasse.Size = new System.Drawing.Size(144, 20);
            this.textBoxConfirmationMotDePasse.TabIndex = 10;
            // 
            // labelConfirmationMotDePasseCP
            // 
            this.labelConfirmationMotDePasseCP.AutoSize = true;
            this.labelConfirmationMotDePasseCP.Location = new System.Drawing.Point(17, 87);
            this.labelConfirmationMotDePasseCP.Name = "labelConfirmationMotDePasseCP";
            this.labelConfirmationMotDePasseCP.Size = new System.Drawing.Size(138, 13);
            this.labelConfirmationMotDePasseCP.TabIndex = 9;
            this.labelConfirmationMotDePasseCP.Text = "Confirmation Mot de passe :";
            // 
            // textBoxCourriel
            // 
            this.textBoxCourriel.Location = new System.Drawing.Point(161, 442);
            this.textBoxCourriel.Name = "textBoxCourriel";
            this.textBoxCourriel.Size = new System.Drawing.Size(144, 20);
            this.textBoxCourriel.TabIndex = 16;
            // 
            // labelCourrielCP
            // 
            this.labelCourrielCP.AutoSize = true;
            this.labelCourrielCP.Location = new System.Drawing.Point(17, 445);
            this.labelCourrielCP.Name = "labelCourrielCP";
            this.labelCourrielCP.Size = new System.Drawing.Size(48, 13);
            this.labelCourrielCP.TabIndex = 15;
            this.labelCourrielCP.Text = "Courriel :";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(161, 157);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(144, 20);
            this.textBoxNom.TabIndex = 14;
            // 
            // labelNomCP
            // 
            this.labelNomCP.AutoSize = true;
            this.labelNomCP.Location = new System.Drawing.Point(17, 160);
            this.labelNomCP.Name = "labelNomCP";
            this.labelNomCP.Size = new System.Drawing.Size(35, 13);
            this.labelNomCP.TabIndex = 13;
            this.labelNomCP.Text = "Nom :";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(161, 119);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(144, 20);
            this.textBoxPrenom.TabIndex = 12;
            // 
            // labelPrenomCP
            // 
            this.labelPrenomCP.AutoSize = true;
            this.labelPrenomCP.Location = new System.Drawing.Point(17, 122);
            this.labelPrenomCP.Name = "labelPrenomCP";
            this.labelPrenomCP.Size = new System.Drawing.Size(49, 13);
            this.labelPrenomCP.TabIndex = 11;
            this.labelPrenomCP.Text = "Prénom :";
            // 
            // labelDateDeNaissanceCP
            // 
            this.labelDateDeNaissanceCP.AutoSize = true;
            this.labelDateDeNaissanceCP.Location = new System.Drawing.Point(18, 489);
            this.labelDateDeNaissanceCP.Name = "labelDateDeNaissanceCP";
            this.labelDateDeNaissanceCP.Size = new System.Drawing.Size(102, 13);
            this.labelDateDeNaissanceCP.TabIndex = 17;
            this.labelDateDeNaissanceCP.Text = "Date de naissance :";
            // 
            // dateTimePickerDateDeNaissance
            // 
            this.dateTimePickerDateDeNaissance.Location = new System.Drawing.Point(161, 489);
            this.dateTimePickerDateDeNaissance.Name = "dateTimePickerDateDeNaissance";
            this.dateTimePickerDateDeNaissance.Size = new System.Drawing.Size(144, 20);
            this.dateTimePickerDateDeNaissance.TabIndex = 18;
            // 
            // labelPhotoDeProfilCP
            // 
            this.labelPhotoDeProfilCP.AutoSize = true;
            this.labelPhotoDeProfilCP.Location = new System.Drawing.Point(18, 538);
            this.labelPhotoDeProfilCP.Name = "labelPhotoDeProfilCP";
            this.labelPhotoDeProfilCP.Size = new System.Drawing.Size(81, 13);
            this.labelPhotoDeProfilCP.TabIndex = 19;
            this.labelPhotoDeProfilCP.Text = "Photo de profil :";
            // 
            // pictureBoxPhotoDeProfil
            // 
            this.pictureBoxPhotoDeProfil.Location = new System.Drawing.Point(161, 538);
            this.pictureBoxPhotoDeProfil.Name = "pictureBoxPhotoDeProfil";
            this.pictureBoxPhotoDeProfil.Size = new System.Drawing.Size(144, 82);
            this.pictureBoxPhotoDeProfil.TabIndex = 20;
            this.pictureBoxPhotoDeProfil.TabStop = false;
            // 
            // buttonImporterPhoto
            // 
            this.buttonImporterPhoto.Location = new System.Drawing.Point(80, 597);
            this.buttonImporterPhoto.Name = "buttonImporterPhoto";
            this.buttonImporterPhoto.Size = new System.Drawing.Size(75, 23);
            this.buttonImporterPhoto.TabIndex = 21;
            this.buttonImporterPhoto.Text = "Importer";
            this.buttonImporterPhoto.UseVisualStyleBackColor = true;
            // 
            // buttonCreer
            // 
            this.buttonCreer.Location = new System.Drawing.Point(24, 661);
            this.buttonCreer.Name = "buttonCreer";
            this.buttonCreer.Size = new System.Drawing.Size(281, 23);
            this.buttonCreer.TabIndex = 22;
            this.buttonCreer.Text = "Créer le nouveau compte";
            this.buttonCreer.UseVisualStyleBackColor = true;
            this.buttonCreer.Click += new System.EventHandler(this.buttonCreer_Click);
            // 
            // groupBoxAdresse
            // 
            this.groupBoxAdresse.Controls.Add(this.labelNumeroCiviqueCP);
            this.groupBoxAdresse.Controls.Add(this.comboBoxPays);
            this.groupBoxAdresse.Controls.Add(this.textBoxNumeroCivique);
            this.groupBoxAdresse.Controls.Add(this.comboBoxProvince);
            this.groupBoxAdresse.Controls.Add(this.labelRueCP);
            this.groupBoxAdresse.Controls.Add(this.labelProvinceCP);
            this.groupBoxAdresse.Controls.Add(this.textBoxRue);
            this.groupBoxAdresse.Controls.Add(this.labelPaysCP);
            this.groupBoxAdresse.Controls.Add(this.labelVilleCP);
            this.groupBoxAdresse.Controls.Add(this.textBoxCodePostal);
            this.groupBoxAdresse.Controls.Add(this.textBoxVille);
            this.groupBoxAdresse.Controls.Add(this.labelCodePostalCP);
            this.groupBoxAdresse.Location = new System.Drawing.Point(12, 183);
            this.groupBoxAdresse.Name = "groupBoxAdresse";
            this.groupBoxAdresse.Size = new System.Drawing.Size(308, 248);
            this.groupBoxAdresse.TabIndex = 71;
            this.groupBoxAdresse.TabStop = false;
            this.groupBoxAdresse.Text = "Adresse";
            // 
            // labelNumeroCiviqueCP
            // 
            this.labelNumeroCiviqueCP.AutoSize = true;
            this.labelNumeroCiviqueCP.Location = new System.Drawing.Point(6, 25);
            this.labelNumeroCiviqueCP.Name = "labelNumeroCiviqueCP";
            this.labelNumeroCiviqueCP.Size = new System.Drawing.Size(87, 13);
            this.labelNumeroCiviqueCP.TabIndex = 41;
            this.labelNumeroCiviqueCP.Text = "Numéro civique :";
            // 
            // comboBoxPays
            // 
            this.comboBoxPays.DataSource = this.paysBindingSource;
            this.comboBoxPays.DisplayMember = "Nom";
            this.comboBoxPays.FormattingEnabled = true;
            this.comboBoxPays.Location = new System.Drawing.Point(149, 176);
            this.comboBoxPays.Name = "comboBoxPays";
            this.comboBoxPays.Size = new System.Drawing.Size(144, 21);
            this.comboBoxPays.TabIndex = 53;
            this.comboBoxPays.ValueMember = "Nom";
            // 
            // textBoxNumeroCivique
            // 
            this.textBoxNumeroCivique.Location = new System.Drawing.Point(149, 22);
            this.textBoxNumeroCivique.Name = "textBoxNumeroCivique";
            this.textBoxNumeroCivique.Size = new System.Drawing.Size(144, 20);
            this.textBoxNumeroCivique.TabIndex = 42;
            // 
            // comboBoxProvince
            // 
            this.comboBoxProvince.DataSource = this.provinceBindingSource;
            this.comboBoxProvince.DisplayMember = "Nom";
            this.comboBoxProvince.FormattingEnabled = true;
            this.comboBoxProvince.Location = new System.Drawing.Point(149, 216);
            this.comboBoxProvince.Name = "comboBoxProvince";
            this.comboBoxProvince.Size = new System.Drawing.Size(144, 21);
            this.comboBoxProvince.TabIndex = 52;
            this.comboBoxProvince.ValueMember = "Nom";
            // 
            // labelRueCP
            // 
            this.labelRueCP.AutoSize = true;
            this.labelRueCP.Location = new System.Drawing.Point(7, 62);
            this.labelRueCP.Name = "labelRueCP";
            this.labelRueCP.Size = new System.Drawing.Size(33, 13);
            this.labelRueCP.TabIndex = 43;
            this.labelRueCP.Text = "Rue :";
            // 
            // labelProvinceCP
            // 
            this.labelProvinceCP.AutoSize = true;
            this.labelProvinceCP.Location = new System.Drawing.Point(6, 219);
            this.labelProvinceCP.Name = "labelProvinceCP";
            this.labelProvinceCP.Size = new System.Drawing.Size(55, 13);
            this.labelProvinceCP.TabIndex = 51;
            this.labelProvinceCP.Text = "Province :";
            // 
            // textBoxRue
            // 
            this.textBoxRue.Location = new System.Drawing.Point(149, 59);
            this.textBoxRue.Name = "textBoxRue";
            this.textBoxRue.Size = new System.Drawing.Size(144, 20);
            this.textBoxRue.TabIndex = 44;
            // 
            // labelPaysCP
            // 
            this.labelPaysCP.AutoSize = true;
            this.labelPaysCP.Location = new System.Drawing.Point(6, 179);
            this.labelPaysCP.Name = "labelPaysCP";
            this.labelPaysCP.Size = new System.Drawing.Size(36, 13);
            this.labelPaysCP.TabIndex = 49;
            this.labelPaysCP.Text = "Pays :";
            // 
            // labelVilleCP
            // 
            this.labelVilleCP.AutoSize = true;
            this.labelVilleCP.Location = new System.Drawing.Point(7, 102);
            this.labelVilleCP.Name = "labelVilleCP";
            this.labelVilleCP.Size = new System.Drawing.Size(32, 13);
            this.labelVilleCP.TabIndex = 45;
            this.labelVilleCP.Text = "Ville :";
            // 
            // textBoxCodePostal
            // 
            this.textBoxCodePostal.Location = new System.Drawing.Point(149, 139);
            this.textBoxCodePostal.Name = "textBoxCodePostal";
            this.textBoxCodePostal.Size = new System.Drawing.Size(144, 20);
            this.textBoxCodePostal.TabIndex = 48;
            // 
            // textBoxVille
            // 
            this.textBoxVille.Location = new System.Drawing.Point(149, 99);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(144, 20);
            this.textBoxVille.TabIndex = 46;
            // 
            // labelCodePostalCP
            // 
            this.labelCodePostalCP.AutoSize = true;
            this.labelCodePostalCP.Location = new System.Drawing.Point(5, 142);
            this.labelCodePostalCP.Name = "labelCodePostalCP";
            this.labelCodePostalCP.Size = new System.Drawing.Size(70, 13);
            this.labelCodePostalCP.TabIndex = 47;
            this.labelCodePostalCP.Text = "Code Postal :";
            // 
            // dataSetPong
            // 
            this.dataSetPong.DataSetName = "DataSetPong";
            this.dataSetPong.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetPongBindingSource
            // 
            this.dataSetPongBindingSource.DataSource = this.dataSetPong;
            this.dataSetPongBindingSource.Position = 0;
            // 
            // paysBindingSource
            // 
            this.paysBindingSource.DataMember = "pays";
            this.paysBindingSource.DataSource = this.dataSetPongBindingSource;
            // 
            // paysTableAdapter
            // 
            this.paysTableAdapter.ClearBeforeFill = true;
            // 
            // provinceBindingSource
            // 
            this.provinceBindingSource.DataMember = "province";
            this.provinceBindingSource.DataSource = this.dataSetPongBindingSource;
            // 
            // provinceTableAdapter
            // 
            this.provinceTableAdapter.ClearBeforeFill = true;
            // 
            // FormNouveauCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 707);
            this.Controls.Add(this.groupBoxAdresse);
            this.Controls.Add(this.buttonCreer);
            this.Controls.Add(this.buttonImporterPhoto);
            this.Controls.Add(this.pictureBoxPhotoDeProfil);
            this.Controls.Add(this.labelPhotoDeProfilCP);
            this.Controls.Add(this.dateTimePickerDateDeNaissance);
            this.Controls.Add(this.labelDateDeNaissanceCP);
            this.Controls.Add(this.textBoxCourriel);
            this.Controls.Add(this.labelCourrielCP);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelNomCP);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.labelPrenomCP);
            this.Controls.Add(this.textBoxConfirmationMotDePasse);
            this.Controls.Add(this.labelConfirmationMotDePasseCP);
            this.Controls.Add(this.textBoxMotdePasse);
            this.Controls.Add(this.labelMotDePasseCP);
            this.Controls.Add(this.textBoxPseudonyme);
            this.Controls.Add(this.labelPseudonymeCP);
            this.Name = "FormNouveauCompte";
            this.Text = "Nouveau Compte";
            this.Load += new System.EventHandler(this.FormNouveauCompte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotoDeProfil)).EndInit();
            this.groupBoxAdresse.ResumeLayout(false);
            this.groupBoxAdresse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMotdePasse;
        private System.Windows.Forms.Label labelMotDePasseCP;
        private System.Windows.Forms.TextBox textBoxPseudonyme;
        private System.Windows.Forms.Label labelPseudonymeCP;
        private System.Windows.Forms.TextBox textBoxConfirmationMotDePasse;
        private System.Windows.Forms.Label labelConfirmationMotDePasseCP;
        private System.Windows.Forms.TextBox textBoxCourriel;
        private System.Windows.Forms.Label labelCourrielCP;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelNomCP;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label labelPrenomCP;
        private System.Windows.Forms.Label labelDateDeNaissanceCP;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateDeNaissance;
        private System.Windows.Forms.Label labelPhotoDeProfilCP;
        private System.Windows.Forms.PictureBox pictureBoxPhotoDeProfil;
        private System.Windows.Forms.Button buttonImporterPhoto;
        private System.Windows.Forms.Button buttonCreer;
        private System.Windows.Forms.GroupBox groupBoxAdresse;
        private System.Windows.Forms.Label labelNumeroCiviqueCP;
        private System.Windows.Forms.ComboBox comboBoxPays;
        private System.Windows.Forms.TextBox textBoxNumeroCivique;
        private System.Windows.Forms.ComboBox comboBoxProvince;
        private System.Windows.Forms.Label labelRueCP;
        private System.Windows.Forms.Label labelProvinceCP;
        private System.Windows.Forms.TextBox textBoxRue;
        private System.Windows.Forms.Label labelPaysCP;
        private System.Windows.Forms.Label labelVilleCP;
        private System.Windows.Forms.TextBox textBoxCodePostal;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.Label labelCodePostalCP;
        private System.Windows.Forms.BindingSource dataSetPongBindingSource;
        private DataSetPong dataSetPong;
        private System.Windows.Forms.BindingSource paysBindingSource;
        private DataSetPongTableAdapters.paysTableAdapter paysTableAdapter;
        private System.Windows.Forms.BindingSource provinceBindingSource;
        private DataSetPongTableAdapters.provinceTableAdapter provinceTableAdapter;
    }
}