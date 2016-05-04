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
    }
}
