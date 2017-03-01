using NUnit.Framework;
using SandLOfSOLID.Lib;

namespace SandLOfSOLID.Tests
{
	[TestFixture]
	public class WhenAddingWeaponsToFighter
	{
		[Test]
		public void AndFighterHasEnoughHandsItShouldAddWeapon()
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

			Assert.That(fighter.Weapons.Count, Is.EqualTo(2));


		}

		[Test]
		public void AndFighterIsOutOfHandsItShouldThrowException()
		{
			var fighter = new Fighter
			{
				Arms = 2,
				Attack = 1,
				Endurance = 1,
				Strength = 5
			};

			var weapon1 = new Weapon { HandsToHold = 1, HitPower = 4, Speed = 100 };
			var weapon2 = new Weapon { HandsToHold = 2, HitPower = 10, Speed = 5 };

			fighter.AddWeapon(weapon1);

			Assert.Throws<NotEnoughArmsException>(() => fighter.AddWeapon(weapon2));
		}

        [Test]
        public void AndAddingWeaponsViaExposed()
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

            fighter.Weapons.Add(new Weapon());

            Assert.That(fighter.Weapons.Count, Is.EqualTo(2));
        }
    }
}
