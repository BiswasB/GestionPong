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
    }
}
