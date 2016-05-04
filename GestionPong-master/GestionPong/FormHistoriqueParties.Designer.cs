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
            this.labelNombrePartiesJoueesCP = new System.Windows.Forms.Label();
            this.labelNombrePartiesJouees = new System.Windows.Forms.Label();
            this.labelPourcentageVictoire = new System.Windows.Forms.Label();
            this.labelPourcentageVictoireCP = new System.Windows.Forms.Label();
            this.labelPointage = new System.Windows.Forms.Label();
            this.labelPointageCP = new System.Windows.Forms.Label();
            this.dataGridViewParties = new System.Windows.Forms.DataGridView();
            this.buttonOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombrePartiesJoueesCP
            // 
            this.labelNombrePartiesJoueesCP.AutoSize = true;
            this.labelNombrePartiesJoueesCP.Location = new System.Drawing.Point(13, 13);
            this.labelNombrePartiesJoueesCP.Name = "labelNombrePartiesJoueesCP";
            this.labelNombrePartiesJoueesCP.Size = new System.Drawing.Size(133, 13);
            this.labelNombrePartiesJoueesCP.TabIndex = 0;
            this.labelNombrePartiesJoueesCP.Text = "Nombre de parties jouées :";
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
            // labelPourcentageVictoireCP
            // 
            this.labelPourcentageVictoireCP.AutoSize = true;
            this.labelPourcentageVictoireCP.Location = new System.Drawing.Point(12, 46);
            this.labelPourcentageVictoireCP.Name = "labelPourcentageVictoireCP";
            this.labelPourcentageVictoireCP.Size = new System.Drawing.Size(126, 13);
            this.labelPourcentageVictoireCP.TabIndex = 2;
            this.labelPourcentageVictoireCP.Text = "Pourcentage de victoire :";
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
            // labelPointageCP
            // 
            this.labelPointageCP.AutoSize = true;
            this.labelPointageCP.Location = new System.Drawing.Point(13, 82);
            this.labelPointageCP.Name = "labelPointageCP";
            this.labelPointageCP.Size = new System.Drawing.Size(55, 13);
            this.labelPointageCP.TabIndex = 4;
            this.labelPointageCP.Text = "Pointage :";
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
            this.Controls.Add(this.labelPointageCP);
            this.Controls.Add(this.labelPourcentageVictoire);
            this.Controls.Add(this.labelPourcentageVictoireCP);
            this.Controls.Add(this.labelNombrePartiesJouees);
            this.Controls.Add(this.labelNombrePartiesJoueesCP);
            this.Name = "FormHistoriqueParties";
            this.Text = "Historique des parties";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombrePartiesJoueesCP;
        private System.Windows.Forms.Label labelNombrePartiesJouees;
        private System.Windows.Forms.Label labelPourcentageVictoire;
        private System.Windows.Forms.Label labelPourcentageVictoireCP;
        private System.Windows.Forms.Label labelPointage;
        private System.Windows.Forms.Label labelPointageCP;
        private System.Windows.Forms.DataGridView dataGridViewParties;
        private System.Windows.Forms.Button buttonOk;
    }
}