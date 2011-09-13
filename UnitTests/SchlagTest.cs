using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;
using NUnit.Framework;
using NerdGolfTracker;

namespace UnitTests
{
    [TestFixture]
    class SchlagTest
    {
        [Test]
        public void ErhoehtDieSchlagzahlAufDerScorecard()
        {
            var scorecardMock = new Mock<Scorecard>();
            new Schlag().FuehreAus(scorecardMock.Object);
            scorecardMock.Verify(scorecard => scorecard.ErhoeheAnzahlSchlaege());
        }
    }
}
