using System.Collections.Generic;
using NerdGolfTracker.Befehle;

namespace NerdGolfTracker
{
    class AlleBefehle
    {
        public List<Befehl> Befehle()
        {
            return new List<Befehl>
                       {
                           new LochwechselBefehl(),
                           new SchlagBefehl(),
                           new HilfeBefehl(),
                       };
        } 
    }
}
