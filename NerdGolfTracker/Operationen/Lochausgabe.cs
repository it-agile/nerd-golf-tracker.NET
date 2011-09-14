namespace NerdGolfTracker.Operationen
{
    public class Lochausgabe : Operation
    {
        public string FuehreAus(Scorecard scorecard)
        {
            return string.Format("auf dem {0}. Loch", scorecard.Lochnummer);
        }
    }
}