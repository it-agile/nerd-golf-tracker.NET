namespace NerdGolfTracker.Operationen
{
    public class Hilfe : Operation
    {
        public string FuehreAus(Scorecard scorecard)
        {
            return "Ich helfe dir beim Fuehren der Scorecard. Ich reagiere auf folgende Befehle: " +
                   "\"Schlage Ball\" zaehlt einen Schlag, " +
                   "\"Naechstes Loch\" bringt Dich zum naechsten Loch, " +
                   "\"Hilfe\" zeigt diese Erklaerung.";
        }
    }
}