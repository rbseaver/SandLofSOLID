using Moq;
using NUnit.Framework;
using SOLID.Lib;
using Match = SOLID.Lib.Match;

namespace SOLID.Tests
{
	[TestFixture]
	public class WhenCreatingMatch
	{
		[SetUp]
		public void Setup()
		{

		}

		[Test]
		public void ItshouldAddFightersToTheMatch()
		{
			var match = new Match();
			var turd = new Fighter();
			var turd2 = new Fighter();

			match.AddFighter(turd);
			match.AddFighter(turd2);

			Assert.That(match.Fighters.Count, Is.EqualTo(2));
		}

        [Test]
	    public void ItShouldReturnWinner()
	    {
	        var match = new Match();

	        var turd = new Mock<IFighter>();
	        turd.Setup(t => t.Endurance).Returns(5);
	        turd.Setup(t => t.Damage()).Returns(4);

            var turdBro = new Mock<IFighter>();
            turdBro.Setup(t => t.Endurance).Returns(4);
            turdBro.Setup(t => t.Damage()).Returns(4);

	        var expected = match.Stage(turd.Object, turdBro.Object);

            Assert.That(turd.Object, Is.EqualTo(expected));

	    }
	}
}
