namespace NerdGolfTracker
{
    public class Tracker
    {
        private Operation _startoperation;
        private Scorecard _scorecard;
        private Interpreter _interpreter;

        public Tracker(Interpreter interpreter, Scorecard scorecard, Operation startoperation)
        {
            _interpreter = interpreter;
            _scorecard = scorecard;
            _startoperation = startoperation;
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