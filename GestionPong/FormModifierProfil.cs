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
    public partial class FormModifierProfil : Form
    {
        public FormModifierProfil()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormModifierProfil_Load(object sender, EventArgs e) //À faire: Finir ceci.
        {
            //Créer la connexion
            MySqlConnection con = null;
            MySqlCommand cmd = null;
            MySqlDataReader rdr = null;
            string commandText = "";
            try
            {
                //Établir la connexion
                con = new MySqlConnection(Properties.Settings.Default."__________" ); //À faire: Nom de connexion string.
                con.Open();
                //Créer la commande
                commandText = "SELECT Pseudonyme, Prenom, Nom, Courriel, DateDeNaissance FROM Joueurs WHERE ID = @ID"; //Commande à exécuter
                cmd = new MySqlCommand(commandText); //Création de la commande
                cmd.Connection = con; //Association de la commande à la connexion
                //Ajouter les paramètres (Nom, Type, Taille dans la table, type dans la table)
                cmd.Parameters.Add(new MySqlParameter("@ID", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "ID"));
                //cmd.Parameters.Add(new MySqlParameter("@Pseudonyme", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "Pseudonyme"));
                //cmd.Parameters.Add(new MySqlParameter("@Prenom", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "Prenom"));
                //cmd.Parameters.Add(new MySqlParameter("@Nom", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "Nom"));
                //cmd.Parameters.Add(new MySqlParameter("@Courriel", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "Courriel"));
                //cmd.Parameters.Add(new MySqlParameter("@DateDeNaissance", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "DateDeNaissance"));
                //Récupérer la valeur de l'ID
                cmd.Parameters["@ID"].Value = 
            }
        }
    }
}
