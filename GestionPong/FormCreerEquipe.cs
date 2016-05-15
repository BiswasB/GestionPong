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
    public partial class FormCreerEquipe : Form
    {
        public FormCreerEquipe()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreer_Click(object sender, EventArgs e)
        {
            if (textBoxNom.Text == "")
            {
                MessageBox.Show("Entrez un nom pour l'équipe");
            }
            else if (richTextBoxDescription.Text == "")
            {
                MessageBox.Show("Entrez une description pour l'équipe");
            }
            else
            {
                MySqlConnection conEquipe = null;
                MySqlCommand cmdEquipe = null;
                MySqlDataReader rdrEquipe = null;
                string commandTextEquipe = "";
                try
                {
                    conEquipe = new MySqlConnection(Global.ConnexionString);
                    conEquipe.Open();
                    commandTextEquipe = "SELECT NomEquipe FROM Equipes WHERE NomEquipe = @NomEquipe";
                    cmdEquipe = new MySqlCommand(commandTextEquipe);
                    cmdEquipe.Connection = conEquipe;
                    cmdEquipe.Parameters.Add(new MySqlParameter("NomEquipe", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "@NomEquipe"));
                    cmdEquipe.Parameters["@NomEquipe"].Value = textBoxNom.Text;
                    rdrEquipe = cmdEquipe.ExecuteReader();
                    if (rdrEquipe.HasRows)
                    {
                        MessageBox.Show("Une équipe existe déjà avec ce nom.");
                    }
                    else
                    {
                        rdrEquipe.Close();
                        rdrEquipe = null;
                        cmdEquipe = null;
                        commandTextEquipe = "INSERT INTO Equipes (NomEquipe, DescriptionEquipe) VALUES (@NomEquipe, @DescriptionEquipe)";
                        cmdEquipe = new MySqlCommand(commandTextEquipe);
                        cmdEquipe.Connection = conEquipe;
                        cmdEquipe.Parameters.Add(new MySqlParameter("@NomEquipe", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "NomEquipe"));
                        cmdEquipe.Parameters.Add(new MySqlParameter("@DescriptionEquipe", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "DescriptionEquipe"));
                        cmdEquipe.Parameters["@NomEquipe"].Value = textBoxNom.Text;
                        cmdEquipe.Parameters["@DescriptionEquipe"].Value = richTextBoxDescription.Text;
                        cmdEquipe.ExecuteNonQuery();
                        MessageBox.Show("Équipe créée");
                        if (rdrEquipe != null)
                        {
                            rdrEquipe.Close();
                        }
                        if (conEquipe != null)
                        {
                            conEquipe.Close();
                        }
                        //Trouver l'ID de la nouvelle équipe.
                        conEquipe = null;
                        cmdEquipe = null;
                        rdrEquipe = null;
                        commandTextEquipe = "";
                        conEquipe = new MySqlConnection(Global.ConnexionString);
                        conEquipe.Open();
                        commandTextEquipe = "SELECT ID FROM Equipes WHERE NomEquipe = @NomEquipe";
                        cmdEquipe = new MySqlCommand(commandTextEquipe);
                        cmdEquipe.Connection = conEquipe;
                        cmdEquipe.Parameters.Add(new MySqlParameter("@NomEquipe", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "NomEquipe"));
                        cmdEquipe.Parameters["@NomEquipe"].Value = textBoxNom.Text;
                        rdrEquipe = cmdEquipe.ExecuteReader();
                        if (rdrEquipe.HasRows)
                        {
                            rdrEquipe.Read();
                            Global.Id_Equipes = Convert.ToInt16((rdrEquipe["ID"]));
                        }
                        else
                        {
                            throw new ArgumentException();
                        }
                        //Insérer l'ID dans le joueur
                        rdrEquipe.Close();
                        rdrEquipe = null;
                        cmdEquipe = null;
                        commandTextEquipe = "UPDATE Joueurs set ID_Equipes = @ID_Equipes WHERE ID = @ID";
                        cmdEquipe = new MySqlCommand(commandTextEquipe);
                        cmdEquipe.Connection = conEquipe;
                        cmdEquipe.Parameters.Add(new MySqlParameter("@ID_Equipes", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "ID_Equipes"));
                        cmdEquipe.Parameters.Add(new MySqlParameter("@ID", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "ID"));
                        cmdEquipe.Parameters["@ID_Equipes"].Value = Global.Id_Equipes;
                        cmdEquipe.Parameters["@ID"].Value = Global.Id;
                        cmdEquipe.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur" + ex);
                }
                finally
                {
                    if (rdrEquipe != null)
                    {
                        rdrEquipe.Close();
                    }
                    if (conEquipe != null)
                    {
                        conEquipe.Close();
                    }
                }
            }
        }
    }
}
