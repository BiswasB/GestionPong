﻿using System;
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
            this.Hide();
            FormEcranPrincipal formEcranPrincipal = new FormEcranPrincipal();
            formEcranPrincipal.Show();
        }
    }
}
