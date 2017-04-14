using System;
using System.Collections.Generic;

namespace SOLID.Lib
{
    public class FighterHealthComparer : IComparer<IFighter>
    {
        public int Compare(IFighter x, IFighter y)
        {
            return Math.Min(x.Endurance, y.Endurance);
        }
    }
}