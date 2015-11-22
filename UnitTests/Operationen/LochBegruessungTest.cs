using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace UnitTests.Operationen
{
    [TestFixture]
    class LochBegruessungTest
    {
        private Mock<Operation> _folgeOperationMock;
        private Lochbegruessung _lochbegruessung;
        private Mock<Scorecard> _scorecardMock;

        [SetUp]
        public void Init()
        {
            _folgeOperationMock = new Mock<Operation>();
            _scorecardMock = new Mock<Scorecard>();
            _lochbegruessung = new Lochbegruessung(_folgeOperationMock.Object);
        }

        [Test]
        public void GibtBegruessungAus()
        {
            Assert.That(_lochbegruessung.FuehreAus(_scorecardMock.Object), Is.StringStarting("Du bist"));
        }


        [Test]
        public void FuehrtFolgeoperationMitAus()
        {
            _lochbegruessung.FuehreAus(_scorecardMock.Object);
            _folgeOperationMock.Verify(folgeOperation => folgeOperation.FuehreAus(_scorecardMock.Object));
        }

    }
}
