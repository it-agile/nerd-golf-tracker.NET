using System.Collections.Generic;
using NerdGolfTracker.Befehle;

namespace NerdGolfTracker
{
    public class EinfacherInterpreter : Interpreter
    {
        private List<Befehl> _befehle = new List<Befehl> {
            new LochwechselBefehl(),
            new SchlagBefehl(),
            new HilfeBefehl(),
        };

        public Operation OperationFuer(string kommando)
        {
            return _befehle.Find(befehl => kommando == befehl.Kommando).Operation;
        }
    }
}
