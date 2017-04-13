using System.Collections.Generic;

namespace TheAllInOne
{
    /// <summary>
    /// SOLID Round 1!
    /// Create a new Library that breaks out these below int classes using Single Object Responsiblity and Liskov Substitution Principal
    /// 1. make these things!
    /// 2. weapons should be able to added to a character. Note... HandToHold says how many they can have too
    /// 3. you should be able to remove weapons too.
    /// 4. Create a fight method that allows you to match them up (2 players at a time... like Mortal Kombat)
    /// 5. fight method should be able to take account weapon info and character info... basics of strength from both.
    /// Bonus using all the characteristics of the weapons and characters to determine the winner (HitPower {Speed of the attack}, Strength, ENdurance, Attack {their default character Power}
    /// 
    /// SOLID Rount 2!
    /// Interface segregation. It allows one object to be represented as multiple things. In the example here, hopefully you see a few come from this.
    /// 1. It has been started, but Implement IDamage
    ///     a. should include the Damage method (which should change to Inflict)
    ///     b. Draining method called Inflict. It should pass in IDamage item. This method should be what drains the fighter's endurance.
    /// 2. Implement new weapons... a laser and a machine gun. (follow up if Liskov)
    ///     a. laser is a more powerful weapon, that can only fire if it has enough charge, which can store up to 5 charges max (each fire subtracts 1)
    ///     b. machine gun can only fire if it has bullets in its magazine clip, which can store up to 500 bullets (each fire subtracts 25 bullets)
    ///     c. both weapons can have an alternative hit, which for now is a lesser impacting blow
    ///     d. guns should be able to add ammo/power up and also subtract
    ///     e. hints... guns will probably have an interface too
    /// 3. This time around, create the actual characters and the weapons:
    ///     c.Raphael
    ///     c.Michaelangelo
    ///     c.Donnatello
    ///     c.Leonardo
    ///     c.Bebop
    ///     c.Rocksteady
    ///     w.sword
    ///     w.sai
    ///     w.bo
    ///     w.nunchaku
    ///     w.laser
    ///     w.machine gun
    ///  4. update the match file to use IDamage for the actual hit method.
    ///     a. note, this will change the strategy from the fighters being immutable to being mutable... no worries! :)
    /// </summary>
    public class TheExamplesThatAreNeverReferenced
    {
        public void Fight()
        {
            var sword = new { HitPower = 3, Speed = 3, HandsToHold = 1 };
            var swordPower = new { HitPower = 5, Speed = 4, HandsToHold = 1 };
            var bo = new { HitPower = 5, Speed = 1, HandsToHold = 2 };
            var nunchucks = new { HitPower = 1, Speed = 5, HandsToHold = 1 };
            var sai = new { HitPower = 2, Speed = 4, HandsToHold = 1 };
            var machineGun = new { HitPower = 1, Speed = 9, HandsToHold = 2 };
            var laserGun = new { HitPower = 4, Speed = 3, HandsToHold = 2 };
            

            var leo = new
            {
                Arms = 2,
                Weapons = new List<object> { sword, sword },
                Strength = 4,
                Endurance = 4,
                Attack = 4
            };

            var mike = new
            {
                Arms = 2,
                Weapons = new List<object> { nunchucks, nunchucks },
                Strength = 4,
                Endurance = 4,
                Attack = 4
            };

            var raph = new
            {
                Arms = 2,
                Weapons = new List<object> { sai, sai },
                Strength = 4,
                Endurance = 4,
                Attack = 4
            };

            var don = new
            {
                Arms = 2,
                Weapons = new List<object> { bo },
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
                Weapons = new List<object> { laserGun },
                Strength = 8,
                Endurance = 6,
                Attack = 7
            };
        }
    }
}
