namespace NerdGolfTracker
{
    public interface Scorecard
    {
        void ErhoeheAnzahlSchlaege();
        int AnzahlSchlaege { get; }
        int Lochnummer { get; }
        void SchliesseLochAb();
    }
}