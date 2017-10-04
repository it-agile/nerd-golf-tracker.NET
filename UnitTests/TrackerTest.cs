using Moq;
using NerdGolfTracker;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class TrackerTest
    {
        [TestMethod]
        public void GibtErgebnisDerAusgeloestenOperationZurueck()
        {
            var interpreterStub = new Mock<Interpreter>();
            var operationStub = new Mock<Operation>();
            interpreterStub.Setup(interpreter => interpreter.OperationFuer("Eingabe"))
                .Returns(operationStub.Object);
            operationStub.Setup(operation => operation.FuehreAus(It.IsAny<Scorecard>()))
                .Returns("Ausgabe");
            var tracker = new Tracker(interpreterStub.Object, null);
            Assert.AreEqual(tracker.ReagiereAuf("Eingabe"), "Ausgabe");
        }

        [TestMethod]
        public void GibtErgebnisDerStartoperationZurueck()
        {
            var startoperationStub = new Mock<Operation>();
            startoperationStub.Setup(operation => operation.FuehreAus(It.IsAny<Scorecard>()))
                .Returns("Ausgabe");
            var tracker = new Tracker(null, startoperationStub.Object);
            Assert.AreEqual(tracker.Starte(), "Ausgabe");
        }
    }
}