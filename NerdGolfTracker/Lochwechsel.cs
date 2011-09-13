namespace NerdGolfTracker
{
    public class Lochwechsel : Operation
    {
        public string FuehreAus(Scorecard scorecard)
        {
            scorecard.SchliesseLochAb();
            return "";
        }
    }
}