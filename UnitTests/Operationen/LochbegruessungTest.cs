using Moq;
using NUnit.Framework;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;

namespace UnitTests.Operationen
{
    [TestFixture]
    class LochbegruessungTest
    {
        [Test]
        public void LiefertTextMitAktuellemLoch()
        {
            var scorecardStub = new Mock<Scorecard>();
            scorecardStub.Setup(scorecard => scorecard.Lochnummer).Returns(2);
            Assert.That(new Lochbegruessung().FuehreAus(scorecardStub.Object), 
                Contains.Substring("auf dem 2. Loch"));
        }
    }
}
