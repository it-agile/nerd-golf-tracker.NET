using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AkzeptanzTests
{
    [Binding]
    public class BallSchlagenSteps
    {
        [When(@"ich den Ball einmal schlage,")]
        public void WhenIchDenBallEinmalSchlage()
        {
            Driver.SchlageBall();
        }

        private static TrackerDriver Driver
        {
            get { return TrackerDriver.instance; }
        }

        [When(@"ich den Ball noch einmal schlage,")]
        public void WhenIchDenBallNochEinmalSchlage()
        {
            WhenIchDenBallEinmalSchlage();
        }

        [Then(@"zählt der NerdGolfTracker (.*) (.*)\.")]
        public void ThenAntwortetMirDerNerdGolfTrackerDuHastEinenSchlag2(string schlagzahl, string schlagnomen)
        {
            Assert.That(TrackerDriver.instance.GibtAntwort(), Is.EqualTo(string.Format("Du hast {0} {1}.", schlagzahl, schlagnomen)));
        }
    }
}