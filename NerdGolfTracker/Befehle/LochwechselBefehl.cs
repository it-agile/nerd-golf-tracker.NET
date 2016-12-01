using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class LochwechselBefehl : Befehl
    {
        public string Kommando => "Naechstes Loch";

        public Operation Operation => new Lochwechsel(new Lochbegruessung(new Lochausgabe()));

        public string Erklaerung => "bringt Dich zum naechsten Loch";
    }
}