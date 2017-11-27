using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonAppli1_Git
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            // instanciation d'un objet Personne
            Personne p = new Personne(1, "Martin");
            Console.WriteLine(p.ToString());
            Console.ReadLine();
        }
    }
}
