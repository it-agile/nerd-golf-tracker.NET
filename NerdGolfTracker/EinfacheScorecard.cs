namespace NerdGolfTracker
{
    public class EinfacheScorecard : Scorecard
    {
        public int AnzahlSchlaege { get; private set; }

        public int Lochnummer
        {
            get { return 1; }
        }

        public void SchliesseLochAb()
        {
            AnzahlSchlaege = 0;
        }

        public void ErhoeheAnzahlSchlaege()
        {
            AnzahlSchlaege++;
        }
    }
}