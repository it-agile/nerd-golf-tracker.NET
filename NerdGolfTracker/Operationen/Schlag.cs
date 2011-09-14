namespace NerdGolfTracker.Operationen
{
    public class Schlag : Operation
    {
        public string FuehreAus(Scorecard scorecard)
        {
            scorecard.ErhoeheAnzahlSchlaege();
            var schlag = scorecard.AnzahlSchlaege == 1 ? "Schlag" : "Schlaege";
            return string.Format("Du hast {0} {1} {2}.", 
                scorecard.AnzahlSchlaege, 
                schlag, 
                new Lochausgabe().FuehreAus(scorecard));
        }
    }
}