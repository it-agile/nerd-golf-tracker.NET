using Moq;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;
using NUnit.Framework;

namespace UnitTests.Operationen
{
    [TestFixture]
    public class LochBegruessungTest
    {
        private Mock<Operation> _folgeOperationMock;
        private Lochbegruessung _lochbegruessung;
        private Mock<Scorecard> _scorecardMock;

        [SetUp]
        public void Init()
        {
            _folgeOperationMock = new Mock<Operation>();
            _scorecardMock = new Mock<Scorecard>();
            _lochbegruessung = new Lochbegruessung(_folgeOperationMock.Object);
        }

        [Test]
        public void GibtBegruessungAus()
        {
            Assert.That(_lochbegruessung.FuehreAus(_scorecardMock.Object), Does.StartWith("Du bist"));
        }


        [Test]
        public void FuehrtFolgeoperationMitAus()
        {
            _lochbegruessung.FuehreAus(_scorecardMock.Object);
            _folgeOperationMock.Verify(folgeOperation => folgeOperation.FuehreAus(_scorecardMock.Object));
        }

    }
}
