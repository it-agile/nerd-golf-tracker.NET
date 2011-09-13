using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AkzeptanzTests
{
    [Binding]
    public class BallSchlagenSteps
    {
        private static TrackerDriver Driver
        {
            get { return TrackerDriver.instance; }
        }

        [When(@"ich den Ball.* einmal schlage,")]
        public void BallSchlagen()
        {
            Driver.SchlageBall();
        }

        [Then(@"zählt der NerdGolfTracker (.*) (.*)\.")]
        public void PruefeSchlagzahl(int schlagzahl, string schlagnomen)
        {
            Assert.That(TrackerDriver.instance.GibtAntwort(), Is.EqualTo(string.Format("Du hast {0} {1}.", schlagzahl, schlagnomen)));
        }
    }
}