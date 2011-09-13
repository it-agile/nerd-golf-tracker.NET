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

        [Then(@"zählt er die Schläge auf dem (\d+)\. (.*)\.")]
        public void PruefeLoch(int lochnummer, string lochnomen)
        {
            Assert.That(_driver.GibtAntwort(), Contains.Substring(
                string.Format("{0}. {1}", lochnummer, lochnomen)));
        }
    }
}
