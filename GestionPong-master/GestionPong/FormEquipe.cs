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

        private void FormEquipe_Load(object sender, EventArgs e)
        {
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
                commandText = "SELECT NomEquipe, DescriptionEquipe, FROM equipe WHERE equipe.ID = @ID; "; //Commande à exécuter
                cmd = new MySqlCommand(commandText); //Création de la commande
                cmd.Connection = con; //Association de la commande à la connexion
                //Ajouter les paramètres(Nom, Type, Taille dans la table, type dans la table)
                cmd.Parameters.Add(new MySqlParameter("@ID", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "ID"));

                cmd.Parameters["@ID"].Value = Global.Id_Equipes;

                rdr = cmd.ExecuteReader();

                // Effectuer le traitement
                // Affiche le nom de l'élève
                if (rdr.HasRows)
                {
                    rdr.Read();
                    labelNomEquipe.Text = rdr["NomEquipe"].ToString();
                    labelDescription.Text = rdr["DescriptionEquipe"].ToString();


                }
                else
                {
                    labelNomEquipe.Text = "";
                    labelDescription.Text = "";
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

        private void buttonQuitterEquipe_Click(object sender, EventArgs e)
        {
            MySqlConnection con = null;
            MySqlCommand cmd = null;
            MySqlDataReader rdr = null;
            string commandText = "";

            try
            {
                commandText = "UPDATE joueurs setID_Equipe = NULL, WHERE ID = @ID;";
                con.Open();
                cmd = new MySqlCommand(commandText); // Création de la commande
                cmd.Connection = con; // Association de la commande avec la connexion

                cmd.Parameters.Add(new MySqlParameter("@ID", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "ID"));
                cmd.Parameters["@ID"].Value = Global.Id;

                #region Étape 3 : Exécuter la commande

                cmd.ExecuteNonQuery();

                labelDescription.Text = "";
                labelNomEquipe.Text = "";
                MessageBox.Show("Mise à jour complétée!");

                #endregion

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
                catch (Exception ex)
                {
                    // Affiche un message d'erreur
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    #region Étape 4 : Fermer la connexion

                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }

                    #endregion
                }
        }
    }
}
