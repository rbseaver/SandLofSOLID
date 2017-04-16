using System;

namespace SOLID.Lib
{
	public class Weapon : IDamage {
		public int Speed { get; set; }
		public int HandsToHold { get; set; }
		public int HitPower { get; set; }

        public void Damage()
        {
            throw new NotImplementedException();
        }
    }
}
