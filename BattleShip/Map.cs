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

		/// <summary>
		/// constructor for a new map
		/// </summary>
		/// <param name="dimension">this int is the length of the x and y axis of the map</param>
		public Map(int dimension)
		{
			Dimension = dimension;
		}

		/// <summary>
		/// returns true if the Point is within the boundaries of the Map
		/// </summary>
		/// <param name="point">The point object being to check</param>
		/// <returns></returns>
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

					mapString += "[ - ] ";
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
