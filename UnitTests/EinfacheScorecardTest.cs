using NUnit.Framework;
using NerdGolfTracker;

namespace UnitTests
{
    [TestFixture]
    public class EinfacheScorecardTest
    {
        private Scorecard _scorecard;

        [SetUp]
        public void InitialisiereScorecard()
        {
            _scorecard = new EinfacheScorecard();
        }

        [Test]
        public void InkrementiertSchlagzahlEinmal()
        {
            _scorecard.ErhoeheAnzahlSchlaege();
            Assert.That(_scorecard.AnzahlSchlaege, Is.EqualTo(1));
        }

        [Test]
        public void InkrementiertSchlagzahlMehrmals()
        {
            _scorecard.ErhoeheAnzahlSchlaege();
            _scorecard.ErhoeheAnzahlSchlaege();
            Assert.That(_scorecard.AnzahlSchlaege, Is.EqualTo(2));
        }
    }
}