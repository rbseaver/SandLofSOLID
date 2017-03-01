using NUnit.Framework;
using SandLOfSOLID.Lib;

namespace SandLOfSOLID.Tests
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
	}
}
