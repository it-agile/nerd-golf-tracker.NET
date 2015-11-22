using Moq;
using NUnit.Framework;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;

namespace UnitTests.Operationen
{
    [TestFixture]
    class LochausgabeTest
    {
        [Test]
        public void LiefertTextMitAktuellemLoch()
        {
            var scorecardStub = new Mock<Scorecard>();
            scorecardStub.Setup(scorecard => scorecard.Lochnummer).Returns(2);
            Assert.That(new Lochausgabe().FuehreAus(scorecardStub.Object), 
                Contains.Substring("auf dem 2.Loch"));
        }

//        [Test]
//        public void FuehrtFolgeOperationMitAus()
//        {
//            var operation = new Mock<Operation>();
//            var scoreCard = new Mock<Scorecard>();
//            new Lochausgabe(operation.Object).FuehreAus(scoreCard.Object);
//        }

    }
}
