using System;
using NerdGolfTracker.Operationen;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Operationen
{
    [TestClass]
    public class HilfeTest
    {
        [TestMethod]
        public void GibtEineZeileProBefehlAus()
        {
            var ausgabe = new Hilfe().FuehreAus(null);
            var zeilen = ausgabe.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.None);
            Assert.AreEqual(zeilen.Length, 3);
        }
    }
}
