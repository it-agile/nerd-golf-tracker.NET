using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;

namespace UnitTests.Operationen
{
    [TestClass]
    public class LochausgabeTest
    {
        [TestMethod]
        public void LiefertTextMitAktuellemLoch()
        {
            var scorecardStub = new Mock<Scorecard>();
            scorecardStub.Setup(scorecard => scorecard.Lochnummer).Returns(2);
            Assert.IsTrue(new Lochausgabe().FuehreAus(scorecardStub.Object).Contains("auf dem 2.Loch"));
        }
    }
}
