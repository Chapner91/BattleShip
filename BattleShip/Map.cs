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
				point.X < Dimension &&
				point.X >= 0 &&
				point.Y < Dimension &&
				point.Y >= 0;
		}

		public string PrintMap()
		{
			int x = 0;
			int y = 0;
			string mapString = "";

			while(x < Dimension)
			{
				while (y < Dimension)
				{

					mapString += "[ ? ] ";
					y++;
				}

				mapString += "\r\n";
				y = 0;
				x++;

			}

			return mapString;
		}

	}
}
