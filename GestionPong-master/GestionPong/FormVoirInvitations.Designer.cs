namespace GestionPong
{
    partial class FormVoirInvitations
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
            this.dataGridViewInvitations = new System.Windows.Forms.DataGridView();
            this.buttonAccepter = new System.Windows.Forms.Button();
            this.buttonRefuser = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.dataSetPong = new GestionPong.DataSetPong();
            this.invitationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invitationsTableAdapter = new GestionPong.DataSetPongTableAdapters.invitationsTableAdapter();
            this.equipesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipesTableAdapter = new GestionPong.DataSetPongTableAdapters.equipesTableAdapter();
            this.iDJoueursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDEquipesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDStatutInvitationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvitations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInvitations
            // 
            this.dataGridViewInvitations.AutoGenerateColumns = false;
            this.dataGridViewInvitations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvitations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDJoueursDataGridViewTextBoxColumn,
            this.iDEquipesDataGridViewTextBoxColumn,
            this.iDStatutInvitationsDataGridViewTextBoxColumn});
            this.dataGridViewInvitations.DataSource = this.invitationsBindingSource;
            this.dataGridViewInvitations.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewInvitations.Name = "dataGridViewInvitations";
            this.dataGridViewInvitations.Size = new System.Drawing.Size(276, 150);
            this.dataGridViewInvitations.TabIndex = 0;
            // 
            // buttonAccepter
            // 
            this.buttonAccepter.Location = new System.Drawing.Point(13, 186);
            this.buttonAccepter.Name = "buttonAccepter";
            this.buttonAccepter.Size = new System.Drawing.Size(132, 23);
            this.buttonAccepter.TabIndex = 1;
            this.buttonAccepter.Text = "Accepter";
            this.buttonAccepter.UseVisualStyleBackColor = true;
            // 
            // buttonRefuser
            // 
            this.buttonRefuser.Location = new System.Drawing.Point(151, 186);
            this.buttonRefuser.Name = "buttonRefuser";
            this.buttonRefuser.Size = new System.Drawing.Size(138, 23);
            this.buttonRefuser.TabIndex = 2;
            this.buttonRefuser.Text = "Refuser";
            this.buttonRefuser.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(13, 220);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(276, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // dataSetPong
            // 
            this.dataSetPong.DataSetName = "DataSetPong";
            this.dataSetPong.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invitationsBindingSource
            // 
            this.invitationsBindingSource.DataMember = "invitations";
            this.invitationsBindingSource.DataSource = this.dataSetPong;
            // 
            // invitationsTableAdapter
            // 
            this.invitationsTableAdapter.ClearBeforeFill = true;
            // 
            // equipesBindingSource
            // 
            this.equipesBindingSource.DataMember = "equipes";
            this.equipesBindingSource.DataSource = this.dataSetPong;
            // 
            // equipesTableAdapter
            // 
            this.equipesTableAdapter.ClearBeforeFill = true;
            // 
            // iDJoueursDataGridViewTextBoxColumn
            // 
            this.iDJoueursDataGridViewTextBoxColumn.DataPropertyName = "ID_Joueurs";
            this.iDJoueursDataGridViewTextBoxColumn.HeaderText = "ID_Joueurs";
            this.iDJoueursDataGridViewTextBoxColumn.Name = "iDJoueursDataGridViewTextBoxColumn";
            // 
            // iDEquipesDataGridViewTextBoxColumn
            // 
            this.iDEquipesDataGridViewTextBoxColumn.DataPropertyName = "ID_Equipes";
            this.iDEquipesDataGridViewTextBoxColumn.DataSource = this.equipesBindingSource;
            this.iDEquipesDataGridViewTextBoxColumn.DisplayMember = "NomEquipe";
            this.iDEquipesDataGridViewTextBoxColumn.HeaderText = "ID_Equipes";
            this.iDEquipesDataGridViewTextBoxColumn.Name = "iDEquipesDataGridViewTextBoxColumn";
            this.iDEquipesDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDEquipesDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // iDStatutInvitationsDataGridViewTextBoxColumn
            // 
            this.iDStatutInvitationsDataGridViewTextBoxColumn.DataPropertyName = "ID_StatutInvitations";
            this.iDStatutInvitationsDataGridViewTextBoxColumn.HeaderText = "ID_StatutInvitations";
            this.iDStatutInvitationsDataGridViewTextBoxColumn.Name = "iDStatutInvitationsDataGridViewTextBoxColumn";
            // 
            // FormVoirInvitations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 255);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonRefuser);
            this.Controls.Add(this.buttonAccepter);
            this.Controls.Add(this.dataGridViewInvitations);
            this.Name = "FormVoirInvitations";
            this.Text = "FormVoirInvitations";
            this.Load += new System.EventHandler(this.FormVoirInvitations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvitations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInvitations;
        private System.Windows.Forms.Button buttonAccepter;
        private System.Windows.Forms.Button buttonRefuser;
        private System.Windows.Forms.Button buttonOK;
        private DataSetPong dataSetPong;
        private System.Windows.Forms.BindingSource invitationsBindingSource;
        private DataSetPongTableAdapters.invitationsTableAdapter invitationsTableAdapter;
        private System.Windows.Forms.BindingSource equipesBindingSource;
        private DataSetPongTableAdapters.equipesTableAdapter equipesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDStatutInvitationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDEquipesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDJoueursDataGridViewTextBoxColumn;
    }
}