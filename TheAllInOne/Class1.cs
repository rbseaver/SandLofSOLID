using System.Collections.Generic;

namespace TheAllInOne
{
	/// <summary>
	/// SOLD Round 1!
	/// Create a new Library that breaks out these below int classes using Single Object Responsiblity and Liskov Substitution Principal
	/// 1. make these things!
	/// 2. weapons should be able to added to a character. Note... HandToHold says how many they can have too
	/// 3. you should be able to remove weapons too.
	/// 4. Create a fight method that allows you to match them up (2 players at a time... like Mortal Kombat)
	/// 5. fight method should be able to take account weapon info and character info... basics of strength from both.
	/// Bonus using all the characteristics of the weapons and characters to determine the winner (HitPower {Speed of the attack}, Strength, ENdurance, Attack {their default character Power}
	/// </summary>
	public class Class1
	{
		public void Fight()
		{
			var sword = new Weapon { HitPower = 3, Speed = 3, HandsToHold = 1 };
			var swordPower = new Weapon { HitPower = 5, Speed = 4, HandsToHold = 1 };
			var bo = new Weapon { HitPower = 5, Speed = 1, HandsToHold = 2 };
			var nunchucks = new Weapon { HitPower = 1, Speed = 5, HandsToHold = 1 };
			var sai = new Weapon { HitPower = 2, Speed = 4, HandsToHold = 1 };
			var machineGun = new Weapon { HitPower = 1, Speed = 9, HandsToHold = 2 };

			var leo = new Fighter
			{
				Arms = 2,
				Weapons = new List<Weapon> { sword, sword },
				Strength = 4,
				Endurance = 4,
				Attack = 4
			};

			var mike = new Fighter
			{
				Arms = 2,
				Weapons = new List<Weapon> { nunchucks, nunchucks },
				Strength = 4,
				Endurance = 4,
				Attack = 4
			};

			var raph = new Fighter
			{
				Arms = 2,
				Weapons = new List<Weapon> { sai, sai },
				Strength = 4,
				Endurance = 4,
				Attack = 4
			};

			var don = new Fighter
			{
				Arms = 2,
				Weapons = new List<Weapon> { bo },
				Strength = 4,
				Endurance = 4,
				Attack = 4
			};

			var shredder = new Fighter
			{
				Arms = 2,
				Weapons = new List<Weapon> { swordPower },
				Strength = 8,
				Endurance = 9,
				Attack = 7
			};

			var bebop = new Fighter
			{
				Arms = 2,
				Weapons = new List<Weapon> { machineGun },
				Strength = 7,
				Endurance = 6,
				Attack = 6
			};

			var rockSteady = new Fighter
			{
				Arms = 2,
				Weapons = new List<Weapon> { machineGun },
				Strength = 8,
				Endurance = 6,
				Attack = 7
			};
		}
	}
}