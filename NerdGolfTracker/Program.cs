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
            var tracker = new Tracker();
            while (true)
            {
                var befehl = Console.ReadLine();
                Console.WriteLine(tracker.ReagiereAuf(befehl));                
            }
        }
    }
}
