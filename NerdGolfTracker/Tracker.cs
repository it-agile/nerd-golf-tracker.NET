namespace NerdGolfTracker
{
    public class Tracker
    {
        private Scorecard _scorecard;
        private Interpreter _interpreter;

        public Tracker(Interpreter interpreter, Scorecard scorecard)
        {
            _interpreter = interpreter;
            _scorecard = scorecard;
        }

        public string ReagiereAuf(string kommando)
        {
            return _interpreter.OperationFuer(kommando).FuehreAus(_scorecard);
        }
    }
}