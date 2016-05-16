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
    public partial class FormCartesCredit : Form
    {
        public FormCartesCredit()
        {
            InitializeComponent();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            FormAjouterCarteCredit formAjouterCarteCredit = new FormAjouterCarteCredit();
            formAjouterCarteCredit.Show();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxCartes_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = null;
            MySqlCommand cmd = null;
            MySqlDataReader rdr = null;
            string commandText = "";
            int idMarque = 0;
            try
            {
                //Établir la connexion
                con = new MySqlConnection(Global.ConnexionString); //À faire: Nom de connexion string.
                con.Open();
                //Créer la commande
                commandText = "SELECT Numero, ID_MarquesCredit, DateExpiration FROM cartescredit WHERE ID = @ID"; //Commande à exécuter
                cmd = new MySqlCommand(commandText); //Création de la commande
                cmd.Connection = con; //Association de la commande à la connexion

                cmd.Parameters.Add(new MySqlParameter("@ID", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "ID"));

                cmd.Parameters["@ID"].Value = int.Parse(comboBoxCartes.Text);

                rdr = cmd.ExecuteReader();

                // Effectuer le traitement
                // Affiche le nom de l'élève
                if (rdr.HasRows)
                {
                    rdr.Read();
                    textBoxNumero.Text = rdr["Numero"].ToString();
                    dateTimePickerDateExpiration.Value = Convert.ToDateTime(rdr["DateNaissance"]);
                    idMarque = (int)rdr["ID_MarquesCredit"];
                }
                else
                {
                    MessageBox.Show("Aucune carte trouvée");
                }
                //Établir la connexion
                con = new MySqlConnection(Global.ConnexionString); //À faire: Nom de connexion string.
                con.Open();
                //Créer la commande
                commandText = "SELECT Marque FROM marquecredit WHERE ID = @ID"; //Commande à exécuter
                cmd = new MySqlCommand(commandText); //Création de la commande
                cmd.Connection = con; //Association de la commande à la connexion

                cmd.Parameters.Add(new MySqlParameter("@ID", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "ID"));

                cmd.Parameters["@ID"].Value = idMarque;

                rdr = cmd.ExecuteReader();

                // Effectuer le traitement
                // Affiche le nom de l'élève
                if (rdr.HasRows)
                {
                    rdr.Read();
                    comboBoxMarque.Text = rdr["Marque"].ToString();
                }
                else
                {
                    MessageBox.Show("Aucune carte trouvée");
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
            int idMarque = 0;
            MySqlConnection con = null;
            MySqlCommand cmd = null;
            MySqlDataReader rdr = null;
            string commandText = "";

            try
            {
                con = new MySqlConnection(Global.ConnexionString); //À faire: Nom de connexion string.
                con.Open();
                //Créer la commande
                commandText = "SELECT ID FROM marquecredit WHERE Marque = @Marque"; //Commande à exécuter
                cmd = new MySqlCommand(commandText); //Création de la commande
                cmd.Connection = con; //Association de la commande à la connexion

                cmd.Parameters.Add(new MySqlParameter("@Marque", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "Marque"));

                cmd.Parameters["@Marque"].Value = comboBoxMarque.Text;

                rdr = cmd.ExecuteReader();

                // Effectuer le traitement
                // Affiche le nom de l'élève
                if (rdr.HasRows)
                {
                    rdr.Read();
                    idMarque = (int)rdr["ID"];
                }
                else
                {
                    MessageBox.Show("Aucune marque trouvée");
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

            try
            {
                commandText = "UPDATE cartescredit setNumero = @Numero, DateExpiration = @DateExpiration, ID_MarquesCredit = @ID_MarquesCredit WHERE ID = @ID;";
                con.Open();
                cmd = new MySqlCommand(commandText); // Création de la commande
                cmd.Connection = con; // Association de la commande avec la connexion
                                      // Ajouter les paramètres (Plus sécuritaire)
                cmd.Parameters.Add(new MySqlParameter("@Numero", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "Numero"));
                cmd.Parameters.Add(new MySqlParameter("@DateExpiration", MySql.Data.MySqlClient.MySqlDbType.DateTime, -1, "DateExpiration"));
                cmd.Parameters.Add(new MySqlParameter("@ID_MarquesCredit", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "ID_MarquesCredit"));
                cmd.Parameters.Add(new MySqlParameter("@ID", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "ID"));

                // Récupère les valeurs entrées dans les zones de texte
                cmd.Parameters["@Numero"].Value = int.Parse(textBoxNumero.Text);
                cmd.Parameters["@DateExpiration"].Value = dateTimePickerDateExpiration.Value;
                cmd.Parameters["@ID_MarquesCredit"].Value = idMarque;
                cmd.Parameters["@ID"].Value = int.Parse(comboBoxCartes.Text);
                
                #region Étape 3 : Exécuter la commande

                cmd.ExecuteNonQuery();

                MessageBox.Show("Mise à jour complétée!");

                #endregion

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
