using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
	class Ship
	{
		public ShipPart[] ShipParts { get; private set;}
		private readonly int _size;
	
		public Ship(string name, int size, Map map, Point initialPoint, string direction)
		{
			Name = name;
			ShipPart[] shipParts = new ShipPart[size];

			int x = initialPoint.X;
			int y = initialPoint.Y;

			if (direction.ToLower() == "+x")
			{
				for(int i = 0; i < size; i++)
				{
					shipParts[i] = new ShipPart(x, y, map);
					x++;
				}
			} else if (direction.ToLower() == "+y")
			{
				for (int i = 0; i < size; i++)
				{
					shipParts[i] = new ShipPart(x, y, map);
					y++;
				}
			}
			else if (direction.ToLower() == "-x")
			{
				for (int i = 0; i < size; i++)
				{
					shipParts[i] = new ShipPart(x, y, map);
					x--;
				}
			}
			else if (direction.ToLower() == "-y")
			{
				for (int i = 0; i < size; i++)
				{
					shipParts[i] = new ShipPart(x, y, map);
					y--;
				}
			} else 
			{
				throw new BattleShip.Exceptions.ShipException(direction + " is not a valid direction. Valid directions include '+x', '+y', '-x', '-y'");
			}

		}

		public string Name { get; }
		public bool IsSunk 
		{
			get 
			{ 
				foreach(ShipPart shipPart in ShipParts)
				{
					if (!shipPart.IsHit)
					{
						return false;
					}
				}

				return true;
			} 
		}



	}
}
