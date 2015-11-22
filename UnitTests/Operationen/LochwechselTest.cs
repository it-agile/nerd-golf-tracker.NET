using Moq;
using NUnit.Framework;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;

namespace UnitTests.Operationen
{
    [TestFixture]
    class LochwechselTest
    {
        private Mock<Scorecard> _scorecardMock;
        private Mock<Operation> _folgeOperationMock;
        private Lochwechsel _lochwechsel;

        [SetUp]
        public void Init()
        {
            _scorecardMock = new Mock<Scorecard>();
            _folgeOperationMock = new Mock<Operation>();
            _lochwechsel = new Lochwechsel(_folgeOperationMock.Object);
        }

        [Test]
        public void SchliesstLochAb()
        {
            _lochwechsel.FuehreAus(_scorecardMock.Object);
            _scorecardMock.Verify(scorecard => scorecard.SchliesseLochAb());
        }

        [Test]
        public void FuehrtFolgeOperationMitAus()
        {
            _lochwechsel.FuehreAus(_scorecardMock.Object);
            _folgeOperationMock.Verify(operation => operation.FuehreAus(_scorecardMock.Object));
        }

    }
}
