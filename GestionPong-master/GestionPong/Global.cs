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
        private static string connexionString = "server = 127.0.0.1;user id = root;database=pong;password=brian1234;";

        /// <summary>
        /// Accesseur en lecture et écriture à la valeur de l'ID.
        /// </summary>
        public static int ID
        {
            get { return id; }
            set { id = value; }
        }

        public static string ConnexionString
        {
            get { return connexionString; }
        }
    }
}
