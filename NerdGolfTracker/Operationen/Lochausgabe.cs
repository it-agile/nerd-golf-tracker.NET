namespace NerdGolfTracker.Operationen
{
    public class Lochausgabe : Operation
    {
        public string FuehreAus(Scorecard scorecard)
        {
            return $"auf dem {scorecard.Lochnummer}.Loch.";
        }
    }
}