using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operateur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duree temps = new Duree();
            temps.Heures = 2;
            temps.Minutes = 30;
            temps.Secondes = 30;

            temps.CalculTemps();

            console.ReadKey();
        }
    }
}
