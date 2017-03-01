using System.Collections.Generic;

namespace SandLOfSOLID.Lib
{
	public class Fighter
	{
		private List<Weapon> _weapons = new List<Weapon>();

		public int Arms { get; set; }

		public List<Weapon> Weapons
		{
			get { return _weapons; }
			set { _weapons = value; }
		}

		public int Strength { get; set; }

		public int Endurance { get; set; }

		public int Attack { get; set; }

		public void AddWeapon(Weapon weapon)
		{
			var handsFree = Arms;
			handsFree -= weapon.HandsToHold;

			if (handsFree < weapon.HandsToHold)
			{
				throw new NotEnoughArmsException("Not enough arms, dawg!");
			}
			_weapons.Add(weapon);
		}

		public void RemoveWeapon(Weapon weapon)
		{
			_weapons.Remove(weapon);
		}
	}
}
