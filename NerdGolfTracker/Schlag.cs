namespace NerdGolfTracker
{
    public class Schlag : Operation
    {
        public string FuehreAus(Scorecard scorecard)
        {
            scorecard.ErhoeheAnzahlSchlaege();
            var schlag = scorecard.AnzahlSchlaege == 1 ? "Schlag" : "Schlaege";
            return string.Format("Du hast {0} {1} auf dem 1. Loch.", scorecard.AnzahlSchlaege, schlag);
        }
    }
}