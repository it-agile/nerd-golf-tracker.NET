using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AkzeptanzTests
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
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Beende();
        }
    }
}
