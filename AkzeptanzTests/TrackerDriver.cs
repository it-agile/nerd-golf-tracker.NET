using System.Diagnostics;

namespace AkzeptanzTests
{
    internal class TrackerDriver
    {
        internal static TrackerDriver instance;

        private readonly Process _tracker;

        internal TrackerDriver()
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