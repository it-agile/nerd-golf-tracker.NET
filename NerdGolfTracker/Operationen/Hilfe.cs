using System.Collections.Generic;
using NerdGolfTracker.Befehle;

namespace NerdGolfTracker.Operationen
{
    public class Hilfe : Operation
    {
        public string FuehreAus(Scorecard scorecard)
        {
            var hilfstexte = new AlleBefehle().Befehle().ConvertAll(HilfstextFuer);
            return "Ich helfe dir beim Fuehren der Scorecard. Ich reagiere auf folgende Befehle: " +
                   string.Join(", ", hilfstexte)
                   + ".";
        }

        private string HilfstextFuer(Befehl befehl)
        {
            return string.Format("\"{0}\" {1}", befehl.Kommando, befehl.Erklaerung);
        }
    }
}