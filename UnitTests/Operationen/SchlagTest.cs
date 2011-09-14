using Moq;
using NUnit.Framework;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;

namespace UnitTests.Operationen
{
    [TestFixture]
    public class SchlagTest
    {
        [Test]
        public void ErhoehtDieSchlagzahlAufDerScorecard()
        {
            var scorecardMock = new Mock<Scorecard>();
            new Schlag().FuehreAus(scorecardMock.Object);
            scorecardMock.Verify(scorecard => scorecard.ErhoeheAnzahlSchlaege());
        }
    }
}
