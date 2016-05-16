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

//À FAIRE: Trier le datagridview.
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
            if (Global.Id_Equipes != 0)
            {
                MessageBox.Show("Vous devez quitter votre équipe pour pouvoir en créer une.");
            }
            else
            {
                FormCreerEquipe formCreerEquipe = new FormCreerEquipe();
                formCreerEquipe.Show();
            }
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

        private void buttonQuitterEquipe_Click(object sender, EventArgs e)
        {
            if (Global.Id_Equipes == 0)
            {
                MessageBox.Show("Vous devez être dans une équipe pour pouvoir la quitter");
            }
            else
            {
                MySqlConnection con = null;
                MySqlCommand cmd = null;
                MySqlDataReader rdr = null;
                string commandText = "";
                try
                {
                    con = new MySqlConnection(Global.ConnexionString);
                    con.Open();
                    commandText = "UPDATE Joueurs SET ID_Equipes = @ID_Equipes WHERE ID = @ID";
                    cmd = new MySqlCommand(commandText);
                    cmd.Connection = con;
                    cmd.Parameters.Add(new MySqlParameter("@ID_Equipes", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "ID_Equipes"));
                    cmd.Parameters.Add(new MySqlParameter("@ID", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "ID"));
                    cmd.Parameters["@ID_Equipes"].Value = DBNull.Value;
                    cmd.Parameters["@ID"].Value = Global.Id;
                    cmd.ExecuteNonQuery();
                    Global.Id_Equipes = 0;
                    MessageBox.Show("Vous avez quitté votre équipe");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur" + ex);
                }
                finally
                {
                    if (rdr != null)
                    {
                        rdr.Close();
                    }
                    if (con != null)
                    {
                        con.Close();
                    }
                }
                buttonRafraichir.PerformClick();
            }
        }

        private void FormEquipe_Load(object sender, EventArgs e)
        {
            this.joueursTableAdapter.Fill(this.dataSetPong.joueurs);
            List<int> listeJoueurs = new List<int>();
            int pointage = 0;
            if (Global.Id_Equipes == 0)
            {
                labelDescription.Text = "";
                labelNomEquipe.Text = "";
            }
            else
            {
                MySqlConnection con = null;
                MySqlCommand cmd = null;
                MySqlDataReader rdr = null;
                string commandText = "";
                try
                {
                    con = new MySqlConnection(Global.ConnexionString);
                    con.Open();
                    commandText = "SELECT NomEquipe, DescriptionEquipe FROM Equipes WHERE ID = @ID";
                    cmd = new MySqlCommand(commandText);
                    cmd.Connection = con;
                    cmd.Parameters.Add(new MySqlParameter("@ID", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "ID"));
                    cmd.Parameters["@ID"].Value = Global.Id_Equipes;
                    rdr = cmd.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        rdr.Read();
                        labelNomEquipe.Text = rdr["NomEquipe"].ToString();
                        labelDescription.Text = rdr["DescriptionEquipe"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur" + ex);
                }
                finally
                {
                    if (rdr != null)
                    {
                        rdr.Close();
                    }
                    if (con != null)
                    {
                        con.Close();
                    }
                }
                con = null;
                cmd = null;
                rdr = null;
                commandText = "";
                try
                {
                    con = new MySqlConnection(Global.ConnexionString);
                    con.Open();
                    commandText = "SELECT ID FROM Joueurs WHERE ID_Equipes = @ID_Equipes";
                    cmd = new MySqlCommand(commandText);
                    cmd.Connection = con;
                    cmd.Parameters.Add(new MySqlParameter("@ID_Equipes", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "ID_Equipes"));
                    cmd.Parameters["@ID_Equipes"].Value = Global.Id_Equipes;
                    rdr = cmd.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            listeJoueurs.Add(Convert.ToInt16(rdr["ID"]));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur" + ex);
                }
                finally
                {
                    if (rdr != null)
                    {
                        rdr.Close();
                    }
                    if (con != null)
                    {
                        con.Close();
                    }
                }
                con = null;
                cmd = null;
                rdr = null;
                commandText = "";
                //Points
                for (int i = 0; i < listeJoueurs.Count; i++)
                {
                    try
                    {
                        con = new MySqlConnection(Global.ConnexionString);
                        con.Open();
                        commandText = "SELECT COUNT(*) FROM Parties WHERE (ID_Joueurs1 = @ID AND ResultatJoueur1 > ResultatJoueur2) OR (ID_Joueurs2 = @ID AND ResultatJoueur2 > ResultatJoueur1)";
                        cmd = new MySqlCommand(commandText);
                        cmd.Connection = con;
                        cmd.Parameters.Add(new MySqlParameter("@ID", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "ID"));
                        cmd.Parameters["@ID"].Value = listeJoueurs.ElementAt(i);
                        rdr = cmd.ExecuteReader();
                        if (rdr.HasRows)
                        {
                            rdr.Read();
                            pointage += Convert.ToInt16(rdr["COUNT(*)"]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur" + ex);
                    }
                    finally
                    {
                        if (rdr != null)
                        {
                            rdr.Close();
                        }
                        if (con != null)
                        {
                            con.Close();
                        }
                    }
                }
                labelPointage.Text = pointage.ToString();
            }
        }

        private void buttonRafraichir_Click(object sender, EventArgs e)
        {
            this.joueursTableAdapter.Fill(this.dataSetPong.joueurs);
            if (Global.Id_Equipes == 0)
            {
                labelDescription.Text = "";
                labelNomEquipe.Text = "";
                labelPointage.Text = "";
            }
            else
            {
                MySqlConnection con = null;
                MySqlCommand cmd = null;
                MySqlDataReader rdr = null;
                string commandText = "";
                try
                {
                    con = new MySqlConnection(Global.ConnexionString);
                    con.Open();
                    commandText = "SELECT NomEquipe, DescriptionEquipe FROM Equipes WHERE ID = @ID";
                    cmd = new MySqlCommand(commandText);
                    cmd.Connection = con;
                    cmd.Parameters.Add(new MySqlParameter("@ID", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "ID"));
                    cmd.Parameters["@ID"].Value = Global.Id_Equipes;
                    rdr = cmd.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        rdr.Read();
                        labelNomEquipe.Text = rdr["NomEquipe"].ToString();
                        labelDescription.Text = rdr["DescriptionEquipe"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur" + ex);
                }
                finally
                {
                    if (rdr != null)
                    {
                        rdr.Close();
                    }
                    if (con != null)
                    {
                        con.Close();
                    }
                }
            }
        }
    }
}
