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
    public partial class FormAjouterCarteCredit : Form
    {
        public FormAjouterCarteCredit()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            MySqlConnection con = null;
            MySqlCommand cmd = null;
            string commandText = "";
            MySqlDataReader rdr = null;

            try
            {
                int idCarte = 0;
                con = null;
                cmd = null;
                rdr = null;
                commandText = "";
                con = new MySqlConnection(Global.ConnexionString);
                con.Open();
                commandText = "SELECT ID FROM marquecredit WHERE Marque = @Marque;";
                cmd = new MySqlCommand(commandText);
                cmd.Connection = con;
                cmd.Parameters.Add(new MySqlParameter("@Marque", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "Marque"));
                cmd.Parameters["@Marque"].Value = /*comboBoxMarque.Text*/"Visa";
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    idCarte = (int)rdr["ID"];
                }

                #region Étape 1 : Établir la connexion avec la base de données

                con = new MySqlConnection(Global.ConnexionString);
                con.Open();

                #endregion

                #region Étape 2 : Inscrire la commande à exécuter

                // Créer la commande à exécuter
                commandText = "INSERT INTO cartescredit (Numero, ID_MarquesCredit, DateExpiration) VALUES (@Numero, @ID_MarquesCredit, @DateExpiration);";
                cmd = new MySqlCommand(commandText); // Création de la commande

                cmd.Connection = con; // Association de la commande avec la connexion



                // Ajouter les paramètres (Plus sécuritaire)
                cmd.Parameters.Add(new MySqlParameter("@Numero", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "Numero"));
                cmd.Parameters.Add(new MySqlParameter("@ID_MarquesCredit", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "ID_MarquesCredit"));
                cmd.Parameters.Add(new MySqlParameter("@DateExpiration", MySql.Data.MySqlClient.MySqlDbType.DateTime, -1, "DateExpiration"));

                // Récupère les valeurs entrées dans les zones de texte
                cmd.Parameters["@Numero"].Value = int.Parse(textBoxNumero.Text);
                cmd.Parameters["@ID_MarquesCredit"].Value = idCarte;
                cmd.Parameters["@DateExpiration"].Value = dateTimePickerDateExpiration.Value;

                #endregion

                cmd.ExecuteNonQuery();

                MessageBox.Show("Ajout complété!");
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
        }
    }
}
