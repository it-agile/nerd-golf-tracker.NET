namespace NerdGolfTracker.Operationen
{
    public class Schlagausgabe : Operation
    {
        public string FuehreAus(Scorecard scorecard)
        {
            return string.Format("{0} Schlag", scorecard.AnzahlSchlaege);
        }
    }
}