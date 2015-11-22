using Moq;
using NUnit.Framework;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;

namespace UnitTests.Operationen
{
    [TestFixture]
    public class SchlagausgabeTest
    {
        [Test]
        public void GibtSchlagzahlenAus()
        {
            var scorecardStub = new Mock<Scorecard>();
            scorecardStub.Setup(scorecard => scorecard.AnzahlSchlaege).Returns(1);
            var ausgabe = new Schlagausgabe().FuehreAus(scorecardStub.Object);
            Assert.That(ausgabe, Is.StringContaining("1 Schlag"));
        }
    }
}