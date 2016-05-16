namespace GestionPong
{
    partial class FormCreerEquipe
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
            this.labelDescriptionCP = new System.Windows.Forms.Label();
            this.labelNomCP = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.buttonCreer = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDescriptionCP
            // 
            this.labelDescriptionCP.AutoSize = true;
            this.labelDescriptionCP.Location = new System.Drawing.Point(12, 40);
            this.labelDescriptionCP.Name = "labelDescriptionCP";
            this.labelDescriptionCP.Size = new System.Drawing.Size(66, 13);
            this.labelDescriptionCP.TabIndex = 9;
            this.labelDescriptionCP.Text = "Description :";
            // 
            // labelNomCP
            // 
            this.labelNomCP.AutoSize = true;
            this.labelNomCP.Location = new System.Drawing.Point(12, 9);
            this.labelNomCP.Name = "labelNomCP";
            this.labelNomCP.Size = new System.Drawing.Size(35, 13);
            this.labelNomCP.TabIndex = 7;
            this.labelNomCP.Text = "Nom :";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(87, 9);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(139, 20);
            this.textBoxNom.TabIndex = 11;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(87, 40);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(139, 96);
            this.richTextBoxDescription.TabIndex = 12;
            this.richTextBoxDescription.Text = "";
            // 
            // buttonCreer
            // 
            this.buttonCreer.Location = new System.Drawing.Point(15, 152);
            this.buttonCreer.Name = "buttonCreer";
            this.buttonCreer.Size = new System.Drawing.Size(211, 23);
            this.buttonCreer.TabIndex = 13;
            this.buttonCreer.Text = "Créer";
            this.buttonCreer.UseVisualStyleBackColor = true;
            this.buttonCreer.Click += new System.EventHandler(this.buttonCreer_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(15, 181);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(211, 23);
            this.buttonOK.TabIndex = 14;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormCreerEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 213);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCreer);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelDescriptionCP);
            this.Controls.Add(this.labelNomCP);
            this.Name = "FormCreerEquipe";
            this.Text = "Créer une équipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDescriptionCP;
        private System.Windows.Forms.Label labelNomCP;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Button buttonCreer;
        private System.Windows.Forms.Button buttonOK;
    }
}