using NerdGolfTracker.Operationen;

namespace NerdGolfTracker
{
    public class LochwechselBefehl : Befehl
    {
        public string Kommando
        {
            get { return "Naechstes Loch"; }
        }

        public Operation Operation
        {
            get { return new Lochwechsel(); }
        }
    }
}