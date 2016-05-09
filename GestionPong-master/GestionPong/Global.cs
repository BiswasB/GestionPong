using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPong
{
    /// <summary>
    /// Classe globale pour avoir des variables accessibles à tous les forms.
    /// </summary>
    public static class Global
    {
        private static int id;
        private static int id_Adresse;
        private static int id_Equipes;
        private static int id_CouleurPlaquette;
        private static string connexionString = "server = 127.0.0.1;user id = root;database=pong;password=brian1234;";

        /// <summary>
        /// Accesseur en lecture et écriture à la valeur de l'ID.
        /// </summary>
        public static int Id
        {
            get { return id; }
            set { id = value; }
        }

        public static int Id_Adresse
        {
            get { return id_Adresse; }
            set { id_Adresse = value; }
        }

        public static int Id_Equipes
        {
            get { return id_Equipes; }
            set { id_Equipes = value; }
        }

        public static int Id_CouleurPlaquette
        {
            get { return id_CouleurPlaquette; }
            set { id_CouleurPlaquette = value; }
        }

        public static string ConnexionString
        {
            get { return connexionString; }
        }
    }
}
