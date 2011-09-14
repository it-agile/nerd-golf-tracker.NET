namespace NerdGolfTracker.Operationen
{
    public class Schlagausgabe : Operation
    {
        public string FuehreAus(Scorecard scorecard)
        {
            var schlagnomen = scorecard.AnzahlSchlaege == 1 ? "Schlag" : "Schlaege";
            return string.Format("{0} {1}", scorecard.AnzahlSchlaege, schlagnomen);
        }
    }
}