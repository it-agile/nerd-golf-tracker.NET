using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;

namespace UnitTests.Operationen
{
    [TestClass]
    public class LochwechselTest
    {
        private Mock<Scorecard> _scorecardMock;
        private Mock<Operation> _folgeOperationMock;
        private Lochwechsel _lochwechsel;

        [TestInitialize]
        public void Init()
        {
            _scorecardMock = new Mock<Scorecard>();
            _folgeOperationMock = new Mock<Operation>();
            _lochwechsel = new Lochwechsel(_folgeOperationMock.Object);
        }

        [TestMethod]
        public void SchliesstLochAb()
        {
            _lochwechsel.FuehreAus(_scorecardMock.Object);
            _scorecardMock.Verify(scorecard => scorecard.SchliesseLochAb());
        }

        [TestMethod]
        public void FuehrtFolgeOperationMitAus()
        {
            _lochwechsel.FuehreAus(_scorecardMock.Object);
            _folgeOperationMock.Verify(operation => operation.FuehreAus(_scorecardMock.Object));
        }

    }
}
