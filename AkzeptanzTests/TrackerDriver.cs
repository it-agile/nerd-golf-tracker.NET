using System.Diagnostics;

namespace AkzeptanzTests
{
    public class TrackerDriver
    {
        private readonly Process _tracker;

        public TrackerDriver()
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

        internal void SchlageBall()
        {
            _tracker.StandardInput.WriteLine("Schlage Ball");
        }

        public string GibtAntwort()
        {
            string antwort = _tracker.StandardOutput.ReadLine();
            return antwort;
        }

        public void Beende()
        {
            _tracker.Kill();
        }
    }
}