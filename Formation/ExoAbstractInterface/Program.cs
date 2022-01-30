using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marchandises
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Transport_aerien aerien = new Transport_aerien();
            aerien.Tarif();

            Transport_aerien_urgent urgent = new Transport_aerien_urgent();
            urgent.Tarif();

            Transport_routier routier = new Transport_routier();
            routier.Calcul();


        }
    }
}
