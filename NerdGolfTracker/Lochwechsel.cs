namespace NerdGolfTracker
{
    public class Lochwechsel : Operation
    {
        public void FuehreAus(Scorecard scorecard)
        {
            scorecard.SchliesseLochAb();
        }
    }
}