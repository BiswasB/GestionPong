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
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
        }

        private void buttonNouveauCompte_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNouveauCompte formNouveauCompte = new FormNouveauCompte();
            formNouveauCompte.Show();
        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            MySqlConnection con = null;
            MySqlCommand cmd = null;
            MySqlDataReader rdr = null;
            string commandText = "";
            try
            {
                con = new MySqlConnection(Global.ConnexionString);
                con.Open();
                commandText = "SELECT ID, MotdePasse, ID_Adresse, ID_Equipes, ID_CouleurPlaquette, DateExpirationPremium, NomJoueur, Prenom FROM Joueurs WHERE Pseudonyme = @Pseudonyme";
                cmd = new MySqlCommand(commandText);
                cmd.Connection = con;
                cmd.Parameters.Add(new MySqlParameter("@Pseudonyme", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "Pseudonyme"));
                cmd.Parameters.Add(new MySqlParameter("@MotdePasse", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "MotdePasse"));
                cmd.Parameters.Add(new MySqlParameter("@ID_Adresse", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "ID_Adresse"));
                cmd.Parameters.Add(new MySqlParameter("@ID_Equipes", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "ID_Equipes"));
                cmd.Parameters.Add(new MySqlParameter("@ID_CouleurPlaquette", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "ID_CouleurPlaquette"));
                cmd.Parameters.Add(new MySqlParameter("@DateExpirationPremium", MySql.Data.MySqlClient.MySqlDbType.DateTime, -1, "DateExpirationPremium"));
                cmd.Parameters.Add(new MySqlParameter("@NomJoueur", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "NomJoueur"));
                cmd.Parameters.Add(new MySqlParameter("@Prenom", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "Prenom"));
                cmd.Parameters["@Pseudonyme"].Value = textBoxPseudonyme.Text;
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    if (rdr["MotdePasse"].ToString() == textBoxMotdePasse.Text)
                    {
                        Global.Id = (int)rdr["ID"];
                        Global.Id_Adresse = (int)rdr["ID_Adresse"];
                        if (rdr["ID_CouleurPlaquette"].ToString() != "")
                        {
                            Global.Id_CouleurPlaquette = (int)rdr["ID_CouleurPlaquette"];
                        }
                        if (rdr["ID_Equipes"] == DBNull.Value)
                        {
                            Global.Id_Equipes = 0;
                        }
                        else
                        {
                            Global.Id_Equipes = (int)rdr["ID_Equipes"];
                        }
                        Global.DateExpirationPremium = (DateTime)rdr["DateExpirationPremium"];
                        Global.Nom = rdr["NomJoueur"].ToString();
                        Global.Prenom = rdr["Prenom"].ToString();
                        Global.Pseudonyme = (cmd.Parameters["@Pseudonyme"].Value).ToString();
                        this.Hide();
                        FormEcranPrincipal formEcranPrincipal = new FormEcranPrincipal();
                        formEcranPrincipal.Show();
                    }
                    else
                    {
                        textBoxMotdePasse.Text = "";
                        MessageBox.Show("Mauvais mot de passe.  Essayez à nouveau.");
                    }
                }
                else
                {
                    MessageBox.Show("Pseudonyme invalide.  Essayez à nouveau ou créez un compte.");
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
