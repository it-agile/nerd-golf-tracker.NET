using System;
using System.Collections.Generic;
using System.Linq;
using NerdGolfTracker.Operationen;

namespace NerdGolfTracker
{
    public class EinfacherInterpreter : Interpreter
    {
        private List<Befehl> _befehle = new List<Befehl>{new LochwechselBefehl()};

        public Operation OperationFuer(string kommando)
        {
            if (kommando == "Hilfe")
                return new Hilfe();

            if (kommando == "Schlage Ball")
                return new Schlag();

            return _befehle.Find(befehl => kommando == befehl.Kommando).Operation;
        }
    }
}
