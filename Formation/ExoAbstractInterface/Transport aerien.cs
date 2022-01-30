using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marchandises
{
    abstract class Transport_aerien : Transport
    {
        double prix;
        int poids;

        // * 10

        public void Tarif(float prixU, int poids)
        {
            this.prixU = 10;
            this.prix = prixU;

            Console.WriteLine("Le tarif est : " + prixU * poids);
        }
    }
}
