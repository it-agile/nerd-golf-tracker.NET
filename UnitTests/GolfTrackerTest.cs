using NerdGolfTracker;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class GolfTrackerTest
    {
        [Test]
        public void ZaehltEinenSchlag()
        {
            var golfTracker = new GolfTracker();
            Assert.That(golfTracker.ReagiereAuf("schlage Ball"), Is.EqualTo("Du hast einen Schlag."));
        }
    }
}