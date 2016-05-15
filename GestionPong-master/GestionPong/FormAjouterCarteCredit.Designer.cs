namespace GestionPong
{
    partial class FormAjouterCarteCredit
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
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.textBoxNumeroSecurite = new System.Windows.Forms.TextBox();
            this.labelNumeroDeSecuriteCP = new System.Windows.Forms.Label();
            this.dateTimePickerDateExpiration = new System.Windows.Forms.DateTimePicker();
            this.labelDateExpirationCP = new System.Windows.Forms.Label();
            this.labelMarqueCP = new System.Windows.Forms.Label();
            this.comboBoxMarque = new System.Windows.Forms.ComboBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelNomDuTitulaireCP = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.labelNumeroCP = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(12, 255);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(241, 23);
            this.buttonAjouter.TabIndex = 25;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            // 
            // textBoxNumeroSecurite
            // 
            this.textBoxNumeroSecurite.Location = new System.Drawing.Point(123, 213);
            this.textBoxNumeroSecurite.Name = "textBoxNumeroSecurite";
            this.textBoxNumeroSecurite.Size = new System.Drawing.Size(133, 20);
            this.textBoxNumeroSecurite.TabIndex = 22;
            // 
            // labelNumeroDeSecuriteCP
            // 
            this.labelNumeroDeSecuriteCP.AutoSize = true;
            this.labelNumeroDeSecuriteCP.Location = new System.Drawing.Point(12, 216);
            this.labelNumeroDeSecuriteCP.Name = "labelNumeroDeSecuriteCP";
            this.labelNumeroDeSecuriteCP.Size = new System.Drawing.Size(105, 13);
            this.labelNumeroDeSecuriteCP.TabIndex = 21;
            this.labelNumeroDeSecuriteCP.Text = "Numéro de sécurité :";
            // 
            // dateTimePickerDateExpiration
            // 
            this.dateTimePickerDateExpiration.Location = new System.Drawing.Point(110, 169);
            this.dateTimePickerDateExpiration.Name = "dateTimePickerDateExpiration";
            this.dateTimePickerDateExpiration.Size = new System.Drawing.Size(146, 20);
            this.dateTimePickerDateExpiration.TabIndex = 20;
            // 
            // labelDateExpirationCP
            // 
            this.labelDateExpirationCP.AutoSize = true;
            this.labelDateExpirationCP.Location = new System.Drawing.Point(12, 175);
            this.labelDateExpirationCP.Name = "labelDateExpirationCP";
            this.labelDateExpirationCP.Size = new System.Drawing.Size(92, 13);
            this.labelDateExpirationCP.TabIndex = 19;
            this.labelDateExpirationCP.Text = "Date d\'expiration :";
            // 
            // labelMarqueCP
            // 
            this.labelMarqueCP.AutoSize = true;
            this.labelMarqueCP.Location = new System.Drawing.Point(12, 122);
            this.labelMarqueCP.Name = "labelMarqueCP";
            this.labelMarqueCP.Size = new System.Drawing.Size(49, 13);
            this.labelMarqueCP.TabIndex = 18;
            this.labelMarqueCP.Text = "Marque :";
            // 
            // comboBoxMarque
            // 
            this.comboBoxMarque.FormattingEnabled = true;
            this.comboBoxMarque.Location = new System.Drawing.Point(111, 119);
            this.comboBoxMarque.Name = "comboBoxMarque";
            this.comboBoxMarque.Size = new System.Drawing.Size(145, 21);
            this.comboBoxMarque.TabIndex = 17;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(111, 67);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(145, 20);
            this.textBoxNom.TabIndex = 16;
            // 
            // labelNomDuTitulaireCP
            // 
            this.labelNomDuTitulaireCP.AutoSize = true;
            this.labelNomDuTitulaireCP.Location = new System.Drawing.Point(12, 70);
            this.labelNomDuTitulaireCP.Name = "labelNomDuTitulaireCP";
            this.labelNomDuTitulaireCP.Size = new System.Drawing.Size(83, 13);
            this.labelNomDuTitulaireCP.TabIndex = 15;
            this.labelNomDuTitulaireCP.Text = "Nom du titulaire:";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(111, 20);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(145, 20);
            this.textBoxNumero.TabIndex = 27;
            // 
            // labelNumeroCP
            // 
            this.labelNumeroCP.AutoSize = true;
            this.labelNumeroCP.Location = new System.Drawing.Point(12, 23);
            this.labelNumeroCP.Name = "labelNumeroCP";
            this.labelNumeroCP.Size = new System.Drawing.Size(50, 13);
            this.labelNumeroCP.TabIndex = 26;
            this.labelNumeroCP.Text = "Numéro :";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(50, 284);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(163, 23);
            this.buttonOK.TabIndex = 28;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormAjouterCarteCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 313);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.labelNumeroCP);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.textBoxNumeroSecurite);
            this.Controls.Add(this.labelNumeroDeSecuriteCP);
            this.Controls.Add(this.dateTimePickerDateExpiration);
            this.Controls.Add(this.labelDateExpirationCP);
            this.Controls.Add(this.labelMarqueCP);
            this.Controls.Add(this.comboBoxMarque);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelNomDuTitulaireCP);
            this.Name = "FormAjouterCarteCredit";
            this.Text = "Ajouter une carte de crédit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.TextBox textBoxNumeroSecurite;
        private System.Windows.Forms.Label labelNumeroDeSecuriteCP;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateExpiration;
        private System.Windows.Forms.Label labelDateExpirationCP;
        private System.Windows.Forms.Label labelMarqueCP;
        private System.Windows.Forms.ComboBox comboBoxMarque;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelNomDuTitulaireCP;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label labelNumeroCP;
        private System.Windows.Forms.Button buttonOK;
    }
}