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
            this.dataGridViewInvitations = new System.Windows.Forms.DataGridView();
            this.buttonAccepter = new System.Windows.Forms.Button();
            this.buttonRefuser = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvitations)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInvitations
            // 
            this.dataGridViewInvitations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvitations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInvitations;
        private System.Windows.Forms.Button buttonAccepter;
        private System.Windows.Forms.Button buttonRefuser;
        private System.Windows.Forms.Button buttonOK;
    }
}