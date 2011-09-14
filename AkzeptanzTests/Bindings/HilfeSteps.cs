using TechTalk.SpecFlow;

namespace AkzeptanzTests.Bindings
{
    [Binding]
    class HilfeSteps
    {
        private TrackerDriver _driver;

        public HilfeSteps(TrackerDriver driver)
        {
            _driver = driver;
        }

        [When(@"ich die Hilfe aufrufe,")]
        public void WennIchDieHilfeAufrufe()
        {
            _driver.EmpfangeAnweisung("Hilfe");
        }

        [Then(@"zeigt der NerdGolfTracker seine Benutzung an.")]
        public void DannZeigtDerNerdGolfTrackerSeineBenutzungAn()
        {
            _driver.AssertThatAntwortContains("folgende Befehle");
        }
    }
}
