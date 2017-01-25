using Moq;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;
using NUnit.Framework;

namespace UnitTests.Operationen
{
    [TestFixture]
    public class SchlagausgabeTest
    {
        private Mock<Scorecard> _scorecardStub;
        private Schlagausgabe _schlagausgabe;
        private Mock<Operation> _folgeOperationMock;
            
        [SetUp]
        public void Init()
        {
            _scorecardStub = new Mock<Scorecard>();
            _folgeOperationMock = new Mock<Operation>();
            _schlagausgabe = new Schlagausgabe(_folgeOperationMock.Object);

        }

        [Test]
        public void GibtSchlagzahlenAus()
        {
            _scorecardStub.Setup(scorecard => scorecard.AnzahlSchlaege).Returns(1);
            Assert.That(_schlagausgabe.FuehreAus(_scorecardStub.Object), Contains.Substring("1 Schlag"));
        }

        [Test]
        public void FuehrtFolgeOperationAus()
        {
            _schlagausgabe.FuehreAus(_scorecardStub.Object);
            _folgeOperationMock.Verify(operation => operation.FuehreAus(_scorecardStub.Object));
        }

    }
}