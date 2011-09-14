using NerdGolfTracker.Befehle;

namespace NerdGolfTracker.Operationen
{
    public class Hilfe : Operation
    {
        public string FuehreAus(Scorecard scorecard)
        {
            return "Ich helfe dir beim Fuehren der Scorecard. Ich reagiere auf folgende Befehle: " +
                   HilfstextFuer(new SchlagBefehl()) + ", " +
                   HilfstextFuer(new LochwechselBefehl()) + ", " +
                   HilfstextFuer(new HilfeBefehl()) + ".";
        }

        private string HilfstextFuer(Befehl befehl)
        {
            return string.Format("\"{0}\" {1}", befehl.Kommando, befehl.Erklaerung);
        }
    }
}