namespace NerdGolfTracker
{
    public class Schlag : Operation
    {
        public void FuehreAus(Scorecard scorecard)
        {
            scorecard.ErhoeheAnzahlSchlaege();
        }
    }
}