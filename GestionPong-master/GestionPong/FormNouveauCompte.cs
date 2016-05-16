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
    public partial class FormNouveauCompte : Form
    {
        public FormNouveauCompte()
        {
            InitializeComponent();
        }

        private void buttonCreer_Click(object sender, EventArgs e)
        {
            if(textBoxMotdePasse.Text != textBoxConfirmationMotDePasse.Text)
            {
                MessageBox.Show("La confirmation du mot de passe ne correspond pas au mot de passe.");
            }
            else
            {
                MySqlConnection con = null;
                MySqlCommand cmd = null;
                MySqlCommand cmd2 = null;
                MySqlCommand cmd3 = null;
                string commandText = "";
                string commandText2 = "";
                string commandText3 = "";

                try
                {

                    #region Étape 1 : Établir la connexion avec la base de données

                    con = new MySqlConnection(Global.ConnexionString);
                    con.Open();

                    #endregion

                    #region Étape 2 : Inscrire la commande à exécuter

                    // Créer la commande à exécuter
                    commandText = "INSERT INTO joueurs (Pseudonyme, MotdePasse, Prenom, NomJoueur, Courriel, DateNaissance, ID_CouleurPlaquette) VALUES (@Pseudonyme, @MotdePasse, @Prenom, @NomJoueur, @Courriel, @DateNaissance, @ID_CouleurPlaquette);";
                    cmd = new MySqlCommand(commandText); // Création de la commande
                    commandText2 = "INSERT INTO adresse (NumeroCivique, Rue) VALUES (@NumeroCivique, @Rue)";
                    cmd2 = new MySqlCommand(commandText2);
                    commandText3 = "INSERT INTO ville(NomVille) VALUES (@NomVille)";
                    cmd3 = new MySqlCommand(commandText3);

                    cmd.Connection = con; // Association de la commande avec la connexion
                    cmd2.Connection = con;
                    cmd3.Connection = con;


                    // Ajouter les paramètres (Plus sécuritaire)
                    cmd.Parameters.Add(new MySqlParameter("@Pseudonyme", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "Pseudonyme"));
                    cmd.Parameters.Add(new MySqlParameter("@MotdePasse", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "MotdePasse"));
                    cmd.Parameters.Add(new MySqlParameter("@Prenom", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "Prenom"));
                    cmd.Parameters.Add(new MySqlParameter("@NomJoueur", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "NomJoueur"));
                    cmd.Parameters.Add(new MySqlParameter("@Courriel", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "Courriel"));
                    cmd.Parameters.Add(new MySqlParameter("@DateNaissance", MySql.Data.MySqlClient.MySqlDbType.DateTime, -1, "DateNaissance"));
                    cmd.Parameters.Add(new MySqlParameter("@ID_CouleurPlaquette", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "ID_CouleurPlaquette"));
                    cmd2.Parameters.Add(new MySqlParameter("@NumeroCivique", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "NumeroCivique"));
                    cmd2.Parameters.Add(new MySqlParameter("@Rue", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "Rue"));
                    cmd3.Parameters.Add(new MySqlParameter("@NomVille", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "NomVille"));


                    // Récupère les valeurs entrées dans les zones de texte
                    cmd.Parameters["@Pseudonyme"].Value = textBoxPseudonyme.Text;
                    cmd.Parameters["@MotdePasse"].Value = textBoxMotdePasse.Text;
                    cmd.Parameters["@Prenom"].Value = textBoxPrenom.Text;
                    cmd.Parameters["@NomJoueur"].Value = textBoxNom.Text;
                    cmd.Parameters["@Courriel"].Value = textBoxCourriel.Text;
                    cmd.Parameters["@DateNaissance"].Value = dateTimePickerDateDeNaissance.Value;
                    cmd.Parameters["@ID_CouleurPlaquette"].Value = 1;
                    cmd2.Parameters["@NumeroCivique"].Value = int.Parse(textBoxNumeroCivique.Text);
                    cmd2.Parameters["@Rue"].Value = textBoxRue.Text;
                    cmd3.Parameters["@NomVille"].Value = textBoxVille.Text;

                    #endregion

                    #region Étape 3 : Exécuter la commande

                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();

                    MessageBox.Show("Ajout complété!");
                    Global.Id = (int)cmd.LastInsertedId;
                    Global.Id_Equipes = 0;
                    Global.Id_CouleurPlaquette = 1;
                    Global.DateDerniereConnexion = DateTime.Today;
                    Global.MotDePasse = textBoxMotdePasse.Text;
                    Global.Nom = textBoxNom.Text;
                    Global.Prenom = textBoxPrenom.Text;
                    Global.Pseudonyme = textBoxPseudonyme.Text;

                    #endregion

                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }

                    MySqlDataReader rdr = null;

                    con = null;
                    cmd = null;
                    rdr = null;
                    commandText = "";
                    try
                    {
                        con = new MySqlConnection(Global.ConnexionString);
                        con.Open();
                        commandText = "SELECT ID FROM adresse WHERE NumeroCivique = @NumeroCivique and Rue = @Rue";
                        cmd = new MySqlCommand(commandText);
                        cmd.Connection = con;
                        cmd.Parameters.Add(new MySqlParameter("@NumeroCivique", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "NumeroCivique"));
                        cmd.Parameters.Add(new MySqlParameter("@Rue", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "Rue"));
                        cmd.Parameters["@NumeroCivique"].Value = int.Parse(textBoxNumeroCivique.Text);
                        cmd.Parameters["@Rue"].Value = textBoxRue.Text;
                        rdr = cmd.ExecuteReader();
                        if (rdr.HasRows)
                        {
                            rdr.Read();
                            Global.Id_Adresse = (int)rdr["ID"];
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur : " + ex);
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

                    //Trouver la ville
                    con = null;
                    cmd = null;
                    rdr = null;
                    commandText = "";
                    try
                    {
                        con = new MySqlConnection(Global.ConnexionString);
                        con.Open();
                        commandText = "SELECT ID FROM ville WHERE NomVille = @NomVille";
                        cmd = new MySqlCommand(commandText);
                        cmd.Connection = con;
                        cmd.Parameters.Add(new MySqlParameter("@NomVille", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "NomVille"));
                        cmd.Parameters["@NomVille"].Value = textBoxVille.Text;
                        rdr = cmd.ExecuteReader();
                        if (rdr.HasRows)
                        {
                            rdr.Read();
                            Global.Id_Ville = (int)rdr["ID"];
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur : " + ex);
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
                    //Trouver la province
                    con = null;
                    cmd = null;
                    rdr = null;
                    commandText = "";
                    try
                    {
                        con = new MySqlConnection(Global.ConnexionString);
                        con.Open();
                        commandText = "SELECT ID FROM province WHERE NomProvince = @NomProvince";
                        cmd = new MySqlCommand(commandText);
                        cmd.Connection = con;
                        cmd.Parameters.Add(new MySqlParameter("@NomProvince", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "NomProvince"));
                        cmd.Parameters["@NomProvince"].Value = comboBoxProvince.Text;
                        rdr = cmd.ExecuteReader();
                        if (rdr.HasRows)
                        {
                            rdr.Read();
                            Global.Id_Province = (int)rdr["ID"];
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur : " + ex);
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
                    //Trouver Pays
                    con = null;
                    cmd = null;
                    rdr = null;
                    commandText = "";
                    try
                    {
                        con = new MySqlConnection(Global.ConnexionString);
                        con.Open();
                        commandText = "SELECT ID_Pays FROM Province WHERE ID = @ID_Province";
                        cmd = new MySqlCommand(commandText);
                        cmd.Connection = con;
                        cmd.Parameters.Add(new MySqlParameter("@ID_Province", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "ID_Province"));
                        cmd.Parameters["@ID_Province"].Value = Global.Id_Province;
                        rdr = cmd.ExecuteReader();
                        if (rdr.HasRows)
                        {
                            rdr.Read();
                            Global.Id_Pays = (int)rdr["ID_Pays"];
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur : " + ex);
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

                    con.Open();

                    #region Étape 2 : Inscrire la commande à exécuter

                    // Créer la commande à exécuter
                    commandText = "UPDATE joueurs set ID_Adresse = @ID_Adresse WHERE joueurs.ID = @joueurs.ID";
                    cmd = new MySqlCommand(commandText); // Création de la commande
                    commandText2 = "UPDATE adresse set ID_Ville = @ID_Ville WHERE adresse.ID = @adresse.ID";
                    cmd2 = new MySqlCommand(commandText2);
                    commandText3 = "UPDATE ville set ID_Province = @ID_Province WHERE ville.ID = @ville.ID";
                    cmd3 = new MySqlCommand(commandText3);

                    #endregion

                    cmd.Connection = con; // Association de la commande avec la connexion
                    cmd2.Connection = con;
                    cmd3.Connection = con;
                    
                    // Ajouter les paramètres (Plus sécuritaire)
                    cmd.Parameters.Add(new MySqlParameter("@ID_Adresse", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "ID_Adresse"));
                    cmd2.Parameters.Add(new MySqlParameter("@ID_Ville", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "ID_Ville"));
                    cmd3.Parameters.Add(new MySqlParameter("@ID_Province", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "ID_Province"));
                    cmd.Parameters.Add(new MySqlParameter("@joueurs.ID", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "joueurs.ID"));
                    cmd2.Parameters.Add(new MySqlParameter("@adresse.ID", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "adresse.ID"));
                    cmd3.Parameters.Add(new MySqlParameter("@ville.ID", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "ville.ID"));

                    cmd.Parameters["@ID_Adresse"].Value = Global.Id_Adresse;
                    cmd.Parameters["@joueurs.ID"].Value = Global.Id;
                    cmd2.Parameters["@ID_Ville"].Value = Global.Id_Ville;
                    cmd2.Parameters["@adresse.ID"].Value = Global.Id_Adresse;
                    cmd3.Parameters["@ID_Province"].Value = Global.Id_Province;
                    cmd3.Parameters["@ville.ID"].Value = Global.Id_Ville;

                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();

                    MessageBox.Show("Ajout complété!");

                    if (rdr != null)
                    {
                        rdr.Close();
                    }
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }

                    con.Open();

                    commandText = "UPDATE joueurs set DateDerniereConnexion = @DateDerniereConnexion WHERE ID = @ID";
                    cmd = new MySqlCommand(commandText); // Création de la commande

                    cmd.Connection = con; // Association de la commande avec la connexion

                    // Ajouter les paramètres (Plus sécuritaire)
                    cmd.Parameters.Add(new MySqlParameter("@DateDerniereConnexion", MySql.Data.MySqlClient.MySqlDbType.DateTime, -1, "DateDerniereConnexion"));
                    cmd.Parameters.Add(new MySqlParameter("@ID", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "ID"));

                    cmd.Parameters["@DateDerniereConnexion"].Value = Global.DateDerniereConnexion;
                    cmd.Parameters["@ID"].Value = Global.Id;

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Ajout complété!");

                    this.Close();
                    FormEcranPrincipal formEcranPrincipal = new FormEcranPrincipal();
                    formEcranPrincipal.Show();
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

        private void FormNouveauCompte_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSetPong.province'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.provinceTableAdapter.Fill(this.dataSetPong.province); 
            // TODO: cette ligne de code charge les données dans la table 'dataSetPong.pays'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.paysTableAdapter.Fill(this.dataSetPong.pays);

        }
    }
}
