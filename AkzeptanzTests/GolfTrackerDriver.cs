using System.Diagnostics;

namespace AkzeptanzTests
{
    internal class GolfTrackerDriver
    {
        private readonly Process _tracker;

        internal GolfTrackerDriver()
        {
            _tracker = Process.Start(new ProcessStartInfo
                                         {
                                             FileName = "NerdGolfTracker.exe",
                                             UseShellExecute = false,
                                             RedirectStandardOutput = true,
                                             RedirectStandardInput = true,
                                         });
        }

        internal void SchlageBall()
        {
            _tracker.StandardInput.WriteLine("Schlage Ball");
        }

        public string GibtAntwort()
        {
            return _tracker.StandardOutput.ReadLine();
        }
    }
}