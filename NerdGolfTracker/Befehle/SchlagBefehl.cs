using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class SchlagBefehl : Befehl
    {
        public string Kommando
        {
            get { return "Schlage Ball"; }
        }

        public Operation Operation
        {
            get { return new Schlag(); }
        }
    }
}