using Moq;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Operationen
{
    [TestClass]
    public class LochBegruessungTest
    {
        private Mock<Operation> _folgeOperationMock;
        private Lochbegruessung _lochbegruessung;
        private Mock<Scorecard> _scorecardMock;

        [TestInitialize]
        public void Init()
        {
            _folgeOperationMock = new Mock<Operation>();
            _scorecardMock = new Mock<Scorecard>();
            _lochbegruessung = new Lochbegruessung(_folgeOperationMock.Object);
        }

        [TestMethod]
        public void GibtBegruessungAus()
        {
            Assert.IsTrue(_lochbegruessung.FuehreAus(_scorecardMock.Object).StartsWith("Du bist"));
        }


        [TestMethod]
        public void FuehrtFolgeoperationMitAus()
        {
            _lochbegruessung.FuehreAus(_scorecardMock.Object);
            _folgeOperationMock.Verify(folgeOperation => folgeOperation.FuehreAus(_scorecardMock.Object));
        }

    }
}
