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

        public Personne(int unId, string unNom)
        {
            this.id = unId;
            this.nom = unNom;
        }
    }
}
