using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AkzeptanzTests
{
    [Binding]
    public class BallSchlagenSteps
    {
        private readonly GolfTrackerDriver _driver = new GolfTrackerDriver();

        [When(@"ich den Ball einmal schlage,")]
        public void WhenIchDenBallEinmalSchlage()
        {
            _driver.SchlageBall();
        }

        [Then(@"antwortet mir der NerdGolfTracker ""(.*)""")]
        public void ThenAntwortetMirDerNerdGolfTrackerDuHastEinenSchlag(string erwarteteAntwort)
        {
            Assert.That(_driver.GibtAntwort(), Is.EqualTo(erwarteteAntwort));
        }
    }
}