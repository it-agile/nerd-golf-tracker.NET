using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AkzeptanzTests
{
    [Binding]
    public class StepDefinitions
    {
        [When(@"ich den Ball einmal schlage,")]
        public void WhenIchDenBallEinmalSchlage()
        {
//            Assert.True(false);
            ScenarioContext.Current.Pending();
        }
    }
}
