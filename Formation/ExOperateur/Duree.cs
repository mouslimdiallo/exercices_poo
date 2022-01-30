using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operateur
{
    internal class Duree
    {
        int Heures;
        int Minutes;
        int Secondes;
        int t, r;

        public Duree(int h, int m, int s)
        {

            this.Heures = h;
            this.Minutes = m;
            this.Secondes = s;

        }
        public void CalculTemps()
        {
            Console.WriteLine("Saisir une durée : ");
            int i = Console.ReadLine();

            this.Heures = i % 3600;
            r = i / 3600;
            this.Minutes = r / 60;
            this.Secondes = r % 60;

            Console.WriteLine(h "H:" m "M:" s "s");
           


        }

    }
}
