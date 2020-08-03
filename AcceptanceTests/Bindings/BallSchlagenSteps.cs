using TechTalk.SpecFlow;

namespace AkzeptanzTests.Bindings
{
    [Binding]
    public class BallSchlagenSteps
    {
        private readonly TrackerDriver _driver;

        public BallSchlagenSteps(TrackerDriver driver)
        {
            _driver = driver;
        }

        [Given(@".* Ball.* einmal geschlagen")]
        [When(@".* Ball.* schlage")]
        public void SchlageBall()
        {
            _driver.EmpfangeAnweisung("Schlage Ball");
        }
    }
}