using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonAppli1_Git
{
    public class Etudiant : Personne
    {
        private string diplome;
        public Etudiant(int unId, string unNom, string unDiplome):base(unId, unNom)
        {
            this.diplome = unDiplome;
        }

        public override string ToString()
        {
            return base.ToString() + " - Diplôme = "+ this.diplome;
        }
    }
}
