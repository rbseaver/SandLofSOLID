using System;
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
	        if (weapon.HandsToHold > Arms)
	        {
	            throw new NotEnoughArmsException("Not enough arms, yo!");
	        }
	        Weapons.Add(weapon);
	    }
	}

    public class NotEnoughArmsException : Exception
    {
        public NotEnoughArmsException(string message) : base(message)
        {
            
        }
    }
}
