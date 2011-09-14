namespace NerdGolfTracker.Operationen
{
    public class Lochwechsel : Operation
    {
        public string FuehreAus(Scorecard scorecard)
        {
            scorecard.SchliesseLochAb();
            return new Lochbegruessung().FuehreAus(scorecard);
        }
    }
}