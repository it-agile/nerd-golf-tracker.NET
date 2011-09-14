using System.Collections.Generic;
using NerdGolfTracker.Befehle;

namespace NerdGolfTracker.Operationen
{
    public class Hilfe : Operation
    {
        private List<Befehl> _befehle = new List<Befehl> {
            new LochwechselBefehl(),
            new SchlagBefehl(),
            new HilfeBefehl(),
        };

        public string FuehreAus(Scorecard scorecard)
        {
            return "Ich helfe dir beim Fuehren der Scorecard. Ich reagiere auf folgende Befehle: " +
                   string.Join(", ", _befehle.ConvertAll(HilfstextFuer))
                   + ".";
        }

        private string HilfstextFuer(Befehl befehl)
        {
            return string.Format("\"{0}\" {1}", befehl.Kommando, befehl.Erklaerung);
        }
    }
}