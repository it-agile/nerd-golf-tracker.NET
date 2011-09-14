namespace NerdGolfTracker.Operationen
{
    public class Lochbegruessung : Operation
    {
        public string FuehreAus(Scorecard scorecard)
        {
            return string.Format("Du bist jetzt auf dem {0}. Loch.", scorecard.Lochnummer);
        }
    }
}