using System.Diagnostics;

namespace AkzeptanzTests
{
    public class TrackerDriver
    {
        private Process _tracker;

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

        internal void SchlageBall()
        {
            _tracker.StandardInput.WriteLine("Schlage Ball");
        }

        public string GibtAntwort()
        {
            string antwort = _tracker.StandardOutput.ReadLine();
            return antwort;
        }
    }
}