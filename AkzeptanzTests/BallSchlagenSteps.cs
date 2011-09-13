using TechTalk.SpecFlow;

namespace AkzeptanzTests
{
    [Binding]
    public class BallSchlagenSteps
    {
        private readonly TrackerDriver _driver;

        public BallSchlagenSteps(TrackerDriver driver)
        {
            _driver = driver;
        }

        [When(@"ich den Ball.* einmal schlage,")]
        public void BallSchlagen()
        {
            _driver.SchlageBall();
        }
    }
}