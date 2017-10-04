using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace AkzeptanzTests.Bindings
{
    [Binding]
    public class LochwechselSteps
    {
        private readonly TrackerDriver _driver;

        public LochwechselSteps(TrackerDriver driver)
        {
            _driver = driver;
        }

        [When(".* zum nächsten Loch gehe")]
        public void GeheZumNaechstenLoch()
        {
            _driver.EmpfangeAnweisung("Naechstes Loch");
        }

        [Then(@"zählt.* auf dem (\d+)\. (.*)")]
        [Then(@"begrüßt.* auf dem (\d+)\. (.*)")]
        public void PruefeLoch(int lochnummer, string lochnomen)
        {
            _driver.AssertThatAntwortContains("{0}.", lochnummer, lochnomen);
        }
    }
}
