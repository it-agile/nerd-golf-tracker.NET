namespace NerdGolfTracker
{
    public class EinfacheScorecard : Scorecard
    {
        public int AnzahlSchlaege { get; private set; }
        public int Lochnummer { get; private set; }

        public EinfacheScorecard()
        {
            Lochnummer = 1;
        }

        public void SchliesseLochAb()
        {
            AnzahlSchlaege = 0;
            Lochnummer++;
        }

        public void ErhoeheAnzahlSchlaege()
        {
            AnzahlSchlaege++;
        }
    }
}