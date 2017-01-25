using System;
using NerdGolfTracker.Operationen;
using NUnit.Framework;

namespace UnitTests.Operationen
{
    [TestFixture]
    public class HilfeTest
    {
        [Test]
        public void GibtEineZeileProBefehlAus()
        {
            var ausgabe = new Hilfe().FuehreAus(null);
            var zeilen = ausgabe.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.None);
            Assert.That(zeilen.Length, Is.EqualTo(3));
        }
    }
}
