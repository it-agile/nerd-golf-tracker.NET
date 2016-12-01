namespace NerdGolfTracker.Operationen
{
    public class Lochbegruessung : Operation
    {
        private readonly Operation _folgeOperation;

        public Lochbegruessung(Operation folgeOperation)
        {
            _folgeOperation = folgeOperation;
        }

        public string FuehreAus(Scorecard scorecard)
        {
            return $"Du bist jetzt {_folgeOperation.FuehreAus(scorecard)}";
        }
    }
}