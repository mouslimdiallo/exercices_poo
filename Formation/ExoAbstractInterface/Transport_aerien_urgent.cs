using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marchandises
{
    internal class Transport_aerien_urgent : Transport
    {
        int poids;
        float prixU;
        public void Tarif()
        {
            Console.WriteLine("Le tarif est : " + prixU * poids);
        }
    }
}