using System;
using System.Collections.Generic;
using System.Linq;

namespace NerdGolfTracker
{
    class AlleBefehle
    {
        public List<Befehl> Befehle()
        {
            var befehlstyp = typeof (Befehl);
            var alleBefehlstypen = 
                GetType().Assembly.GetTypes().Where(befehlstyp.IsAssignableFrom);
            var alleKonkretenBefehlstypen = alleBefehlstypen.Except(new[] { befehlstyp }).ToList();
            return alleKonkretenBefehlstypen.ConvertAll(b => Activator.CreateInstance(b) as Befehl);
        }
    }
}
