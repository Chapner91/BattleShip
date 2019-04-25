using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
	class Point
	{
		public int X { get; }
		public int Y { get; }

		/// <summary>
		/// constructor for a new point
		/// </summary>
		/// <param name="x">INT - the X coordinate of the point</param>
		/// <param name="y">INT - the Y coordinate of the point</param>
		public Point(int x, int y)
		{
			X = x;
			Y = y;
		}

		/// <summary>
		/// returns true if the point passed in has the same coordinates as the point calling IsEqual
		/// </summary>
		/// <param name="point">a point object to compare coordinates with</param>
		/// <returns></returns>
		public bool Equals(Point point)
		{
			return 
				point.X == X &&
				point.Y == Y;
		}
	}
}
