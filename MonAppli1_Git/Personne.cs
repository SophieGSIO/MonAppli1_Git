using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonAppli1_Git
{
    public class Personne
    {
        // attributs privés
        private int id;
        private string nom;
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="unId"></param>
        /// <param name="unNom"></param>
        public Personne(int unId, string unNom)
        {
            this.id = unId;
            this.nom = unNom;
        }
        /// <summary>
        /// Méthode ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.id + " " + this.nom;
        }
    }
}
