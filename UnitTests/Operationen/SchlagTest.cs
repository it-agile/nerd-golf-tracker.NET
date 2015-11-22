using Moq;
using NUnit.Framework;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;

namespace UnitTests.Operationen
{
    [TestFixture]
    public class SchlagTest
    {
        private Mock<Scorecard> _scorecardMock;
        private Mock<Operation> _folgeOperationMock;
        private Schlag _schlag;

        [SetUp]
        public void Init()
        {
            _scorecardMock = new Mock<Scorecard>();
            _folgeOperationMock = new Mock<Operation>();
            _schlag = new Schlag(_folgeOperationMock.Object);
        }

        [Test]
        public void ErhoehtDieSchlagzahlAufDerScorecard()
        {
            _schlag.FuehreAus(_scorecardMock.Object);
            _scorecardMock.Verify(scorecard => scorecard.ErhoeheAnzahlSchlaege());
        }

        [Test]
        public void FuehrtFolgeOperationAus()
        {
            _schlag.FuehreAus(_scorecardMock.Object);
            _folgeOperationMock.Verify(operation => operation.FuehreAus(_scorecardMock.Object));
        }

    }
}
