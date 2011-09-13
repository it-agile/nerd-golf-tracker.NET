using Moq;
using NerdGolfTracker;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class TrackerTest
    {
        [Test]
        public void GibtErgebnisDerAusgeloestenOperationZurueck()
        {
            var interpreterStub = new Mock<Interpreter>();
            var operationStub = new Mock<Operation>();
            interpreterStub.Setup(interpreter => interpreter.OperationFuer("Eingabe"))
                .Returns(operationStub.Object);
            operationStub.Setup(operation => operation.FuehreAus(It.IsAny<Scorecard>()))
                .Returns("Ausgabe");
            var tracker = new Tracker(interpreterStub.Object, new EinfacheScorecard());
            Assert.That(tracker.ReagiereAuf("Eingabe"), Is.EqualTo("Ausgabe"));
        }
    }
}