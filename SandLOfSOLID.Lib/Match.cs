using System;
using System.Collections.Generic;

namespace SandLOfSOLID.Lib
{
	public class Match
	{
		private List<Fighter> _fighters;
        
		public Match()
		{
			_fighters = new List<Fighter>();
		}

		public List<Fighter> Fighters
		{
			get { return _fighters; }
		}

		public void AddFighter(Fighter fighter)
		{
			_fighters.Add(fighter);
		}

        public IFighter Stage(IFighter fighter1, IFighter fighter2)
        {
            var newChar = Hit(fighter1, fighter2);

            var fighters = new[] { fighter1, newChar };

            Array.Sort(fighters, new FighterHealthComparer());

            return fighters[0];

        }

	    public IFighter Hit(IFighter attackingCharcter, IFighter defendingCharacter)
	    {
	        var fighter = new Fighter
	        {
	            Attack = defendingCharacter.Attack,
	            Endurance = defendingCharacter.Endurance - attackingCharcter.Damage(),
	            Arms = defendingCharacter.Arms,
	            Strength = defendingCharacter.Strength
	        };

	        if (defendingCharacter.Weapons != null)
	        {
                foreach (var defendingCharacterWeapon in defendingCharacter.Weapons)
                {
                    fighter.AddWeapon(defendingCharacterWeapon);
                }
            }


	        fighter.Endurance =- attackingCharcter.Damage();

            return fighter;

	    }


    }

    public class FighterHealthComparer : IComparer<IFighter>
    {
        public int Compare(IFighter x, IFighter y)
        {
            return Math.Min(x.Endurance, y.Endurance);
        }
    }
}