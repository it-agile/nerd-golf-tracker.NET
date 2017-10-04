using TechTalk.SpecFlow;

namespace AkzeptanzTests.Bindings
{
    [Binding]
    public class TrackerDriverFixture
    {
        private readonly TrackerDriver _driver;

        public TrackerDriverFixture(TrackerDriver driver)
        {
            _driver = driver;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver.Starte();
        }

        [When(@"ich den NerdGolfTracker starte")]
        public void StarteTracker()
        {
            // Nur da, um Szenario sprechend zu schreiben.
            // Der Tracker wird automatisch davor gestartet.
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Beende();
        }
    }
}
