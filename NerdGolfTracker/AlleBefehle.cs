using System;
using System.Collections.Generic;
using System.Linq;
using NerdGolfTracker.Befehle;

namespace NerdGolfTracker
{
    class AlleBefehle
    {
        public List<Befehl> Befehle()
        {
            var befehle = new List<Befehl>();
            befehle.Add(new HilfeBefehl());
            befehle.Add(new LochwechselBefehl());
            befehle.Add(new SchlagBefehl());
            return befehle;
        }
    }
}
