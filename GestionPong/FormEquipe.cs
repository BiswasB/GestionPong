using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPong
{
    public partial class FormEquipe : Form
    {
        public FormEquipe()
        {
            InitializeComponent();
        }

        private void buttonCreer_Click(object sender, EventArgs e)
        {
            FormCreerEquipe formCreerEquipe = new FormCreerEquipe();
            formCreerEquipe.Show();
        }

        private void buttonInviter_Click(object sender, EventArgs e)
        {
            FormInviterJoueur formInviterJoueur = new FormInviterJoueur();
            formInviterJoueur.Show();
        }

        private void buttonVoirInvitations_Click(object sender, EventArgs e)
        {
            FormVoirInvitations formVoirInvitations = new FormVoirInvitations();
            formVoirInvitations.Show();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
