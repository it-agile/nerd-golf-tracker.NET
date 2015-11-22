namespace NerdGolfTracker.Operationen
{
    public class Lochwechsel : Operation
    {
        private Operation _folgeOperation;

        public Lochwechsel(Operation folgeOperation)
        {
            _folgeOperation = folgeOperation;
        }

        public string FuehreAus(Scorecard scorecard)
        {
            scorecard.SchliesseLochAb();
            return _folgeOperation.FuehreAus(scorecard);
        }
    }
}