using System.Diagnostics;

namespace AkzeptanzTests
{
    public class TrackerDriver
    {
        private Process _tracker;
        private string _antwort;

        public void Starte()
        {
            _tracker = Process.Start(new ProcessStartInfo
                                         {
                                             FileName = "NerdGolfTracker.exe",
                                             UseShellExecute = false,
                                             RedirectStandardOutput = true,
                                             RedirectStandardInput = true,
                                             CreateNoWindow = true,
                                         });
        }

        public void Beende()
        {
            _tracker.Kill();
        }

        public string GibtAntwort()
        {
            return _antwort;
        }

        public void EmpfangeAnweisung(string anweisung)
        {
            _tracker.StandardInput.WriteLine(anweisung);
            _antwort = _tracker.StandardOutput.ReadLine();
        }
    }
}