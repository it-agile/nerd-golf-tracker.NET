using Moq;
using NUnit.Framework;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;

namespace UnitTests
{
    [TestFixture]
    class LochwechselTest
    {
        [Test]
        public void SchliesstLochAb()
        {
            var scorecardMock = new Mock<Scorecard>();
            new Lochwechsel().FuehreAus(scorecardMock.Object);
            scorecardMock.Verify(scorecard => scorecard.SchliesseLochAb());
        }
    }
}
