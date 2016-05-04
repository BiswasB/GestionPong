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

        /// <summary>
        /// Accesseur en lecture et écriture à la valeur de l'ID.
        /// </summary>
        public static int ID
        {
            get { return id; }
            set { id = value; }
        }
    }
}
