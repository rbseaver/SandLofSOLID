using System;
using System.Collections.Generic;

namespace SandLOfSOLID.Lib
{
	internal class Match
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

		public void Fight()
		{
			throw new NotImplementedException("need fighters to do shtuff");
		}
	}
}