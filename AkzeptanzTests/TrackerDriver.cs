using System.Diagnostics;
using NUnit.Framework.Constraints;
using NUnit.Framework;

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
            SpeichereAntwort();
        }

        public void Beende()
        {
            _tracker.Kill();
        }

        public void EmpfangeAnweisung(string anweisung)
        {
            _tracker.StandardInput.WriteLine(anweisung);
            SpeichereAntwort();
        }

        private void SpeichereAntwort()
        {
            _antwort = _tracker.StandardOutput.ReadLine();
        }

        public void AssertThatAntwortContains(string format, params object[] objects)
        {
            Assert.That(_antwort, Contains.Substring(string.Format(format, objects)));
        }
    }
}