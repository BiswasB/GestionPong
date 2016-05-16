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
            this.dateTimePickerDateExpiration = new System.Windows.Forms.DateTimePicker();
            this.labelDateExpirationCP = new System.Windows.Forms.Label();
            this.labelMarqueCP = new System.Windows.Forms.Label();
            this.comboBoxMarque = new System.Windows.Forms.ComboBox();
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
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
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
            this.buttonOK.Location = new System.Drawing.Point(12, 284);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(241, 23);
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
            this.Controls.Add(this.dateTimePickerDateExpiration);
            this.Controls.Add(this.labelDateExpirationCP);
            this.Controls.Add(this.labelMarqueCP);
            this.Controls.Add(this.comboBoxMarque);
            this.Name = "FormAjouterCarteCredit";
            this.Text = "Ajouter une carte de crédit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateExpiration;
        private System.Windows.Forms.Label labelDateExpirationCP;
        private System.Windows.Forms.Label labelMarqueCP;
        private System.Windows.Forms.ComboBox comboBoxMarque;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label labelNumeroCP;
        private System.Windows.Forms.Button buttonOK;
    }
}