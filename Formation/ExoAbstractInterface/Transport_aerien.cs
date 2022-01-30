using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marchandises
{
    internal class Transport_aerien : Transport
    {
        int poids;
        float prixU;
        public Transport_aerien()
        {
            this.prixU = 0;
            this.poids = 2;
        }
        public void Tarif()
        {
            Console.WriteLine("Le tarif est : " + prixU * poids);
        }
    }
}