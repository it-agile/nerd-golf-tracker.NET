using System.Collections.Generic;
using NerdGolfTracker.Befehle;

namespace NerdGolfTracker
{
    public class EinfacherInterpreter : Interpreter
    {
        public Operation OperationFuer(string kommando)
        {
            List<Befehl> befehle = new AlleBefehle().Befehle();
            return befehle.Find(befehl => kommando == befehl.Kommando).Operation;
        }
    }
}
