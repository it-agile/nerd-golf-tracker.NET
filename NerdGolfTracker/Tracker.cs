namespace NerdGolfTracker
{
    public class Tracker
    {
        private Scorecard _scorecard = new EinfacheScorecard();
        private Interpreter _interpreter;

        public Tracker(Interpreter interpreter)
        {
            _interpreter = interpreter;
        }

        public string ReagiereAuf(string kommando)
        {
            _interpreter.OperationFuer(kommando).FuehreAus(_scorecard);

            var schlag = _scorecard.AnzahlSchlaege == 1 ? "Schlag" : "Schlaege";
            return string.Format("Du hast {0} {1}.", _scorecard.AnzahlSchlaege, schlag);
        }
    }
}