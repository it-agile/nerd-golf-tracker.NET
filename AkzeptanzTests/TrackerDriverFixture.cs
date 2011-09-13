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
        [BeforeScenario]
        public void BeforeScenario()
        {
            TrackerDriver.instance = new TrackerDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            TrackerDriver.instance.Beende();
        }
    }
}
