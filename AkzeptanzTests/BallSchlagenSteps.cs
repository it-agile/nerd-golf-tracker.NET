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

        [When(@".* Ball.* schlage.*")]
        public void SchlageBall()
        {
            _driver.SchlageBall();
        }

        [Given(@".* Ball.* einmal geschlagen.*")]
        public void SchlageBall2()
        {
            _driver.SchlageBall();
        }
    }
}