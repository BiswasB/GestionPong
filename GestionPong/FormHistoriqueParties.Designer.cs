namespace GestionPong
{
    partial class FormHistoriqueParties
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
            this.labelNombrePartiesJouees = new System.Windows.Forms.Label();
            this.labelPourcentageVictoire = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPointage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewParties = new System.Windows.Forms.DataGridView();
            this.buttonOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de parties jouées :";
            // 
            // labelNombrePartiesJouees
            // 
            this.labelNombrePartiesJouees.AutoSize = true;
            this.labelNombrePartiesJouees.Location = new System.Drawing.Point(152, 13);
            this.labelNombrePartiesJouees.Name = "labelNombrePartiesJouees";
            this.labelNombrePartiesJouees.Size = new System.Drawing.Size(13, 13);
            this.labelNombrePartiesJouees.TabIndex = 1;
            this.labelNombrePartiesJouees.Text = "0";
            // 
            // labelPourcentageVictoire
            // 
            this.labelPourcentageVictoire.AutoSize = true;
            this.labelPourcentageVictoire.Location = new System.Drawing.Point(151, 46);
            this.labelPourcentageVictoire.Name = "labelPourcentageVictoire";
            this.labelPourcentageVictoire.Size = new System.Drawing.Size(13, 13);
            this.labelPourcentageVictoire.TabIndex = 3;
            this.labelPourcentageVictoire.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pourcentage de victoire :";
            // 
            // labelPointage
            // 
            this.labelPointage.AutoSize = true;
            this.labelPointage.Location = new System.Drawing.Point(152, 82);
            this.labelPointage.Name = "labelPointage";
            this.labelPointage.Size = new System.Drawing.Size(13, 13);
            this.labelPointage.TabIndex = 5;
            this.labelPointage.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pointage :";
            // 
            // dataGridViewParties
            // 
            this.dataGridViewParties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParties.Location = new System.Drawing.Point(16, 117);
            this.dataGridViewParties.Name = "dataGridViewParties";
            this.dataGridViewParties.Size = new System.Drawing.Size(275, 150);
            this.dataGridViewParties.TabIndex = 6;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(16, 288);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(275, 23);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormHistoriqueParties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 327);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.dataGridViewParties);
            this.Controls.Add(this.labelPointage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelPourcentageVictoire);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNombrePartiesJouees);
            this.Controls.Add(this.label1);
            this.Name = "FormHistoriqueParties";
            this.Text = "Historique des parties";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombrePartiesJouees;
        private System.Windows.Forms.Label labelPourcentageVictoire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPointage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewParties;
        private System.Windows.Forms.Button buttonOk;
    }
}