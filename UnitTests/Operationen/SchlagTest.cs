using Moq;
using NUnit.Framework;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;

namespace UnitTests.Operationen
{
    [TestFixture]
    class SchlagTest
    {
        [Test]
        public void ErhoehtDieSchlagzahlAufDerScorecard()
        {
            var scorecardMock = new Mock<Scorecard>();
            new Schlag().FuehreAus(scorecardMock.Object);
            scorecardMock.Verify(scorecard => scorecard.ErhoeheAnzahlSchlaege());
        }

        [Test]
        public void GibtDieAktuelleSchlagzahlZurueck()
        {
            var scorecardStub = new Mock<Scorecard>();
            scorecardStub.Setup(scorecard => scorecard.AnzahlSchlaege).Returns(2);
            var ausgabe = new Schlag().FuehreAus(scorecardStub.Object);
            Assert.That(ausgabe, Contains.Substring("2 Schlaege"));
        }
    }
}
