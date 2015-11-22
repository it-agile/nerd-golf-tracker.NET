namespace NerdGolfTracker.Operationen
{
    public class Schlagausgabe : Operation
    {
        public string FuehreAus(Scorecard scorecard)
        {
            return string.Format("Du hast {0} Schlag {1}", scorecard.AnzahlSchlaege, new Lochausgabe().FuehreAus(scorecard));
        }
    }
}