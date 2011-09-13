namespace NerdGolfTracker
{
    public class EinfacheScorecard : Scorecard
    {
        public int AnzahlSchlaege { get; private set; }

        public void ErhoeheAnzahlSchlaege()
        {
            AnzahlSchlaege++;
        }
    }
}