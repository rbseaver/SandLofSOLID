using System;
using System.Collections.Generic;

namespace SandLOfSOLID.Lib
{
	internal class Match
	{
		private List<Fighter> _fighters = new List<Fighter>();

		public Match()
		{
		}

		public List<Fighter> Fighters
		{
			get { return _fighters; }
			set { _fighters = value; }
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