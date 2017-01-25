using Moq;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;
using NUnit.Framework;

namespace UnitTests.Operationen
{
    [TestFixture]
    public class LochausgabeTest
    {
        [Test]
        public void LiefertTextMitAktuellemLoch()
        {
            var scorecardStub = new Mock<Scorecard>();
            scorecardStub.Setup(scorecard => scorecard.Lochnummer).Returns(2);
            Assert.That(new Lochausgabe().FuehreAus(scorecardStub.Object), Contains.Substring("auf dem 2.Loch"));
        }
    }
}
