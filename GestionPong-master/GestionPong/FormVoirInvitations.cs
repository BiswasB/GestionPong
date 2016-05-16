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
    public partial class FormVoirInvitations : Form
    {
        public FormVoirInvitations()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormVoirInvitations_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSetPong.equipes'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.equipesTableAdapter.Fill(this.dataSetPong.equipes);
            // TODO: cette ligne de code charge les données dans la table 'dataSetPong.invitations'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.invitationsTableAdapter.Fill(this.dataSetPong.invitations);

        }
    }
}
