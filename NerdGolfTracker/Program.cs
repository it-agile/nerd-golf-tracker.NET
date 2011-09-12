using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NerdGolfTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            string befehl = Console.ReadLine();
            Console.WriteLine(new GolfTracker().ReagiereAuf(befehl));
        }
    }
}
