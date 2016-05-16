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
            // TODO: cette ligne de code charge les données dans la table 'dataSetPong.province'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.provinceTableAdapter.Fill(this.dataSetPong.province);
            // TODO: cette ligne de code charge les données dans la table 'dataSetPong.pays'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.paysTableAdapter.Fill(this.dataSetPong.pays);
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
                commandText = "SELECT Pseudonyme, NomJoueur, Prenom, MotdePasse, Courriel, MotdePasse, DateNaissance, NumeroCivique, Rue, CodePostal, NomVille, NomProvince, NomPays FROM joueurs, adresse, ville, province, pays WHERE joueurs.ID = " + Global.Id + " and joueurs.ID_Adresse = adresse.id and adresse.ID_Ville = ville.id and ville.ID_Province = province.id and province.ID_Pays = pays.id; "; //Commande à exécuter
                cmd = new MySqlCommand(commandText); //Création de la commande
                cmd.Connection = con; //Association de la commande à la connexion

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
                    dateTimePickerDateDeNaissance.Value = Convert.ToDateTime(rdr["DateNaissance"]);
                    textBoxMotdePasseActuel.Text = rdr["MotdePasse"].ToString();
                    textBoxNumeroCivique.Text = rdr["NumeroCivique"].ToString();
                    textBoxRue.Text = rdr["Rue"].ToString();
                    textBoxCodePostal.Text = rdr["CodePostal"].ToString();
                    textBoxVille.Text = rdr["NomVille"].ToString();
                    comboBoxProvince.Text = rdr["NomProvince"].ToString();
                    comboBoxPays.Text = rdr["NomPays"].ToString();

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

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            
            MySqlConnection con = null;
            MySqlCommand cmd = null;
            MySqlDataReader rdr = null;
            string commandText = "";

            if(textBoxMotdePasseActuel.Text != Global.MotDePasse)
            {
                MessageBox.Show("Le mot de passe actuel est incorrect");
            }
            else if(textBoxNouveauMotdePasse.Text != textBoxConfirmationNouveauMotDePasse.Text)
            {
                MessageBox.Show("La confirmation du mot de passe est incorrect");
            }
            else
            {
                try
                {
                    con = new MySqlConnection(Global.ConnexionString); //À faire: Nom connexionString
                    con.Open();
                    //Créer la commande
                    commandText = "SELECT ID FROM province WHERE province.NomProvince = @NomProvince; "; //Commande à exécuter
                    cmd = new MySqlCommand(commandText); //Création de la commande
                    cmd.Connection = con; //Association de la commande à la connexion
                                          //Ajouter les paramètres(Nom, Type, Taille dans la table, type dans la table)

                    cmd.Parameters.Add(new MySqlParameter("@NomProvince", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "NomProvince"));

                    cmd.Parameters["@NomProvince"].Value = comboBoxProvince.Text;

                    rdr = cmd.ExecuteReader();

                    // Effectuer le traitement
                    // Affiche le nom de l'élève
                    if (rdr.HasRows)
                    {
                        rdr.Read();
                        Global.Id_Province = (int)rdr["ID"];
                    }

                    if (rdr != null)
                    {
                        rdr.Close();
                    }
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }

                    commandText = "UPDATE joueurs, adresse, ville setjoueurs.MotdePasse = @MotdePasse, joueurs.Prenom = @Prenom, joueurs.NomJoueur = @NomJoueur, joueurs.Courriel = @Courriel, joueurs.DateNaissance = @DateNaissance, adresse.NumeroCivique = @NumeroCivique, adresse.Rue = @Rue, ville.NomVille = @NomVille, adresse.CodePostal = @CodePostal, ville.ID_Province = @ID_Province  WHERE joueurs.ID = @ID;";
                    con.Open();
                    cmd = new MySqlCommand(commandText); // Création de la commande
                    cmd.Connection = con; // Association de la commande avec la connexion
                                          // Ajouter les paramètres (Plus sécuritaire)
                    cmd.Parameters.Add(new MySqlParameter("@MotdePasse", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "MotdePasse"));
                    cmd.Parameters.Add(new MySqlParameter("@Prenom", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "Prenom"));
                    cmd.Parameters.Add(new MySqlParameter("@NomJoueur", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "NomJoueur"));
                    cmd.Parameters.Add(new MySqlParameter("@Courriel", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "Courriel"));
                    cmd.Parameters.Add(new MySqlParameter("@DateNaissance", MySql.Data.MySqlClient.MySqlDbType.DateTime, -1, "DateNaissance"));
                    cmd.Parameters.Add(new MySqlParameter("@NumeroCivique", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "NumeroCivique"));
                    cmd.Parameters.Add(new MySqlParameter("@Rue", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "Rue"));
                    cmd.Parameters.Add(new MySqlParameter("@NomVille", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "NomVille"));
                    cmd.Parameters.Add(new MySqlParameter("@CodePostal", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "CodePostal"));
                    cmd.Parameters.Add(new MySqlParameter("@ID_Province", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "ID_Province"));
                    cmd.Parameters.Add(new MySqlParameter("@ID", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "joueurs.ID"));

                    // Récupère les valeurs entrées dans les zones de texte
                    cmd.Parameters["@Prenom"].Value = textBoxPrenom.Text;
                    cmd.Parameters["@NomJoueur"].Value = textBoxNom.Text;
                    cmd.Parameters["@MotdePasse"].Value = textBoxNouveauMotdePasse.Text;
                    cmd.Parameters["@Courriel"].Value = textBoxCourriel.Text;
                    cmd.Parameters["@DateNaissance"].Value = dateTimePickerDateDeNaissance.Value;
                    cmd.Parameters["@NumeroCivique"].Value = int.Parse(textBoxNumeroCivique.Text);
                    cmd.Parameters["@Rue"].Value = textBoxRue.Text;
                    cmd.Parameters["@NomVille"].Value = textBoxVille.Text;
                    cmd.Parameters["@CodePostal"].Value = textBoxCodePostal.Text;
                    cmd.Parameters["@ID_Province"].Value = Global.Id_Province;
                    cmd.Parameters["@ID"].Value = Global.Id;



                    #region Étape 3 : Exécuter la commande

                    cmd.ExecuteNonQuery();

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
}
