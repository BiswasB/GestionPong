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
                con = new MySqlConnection(Global.ConnexionString); //À faire: Nom de connexion string.
                con.Open();
                //Créer la commande
                commandText = "SELECT Pseudonyme, NomJoueur, Prenom, MotdePasse Courriel, MotdePasse, NumeroCivique, Rue, CodePostal FROM joueurs, adresse WHERE ID = " + Global.Id; //Commande à exécuter
                cmd = new MySqlCommand(commandText); //Création de la commande
                cmd.Connection = con; //Association de la commande à la connexion
                //Ajouter les paramètres(Nom, Type, Taille dans la table, type dans la table)
                cmd.Parameters.Add(new MySqlParameter("@ID", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "ID"));
                
                cmd.Parameters["@ID"].Value = Global.Id;

                rdr = cmd.ExecuteReader();

                // Effectuer le traitement
                // Affiche le nom de l'élève
                if (rdr.HasRows)
                {
                    rdr.Read();
                    textBoxPseudonyme.Text = rdr["Pseudonyme"].ToString();
                    textBoxNom.Text = rdr["NomJoueur"].ToString();
                    textBoxPrenom.Text = rdr["Prenom"].ToString();
                    textBoxCourriel.Text = rdr["Courriel"].ToString();
                    textBoxMotdePasseActuel.Text = rdr["MotdePasse"].ToString();
                    textBoxNumeroCivique.Text = rdr["NumeroCivique"].ToString();
                    textBoxRue.Text = rdr["Rue"].ToString();
                    textBoxCodePostal.Text = rdr["CodePostal"].ToString();

                }
                else
                {
                    textBoxPseudonyme.Text = "";
                    textBoxNom.Text = "";
                    textBoxPrenom.Text = "";
                    MessageBox.Show("Aucun joueur trouvé");
                }
            }
            catch
            {
                MessageBox.Show("Erreur.");
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}
