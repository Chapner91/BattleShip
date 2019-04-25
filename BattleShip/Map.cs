using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
	class Map
	{
		public int Dimension { get; }


		public Map(int dimension)
		{
			Dimension = dimension;
		}

		public bool IsOnMap(Point point)
		{
			return 
				point.X < this.Dimension &&
				point.X >= 0 &&
				point.Y < this.Dimension &&
				point.Y >= 0;
		}

	}
}
