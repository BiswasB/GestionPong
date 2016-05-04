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
    public partial class FormTournoi : Form
    {
        public FormTournoi()
        {
            InitializeComponent();
        }

        private void buttonTournoiActif_Click(object sender, EventArgs e)
        {
            FormTournoiActif formTournoiActif = new FormTournoiActif();
            formTournoiActif.Show();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
