using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class HilfeBefehl : Befehl
    {
        public string Kommando
        {
            get { return "Hilfe"; }
        }

        public Operation Operation
        {
            get { return new Hilfe(); }
        }
    }
}