namespace NerdGolfTracker.Operationen
{
    public class Lochwechsel : Operation
    {
        public string FuehreAus(Scorecard scorecard)
        {
            scorecard.SchliesseLochAb();
            return string.Format("Du bist jetzt auf dem {0}. Loch.", scorecard.Lochnummer);
        }
    }
}