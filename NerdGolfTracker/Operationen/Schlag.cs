namespace NerdGolfTracker.Operationen
{
    public class Schlag : Operation
    {
        private readonly Operation _folgeOperation;

        public Schlag(Operation folgeOperation)
        {
            _folgeOperation = folgeOperation;
        }

        public string FuehreAus(Scorecard scorecard)
        {
            scorecard.ErhoeheAnzahlSchlaege();
            return _folgeOperation.FuehreAus(scorecard);
        }
    }
}