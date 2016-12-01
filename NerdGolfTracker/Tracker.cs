namespace NerdGolfTracker
{
    public class Tracker
    {
        private readonly Operation _startoperation;
        private readonly Scorecard _scorecard;
        private readonly Interpreter _interpreter;

        public Tracker(Interpreter interpreter, Operation startoperation)
        {
            _interpreter = interpreter;
            _startoperation = startoperation;
            _scorecard = new EinfacheScorecard();
        }

        public string ReagiereAuf(string kommando)
        {
            return _interpreter.OperationFuer(kommando).FuehreAus(_scorecard);
        }

        public string Starte()
        {
            return _startoperation.FuehreAus(_scorecard);
        }
    }
}