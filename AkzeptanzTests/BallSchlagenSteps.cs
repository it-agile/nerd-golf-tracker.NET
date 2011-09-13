using TechTalk.SpecFlow;

namespace AkzeptanzTests
{
    [Binding]
    public class BallSchlagenSteps
    {
        [When(@"ich den Ball.* einmal schlage,")]
        public void BallSchlagen()
        {
            TrackerDriver.instance.SchlageBall();
        }
    }
}