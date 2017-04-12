using System.Collections.Generic;
using System.Linq;

namespace SOLID.Lib
{
    /// <summary>
    /// Fighter has a simple setup which allows for it to be mocked by the interface <see cref="IFighter"/>. This is part of Liskov substitution. 
    /// Also the fighter is a single object, only carying about what it needs to do as a fighter, which is juggle weapons, health, and damage
    /// </summary>
    public class Fighter : IFighter
    {
        private readonly List<Weapon> _weapons;

        public Fighter()
        {
            _weapons = new List<Weapon>();
        }

        public int Arms { get; set; }

        public IList<Weapon> Weapons => new List<Weapon>(_weapons);

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