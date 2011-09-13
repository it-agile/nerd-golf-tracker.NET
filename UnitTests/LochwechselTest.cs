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
    class LochwechselTest
    {
        [Test]
        public void SchliesstLochAb()
        {
            var scorecardMock = new Mock<Scorecard>();
            new Lochwechsel().FuehreAus(scorecardMock.Object);
            scorecardMock.Verify(scorecard => scorecard.SchliesseLochAb());
        }
    }
}
