using NerdGolfTracker;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class TrackerTest
    {
        [Test]
        public void ZaehltEinenSchlag()
        {
            var tracker = new Tracker();
            Assert.That(tracker.ReagiereAuf("schlage Ball"), Is.EqualTo("Du hast 1 Schlag."));
        }
    }
}