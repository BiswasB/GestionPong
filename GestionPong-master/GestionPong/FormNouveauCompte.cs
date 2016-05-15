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
            this.Close();
            FormEcranPrincipal formEcranPrincipal = new FormEcranPrincipal();
            formEcranPrincipal.Show();
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
