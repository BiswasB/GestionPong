namespace GestionPong
{
    partial class FormCartesCredit
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
            this.comboBoxCartes = new System.Windows.Forms.ComboBox();
            this.labelCarteCP = new System.Windows.Forms.Label();
            this.comboBoxMarque = new System.Windows.Forms.ComboBox();
            this.labelMarqueCP = new System.Windows.Forms.Label();
            this.labelDateExpirationCP = new System.Windows.Forms.Label();
            this.dateTimePickerDateExpiration = new System.Windows.Forms.DateTimePicker();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.labelNumeroCP = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxCartes
            // 
            this.comboBoxCartes.FormattingEnabled = true;
            this.comboBoxCartes.Location = new System.Drawing.Point(111, 16);
            this.comboBoxCartes.Name = "comboBoxCartes";
            this.comboBoxCartes.Size = new System.Drawing.Size(146, 21);
            this.comboBoxCartes.TabIndex = 0;
            this.comboBoxCartes.SelectedIndexChanged += new System.EventHandler(this.comboBoxCartes_SelectedIndexChanged);
            // 
            // labelCarteCP
            // 
            this.labelCarteCP.AutoSize = true;
            this.labelCarteCP.Location = new System.Drawing.Point(13, 19);
            this.labelCarteCP.Name = "labelCarteCP";
            this.labelCarteCP.Size = new System.Drawing.Size(38, 13);
            this.labelCarteCP.TabIndex = 1;
            this.labelCarteCP.Text = "Carte :";
            // 
            // comboBoxMarque
            // 
            this.comboBoxMarque.FormattingEnabled = true;
            this.comboBoxMarque.Location = new System.Drawing.Point(111, 160);
            this.comboBoxMarque.Name = "comboBoxMarque";
            this.comboBoxMarque.Size = new System.Drawing.Size(145, 21);
            this.comboBoxMarque.TabIndex = 4;
            // 
            // labelMarqueCP
            // 
            this.labelMarqueCP.AutoSize = true;
            this.labelMarqueCP.Location = new System.Drawing.Point(12, 163);
            this.labelMarqueCP.Name = "labelMarqueCP";
            this.labelMarqueCP.Size = new System.Drawing.Size(49, 13);
            this.labelMarqueCP.TabIndex = 5;
            this.labelMarqueCP.Text = "Marque :";
            // 
            // labelDateExpirationCP
            // 
            this.labelDateExpirationCP.AutoSize = true;
            this.labelDateExpirationCP.Location = new System.Drawing.Point(12, 216);
            this.labelDateExpirationCP.Name = "labelDateExpirationCP";
            this.labelDateExpirationCP.Size = new System.Drawing.Size(92, 13);
            this.labelDateExpirationCP.TabIndex = 6;
            this.labelDateExpirationCP.Text = "Date d\'expiration :";
            // 
            // dateTimePickerDateExpiration
            // 
            this.dateTimePickerDateExpiration.Location = new System.Drawing.Point(110, 210);
            this.dateTimePickerDateExpiration.Name = "dateTimePickerDateExpiration";
            this.dateTimePickerDateExpiration.Size = new System.Drawing.Size(146, 20);
            this.dateTimePickerDateExpiration.TabIndex = 7;
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(21, 311);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(115, 23);
            this.buttonModifier.TabIndex = 10;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(142, 311);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(115, 23);
            this.buttonSupprimer.TabIndex = 11;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(16, 351);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(241, 23);
            this.buttonAjouter.TabIndex = 12;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(111, 59);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(145, 20);
            this.textBoxNumero.TabIndex = 14;
            // 
            // labelNumeroCP
            // 
            this.labelNumeroCP.AutoSize = true;
            this.labelNumeroCP.Location = new System.Drawing.Point(12, 62);
            this.labelNumeroCP.Name = "labelNumeroCP";
            this.labelNumeroCP.Size = new System.Drawing.Size(50, 13);
            this.labelNumeroCP.TabIndex = 13;
            this.labelNumeroCP.Text = "Numéro :";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(16, 380);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(240, 23);
            this.buttonOK.TabIndex = 15;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormCartesCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 415);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.labelNumeroCP);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.dateTimePickerDateExpiration);
            this.Controls.Add(this.labelDateExpirationCP);
            this.Controls.Add(this.labelMarqueCP);
            this.Controls.Add(this.comboBoxMarque);
            this.Controls.Add(this.labelCarteCP);
            this.Controls.Add(this.comboBoxCartes);
            this.Name = "FormCartesCredit";
            this.Text = "Cartes de crédit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCartes;
        private System.Windows.Forms.Label labelCarteCP;
        private System.Windows.Forms.ComboBox comboBoxMarque;
        private System.Windows.Forms.Label labelMarqueCP;
        private System.Windows.Forms.Label labelDateExpirationCP;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateExpiration;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label labelNumeroCP;
        private System.Windows.Forms.Button buttonOK;
    }
}