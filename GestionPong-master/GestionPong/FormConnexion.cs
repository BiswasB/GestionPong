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
                con = new MySqlConnection(Global.ConnexionString); //À faire: Nom connexionString
                con.Open();
                commandText = "SELECT ID, MotdePasse FROM joueurs WHERE Pseudonyme = @Pseudonyme";
                cmd = new MySqlCommand(commandText);
                cmd.Connection = con;
                cmd.Parameters.Add(new MySqlParameter("@Pseudonyme", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "Pseudonyme"));
                cmd.Parameters.Add(new MySqlParameter("@MotdePasse", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "MotdePasse"));
                cmd.Parameters["@Pseudonyme"].Value = textBoxPseudonyme.Text;
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    if (rdr["MotdePasse"].ToString() == textBoxMotdePasse.Text)
                    {
                        Global.Id = (int)rdr["ID"]; //Variable globale permettan à l'ID de suivre.
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
