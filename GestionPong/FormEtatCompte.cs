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
    public partial class FormEtatCompte : Form
    {
        private int partiesJouees;
        private int nombreForfaits;
        private int[] partiesParForfait;
        private int[] transactionsDeChaqueForfait;
        private int partiesAcheteesTotales;

        public FormEtatCompte()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEtatCompte_Load(object sender, EventArgs e)
        {
            if ((Global.DateExpirationPremium - DateTime.Now).Days >= 0)
            {
                labelJoursPremiumRestants.Text = ((Global.DateExpirationPremium - DateTime.Now).Days).ToString();
            }
            else
            {
                labelJoursPremiumRestants.Text = "0";
            }
            MySqlConnection conCompte = null;
            MySqlCommand cmdCompte = null;
            MySqlDataReader rdrCompte = null;
            string commandTextCompte = "";
            try
            {
                conCompte = new MySqlConnection(Global.ConnexionString);
                conCompte.Open();
                commandTextCompte = "SELECT Couleur FROM CouleurPlaquette WHERE ID = @ID";
                cmdCompte = new MySqlCommand(commandTextCompte);
                cmdCompte.Connection = conCompte;
                cmdCompte.Parameters.Add(new MySqlParameter("@Couleur", MySql.Data.MySqlClient.MySqlDbType.VarChar, -1, "Couleur"));
                cmdCompte.Parameters.Add(new MySqlParameter("@ID", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "ID"));
                cmdCompte.Parameters["@ID"].Value = Global.Id_CouleurPlaquette;
                rdrCompte = cmdCompte.ExecuteReader();
                if (rdrCompte.HasRows)
                {
                    rdrCompte.Read();
                    if (rdrCompte["Couleur"].ToString() != "")
                    {
                        labelCouleurPalette.Text = rdrCompte["Couleur"].ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erreur.");
            }
            if (rdrCompte != null)
            {
                rdrCompte.Close();
            }
            cmdCompte = null;
            rdrCompte = null;
            commandTextCompte = "";
            try
            {
                commandTextCompte = "SELECT COUNT(*) FROM Parties WHERE ID_Joueurs1 = @IDJoueur OR ID_Joueurs2 = @IDJoueur";
                cmdCompte = new MySqlCommand(commandTextCompte);
                cmdCompte.Connection = conCompte;
                cmdCompte.Parameters.Add(new MySqlParameter("@IDJoueur", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "IDJoueur"));
                cmdCompte.Parameters["@IDJoueur"].Value = (int)Global.Id;
                rdrCompte = cmdCompte.ExecuteReader();
                if (rdrCompte.HasRows)
                {
                    //Compter les parties jouées
                    rdrCompte.Read();
                    partiesJouees = Convert.ToInt16(rdrCompte["COUNT(*)"]);
                }
                if (rdrCompte != null)
                {
                    rdrCompte.Close();
                }
                cmdCompte = null;
                rdrCompte = null;
                commandTextCompte = "SELECT COUNT(*) FROM Forfaits";
                cmdCompte = new MySqlCommand(commandTextCompte);
                cmdCompte.Connection = conCompte;
                rdrCompte = cmdCompte.ExecuteReader();
                if (rdrCompte.HasRows)
                {
                    //Compter le nombre de forfaits
                    rdrCompte.Read();
                    nombreForfaits = Convert.ToInt16((rdrCompte["COUNT(*)"]));
                    partiesParForfait = new int[nombreForfaits];
                    transactionsDeChaqueForfait = new int[partiesParForfait.Length];
                }
                if (rdrCompte != null)
                {
                    rdrCompte.Close();
                }
                cmdCompte = null;
                rdrCompte = null;
                for (int i = 0; i < partiesParForfait.Length; i++)
                {
                    //Parties incluses dans chaque type de forfait
                    if (rdrCompte != null)
                    {
                        rdrCompte.Close();
                    }
                    cmdCompte = null;
                    rdrCompte = null;
                    commandTextCompte = "SELECT NombreParties FROM Forfaits WHERE ID = @ID";
                    cmdCompte = new MySqlCommand(commandTextCompte);
                    cmdCompte.Connection = conCompte;
                    cmdCompte.Parameters.Add(new MySqlParameter("@ID", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "ID"));
                    cmdCompte.Parameters["@ID"].Value = i + 1;
                    rdrCompte = cmdCompte.ExecuteReader();
                    if (rdrCompte.HasRows)
                    {
                        //Insérer
                        rdrCompte.Read();
                        partiesParForfait[i] = Convert.ToInt32(rdrCompte["NombreParties"]);
                    }
                }
                for (int i = 0; i < transactionsDeChaqueForfait.Length; i++)
                {
                    //Transactions
                    if (rdrCompte != null)
                    {
                        rdrCompte.Close();
                    }
                    cmdCompte = null;
                    rdrCompte = null;
                    commandTextCompte = "SELECT COUNT(*) FROM Transactions WHERE ID_Joueurs = @ID_Joueurs AND ID_Forfaits = @ID_Forfaits";
                    cmdCompte = new MySqlCommand(commandTextCompte);
                    cmdCompte.Connection = conCompte;
                    cmdCompte.Parameters.Add(new MySqlParameter("@ID_Joueurs", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "ID_Joueurs"));
                    cmdCompte.Parameters.Add(new MySqlParameter("@ID_Forfaits", MySql.Data.MySqlClient.MySqlDbType.Int16, -1, "ID_Forfaits"));
                    cmdCompte.Parameters["@ID_Joueurs"].Value = Global.Id;
                    cmdCompte.Parameters["@ID_Forfaits"].Value = i + 1;
                    rdrCompte = cmdCompte.ExecuteReader();
                    if (rdrCompte.HasRows)
                    {
                        rdrCompte.Read();
                        transactionsDeChaqueForfait[i] = Convert.ToInt16(rdrCompte["COUNT(*)"]);
                    }
                }
                partiesAcheteesTotales = 0;
                for (int i = 0; i < transactionsDeChaqueForfait.Length; i++)
                {
                    partiesAcheteesTotales += partiesParForfait[i] * transactionsDeChaqueForfait[i];
                }
                labelPartiesRestantes.Text = (partiesAcheteesTotales - partiesJouees).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur" + ex);
            }
            finally
            {
                if (rdrCompte != null)
                {
                    rdrCompte.Close();
                }
                if (conCompte.State == ConnectionState.Open)
                {
                    conCompte.Close();
                }
            }
        }
    }
}