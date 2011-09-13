using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AkzeptanzTests
{
    [Binding]
    public class LochwechselSteps
    {
        private readonly TrackerDriver _driver;

        public LochwechselSteps(TrackerDriver driver)
        {
            _driver = driver;
        }

        [When(".* zum nächsten Loch.*")]
        public void GeheZumNaechstenLoch()
        {
            _driver.EmpfangeAnweisung("Naechstes Loch");
        }

    }
}
