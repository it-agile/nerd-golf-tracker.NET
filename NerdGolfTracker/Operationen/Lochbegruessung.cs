namespace NerdGolfTracker.Operationen
{
    public class Lochbegruessung : Operation
    {
        private Operation _folgeOperation;

        public Lochbegruessung(Operation folgeOperation)
        {
            _folgeOperation = folgeOperation;
        }

        public string FuehreAus(Scorecard scorecard)
        {
            return string.Format("Du bist jetzt {0}", _folgeOperation.FuehreAus(scorecard));
        }
    }
}