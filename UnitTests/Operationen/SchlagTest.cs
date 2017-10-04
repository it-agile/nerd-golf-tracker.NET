using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;

namespace UnitTests.Operationen
{
    [TestClass]
    public class SchlagTest
    {
        private Mock<Scorecard> _scorecardMock;
        private Mock<Operation> _folgeOperationMock;
        private Schlag _schlag;

        [TestInitialize]
        public void Init()
        {
            _scorecardMock = new Mock<Scorecard>();
            _folgeOperationMock = new Mock<Operation>();
            _schlag = new Schlag(_folgeOperationMock.Object);
        }

        [TestMethod]
        public void ErhoehtDieSchlagzahlAufDerScorecard()
        {
            _schlag.FuehreAus(_scorecardMock.Object);
            _scorecardMock.Verify(scorecard => scorecard.ErhoeheAnzahlSchlaege());
        }

        [TestMethod]
        public void FuehrtFolgeOperationAus()
        {
            _schlag.FuehreAus(_scorecardMock.Object);
            _folgeOperationMock.Verify(operation => operation.FuehreAus(_scorecardMock.Object));
        }

    }
}
