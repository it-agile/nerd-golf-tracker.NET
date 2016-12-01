using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class HilfeBefehl : Befehl
    {
        public string Kommando => "Hilfe";

        public Operation Operation => new Hilfe();

        public string Erklaerung => "zeigt Dir diese Erklaerung";
    }
}