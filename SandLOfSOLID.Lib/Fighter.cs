using System.Collections.Generic;
using System.Linq;

namespace SandLOfSOLID.Lib
{
	public class Fighter : IFighter
    {
	    private List<Weapon> _weapons;

	    public Fighter()
	    {
	        _weapons = new List<Weapon>();
	    }

		public int Arms { get; set; }

		public IList<Weapon> Weapons
		{
			get { return new List<Weapon>(_weapons); }
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


	    public int Damage()
	    {
	        if (Weapons.Count == 0)
	        {
	            return Attack;
	        }

	        return Attack + Weapons.Sum(w => w.HitPower);
	    }

    }
}
