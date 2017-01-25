using System;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class EinfacherInterpreterTest
    {
        [Test]
        public void FindetAlleOperationenZubefehlen()
        {
            FindetOperation("Naechstes Loch", typeof(Lochwechsel));
            FindetOperation("Schlage Ball", typeof(Schlag));
            FindetOperation("Hilfe", typeof(Hilfe));
        }

        public void FindetOperation(string kommando, Type operationstyp)
        {
            Interpreter interpreter = new EinfacherInterpreter();
            Assert.That(interpreter.OperationFuer(kommando), Is.InstanceOf(operationstyp));
        }
    }
}
