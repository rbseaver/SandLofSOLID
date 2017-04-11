using System.Collections.Generic;

namespace SandLOfSOLID.Lib
{
    public interface IFighter
    {
        int Arms { get; set; }
        int Attack { get; set; }
        int Endurance { get; set; }
        int Strength { get; set; }
        IList<Weapon> Weapons { get; }

        void AddWeapon(Weapon weapon);
        int Damage();
        void RemoveWeapon(Weapon weapon);
    }
}