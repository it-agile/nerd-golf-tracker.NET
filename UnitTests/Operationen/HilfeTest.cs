using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NerdGolfTracker.Operationen;

namespace UnitTests.Operationen
{
    [TestFixture]
    class HilfeTest
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
