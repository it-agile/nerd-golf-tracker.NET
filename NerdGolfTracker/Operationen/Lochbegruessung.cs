namespace NerdGolfTracker.Operationen
{
    public class Lochbegruessung : Operation
    {
        public string FuehreAus(Scorecard scorecard)
        {
            return string.Format("Du bist jetzt {0}.", new Lochausgabe().FuehreAus(scorecard));
        }
    }
}