namespace NerdGolfTracker
{
    public class EinfacheScorecard : Scorecard
    {
        private int _anzahlSchlaege = 0;

        public void ErhoeheAnzahlSchlaege()
        {
            _anzahlSchlaege++;
        }

        public int AnzahlSchlaege()
        {
            return _anzahlSchlaege;
        }
    }
}