using NerdGolfTracker.Operationen;

namespace NerdGolfTracker
{
    public class EinfacherInterpreter : Interpreter
    {
        public Operation OperationFuer(string kommando)
        {
            if (kommando == "Naechstes Loch")
            {
                return new Lochwechsel();
            }

            return new Schlag();
        }
    }
}
