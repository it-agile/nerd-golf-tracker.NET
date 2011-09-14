using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NerdGolfTracker.Operationen;

namespace NerdGolfTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var scorecard = new EinfacheScorecard();
            var tracker = new Tracker(new EinfacherInterpreter(), scorecard);
            Console.WriteLine(new Lochbegruessung().FuehreAus(scorecard));
            while (true)
            {
                var befehl = Console.ReadLine();
                Console.WriteLine(tracker.ReagiereAuf(befehl));                
            }
        }
    }
}
