using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
