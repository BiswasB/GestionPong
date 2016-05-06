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
    public partial class FormEcranPrincipal : Form
    {
        public FormEcranPrincipal()
        {
            InitializeComponent();
        }

        private void buttonDeconnexion_Click(object sender, EventArgs e)
        {
            Global.ID = 0; //fuck you
            Environment.Exit(0);
        }

        private void buttonModifierCompte_Click(object sender, EventArgs e)
        {
            FormModifierProfil formModifierProfil = new FormModifierProfil();
            formModifierProfil.Show();
        }

        private void buttonCarteCredit_Click(object sender, EventArgs e)
        {
            FormCartesCredit formCartesCredit = new FormCartesCredit();
            formCartesCredit.Show();
        }

        private void buttonForfaits_Click(object sender, EventArgs e)
        {
            FormAcheterForfaits formAcheterForfaits = new FormAcheterForfaits();
            formAcheterForfaits.Show();
        }

        private void buttonEtatCompte_Click(object sender, EventArgs e)
        {
            FormEtatCompte formEtatCompte = new FormEtatCompte();
            formEtatCompte.Show();
        }

        private void buttonEquipe_Click(object sender, EventArgs e)
        {
            FormEquipe formEquipe = new FormEquipe();
            formEquipe.Show();
        }

        private void buttonHistorique_Click(object sender, EventArgs e)
        {
            FormHistoriqueParties formHistoriqueParties = new FormHistoriqueParties();
            formHistoriqueParties.Show();
        }

        private void buttonTournois_Click(object sender, EventArgs e)
        {
            FormTournoi formTournoi = new FormTournoi();
            formTournoi.Show();
        }
    }
}
