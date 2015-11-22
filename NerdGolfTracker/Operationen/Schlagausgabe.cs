namespace NerdGolfTracker.Operationen
{
    public class Schlagausgabe : Operation
    {
        private Operation _folgeOperation;

        public Schlagausgabe(Operation folgeOperation)
        {
            _folgeOperation = folgeOperation;
        }

        public string FuehreAus(Scorecard scorecard)
        {
            return string.Format("Du hast {0} Schlag {1}", scorecard.AnzahlSchlaege, _folgeOperation.FuehreAus(scorecard));
        }
    }
}