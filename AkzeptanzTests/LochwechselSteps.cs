using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
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

        [Then(@"zählt er die Schläge auf dem 1\. Loch\.")]
        public void PruefeLoch()
        {
            Assert.That(_driver.GibtAntwort(), Contains.Substring("1. Loch"));
        }
    }
}
