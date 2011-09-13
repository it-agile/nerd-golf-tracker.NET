using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AkzeptanzTests
{
    [Binding]
    public class SchlaegeZaehlenSteps
    {
        [Then(@"zählt der NerdGolfTracker (.*) (.*)\.")]
        public void PruefeSchlagzahl(int schlagzahl, string schlagnomen)
        {
            Assert.That(TrackerDriver.instance.GibtAntwort(), Is.EqualTo(string.Format("Du hast {0} {1}.", schlagzahl, schlagnomen)));
        }
    }
}