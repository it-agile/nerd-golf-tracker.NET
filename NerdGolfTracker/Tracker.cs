namespace NerdGolfTracker
{
    public class Tracker
    {
        private Scorecard _scorecard = new EinfacheScorecard();

        public string ReagiereAuf(string kommando)
        {
            if (kommando == "Naechstes Loch")
            {
                _scorecard = new EinfacheScorecard();
                return "";
            }

            new Schlag().FuehreAus(_scorecard);

            var schlag = _scorecard.AnzahlSchlaege == 1 ? "Schlag" : "Schlaege";
            return string.Format("Du hast {0} {1}.", _scorecard.AnzahlSchlaege, schlag);
        }
    }
}