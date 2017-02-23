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
            var sword = new {HitPower = 3, Speed = 3, HandsToHold = 1};
            var swordPower = new {HitPower = 5, Speed = 4, HandsToHold = 1};
            var bo = new {HitPower = 5, Speed = 1, HandsToHold = 2};
            var nunchucks = new {HitPower = 1, Speed = 5, HandsToHold = 1};
            var sai = new {HitPower = 2, Speed = 4, HandsToHold = 1};
            var machineGun = new {HitPower = 1, Speed = 9, HandsToHold = 2};

            var leo = new
            {
                Arms = 2,
                Weapons = new List<object> {sword, sword},
                Strength = 4,
                Endurance = 4,
                Attack = 4
            };

            var mike = new
            {
                Arms = 2,
                Weapons = new List<object> {nunchucks, nunchucks},
                Strength = 4,
                Endurance = 4,
                Attack = 4
            };

            var raph = new
            {
                Arms = 2,
                Weapons = new List<object> {sai, sai},
                Strength = 4,
                Endurance = 4,
                Attack = 4
            };

            var don = new
            {
                Arms = 2,
                Weapons = new List<object> {bo},
                Strength = 4,
                Endurance = 4,
                Attack = 4
            };

            var shredder = new
            {
                Arms = 2,
                Weapons = new List<object> { swordPower },
                Strength = 8,
                Endurance = 9,
                Attack = 7
            };

            var bebop = new
            {
                Arms = 2,
                Weapons = new List<object> { machineGun },
                Strength = 7,
                Endurance = 6,
                Attack = 6
            };

            var rockSteady = new
            {
                Arms = 2,
                Weapons = new List<object> { machineGun },
                Strength = 8,
                Endurance = 6,
                Attack = 7
            };
        }
    }
}