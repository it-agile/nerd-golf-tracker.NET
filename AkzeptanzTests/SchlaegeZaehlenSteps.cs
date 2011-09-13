using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AkzeptanzTests
{
    [Binding]
    public class SchlaegeZaehlenSteps
    {
        private readonly TrackerDriver _driver;

        public SchlaegeZaehlenSteps(TrackerDriver driver)
        {
            _driver = driver;
        }

        [Then(@"zählt der NerdGolfTracker (.*) (.*)\.")]
        public void PruefeSchlagzahl(int schlagzahl, string schlagnomen)
        {
            Assert.That(_driver.GibtAntwort(), Is.EqualTo(string.Format("Du hast {0} {1}.", schlagzahl, schlagnomen)));
        }
    }
}