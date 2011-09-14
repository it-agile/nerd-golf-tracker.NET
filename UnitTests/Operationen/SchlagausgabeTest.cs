using Moq;
using NUnit.Framework;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;

namespace UnitTests.Operationen
{
    [TestFixture]
    public class SchlagausgabeTest
    {
        [TestCase(1, Result="1 Schlag")]
        [TestCase(2, Result="2 Schlaege")]
        public string GibtSchlagzahlenAus(int schlagzahl)
        {
            var scorecardStub = new Mock<Scorecard>();
            scorecardStub.Setup(scorecard => scorecard.AnzahlSchlaege).Returns(schlagzahl);
            return new Schlagausgabe().FuehreAus(scorecardStub.Object);
        }
    }
}