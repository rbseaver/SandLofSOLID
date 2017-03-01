using NUnit.Framework;
using SandLOfSOLID.Lib;

namespace SandLOfSOLID.Tests
{
	[TestFixture]
	public class WhenRemovingWeaponsFromFighter
	{
		[SetUp]
		public void Setup()
		{

		}

		[Test]
		public void ItShouldRemoveSpecifiedWeapon()
		{
			var fighter = new Fighter
			{
				Arms = 2,
				Attack = 1,
				Endurance = 1,
				Strength = 5
			};

			var weapon1 = new Weapon { HandsToHold = 1, HitPower = 4, Speed = 100 };
			var weapon2 = new Weapon { HandsToHold = 1, HitPower = 10, Speed = 5 };

			fighter.AddWeapon(weapon1);
			fighter.AddWeapon(weapon2);

			fighter.RemoveWeapon(weapon1);

			Assert.That(fighter.Weapons.Count, Is.EqualTo(1));
			Assert.That(fighter.Weapons[0], Is.EqualTo(weapon2));
		}

		[Test]
		public void ItShouldIncreaseArmsAvailable()
		{
			var fighter = new Fighter
			{
				Arms = 2,
				Attack = 1,
				Endurance = 1,
				Strength = 5
			};

			var weapon1 = new Weapon { HandsToHold = 1, HitPower = 4, Speed = 100 };
			var weapon2 = new Weapon { HandsToHold = 1, HitPower = 10, Speed = 5 };

			fighter.AddWeapon(weapon1);
			fighter.AddWeapon(weapon2);

			fighter.RemoveWeapon(weapon1);
		}
	}
}
