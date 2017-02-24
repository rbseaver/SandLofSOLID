using System.Collections.Generic;

namespace SandLOfSOLID.Lib
{
	public class Fighter
	{
		public int Arms { get; set; }
		public List<Weapon> Weapons { get; set; }
		public int Strength { get; set; }
		public int Endurance { get; set; }
		public int Attack { get; set; }

	    public void AddWeapon(Weapon weapon)
	    {
	        Weapons.Add(weapon);
	    }
	}
}
